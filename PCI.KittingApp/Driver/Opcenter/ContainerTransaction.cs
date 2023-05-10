using Camstar.WCF.ObjectStack;
using Camstar.WCF.Services;
using PCI.KittingApp.Config;
using PCI.KittingApp.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PCI.KittingApp.Driver.Opcenter
{
    public class ContainerTransaction
    {
        private readonly Helper _helper;
        public ContainerTransaction(Helper helper)
        {
            _helper = helper;
        }
        public ViewContainerStatus ContainerInfo(ViewContainerStatus_Info ContainerInfo, string ContainerName, bool IgnoreException = true)
        {
            string TxnId = Guid.NewGuid().ToString();
            ViewContainerStatusService oService = null;
            try
            {
                oService = new ViewContainerStatusService(AppSettings.ExCoreUserProfile);

                //Set input Data
                ViewContainerStatus oServiceObject = new ViewContainerStatus();
                oServiceObject.Container = new ContainerRef(ContainerName);
                ViewContainerStatus_Request oServiceRequest = new ViewContainerStatus_Request
                {
                    Info = ContainerInfo
                };

                //Request the Data
                ResultStatus oResultStatus = oService.ExecuteTransaction(oServiceObject, oServiceRequest, out ViewContainerStatus_Result oServiceResult);

                //Return Result
                string sMessage = "";
                bool processResult = _helper.ProcessResult(oResultStatus, ref sMessage, false);
                EventLogUtil.LogEvent(Logging.LoggingContainer(ContainerName, TxnId, sMessage), System.Diagnostics.EventLogEntryType.Information, 3);
                if (processResult)
                {
                    return oServiceResult.Value;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                ex.Source = AppSettings.AssemblyName == ex.Source ? MethodBase.GetCurrentMethod().Name : MethodBase.GetCurrentMethod().Name + "." + ex.Source;
                string exceptionMsg = Logging.LoggingContainer(ContainerName, TxnId, ex.Message);
                EventLogUtil.LogErrorEvent(ex.Source, exceptionMsg);
                if (!IgnoreException) throw ex;
                return null;
            }
            finally
            {
                if (!(oService is null)) oService.Close();
            }
        }
        public CurrentContainerStatus ContainerStatusInfo(ContainerTxn ServiceObject, string ContainerName, bool IgnoreException = true)
        {
            string TxnId = Guid.NewGuid().ToString();
            ContainerTxnService oService = null;
            try
            {
                oService = new ContainerTxnService(AppSettings.ExCoreUserProfile);

                //Set input Data
                ContainerTxn oServiceObject = ServiceObject;
                ContainerTxn_Request oServiceRequest = new ContainerTxn_Request();
                oServiceRequest.Info = new ContainerTxn_Info();
                oServiceRequest.Info.CurrentContainerStatus = new CurrentContainerStatus_Info();
                oServiceRequest.Info.CurrentContainerStatus.RequestValue = true;

                //Requets the Data
                ResultStatus oResultStatus = oService.GetEnvironment(oServiceObject, oServiceRequest, out ContainerTxn_Result oServiceResult);

                //Return Result
                string sMessage = "";
                bool processResult = _helper.ProcessResult(oResultStatus, ref sMessage, false);
                EventLogUtil.LogEvent(Logging.LoggingContainer(ContainerName, TxnId, sMessage), System.Diagnostics.EventLogEntryType.Information, 3);
                if (processResult)
                {
                    return oServiceResult.Value.CurrentContainerStatus;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                ex.Source = AppSettings.AssemblyName == ex.Source ? MethodBase.GetCurrentMethod().Name : MethodBase.GetCurrentMethod().Name + "." + ex.Source;
                string exceptionMsg = Logging.LoggingContainer(ContainerName, TxnId, ex.Message);
                EventLogUtil.LogErrorEvent(ex.Source, exceptionMsg);
                if (!IgnoreException) throw ex;
                return null;
            }
            finally
            {
                if (!(oService is null)) oService.Close();
            }
        }
    }
}
