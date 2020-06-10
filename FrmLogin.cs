using BLL;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalTracking
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void txtUserNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !General.isNumber(e);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserNo.Text.Trim() == "" || txtPassword.Text.Trim() == "")
                MessageBox.Show("Please fill the userNo and password");
            else
            {

                List<EMPLOYEE> listEmployee = EmployeeBLL.GetEmployees(Convert.ToInt32(txtUserNo.Text), txtPassword.Text);
                if (listEmployee.Count == 0)
                    MessageBox.Show("Please control you information");
                else
                {
                    EMPLOYEE employee = new EMPLOYEE();
                    employee = listEmployee.First();
                    UserStatic.EmployeeID = employee.ID;
                    UserStatic.UserNO = employee.UserNo;
                    UserStatic.isAdmin = employee.isAdmin;
                    FrmMain frm = new FrmMain();
                    this.Hide();
                    frm.ShowDialog();

                }
            }
        }
    }
}
