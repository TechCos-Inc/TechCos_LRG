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
            SuperUserBtn = new Button();
            button4 = new Button();
            pictureBox1 = new PictureBox();
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
            CloseBtn = new PictureBox();
            panelContainer = new Panel();
            SubmitBtn = new MaterialSkin.Controls.MaterialButton();
            PasswordTxt = new MaterialSkin.Controls.MaterialTextBox();
            UsernameTxt = new MaterialSkin.Controls.MaterialTextBox();
            label12 = new Label();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuperUserPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)superusrBackBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CloseBtn).BeginInit();
            panelContainer.SuspendLayout();
            SuspendLayout();
            // 
            // SuperUserBtn
            // 
            SuperUserBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            SuperUserBtn.Location = new Point(1820, 18);
            SuperUserBtn.Name = "SuperUserBtn";
            SuperUserBtn.Size = new Size(75, 23);
            SuperUserBtn.TabIndex = 3;
            SuperUserBtn.Text = "Super User";
            SuperUserBtn.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button4.Location = new Point(1919, 18);
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
            SuperUserPanel.Location = new Point(138, 578);
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
            // CloseBtn
            // 
            CloseBtn.BackgroundImageLayout = ImageLayout.Stretch;
            CloseBtn.Image = Properties.Resources.cancel;
            CloseBtn.Location = new Point(1151, 12);
            CloseBtn.Name = "CloseBtn";
            CloseBtn.Size = new Size(37, 34);
            CloseBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            CloseBtn.TabIndex = 11;
            CloseBtn.TabStop = false;
            CloseBtn.Click += CloseBtn_Click;
            // 
            // panelContainer
            // 
            panelContainer.Controls.Add(SubmitBtn);
            panelContainer.Controls.Add(PasswordTxt);
            panelContainer.Controls.Add(UsernameTxt);
            panelContainer.Controls.Add(label12);
            panelContainer.Location = new Point(642, 210);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(509, 322);
            panelContainer.TabIndex = 12;
            // 
            // SubmitBtn
            // 
            SubmitBtn.AutoEllipsis = true;
            SubmitBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            SubmitBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            SubmitBtn.Depth = 0;
            SubmitBtn.HighEmphasis = true;
            SubmitBtn.Icon = null;
            SubmitBtn.Location = new Point(195, 259);
            SubmitBtn.Margin = new Padding(4, 6, 4, 6);
            SubmitBtn.MouseState = MaterialSkin.MouseState.HOVER;
            SubmitBtn.Name = "SubmitBtn";
            SubmitBtn.NoAccentTextColor = Color.Empty;
            SubmitBtn.Size = new Size(75, 36);
            SubmitBtn.TabIndex = 6;
            SubmitBtn.Text = "SUBMIT";
            SubmitBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            SubmitBtn.UseAccentColor = false;
            SubmitBtn.UseVisualStyleBackColor = true;
            SubmitBtn.Click += SubmitBtn_Click;
            // 
            // PasswordTxt
            // 
            PasswordTxt.AnimateReadOnly = false;
            PasswordTxt.BorderStyle = BorderStyle.None;
            PasswordTxt.Depth = 0;
            PasswordTxt.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            PasswordTxt.Hint = "Password";
            PasswordTxt.LeadingIcon = (Image)resources.GetObject("PasswordTxt.LeadingIcon");
            PasswordTxt.Location = new Point(150, 179);
            PasswordTxt.MaxLength = 50;
            PasswordTxt.MouseState = MaterialSkin.MouseState.OUT;
            PasswordTxt.Multiline = false;
            PasswordTxt.Name = "PasswordTxt";
            PasswordTxt.Password = true;
            PasswordTxt.Size = new Size(184, 50);
            PasswordTxt.TabIndex = 5;
            PasswordTxt.Text = "";
            PasswordTxt.TrailingIcon = null;
            // 
            // UsernameTxt
            // 
            UsernameTxt.AnimateReadOnly = false;
            UsernameTxt.BorderStyle = BorderStyle.None;
            UsernameTxt.Depth = 0;
            UsernameTxt.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            UsernameTxt.Hint = "Username";
            UsernameTxt.LeadingIcon = Properties.Resources.user;
            UsernameTxt.Location = new Point(150, 110);
            UsernameTxt.MaxLength = 50;
            UsernameTxt.MouseState = MaterialSkin.MouseState.OUT;
            UsernameTxt.Multiline = false;
            UsernameTxt.Name = "UsernameTxt";
            UsernameTxt.Size = new Size(184, 50);
            UsernameTxt.TabIndex = 4;
            UsernameTxt.Text = "";
            UsernameTxt.TrailingIcon = null;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Lucida Fax", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(34, 14);
            label12.Name = "label12";
            label12.Size = new Size(181, 55);
            label12.TabIndex = 1;
            label12.Text = "Log In";
            // 
            // button3
            // 
            button3.Location = new Point(633, 483);
            button3.Name = "button3";
            button3.Size = new Size(8, 8);
            button3.TabIndex = 13;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            ClientSize = new Size(1200, 800);
            Controls.Add(button3);
            Controls.Add(panelContainer);
            Controls.Add(CloseBtn);
            Controls.Add(pictureBox1);
            Controls.Add(button4);
            Controls.Add(SuperUserBtn);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            StateCommon.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right;
            StateCommon.Border.Rounding = 20;
            Text = "Loan Report Generator - TechCos Inc";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            SuperUserPanel.ResumeLayout(false);
            SuperUserPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)superusrBackBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)CloseBtn).EndInit();
            panelContainer.ResumeLayout(false);
            panelContainer.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button SuperUserBtn;
        private Button button4;
        private PictureBox pictureBox1;
        private TextBox addPass;
        private TextBox addName;
        private TextBox textBox3;
        private Panel SuperUserPanel;
        private Label label8;
        private Label label9;
        private Label label10;
        private PictureBox superusrBackBtn;
        private Button AddUserBtn;
        private ComboBox roleCombo;
        private Label label11;
        private PictureBox CloseBtn;
        private Panel panelContainer;
        private Button button3;
        private Krypton.Toolkit.KryptonBreadCrumb kryptonBreadCrumb1;
        private Label label12;
        private MaterialSkin.Controls.MaterialTextBox UsernameTxt;
        private MaterialSkin.Controls.MaterialTextBox PasswordTxt;
        private MaterialSkin.Controls.MaterialButton SubmitBtn;
    }
}