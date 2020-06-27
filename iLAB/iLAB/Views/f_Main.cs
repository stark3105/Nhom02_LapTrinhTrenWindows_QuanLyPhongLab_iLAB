using iLAB.Controllers;
using iLAB.Models;
using iLAB.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Task = iLAB.Models.Task;

namespace iLAB.Views
{

    public partial class f_Main : Form
    {
        public f_Main()
        {
            InitializeComponent();

            LoadMatrix();
        }

        private void f_Main_Load(object sender, EventArgs e)
        {
            mt_Infomation.Text = "Tài khoản: " + Global.Account.Name;

            if(Global.Account.Position == "Nhân viên")
            {
                lb_HumanResources.Visible = false;
                mt_Employee.Visible = false;
                mt_Attendance.Visible = false;
                mt_Salary.Visible = false;
            }    
        }

        #region Calendar

        private List<string> dateOfWeek = new List<string>() { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
        private List<List<Button>> matrix;
        public List<List<Button>> Matrix
        {
            get { return matrix; }
            set { matrix = value; }
        }

        public void LoadMatrix()
        {
            Matrix = new List<List<Button>>();

            Button oldBtn = new Button() { Width = 0, Height = 0, Location = new Point(-Global.margin, 0) };
            for (int i = 0; i < Global.DayOfColumn; i++)
            {
                Matrix.Add(new List<Button>());
                for (int j = 0; j < Global.DayOfWeek; j++)
                {
                    Button btn = new Button() { Width = Global.dateButtonWidth, Height = Global.dateButtonHeight };
                    btn.Location = new Point(oldBtn.Location.X + oldBtn.Width + Global.margin, oldBtn.Location.Y);
                    btn.Click += Btn_Click;

                    pnThang.Controls.Add(btn);
                    Matrix[i].Add(btn);

                    oldBtn = btn;
                }
                oldBtn = new Button() { Width = 0, Height = 0, Location = new Point(-Global.margin, oldBtn.Location.Y + Global.dateButtonHeight) };
            }
            SetDefaultDate();
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn.Text == "")
                return;
           
            if(btn.Tag is Project)
            {
                f_Project f = new f_Project();
                f.ShowDialog();
            } 
            else if(btn.Tag is Task)
            {
                Task t = btn.Tag as Task;
                f_TaskEdit f = new f_TaskEdit(Convert.ToInt32(t.IDProject.ToString()));
                f.ShowDialog();
            }    
        }

        public void SetDefaultDate()
        {
            dtpkNgayLichThang.Value = DateTime.Now;
        }

        public void AddNumberIntoMatrixByDate(DateTime date)
        {
            ClearMatrix();
            DateTime useDate = new DateTime(date.Year, date.Month, 1);
            DateTime endDate = useDate.AddMonths(1).AddDays(-1);

            int line = 0;

            for (int i = 1; i <= endDate.Day; i++)
            {
                int column = dateOfWeek.IndexOf(useDate.DayOfWeek.ToString());
                Button btn = Matrix[line][column];
                btn.Text = i.ToString();

                if (isEqualDate(useDate, DateTime.Now))
                {
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderColor = Color.Blue;
                    btn.FlatAppearance.BorderSize = 2;
                }

                if (isEqualDate(useDate, date))
                {
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderColor = Color.Green;
                    btn.FlatAppearance.BorderSize = 3;
                }

                if (column >= 6)
                    line++;

                LoadToolTipForDate(ref btn, useDate);

                useDate = useDate.AddDays(1);
            }
        }

        public void ClearMatrix()
        {
            for (int i = 0; i < Matrix.Count; i++)
            {
                for (int j = 0; j < Matrix[i].Count; j++)
                {
                    Button btn = Matrix[i][j];
                    btn.Text = "";
                    btn.BackColor = Color.White;
                    btn.FlatStyle = FlatStyle.Standard;
                    btn.FlatAppearance.BorderColor = Color.White;
                }
            }
        }

        public bool isEqualDate(DateTime dateA, DateTime dateB)
        {
            return dateA.Year == dateB.Year && dateA.Month == dateB.Month && dateA.Day == dateB.Day;
        }

        public void LoadToolTipForDate(ref Button btn, DateTime date)
        {
            string strText = "";

            if(Global.Account.Position == "Quản lý")
            {
                toolTipLichThang.ToolTipTitle = "Dự án";

                foreach (Project item in ProjectController.getListProjects())
                {
                    bool kt_Start = isEqualDate(item.StartDate.Value, date);
                    bool kt_End = isEqualDate(item.EndDate.Value, date);

                    if (kt_Start)
                    {
                        strText += "Bắt đầu: " + item.Name + "\n";
                        btn.Tag = item;
                    }

                    if (kt_End)
                    {
                        strText += "Deadline: " + item.Name + "\n";
                        btn.Tag = item;
                    }
                }
            }
            else if(Global.Account.Position == "Nhân viên")
            {
                toolTipLichThang.ToolTipTitle = "Công việc";

                foreach (Task item in TaskController.GetListTaskByIDEmp(Global.Account.ID))
                {
                    bool kt_Start = isEqualDate(item.StartDate.Value, date);
                    bool kt_End = isEqualDate(item.EndDate.Value, date);

                    if (kt_Start)
                    {
                        strText += "Bắt đầu: " + item.Name + "\n";
                        btn.Tag = item;
                    }

                    if (kt_End)
                    {
                        strText += "Deadline: " + item.Name + "\n";
                        btn.Tag = item;
                    }
                }
            }    

            if (strText != "")
            {
                toolTipLichThang.SetToolTip(btn, strText);
                btn.BackColor = Color.Aqua;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            AddNumberIntoMatrixByDate(dtpkNgayLichThang.Value);
        }

        private void btnHomNayLichThang_Click(object sender, EventArgs e)
        {
            SetDefaultDate();
        }

        private void btnThangSau_Click(object sender, EventArgs e)
        {
            dtpkNgayLichThang.Value = dtpkNgayLichThang.Value.AddMonths(1);
        }

        private void btnThangTruoc_Click(object sender, EventArgs e)
        {
            dtpkNgayLichThang.Value = dtpkNgayLichThang.Value.AddMonths(-1);
        }

        private void dtpkNgayLichThang_ValueChanged(object sender, EventArgs e)
        {
            AddNumberIntoMatrixByDate((sender as DateTimePicker).Value);
        }

        #endregion

        #region Control Panel

        private void mt_Attendance_Click(object sender, EventArgs e)
        {
            f_Working f = new f_Working();
            f.ShowDialog();
        }

        private void mt_Employee_Click(object sender, EventArgs e)
        {
            f_Employee f = new f_Employee();
            f.ShowDialog();
        }

        private void mt_Salary_Click(object sender, EventArgs e)
        {
            f_Salary f = new f_Salary();
            f.ShowDialog();
        }

        private void mt_Project_Click(object sender, EventArgs e)
        {
            f_Project f = new f_Project();
            f.ShowDialog();
        }

        private void btn_Task_Click(object sender, EventArgs e)
        {
            List<int> projectIDs = ProjectController.getListProjectsID();
            f_TaskEdit f = new f_TaskEdit(projectIDs[0]);
            f.Show();
        }

        private void mt_Logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mt_Infomation_Click(object sender, EventArgs e)
        {
            f_AccountInfo f = new f_AccountInfo();
            f.ShowDialog();
        }

        private void ml_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        private void mt_About_Click(object sender, EventArgs e)
        {
            f_About f = new f_About();
            f.ShowDialog();
        }
    }
}
