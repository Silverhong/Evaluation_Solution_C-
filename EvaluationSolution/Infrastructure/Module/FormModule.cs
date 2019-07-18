﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EvaluationSolution.UI.Forms;
using Ninject.Modules;
namespace EvaluationSolution.Infrastructure.Module
{
    public class FormModule : NinjectModule
    {
        public override void Load()
        {
            Bind<LoginForm>().ToSelf().InSingletonScope().Named("LoginForm");
            Bind<MainForm>().ToSelf().InSingletonScope().Named("MainForm");
        }
    }
}
