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
    public partial class f_ProjectEdit : Form
    {
        public f_ProjectEdit()
        {
            InitializeComponent();

            LoadProjectsToDatagridview();
            LoadComboboxLeader();
        }

        void Reset()
        {
            LoadProjectsToDatagridview();
            ClearPanel(pn_ProjectDetail);
        }

        void AddProject(Project project)
        {
            if (ProjectController.AddProject(project))
            {
                MessageBox.Show("Thêm dự án thành công", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Thêm dự án không thành công", "Lỗi", MessageBoxButtons.OK);
            }
        }

        void UpdateProject(Project project)
        {
            if (ProjectController.AddProject(project))
            {
                MessageBox.Show("Cập nhật dự án thành công", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Cập nhật dự án không thành công", "Lỗi", MessageBoxButtons.OK);
            }
        }

        void DeleteProject(int id)
        {
            if (ProjectController.DeleteProject(id))
            {
                MessageBox.Show("Xóa dự án thành công", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Xóa dự án không thành công", "Lỗi", MessageBoxButtons.OK);
            }
        }

        void ClearPanel(Panel panel)
        {
            foreach(Control ctrl in panel.Controls)
            {
                if(ctrl is TextBox || ctrl is ComboBox)
                {
                    ctrl.Text = "";
                }
                else if (ctrl is DateTimePicker)
                {
                    (ctrl as DateTimePicker).Value = DateTime.Now;
                }    
                else if (ctrl is Panel)
                {
                    ClearPanel(ctrl as Panel);
                }
                else if (ctrl is ListBox)
                {
                    (ctrl as ListBox).Items.Clear();
                }    
            }
        }

        void LoadProjectsToDatagridview()
        {
            this.col_ID.DataPropertyName = nameof(Project.ID);
            this.col_Name.DataPropertyName = nameof(Project.Name);
            this.col_Description.DataPropertyName = nameof(Project.Description);
            this.col_Start.DataPropertyName = nameof(Project.StartDate);
            this.col_Finish.DataPropertyName = nameof(Project.EndDate);
            this.col_Status.DataPropertyName = nameof(Project.Status);
            this.col_IDLeader.DataPropertyName = nameof(Project.IDLeader);
            this.col_Task.DataPropertyName = nameof(Project.Tasks);
            this.col_Employee.DataPropertyName = nameof(Project.Employee);

            dtgv_ListProject.DataSource = ProjectController.getListProjects();
        }

        void FillProjectDetail(Project p)
        {
            tbx_ID.Text = p.ID.ToString();
            tbx_Name.Text = p.Name;
            tbx_Description.Text = p.Description;
            dtp_Start.Value = p.StartDate.Value;
            dtp_End.Value = p.EndDate.Value;
            cbb_Status.Text = (p.Status == 1 ? "Hoàn thành" : "Chưa hoàn thành");

            cbb_LeaderName.Text = EmployeeController.GetEmployeeByID(p.IDLeader).Name;
        }

        void LoadComboboxLeader()
        {
            cbb_LeaderName.DataSource = EmployeeController.GetListEmployee();

            cbb_LeaderName.DisplayMember = "Name";
            tbx_LeaderID.DataBindings.Add(new Binding("Text", cbb_LeaderName.DataSource, "ID"));
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            pn_ProjectDetail.Enabled = true;
            ClearPanel(pn_ProjectDetail);

            tbx_ID.Text = ProjectController.GetNextProjectID().ToString();
            cbb_Status.Text = "Chưa hoàn thành";

            btn_SaveChange.Tag = "Add";
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            pn_ProjectDetail.Enabled = true;
            tbx_ID.ReadOnly = true;

            btn_SaveChange.Tag = "Update";
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if(tbx_ID.Text == "")
            {
                MessageBox.Show("Vui lòng chọn Dự án cần xóa", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            int id = Convert.ToInt32(tbx_ID.Text);

            DeleteProject(id);
            Reset();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            List<Project> filtedList = ProjectController.getListProjects();

            if(cb_Name.Checked == true)
            {
                if (tbx_NameSearch.Text.Length > 0)
                {
                    filtedList = filtedList.Where(x => x.Name.Contains(tbx_NameSearch.Text)).ToList();
                }
            }    

            if(cb_Date.Checked == true)
            {
                filtedList = filtedList.Where(x => DateTime.Compare(x.StartDate.Value, dtp_StartDateSearch.Value) >= 0).ToList();
                filtedList = filtedList.Where(x => DateTime.Compare(x.EndDate.Value, dtp_EndDateSearch.Value) <= 0).ToList();
            }    

            dtgv_ListProject.DataSource = filtedList;
        }

        private void ml_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void dtgv_ListProject_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex < 0)
            {
                return;
            }    
            int id = (int)dtgv_ListProject.Rows[e.RowIndex].Cells[0].Value;

            Project project = ProjectController.GetProjectByID(id);

            FillProjectDetail(project);
        }

        private void btn_SaveChange_Click(object sender, EventArgs e)
        {
            Project project = new Project
            {
                ID = Convert.ToInt32(tbx_ID.Text),
                Name = tbx_Name.Text,
                Description = tbx_Description.Text,
                StartDate = dtp_Start.Value,
                EndDate = dtp_End.Value,
                Status = cbb_Status.Text == "Chưa hoàn thành" ? 0 : 1,
                
                IDLeader = (cbb_LeaderName.SelectedItem as Employee).ID,
            };    

            if(btn_SaveChange.Tag.ToString() == "Add")
            {
                AddProject(project);
                Reset();
            }  
            else if (btn_SaveChange.Tag.ToString() == "Update")
            {
                UpdateProject(project);
                Reset();
            }    

            pn_ProjectDetail.Enabled = false;
            tbx_ID.ReadOnly = false;
        }
    }
}
