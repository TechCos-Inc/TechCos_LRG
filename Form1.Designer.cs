namespace TechCos_LRG
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuperUserBtn = new Button();
            button4 = new Button();
            pictureBox1 = new PictureBox();
            LoginInfoPanel = new Panel();
            AdminLoginPanel = new Panel();
            label7 = new Label();
            label3 = new Label();
            label2 = new Label();
            backAdminBtn = new PictureBox();
            AdminSubmitBtn = new Button();
            PasswordAdminLoginTxtField = new TextBox();
            UsernameAdminLoginTxtField = new TextBox();
            UserloginPanel = new Panel();
            label6 = new Label();
            backUserBtn = new PictureBox();
            UserSubmitBtn = new Button();
            PasswordUserLoginTxtField = new TextBox();
            UsernameUserLoginTxtField = new TextBox();
            label4 = new Label();
            label5 = new Label();
            SuperUserPanel = new Panel();
            label11 = new Label();
            roleCombo = new ComboBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            superusrBackBtn = new PictureBox();
            AddUserBtn = new Button();
            addPass = new TextBox();
            addName = new TextBox();
            BranchBtn = new Button();
            CloseBtn = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            LoginInfoPanel.SuspendLayout();
            AdminLoginPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)backAdminBtn).BeginInit();
            UserloginPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)backUserBtn).BeginInit();
            SuperUserPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)superusrBackBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CloseBtn).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(3, 16);
            label1.Name = "label1";
            label1.Size = new Size(257, 59);
            label1.TabIndex = 0;
            label1.Text = "Login To Continue";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(3, 78);
            button1.Name = "button1";
            button1.Size = new Size(128, 42);
            button1.TabIndex = 1;
            button1.Text = "Admin";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(0, 137);
            button2.Name = "button2";
            button2.Size = new Size(128, 43);
            button2.TabIndex = 2;
            button2.Text = "User";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // SuperUserBtn
            // 
            SuperUserBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            SuperUserBtn.Location = new Point(790, 12);
            SuperUserBtn.Name = "SuperUserBtn";
            SuperUserBtn.Size = new Size(75, 23);
            SuperUserBtn.TabIndex = 3;
            SuperUserBtn.Text = "Super User";
            SuperUserBtn.UseVisualStyleBackColor = true;
            SuperUserBtn.Click += SuperUserBtn_Click;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button4.Location = new Point(889, 12);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 4;
            button4.Text = "Help?";
            button4.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(90, 164);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(478, 368);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // LoginInfoPanel
            // 
            LoginInfoPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            LoginInfoPanel.Controls.Add(label1);
            LoginInfoPanel.Controls.Add(button1);
            LoginInfoPanel.Controls.Add(button2);
            LoginInfoPanel.Location = new Point(723, 278);
            LoginInfoPanel.Name = "LoginInfoPanel";
            LoginInfoPanel.Size = new Size(294, 203);
            LoginInfoPanel.TabIndex = 6;
            // 
            // AdminLoginPanel
            // 
            AdminLoginPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            AdminLoginPanel.Controls.Add(label7);
            AdminLoginPanel.Controls.Add(label3);
            AdminLoginPanel.Controls.Add(label2);
            AdminLoginPanel.Controls.Add(backAdminBtn);
            AdminLoginPanel.Controls.Add(AdminSubmitBtn);
            AdminLoginPanel.Controls.Add(PasswordAdminLoginTxtField);
            AdminLoginPanel.Controls.Add(UsernameAdminLoginTxtField);
            AdminLoginPanel.Location = new Point(753, 243);
            AdminLoginPanel.Name = "AdminLoginPanel";
            AdminLoginPanel.Size = new Size(453, 277);
            AdminLoginPanel.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(80, 18);
            label7.Name = "label7";
            label7.Size = new Size(124, 28);
            label7.TabIndex = 9;
            label7.Text = "Admin Login";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(80, 104);
            label3.Name = "label3";
            label3.Size = new Size(87, 25);
            label3.TabIndex = 8;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(80, 57);
            label2.Name = "label2";
            label2.Size = new Size(96, 25);
            label2.TabIndex = 7;
            label2.Text = "Username ";
            // 
            // backAdminBtn
            // 
            backAdminBtn.Image = Properties.Resources.icons8_back_arrow_100;
            backAdminBtn.Location = new Point(17, 18);
            backAdminBtn.Name = "backAdminBtn";
            backAdminBtn.Size = new Size(37, 34);
            backAdminBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            backAdminBtn.TabIndex = 6;
            backAdminBtn.TabStop = false;
            backAdminBtn.Click += backAdminBtn_Click;
            // 
            // AdminSubmitBtn
            // 
            AdminSubmitBtn.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            AdminSubmitBtn.Location = new Point(145, 162);
            AdminSubmitBtn.Name = "AdminSubmitBtn";
            AdminSubmitBtn.Size = new Size(128, 43);
            AdminSubmitBtn.TabIndex = 4;
            AdminSubmitBtn.Text = "Continue";
            AdminSubmitBtn.UseVisualStyleBackColor = true;
            AdminSubmitBtn.Click += AdminSubmitBtn_Click;
            // 
            // PasswordAdminLoginTxtField
            // 
            PasswordAdminLoginTxtField.Location = new Point(233, 107);
            PasswordAdminLoginTxtField.Name = "PasswordAdminLoginTxtField";
            PasswordAdminLoginTxtField.Size = new Size(100, 23);
            PasswordAdminLoginTxtField.TabIndex = 3;
            // 
            // UsernameAdminLoginTxtField
            // 
            UsernameAdminLoginTxtField.Location = new Point(233, 60);
            UsernameAdminLoginTxtField.Name = "UsernameAdminLoginTxtField";
            UsernameAdminLoginTxtField.Size = new Size(100, 23);
            UsernameAdminLoginTxtField.TabIndex = 2;
            // 
            // UserloginPanel
            // 
            UserloginPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            UserloginPanel.Controls.Add(label6);
            UserloginPanel.Controls.Add(backUserBtn);
            UserloginPanel.Controls.Add(UserSubmitBtn);
            UserloginPanel.Controls.Add(PasswordUserLoginTxtField);
            UserloginPanel.Controls.Add(UsernameUserLoginTxtField);
            UserloginPanel.Controls.Add(label4);
            UserloginPanel.Controls.Add(label5);
            UserloginPanel.Location = new Point(735, 263);
            UserloginPanel.Name = "UserloginPanel";
            UserloginPanel.Size = new Size(416, 247);
            UserloginPanel.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(69, 13);
            label6.Name = "label6";
            label6.Size = new Size(105, 28);
            label6.TabIndex = 6;
            label6.Text = "User Login";
            // 
            // backUserBtn
            // 
            backUserBtn.Image = Properties.Resources.icons8_back_arrow_100;
            backUserBtn.Location = new Point(18, 13);
            backUserBtn.Name = "backUserBtn";
            backUserBtn.Size = new Size(37, 34);
            backUserBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            backUserBtn.TabIndex = 5;
            backUserBtn.TabStop = false;
            backUserBtn.Click += backUserBtn_Click;
            // 
            // UserSubmitBtn
            // 
            UserSubmitBtn.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            UserSubmitBtn.Location = new Point(145, 162);
            UserSubmitBtn.Name = "UserSubmitBtn";
            UserSubmitBtn.Size = new Size(128, 43);
            UserSubmitBtn.TabIndex = 4;
            UserSubmitBtn.Text = "Continue";
            UserSubmitBtn.UseVisualStyleBackColor = true;
            UserSubmitBtn.Click += UserSubmitBtn_Click;
            // 
            // PasswordUserLoginTxtField
            // 
            PasswordUserLoginTxtField.Location = new Point(233, 108);
            PasswordUserLoginTxtField.Name = "PasswordUserLoginTxtField";
            PasswordUserLoginTxtField.Size = new Size(150, 23);
            PasswordUserLoginTxtField.TabIndex = 3;
            // 
            // UsernameUserLoginTxtField
            // 
            UsernameUserLoginTxtField.Location = new Point(233, 57);
            UsernameUserLoginTxtField.Name = "UsernameUserLoginTxtField";
            UsernameUserLoginTxtField.Size = new Size(150, 23);
            UsernameUserLoginTxtField.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(69, 105);
            label4.Name = "label4";
            label4.Size = new Size(87, 25);
            label4.TabIndex = 1;
            label4.Text = "Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(69, 54);
            label5.Name = "label5";
            label5.Size = new Size(96, 25);
            label5.TabIndex = 0;
            label5.Text = "Username ";
            // 
            // SuperUserPanel
            // 
            SuperUserPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            SuperUserPanel.Controls.Add(label11);
            SuperUserPanel.Controls.Add(roleCombo);
            SuperUserPanel.Controls.Add(label8);
            SuperUserPanel.Controls.Add(label9);
            SuperUserPanel.Controls.Add(label10);
            SuperUserPanel.Controls.Add(superusrBackBtn);
            SuperUserPanel.Controls.Add(AddUserBtn);
            SuperUserPanel.Controls.Add(addPass);
            SuperUserPanel.Controls.Add(addName);
            SuperUserPanel.Location = new Point(770, 218);
            SuperUserPanel.Name = "SuperUserPanel";
            SuperUserPanel.Size = new Size(463, 292);
            SuperUserPanel.TabIndex = 9;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(90, 156);
            label11.Name = "label11";
            label11.Size = new Size(46, 25);
            label11.TabIndex = 11;
            label11.Text = "Role";
            // 
            // roleCombo
            // 
            roleCombo.FormattingEnabled = true;
            roleCombo.Location = new Point(233, 158);
            roleCombo.Name = "roleCombo";
            roleCombo.Size = new Size(121, 23);
            roleCombo.TabIndex = 10;
            roleCombo.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(80, 18);
            label8.Name = "label8";
            label8.Size = new Size(90, 28);
            label8.TabIndex = 9;
            label8.Text = "Add user";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(80, 104);
            label9.Name = "label9";
            label9.Size = new Size(87, 25);
            label9.TabIndex = 8;
            label9.Text = "Password";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(80, 57);
            label10.Name = "label10";
            label10.Size = new Size(96, 25);
            label10.TabIndex = 7;
            label10.Text = "Username ";
            // 
            // superusrBackBtn
            // 
            superusrBackBtn.Image = Properties.Resources.icons8_back_arrow_100;
            superusrBackBtn.Location = new Point(17, 18);
            superusrBackBtn.Name = "superusrBackBtn";
            superusrBackBtn.Size = new Size(37, 34);
            superusrBackBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            superusrBackBtn.TabIndex = 6;
            superusrBackBtn.TabStop = false;
            superusrBackBtn.Click += superusrBackBtn_Click;
            // 
            // AddUserBtn
            // 
            AddUserBtn.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            AddUserBtn.Location = new Point(151, 194);
            AddUserBtn.Name = "AddUserBtn";
            AddUserBtn.Size = new Size(128, 43);
            AddUserBtn.TabIndex = 4;
            AddUserBtn.Text = "Add";
            AddUserBtn.UseVisualStyleBackColor = true;
            AddUserBtn.Click += AddUserBtn_Click;
            // 
            // addPass
            // 
            addPass.Location = new Point(233, 107);
            addPass.Name = "addPass";
            addPass.Size = new Size(100, 23);
            addPass.TabIndex = 3;
            // 
            // addName
            // 
            addName.Location = new Point(233, 60);
            addName.Name = "addName";
            addName.Size = new Size(100, 23);
            addName.TabIndex = 2;
            // 
            // BranchBtn
            // 
            BranchBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BranchBtn.Location = new Point(994, 12);
            BranchBtn.Name = "BranchBtn";
            BranchBtn.Size = new Size(75, 23);
            BranchBtn.TabIndex = 10;
            BranchBtn.Text = "Branch";
            BranchBtn.UseVisualStyleBackColor = true;
            BranchBtn.Click += BranchBtn_Click;
            // 
            // CloseBtn
            // 
            CloseBtn.BackgroundImage = Properties.Resources.cancel;
            CloseBtn.BackgroundImageLayout = ImageLayout.Stretch;
            CloseBtn.Location = new Point(1114, 12);
            CloseBtn.Name = "CloseBtn";
            CloseBtn.Size = new Size(37, 34);
            CloseBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            CloseBtn.TabIndex = 11;
            CloseBtn.TabStop = false;
            CloseBtn.Click += CloseBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 800);
            Controls.Add(CloseBtn);
            Controls.Add(BranchBtn);
            Controls.Add(SuperUserPanel);
            Controls.Add(AdminLoginPanel);
            Controls.Add(UserloginPanel);
            Controls.Add(pictureBox1);
            Controls.Add(button4);
            Controls.Add(SuperUserBtn);
            Controls.Add(LoginInfoPanel);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Loan Report Generator - TechCos Inc";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            LoginInfoPanel.ResumeLayout(false);
            AdminLoginPanel.ResumeLayout(false);
            AdminLoginPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)backAdminBtn).EndInit();
            UserloginPanel.ResumeLayout(false);
            UserloginPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)backUserBtn).EndInit();
            SuperUserPanel.ResumeLayout(false);
            SuperUserPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)superusrBackBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)CloseBtn).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Button SuperUserBtn;
        private Button button4;
        private PictureBox pictureBox1;
        private Panel LoginInfoPanel;
        private Panel AdminLoginPanel;
        private TextBox addPass;
        private Button AdminSubmitBtn;
        private TextBox PasswordAdminLoginTxtField;
        private TextBox UsernameAdminLoginTxtField;
        private TextBox addName;
        private Panel UserloginPanel;
        private Button UserSubmitBtn;
        private TextBox PasswordUserLoginTxtField;
        private TextBox textBox3;
        private TextBox UsernameUserLoginTxtField;
        private Label label4;
        private Label label5;
        private PictureBox backUserBtn;
        private PictureBox backAdminBtn;
        private Label label3;
        private Label label2;
        private Label label6;
        private Label label7;
        private Panel SuperUserPanel;
        private Label label8;
        private Label label9;
        private Label label10;
        private PictureBox superusrBackBtn;
        private Button AddUserBtn;
        private ComboBox roleCombo;
        private Label label11;
        private Button BranchBtn;
        private PictureBox CloseBtn;
    }
}