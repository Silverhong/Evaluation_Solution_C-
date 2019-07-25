using EvaluationSolution.Entity;
using EvaluationSolution.Infrastructure;
using MetroFramework.Forms;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvaluationSolution.UI.View.ManagementViewControl
{
    public partial class AddStaffForm : MetroForm
    {
        List<VDepartment> listDepartment;
        List<VOffice> listOffice;
        List<VPosition> listPosition;
        List<VUsergroup> listUserGroup;
        public AddStaffForm()
        {
            InitializeComponent();
            listDepartment = new List<VDepartment>();
            listOffice = new List<VOffice>();
            listPosition = new List<VPosition>();
            listUserGroup = new List<VUsergroup>();
            ApiRouting.GetUrl("", "", "department", ApiFunction.GetAll).ToString().Get<VDepartment>(ref listDepartment);
            ApiRouting.GetUrl("", "", "office", ApiFunction.GetAll).ToString().Get<VOffice>(ref listOffice);
            ApiRouting.GetUrl("", "", "position", ApiFunction.GetAll).ToString().Get<VPosition>(ref listPosition);
            ApiRouting.GetUrl("", "", "usergroup", ApiFunction.GetAll).ToString().Get<VUsergroup>(ref listUserGroup);
            comboDepartment.DataSource = listDepartment.Select(x => x.Deptname).ToList();
            comboOffice.DataSource = listOffice.Select(x => x.OfficeName).ToList();
            comboGroup.DataSource = listUserGroup.Select(x => x.Name).ToList();
            comboPosition.DataSource = listPosition.Select(x => x.Pname).ToList();
        }
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            btnSubmit.DialogResult = DialogResult.OK;
            if (MessageBox.Show("Do you want to cancel the recruitment ?", "Staff Recruitment").DialogResult == DialogResult.OK)
            {
                this.Dispose();
            }
        }

        private void BtnAddNew_Click(object sender, EventArgs e)
        {
            if (AddStaff())
            {
                Dispose();
                AddStaffForm addStaff = new AddStaffForm();
                addStaff.ShowDialog();
            }
        }

        private void ComboDepartment_SelectedValueChanged(object sender, EventArgs e)
        {
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            if (AddStaff())
                Dispose();
        }
        private bool AddStaff()
        {
            string name = txtName.Text.Trim();
            string sex = comboGender.SelectedItem.ToString();
            string dob = dtDOB.Value.ToShortDateString();
            string address = txtAddress.Text.Trim();
            string phone = txtPhone.Text.Trim();
            string email = txtEmail.Text.Trim();
            string deptName = comboDepartment.SelectedItem.ToString();
            string deptId = listDepartment.Where(x => x.Deptname == deptName).Select(x => x.DeptId).FirstOrDefault();
            string officeName = comboOffice.SelectedItem.ToString();
            string officeId = listOffice.Where(x => x.OfficeName == officeName).Select(x => x.OfficeId).FirstOrDefault();
            string position = comboPosition.SelectedItem.ToString();
            string positionId = listPosition.Where(x => x.Pname == position).Select(x => x.Pid).FirstOrDefault();
            string group = comboGroup.SelectedItem.ToString();
            string groupId = listUserGroup.Where(x => x.Name == group).Select(x => x.UserGroupID).FirstOrDefault();
            Staff staff = new Staff()
            {
                CreatedBy = GlobalVariable.LoginStaffName,
                CurrentAddress = address,
                DeptID = deptId,
                Dob = dob,
                Email = email,
                OfficeId = officeId,
                Phone = phone,
                Pid = positionId,
                Pob = address,
                SName = name,
                Sex=sex,
                UserGroupID = groupId,
                StaffId = ""
            };
            string json = JsonConvert.SerializeObject(staff);
            string url = ApiRouting.GetUrl("", "", "staff", ApiFunction.Add).ToString();
            bool confirm = url.Post<Staff>(json);
            if (confirm)
            {
                MessageBox.Show("Staff Added Successful", "Successful");
                var objStaff = Singleton.Instance.Container.Resolve<MainView>("staff");
                objStaff.Init();
                return true;
            }
            return false;
        }
    }
}
