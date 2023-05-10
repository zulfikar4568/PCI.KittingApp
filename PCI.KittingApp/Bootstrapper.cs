using Autofac;
using PCI.KittingApp.Config;
using PCI.KittingApp.Forms;
using PCI.KittingApp.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PCI.KittingApp
{
    public static class Bootstrapper
    {
        public static ContainerBuilder DependencyInjectionBuilder(ContainerBuilder containerBuilder)
        {
            containerBuilder.RegisterModule(new UtilModule());
            containerBuilder.RegisterModule(new Driver.DriverModule());
            containerBuilder.RegisterModule(new Repository.RepositoryModule());
            containerBuilder.RegisterModule(new UseCase.UseCaseModule());
            containerBuilder.RegisterModule(new FormModule());
            containerBuilder.RegisterType<Main>().AsSelf();

            return containerBuilder;
        }

        public static bool CheckConnection()
        {
            using (TcpClient tcpClient = new TcpClient())
            {
                try
                {
                    tcpClient.Connect(AppSettings.ExCoreHost, Convert.ToInt32(AppSettings.ExCorePort));
                    return true;
                }
                catch (Exception ex)
                {
                    EventLogUtil.LogErrorEvent(AppSettings.AssemblyName == ex.Source ? MethodBase.GetCurrentMethod().Name : MethodBase.GetCurrentMethod().Name + "." + ex.Source, ex);
                    return false;
                }
            }
        }
    }
}
