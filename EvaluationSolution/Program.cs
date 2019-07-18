using EvaluationSolution.Infrastructure;
using EvaluationSolution.UI.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvaluationSolution
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DependencyRegister register = new DependencyRegister();
            //var mainForm = Singleton.Instance.Container.Resolve<MainForm>();
            Application.Run(new MainForm());
        }
    }
}
