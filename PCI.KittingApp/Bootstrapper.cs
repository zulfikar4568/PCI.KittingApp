using Autofac;
using Autofac.Extras.Quartz;
using PCI.KittingApp.Config;
using PCI.KittingApp.Forms;
using PCI.KittingApp.Util;
using Quartz.Logging;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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
            containerBuilder.RegisterType<Scheduler>().AsSelf();

            // configure and register Quartz
            var schedulerConfig = new NameValueCollection {
                { "quartz.scheduler.instanceName", "MyScheduler" },
                { "quartz.jobStore.type", "Quartz.Simpl.RAMJobStore, Quartz" },
                { "quartz.threadPool.threadCount", "3" }
            };

            // Log for Quartz
            LogProvider.SetCurrentLogProvider(new Job.ConsoleLogProvider());

            containerBuilder.RegisterModule(new QuartzAutofacFactoryModule
            {
                ConfigurationProvider = ctx => schedulerConfig
            });

            containerBuilder.RegisterModule(new QuartzAutofacJobsModule(typeof(Job.CheckConnectionJob).Assembly));

            return containerBuilder;
        }

        public static bool CheckConnection()
        {
            using (TcpClient tcpClient = new TcpClient())
            {
                try
                {
                    if (tcpClient.ConnectAsync(AppSettings.ExCoreHost, Convert.ToInt32(AppSettings.ExCorePort)).Wait(TimeSpan.FromSeconds(3)))
                    {
                        return true;
                    } else
                    {
                        return false;
                    }
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
