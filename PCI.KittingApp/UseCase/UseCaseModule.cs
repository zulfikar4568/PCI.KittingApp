﻿using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCI.KittingApp.UseCase
{
    public class UseCaseModule : Module
    {
        protected override void Load(ContainerBuilder moduleBuilder)
        {
            moduleBuilder.RegisterType<Kitting>().AsSelf();
            moduleBuilder.RegisterType<OpcenterCheckData>().AsSelf();
            moduleBuilder.RegisterType<OpcenterSaveData>().AsSelf();
            moduleBuilder.RegisterType<TransactionFailed>().AsSelf();
            moduleBuilder.RegisterType<CheckConnection>().AsSelf();
            moduleBuilder.RegisterType<PrintingLabelUseCase>().AsSelf();
            moduleBuilder.RegisterType<UserUseCase>().AsSelf();
            moduleBuilder.RegisterType<SummaryUseCase>().AsSelf();
        }
    }
}
