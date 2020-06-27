using iLAB.Controllers;
using iLAB.Models;
using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Task = iLAB.Models.Task;

namespace iLAB.Views
{
    public partial class f_ProjectDetail : Form
    {
        public f_ProjectDetail(int id)
        {
            InitializeComponent();
            this.Tag = id;

            Project project = ProjectController.GetProjectByID(id);

            FillDetailWithProject(project);
            LoadTasksToFlowLayoutPanel(project);
        }

        void FillDetailWithProject(Project p)
        {
            if(p==null)
            {
                return;
            }

            tbx_Name.Text = p.Name;
            tbx_Description.Text = p.Description;
            dtp_Start.Value = p.StartDate.Value;
            dtp_End.Value = p.EndDate.Value;
            tbx_Status.Text = (p.Status == 1 ? "Hoàn thành" : "Chưa hoàn thành");

            Employee leader = EmployeeController.GetEmployeeByID(p.IDLeader);
            tbx_Leader.Text = leader.Name;
        }

        void LoadTasksToFlowLayoutPanel(Project p)
        {
            this.flp_Tasks.Controls.Clear();

            foreach (Task task in TaskController.getListTaskByProject(p.ID))
            {
                FlowLayoutPanel flp = new FlowLayoutPanel { Width = flp_Tasks.Width - 20, Height = 30 };

                MetroLabel mlb = new MetroLabel
                {
                    Text = task.Name,
                    Width = flp_Tasks.Width - 280,
                    Height = 25,
                    FontSize = MetroFramework.MetroLabelSize.Tall,
                    BackColor = Color.Transparent
                };

                MetroLink mtl = new MetroLink
                {
                    Text = "docs",
                    Width = 100,
                    FontSize = MetroFramework.MetroLinkSize.Medium,
                    BackColor = Color.Transparent,
                    Tag = task.ID
                };
                mtl.Click += Mtl_Click;

                RadioButton rdb_Yes = new RadioButton { Text = "", Width = 100, Tag = task.ID };
                rdb_Yes.Click += Rdb_Yes_CheckedChanged;

                RadioButton rdb_No = new RadioButton { Text = "", Width = 20, Tag = task.ID };
                rdb_No.Click += Rdb_No_CheckedChanged;

                if(task.Status == 1)
                {
                    rdb_Yes.Checked = true;
                }    
                else
                {
                    rdb_No.Checked = true;
                }    

                flp.Controls.Add(mlb);    
                flp.Controls.Add(rdb_Yes);
                flp.Controls.Add(rdb_No);
                flp.Controls.Add(mtl);
                flp_Tasks.Controls.Add(flp);  
            };

            pgb_Progress.Value = f_Project.LoadValueProject(p);
            
            lb_Progress.Text = pgb_Progress.Value.ToString() + "%";
        }

        private void Mtl_Click(object sender, EventArgs e)
        {
            MetroLink link = sender as MetroLink;
            Task task = TaskController.GetTasktByID((int)link.Tag);
            try
            { Process.Start(task.LinkDocuments); }
            catch
            { }
            
        }

        private void Rdb_No_CheckedChanged(object sender, EventArgs e)
        {
            Project p = ProjectController.GetProjectByID((int)this.Tag);

            LoadTasksToFlowLayoutPanel(p);
            pgb_Progress.Value = f_Project.LoadValueProject(p);
            lb_Progress.Text = pgb_Progress.Value.ToString() + "%";
        }

        private void Rdb_Yes_CheckedChanged(object sender, EventArgs e)
        {
            Project p = ProjectController.GetProjectByID((int)this.Tag);

            LoadTasksToFlowLayoutPanel(p);
            pgb_Progress.Value = f_Project.LoadValueProject(p);
            lb_Progress.Text = pgb_Progress.Value.ToString() + "%";

        }

        private void Ml_Add_Click(object sender, EventArgs e)
        {
            f_TaskEdit f = new f_TaskEdit((int)this.Tag);
            this.Hide();
            f.ShowDialog();

            int idProject = (int)this.Tag;

            Project project = ProjectController.GetProjectByID(idProject);

            LoadTasksToFlowLayoutPanel(project);
            pgb_Progress.Value = f_Project.LoadValueProject(project);
            lb_Progress.Text = pgb_Progress.Value.ToString() + "%";

            this.Show();
        }

        private void ml_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ml_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
