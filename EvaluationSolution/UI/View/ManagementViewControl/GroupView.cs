using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EvaluationSolution.Entity;
using EvaluationSolution.Infrastructure;

namespace EvaluationSolution.UI.View.ManagementViewControl
{
    public partial class GroupView : MainView
    {
        List<VGroup> listGroup;
        public GroupView()
        {
            InitializeComponent();
            listGroup = new List<VGroup>();
        }
        public override void Init()
        {
            string url = ApiRouting.GetUrl("", "", "usergroup", ApiFunction.GetAll).ToString();
            bool confirm = url.Get<VGroup>(ref listGroup);
            if (confirm)
                dataGridMain.DataSource = listGroup;
            else
                MessageBox.Show("Cannot connect to server!", "Error");
        }

        private void BtnAddGroup_Click(object sender, EventArgs e)
        {
            AddGroup addGroup = new AddGroup();
            addGroup.ShowDialog();
        }

        private void BtnGroup_Click(object sender, EventArgs e)
        {

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            int index = dataGridMain.CurrentCell.RowIndex;
            string id = dataGridMain.Rows[index].Cells[0].Value.ToString();
            VGroup group = new VGroup()
            {
                UserGroupID = id,
                Name = ""
            };
            string queryString = group.GetQueryString<VGroup>();
            string url = ApiRouting.GetUrl("", "", "usergroup", ApiFunction.DeleteById).ToString() + queryString;
            bool confirm = url.Detete<VGroup>();
            if (confirm)
            {
                MessageBox.Show("Delete Succesful", "Success");
                Init();
            }
        }
    }
}
