using EvaluationSolution.Infrastructure;
using EvaluationSolution.Infrastructure.Module;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluationSolution
{
    public class DependencyRegister
    {
        public DependencyRegister()
        {
            Singleton.Instance.Container.Initializer(new ViewModule());
            Singleton.Instance.Container.Initializer(new FormModule());
        }
    }
}
