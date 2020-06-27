namespace iLAB
{
    partial class f_Employee
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f_Employee));
            this.dtgv_ListEmployee = new System.Windows.Forms.DataGridView();
            this.col_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Major = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Birthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_HourlyWages = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Projects = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Salaries = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Works = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Tasks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Image = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.btn_ClearControl = new System.Windows.Forms.Button();
            this.ptb_Avatar = new System.Windows.Forms.PictureBox();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.metroPanel9 = new MetroFramework.Controls.MetroPanel();
            this.tbx_HourlyWages = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel8 = new MetroFramework.Controls.MetroPanel();
            this.tbx_Email = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel7 = new MetroFramework.Controls.MetroPanel();
            this.tbx_Phone = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel6 = new MetroFramework.Controls.MetroPanel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel4 = new MetroFramework.Controls.MetroPanel();
            this.tbx_Position = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel5 = new MetroFramework.Controls.MetroPanel();
            this.tbx_Major = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.tbx_Name = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.tbx_ID = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ml_Close = new MetroFramework.Controls.MetroLink();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_ListEmployee)).BeginInit();
            this.panel1.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Avatar)).BeginInit();
            this.metroPanel9.SuspendLayout();
            this.metroPanel8.SuspendLayout();
            this.metroPanel7.SuspendLayout();
            this.metroPanel6.SuspendLayout();
            this.metroPanel4.SuspendLayout();
            this.metroPanel5.SuspendLayout();
            this.metroPanel3.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgv_ListEmployee
            // 
            this.dtgv_ListEmployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_ListEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_ListEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_ID,
            this.col_Name,
            this.col_Position,
            this.col_Major,
            this.col_Birthday,
            this.col_Phone,
            this.col_Email,
            this.col_HourlyWages,
            this.col_password,
            this.col_Projects,
            this.col_Salaries,
            this.col_Works,
            this.col_Tasks,
            this.col_Image});
            this.dtgv_ListEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgv_ListEmployee.Location = new System.Drawing.Point(0, 0);
            this.dtgv_ListEmployee.Name = "dtgv_ListEmployee";
            this.dtgv_ListEmployee.ReadOnly = true;
            this.dtgv_ListEmployee.RowHeadersVisible = false;
            this.dtgv_ListEmployee.RowHeadersWidth = 51;
            this.dtgv_ListEmployee.Size = new System.Drawing.Size(715, 508);
            this.dtgv_ListEmployee.TabIndex = 0;
            this.dtgv_ListEmployee.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_ListEmployee_CellClick);
            // 
            // col_ID
            // 
            this.col_ID.HeaderText = "ID Nhân viên";
            this.col_ID.MinimumWidth = 6;
            this.col_ID.Name = "col_ID";
            this.col_ID.ReadOnly = true;
            // 
            // col_Name
            // 
            this.col_Name.HeaderText = "Họ và tên";
            this.col_Name.MinimumWidth = 6;
            this.col_Name.Name = "col_Name";
            this.col_Name.ReadOnly = true;
            // 
            // col_Position
            // 
            this.col_Position.HeaderText = "Chức vụ";
            this.col_Position.MinimumWidth = 6;
            this.col_Position.Name = "col_Position";
            this.col_Position.ReadOnly = true;
            // 
            // col_Major
            // 
            this.col_Major.HeaderText = "Chuyên môn";
            this.col_Major.MinimumWidth = 6;
            this.col_Major.Name = "col_Major";
            this.col_Major.ReadOnly = true;
            // 
            // col_Birthday
            // 
            this.col_Birthday.HeaderText = "Birthday";
            this.col_Birthday.MinimumWidth = 6;
            this.col_Birthday.Name = "col_Birthday";
            this.col_Birthday.ReadOnly = true;
            this.col_Birthday.Visible = false;
            // 
            // col_Phone
            // 
            this.col_Phone.HeaderText = "Phone";
            this.col_Phone.MinimumWidth = 6;
            this.col_Phone.Name = "col_Phone";
            this.col_Phone.ReadOnly = true;
            this.col_Phone.Visible = false;
            // 
            // col_Email
            // 
            this.col_Email.HeaderText = "Email";
            this.col_Email.MinimumWidth = 6;
            this.col_Email.Name = "col_Email";
            this.col_Email.ReadOnly = true;
            this.col_Email.Visible = false;
            // 
            // col_HourlyWages
            // 
            this.col_HourlyWages.HeaderText = "HourlyWages";
            this.col_HourlyWages.MinimumWidth = 6;
            this.col_HourlyWages.Name = "col_HourlyWages";
            this.col_HourlyWages.ReadOnly = true;
            this.col_HourlyWages.Visible = false;
            // 
            // col_password
            // 
            this.col_password.HeaderText = "Password";
            this.col_password.MinimumWidth = 6;
            this.col_password.Name = "col_password";
            this.col_password.ReadOnly = true;
            this.col_password.Visible = false;
            // 
            // col_Projects
            // 
            this.col_Projects.HeaderText = "Projects";
            this.col_Projects.MinimumWidth = 6;
            this.col_Projects.Name = "col_Projects";
            this.col_Projects.ReadOnly = true;
            this.col_Projects.Visible = false;
            // 
            // col_Salaries
            // 
            this.col_Salaries.HeaderText = "Salaries";
            this.col_Salaries.MinimumWidth = 6;
            this.col_Salaries.Name = "col_Salaries";
            this.col_Salaries.ReadOnly = true;
            this.col_Salaries.Visible = false;
            // 
            // col_Works
            // 
            this.col_Works.HeaderText = "Works";
            this.col_Works.MinimumWidth = 6;
            this.col_Works.Name = "col_Works";
            this.col_Works.ReadOnly = true;
            this.col_Works.Visible = false;
            // 
            // col_Tasks
            // 
            this.col_Tasks.HeaderText = "Tasks";
            this.col_Tasks.MinimumWidth = 6;
            this.col_Tasks.Name = "col_Tasks";
            this.col_Tasks.ReadOnly = true;
            this.col_Tasks.Visible = false;
            // 
            // col_Image
            // 
            this.col_Image.HeaderText = "Ảnh";
            this.col_Image.MinimumWidth = 6;
            this.col_Image.Name = "col_Image";
            this.col_Image.ReadOnly = true;
            this.col_Image.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtgv_ListEmployee);
            this.panel1.Location = new System.Drawing.Point(28, 198);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(715, 508);
            this.panel1.TabIndex = 1;
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.Transparent;
            this.metroPanel1.Controls.Add(this.btn_ClearControl);
            this.metroPanel1.Controls.Add(this.ptb_Avatar);
            this.metroPanel1.Controls.Add(this.btn_Delete);
            this.metroPanel1.Controls.Add(this.btn_Update);
            this.metroPanel1.Controls.Add(this.btn_Add);
            this.metroPanel1.Controls.Add(this.metroPanel9);
            this.metroPanel1.Controls.Add(this.metroPanel8);
            this.metroPanel1.Controls.Add(this.metroPanel7);
            this.metroPanel1.Controls.Add(this.metroPanel6);
            this.metroPanel1.Controls.Add(this.metroPanel4);
            this.metroPanel1.Controls.Add(this.metroPanel5);
            this.metroPanel1.Controls.Add(this.metroPanel3);
            this.metroPanel1.Controls.Add(this.metroPanel2);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(767, 57);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(587, 660);
            this.metroPanel1.TabIndex = 2;
            this.metroPanel1.UseCustomBackColor = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // btn_ClearControl
            // 
            this.btn_ClearControl.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btn_ClearControl.FlatAppearance.BorderSize = 2;
            this.btn_ClearControl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ClearControl.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ClearControl.Location = new System.Drawing.Point(480, 612);
            this.btn_ClearControl.Name = "btn_ClearControl";
            this.btn_ClearControl.Size = new System.Drawing.Size(88, 37);
            this.btn_ClearControl.TabIndex = 16;
            this.btn_ClearControl.Text = "Reset";
            this.btn_ClearControl.UseVisualStyleBackColor = true;
            this.btn_ClearControl.Click += new System.EventHandler(this.btn_ClearControl_Click);
            // 
            // ptb_Avatar
            // 
            this.ptb_Avatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ptb_Avatar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptb_Avatar.Image = global::iLAB.Properties.Resources.ImgEmployee;
            this.ptb_Avatar.Location = new System.Drawing.Point(408, 156);
            this.ptb_Avatar.Name = "ptb_Avatar";
            this.ptb_Avatar.Size = new System.Drawing.Size(114, 120);
            this.ptb_Avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_Avatar.TabIndex = 5;
            this.ptb_Avatar.TabStop = false;
            this.ptb_Avatar.Click += new System.EventHandler(this.ptb_Avatar_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.Color.Transparent;
            this.btn_Delete.BackgroundImage = global::iLAB.Properties.Resources.delete_button;
            this.btn_Delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Delete.FlatAppearance.BorderSize = 0;
            this.btn_Delete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_Delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Delete.Location = new System.Drawing.Point(525, 197);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(50, 35);
            this.btn_Delete.TabIndex = 15;
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
            this.btn_Update.Location = new System.Drawing.Point(525, 156);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(50, 35);
            this.btn_Update.TabIndex = 14;
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
            this.btn_Add.Location = new System.Drawing.Point(408, 613);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(55, 36);
            this.btn_Add.TabIndex = 13;
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // metroPanel9
            // 
            this.metroPanel9.Controls.Add(this.tbx_HourlyWages);
            this.metroPanel9.Controls.Add(this.panel8);
            this.metroPanel9.Controls.Add(this.metroLabel8);
            this.metroPanel9.HorizontalScrollbarBarColor = true;
            this.metroPanel9.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel9.HorizontalScrollbarSize = 10;
            this.metroPanel9.Location = new System.Drawing.Point(5, 597);
            this.metroPanel9.Name = "metroPanel9";
            this.metroPanel9.Size = new System.Drawing.Size(363, 57);
            this.metroPanel9.TabIndex = 12;
            this.metroPanel9.VerticalScrollbarBarColor = true;
            this.metroPanel9.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel9.VerticalScrollbarSize = 10;
            // 
            // tbx_HourlyWages
            // 
            this.tbx_HourlyWages.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbx_HourlyWages.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_HourlyWages.Location = new System.Drawing.Point(137, 18);
            this.tbx_HourlyWages.Name = "tbx_HourlyWages";
            this.tbx_HourlyWages.Size = new System.Drawing.Size(200, 25);
            this.tbx_HourlyWages.TabIndex = 6;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.DarkGreen;
            this.panel8.Location = new System.Drawing.Point(137, 50);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(200, 2);
            this.panel8.TabIndex = 7;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel8.Location = new System.Drawing.Point(0, 19);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(96, 25);
            this.metroLabel8.TabIndex = 2;
            this.metroLabel8.Text = "Lương/giờ";
            // 
            // metroPanel8
            // 
            this.metroPanel8.Controls.Add(this.tbx_Email);
            this.metroPanel8.Controls.Add(this.panel7);
            this.metroPanel8.Controls.Add(this.metroLabel7);
            this.metroPanel8.HorizontalScrollbarBarColor = true;
            this.metroPanel8.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel8.HorizontalScrollbarSize = 10;
            this.metroPanel8.Location = new System.Drawing.Point(5, 534);
            this.metroPanel8.Name = "metroPanel8";
            this.metroPanel8.Size = new System.Drawing.Size(563, 57);
            this.metroPanel8.TabIndex = 11;
            this.metroPanel8.VerticalScrollbarBarColor = true;
            this.metroPanel8.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel8.VerticalScrollbarSize = 10;
            // 
            // tbx_Email
            // 
            this.tbx_Email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbx_Email.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_Email.Location = new System.Drawing.Point(137, 18);
            this.tbx_Email.Name = "tbx_Email";
            this.tbx_Email.Size = new System.Drawing.Size(400, 25);
            this.tbx_Email.TabIndex = 6;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.DarkGreen;
            this.panel7.Location = new System.Drawing.Point(137, 50);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(400, 2);
            this.panel7.TabIndex = 7;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel7.Location = new System.Drawing.Point(0, 19);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(59, 25);
            this.metroLabel7.TabIndex = 2;
            this.metroLabel7.Text = "Email:";
            // 
            // metroPanel7
            // 
            this.metroPanel7.Controls.Add(this.tbx_Phone);
            this.metroPanel7.Controls.Add(this.panel6);
            this.metroPanel7.Controls.Add(this.metroLabel6);
            this.metroPanel7.HorizontalScrollbarBarColor = true;
            this.metroPanel7.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel7.HorizontalScrollbarSize = 10;
            this.metroPanel7.Location = new System.Drawing.Point(5, 471);
            this.metroPanel7.Name = "metroPanel7";
            this.metroPanel7.Size = new System.Drawing.Size(563, 57);
            this.metroPanel7.TabIndex = 10;
            this.metroPanel7.VerticalScrollbarBarColor = true;
            this.metroPanel7.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel7.VerticalScrollbarSize = 10;
            // 
            // tbx_Phone
            // 
            this.tbx_Phone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbx_Phone.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_Phone.Location = new System.Drawing.Point(137, 18);
            this.tbx_Phone.Name = "tbx_Phone";
            this.tbx_Phone.Size = new System.Drawing.Size(400, 25);
            this.tbx_Phone.TabIndex = 6;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.DarkGreen;
            this.panel6.Location = new System.Drawing.Point(137, 50);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(400, 2);
            this.panel6.TabIndex = 7;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.Location = new System.Drawing.Point(0, 19);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(121, 25);
            this.metroLabel6.TabIndex = 2;
            this.metroLabel6.Text = "Số điện thoại:";
            // 
            // metroPanel6
            // 
            this.metroPanel6.Controls.Add(this.dateTimePicker1);
            this.metroPanel6.Controls.Add(this.metroLabel5);
            this.metroPanel6.HorizontalScrollbarBarColor = true;
            this.metroPanel6.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel6.HorizontalScrollbarSize = 10;
            this.metroPanel6.Location = new System.Drawing.Point(5, 408);
            this.metroPanel6.Name = "metroPanel6";
            this.metroPanel6.Size = new System.Drawing.Size(563, 57);
            this.metroPanel6.TabIndex = 9;
            this.metroPanel6.VerticalScrollbarBarColor = true;
            this.metroPanel6.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel6.VerticalScrollbarSize = 10;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(135, 14);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(228, 30);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.Location = new System.Drawing.Point(0, 19);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(94, 25);
            this.metroLabel5.TabIndex = 2;
            this.metroLabel5.Text = "Ngày sinh:";
            // 
            // metroPanel4
            // 
            this.metroPanel4.Controls.Add(this.tbx_Position);
            this.metroPanel4.Controls.Add(this.panel4);
            this.metroPanel4.Controls.Add(this.metroLabel3);
            this.metroPanel4.HorizontalScrollbarBarColor = true;
            this.metroPanel4.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel4.HorizontalScrollbarSize = 10;
            this.metroPanel4.Location = new System.Drawing.Point(3, 345);
            this.metroPanel4.Name = "metroPanel4";
            this.metroPanel4.Size = new System.Drawing.Size(281, 57);
            this.metroPanel4.TabIndex = 8;
            this.metroPanel4.VerticalScrollbarBarColor = true;
            this.metroPanel4.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel4.VerticalScrollbarSize = 10;
            // 
            // tbx_Position
            // 
            this.tbx_Position.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbx_Position.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_Position.Location = new System.Drawing.Point(137, 18);
            this.tbx_Position.Name = "tbx_Position";
            this.tbx_Position.Size = new System.Drawing.Size(136, 25);
            this.tbx_Position.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkGreen;
            this.panel4.Location = new System.Drawing.Point(137, 50);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(136, 2);
            this.panel4.TabIndex = 7;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.Location = new System.Drawing.Point(0, 19);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(80, 25);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Chức vụ:";
            // 
            // metroPanel5
            // 
            this.metroPanel5.Controls.Add(this.tbx_Major);
            this.metroPanel5.Controls.Add(this.panel5);
            this.metroPanel5.Controls.Add(this.metroLabel4);
            this.metroPanel5.HorizontalScrollbarBarColor = true;
            this.metroPanel5.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel5.HorizontalScrollbarSize = 10;
            this.metroPanel5.Location = new System.Drawing.Point(285, 345);
            this.metroPanel5.Name = "metroPanel5";
            this.metroPanel5.Size = new System.Drawing.Size(283, 57);
            this.metroPanel5.TabIndex = 7;
            this.metroPanel5.VerticalScrollbarBarColor = true;
            this.metroPanel5.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel5.VerticalScrollbarSize = 10;
            // 
            // tbx_Major
            // 
            this.tbx_Major.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbx_Major.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_Major.Location = new System.Drawing.Point(137, 18);
            this.tbx_Major.Name = "tbx_Major";
            this.tbx_Major.Size = new System.Drawing.Size(136, 25);
            this.tbx_Major.TabIndex = 6;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DarkGreen;
            this.panel5.Location = new System.Drawing.Point(137, 50);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(136, 2);
            this.panel5.TabIndex = 7;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.Location = new System.Drawing.Point(0, 19);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(119, 25);
            this.metroLabel4.TabIndex = 2;
            this.metroLabel4.Text = "Chuyên môn:";
            // 
            // metroPanel3
            // 
            this.metroPanel3.Controls.Add(this.tbx_Name);
            this.metroPanel3.Controls.Add(this.panel3);
            this.metroPanel3.Controls.Add(this.metroLabel2);
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(3, 219);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(399, 57);
            this.metroPanel3.TabIndex = 3;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
            // 
            // tbx_Name
            // 
            this.tbx_Name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbx_Name.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_Name.Location = new System.Drawing.Point(137, 18);
            this.tbx_Name.Name = "tbx_Name";
            this.tbx_Name.Size = new System.Drawing.Size(244, 25);
            this.tbx_Name.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkGreen;
            this.panel3.Location = new System.Drawing.Point(137, 50);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(250, 2);
            this.panel3.TabIndex = 7;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(0, 19);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(94, 25);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Họ và tên:";
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.tbx_ID);
            this.metroPanel2.Controls.Add(this.panel2);
            this.metroPanel2.Controls.Add(this.metroLabel1);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(3, 156);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(399, 57);
            this.metroPanel2.TabIndex = 2;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // tbx_ID
            // 
            this.tbx_ID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbx_ID.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_ID.Location = new System.Drawing.Point(137, 18);
            this.tbx_ID.Name = "tbx_ID";
            this.tbx_ID.Size = new System.Drawing.Size(244, 25);
            this.tbx_ID.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGreen;
            this.panel2.Location = new System.Drawing.Point(137, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 2);
            this.panel2.TabIndex = 7;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(0, 19);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(118, 25);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "ID Nhân viên:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ml_Close
            // 
            this.ml_Close.BackColor = System.Drawing.Color.Transparent;
            this.ml_Close.BackgroundImage = global::iLAB.Properties.Resources.iconfinder_UI_Basic_outline_116_4733225;
            this.ml_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ml_Close.Location = new System.Drawing.Point(12, 36);
            this.ml_Close.Name = "ml_Close";
            this.ml_Close.Size = new System.Drawing.Size(30, 30);
            this.ml_Close.TabIndex = 15;
            this.ml_Close.UseSelectable = true;
            this.ml_Close.Click += new System.EventHandler(this.ml_Close_Click);
            // 
            // f_Employee
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackgroundImage = global::iLAB.Properties.Resources.iLAB_Thong__3_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.ControlBox = false;
            this.Controls.Add(this.ml_Close);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "f_Employee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.f_Employee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_ListEmployee)).EndInit();
            this.panel1.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Avatar)).EndInit();
            this.metroPanel9.ResumeLayout(false);
            this.metroPanel9.PerformLayout();
            this.metroPanel8.ResumeLayout(false);
            this.metroPanel8.PerformLayout();
            this.metroPanel7.ResumeLayout(false);
            this.metroPanel7.PerformLayout();
            this.metroPanel6.ResumeLayout(false);
            this.metroPanel6.PerformLayout();
            this.metroPanel4.ResumeLayout(false);
            this.metroPanel4.PerformLayout();
            this.metroPanel5.ResumeLayout(false);
            this.metroPanel5.PerformLayout();
            this.metroPanel3.ResumeLayout(false);
            this.metroPanel3.PerformLayout();
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgv_ListEmployee;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.TextBox tbx_ID;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private System.Windows.Forms.TextBox tbx_Name;
        private System.Windows.Forms.Panel panel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.PictureBox ptb_Avatar;
        private MetroFramework.Controls.MetroPanel metroPanel5;
        private System.Windows.Forms.TextBox tbx_Major;
        private System.Windows.Forms.Panel panel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroPanel metroPanel4;
        private System.Windows.Forms.TextBox tbx_Position;
        private System.Windows.Forms.Panel panel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroPanel metroPanel9;
        private System.Windows.Forms.TextBox tbx_HourlyWages;
        private System.Windows.Forms.Panel panel8;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroPanel metroPanel8;
        private System.Windows.Forms.TextBox tbx_Email;
        private System.Windows.Forms.Panel panel7;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroPanel metroPanel7;
        private System.Windows.Forms.TextBox tbx_Phone;
        private System.Windows.Forms.Panel panel6;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroPanel metroPanel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private MetroFramework.Controls.MetroLink ml_Close;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Position;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Major;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Birthday;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_HourlyWages;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_password;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Projects;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Salaries;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Works;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Tasks;
        private System.Windows.Forms.DataGridViewImageColumn col_Image;
        private System.Windows.Forms.Button btn_ClearControl;
    }
}