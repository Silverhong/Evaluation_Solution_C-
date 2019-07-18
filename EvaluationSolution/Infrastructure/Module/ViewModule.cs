using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EvaluationSolution.UI.View;
using EvaluationSolution.UI.View.ManagementViewControl;
using EvaluationSolution.UI.View.SettingViewControl;
using EvaluationSolution.UI.View.SettingViewControl.Evaluation;
using EvaluationSolution.UI.View.DailyActivity;
using Ninject.Modules;

namespace EvaluationSolution.Infrastructure.Module
{
    public class ViewModule : NinjectModule
    {
        public override void Load()
        {
            Bind<MainView>().To<ManagementView>().InSingletonScope().Named("management");
            Bind<MainView>().To<StaffView>().InSingletonScope().Named("staff");
            Bind<MainView>().To<DepartmentView>().InSingletonScope().Named("department");
            Bind<MainView>().To<OfficeView>().InSingletonScope().Named("office");
            Bind<MainView>().To<SettingView>().InSingletonScope().Named("setting");
            Bind<MainView>().To<UserAccount>().InSingletonScope().Named("user account");
            Bind<MainView>().To<UserRole>().InSingletonScope().Named("user role");
            Bind<MainView>().To<EvaluationManagement>().InSingletonScope().Named("evaluation management");
            Bind<MainView>().To<EvaluationQuestion>().InSingletonScope().Named("evaluation question");
            Bind<MainView>().To<EvaluationType>().InSingletonScope().Named("evaluation type");
            Bind<MainView>().To<EvaluationView>().InSingletonScope().Named("evaluation");
            Bind<MainView>().To<DailyActivityView>().InSingletonScope().Named("daily activity");
            Bind<MainView>().To<EvaluationScore>().InSingletonScope().Named("evaluation score");
        }
    }
}
