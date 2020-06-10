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
using DAL.DTO;

namespace PersonalTracking
{
    public partial class FrmPermissionList : Form
    {
        PermissionDTO dto = new PermissionDTO();

        public FrmPermissionList()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            FrmPermission frm = new FrmPermission();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmPermission frm = new FrmPermission();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !General.isNumber(e);
        }

        private void txtUserNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !General.isNumber(e);
        }

        private void FrmPermissionList_Load(object sender, EventArgs e)
        {
            dto = PermissionBLL.GetAll();
        }
    }
}
