using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject.Modules;

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
    }
}
