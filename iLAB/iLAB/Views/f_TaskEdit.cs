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
using Task = iLAB.Models.Task;

namespace iLAB.Views
{
    public partial class f_TaskEdit : Form
    {
        public f_TaskEdit(int id)
        {
            InitializeComponent();

            LoadDataGridview(id);
            LoadComboboxProject(id);  
        }

        private void FillTaskDetail(Task task)
        {
            tbx_ID.Text = task.ID.ToString();
            tbx_Name.Text = task.Name;
            tbx_Description.Text = task.Description;
            dtp_Start.Value = task.StartDate.Value;
            dtp_End.Value = task.EndDate.Value;
            cbb_Status.Text = (task.Status == 1 ? "Hoàn thành" : "Chưa hoàn thành");
            tbx_Link.Text = task.LinkDocuments;

            lbx_ListEmployee.Items.Clear();
            foreach(Employee e in task.Employees)
            {
                lbx_ListEmployee.Items.Add(e);
            }
            lbx_ListEmployee.DisplayMember = "Name";
        }

        void ClearPanel(Panel panel)
        {
            foreach (Control ctrl in panel.Controls)
            {
                if (ctrl is TextBox || ctrl is ComboBox)
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

        private void LoadDataGridview(int id)
        {
            this.col_ID.DataPropertyName = nameof(Task.ID);
            this.col_Name.DataPropertyName = nameof(Task.Name);
            this.col_Description.DataPropertyName = nameof(Task.Description);
            this.col_Start.DataPropertyName = nameof(Task.StartDate);
            this.col_Finish.DataPropertyName = nameof(Task.EndDate);
            this.col_IDProject.DataPropertyName = nameof(Task.IDProject);
            this.col_Status.DataPropertyName = nameof(Task.Status);
            this.col_Link.DataPropertyName = nameof(Task.LinkDocuments);
            this.col_Projetc.DataPropertyName = nameof(Task.Project);
            this.col_Employee.DataPropertyName = nameof(Task.Employees);
        }

        void Reset()
        {
            LoadListTaskByProject(cbb_ChooseProject.SelectedItem as Project);
            ClearPanel(pn_TaskDetail);
        }

        private void LoadComboboxProject(int id)
        {
            List<Project> projects = ProjectController.getListProjects();
            cbb_ChooseProject.DataSource = projects;
            cbb_ChooseProject.DisplayMember = "Name";

            Project project = ProjectController.GetProjectByID(id);

            foreach (Project p in cbb_ChooseProject.Items)
            {
                if (project.ID == p.ID)
                {
                    cbb_ChooseProject.SelectedItem = p;
                    break;
                }
            }
        }

        private void LoadListTaskByProject(Project project)
        {
            dtgv_ListTask.DataSource = TaskController.getListTaskByProject(project.ID);
        }

        void AddTask(Task task)
        {
            if (TaskController.AddTask(task))
            {
                MessageBox.Show("Thêm công việc thành công", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Thêm công việc không thành công", "Lỗi", MessageBoxButtons.OK);
            }
        }

        void UpdateTask(Task task)
        {
            if (TaskController.UpdateTask(task))
            {
                MessageBox.Show("Chỉnh sửa công việc thành công", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Chỉnh sửa công việc không thành công", "Lỗi", MessageBoxButtons.OK);
            }
        }

        void DeleteTask(int id)
        {
            if (TaskController.DeleteTask(id))
            {
                MessageBox.Show("Xóa công việc thành công", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Xóa công việc không thành công", "Lỗi", MessageBoxButtons.OK);
            }
        }

        private void ml_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbb_ChooseProject_SelectedIndexChanged(object sender, EventArgs e)
        {
            Project p = cbb_ChooseProject.SelectedItem as Project;
            LoadListTaskByProject(p);

            if (!(Global.Account.Position == "Quản lý" || (Global.Account.ID == (cbb_ChooseProject.SelectedItem as Project).IDLeader)))
            {
                btn_Add.Visible = false;
                btn_Update.Visible = false;
                btn_Delete.Visible = false;
                btn_SaveChange.Visible = false;
            }
            else
            {
                btn_Add.Visible = true;
                btn_Update.Visible = true;
                btn_Delete.Visible = true;
                btn_SaveChange.Visible = true;
            }    
        }

        private void tbx_SearchName_TextChanged(object sender, EventArgs e)
        {
            this.lbx_SeachEmployee.Items.Clear();

            List<Employee> searchEmployees = EmployeeController.GetListEmployee().Where(x => x.Name.Contains(tbx_SearchName.Text.Trim())).ToList();
                
            if(searchEmployees.Count > 0 && tbx_SearchName.Text != "")
            {
                this.lbx_SeachEmployee.Visible = true;

                foreach(Employee employee in searchEmployees)
                {
                    this.lbx_SeachEmployee.Items.Add(employee);
                }
                lbx_SeachEmployee.DisplayMember = "Name";
            }
            else
            {
                this.lbx_SeachEmployee.Visible = false;
            }    
        }

        private void lbx_SeachEmployee_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(this.lbx_SeachEmployee.SelectedIndex >= 0)
            {
                Employee employee = lbx_SeachEmployee.SelectedItem as Employee;

                foreach(Employee em in lbx_ListEmployee.Items)
                {
                    if(employee.Name == em.Name)
                    {
                        return;
                    }    
                }    

                this.lbx_ListEmployee.Items.Add(employee);
                this.lbx_ListEmployee.DisplayMember = "Name";
            }    
        }

        private void lbx_ListEmployee_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(this.lbx_ListEmployee.SelectedIndex >= 0)
            {
                Employee employee = lbx_ListEmployee.SelectedItem as Employee;
                lbx_ListEmployee.Items.Remove(employee);
            }    
        }

        private void dtgv_ListTask_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            int id = (int)dtgv_ListTask.Rows[e.RowIndex].Cells[0].Value;

            Task task = TaskController.GetTasktByID(id);

            FillTaskDetail(task);
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            pn_TaskDetail.Enabled = true;
            ClearPanel(pn_TaskDetail);

            tbx_ID.Text = TaskController.GetNextTaskID().ToString();
            cbb_Status.Text = "Chưa hoàn thành";

            btn_SaveChange.Tag = "Add";
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            pn_TaskDetail.Enabled = true;
            btn_SaveChange.Tag = "Update";
        }

        private void btn_SaveChange_Click(object sender, EventArgs e)
        {
            Task task = new Task
            {
                ID = Convert.ToInt32(tbx_ID.Text),
                Name = tbx_Name.Text,
                Description = tbx_Description.Text,
                StartDate = dtp_Start.Value,
                EndDate = dtp_End.Value,
                Status = cbb_Status.Text == "Chưa hoàn thành" ? 0 : 1,
                IDProject = (cbb_ChooseProject.SelectedItem as Project).ID,  
            };

            foreach (Employee employee in lbx_ListEmployee.Items)
            {
                task.Employees.Add(employee);
            }

            if (btn_SaveChange.Tag.ToString() == "Add")
            {
                AddTask(task);
                Reset();
            }
            else if (btn_SaveChange.Tag.ToString() == "Update")
            {
                UpdateTask(task);
                Reset();
            }

            pn_TaskDetail.Enabled = false;
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            int id = 0;
            try
            {
                id = Convert.ToInt32(tbx_ID.Text);
            }
            catch
            {
                MessageBox.Show("Chọn task cần xóa");
                return;
            }

            DeleteTask(id);
            Reset();
        }
    }
}
