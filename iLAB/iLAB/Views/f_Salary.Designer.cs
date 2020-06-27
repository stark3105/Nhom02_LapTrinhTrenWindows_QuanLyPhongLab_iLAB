namespace iLAB.Views
{
    partial class f_Salary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f_Salary));
            this.tbx_IDAttendance = new System.Windows.Forms.TextBox();
            this.lb_Month = new System.Windows.Forms.Label();
            this.tm_DateNow = new System.Windows.Forms.Timer(this.components);
            this.ml_Close = new MetroFramework.Controls.MetroLink();
            this.lb_Year = new System.Windows.Forms.Label();
            this.cb_Month = new System.Windows.Forms.ComboBox();
            this.cb_Year = new System.Windows.Forms.ComboBox();
            this.dtgv_Payroll = new System.Windows.Forms.DataGridView();
            this.cID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTotalHours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cRewards = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTotalSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_SavetoExcel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Payroll)).BeginInit();
            this.SuspendLayout();
            // 
            // tbx_IDAttendance
            // 
            this.tbx_IDAttendance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbx_IDAttendance.Location = new System.Drawing.Point(70, 234);
            this.tbx_IDAttendance.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbx_IDAttendance.Name = "tbx_IDAttendance";
            this.tbx_IDAttendance.Size = new System.Drawing.Size(356, 22);
            this.tbx_IDAttendance.TabIndex = 1;
            // 
            // lb_Month
            // 
            this.lb_Month.AutoSize = true;
            this.lb_Month.BackColor = System.Drawing.Color.Transparent;
            this.lb_Month.Font = new System.Drawing.Font("UTM Alexander", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Month.ForeColor = System.Drawing.Color.DarkBlue;
            this.lb_Month.Location = new System.Drawing.Point(821, 110);
            this.lb_Month.Name = "lb_Month";
            this.lb_Month.Size = new System.Drawing.Size(90, 32);
            this.lb_Month.TabIndex = 15;
            this.lb_Month.Text = "Tháng:";
            // 
            // tm_DateNow
            // 
            this.tm_DateNow.Enabled = true;
            this.tm_DateNow.Interval = 1000;
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
            // lb_Year
            // 
            this.lb_Year.AutoSize = true;
            this.lb_Year.BackColor = System.Drawing.Color.Transparent;
            this.lb_Year.Font = new System.Drawing.Font("UTM Alexander", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Year.ForeColor = System.Drawing.Color.DarkBlue;
            this.lb_Year.Location = new System.Drawing.Point(1011, 110);
            this.lb_Year.Name = "lb_Year";
            this.lb_Year.Size = new System.Drawing.Size(73, 32);
            this.lb_Year.TabIndex = 17;
            this.lb_Year.Text = "Năm:";
            // 
            // cb_Month
            // 
            this.cb_Month.FormattingEnabled = true;
            this.cb_Month.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.cb_Month.Location = new System.Drawing.Point(915, 116);
            this.cb_Month.Name = "cb_Month";
            this.cb_Month.Size = new System.Drawing.Size(90, 30);
            this.cb_Month.TabIndex = 18;
            this.cb_Month.SelectedIndexChanged += new System.EventHandler(this.cb_Month_SelectedIndexChanged);
            // 
            // cb_Year
            // 
            this.cb_Year.FormattingEnabled = true;
            this.cb_Year.Items.AddRange(new object[] {
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025"});
            this.cb_Year.Location = new System.Drawing.Point(1090, 116);
            this.cb_Year.Name = "cb_Year";
            this.cb_Year.Size = new System.Drawing.Size(90, 30);
            this.cb_Year.TabIndex = 19;
            this.cb_Year.SelectedIndexChanged += new System.EventHandler(this.cb_Year_SelectedIndexChanged);
            // 
            // dtgv_Payroll
            // 
            this.dtgv_Payroll.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_Payroll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_Payroll.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cID,
            this.c_Name,
            this.cTotalHours,
            this.cRewards,
            this.cTotalSalary});
            this.dtgv_Payroll.Location = new System.Drawing.Point(25, 236);
            this.dtgv_Payroll.Name = "dtgv_Payroll";
            this.dtgv_Payroll.RowHeadersWidth = 51;
            this.dtgv_Payroll.RowTemplate.Height = 24;
            this.dtgv_Payroll.Size = new System.Drawing.Size(1315, 449);
            this.dtgv_Payroll.TabIndex = 20;
            // 
            // cID
            // 
            this.cID.HeaderText = "ID";
            this.cID.MinimumWidth = 6;
            this.cID.Name = "cID";
            // 
            // c_Name
            // 
            this.c_Name.HeaderText = "Họ và tên";
            this.c_Name.MinimumWidth = 6;
            this.c_Name.Name = "c_Name";
            // 
            // cTotalHours
            // 
            this.cTotalHours.HeaderText = "Số giờ làm";
            this.cTotalHours.MinimumWidth = 6;
            this.cTotalHours.Name = "cTotalHours";
            // 
            // cRewards
            // 
            this.cRewards.HeaderText = "Thưởng";
            this.cRewards.MinimumWidth = 6;
            this.cRewards.Name = "cRewards";
            // 
            // cTotalSalary
            // 
            this.cTotalSalary.HeaderText = "Tổng lương";
            this.cTotalSalary.MinimumWidth = 6;
            this.cTotalSalary.Name = "cTotalSalary";
            // 
            // btn_SavetoExcel
            // 
            this.btn_SavetoExcel.BackColor = System.Drawing.Color.Transparent;
            this.btn_SavetoExcel.BackgroundImage = global::iLAB.Properties.Resources.logo_Excel;
            this.btn_SavetoExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_SavetoExcel.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_SavetoExcel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_SavetoExcel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_SavetoExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SavetoExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SavetoExcel.Location = new System.Drawing.Point(1216, 688);
            this.btn_SavetoExcel.Name = "btn_SavetoExcel";
            this.btn_SavetoExcel.Size = new System.Drawing.Size(124, 35);
            this.btn_SavetoExcel.TabIndex = 21;
            this.btn_SavetoExcel.UseVisualStyleBackColor = false;
            this.btn_SavetoExcel.Click += new System.EventHandler(this.btn_SavetoExcel_Click);
            // 
            // f_Salary
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackgroundImage = global::iLAB.Properties.Resources.iLAB_Salary;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1366, 766);
            this.ControlBox = false;
            this.Controls.Add(this.btn_SavetoExcel);
            this.Controls.Add(this.dtgv_Payroll);
            this.Controls.Add(this.cb_Year);
            this.Controls.Add(this.cb_Month);
            this.Controls.Add(this.lb_Year);
            this.Controls.Add(this.lb_Month);
            this.Controls.Add(this.ml_Close);
            this.Controls.Add(this.tbx_IDAttendance);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "f_Salary";
            this.Padding = new System.Windows.Forms.Padding(22, 82, 22, 28);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Payroll)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbx_IDAttendance;
        private MetroFramework.Controls.MetroLink ml_Close;
        private System.Windows.Forms.Label lb_Month;
        private System.Windows.Forms.Timer tm_DateNow;
        private System.Windows.Forms.Label lb_Year;
        private System.Windows.Forms.ComboBox cb_Month;
        private System.Windows.Forms.ComboBox cb_Year;
        private System.Windows.Forms.DataGridView dtgv_Payroll;
        private System.Windows.Forms.DataGridViewTextBoxColumn cID;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTotalHours;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRewards;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTotalSalary;
        private System.Windows.Forms.Button btn_SavetoExcel;
    }
}