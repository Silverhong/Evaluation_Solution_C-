using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject.Modules;
using EvaluationSolution.UI.View.SettingViewControl.Evaluation;

namespace EvaluationSolution.Infrastructure
{
    public class ContainerManager
    {
        private IKernel container;
        public void Initializer(INinjectModule module)
        {
            if (container == null)
                container = new StandardKernel(module);
            else
                container.Load(module);
        }
        public T Resolve<T>()
        {
            return container.Get<T>();
        }
        public T Resolve<T>(string name)
        {
            return container.Get<T>(name);
        }
        public void Dispose<T>()
        {
            container.Unbind<T>();
        }
        public void Bind<T>()
        {
            container.Bind<T>().ToSelf().InSingletonScope();
        }
        public bool GetBinding(string name)
        {
            var binding = container.GetBindings(typeof(AddEvaluation)).FirstOrDefault();
            return true;
        }
    }
}
