using iLAB.Controllers;
using iLAB.Models;
using MetroFramework.Controls;
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
    public partial class f_Project : Form
    {
        public f_Project()
        {
            InitializeComponent();

            if (Global.Account.Position != "Quản lý")
            {
                btn_Edit.Visible = false;
            }
        }

        public static int LoadValueProject(Project p)
        {
            int totalTasks = 0;
            int doneTasks = 0;
     
            foreach(Task t in TaskController.getListTaskByProject(p.ID))
            {
                if(t.Status == 1)
                {
                    doneTasks++;
                }
                totalTasks++;
            }

            if(totalTasks > 0)
            {
                return (int)((float)doneTasks / totalTasks * 100);
            }   
            else
            {
                return 0;
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

        void LoadProjectsToFlowLayoutPanel()
        {

            flp_Projects.Controls.Clear();

            foreach(Project p in ProjectController.getListProjects())
            {
                if(p.Status == 0)
                {
                    FlowLayoutPanel flp = new FlowLayoutPanel { Width = flp_Projects.Width - 30, Height = 70 };

                    MetroLabel mlb = new MetroLabel
                    {   Text = p.Name, 
                        Width = flp_Projects.Width - 30,
                        Height = 25,
                        FontSize = MetroFramework.MetroLabelSize.Tall,
                        BackColor = Color.Transparent
                    };

                    MetroProgressBar pgb = new MetroProgressBar
                    {
                        Value = LoadValueProject(p),
                        Width = flp_Projects.Width - 280,
                        Height = 15,
                        Location = new Point(0, 15),   
                        Style = p.EndDate.Value < DateTime.Now ? MetroFramework.MetroColorStyle.Red : MetroFramework.MetroColorStyle.Green,
                    };

                    MetroLabel lb = new MetroLabel
                    {
                        Text = pgb.Value.ToString() + "%",
                        Width = 50
                    };

                    MetroLink mtl = new MetroLink { Text = "Chi tiết", Width = 150, Tag = p.ID };
                    mtl.Click += Mtl_Click;

                    flp.Controls.Add(mlb);
                    flp.Controls.Add(pgb);
                    flp.Controls.Add(lb);
                    flp.Controls.Add(mtl);

                    flp_Projects.Controls.Add(flp);
                }    
            }    
        }

        private void Mtl_Click(object sender, EventArgs e)
        {
            int id = (int)(sender as MetroLink).Tag;

            f_ProjectDetail f = new f_ProjectDetail(id);

            this.Hide();
            f.ShowDialog();
            LoadProjectsToFlowLayoutPanel();
            this.Show();
        }

        private void f_Project_Load(object sender, EventArgs e)
        {
            LoadProjectsToDatagridview();
            LoadProjectsToFlowLayoutPanel();
        }

        private void ml_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ml_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void dtgv_ListProject_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dtgv_ListProject.Rows[e.RowIndex].Cells[0].Value);

            this.Hide();
            f_ProjectDetail f = new f_ProjectDetail(id);
            f.ShowDialog();
            LoadProjectsToFlowLayoutPanel();
            this.Show();
        }
        private void btn_Edit_Click(object sender, EventArgs e)
        {
            f_ProjectEdit f = new f_ProjectEdit();

            f.ShowDialog();

            LoadProjectsToFlowLayoutPanel();
            LoadProjectsToDatagridview();
        }
    }
}
