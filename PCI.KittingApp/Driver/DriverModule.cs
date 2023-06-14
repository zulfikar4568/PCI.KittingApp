using Autofac;
using PCI.KittingApp.Driver.Opcenter;
using PCI.KittingApp.Entity;
using PCI.KittingApp.Entity.Printer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace PCI.KittingApp.Driver
{
    public class DriverModule : Module
    {
        protected override void Load(ContainerBuilder moduleBuilder)
        {
            moduleBuilder.RegisterType<Helper>().AsSelf();
            moduleBuilder.RegisterType<MaintenanceTransaction>().AsSelf();
            moduleBuilder.RegisterType<ContainerTransaction>().AsSelf();
            moduleBuilder.RegisterType<SQLite.ReadWriteOperation<TransactionFailed>>().AsSelf();
            moduleBuilder.RegisterType<SQLite.ReadWriteOperation<PrintingLabel>>().AsSelf();
        }
    }
}
