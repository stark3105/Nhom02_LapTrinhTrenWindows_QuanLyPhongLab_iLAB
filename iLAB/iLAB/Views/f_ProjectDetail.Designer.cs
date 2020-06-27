namespace iLAB.Views
{
    partial class f_ProjectDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f_ProjectDetail));
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
            this.tbx_Status = new System.Windows.Forms.TextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel7 = new MetroFramework.Controls.MetroPanel();
            this.tbx_Leader = new System.Windows.Forms.TextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.ml_Close = new MetroFramework.Controls.MetroLink();
            this.flp_Tasks = new System.Windows.Forms.FlowLayoutPanel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.lb_Progress = new System.Windows.Forms.Label();
            this.pgb_Progress = new MetroFramework.Controls.MetroProgressBar();
            this.ml_Add = new MetroFramework.Controls.MetroLink();
            this.metroPanel1.SuspendLayout();
            this.metroPanel3.SuspendLayout();
            this.metroPanel6.SuspendLayout();
            this.metroPanel4.SuspendLayout();
            this.metroPanel5.SuspendLayout();
            this.metroPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.tbx_Name);
            this.metroPanel1.Controls.Add(this.panel1);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(48, 209);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(635, 57);
            this.metroPanel1.TabIndex = 4;
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
            this.tbx_Name.ReadOnly = true;
            this.tbx_Name.Size = new System.Drawing.Size(500, 28);
            this.tbx_Name.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Location = new System.Drawing.Point(120, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 2);
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
            // metroPanel3
            // 
            this.metroPanel3.Controls.Add(this.tbx_Description);
            this.metroPanel3.Controls.Add(this.metroLabel3);
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(48, 272);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(635, 131);
            this.metroPanel3.TabIndex = 5;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
            // 
            // tbx_Description
            // 
            this.tbx_Description.BackColor = System.Drawing.Color.White;
            this.tbx_Description.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbx_Description.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_Description.Location = new System.Drawing.Point(120, 18);
            this.tbx_Description.Multiline = true;
            this.tbx_Description.Name = "tbx_Description";
            this.tbx_Description.ReadOnly = true;
            this.tbx_Description.Size = new System.Drawing.Size(486, 97);
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
            this.metroPanel6.Location = new System.Drawing.Point(48, 409);
            this.metroPanel6.Name = "metroPanel6";
            this.metroPanel6.Size = new System.Drawing.Size(307, 57);
            this.metroPanel6.TabIndex = 10;
            this.metroPanel6.VerticalScrollbarBarColor = true;
            this.metroPanel6.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel6.VerticalScrollbarSize = 10;
            // 
            // dtp_Start
            // 
            this.dtp_Start.CustomFormat = "dd/MM/yyyy";
            this.dtp_Start.Enabled = false;
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
            // metroPanel4
            // 
            this.metroPanel4.Controls.Add(this.dtp_End);
            this.metroPanel4.Controls.Add(this.metroLabel4);
            this.metroPanel4.HorizontalScrollbarBarColor = true;
            this.metroPanel4.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel4.HorizontalScrollbarSize = 10;
            this.metroPanel4.Location = new System.Drawing.Point(376, 409);
            this.metroPanel4.Name = "metroPanel4";
            this.metroPanel4.Size = new System.Drawing.Size(307, 57);
            this.metroPanel4.TabIndex = 11;
            this.metroPanel4.VerticalScrollbarBarColor = true;
            this.metroPanel4.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel4.VerticalScrollbarSize = 10;
            // 
            // dtp_End
            // 
            this.dtp_End.CustomFormat = "dd/MM/yyyy";
            this.dtp_End.Enabled = false;
            this.dtp_End.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_End.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_End.Location = new System.Drawing.Point(120, 14);
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
            this.metroPanel5.Controls.Add(this.tbx_Status);
            this.metroPanel5.Controls.Add(this.metroLabel6);
            this.metroPanel5.HorizontalScrollbarBarColor = true;
            this.metroPanel5.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel5.HorizontalScrollbarSize = 10;
            this.metroPanel5.Location = new System.Drawing.Point(48, 472);
            this.metroPanel5.Name = "metroPanel5";
            this.metroPanel5.Size = new System.Drawing.Size(307, 57);
            this.metroPanel5.TabIndex = 12;
            this.metroPanel5.VerticalScrollbarBarColor = true;
            this.metroPanel5.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel5.VerticalScrollbarSize = 10;
            // 
            // tbx_Status
            // 
            this.tbx_Status.BackColor = System.Drawing.Color.White;
            this.tbx_Status.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbx_Status.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_Status.Location = new System.Drawing.Point(120, 20);
            this.tbx_Status.Name = "tbx_Status";
            this.tbx_Status.ReadOnly = true;
            this.tbx_Status.Size = new System.Drawing.Size(180, 25);
            this.tbx_Status.TabIndex = 6;
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
            // metroPanel7
            // 
            this.metroPanel7.Controls.Add(this.tbx_Leader);
            this.metroPanel7.Controls.Add(this.metroLabel7);
            this.metroPanel7.HorizontalScrollbarBarColor = true;
            this.metroPanel7.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel7.HorizontalScrollbarSize = 10;
            this.metroPanel7.Location = new System.Drawing.Point(48, 535);
            this.metroPanel7.Name = "metroPanel7";
            this.metroPanel7.Size = new System.Drawing.Size(399, 57);
            this.metroPanel7.TabIndex = 13;
            this.metroPanel7.VerticalScrollbarBarColor = true;
            this.metroPanel7.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel7.VerticalScrollbarSize = 10;
            // 
            // tbx_Leader
            // 
            this.tbx_Leader.BackColor = System.Drawing.Color.White;
            this.tbx_Leader.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbx_Leader.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_Leader.Location = new System.Drawing.Point(120, 18);
            this.tbx_Leader.Name = "tbx_Leader";
            this.tbx_Leader.ReadOnly = true;
            this.tbx_Leader.Size = new System.Drawing.Size(250, 25);
            this.tbx_Leader.TabIndex = 6;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel7.Location = new System.Drawing.Point(0, 19);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(72, 25);
            this.metroLabel7.TabIndex = 2;
            this.metroLabel7.Text = "Leader:";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // ml_Close
            // 
            this.ml_Close.BackColor = System.Drawing.Color.Transparent;
            this.ml_Close.BackgroundImage = global::iLAB.Properties.Resources.iconfinder_UI_Basic_outline_116_4733225;
            this.ml_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ml_Close.Location = new System.Drawing.Point(12, 34);
            this.ml_Close.Name = "ml_Close";
            this.ml_Close.Size = new System.Drawing.Size(30, 30);
            this.ml_Close.TabIndex = 15;
            this.ml_Close.UseSelectable = true;
            this.ml_Close.Click += new System.EventHandler(this.ml_Close_Click);
            // 
            // flp_Tasks
            // 
            this.flp_Tasks.BackColor = System.Drawing.Color.Transparent;
            this.flp_Tasks.Location = new System.Drawing.Point(704, 205);
            this.flp_Tasks.Name = "flp_Tasks";
            this.flp_Tasks.Size = new System.Drawing.Size(650, 441);
            this.flp_Tasks.TabIndex = 18;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel8.Location = new System.Drawing.Point(1044, 180);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(96, 17);
            this.metroLabel8.TabIndex = 19;
            this.metroLabel8.Text = "Đã hoành thành";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel9.Location = new System.Drawing.Point(1146, 180);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(109, 17);
            this.metroLabel9.TabIndex = 20;
            this.metroLabel9.Text = "Chưa hoành thành";
            // 
            // lb_Progress
            // 
            this.lb_Progress.AutoSize = true;
            this.lb_Progress.BackColor = System.Drawing.Color.Transparent;
            this.lb_Progress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Progress.ForeColor = System.Drawing.Color.DarkGreen;
            this.lb_Progress.Location = new System.Drawing.Point(1230, 720);
            this.lb_Progress.Name = "lb_Progress";
            this.lb_Progress.Size = new System.Drawing.Size(67, 25);
            this.lb_Progress.TabIndex = 22;
            this.lb_Progress.Text = "100%";
            // 
            // pgb_Progress
            // 
            this.pgb_Progress.Location = new System.Drawing.Point(860, 722);
            this.pgb_Progress.Name = "pgb_Progress";
            this.pgb_Progress.Size = new System.Drawing.Size(364, 23);
            this.pgb_Progress.Style = MetroFramework.MetroColorStyle.Silver;
            this.pgb_Progress.TabIndex = 24;
            this.pgb_Progress.Value = 100;
            // 
            // ml_Add
            // 
            this.ml_Add.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.ml_Add.Location = new System.Drawing.Point(709, 652);
            this.ml_Add.Name = "ml_Add";
            this.ml_Add.Size = new System.Drawing.Size(170, 23);
            this.ml_Add.Style = MetroFramework.MetroColorStyle.Black;
            this.ml_Add.TabIndex = 0;
            this.ml_Add.Text = "Chi tiết công việc";
            this.ml_Add.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ml_Add.UseSelectable = true;
            this.ml_Add.Click += new System.EventHandler(this.Ml_Add_Click);
            // 
            // f_ProjectDetail
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackgroundImage = global::iLAB.Properties.Resources.iLAB_Thong__5_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1364, 766);
            this.ControlBox = false;
            this.Controls.Add(this.ml_Add);
            this.Controls.Add(this.pgb_Progress);
            this.Controls.Add(this.lb_Progress);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.flp_Tasks);
            this.Controls.Add(this.ml_Close);
            this.Controls.Add(this.metroPanel7);
            this.Controls.Add(this.metroPanel5);
            this.Controls.Add(this.metroPanel4);
            this.Controls.Add(this.metroPanel6);
            this.Controls.Add(this.metroPanel3);
            this.Controls.Add(this.metroPanel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "f_ProjectDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
            this.metroPanel7.ResumeLayout(false);
            this.metroPanel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.TextBox tbx_Status;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroPanel metroPanel7;
        private System.Windows.Forms.TextBox tbx_Leader;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private MetroFramework.Controls.MetroLink ml_Close;
        private System.Windows.Forms.FlowLayoutPanel flp_Tasks;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private System.Windows.Forms.Label lb_Progress;
        private MetroFramework.Controls.MetroProgressBar pgb_Progress;
        private MetroFramework.Controls.MetroLink ml_Add;
    }
}