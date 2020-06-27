namespace iLAB.Views
{
    partial class f_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f_Main));
            this.mt_Employee = new MetroFramework.Controls.MetroTile();
            this.mt_Attendance = new MetroFramework.Controls.MetroTile();
            this.mt_Salary = new MetroFramework.Controls.MetroTile();
            this.mt_Project = new MetroFramework.Controls.MetroTile();
            this.mt_Infomation = new MetroFramework.Controls.MetroTile();
            this.mt_Logout = new MetroFramework.Controls.MetroTile();
            this.mt_About = new MetroFramework.Controls.MetroTile();
            this.lb_HumanResources = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.pnThang = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnThangTruoc = new System.Windows.Forms.Button();
            this.btnHomNayLichThang = new System.Windows.Forms.Button();
            this.dtpkNgayLichThang = new System.Windows.Forms.DateTimePicker();
            this.btnThangSau = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolTipLichThang = new System.Windows.Forms.ToolTip(this.components);
            this.btn_Task = new MetroFramework.Controls.MetroTile();
            this.ml_Close = new MetroFramework.Controls.MetroLink();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // mt_Employee
            // 
            this.mt_Employee.ActiveControl = null;
            this.mt_Employee.Location = new System.Drawing.Point(284, 163);
            this.mt_Employee.Name = "mt_Employee";
            this.mt_Employee.Size = new System.Drawing.Size(211, 105);
            this.mt_Employee.TabIndex = 13;
            this.mt_Employee.Text = "Nhân viên";
            this.mt_Employee.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mt_Employee.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mt_Employee.UseSelectable = true;
            this.mt_Employee.Click += new System.EventHandler(this.mt_Employee_Click);
            // 
            // mt_Attendance
            // 
            this.mt_Attendance.ActiveControl = null;
            this.mt_Attendance.Location = new System.Drawing.Point(67, 163);
            this.mt_Attendance.Name = "mt_Attendance";
            this.mt_Attendance.Size = new System.Drawing.Size(211, 211);
            this.mt_Attendance.TabIndex = 14;
            this.mt_Attendance.Text = "Điểm danh";
            this.mt_Attendance.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mt_Attendance.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mt_Attendance.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mt_Attendance.UseSelectable = true;
            this.mt_Attendance.Click += new System.EventHandler(this.mt_Attendance_Click);
            // 
            // mt_Salary
            // 
            this.mt_Salary.ActiveControl = null;
            this.mt_Salary.Location = new System.Drawing.Point(285, 274);
            this.mt_Salary.Name = "mt_Salary";
            this.mt_Salary.Size = new System.Drawing.Size(210, 100);
            this.mt_Salary.TabIndex = 15;
            this.mt_Salary.Text = "Bảng lương";
            this.mt_Salary.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mt_Salary.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mt_Salary.UseSelectable = true;
            this.mt_Salary.Click += new System.EventHandler(this.mt_Salary_Click);
            // 
            // mt_Project
            // 
            this.mt_Project.ActiveControl = null;
            this.mt_Project.Location = new System.Drawing.Point(67, 408);
            this.mt_Project.Name = "mt_Project";
            this.mt_Project.Size = new System.Drawing.Size(211, 91);
            this.mt_Project.TabIndex = 16;
            this.mt_Project.Text = "Dự án";
            this.mt_Project.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mt_Project.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mt_Project.UseSelectable = true;
            this.mt_Project.Click += new System.EventHandler(this.mt_Project_Click);
            // 
            // mt_Infomation
            // 
            this.mt_Infomation.ActiveControl = null;
            this.mt_Infomation.Location = new System.Drawing.Point(67, 530);
            this.mt_Infomation.Name = "mt_Infomation";
            this.mt_Infomation.Size = new System.Drawing.Size(428, 76);
            this.mt_Infomation.TabIndex = 18;
            this.mt_Infomation.Text = "Tài khoản";
            this.mt_Infomation.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mt_Infomation.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mt_Infomation.UseSelectable = true;
            this.mt_Infomation.Click += new System.EventHandler(this.mt_Infomation_Click);
            // 
            // mt_Logout
            // 
            this.mt_Logout.ActiveControl = null;
            this.mt_Logout.Location = new System.Drawing.Point(67, 612);
            this.mt_Logout.Name = "mt_Logout";
            this.mt_Logout.Size = new System.Drawing.Size(210, 71);
            this.mt_Logout.TabIndex = 19;
            this.mt_Logout.Text = "Đăng xuất";
            this.mt_Logout.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mt_Logout.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mt_Logout.UseSelectable = true;
            this.mt_Logout.Click += new System.EventHandler(this.mt_Logout_Click);
            // 
            // mt_About
            // 
            this.mt_About.ActiveControl = null;
            this.mt_About.Location = new System.Drawing.Point(285, 612);
            this.mt_About.Name = "mt_About";
            this.mt_About.Size = new System.Drawing.Size(210, 71);
            this.mt_About.TabIndex = 20;
            this.mt_About.Text = "Phần mềm";
            this.mt_About.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mt_About.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mt_About.UseSelectable = true;
            this.mt_About.Click += new System.EventHandler(this.mt_About_Click);
            // 
            // lb_HumanResources
            // 
            this.lb_HumanResources.AutoSize = true;
            this.lb_HumanResources.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lb_HumanResources.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lb_HumanResources.Location = new System.Drawing.Point(67, 135);
            this.lb_HumanResources.Name = "lb_HumanResources";
            this.lb_HumanResources.Size = new System.Drawing.Size(149, 25);
            this.lb_HumanResources.TabIndex = 21;
            this.lb_HumanResources.Text = "Quản lý nhân sự";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(67, 380);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(162, 25);
            this.metroLabel2.TabIndex = 22;
            this.metroLabel2.Text = "Quản lý công việc";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(67, 502);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(53, 25);
            this.metroLabel3.TabIndex = 23;
            this.metroLabel3.Text = "Khác";
            // 
            // pnThang
            // 
            this.pnThang.BackColor = System.Drawing.Color.Transparent;
            this.pnThang.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Italic);
            this.pnThang.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.pnThang.Location = new System.Drawing.Point(599, 380);
            this.pnThang.Name = "pnThang";
            this.pnThang.Size = new System.Drawing.Size(642, 330);
            this.pnThang.TabIndex = 25;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnThangTruoc);
            this.panel1.Controls.Add(this.btnHomNayLichThang);
            this.panel1.Controls.Add(this.dtpkNgayLichThang);
            this.panel1.Controls.Add(this.btnThangSau);
            this.panel1.Font = new System.Drawing.Font("Calibri", 12F);
            this.panel1.Location = new System.Drawing.Point(599, 269);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(642, 46);
            this.panel1.TabIndex = 24;
            // 
            // btnThangTruoc
            // 
            this.btnThangTruoc.BackColor = System.Drawing.Color.White;
            this.btnThangTruoc.BackgroundImage = global::iLAB.Properties.Resources.left_arrow3;
            this.btnThangTruoc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnThangTruoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThangTruoc.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnThangTruoc.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnThangTruoc.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnThangTruoc.Location = new System.Drawing.Point(7, 5);
            this.btnThangTruoc.Name = "btnThangTruoc";
            this.btnThangTruoc.Size = new System.Drawing.Size(36, 36);
            this.btnThangTruoc.TabIndex = 13;
            this.btnThangTruoc.UseVisualStyleBackColor = false;
            this.btnThangTruoc.Click += new System.EventHandler(this.btnThangTruoc_Click);
            // 
            // btnHomNayLichThang
            // 
            this.btnHomNayLichThang.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnHomNayLichThang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHomNayLichThang.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.btnHomNayLichThang.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnHomNayLichThang.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnHomNayLichThang.Location = new System.Drawing.Point(436, 5);
            this.btnHomNayLichThang.Name = "btnHomNayLichThang";
            this.btnHomNayLichThang.Size = new System.Drawing.Size(157, 36);
            this.btnHomNayLichThang.TabIndex = 9;
            this.btnHomNayLichThang.Text = "To day";
            this.btnHomNayLichThang.UseVisualStyleBackColor = true;
            this.btnHomNayLichThang.Click += new System.EventHandler(this.btnHomNayLichThang_Click);
            // 
            // dtpkNgayLichThang
            // 
            this.dtpkNgayLichThang.CalendarFont = new System.Drawing.Font("Calibri", 12F);
            this.dtpkNgayLichThang.Location = new System.Drawing.Point(56, 7);
            this.dtpkNgayLichThang.Name = "dtpkNgayLichThang";
            this.dtpkNgayLichThang.Size = new System.Drawing.Size(366, 32);
            this.dtpkNgayLichThang.TabIndex = 8;
            this.dtpkNgayLichThang.ValueChanged += new System.EventHandler(this.dtpkNgayLichThang_ValueChanged);
            // 
            // btnThangSau
            // 
            this.btnThangSau.BackColor = System.Drawing.Color.White;
            this.btnThangSau.BackgroundImage = global::iLAB.Properties.Resources.right_arrow3;
            this.btnThangSau.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThangSau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThangSau.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnThangSau.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnThangSau.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnThangSau.Location = new System.Drawing.Point(599, 5);
            this.btnThangSau.Name = "btnThangSau";
            this.btnThangSau.Size = new System.Drawing.Size(36, 36);
            this.btnThangSau.TabIndex = 10;
            this.btnThangSau.UseVisualStyleBackColor = false;
            this.btnThangSau.Click += new System.EventHandler(this.btnThangSau_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label19);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(599, 321);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(642, 53);
            this.panel2.TabIndex = 27;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.White;
            this.label19.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label19.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label19.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label19.Location = new System.Drawing.Point(572, 15);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(45, 24);
            this.label19.TabIndex = 21;
            this.label19.Text = "SUN";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.White;
            this.label18.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label18.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label18.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label18.Location = new System.Drawing.Point(480, 15);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(39, 24);
            this.label18.TabIndex = 20;
            this.label18.Text = "SAT";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.White;
            this.label17.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label17.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label17.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label17.Location = new System.Drawing.Point(388, 15);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(35, 24);
            this.label17.TabIndex = 19;
            this.label17.Text = "FRI";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.White;
            this.label16.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label16.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label16.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label16.Location = new System.Drawing.Point(296, 15);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(46, 24);
            this.label16.TabIndex = 18;
            this.label16.Text = "THU";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.White;
            this.label15.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label15.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label15.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label15.Location = new System.Drawing.Point(204, 15);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(51, 24);
            this.label15.TabIndex = 17;
            this.label15.Text = "WED";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label14.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label14.Location = new System.Drawing.Point(112, 15);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(43, 24);
            this.label14.TabIndex = 16;
            this.label14.Text = "TUE";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label13.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label13.Location = new System.Drawing.Point(20, 15);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 24);
            this.label13.TabIndex = 15;
            this.label13.Text = "MON";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(635, 40);
            this.label1.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.MidnightBlue;
            this.label2.Font = new System.Drawing.Font("UTM Bitsumishi Pro", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(599, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(642, 69);
            this.label2.TabIndex = 28;
            this.label2.Text = "LỊCH THÁNG";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 30000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // toolTipLichThang
            // 
            this.toolTipLichThang.AutoPopDelay = 5000;
            this.toolTipLichThang.InitialDelay = 500;
            this.toolTipLichThang.IsBalloon = true;
            this.toolTipLichThang.ReshowDelay = 100;
            this.toolTipLichThang.Tag = "";
            this.toolTipLichThang.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipLichThang.ToolTipTitle = "Dự án trong ngày";
            // 
            // btn_Task
            // 
            this.btn_Task.ActiveControl = null;
            this.btn_Task.Location = new System.Drawing.Point(285, 408);
            this.btn_Task.Name = "btn_Task";
            this.btn_Task.Size = new System.Drawing.Size(211, 91);
            this.btn_Task.TabIndex = 29;
            this.btn_Task.Text = "Công việc";
            this.btn_Task.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btn_Task.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btn_Task.UseSelectable = true;
            this.btn_Task.Click += new System.EventHandler(this.btn_Task_Click);
            // 
            // ml_Close
            // 
            this.ml_Close.BackColor = System.Drawing.Color.Transparent;
            this.ml_Close.BackgroundImage = global::iLAB.Properties.Resources.iconfinder_UI_Basic_outline_116_4733225;
            this.ml_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ml_Close.Location = new System.Drawing.Point(23, 36);
            this.ml_Close.Name = "ml_Close";
            this.ml_Close.Size = new System.Drawing.Size(30, 30);
            this.ml_Close.TabIndex = 30;
            this.ml_Close.UseSelectable = true;
            this.ml_Close.Click += new System.EventHandler(this.ml_Close_Click);
            // 
            // f_Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::iLAB.Properties.Resources.iLAB_Thong1;
            this.ClientSize = new System.Drawing.Size(1364, 766);
            this.ControlBox = false;
            this.Controls.Add(this.ml_Close);
            this.Controls.Add(this.btn_Task);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnThang);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.lb_HumanResources);
            this.Controls.Add(this.mt_About);
            this.Controls.Add(this.mt_Logout);
            this.Controls.Add(this.mt_Infomation);
            this.Controls.Add(this.mt_Project);
            this.Controls.Add(this.mt_Salary);
            this.Controls.Add(this.mt_Attendance);
            this.Controls.Add(this.mt_Employee);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "f_Main";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.f_Main_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroTile mt_Employee;
        private MetroFramework.Controls.MetroTile mt_Attendance;
        private MetroFramework.Controls.MetroTile mt_Salary;
        private MetroFramework.Controls.MetroTile mt_Project;
        private MetroFramework.Controls.MetroTile mt_Infomation;
        private MetroFramework.Controls.MetroTile mt_Logout;
        private MetroFramework.Controls.MetroTile mt_About;
        private MetroFramework.Controls.MetroLabel lb_HumanResources;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.Panel pnThang;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnThangTruoc;
        private System.Windows.Forms.Button btnHomNayLichThang;
        private System.Windows.Forms.DateTimePicker dtpkNgayLichThang;
        private System.Windows.Forms.Button btnThangSau;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolTip toolTipLichThang;
        private MetroFramework.Controls.MetroTile btn_Task;
        private MetroFramework.Controls.MetroLink ml_Close;
    }
}