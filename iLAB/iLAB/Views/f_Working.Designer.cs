namespace iLAB.Views
{
    partial class f_Working
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f_Working));
            this.lv_Attendance = new System.Windows.Forms.ListView();
            this.c_IDEmployee = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.c_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.c_CheckIn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.c_CheckOut = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbx_IDAttendance = new System.Windows.Forms.TextBox();
            this.lb_Date = new System.Windows.Forms.Label();
            this.tm_DateNow = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_AddIDAttendance = new System.Windows.Forms.Button();
            this.ml_UserName = new MetroFramework.Controls.MetroLink();
            this.ml_Close = new MetroFramework.Controls.MetroLink();
            this.flpn_EmployeeWorking = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // lv_Attendance
            // 
            this.lv_Attendance.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.c_IDEmployee,
            this.c_Name,
            this.c_CheckIn,
            this.c_CheckOut});
            this.lv_Attendance.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_Attendance.GridLines = true;
            this.lv_Attendance.HideSelection = false;
            this.lv_Attendance.Location = new System.Drawing.Point(25, 303);
            this.lv_Attendance.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lv_Attendance.Name = "lv_Attendance";
            this.lv_Attendance.Size = new System.Drawing.Size(700, 400);
            this.lv_Attendance.TabIndex = 0;
            this.lv_Attendance.UseCompatibleStateImageBehavior = false;
            this.lv_Attendance.View = System.Windows.Forms.View.Details;
            // 
            // c_IDEmployee
            // 
            this.c_IDEmployee.Text = "ID";
            this.c_IDEmployee.Width = 100;
            // 
            // c_Name
            // 
            this.c_Name.Text = "Họ và tên";
            this.c_Name.Width = 170;
            // 
            // c_CheckIn
            // 
            this.c_CheckIn.Text = "Giờ vào";
            this.c_CheckIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.c_CheckIn.Width = 200;
            // 
            // c_CheckOut
            // 
            this.c_CheckOut.Text = "Giờ ra";
            this.c_CheckOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.c_CheckOut.Width = 200;
            // 
            // tbx_IDAttendance
            // 
            this.tbx_IDAttendance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbx_IDAttendance.Location = new System.Drawing.Point(75, 236);
            this.tbx_IDAttendance.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbx_IDAttendance.Name = "tbx_IDAttendance";
            this.tbx_IDAttendance.Size = new System.Drawing.Size(356, 22);
            this.tbx_IDAttendance.TabIndex = 1;
            // 
            // lb_Date
            // 
            this.lb_Date.AutoSize = true;
            this.lb_Date.BackColor = System.Drawing.Color.Transparent;
            this.lb_Date.Font = new System.Drawing.Font("UTM Alexander", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Date.ForeColor = System.Drawing.Color.DarkBlue;
            this.lb_Date.Location = new System.Drawing.Point(19, 143);
            this.lb_Date.Name = "lb_Date";
            this.lb_Date.Size = new System.Drawing.Size(210, 32);
            this.lb_Date.TabIndex = 15;
            this.lb_Date.Text = "Ngày 30/05/2020";
            // 
            // tm_DateNow
            // 
            this.tm_DateNow.Enabled = true;
            this.tm_DateNow.Interval = 1000;
            this.tm_DateNow.Tick += new System.EventHandler(this.tm_DateNow_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 24);
            this.label1.TabIndex = 16;
            this.label1.Text = "Mã số";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.panel1.Location = new System.Drawing.Point(35, 263);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 2);
            this.panel1.TabIndex = 17;
            // 
            // btn_AddIDAttendance
            // 
            this.btn_AddIDAttendance.BackColor = System.Drawing.Color.Transparent;
            this.btn_AddIDAttendance.BackgroundImage = global::iLAB.Properties.Resources.add_button;
            this.btn_AddIDAttendance.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_AddIDAttendance.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_AddIDAttendance.FlatAppearance.BorderSize = 0;
            this.btn_AddIDAttendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddIDAttendance.Location = new System.Drawing.Point(437, 232);
            this.btn_AddIDAttendance.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_AddIDAttendance.Name = "btn_AddIDAttendance";
            this.btn_AddIDAttendance.Size = new System.Drawing.Size(33, 29);
            this.btn_AddIDAttendance.TabIndex = 2;
            this.btn_AddIDAttendance.UseVisualStyleBackColor = false;
            this.btn_AddIDAttendance.Click += new System.EventHandler(this.btn_AddIDAttendance_Click);
            // 
            // ml_UserName
            // 
            this.ml_UserName.BackColor = System.Drawing.Color.Transparent;
            this.ml_UserName.BackgroundImage = global::iLAB.Properties.Resources.icon_User;
            this.ml_UserName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ml_UserName.Location = new System.Drawing.Point(30, 231);
            this.ml_UserName.Name = "ml_UserName";
            this.ml_UserName.Size = new System.Drawing.Size(39, 30);
            this.ml_UserName.TabIndex = 18;
            this.ml_UserName.UseSelectable = true;
            // 
            // ml_Close
            // 
            this.ml_Close.BackColor = System.Drawing.Color.Transparent;
            this.ml_Close.BackgroundImage = global::iLAB.Properties.Resources.iconfinder_UI_Basic_outline_116_4733225;
            this.ml_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ml_Close.Location = new System.Drawing.Point(12, 36);
            this.ml_Close.Name = "ml_Close";
            this.ml_Close.Size = new System.Drawing.Size(30, 30);
            this.ml_Close.TabIndex = 14;
            this.ml_Close.UseSelectable = true;
            this.ml_Close.Click += new System.EventHandler(this.ml_Close_Click);
            // 
            // flpn_EmployeeWorking
            // 
            this.flpn_EmployeeWorking.AutoScroll = true;
            this.flpn_EmployeeWorking.BackColor = System.Drawing.Color.White;
            this.flpn_EmployeeWorking.Location = new System.Drawing.Point(788, 204);
            this.flpn_EmployeeWorking.Name = "flpn_EmployeeWorking";
            this.flpn_EmployeeWorking.Size = new System.Drawing.Size(539, 499);
            this.flpn_EmployeeWorking.TabIndex = 19;
            // 
            // f_Working
            // 
            this.AcceptButton = this.btn_AddIDAttendance;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoScroll = true;
            this.BackgroundImage = global::iLAB.Properties.Resources.iLAB_Working;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1364, 766);
            this.ControlBox = false;
            this.Controls.Add(this.flpn_EmployeeWorking);
            this.Controls.Add(this.ml_UserName);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_Date);
            this.Controls.Add(this.ml_Close);
            this.Controls.Add(this.btn_AddIDAttendance);
            this.Controls.Add(this.tbx_IDAttendance);
            this.Controls.Add(this.lv_Attendance);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "f_Working";
            this.Padding = new System.Windows.Forms.Padding(22, 82, 22, 28);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lv_Attendance;
        private System.Windows.Forms.ColumnHeader c_Name;
        private System.Windows.Forms.ColumnHeader c_CheckIn;
        private System.Windows.Forms.ColumnHeader c_CheckOut;
        private System.Windows.Forms.TextBox tbx_IDAttendance;
        private System.Windows.Forms.Button btn_AddIDAttendance;
        private System.Windows.Forms.ColumnHeader c_IDEmployee;
        private MetroFramework.Controls.MetroLink ml_Close;
        private System.Windows.Forms.Label lb_Date;
        private System.Windows.Forms.Timer tm_DateNow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroLink ml_UserName;
        private System.Windows.Forms.FlowLayoutPanel flpn_EmployeeWorking;
    }
}