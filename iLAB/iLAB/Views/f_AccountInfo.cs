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

namespace iLAB.Views
{
    public partial class f_AccountInfo : Form
    {
        public f_AccountInfo()
        {
            InitializeComponent();
        }

        private void AccountInfo_Load(object sender, EventArgs e)
        {
            ml_Name.Text = Global.Account.Name;
            ml_Major.Text = "Chuyên môn: " + Global.Account.Major;
            ml_Position.Text = "Vị trí: " + Global.Account.Position;

            tbx_ID.Text = Global.Account.ID;
            tbx_Name.Text = Global.Account.Name;
            tbx_PhoneNumber.Text = Global.Account.Phone;
            tbx_Email.Text = Global.Account.Email;
            tbx_NewPassword.Text = Global.Account.PassWord;
            dtp_Birthday.Value = DateTime.Parse(Global.Account.Birthday.ToString());

            if (Global.Account.EmpImage != null)
            {
                MemoryStream memoryStream = new MemoryStream(Global.Account.EmpImage.ToArray());
                Image img = Image.FromStream(memoryStream);
                if (img == null)
                    return;
                pb_EmImage.Image = img;
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if(tbx_NewPassword.Text != tbx_RePassword.Text)
            {
                MessageBox.Show("Xác nhận lại mật khẩu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Global.Account.Name = tbx_Name.Text;
            Global.Account.Birthday = dtp_Birthday.Value;
            Global.Account.Phone = tbx_PhoneNumber.Text;
            Global.Account.Email = tbx_Email.Text;
            Global.Account.PassWord = tbx_NewPassword.Text;

            MemoryStream stream = new MemoryStream();
            pb_EmImage.Image.Save(stream, ImageFormat.Jpeg);

            Global.Account.EmpImage = stream.ToArray();

            if (EmployeeController.UpdateEmployee(Global.Account))
            {
                MessageBox.Show("Cập nhật thành công", "Thông báo");
            }   
            else
            {
                MessageBox.Show("Cập nhật không thành công", "Thông báo");
            }    
        }

        private void ml_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pb_EmImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Title = "Chọn hình ảnh";
            ofd.Filter = "Files *.jpg|*jpg|*.png|png";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Image img = new Bitmap(ofd.FileName);

                pb_EmImage.Image = img;
            }
        }
    }
}
