namespace iLAB.Views
{
    partial class fLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fLogin));
            this.tbx_UserName = new System.Windows.Forms.TextBox();
            this.tbx_PassWord = new System.Windows.Forms.TextBox();
            this.mlb_UserName = new MetroFramework.Controls.MetroLabel();
            this.mlb_PassWord = new MetroFramework.Controls.MetroLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Login = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ml_Close = new MetroFramework.Controls.MetroLink();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.pn_Position = new System.Windows.Forms.Panel();
            this.rb_Employee = new System.Windows.Forms.RadioButton();
            this.rb_Manager = new System.Windows.Forms.RadioButton();
            this.ml_User = new MetroFramework.Controls.MetroLink();
            this.ml_PassWord = new MetroFramework.Controls.MetroLink();
            this.ml_UserName = new MetroFramework.Controls.MetroLink();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.pn_Position.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbx_UserName
            // 
            this.tbx_UserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbx_UserName.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_UserName.Location = new System.Drawing.Point(64, 344);
            this.tbx_UserName.Name = "tbx_UserName";
            this.tbx_UserName.Size = new System.Drawing.Size(323, 26);
            this.tbx_UserName.TabIndex = 1;
            this.tbx_UserName.Text = "18110207";
            // 
            // tbx_PassWord
            // 
            this.tbx_PassWord.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbx_PassWord.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_PassWord.Location = new System.Drawing.Point(64, 444);
            this.tbx_PassWord.Name = "tbx_PassWord";
            this.tbx_PassWord.Size = new System.Drawing.Size(323, 26);
            this.tbx_PassWord.TabIndex = 2;
            this.tbx_PassWord.Text = "123456";
            this.tbx_PassWord.UseSystemPasswordChar = true;
            // 
            // mlb_UserName
            // 
            this.mlb_UserName.AutoSize = true;
            this.mlb_UserName.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mlb_UserName.Location = new System.Drawing.Point(18, 304);
            this.mlb_UserName.Name = "mlb_UserName";
            this.mlb_UserName.Size = new System.Drawing.Size(100, 25);
            this.mlb_UserName.TabIndex = 3;
            this.mlb_UserName.Text = "User Name";
            // 
            // mlb_PassWord
            // 
            this.mlb_PassWord.AutoSize = true;
            this.mlb_PassWord.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mlb_PassWord.Location = new System.Drawing.Point(18, 404);
            this.mlb_PassWord.Name = "mlb_PassWord";
            this.mlb_PassWord.Size = new System.Drawing.Size(85, 25);
            this.mlb_PassWord.TabIndex = 4;
            this.mlb_PassWord.Text = "Password";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Location = new System.Drawing.Point(17, 375);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(369, 2);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Location = new System.Drawing.Point(18, 474);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(369, 2);
            this.panel2.TabIndex = 6;
            // 
            // btn_Login
            // 
            this.btn_Login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Login.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.Location = new System.Drawing.Point(18, 529);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(369, 46);
            this.btn_Login.TabIndex = 9;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.ml_Close);
            this.panel3.Controls.Add(this.metroLabel1);
            this.panel3.Controls.Add(this.pn_Position);
            this.panel3.Controls.Add(this.ml_User);
            this.panel3.Controls.Add(this.tbx_UserName);
            this.panel3.Controls.Add(this.btn_Login);
            this.panel3.Controls.Add(this.tbx_PassWord);
            this.panel3.Controls.Add(this.ml_PassWord);
            this.panel3.Controls.Add(this.mlb_UserName);
            this.panel3.Controls.Add(this.ml_UserName);
            this.panel3.Controls.Add(this.mlb_PassWord);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Location = new System.Drawing.Point(441, 16);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(403, 617);
            this.panel3.TabIndex = 11;
            // 
            // ml_Close
            // 
            this.ml_Close.BackgroundImage = global::iLAB.Properties.Resources.iconfinder_UI_Basic_outline_116_4733225;
            this.ml_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ml_Close.Location = new System.Drawing.Point(370, 3);
            this.ml_Close.Name = "ml_Close";
            this.ml_Close.Size = new System.Drawing.Size(30, 30);
            this.ml_Close.TabIndex = 13;
            this.ml_Close.UseSelectable = true;
            this.ml_Close.Click += new System.EventHandler(this.ml_Close_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(160, 221);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(64, 25);
            this.metroLabel1.TabIndex = 12;
            this.metroLabel1.Text = "LOGIN";
            // 
            // pn_Position
            // 
            this.pn_Position.Controls.Add(this.rb_Employee);
            this.pn_Position.Controls.Add(this.rb_Manager);
            this.pn_Position.Location = new System.Drawing.Point(18, 489);
            this.pn_Position.Name = "pn_Position";
            this.pn_Position.Size = new System.Drawing.Size(367, 30);
            this.pn_Position.TabIndex = 11;
            // 
            // rb_Employee
            // 
            this.rb_Employee.AutoSize = true;
            this.rb_Employee.Checked = true;
            this.rb_Employee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Employee.Location = new System.Drawing.Point(136, 3);
            this.rb_Employee.Name = "rb_Employee";
            this.rb_Employee.Size = new System.Drawing.Size(103, 24);
            this.rb_Employee.TabIndex = 1;
            this.rb_Employee.TabStop = true;
            this.rb_Employee.Text = "Employee";
            this.rb_Employee.UseVisualStyleBackColor = true;
            // 
            // rb_Manager
            // 
            this.rb_Manager.AutoSize = true;
            this.rb_Manager.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Manager.Location = new System.Drawing.Point(3, 3);
            this.rb_Manager.Name = "rb_Manager";
            this.rb_Manager.Size = new System.Drawing.Size(95, 24);
            this.rb_Manager.TabIndex = 0;
            this.rb_Manager.TabStop = true;
            this.rb_Manager.Text = "Manager";
            this.rb_Manager.UseVisualStyleBackColor = true;
            // 
            // ml_User
            // 
            this.ml_User.BackgroundImage = global::iLAB.Properties.Resources.icon_Login;
            this.ml_User.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ml_User.Location = new System.Drawing.Point(134, 129);
            this.ml_User.Name = "ml_User";
            this.ml_User.Size = new System.Drawing.Size(117, 89);
            this.ml_User.TabIndex = 0;
            this.ml_User.UseSelectable = true;
            // 
            // ml_PassWord
            // 
            this.ml_PassWord.BackgroundImage = global::iLAB.Properties.Resources.icon_Password;
            this.ml_PassWord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ml_PassWord.Location = new System.Drawing.Point(13, 428);
            this.ml_PassWord.Name = "ml_PassWord";
            this.ml_PassWord.Size = new System.Drawing.Size(45, 45);
            this.ml_PassWord.TabIndex = 8;
            this.ml_PassWord.UseSelectable = true;
            // 
            // ml_UserName
            // 
            this.ml_UserName.BackgroundImage = global::iLAB.Properties.Resources.icon_User;
            this.ml_UserName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ml_UserName.Location = new System.Drawing.Point(17, 334);
            this.ml_UserName.Name = "ml_UserName";
            this.ml_UserName.Size = new System.Drawing.Size(39, 36);
            this.ml_UserName.TabIndex = 7;
            this.ml_UserName.UseSelectable = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.ForestGreen;
            this.panel4.BackgroundImage = global::iLAB.Properties.Resources.iLAB2;
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(-4, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(428, 647);
            this.panel4.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(16, 616);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Version 1.0";
            // 
            // fLogin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(867, 641);
            this.ControlBox = false;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fLogin";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pn_Position.ResumeLayout(false);
            this.pn_Position.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLink ml_User;
        private System.Windows.Forms.TextBox tbx_UserName;
        private System.Windows.Forms.TextBox tbx_PassWord;
        private MetroFramework.Controls.MetroLabel mlb_UserName;
        private MetroFramework.Controls.MetroLabel mlb_PassWord;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroLink ml_UserName;
        private MetroFramework.Controls.MetroLink ml_PassWord;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Panel panel3;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.Panel pn_Position;
        private System.Windows.Forms.RadioButton rb_Employee;
        private System.Windows.Forms.RadioButton rb_Manager;
        private System.Windows.Forms.Panel panel4;
        private MetroFramework.Controls.MetroLink ml_Close;
        private System.Windows.Forms.Label label1;
    }
}

