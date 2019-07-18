using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvaluationSolution.UI.Control
{
    public partial class ImageButton : UserControl
    {
        private Bitmap _icon;
        private Bitmap _iconHover;

        public ImageButton()
        {
            InitializeComponent();
        }

        public void Initialize(Bitmap icon, Bitmap iconHover)
        {
            InitializeComponent();
            Icon = icon;
            IconHover = iconHover;
            this.btn.BackgroundImage = Icon;
            this.btn.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            this.btn.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
        }

        #region Properties

        public string ButtonText
        {
            set { btn.Text = value; }
        }

        public Bitmap Icon
        {
            get
            {
                return _icon;
            }
            set
            {
                _icon = value;
                this.btn.BackgroundImage = Icon;
            }
        }

        public Bitmap IconHover
        {
            get
            {
                return _iconHover;
            }
            set
            {
                _iconHover = value;
                this.btn.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
                this.btn.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            }
        }

        public Button Button
        {
            get { return btn; }
            set { btn = value; }
        }

        public event EventHandler ButtonClick;

        #endregion

        #region Events

        void btn_MouseLeave(object sender, EventArgs e)
        {
            this.btn.BackgroundImage = Icon;
        }


        void btn_MouseEnter(object sender, EventArgs e)
        {
            this.btn.BackgroundImage = IconHover;
        }

        protected void btn_Click(object sender, EventArgs e)
        {
            if (this.ButtonClick != null)
                this.ButtonClick(this, e);
        }

        #endregion
    }
}
