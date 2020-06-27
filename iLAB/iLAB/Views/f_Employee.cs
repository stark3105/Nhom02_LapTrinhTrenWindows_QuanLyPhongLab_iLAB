using iLAB.Controllers;
using iLAB.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iLAB
{
    public partial class f_Employee : Form
    {
        public int rowIndex;
        public f_Employee()
        {
            InitializeComponent();

            //Khai báo nhân viên
            this.col_ID.DataPropertyName = nameof(Employee.ID);
            this.col_Name.DataPropertyName = nameof(Employee.Name);
            this.col_Position.DataPropertyName = nameof(Employee.Position);
            this.col_Major.DataPropertyName = nameof(Employee.Major);
            this.col_Birthday.DataPropertyName = nameof(Employee.Birthday);
            this.col_Phone.DataPropertyName = nameof(Employee.Phone);
            this.col_Email.DataPropertyName = nameof(Employee.Email);
            this.col_HourlyWages.DataPropertyName = nameof(Employee.HourlyWages);
            this.col_password.DataPropertyName = nameof(Employee.PassWord);
            this.col_Projects.DataPropertyName = nameof(Employee.Projects);
            this.col_Salaries.DataPropertyName = nameof(Employee.Salaries);
            this.col_Works.DataPropertyName = nameof(Employee.Works);
            this.col_Tasks.DataPropertyName = nameof(Employee.Tasks);
            this.col_Image.DataPropertyName = nameof(Employee.EmpImage);
        }

        #region Method
        public void ClearControls()
        {
            this.tbx_ID.Clear();
            this.tbx_Name.Clear();
            this.tbx_Position.Clear();
            this.tbx_Major.Clear();
            this.dateTimePicker1.ResetText();
            this.tbx_Phone.Clear();
            this.tbx_Email.Clear();
            this.tbx_HourlyWages.Clear();

            ptb_Avatar.Image = global::iLAB.Properties.Resources.ImgEmployee;
        }
        public bool isError(int status)
        {
            this.errorProvider1.Clear();
            bool error = false;

            if (this.tbx_ID.Text.Trim().Length <= 0)
            {
                this.errorProvider1.SetError(this.tbx_ID, "Vui lòng nhập ID");
                error = true;
            }
            else if (EmployeeController.GetEmployeeByID(this.tbx_ID.Text.Trim()) != null && status == 0)
            {
                this.errorProvider1.SetError(this.tbx_ID, "Employee đã tồn tại");
                error = true;
            }
            if (this.tbx_Name.Text.Trim().Length <= 0)
            {
                this.errorProvider1.SetError(this.tbx_Name, "Vui lòng nhập EmployeeName");
                error = true;
            }

            if (this.tbx_Major.Text.Trim().Length <= 0)
            {
                this.errorProvider1.SetError(this.tbx_Major, "Vui lòng nhập Chuyên ngành");
                error = true;
            }

            if (this.dateTimePicker1.Value > DateTime.Now.AddYears(-18))
            {
                this.errorProvider1.SetError(this.dateTimePicker1, "Tuổi của Employee phải trên 18");
                error = true;
            }

            if (this.tbx_Phone.Text.Trim().Length <= 0)
            {
                this.errorProvider1.SetError(this.tbx_Phone, "Vui lòng nhập Số điện thoại");
                error = true;
            }

            if (this.tbx_Email.Text.Trim().Length <= 0)
            {
                this.errorProvider1.SetError(this.tbx_Email, "Vui lòng nhập Email");
                error = true;
            }
            if (this.tbx_HourlyWages.Text.Trim().Length <= 0)
            {
                this.errorProvider1.SetError(this.tbx_HourlyWages, "Vui lòng nhập lương trên một giờ");
                error = true;
            }

            try
            {
                Convert.ToInt32(this.tbx_HourlyWages.Text.Trim());
            }
            catch
            {
                this.errorProvider1.SetError(this.tbx_HourlyWages, "Vui lòng nhập số");
                error = true;
            }

            return error;
        }
        #endregion

        private void dtgv_ListEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowIndex = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                Employee employee = EmployeeController.GetEmployeeByID(this.dtgv_ListEmployee.Rows[e.RowIndex].Cells[0].Value.ToString());

                tbx_ID.Text = employee.ID;
                tbx_Name.Text = employee.Name;
                tbx_Major.Text = employee.Major;
                tbx_Position.Text = employee.Position;
                dateTimePicker1.Value = DateTime.Parse(employee.Birthday.ToString());
                tbx_Phone.Text = employee.Phone;
                tbx_Email.Text = employee.Email;
                tbx_HourlyWages.Text = employee.HourlyWages.ToString();

                if (employee.EmpImage != null)
                {
                    MemoryStream memoryStream = new MemoryStream(employee.EmpImage.ToArray());
                    Image img = Image.FromStream(memoryStream);
                    if (img == null)
                        return;
                    ptb_Avatar.Image = img;
                }
            }
            if (e.RowIndex > dtgv_ListEmployee.Rows.Count - 1)
            {
                return;
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (isError(0))
            {
                return;
            }

            string id = tbx_ID.Text.Trim();
            string EmployeeName = tbx_Name.Text.Trim();
            string position = tbx_Position.Text.Trim();
            string major = tbx_Major.Text.Trim();
            DateTime birthday = dateTimePicker1.Value.Date;
            string phone = tbx_Phone.Text.Trim();
            string email = tbx_Email.Text.Trim();

            MemoryStream stream = new MemoryStream();
            ptb_Avatar.Image.Save(stream, ImageFormat.Jpeg);

            string hourlywages = tbx_HourlyWages.Text.Trim();

            Employee employee = new Employee()
            {
                ID = id,
                Name = EmployeeName,
                Position = position,
                Major = major,
                Birthday = birthday,
                Phone = phone,
                Email = email,
                EmpImage = stream.ToArray(),
                HourlyWages = Convert.ToInt32(hourlywages)
            };

            if (EmployeeController.AddEmployee(employee) == true)
            {
                MessageBox.Show("Thêm nhân viên thành công", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Thêm nhân viên không thành công", "Lỗi !", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                return;
            }

            dtgv_ListEmployee.DataSource = EmployeeController.GetListEmployee();

            ClearControls();
        }

        private void f_Employee_Load(object sender, EventArgs e)
        {
            dtgv_ListEmployee.DataSource = EmployeeController.GetListEmployee();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {

            if (rowIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn Employee cần xóa!", "Thông báo");
                return;
            }

            string ID = this.dtgv_ListEmployee.Rows[rowIndex].Cells[0].Value.ToString();

            if(ProjectController.GetListProjectsByIDLeader(ID) != null)
            {
                MessageBox.Show("Nhân viên hiện là Leader dự án không thể xóa", "Cảnh báo báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }    

            if (EmployeeController.DeleteEmployee(ID) == true)
            {
                MessageBox.Show("Xóa nhân viên thành công", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Xóa nhân viên không thành công", "Lỗi !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dtgv_ListEmployee.DataSource = EmployeeController.GetListEmployee();

            ClearControls();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (isError(1))
            {
                return;
            }
            Employee employee = EmployeeController.GetEmployeeByID(this.tbx_ID.Text);

            employee.ID = this.tbx_ID.Text;
            employee.Name = this.tbx_Name.Text;
            employee.Position = this.tbx_Position.Text;
            employee.Major = this.tbx_Major.Text;
            employee.Name = this.tbx_Name.Text;
            employee.Birthday = this.dateTimePicker1.Value;
            employee.Phone = this.tbx_Phone.Text;
            employee.Email = this.tbx_Email.Text;
            employee.HourlyWages = Convert.ToInt32(this.tbx_HourlyWages.Text);

            MemoryStream stream = new MemoryStream();
            ptb_Avatar.Image.Save(stream, ImageFormat.Jpeg);

            employee.EmpImage = stream.ToArray();

            if (EmployeeController.UpdateEmployee(employee) == true)
            {
                MessageBox.Show("Cập nhật nhân viên thành công", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Cập nhật nhân viên không thành công", "Lỗi !", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            dtgv_ListEmployee.DataSource = EmployeeController.GetListEmployee();
        }

        private void ml_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ptb_Avatar_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Title = "Chọn hình ảnh";
            ofd.Filter = "Files *.jpg|*jpg|*.png|png";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Image img = new Bitmap(ofd.FileName);

                ptb_Avatar.Image = img;
            }
        }

        private void btn_ClearControl_Click(object sender, EventArgs e)
        {
            ClearControls();
        }
    }


}
