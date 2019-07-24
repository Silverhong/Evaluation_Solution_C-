using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvaluationSolution.Infrastructure
{
    public class ConditionSetting:IDisposable
    {
        public ConditionSetting()
        {

        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public bool isInput(params TextBox[] textBox)
        {
            foreach(var obj in textBox)
            {
                if (obj.Text.Length == 0)
                    return false;
            }
            return true;
        }
    }
}
