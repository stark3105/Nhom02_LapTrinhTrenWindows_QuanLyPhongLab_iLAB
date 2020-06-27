namespace iLAB.Views
{
    partial class f_TaskEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f_TaskEdit));
            this.mlb_ChooseProject = new MetroFramework.Controls.MetroLabel();
            this.cbb_ChooseProject = new System.Windows.Forms.ComboBox();
            this.dtgv_ListTask = new System.Windows.Forms.DataGridView();
            this.col_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_IDProject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Link = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Projetc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Start = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Finish = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Employee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ml_Close = new MetroFramework.Controls.MetroLink();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.pn_TaskDetail = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tbx_SearchName = new System.Windows.Forms.TextBox();
            this.lbx_SeachEmployee = new System.Windows.Forms.ListBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbx_ListEmployee = new System.Windows.Forms.ListBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.tbx_Link = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btn_SaveChange = new System.Windows.Forms.Button();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.tbx_Name = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.tbx_Description = new System.Windows.Forms.TextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel6 = new MetroFramework.Controls.MetroPanel();
            this.dtp_Start = new System.Windows.Forms.DateTimePicker();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel4 = new MetroFramework.Controls.MetroPanel();
            this.dtp_End = new System.Windows.Forms.DateTimePicker();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel5 = new MetroFramework.Controls.MetroPanel();
            this.cbb_Status = new System.Windows.Forms.ComboBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.metroPanel10 = new MetroFramework.Controls.MetroPanel();
            this.tbx_ID = new System.Windows.Forms.TextBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_ListTask)).BeginInit();
            this.pn_TaskDetail.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.metroPanel3.SuspendLayout();
            this.metroPanel6.SuspendLayout();
            this.metroPanel4.SuspendLayout();
            this.metroPanel5.SuspendLayout();
            this.metroPanel10.SuspendLayout();
            this.SuspendLayout();
            // 
            // mlb_ChooseProject
            // 
            this.mlb_ChooseProject.AutoSize = true;
            this.mlb_ChooseProject.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mlb_ChooseProject.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.mlb_ChooseProject.Location = new System.Drawing.Point(32, 143);
            this.mlb_ChooseProject.Name = "mlb_ChooseProject";
            this.mlb_ChooseProject.Size = new System.Drawing.Size(116, 25);
            this.mlb_ChooseProject.TabIndex = 0;
            this.mlb_ChooseProject.Text = "Chọn dự án";
            // 
            // cbb_ChooseProject
            // 
            this.cbb_ChooseProject.Font = new System.Drawing.Font("UVN Thoi Nay Nang", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_ChooseProject.ForeColor = System.Drawing.Color.Black;
            this.cbb_ChooseProject.FormattingEnabled = true;
            this.cbb_ChooseProject.Location = new System.Drawing.Point(154, 139);
            this.cbb_ChooseProject.Name = "cbb_ChooseProject";
            this.cbb_ChooseProject.Size = new System.Drawing.Size(593, 35);
            this.cbb_ChooseProject.TabIndex = 1;
            this.cbb_ChooseProject.Text = "Tên dự án";
            this.cbb_ChooseProject.SelectedIndexChanged += new System.EventHandler(this.cbb_ChooseProject_SelectedIndexChanged);
            // 
            // dtgv_ListTask
            // 
            this.dtgv_ListTask.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_ListTask.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_ListTask.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_ID,
            this.col_IDProject,
            this.col_Link,
            this.col_Projetc,
            this.col_Description,
            this.col_Name,
            this.col_Start,
            this.col_Finish,
            this.col_Status,
            this.col_Employee});
            this.dtgv_ListTask.Location = new System.Drawing.Point(32, 278);
            this.dtgv_ListTask.Name = "dtgv_ListTask";
            this.dtgv_ListTask.ReadOnly = true;
            this.dtgv_ListTask.RowHeadersWidth = 51;
            this.dtgv_ListTask.RowTemplate.Height = 24;
            this.dtgv_ListTask.Size = new System.Drawing.Size(715, 441);
            this.dtgv_ListTask.TabIndex = 4;
            this.dtgv_ListTask.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_ListTask_CellClick);
            // 
            // col_ID
            // 
            this.col_ID.HeaderText = "Mã công việc";
            this.col_ID.MinimumWidth = 6;
            this.col_ID.Name = "col_ID";
            this.col_ID.ReadOnly = true;
            // 
            // col_IDProject
            // 
            this.col_IDProject.HeaderText = "IDProject";
            this.col_IDProject.MinimumWidth = 6;
            this.col_IDProject.Name = "col_IDProject";
            this.col_IDProject.ReadOnly = true;
            this.col_IDProject.Visible = false;
            // 
            // col_Link
            // 
            this.col_Link.HeaderText = "Link tài liệu";
            this.col_Link.MinimumWidth = 6;
            this.col_Link.Name = "col_Link";
            this.col_Link.ReadOnly = true;
            this.col_Link.Visible = false;
            // 
            // col_Projetc
            // 
            this.col_Projetc.HeaderText = "Project";
            this.col_Projetc.MinimumWidth = 6;
            this.col_Projetc.Name = "col_Projetc";
            this.col_Projetc.ReadOnly = true;
            this.col_Projetc.Visible = false;
            // 
            // col_Description
            // 
            this.col_Description.HeaderText = "Mô tả";
            this.col_Description.MinimumWidth = 6;
            this.col_Description.Name = "col_Description";
            this.col_Description.ReadOnly = true;
            this.col_Description.Visible = false;
            // 
            // col_Name
            // 
            this.col_Name.HeaderText = "Tên công việc";
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
            this.col_Employee.HeaderText = "Employees";
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
            this.ml_Close.Location = new System.Drawing.Point(23, 37);
            this.ml_Close.Name = "ml_Close";
            this.ml_Close.Size = new System.Drawing.Size(30, 30);
            this.ml_Close.TabIndex = 16;
            this.ml_Close.UseSelectable = true;
            this.ml_Close.Click += new System.EventHandler(this.ml_Close_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.Color.Transparent;
            this.btn_Delete.BackgroundImage = global::iLAB.Properties.Resources.delete_button;
            this.btn_Delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Delete.FlatAppearance.BorderSize = 0;
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Delete.Location = new System.Drawing.Point(1319, 137);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(35, 35);
            this.btn_Delete.TabIndex = 27;
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
            this.btn_Update.Location = new System.Drawing.Point(1278, 137);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(35, 35);
            this.btn_Update.TabIndex = 26;
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
            this.btn_Add.Location = new System.Drawing.Point(1232, 134);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(40, 40);
            this.btn_Add.TabIndex = 25;
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // pn_TaskDetail
            // 
            this.pn_TaskDetail.BackColor = System.Drawing.Color.Transparent;
            this.pn_TaskDetail.Controls.Add(this.panel4);
            this.pn_TaskDetail.Controls.Add(this.panel3);
            this.pn_TaskDetail.Controls.Add(this.metroPanel2);
            this.pn_TaskDetail.Controls.Add(this.btn_SaveChange);
            this.pn_TaskDetail.Controls.Add(this.metroPanel1);
            this.pn_TaskDetail.Controls.Add(this.metroPanel3);
            this.pn_TaskDetail.Controls.Add(this.metroPanel6);
            this.pn_TaskDetail.Controls.Add(this.metroPanel4);
            this.pn_TaskDetail.Controls.Add(this.metroPanel5);
            this.pn_TaskDetail.Enabled = false;
            this.pn_TaskDetail.Location = new System.Drawing.Point(771, 197);
            this.pn_TaskDetail.Name = "pn_TaskDetail";
            this.pn_TaskDetail.Size = new System.Drawing.Size(583, 570);
            this.pn_TaskDetail.TabIndex = 31;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tbx_SearchName);
            this.panel4.Controls.Add(this.lbx_SeachEmployee);
            this.panel4.Controls.Add(this.metroLabel8);
            this.panel4.Location = new System.Drawing.Point(370, 410);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(210, 115);
            this.panel4.TabIndex = 34;
            // 
            // tbx_SearchName
            // 
            this.tbx_SearchName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tbx_SearchName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbx_SearchName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_SearchName.Location = new System.Drawing.Point(3, 33);
            this.tbx_SearchName.Name = "tbx_SearchName";
            this.tbx_SearchName.Size = new System.Drawing.Size(204, 27);
            this.tbx_SearchName.TabIndex = 6;
            this.tbx_SearchName.TextChanged += new System.EventHandler(this.tbx_SearchName_TextChanged);
            // 
            // lbx_SeachEmployee
            // 
            this.lbx_SeachEmployee.FormattingEnabled = true;
            this.lbx_SeachEmployee.ItemHeight = 16;
            this.lbx_SeachEmployee.Location = new System.Drawing.Point(3, 58);
            this.lbx_SeachEmployee.Name = "lbx_SeachEmployee";
            this.lbx_SeachEmployee.Size = new System.Drawing.Size(204, 52);
            this.lbx_SeachEmployee.TabIndex = 5;
            this.lbx_SeachEmployee.Visible = false;
            this.lbx_SeachEmployee.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbx_SeachEmployee_MouseDoubleClick);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel8.Location = new System.Drawing.Point(0, 0);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(134, 25);
            this.metroLabel8.TabIndex = 3;
            this.metroLabel8.Text = "Tìm thành viên:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lbx_ListEmployee);
            this.panel3.Controls.Add(this.metroLabel7);
            this.panel3.Location = new System.Drawing.Point(20, 410);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(344, 168);
            this.panel3.TabIndex = 33;
            // 
            // lbx_ListEmployee
            // 
            this.lbx_ListEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbx_ListEmployee.FormattingEnabled = true;
            this.lbx_ListEmployee.ItemHeight = 20;
            this.lbx_ListEmployee.Location = new System.Drawing.Point(3, 33);
            this.lbx_ListEmployee.Name = "lbx_ListEmployee";
            this.lbx_ListEmployee.Size = new System.Drawing.Size(338, 124);
            this.lbx_ListEmployee.TabIndex = 4;
            this.lbx_ListEmployee.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbx_ListEmployee_MouseDoubleClick);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel7.Location = new System.Drawing.Point(0, 0);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(185, 25);
            this.metroLabel7.TabIndex = 3;
            this.metroLabel7.Text = "Danh sách thành viên:";
            // 
            // metroPanel2
            // 
            this.metroPanel2.BackColor = System.Drawing.Color.White;
            this.metroPanel2.Controls.Add(this.tbx_Link);
            this.metroPanel2.Controls.Add(this.panel2);
            this.metroPanel2.Controls.Add(this.metroLabel1);
            this.metroPanel2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(23, 351);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(560, 57);
            this.metroPanel2.TabIndex = 32;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // tbx_Link
            // 
            this.tbx_Link.BackColor = System.Drawing.Color.White;
            this.tbx_Link.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbx_Link.Font = new System.Drawing.Font("UTM Essendine Caps", 10.2F);
            this.tbx_Link.Location = new System.Drawing.Point(130, 21);
            this.tbx_Link.Name = "tbx_Link";
            this.tbx_Link.Size = new System.Drawing.Size(416, 24);
            this.tbx_Link.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.Location = new System.Drawing.Point(125, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(420, 2);
            this.panel2.TabIndex = 7;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(0, 19);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(100, 25);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Link tài liệu";
            // 
            // btn_SaveChange
            // 
            this.btn_SaveChange.BackColor = System.Drawing.Color.White;
            this.btn_SaveChange.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SaveChange.ForeColor = System.Drawing.Color.DarkBlue;
            this.btn_SaveChange.Location = new System.Drawing.Point(373, 530);
            this.btn_SaveChange.Name = "btn_SaveChange";
            this.btn_SaveChange.Size = new System.Drawing.Size(204, 35);
            this.btn_SaveChange.TabIndex = 31;
            this.btn_SaveChange.Text = "Lưu thay đổi";
            this.btn_SaveChange.UseVisualStyleBackColor = false;
            this.btn_SaveChange.Click += new System.EventHandler(this.btn_SaveChange_Click);
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
            this.metroPanel1.Location = new System.Drawing.Point(23, 59);
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
            this.tbx_Name.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_Name.Location = new System.Drawing.Point(130, 20);
            this.tbx_Name.Name = "tbx_Name";
            this.tbx_Name.Size = new System.Drawing.Size(416, 25);
            this.tbx_Name.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Location = new System.Drawing.Point(125, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(420, 2);
            this.panel1.TabIndex = 7;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(0, 19);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(124, 25);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Tên công việc:";
            // 
            // metroPanel3
            // 
            this.metroPanel3.Controls.Add(this.tbx_Description);
            this.metroPanel3.Controls.Add(this.metroLabel3);
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(23, 122);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(560, 99);
            this.metroPanel3.TabIndex = 15;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
            // 
            // tbx_Description
            // 
            this.tbx_Description.BackColor = System.Drawing.Color.White;
            this.tbx_Description.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbx_Description.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_Description.Location = new System.Drawing.Point(130, 22);
            this.tbx_Description.Multiline = true;
            this.tbx_Description.Name = "tbx_Description";
            this.tbx_Description.Size = new System.Drawing.Size(416, 68);
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
            // metroPanel6
            // 
            this.metroPanel6.Controls.Add(this.dtp_Start);
            this.metroPanel6.Controls.Add(this.metroLabel5);
            this.metroPanel6.HorizontalScrollbarBarColor = true;
            this.metroPanel6.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel6.HorizontalScrollbarSize = 10;
            this.metroPanel6.Location = new System.Drawing.Point(23, 225);
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
            this.dtp_Start.Location = new System.Drawing.Point(120, 18);
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
            // metroPanel4
            // 
            this.metroPanel4.Controls.Add(this.dtp_End);
            this.metroPanel4.Controls.Add(this.metroLabel4);
            this.metroPanel4.HorizontalScrollbarBarColor = true;
            this.metroPanel4.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel4.HorizontalScrollbarSize = 10;
            this.metroPanel4.Location = new System.Drawing.Point(323, 225);
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
            this.dtp_End.Location = new System.Drawing.Point(98, 18);
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
            // metroPanel5
            // 
            this.metroPanel5.Controls.Add(this.cbb_Status);
            this.metroPanel5.Controls.Add(this.metroLabel6);
            this.metroPanel5.HorizontalScrollbarBarColor = true;
            this.metroPanel5.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel5.HorizontalScrollbarSize = 10;
            this.metroPanel5.Location = new System.Drawing.Point(23, 288);
            this.metroPanel5.Name = "metroPanel5";
            this.metroPanel5.Size = new System.Drawing.Size(560, 57);
            this.metroPanel5.TabIndex = 18;
            this.metroPanel5.VerticalScrollbarBarColor = true;
            this.metroPanel5.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel5.VerticalScrollbarSize = 10;
            // 
            // cbb_Status
            // 
            this.cbb_Status.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_Status.FormattingEnabled = true;
            this.cbb_Status.Items.AddRange(new object[] {
            "Đã hoàn thành",
            "Chưa hoàn thành"});
            this.cbb_Status.Location = new System.Drawing.Point(120, 17);
            this.cbb_Status.Name = "cbb_Status";
            this.cbb_Status.Size = new System.Drawing.Size(222, 32);
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
            // btn_Reset
            // 
            this.btn_Reset.BackColor = System.Drawing.Color.Green;
            this.btn_Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Reset.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reset.ForeColor = System.Drawing.Color.White;
            this.btn_Reset.Location = new System.Drawing.Point(642, 724);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(105, 35);
            this.btn_Reset.TabIndex = 33;
            this.btn_Reset.Text = "Làm mới";
            this.btn_Reset.UseVisualStyleBackColor = false;
            // 
            // metroPanel10
            // 
            this.metroPanel10.Controls.Add(this.tbx_ID);
            this.metroPanel10.Controls.Add(this.metroLabel10);
            this.metroPanel10.Enabled = false;
            this.metroPanel10.HorizontalScrollbarBarColor = true;
            this.metroPanel10.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel10.HorizontalScrollbarSize = 10;
            this.metroPanel10.Location = new System.Drawing.Point(794, 197);
            this.metroPanel10.Name = "metroPanel10";
            this.metroPanel10.Size = new System.Drawing.Size(270, 57);
            this.metroPanel10.TabIndex = 35;
            this.metroPanel10.VerticalScrollbarBarColor = true;
            this.metroPanel10.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel10.VerticalScrollbarSize = 10;
            // 
            // tbx_ID
            // 
            this.tbx_ID.BackColor = System.Drawing.Color.White;
            this.tbx_ID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbx_ID.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_ID.Location = new System.Drawing.Point(130, 21);
            this.tbx_ID.Name = "tbx_ID";
            this.tbx_ID.ReadOnly = true;
            this.tbx_ID.Size = new System.Drawing.Size(90, 25);
            this.tbx_ID.TabIndex = 6;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel10.Location = new System.Drawing.Point(0, 19);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(122, 25);
            this.metroLabel10.TabIndex = 2;
            this.metroLabel10.Text = "Mã công việc:";
            // 
            // f_TaskEdit
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackgroundImage = global::iLAB.Properties.Resources.iLAB_Thong__2_2;
            this.ClientSize = new System.Drawing.Size(1364, 766);
            this.ControlBox = false;
            this.Controls.Add(this.metroPanel10);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.pn_TaskDetail);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.ml_Close);
            this.Controls.Add(this.dtgv_ListTask);
            this.Controls.Add(this.cbb_ChooseProject);
            this.Controls.Add(this.mlb_ChooseProject);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "f_TaskEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_ListTask)).EndInit();
            this.pn_TaskDetail.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.metroPanel3.ResumeLayout(false);
            this.metroPanel3.PerformLayout();
            this.metroPanel6.ResumeLayout(false);
            this.metroPanel6.PerformLayout();
            this.metroPanel4.ResumeLayout(false);
            this.metroPanel4.PerformLayout();
            this.metroPanel5.ResumeLayout(false);
            this.metroPanel5.PerformLayout();
            this.metroPanel10.ResumeLayout(false);
            this.metroPanel10.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel mlb_ChooseProject;
        private System.Windows.Forms.ComboBox cbb_ChooseProject;
        private System.Windows.Forms.DataGridView dtgv_ListTask;
        private MetroFramework.Controls.MetroLink ml_Close;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Panel pn_TaskDetail;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox tbx_SearchName;
        private System.Windows.Forms.ListBox lbx_SeachEmployee;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListBox lbx_ListEmployee;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private System.Windows.Forms.TextBox tbx_Link;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.Button btn_SaveChange;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.TextBox tbx_Name;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private System.Windows.Forms.TextBox tbx_Description;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroPanel metroPanel6;
        private System.Windows.Forms.DateTimePicker dtp_Start;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroPanel metroPanel4;
        private System.Windows.Forms.DateTimePicker dtp_End;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroPanel metroPanel5;
        private System.Windows.Forms.ComboBox cbb_Status;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_IDProject;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Link;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Projetc;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Start;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Finish;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Employee;
        private MetroFramework.Controls.MetroPanel metroPanel10;
        private System.Windows.Forms.TextBox tbx_ID;
        private MetroFramework.Controls.MetroLabel metroLabel10;
    }
}