using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCI.KittingApp.Forms
{
    public class FormModule : Module
    {
        protected override void Load(ContainerBuilder moduleBuilder)
        {
            moduleBuilder.RegisterType<FormOrder>().AsSelf();
            moduleBuilder.RegisterType<FormMaterialRegistration>().AsSelf();
            moduleBuilder.RegisterType<FormUnitRegistration>().AsSelf();
            moduleBuilder.RegisterType<FormTransactionFailed>().AsSelf();
        }
    }
}
