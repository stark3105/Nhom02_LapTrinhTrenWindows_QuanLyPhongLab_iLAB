using iLAB.Controllers;
using iLAB.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iLAB.Views
{
    public partial class f_Working : Form
    {
        public f_Working()
        {
            InitializeComponent();

            lb_Date.Text = "Ngày " + DateTime.Now.ToString();

            LoadWorkToListView();
        }
        #region Methods
        public void LoadWorkToListView()
        {

            List<Work> works = WorkController.GetListWorkByDay(DateTime.Now);

            if (works is null)
                return;

            foreach (var work in works)
            {
                Employee employee = EmployeeController.GetEmployeeByID(work.IDEmployee);

                ListViewItem item = new ListViewItem(employee.ID);
                item.SubItems.Add(employee.Name);
                item.SubItems.Add(work.CheckIn.ToString());
                item.SubItems.Add(work.CheckOut.ToString());

                item.Tag = work.ID.ToString();
                lv_Attendance.Items.Add(item);

                if (work.CheckIn != null && work.CheckOut == null)
                {
                    AddEmployeeWorking(employee);
                }
            }
        }

        public void AddEmployeeToListView()
        {
            int IDWork = 0;
            DateTime checkIn = DateTime.Now;
            string IDEmployee = tbx_IDAttendance.Text.Trim();

            foreach (ListViewItem item in lv_Attendance.Items)
            {
                if (item.SubItems[0].Text == IDEmployee && item.SubItems[2].Text != "" && item.SubItems[3].Text == "")
                {
                    lv_Attendance.Items[lv_Attendance.Items.IndexOf(item)].SubItems[3].Text = DateTime.Now.ToString();
                    IDWork = Convert.ToInt32(item.Tag);
                    checkIn = DateTime.Parse(item.SubItems[2].Text);
                    break;
                }
            }

            Employee employee = EmployeeController.GetEmployeeByID(IDEmployee);

            if (employee == null)
                return;

            Work work = new Work
            {
                ID = IDWork,
                IDEmployee = IDEmployee,
                CheckIn = checkIn
            };

            if (IDWork == 0)
            {
                IDWork = WorkController.GetIDFromDB();
                work.ID = IDWork;
                WorkController.AddWork(work);

                ListViewItem item1 = new ListViewItem(IDEmployee);
                item1.SubItems.Add(employee.Name);
                item1.SubItems.Add(DateTime.Now.ToString());
                item1.SubItems.Add("");

                item1.Tag = IDWork.ToString();
                lv_Attendance.Items.Add(item1);

                AddEmployeeWorking(employee);
            }
            else
            {
                work.CheckOut = DateTime.Now;
                WorkController.UpdateWork(work);

                RemoveEmployeeWorking(employee);
            }

            tbx_IDAttendance.Text = "";
        }
        public void AddEmployeeWorking(Employee employee)
        {
            MemoryStream memoryStream = new MemoryStream(employee.EmpImage.ToArray());
            Image img = Image.FromStream(memoryStream);

            FlowLayoutPanel flpn = new FlowLayoutPanel
            {
                Width = 165,
                Height = 170,
                Tag = employee.ID
            };

            PictureBox ptb = new PictureBox
            {
                Width = 155,
                Height = 130,
                SizeMode = PictureBoxSizeMode.Zoom,
                Image = img
            };

            Label lb = new Label
            {
                Width = 155,
                Height = 30,
                Text = employee.Name,
                TextAlign = ContentAlignment.MiddleCenter
            };

            flpn.Controls.Add(ptb);
            flpn.Controls.Add(lb);

            flpn_EmployeeWorking.Controls.Add(flpn);
        }

        public void RemoveEmployeeWorking(Employee employee)
        {
            foreach (var item in flpn_EmployeeWorking.Controls)
            {
                if (item is FlowLayoutPanel)
                {
                    FlowLayoutPanel flowLayoutPanel = item as FlowLayoutPanel;
                    if (flowLayoutPanel.Tag.ToString() == employee.ID)
                    {
                        flpn_EmployeeWorking.Controls.Remove(flowLayoutPanel);
                    }
                }
            }

        }
        #endregion

        #region Events
        private void btn_AddIDAttendance_Click(object sender, EventArgs e)
        {
            AddEmployeeToListView();
        }
        private void ml_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tm_DateNow_Tick(object sender, EventArgs e)
        {

            lb_Date.Text = "Ngày " + DateTime.Now.ToString();
        }
        #endregion


    }
}
