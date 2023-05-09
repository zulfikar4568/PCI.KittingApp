using Autofac;
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
            moduleBuilder.RegisterType<KittingApp.Driver.Opcenter.Helper>().AsSelf();
            moduleBuilder.RegisterType<KittingApp.Driver.Opcenter.MaintenanceTransaction>().AsSelf();
        }
    }
}
