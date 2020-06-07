using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;

namespace PersonalTracking
{
    public partial class FrmPosition : Form
    {
        List<DEPARTMENT> departmentList = new List<DEPARTMENT>();

        public FrmPosition()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmPosition_Load(object sender, EventArgs e)
        {
            departmentList = DepartmentBLL.GetDepartments();
            cmbDepartment.DataSource = departmentList;
            cmbDepartment.DisplayMember = "DepartmentName";
            cmbDepartment.ValueMember = "ID";
            cmbDepartment.SelectedIndex = -1;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtPosition.Text.Trim() == "")
            {
                MessageBox.Show("Please fill the position name");
            }else if(cmbDepartment.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a department");
            }
            else
            {
                POSITION position = new POSITION();
                position.DepartmentID = Convert.ToInt32(cmbDepartment.SelectedValue);
                position.PositionName = txtPosition.Text;
                PositionBLL.addPosition(position);
                MessageBox.Show("Position added");
                txtPosition.Clear();
                cmbDepartment.SelectedIndex = -1;
            }
        }
    }
}
