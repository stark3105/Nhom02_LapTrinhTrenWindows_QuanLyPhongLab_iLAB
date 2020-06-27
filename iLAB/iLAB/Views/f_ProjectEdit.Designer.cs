namespace iLAB.Views
{
    partial class f_ProjectEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f_ProjectEdit));
            this.dtgv_ListProject = new System.Windows.Forms.DataGridView();
            this.col_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_IDLeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Task = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Start = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Finish = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Employee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroPanel7 = new MetroFramework.Controls.MetroPanel();
            this.tbx_LeaderID = new System.Windows.Forms.TextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel5 = new MetroFramework.Controls.MetroPanel();
            this.cbb_Status = new System.Windows.Forms.ComboBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel4 = new MetroFramework.Controls.MetroPanel();
            this.dtp_End = new System.Windows.Forms.DateTimePicker();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel6 = new MetroFramework.Controls.MetroPanel();
            this.dtp_Start = new System.Windows.Forms.DateTimePicker();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.tbx_Description = new System.Windows.Forms.TextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.tbx_Name = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.ml_Close = new MetroFramework.Controls.MetroLink();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.tbx_NameSearch = new System.Windows.Forms.TextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel8 = new MetroFramework.Controls.MetroPanel();
            this.dtp_EndDateSearch = new System.Windows.Forms.DateTimePicker();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel9 = new MetroFramework.Controls.MetroPanel();
            this.dtp_StartDateSearch = new System.Windows.Forms.DateTimePicker();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.btn_Search = new System.Windows.Forms.Button();
            this.metroPanel10 = new MetroFramework.Controls.MetroPanel();
            this.tbx_ID = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.pn_ProjectDetail = new System.Windows.Forms.Panel();
            this.btn_SaveChange = new System.Windows.Forms.Button();
            this.metroPanel11 = new MetroFramework.Controls.MetroPanel();
            this.cbb_LeaderName = new System.Windows.Forms.ComboBox();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.cb_Name = new System.Windows.Forms.CheckBox();
            this.cb_Date = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_ListProject)).BeginInit();
            this.metroPanel7.SuspendLayout();
            this.metroPanel5.SuspendLayout();
            this.metroPanel4.SuspendLayout();
            this.metroPanel6.SuspendLayout();
            this.metroPanel3.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.metroPanel8.SuspendLayout();
            this.metroPanel9.SuspendLayout();
            this.metroPanel10.SuspendLayout();
            this.pn_ProjectDetail.SuspendLayout();
            this.metroPanel11.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgv_ListProject
            // 
            this.dtgv_ListProject.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_ListProject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_ListProject.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_ID,
            this.col_Description,
            this.col_Status,
            this.col_IDLeader,
            this.col_Task,
            this.col_Name,
            this.col_Start,
            this.col_Finish,
            this.col_Employee});
            this.dtgv_ListProject.Location = new System.Drawing.Point(29, 200);
            this.dtgv_ListProject.Name = "dtgv_ListProject";
            this.dtgv_ListProject.ReadOnly = true;
            this.dtgv_ListProject.RowHeadersWidth = 51;
            this.dtgv_ListProject.RowTemplate.Height = 24;
            this.dtgv_ListProject.Size = new System.Drawing.Size(717, 348);
            this.dtgv_ListProject.TabIndex = 3;
            this.dtgv_ListProject.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_ListProject_CellClick);
            // 
            // col_ID
            // 
            this.col_ID.HeaderText = "Mã dự án";
            this.col_ID.MinimumWidth = 6;
            this.col_ID.Name = "col_ID";
            this.col_ID.ReadOnly = true;
            // 
            // col_Description
            // 
            this.col_Description.HeaderText = "Mô tả";
            this.col_Description.MinimumWidth = 6;
            this.col_Description.Name = "col_Description";
            this.col_Description.ReadOnly = true;
            this.col_Description.Visible = false;
            // 
            // col_Status
            // 
            this.col_Status.HeaderText = "Trạng thái";
            this.col_Status.MinimumWidth = 6;
            this.col_Status.Name = "col_Status";
            this.col_Status.ReadOnly = true;
            this.col_Status.Visible = false;
            // 
            // col_IDLeader
            // 
            this.col_IDLeader.HeaderText = "Leader";
            this.col_IDLeader.MinimumWidth = 6;
            this.col_IDLeader.Name = "col_IDLeader";
            this.col_IDLeader.ReadOnly = true;
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
            // col_Employee
            // 
            this.col_Employee.HeaderText = "Employee";
            this.col_Employee.MinimumWidth = 6;
            this.col_Employee.Name = "col_Employee";
            this.col_Employee.ReadOnly = true;
            this.col_Employee.Visible = false;
            // 
            // metroPanel7
            // 
            this.metroPanel7.Controls.Add(this.tbx_LeaderID);
            this.metroPanel7.Controls.Add(this.metroLabel7);
            this.metroPanel7.HorizontalScrollbarBarColor = true;
            this.metroPanel7.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel7.HorizontalScrollbarSize = 10;
            this.metroPanel7.Location = new System.Drawing.Point(21, 446);
            this.metroPanel7.Name = "metroPanel7";
            this.metroPanel7.Size = new System.Drawing.Size(560, 57);
            this.metroPanel7.TabIndex = 19;
            this.metroPanel7.VerticalScrollbarBarColor = true;
            this.metroPanel7.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel7.VerticalScrollbarSize = 10;
            // 
            // tbx_LeaderID
            // 
            this.tbx_LeaderID.BackColor = System.Drawing.Color.White;
            this.tbx_LeaderID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbx_LeaderID.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_LeaderID.Location = new System.Drawing.Point(120, 19);
            this.tbx_LeaderID.Name = "tbx_LeaderID";
            this.tbx_LeaderID.Size = new System.Drawing.Size(150, 28);
            this.tbx_LeaderID.TabIndex = 6;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel7.Location = new System.Drawing.Point(0, 19);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(94, 25);
            this.metroLabel7.TabIndex = 2;
            this.metroLabel7.Text = "ID Leader:";
            // 
            // metroPanel5
            // 
            this.metroPanel5.Controls.Add(this.cbb_Status);
            this.metroPanel5.Controls.Add(this.metroLabel6);
            this.metroPanel5.HorizontalScrollbarBarColor = true;
            this.metroPanel5.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel5.HorizontalScrollbarSize = 10;
            this.metroPanel5.Location = new System.Drawing.Point(21, 329);
            this.metroPanel5.Name = "metroPanel5";
            this.metroPanel5.Size = new System.Drawing.Size(560, 57);
            this.metroPanel5.TabIndex = 18;
            this.metroPanel5.VerticalScrollbarBarColor = true;
            this.metroPanel5.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel5.VerticalScrollbarSize = 10;
            // 
            // cbb_Status
            // 
            this.cbb_Status.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_Status.FormattingEnabled = true;
            this.cbb_Status.Items.AddRange(new object[] {
            "Đã hoàn thành",
            "Chưa hoàn thành"});
            this.cbb_Status.Location = new System.Drawing.Point(120, 12);
            this.cbb_Status.Name = "cbb_Status";
            this.cbb_Status.Size = new System.Drawing.Size(222, 36);
            this.cbb_Status.TabIndex = 9;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.Location = new System.Drawing.Point(0, 19);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(93, 25);
            this.metroLabel6.TabIndex = 2;
            this.metroLabel6.Text = "Trạng thái:";
            // 
            // metroPanel4
            // 
            this.metroPanel4.Controls.Add(this.dtp_End);
            this.metroPanel4.Controls.Add(this.metroLabel4);
            this.metroPanel4.HorizontalScrollbarBarColor = true;
            this.metroPanel4.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel4.HorizontalScrollbarSize = 10;
            this.metroPanel4.Location = new System.Drawing.Point(321, 266);
            this.metroPanel4.Name = "metroPanel4";
            this.metroPanel4.Size = new System.Drawing.Size(260, 57);
            this.metroPanel4.TabIndex = 17;
            this.metroPanel4.VerticalScrollbarBarColor = true;
            this.metroPanel4.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel4.VerticalScrollbarSize = 10;
            // 
            // dtp_End
            // 
            this.dtp_End.CustomFormat = "dd/MM/yyyy";
            this.dtp_End.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_End.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_End.Location = new System.Drawing.Point(98, 14);
            this.dtp_End.Name = "dtp_End";
            this.dtp_End.Size = new System.Drawing.Size(148, 30);
            this.dtp_End.TabIndex = 3;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.Location = new System.Drawing.Point(0, 19);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(81, 25);
            this.metroLabel4.TabIndex = 2;
            this.metroLabel4.Text = "Kết thúc:";
            // 
            // metroPanel6
            // 
            this.metroPanel6.Controls.Add(this.dtp_Start);
            this.metroPanel6.Controls.Add(this.metroLabel5);
            this.metroPanel6.HorizontalScrollbarBarColor = true;
            this.metroPanel6.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel6.HorizontalScrollbarSize = 10;
            this.metroPanel6.Location = new System.Drawing.Point(21, 266);
            this.metroPanel6.Name = "metroPanel6";
            this.metroPanel6.Size = new System.Drawing.Size(294, 57);
            this.metroPanel6.TabIndex = 16;
            this.metroPanel6.VerticalScrollbarBarColor = true;
            this.metroPanel6.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel6.VerticalScrollbarSize = 10;
            // 
            // dtp_Start
            // 
            this.dtp_Start.CustomFormat = "dd/MM/yyyy";
            this.dtp_Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Start.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_Start.Location = new System.Drawing.Point(120, 14);
            this.dtp_Start.Name = "dtp_Start";
            this.dtp_Start.Size = new System.Drawing.Size(148, 30);
            this.dtp_Start.TabIndex = 3;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.Location = new System.Drawing.Point(0, 19);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(76, 25);
            this.metroLabel5.TabIndex = 2;
            this.metroLabel5.Text = "Bắt đầu:";
            // 
            // metroPanel3
            // 
            this.metroPanel3.Controls.Add(this.tbx_Description);
            this.metroPanel3.Controls.Add(this.metroLabel3);
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(21, 129);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(560, 131);
            this.metroPanel3.TabIndex = 15;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
            // 
            // tbx_Description
            // 
            this.tbx_Description.BackColor = System.Drawing.Color.White;
            this.tbx_Description.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbx_Description.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_Description.Location = new System.Drawing.Point(120, 18);
            this.tbx_Description.Multiline = true;
            this.tbx_Description.Name = "tbx_Description";
            this.tbx_Description.Size = new System.Drawing.Size(426, 97);
            this.tbx_Description.TabIndex = 6;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.Location = new System.Drawing.Point(0, 19);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(63, 25);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Mô tả:";
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.White;
            this.metroPanel1.Controls.Add(this.tbx_Name);
            this.metroPanel1.Controls.Add(this.panel1);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(21, 66);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(560, 57);
            this.metroPanel1.TabIndex = 14;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // tbx_Name
            // 
            this.tbx_Name.BackColor = System.Drawing.Color.White;
            this.tbx_Name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbx_Name.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_Name.Location = new System.Drawing.Point(120, 18);
            this.tbx_Name.Name = "tbx_Name";
            this.tbx_Name.Size = new System.Drawing.Size(426, 28);
            this.tbx_Name.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Location = new System.Drawing.Point(120, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(426, 2);
            this.panel1.TabIndex = 7;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(0, 19);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(93, 25);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Tên dự án:";
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.Color.Transparent;
            this.btn_Delete.BackgroundImage = global::iLAB.Properties.Resources.delete_button;
            this.btn_Delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Delete.FlatAppearance.BorderSize = 0;
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Delete.Location = new System.Drawing.Point(1301, 140);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(35, 35);
            this.btn_Delete.TabIndex = 24;
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.Color.Transparent;
            this.btn_Update.BackgroundImage = global::iLAB.Properties.Resources.update_button;
            this.btn_Update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Update.FlatAppearance.BorderSize = 0;
            this.btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Update.Location = new System.Drawing.Point(1260, 140);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(35, 35);
            this.btn_Update.TabIndex = 23;
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.Transparent;
            this.btn_Add.BackgroundImage = global::iLAB.Properties.Resources.add_button;
            this.btn_Add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Add.FlatAppearance.BorderSize = 0;
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add.Location = new System.Drawing.Point(1214, 137);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(40, 40);
            this.btn_Add.TabIndex = 22;
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // ml_Close
            // 
            this.ml_Close.BackColor = System.Drawing.Color.Transparent;
            this.ml_Close.BackgroundImage = global::iLAB.Properties.Resources.iconfinder_UI_Basic_outline_116_4733225;
            this.ml_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ml_Close.Location = new System.Drawing.Point(20, 36);
            this.ml_Close.Name = "ml_Close";
            this.ml_Close.Size = new System.Drawing.Size(30, 30);
            this.ml_Close.TabIndex = 20;
            this.ml_Close.UseSelectable = true;
            this.ml_Close.Click += new System.EventHandler(this.ml_Close_Click);
            // 
            // metroPanel2
            // 
            this.metroPanel2.BackColor = System.Drawing.Color.Transparent;
            this.metroPanel2.Controls.Add(this.tbx_NameSearch);
            this.metroPanel2.Controls.Add(this.metroLabel1);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(44, 656);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(538, 57);
            this.metroPanel2.TabIndex = 25;
            this.metroPanel2.UseCustomBackColor = true;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // tbx_NameSearch
            // 
            this.tbx_NameSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbx_NameSearch.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_NameSearch.Location = new System.Drawing.Point(129, 14);
            this.tbx_NameSearch.Name = "tbx_NameSearch";
            this.tbx_NameSearch.Size = new System.Drawing.Size(406, 33);
            this.tbx_NameSearch.TabIndex = 6;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.ForeColor = System.Drawing.Color.White;
            this.metroLabel1.Location = new System.Drawing.Point(0, 19);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(105, 25);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Tên dự án:";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // metroPanel8
            // 
            this.metroPanel8.BackColor = System.Drawing.Color.Transparent;
            this.metroPanel8.Controls.Add(this.dtp_EndDateSearch);
            this.metroPanel8.Controls.Add(this.metroLabel8);
            this.metroPanel8.HorizontalScrollbarBarColor = true;
            this.metroPanel8.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel8.HorizontalScrollbarSize = 10;
            this.metroPanel8.Location = new System.Drawing.Point(322, 712);
            this.metroPanel8.Name = "metroPanel8";
            this.metroPanel8.Size = new System.Drawing.Size(257, 42);
            this.metroPanel8.TabIndex = 27;
            this.metroPanel8.UseCustomBackColor = true;
            this.metroPanel8.VerticalScrollbarBarColor = true;
            this.metroPanel8.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel8.VerticalScrollbarSize = 10;
            // 
            // dtp_EndDateSearch
            // 
            this.dtp_EndDateSearch.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_EndDateSearch.CustomFormat = "dd/MM/yyyy";
            this.dtp_EndDateSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_EndDateSearch.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_EndDateSearch.Location = new System.Drawing.Point(124, 11);
            this.dtp_EndDateSearch.Name = "dtp_EndDateSearch";
            this.dtp_EndDateSearch.Size = new System.Drawing.Size(130, 27);
            this.dtp_EndDateSearch.TabIndex = 3;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel8.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel8.ForeColor = System.Drawing.Color.White;
            this.metroLabel8.Location = new System.Drawing.Point(0, 11);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(102, 25);
            this.metroLabel8.TabIndex = 2;
            this.metroLabel8.Text = "Đến ngày:";
            this.metroLabel8.UseCustomBackColor = true;
            this.metroLabel8.UseCustomForeColor = true;
            // 
            // metroPanel9
            // 
            this.metroPanel9.BackColor = System.Drawing.Color.Transparent;
            this.metroPanel9.Controls.Add(this.dtp_StartDateSearch);
            this.metroPanel9.Controls.Add(this.metroLabel9);
            this.metroPanel9.HorizontalScrollbarBarColor = true;
            this.metroPanel9.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel9.HorizontalScrollbarSize = 10;
            this.metroPanel9.Location = new System.Drawing.Point(44, 712);
            this.metroPanel9.Name = "metroPanel9";
            this.metroPanel9.Size = new System.Drawing.Size(272, 42);
            this.metroPanel9.TabIndex = 26;
            this.metroPanel9.UseCustomBackColor = true;
            this.metroPanel9.VerticalScrollbarBarColor = true;
            this.metroPanel9.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel9.VerticalScrollbarSize = 10;
            // 
            // dtp_StartDateSearch
            // 
            this.dtp_StartDateSearch.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_StartDateSearch.CustomFormat = "dd/MM/yyyy";
            this.dtp_StartDateSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_StartDateSearch.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_StartDateSearch.Location = new System.Drawing.Point(129, 11);
            this.dtp_StartDateSearch.Name = "dtp_StartDateSearch";
            this.dtp_StartDateSearch.Size = new System.Drawing.Size(130, 27);
            this.dtp_StartDateSearch.TabIndex = 3;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel9.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel9.ForeColor = System.Drawing.Color.White;
            this.metroLabel9.Location = new System.Drawing.Point(0, 11);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(90, 25);
            this.metroLabel9.TabIndex = 2;
            this.metroLabel9.Text = "Từ ngày:";
            this.metroLabel9.UseCustomBackColor = true;
            this.metroLabel9.UseCustomForeColor = true;
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.Transparent;
            this.btn_Search.BackgroundImage = global::iLAB.Properties.Resources.search_icon_png_4;
            this.btn_Search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Search.FlatAppearance.BorderSize = 0;
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search.Location = new System.Drawing.Point(604, 616);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(100, 105);
            this.btn_Search.TabIndex = 28;
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // metroPanel10
            // 
            this.metroPanel10.Controls.Add(this.tbx_ID);
            this.metroPanel10.Controls.Add(this.panel5);
            this.metroPanel10.Controls.Add(this.metroLabel10);
            this.metroPanel10.HorizontalScrollbarBarColor = true;
            this.metroPanel10.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel10.HorizontalScrollbarSize = 10;
            this.metroPanel10.Location = new System.Drawing.Point(21, 3);
            this.metroPanel10.Name = "metroPanel10";
            this.metroPanel10.Size = new System.Drawing.Size(270, 57);
            this.metroPanel10.TabIndex = 29;
            this.metroPanel10.VerticalScrollbarBarColor = true;
            this.metroPanel10.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel10.VerticalScrollbarSize = 10;
            // 
            // tbx_ID
            // 
            this.tbx_ID.BackColor = System.Drawing.Color.White;
            this.tbx_ID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbx_ID.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_ID.Location = new System.Drawing.Point(123, 18);
            this.tbx_ID.Name = "tbx_ID";
            this.tbx_ID.Size = new System.Drawing.Size(100, 28);
            this.tbx_ID.TabIndex = 6;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel5.Location = new System.Drawing.Point(120, 50);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(100, 2);
            this.panel5.TabIndex = 7;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel10.Location = new System.Drawing.Point(0, 19);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(91, 25);
            this.metroLabel10.TabIndex = 2;
            this.metroLabel10.Text = "Mã dự án:";
            // 
            // pn_ProjectDetail
            // 
            this.pn_ProjectDetail.BackColor = System.Drawing.Color.Transparent;
            this.pn_ProjectDetail.Controls.Add(this.btn_SaveChange);
            this.pn_ProjectDetail.Controls.Add(this.metroPanel11);
            this.pn_ProjectDetail.Controls.Add(this.metroPanel10);
            this.pn_ProjectDetail.Controls.Add(this.metroPanel1);
            this.pn_ProjectDetail.Controls.Add(this.metroPanel3);
            this.pn_ProjectDetail.Controls.Add(this.metroPanel6);
            this.pn_ProjectDetail.Controls.Add(this.metroPanel4);
            this.pn_ProjectDetail.Controls.Add(this.metroPanel5);
            this.pn_ProjectDetail.Controls.Add(this.metroPanel7);
            this.pn_ProjectDetail.Enabled = false;
            this.pn_ProjectDetail.Location = new System.Drawing.Point(767, 200);
            this.pn_ProjectDetail.Name = "pn_ProjectDetail";
            this.pn_ProjectDetail.Size = new System.Drawing.Size(583, 564);
            this.pn_ProjectDetail.TabIndex = 30;
            // 
            // btn_SaveChange
            // 
            this.btn_SaveChange.BackColor = System.Drawing.Color.White;
            this.btn_SaveChange.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SaveChange.ForeColor = System.Drawing.Color.DarkBlue;
            this.btn_SaveChange.Location = new System.Drawing.Point(434, 519);
            this.btn_SaveChange.Name = "btn_SaveChange";
            this.btn_SaveChange.Size = new System.Drawing.Size(133, 35);
            this.btn_SaveChange.TabIndex = 31;
            this.btn_SaveChange.Text = "Lưu thay đổi";
            this.btn_SaveChange.UseVisualStyleBackColor = false;
            this.btn_SaveChange.Click += new System.EventHandler(this.btn_SaveChange_Click);
            // 
            // metroPanel11
            // 
            this.metroPanel11.Controls.Add(this.cbb_LeaderName);
            this.metroPanel11.Controls.Add(this.metroLabel11);
            this.metroPanel11.HorizontalScrollbarBarColor = true;
            this.metroPanel11.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel11.HorizontalScrollbarSize = 10;
            this.metroPanel11.Location = new System.Drawing.Point(21, 389);
            this.metroPanel11.Name = "metroPanel11";
            this.metroPanel11.Size = new System.Drawing.Size(560, 57);
            this.metroPanel11.TabIndex = 30;
            this.metroPanel11.VerticalScrollbarBarColor = true;
            this.metroPanel11.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel11.VerticalScrollbarSize = 10;
            // 
            // cbb_LeaderName
            // 
            this.cbb_LeaderName.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_LeaderName.FormattingEnabled = true;
            this.cbb_LeaderName.Location = new System.Drawing.Point(120, 14);
            this.cbb_LeaderName.Name = "cbb_LeaderName";
            this.cbb_LeaderName.Size = new System.Drawing.Size(359, 36);
            this.cbb_LeaderName.TabIndex = 8;
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel11.Location = new System.Drawing.Point(0, 19);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(72, 25);
            this.metroLabel11.TabIndex = 2;
            this.metroLabel11.Text = "Leader:";
            // 
            // btn_Reset
            // 
            this.btn_Reset.BackColor = System.Drawing.Color.Green;
            this.btn_Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Reset.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reset.ForeColor = System.Drawing.Color.White;
            this.btn_Reset.Location = new System.Drawing.Point(29, 550);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(105, 35);
            this.btn_Reset.TabIndex = 32;
            this.btn_Reset.Text = "Làm mới";
            this.btn_Reset.UseVisualStyleBackColor = false;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // cb_Name
            // 
            this.cb_Name.AutoSize = true;
            this.cb_Name.BackColor = System.Drawing.Color.Transparent;
            this.cb_Name.Location = new System.Drawing.Point(44, 625);
            this.cb_Name.Name = "cb_Name";
            this.cb_Name.Size = new System.Drawing.Size(109, 21);
            this.cb_Name.TabIndex = 33;
            this.cb_Name.Text = "Lọc theo tên";
            this.cb_Name.UseVisualStyleBackColor = false;
            // 
            // cb_Date
            // 
            this.cb_Date.AutoSize = true;
            this.cb_Date.BackColor = System.Drawing.Color.Transparent;
            this.cb_Date.Location = new System.Drawing.Point(159, 625);
            this.cb_Date.Name = "cb_Date";
            this.cb_Date.Size = new System.Drawing.Size(120, 21);
            this.cb_Date.TabIndex = 34;
            this.cb_Date.Text = "Lọc theo ngày";
            this.cb_Date.UseVisualStyleBackColor = false;
            // 
            // f_ProjectEdit
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackgroundImage = global::iLAB.Properties.Resources.iLAB_Thong__1_1;
            this.ClientSize = new System.Drawing.Size(1364, 766);
            this.ControlBox = false;
            this.Controls.Add(this.cb_Date);
            this.Controls.Add(this.cb_Name);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.pn_ProjectDetail);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.metroPanel8);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.metroPanel9);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.ml_Close);
            this.Controls.Add(this.dtgv_ListProject);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "f_ProjectEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_ListProject)).EndInit();
            this.metroPanel7.ResumeLayout(false);
            this.metroPanel7.PerformLayout();
            this.metroPanel5.ResumeLayout(false);
            this.metroPanel5.PerformLayout();
            this.metroPanel4.ResumeLayout(false);
            this.metroPanel4.PerformLayout();
            this.metroPanel6.ResumeLayout(false);
            this.metroPanel6.PerformLayout();
            this.metroPanel3.ResumeLayout(false);
            this.metroPanel3.PerformLayout();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            this.metroPanel8.ResumeLayout(false);
            this.metroPanel8.PerformLayout();
            this.metroPanel9.ResumeLayout(false);
            this.metroPanel9.PerformLayout();
            this.metroPanel10.ResumeLayout(false);
            this.metroPanel10.PerformLayout();
            this.pn_ProjectDetail.ResumeLayout(false);
            this.metroPanel11.ResumeLayout(false);
            this.metroPanel11.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgv_ListProject;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_IDLeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Task;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Start;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Finish;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Employee;
        private MetroFramework.Controls.MetroPanel metroPanel7;
        private System.Windows.Forms.TextBox tbx_LeaderID;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroPanel metroPanel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroPanel metroPanel4;
        private System.Windows.Forms.DateTimePicker dtp_End;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroPanel metroPanel6;
        private System.Windows.Forms.DateTimePicker dtp_Start;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private System.Windows.Forms.TextBox tbx_Description;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.TextBox tbx_Name;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Add;
        private MetroFramework.Controls.MetroLink ml_Close;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private System.Windows.Forms.TextBox tbx_NameSearch;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroPanel metroPanel8;
        private System.Windows.Forms.DateTimePicker dtp_EndDateSearch;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroPanel metroPanel9;
        private System.Windows.Forms.DateTimePicker dtp_StartDateSearch;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private System.Windows.Forms.Button btn_Search;
        private MetroFramework.Controls.MetroPanel metroPanel10;
        private System.Windows.Forms.TextBox tbx_ID;
        private System.Windows.Forms.Panel panel5;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private System.Windows.Forms.Panel pn_ProjectDetail;
        private MetroFramework.Controls.MetroPanel metroPanel11;
        private System.Windows.Forms.ComboBox cbb_LeaderName;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private System.Windows.Forms.ComboBox cbb_Status;
        private System.Windows.Forms.Button btn_SaveChange;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.CheckBox cb_Name;
        private System.Windows.Forms.CheckBox cb_Date;
    }
}