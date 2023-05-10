using Autofac;
using PCI.KittingApp.Repository.Opcenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace PCI.KittingApp.Repository
{
    public class RepositoryModule : Module
    {
        protected override void Load(ContainerBuilder moduleBuilder)
        {
            moduleBuilder.RegisterType<MaintenanceTransaction>().AsSelf();
            moduleBuilder.RegisterType<ContainerTransaction>().AsSelf();
            moduleBuilder.RegisterType<MaintenanceMapper>().AsSelf();
        }
    }
}
