using iLAB.Controllers;
using iLAB.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iLAB.Views
{
    public partial class fLogin : MetroFramework.Forms.MetroForm
    {
        public fLogin()
        {
            InitializeComponent();
        }

        #region Methods

        private bool isValidAccount()
        {
            Employee e = EmployeeController.GetEmployeeByID(Global.Account.ID);

            if (e != null)
            {
                if (e.PassWord != Global.Account.PassWord)
                {
                    MessageBox.Show("Sai mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (e.Position != Global.Account.Position)
                {
                    MessageBox.Show("Sai vị trí!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                Global.Account = e;
                return true;
            }
            else
            {
                MessageBox.Show("Tài khoản không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        #endregion

        private void ml_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            Global.Account = new Employee();
            Global.Account.ID = tbx_UserName.Text;
            Global.Account.PassWord = tbx_PassWord.Text;

            if (rb_Manager.Checked)
            {
                Global.Account.Position = "Quản lý";
            }
            else if (rb_Employee.Checked)
            {
                Global.Account.Position = "Nhân viên";
            }

            if (!isValidAccount())
            {
                return;
            }

            f_Main f = new f_Main();

            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void mtl_Register_Click(object sender, EventArgs e)
        {
            
        }
    }
}
