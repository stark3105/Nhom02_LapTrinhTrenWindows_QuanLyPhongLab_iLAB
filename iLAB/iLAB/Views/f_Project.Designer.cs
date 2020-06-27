namespace iLAB.Views
{
    partial class f_Project
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f_Project));
            this.flp_Projects = new System.Windows.Forms.FlowLayoutPanel();
            this.dtgv_ListProject = new System.Windows.Forms.DataGridView();
            this.col_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_IDLeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Task = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Start = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Finish = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Employee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ml_Close = new MetroFramework.Controls.MetroLink();
            this.ml_Minimize = new MetroFramework.Controls.MetroLink();
            this.btn_Edit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_ListProject)).BeginInit();
            this.SuspendLayout();
            // 
            // flp_Projects
            // 
            this.flp_Projects.AutoScroll = true;
            this.flp_Projects.BackColor = System.Drawing.Color.Transparent;
            this.flp_Projects.Location = new System.Drawing.Point(23, 198);
            this.flp_Projects.Name = "flp_Projects";
            this.flp_Projects.Size = new System.Drawing.Size(672, 486);
            this.flp_Projects.TabIndex = 1;
            // 
            // dtgv_ListProject
            // 
            this.dtgv_ListProject.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_ListProject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_ListProject.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_ID,
            this.col_Description,
            this.col_IDLeader,
            this.col_Task,
            this.col_Name,
            this.col_Start,
            this.col_Finish,
            this.col_Status,
            this.col_Employee});
            this.dtgv_ListProject.Location = new System.Drawing.Point(763, 198);
            this.dtgv_ListProject.Name = "dtgv_ListProject";
            this.dtgv_ListProject.ReadOnly = true;
            this.dtgv_ListProject.RowHeadersWidth = 51;
            this.dtgv_ListProject.RowTemplate.Height = 24;
            this.dtgv_ListProject.Size = new System.Drawing.Size(581, 486);
            this.dtgv_ListProject.TabIndex = 2;
            this.dtgv_ListProject.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_ListProject_CellClick);
            // 
            // col_ID
            // 
            this.col_ID.HeaderText = "Mã dự án";
            this.col_ID.MinimumWidth = 6;
            this.col_ID.Name = "col_ID";
            this.col_ID.ReadOnly = true;
            this.col_ID.Visible = false;
            // 
            // col_Description
            // 
            this.col_Description.HeaderText = "Mô tả";
            this.col_Description.MinimumWidth = 6;
            this.col_Description.Name = "col_Description";
            this.col_Description.ReadOnly = true;
            this.col_Description.Visible = false;
            // 
            // col_IDLeader
            // 
            this.col_IDLeader.HeaderText = "Leader";
            this.col_IDLeader.MinimumWidth = 6;
            this.col_IDLeader.Name = "col_IDLeader";
            this.col_IDLeader.ReadOnly = true;
            this.col_IDLeader.Visible = false;
            // 
            // col_Task
            // 
            this.col_Task.HeaderText = "Tasks";
            this.col_Task.MinimumWidth = 6;
            this.col_Task.Name = "col_Task";
            this.col_Task.ReadOnly = true;
            this.col_Task.Visible = false;
            // 
            // col_Name
            // 
            this.col_Name.HeaderText = "Tên dự án";
            this.col_Name.MinimumWidth = 6;
            this.col_Name.Name = "col_Name";
            this.col_Name.ReadOnly = true;
            // 
            // col_Start
            // 
            this.col_Start.HeaderText = "Ngày bắt đầu";
            this.col_Start.MinimumWidth = 6;
            this.col_Start.Name = "col_Start";
            this.col_Start.ReadOnly = true;
            // 
            // col_Finish
            // 
            this.col_Finish.HeaderText = "Ngày kết thúc";
            this.col_Finish.MinimumWidth = 6;
            this.col_Finish.Name = "col_Finish";
            this.col_Finish.ReadOnly = true;
            // 
            // col_Status
            // 
            this.col_Status.HeaderText = "Trạng thái";
            this.col_Status.MinimumWidth = 6;
            this.col_Status.Name = "col_Status";
            this.col_Status.ReadOnly = true;
            // 
            // col_Employee
            // 
            this.col_Employee.HeaderText = "Employee";
            this.col_Employee.MinimumWidth = 6;
            this.col_Employee.Name = "col_Employee";
            this.col_Employee.ReadOnly = true;
            this.col_Employee.Visible = false;
            // 
            // ml_Close
            // 
            this.ml_Close.BackColor = System.Drawing.Color.Transparent;
            this.ml_Close.BackgroundImage = global::iLAB.Properties.Resources.iconfinder_UI_Basic_outline_116_4733225;
            this.ml_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ml_Close.Location = new System.Drawing.Point(23, 36);
            this.ml_Close.Name = "ml_Close";
            this.ml_Close.Size = new System.Drawing.Size(30, 30);
            this.ml_Close.TabIndex = 14;
            this.ml_Close.UseSelectable = true;
            this.ml_Close.Click += new System.EventHandler(this.ml_Close_Click);
            // 
            // ml_Minimize
            // 
            this.ml_Minimize.BackColor = System.Drawing.Color.Transparent;
            this.ml_Minimize.BackgroundImage = global::iLAB.Properties.Resources.icon_Minimize;
            this.ml_Minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ml_Minimize.Location = new System.Drawing.Point(1324, 2);
            this.ml_Minimize.Name = "ml_Minimize";
            this.ml_Minimize.Size = new System.Drawing.Size(30, 30);
            this.ml_Minimize.TabIndex = 16;
            this.ml_Minimize.UseSelectable = true;
            this.ml_Minimize.Click += new System.EventHandler(this.ml_Minimize_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.BackColor = System.Drawing.Color.Transparent;
            this.btn_Edit.BackgroundImage = global::iLAB.Properties.Resources.icon_Edit;
            this.btn_Edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Edit.FlatAppearance.BorderSize = 0;
            this.btn_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Edit.Location = new System.Drawing.Point(1301, 684);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(42, 42);
            this.btn_Edit.TabIndex = 17;
            this.btn_Edit.UseVisualStyleBackColor = false;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // f_Project
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackgroundImage = global::iLAB.Properties.Resources.iLAB_Thong__2_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1364, 766);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.ml_Minimize);
            this.Controls.Add(this.ml_Close);
            this.Controls.Add(this.dtgv_ListProject);
            this.Controls.Add(this.flp_Projects);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "f_Project";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.f_Project_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_ListProject)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flp_Projects;
        private System.Windows.Forms.DataGridView dtgv_ListProject;
        private MetroFramework.Controls.MetroLink ml_Close;
        private MetroFramework.Controls.MetroLink ml_Minimize;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_IDLeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Task;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Start;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Finish;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Employee;
    }
}