namespace TechCos_LRG
{
    partial class SuperUserForm
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
            CloseBtn = new PictureBox();
            superusrBackBtn = new PictureBox();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            addUserNameTxt = new MaterialSkin.Controls.MaterialTextBox2();
            addUserPassTxt = new MaterialSkin.Controls.MaterialTextBox2();
            adminRadioButton = new MaterialSkin.Controls.MaterialRadioButton();
            userRadioButton = new MaterialSkin.Controls.MaterialRadioButton();
            materialButton1 = new MaterialSkin.Controls.MaterialButton();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)CloseBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)superusrBackBtn).BeginInit();
            SuspendLayout();
            // 
            // CloseBtn
            // 
            CloseBtn.BackgroundImageLayout = ImageLayout.Stretch;
            CloseBtn.Image = Properties.Resources.cancel;
            CloseBtn.Location = new Point(739, 12);
            CloseBtn.Name = "CloseBtn";
            CloseBtn.Size = new Size(37, 34);
            CloseBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            CloseBtn.TabIndex = 12;
            CloseBtn.TabStop = false;
            CloseBtn.Click += CloseBtn_Click;
            // 
            // superusrBackBtn
            // 
            superusrBackBtn.Image = Properties.Resources.icons8_back_arrow_100;
            superusrBackBtn.Location = new Point(696, 12);
            superusrBackBtn.Name = "superusrBackBtn";
            superusrBackBtn.Size = new Size(37, 34);
            superusrBackBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            superusrBackBtn.TabIndex = 580;
            superusrBackBtn.TabStop = false;
            superusrBackBtn.Click += superusrBackBtn_Click;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            materialLabel1.Location = new Point(219, 108);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(110, 29);
            materialLabel1.TabIndex = 581;
            materialLabel1.Text = "Username";
            // 
            // materialLabel2
            // 
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            materialLabel2.Location = new Point(219, 174);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(124, 48);
            materialLabel2.TabIndex = 582;
            materialLabel2.Text = "Password";
            materialLabel2.Click += materialLabel2_Click;
            // 
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            materialLabel3.Location = new Point(219, 273);
            materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(49, 29);
            materialLabel3.TabIndex = 583;
            materialLabel3.Text = "Role";
            // 
            // addUserNameTxt
            // 
            addUserNameTxt.AnimateReadOnly = false;
            addUserNameTxt.BackgroundImageLayout = ImageLayout.None;
            addUserNameTxt.CharacterCasing = CharacterCasing.Normal;
            addUserNameTxt.Depth = 0;
            addUserNameTxt.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            addUserNameTxt.HideSelection = true;
            addUserNameTxt.LeadingIcon = null;
            addUserNameTxt.Location = new Point(417, 108);
            addUserNameTxt.Margin = new Padding(0);
            addUserNameTxt.MaxLength = 32767;
            addUserNameTxt.MouseState = MaterialSkin.MouseState.OUT;
            addUserNameTxt.Name = "addUserNameTxt";
            addUserNameTxt.PasswordChar = '\0';
            addUserNameTxt.PrefixSuffixText = null;
            addUserNameTxt.ReadOnly = false;
            addUserNameTxt.RightToLeft = RightToLeft.No;
            addUserNameTxt.SelectedText = "";
            addUserNameTxt.SelectionLength = 0;
            addUserNameTxt.SelectionStart = 0;
            addUserNameTxt.ShortcutsEnabled = true;
            addUserNameTxt.Size = new Size(179, 48);
            addUserNameTxt.TabIndex = 585;
            addUserNameTxt.TabStop = false;
            addUserNameTxt.TextAlign = HorizontalAlignment.Left;
            addUserNameTxt.TrailingIcon = null;
            addUserNameTxt.UseSystemPasswordChar = false;
            // 
            // addUserPassTxt
            // 
            addUserPassTxt.AnimateReadOnly = false;
            addUserPassTxt.BackgroundImageLayout = ImageLayout.None;
            addUserPassTxt.CharacterCasing = CharacterCasing.Normal;
            addUserPassTxt.Depth = 0;
            addUserPassTxt.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            addUserPassTxt.HideSelection = true;
            addUserPassTxt.LeadingIcon = null;
            addUserPassTxt.Location = new Point(417, 174);
            addUserPassTxt.Margin = new Padding(0);
            addUserPassTxt.MaxLength = 32767;
            addUserPassTxt.MouseState = MaterialSkin.MouseState.OUT;
            addUserPassTxt.Name = "addUserPassTxt";
            addUserPassTxt.PasswordChar = '\0';
            addUserPassTxt.PrefixSuffixText = null;
            addUserPassTxt.ReadOnly = false;
            addUserPassTxt.RightToLeft = RightToLeft.No;
            addUserPassTxt.SelectedText = "";
            addUserPassTxt.SelectionLength = 0;
            addUserPassTxt.SelectionStart = 0;
            addUserPassTxt.ShortcutsEnabled = true;
            addUserPassTxt.Size = new Size(179, 48);
            addUserPassTxt.TabIndex = 586;
            addUserPassTxt.TabStop = false;
            addUserPassTxt.TextAlign = HorizontalAlignment.Left;
            addUserPassTxt.TrailingIcon = null;
            addUserPassTxt.UseSystemPasswordChar = false;
            // 
            // adminRadioButton
            // 
            adminRadioButton.AutoSize = true;
            adminRadioButton.Depth = 0;
            adminRadioButton.Location = new Point(393, 273);
            adminRadioButton.Margin = new Padding(0);
            adminRadioButton.MouseLocation = new Point(-1, -1);
            adminRadioButton.MouseState = MaterialSkin.MouseState.HOVER;
            adminRadioButton.Name = "adminRadioButton";
            adminRadioButton.Ripple = true;
            adminRadioButton.Size = new Size(81, 37);
            adminRadioButton.TabIndex = 587;
            adminRadioButton.TabStop = true;
            adminRadioButton.Text = "Admin";
            adminRadioButton.UseVisualStyleBackColor = true;
            // 
            // userRadioButton
            // 
            userRadioButton.AutoSize = true;
            userRadioButton.Depth = 0;
            userRadioButton.Location = new Point(495, 273);
            userRadioButton.Margin = new Padding(0);
            userRadioButton.MouseLocation = new Point(-1, -1);
            userRadioButton.MouseState = MaterialSkin.MouseState.HOVER;
            userRadioButton.Name = "userRadioButton";
            userRadioButton.Ripple = true;
            userRadioButton.Size = new Size(122, 37);
            userRadioButton.TabIndex = 588;
            userRadioButton.TabStop = true;
            userRadioButton.Text = "Normal User";
            userRadioButton.UseVisualStyleBackColor = true;
            // 
            // materialButton1
            // 
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.Location = new Point(364, 366);
            materialButton1.Margin = new Padding(4, 6, 4, 6);
            materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(90, 36);
            materialButton1.TabIndex = 589;
            materialButton1.Text = "ADD USER";
            materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            materialButton1.Click += materialButton1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(276, 12);
            label1.Name = "label1";
            label1.Size = new Size(221, 50);
            label1.TabIndex = 590;
            label1.Text = "Super User ";
            // 
            // SuperUserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(label1);
            Controls.Add(materialButton1);
            Controls.Add(userRadioButton);
            Controls.Add(adminRadioButton);
            Controls.Add(addUserPassTxt);
            Controls.Add(addUserNameTxt);
            Controls.Add(materialLabel3);
            Controls.Add(materialLabel2);
            Controls.Add(materialLabel1);
            Controls.Add(superusrBackBtn);
            Controls.Add(CloseBtn);
            FormBorderStyle = FormBorderStyle.None;
            GroupBorderStyle = ComponentFactory.Krypton.Toolkit.PaletteBorderStyle.HeaderForm;
            HeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.Custom1;
            Name = "SuperUserForm";
            RightToLeft = RightToLeft.No;
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            StateCommon.Border.Color1 = Color.Black;
            StateCommon.Border.Color2 = Color.Black;
            StateCommon.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right;
            StateCommon.Border.Rounding = 20;
            Text = "SuperUser";
            Load += SuperUserForm_Load;
            ((System.ComponentModel.ISupportInitialize)CloseBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)superusrBackBtn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox CloseBtn;
        private PictureBox superusrBackBtn;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialTextBox2 addUserNameTxt;
        private MaterialSkin.Controls.MaterialTextBox2 addUserPassTxt;
        private MaterialSkin.Controls.MaterialRadioButton adminRadioButton;
        private MaterialSkin.Controls.MaterialRadioButton userRadioButton;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private Label label1;
    }
}