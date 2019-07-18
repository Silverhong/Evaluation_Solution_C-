using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvaluationSolution.UI
{
    public partial class MessageBox : MetroForm
    {
        private static MessageBox _message;
        public MessageBox()
        {
            InitializeComponent();
        }
        public static MessageBox Show(string message, string title = "")
        {
            if (_message == null || _message.IsDisposed) _message = new MessageBox();
            _message.lbContent.Text = message;
            _message.lbTitle.Text = title;
            _message.TopMost = true;
            _message.ShowDialog();
            _message.Dispose();
            return _message;
        }

        internal static bool Show(object staticmessage)
        {
            throw new NotImplementedException();
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            
        }
        private void BtnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
