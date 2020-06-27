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
    public partial class f_Salary : Form
    {
        public f_Salary()
        {
            InitializeComponent();

            cID.DataPropertyName = nameof(SalaryEmployee.IDEmp);
            c_Name.DataPropertyName = nameof(SalaryEmployee.NameEmp);
            cTotalHours.DataPropertyName = nameof(SalaryEmployee.TotalHours);
            cRewards.DataPropertyName = nameof(SalaryEmployee.Rewards);
            cTotalSalary.DataPropertyName = nameof(SalaryEmployee.TotalSalary);


            cb_Month.Text = DateTime.Now.Month.ToString();
            cb_Year.Text = DateTime.Now.Year.ToString();
        }

        private void ml_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cb_Month_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int i = Convert.ToInt32(cb_Month.Text);
            }
            catch
            {
                return;
            }

            try
            {
                SalaryController.CaculateSalaryByMY(Convert.ToInt32(cb_Month.Text), Convert.ToInt32(cb_Year.Text));

                List<SalaryEmployee> salaries = SalaryController.GetListSalary(Convert.ToInt32(cb_Month.Text), Convert.ToInt32(cb_Year.Text));
                if (salaries == null)
                {
                    MessageBox.Show("Không có dữ liệu");
                    return;
                }
                dtgv_Payroll.DataSource = salaries;
            }
            catch { }
        }

        private void cb_Year_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SalaryController.CaculateSalaryByMY(Convert.ToInt32(cb_Month.Text), Convert.ToInt32(cb_Year.Text));

                List<SalaryEmployee> salaries = SalaryController.GetListSalary(Convert.ToInt32(cb_Month.Text), Convert.ToInt32(cb_Year.Text));
                if (salaries == null)
                {
                    MessageBox.Show("Không có dữ liệu");
                    return;
                }
                dtgv_Payroll.DataSource = salaries;
            }
            catch { }
        }

        private void btn_SavetoExcel_Click(object sender, EventArgs e)
        {
            Global.ExportToExcel(dtgv_Payroll);
        }
    }
}
