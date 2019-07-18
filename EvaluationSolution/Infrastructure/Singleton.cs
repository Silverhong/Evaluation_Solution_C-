using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluationSolution.Infrastructure
{
    public class Singleton
    {
        private static Singleton singleton;
        private static ContainerManager container;
        public ContainerManager Container
        {
            get
            {
                return container;
            }
        }
        public static Singleton Instance
        {
            get
            {
                if (singleton == null)
                    singleton = new Singleton();
                if (container == null)
                    container = new ContainerManager();
                return singleton;
            }

        }
    }
}
