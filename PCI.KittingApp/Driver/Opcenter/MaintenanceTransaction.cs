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
    public class MaintenanceTransaction
    {
        private readonly Helper _helper;
        public MaintenanceTransaction(Helper helper)
        {
            _helper = helper;
        }

        public RevisionedObjectChanges RevisionedObjectInfo(RevisionedObjectRef ObjectRevisionRef, RevisionedObjectChanges_Info ObjectChanges, bool IgnoreException = true)
        {
            RevisionedObjectMaintService oService = null;
            try
            {
                oService = new RevisionedObjectMaintService(AppSettings.ExCoreUserProfile);
                RevisionedObjectMaint oServiceObject = new RevisionedObjectMaint();
                oServiceObject.ObjectToChange = ObjectRevisionRef;
                RevisionedObjectMaint_Request oServiceRequest = new RevisionedObjectMaint_Request();
                oServiceRequest.Info = new RevisionedObjectMaint_Info();
                oServiceRequest.Info.ObjectChanges = ObjectChanges;

                ResultStatus oResultStatus = oService.Load(oServiceObject, oServiceRequest, out RevisionedObjectMaint_Result oServiceResult);

                EventLogUtil.LogEvent(oResultStatus.Message, System.Diagnostics.EventLogEntryType.Information, 3);
                if (oServiceResult.Value.ObjectChanges != null)
                {
                    return oServiceResult.Value.ObjectChanges;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                ex.Source = AppSettings.AssemblyName == ex.Source ? MethodBase.GetCurrentMethod().Name : MethodBase.GetCurrentMethod().Name + "." + ex.Source;
                EventLogUtil.LogErrorEvent(ex.Source, ex);
                if (!IgnoreException) throw ex;
                return null;
            }
            finally
            {
                if (!(oService is null)) oService.Close();
            }
        }
        public NamedDataObjectChanges NamedDataObjectInfo(NamedObjectRef ObjectRef, bool IgnoreException = true)
        {
            NamedDataObjectMaintService oService = null;
            try
            {
                oService = new NamedDataObjectMaintService(AppSettings.ExCoreUserProfile);
                NamedDataObjectMaint oServiceObject = new NamedDataObjectMaint();
                oServiceObject.ObjectToChange = ObjectRef;

                NamedDataObjectMaint_Request oServiceRequest = new NamedDataObjectMaint_Request();
                oServiceRequest.Info = new NamedDataObjectMaint_Info();
                oServiceRequest.Info.ObjectChanges = new NamedDataObjectChanges_Info();
                oServiceRequest.Info.ObjectChanges.RequestValue = true;

                NamedDataObjectMaint_Result oServiceResult = null;
                ResultStatus oResultStatus = oService.Load(oServiceObject, oServiceRequest, out oServiceResult);

                string sMessage = "";
                if (_helper.ProcessResult(oResultStatus, ref sMessage, true))
                {
                    EventLogUtil.LogEvent(oResultStatus.Message, System.Diagnostics.EventLogEntryType.Information, 3);
                    return oServiceResult.Value.ObjectChanges;
                }
                else
                {
                    EventLogUtil.LogEvent($"{ObjectRef.Name} doesn't exists!", System.Diagnostics.EventLogEntryType.Warning, 3);
                    return null;
                }
            }
            catch (Exception ex)
            {
                ex.Source = AppSettings.AssemblyName == ex.Source ? MethodBase.GetCurrentMethod().Name : MethodBase.GetCurrentMethod().Name + "." + ex.Source;
                EventLogUtil.LogErrorEvent(ex.Source, ex);
                if (!IgnoreException) throw ex;
                return null;
            }
            finally
            {
                if (!(oService is null)) oService.Close();
            }
        }
        public NamedObjectRef[] MfgOrderInfo(bool IgnoreException = true)
        {
            MfgOrderMaintService oService = null;
            try
            {
                oService = new MfgOrderMaintService(AppSettings.ExCoreUserProfile);
                MfgOrderMaint oServiceObject = new MfgOrderMaint();

                MfgOrderMaint_Request oServiceRequest = new MfgOrderMaint_Request();
                oServiceRequest.Info = new MfgOrderMaint_Info();
                oServiceRequest.Info.ObjectListInquiry = new Info(true);
                oServiceRequest.Info.ObjectListInquiry.RequestValue = true;

                MfgOrderMaint_Result oServiceResult = null;
                ResultStatus oResultStatus = oService.GetEnvironment(oServiceRequest, out oServiceResult);

                EventLogUtil.LogEvent(oResultStatus.Message, System.Diagnostics.EventLogEntryType.Information, 3);
                string sMessage = "";
                if (_helper.ProcessResult(oResultStatus, ref sMessage, true))
                {
                    return oServiceResult.Value.ObjectListInquiry;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                ex.Source = AppSettings.AssemblyName == ex.Source ? MethodBase.GetCurrentMethod().Name : MethodBase.GetCurrentMethod().Name + "." + ex.Source;
                EventLogUtil.LogErrorEvent(ex.Source, ex);
                if (!IgnoreException) throw ex;
                return null;
            }
            finally
            {
                if (!(oService is null)) oService.Close();
            }
        }
        public bool NamedDataObjectTxn(NamedDataObjectChanges ObjectChanges, bool IgnoreException = true)
        {
            NamedDataObjectMaintService oService = null;
            try
            {
                NamedDataObjectMaint oServiceObject = null;

                //Check Object exists
                oService = new NamedDataObjectMaintService(AppSettings.ExCoreUserProfile);
                EventLogUtil.LogEvent($"Checking {ObjectChanges.GetType().Name} " + ObjectChanges.Name, System.Diagnostics.EventLogEntryType.Information, 2);
                bool bObjectExists = _helper.ObjectExists(oService, new NamedDataObjectMaint(), ObjectChanges.Name.ToString());

                //Prepare Object
                EventLogUtil.LogEvent($"Preparing {ObjectChanges.GetType().Name} " + ObjectChanges.Name, System.Diagnostics.EventLogEntryType.Information, 2);
                oServiceObject = new NamedDataObjectMaint();
                if (bObjectExists)
                {
                    oServiceObject.ObjectToChange = new NamedObjectRef(ObjectChanges.Name.ToString());
                    oService.BeginTransaction();
                    oService.Load(oServiceObject);
                }

                //Prepare Input Data
                oServiceObject = new NamedDataObjectMaint();
                oServiceObject.ObjectChanges = ObjectChanges;

                //Save Data
                if (bObjectExists)
                {
                    EventLogUtil.LogEvent($"Updating {ObjectChanges.GetType().Name} " + ObjectChanges.Name.ToString(), System.Diagnostics.EventLogEntryType.Information, 2);
                    oService.ExecuteTransaction(oServiceObject);
                }
                else
                {
                    EventLogUtil.LogEvent($"Creating {ObjectChanges.GetType().Name} " + ObjectChanges.Name.ToString(), System.Diagnostics.EventLogEntryType.Information, 2);
                    oService.BeginTransaction();
                    oService.New(oServiceObject);
                    oService.ExecuteTransaction();
                }
                string sMessage = "";
                bool statusNamedDataObject = _helper.ProcessResult(oService.CommitTransaction(), ref sMessage, false);
                EventLogUtil.LogEvent(sMessage, System.Diagnostics.EventLogEntryType.Information, 2);
                return statusNamedDataObject;
            }
            catch (Exception ex)
            {
                ex.Source = AppSettings.AssemblyName == ex.Source ? MethodBase.GetCurrentMethod().Name : MethodBase.GetCurrentMethod().Name + "." + ex.Source;
                EventLogUtil.LogErrorEvent(ex.Source, ex);
                if (!IgnoreException) throw ex;
                return false;
            }
            finally
            {
                if (oService != null) oService.Close();
            }
        }
        public bool RevisionedObjectTxn(RevisionedObjectChanges ObjectChanges, bool IgnoreException = true)
        {
            RevisionedObjectMaintService oService = null;
            try
            {
                RevisionedObjectMaint oServiceObject = null;
                // CheckObject Exists
                oService = new RevisionedObjectMaintService(AppSettings.ExCoreUserProfile);
                EventLogUtil.LogEvent($"Checking {ObjectChanges.GetType().Name} {ObjectChanges.Name} : {ObjectChanges.Revision}", System.Diagnostics.EventLogEntryType.Information, 3);
                bool bBaseExists = _helper.ObjectExists(oService, new RevisionedObjectMaint(), ObjectChanges.Name.ToString(), "");
                bool bObjectExists = _helper.ObjectExists(oService, new RevisionedObjectMaint(), ObjectChanges.Name.ToString(), ObjectChanges.Revision.ToString());
                // Prepare Object
                EventLogUtil.LogEvent($"Preparing {ObjectChanges.GetType().Name} {ObjectChanges.Name} : {ObjectChanges.Revision}", System.Diagnostics.EventLogEntryType.Information, 3);
                oServiceObject = new RevisionedObjectMaint();
                if (bObjectExists)
                {
                    oServiceObject.ObjectToChange = new RevisionedObjectRef(ObjectChanges.Name.ToString(), ObjectChanges.Revision.ToString());
                    oService.BeginTransaction();
                    oService.Load(oServiceObject);
                }
                else if (bBaseExists)
                {
                    oService.BeginTransaction();
                    oServiceObject.BaseToChange = new RevisionedObjectRef();
                    oServiceObject.BaseToChange.Name = ObjectChanges.Name.ToString();
                    oService.NewRev(oServiceObject);
                }
                // PrepareInput Data
                oServiceObject = new RevisionedObjectMaint();
                oServiceObject.ObjectChanges = ObjectChanges;

                // Save the Data
                if (bObjectExists)
                {
                    EventLogUtil.LogEvent($"Updating {ObjectChanges.GetType().Name} {ObjectChanges.Name} : {ObjectChanges.Revision}", System.Diagnostics.EventLogEntryType.Information, 3);
                    oService.ExecuteTransaction(oServiceObject);
                }
                else if (bBaseExists)
                {
                    EventLogUtil.LogEvent($"Creating {ObjectChanges.GetType().Name} {ObjectChanges.Name} : {ObjectChanges.Revision}", System.Diagnostics.EventLogEntryType.Information, 3);
                    oService.ExecuteTransaction(oServiceObject);
                }
                else
                {
                    EventLogUtil.LogEvent($"Creating {ObjectChanges.GetType().Name} {ObjectChanges.Name} : {ObjectChanges.Revision}", System.Diagnostics.EventLogEntryType.Information, 3);
                    oService.BeginTransaction();
                    oService.New(oServiceObject);
                    oService.ExecuteTransaction();
                }
                string sMessage = "";
                bool statusRevisionedObject = _helper.ProcessResult(oService.CommitTransaction(), ref sMessage, false);
                EventLogUtil.LogEvent(sMessage, System.Diagnostics.EventLogEntryType.Information, 2);
                return statusRevisionedObject;
            }
            catch (Exception ex)
            {
                ex.Source = AppSettings.AssemblyName == ex.Source ? MethodBase.GetCurrentMethod().Name : MethodBase.GetCurrentMethod().Name + "." + ex.Source;
                EventLogUtil.LogErrorEvent(ex.Source, ex);
                if (!IgnoreException) throw ex;
                return false;
            }
            finally
            {
                if (oService != null) oService.Close();
            }
        }
    }
}
