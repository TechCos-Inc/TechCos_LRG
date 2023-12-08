namespace TechCos_LRG
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            LoanListPanel = new Panel();
            GroupBtn = new MaterialSkin.Controls.MaterialButton();
            PersonalBtn = new MaterialSkin.Controls.MaterialButton();
            JlgBtn = new MaterialSkin.Controls.MaterialButton();
            BusinessBtn = new MaterialSkin.Controls.MaterialButton();
            panel1 = new Panel();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            branchComboBox = new MaterialSkin.Controls.MaterialComboBox();
            dataGridView = new DataGridView();
            label3 = new Label();
            label2 = new Label();
            containerPanel = new Panel();
            pictureBox1 = new PictureBox();
            BranchBtn = new MaterialSkin.Controls.MaterialButton();
            SuperUserBtn = new MaterialSkin.Controls.MaterialButton();
            openDirBtn = new MaterialSkin.Controls.MaterialButton();
            pictureBox2 = new PictureBox();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            procodeBtn = new MaterialSkin.Controls.MaterialButton();
            LoanListPanel.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            containerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // LoanListPanel
            // 
            LoanListPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            LoanListPanel.BackgroundImageLayout = ImageLayout.Center;
            LoanListPanel.Controls.Add(GroupBtn);
            LoanListPanel.Controls.Add(PersonalBtn);
            LoanListPanel.Controls.Add(JlgBtn);
            LoanListPanel.Controls.Add(BusinessBtn);
            LoanListPanel.Location = new Point(307, 103);
            LoanListPanel.Name = "LoanListPanel";
            LoanListPanel.Size = new Size(554, 93);
            LoanListPanel.TabIndex = 5;
            // 
            // GroupBtn
            // 
            GroupBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            GroupBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            GroupBtn.Depth = 0;
            GroupBtn.HighEmphasis = true;
            GroupBtn.Icon = null;
            GroupBtn.Location = new Point(445, 23);
            GroupBtn.Margin = new Padding(4, 6, 4, 6);
            GroupBtn.MouseState = MaterialSkin.MouseState.HOVER;
            GroupBtn.Name = "GroupBtn";
            GroupBtn.NoAccentTextColor = Color.Empty;
            GroupBtn.Size = new Size(70, 36);
            GroupBtn.TabIndex = 25;
            GroupBtn.Text = "Group";
            GroupBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            GroupBtn.UseAccentColor = false;
            GroupBtn.UseVisualStyleBackColor = true;
            GroupBtn.Click += GroupBtn_Click;
            // 
            // PersonalBtn
            // 
            PersonalBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            PersonalBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            PersonalBtn.Depth = 0;
            PersonalBtn.HighEmphasis = true;
            PersonalBtn.Icon = null;
            PersonalBtn.Location = new Point(49, 23);
            PersonalBtn.Margin = new Padding(4, 6, 4, 6);
            PersonalBtn.MouseState = MaterialSkin.MouseState.HOVER;
            PersonalBtn.Name = "PersonalBtn";
            PersonalBtn.NoAccentTextColor = Color.Empty;
            PersonalBtn.Size = new Size(96, 36);
            PersonalBtn.TabIndex = 22;
            PersonalBtn.Text = "Personal";
            PersonalBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            PersonalBtn.UseAccentColor = false;
            PersonalBtn.UseVisualStyleBackColor = true;
            PersonalBtn.Click += PersonalBtn_Click_1;
            // 
            // JlgBtn
            // 
            JlgBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            JlgBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            JlgBtn.Depth = 0;
            JlgBtn.HighEmphasis = true;
            JlgBtn.Icon = null;
            JlgBtn.Location = new Point(329, 23);
            JlgBtn.Margin = new Padding(4, 6, 4, 6);
            JlgBtn.MouseState = MaterialSkin.MouseState.HOVER;
            JlgBtn.Name = "JlgBtn";
            JlgBtn.NoAccentTextColor = Color.Empty;
            JlgBtn.Size = new Size(64, 36);
            JlgBtn.TabIndex = 24;
            JlgBtn.Text = "JLG";
            JlgBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            JlgBtn.UseAccentColor = false;
            JlgBtn.UseVisualStyleBackColor = true;
            JlgBtn.Click += JlgBtn_Click_1;
            // 
            // BusinessBtn
            // 
            BusinessBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BusinessBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BusinessBtn.Depth = 0;
            BusinessBtn.HighEmphasis = true;
            BusinessBtn.Icon = null;
            BusinessBtn.Location = new Point(187, 23);
            BusinessBtn.Margin = new Padding(4, 6, 4, 6);
            BusinessBtn.MouseState = MaterialSkin.MouseState.HOVER;
            BusinessBtn.Name = "BusinessBtn";
            BusinessBtn.NoAccentTextColor = Color.Empty;
            BusinessBtn.Size = new Size(90, 36);
            BusinessBtn.TabIndex = 23;
            BusinessBtn.Text = "Business";
            BusinessBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            BusinessBtn.UseAccentColor = false;
            BusinessBtn.UseVisualStyleBackColor = true;
            BusinessBtn.Click += BusinessBtn_Click_1;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackgroundImageLayout = ImageLayout.Center;
            panel1.Controls.Add(materialLabel1);
            panel1.Controls.Add(branchComboBox);
            panel1.Location = new Point(365, 37);
            panel1.Name = "panel1";
            panel1.Size = new Size(418, 92);
            panel1.TabIndex = 6;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            materialLabel1.Location = new Point(34, 26);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(76, 29);
            materialLabel1.TabIndex = 23;
            materialLabel1.Text = "Branch";
            // 
            // branchComboBox
            // 
            branchComboBox.AutoResize = false;
            branchComboBox.BackColor = Color.FromArgb(255, 255, 255);
            branchComboBox.Depth = 0;
            branchComboBox.DrawMode = DrawMode.OwnerDrawVariable;
            branchComboBox.DropDownHeight = 174;
            branchComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            branchComboBox.DropDownWidth = 121;
            branchComboBox.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            branchComboBox.ForeColor = Color.FromArgb(222, 0, 0, 0);
            branchComboBox.FormattingEnabled = true;
            branchComboBox.IntegralHeight = false;
            branchComboBox.ItemHeight = 43;
            branchComboBox.Location = new Point(186, 18);
            branchComboBox.MaxDropDownItems = 4;
            branchComboBox.MouseState = MaterialSkin.MouseState.OUT;
            branchComboBox.Name = "branchComboBox";
            branchComboBox.Size = new Size(208, 49);
            branchComboBox.StartIndex = 0;
            branchComboBox.TabIndex = 22;
            branchComboBox.SelectedIndexChanged += branchComboBox_SelectedIndexChanged;
            // 
            // dataGridView
            // 
            dataGridView.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(48, 277);
            dataGridView.Name = "dataGridView";
            dataGridView.RowTemplate.Height = 25;
            dataGridView.Size = new Size(1062, 228);
            dataGridView.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(433, 216);
            label3.Name = "label3";
            label3.Size = new Size(297, 32);
            label3.TabIndex = 14;
            label3.Text = "EDIT AN EXISTING LOAN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(480, 42);
            label2.Name = "label2";
            label2.Size = new Size(203, 32);
            label2.TabIndex = 15;
            label2.Text = "CREATE A  LOAN";
            // 
            // containerPanel
            // 
            containerPanel.Controls.Add(LoanListPanel);
            containerPanel.Controls.Add(label3);
            containerPanel.Controls.Add(dataGridView);
            containerPanel.Controls.Add(label2);
            containerPanel.Location = new Point(29, 182);
            containerPanel.Name = "containerPanel";
            containerPanel.Size = new Size(1143, 547);
            containerPanel.TabIndex = 16;
            containerPanel.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = Properties.Resources.cancel;
            pictureBox1.Location = new Point(1135, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(37, 34);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // BranchBtn
            // 
            BranchBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BranchBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            BranchBtn.Depth = 0;
            BranchBtn.HighEmphasis = true;
            BranchBtn.Icon = null;
            BranchBtn.Location = new Point(13, 16);
            BranchBtn.Margin = new Padding(4, 6, 4, 6);
            BranchBtn.MouseState = MaterialSkin.MouseState.HOVER;
            BranchBtn.Name = "BranchBtn";
            BranchBtn.NoAccentTextColor = Color.Empty;
            BranchBtn.Size = new Size(142, 36);
            BranchBtn.TabIndex = 20;
            BranchBtn.Text = "Branch Details";
            BranchBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            BranchBtn.UseAccentColor = false;
            BranchBtn.UseVisualStyleBackColor = true;
            BranchBtn.Click += BranchBtn_Click_1;
            // 
            // SuperUserBtn
            // 
            SuperUserBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            SuperUserBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            SuperUserBtn.Depth = 0;
            SuperUserBtn.HighEmphasis = true;
            SuperUserBtn.Icon = null;
            SuperUserBtn.Location = new Point(180, 16);
            SuperUserBtn.Margin = new Padding(4, 6, 4, 6);
            SuperUserBtn.MouseState = MaterialSkin.MouseState.HOVER;
            SuperUserBtn.Name = "SuperUserBtn";
            SuperUserBtn.NoAccentTextColor = Color.Empty;
            SuperUserBtn.Size = new Size(106, 36);
            SuperUserBtn.TabIndex = 21;
            SuperUserBtn.Text = "Super User";
            SuperUserBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            SuperUserBtn.UseAccentColor = false;
            SuperUserBtn.UseVisualStyleBackColor = true;
            SuperUserBtn.Click += SuperUserBtn_Click;
            // 
            // openDirBtn
            // 
            openDirBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            openDirBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            openDirBtn.Depth = 0;
            openDirBtn.HighEmphasis = true;
            openDirBtn.Icon = null;
            openDirBtn.Location = new Point(13, 64);
            openDirBtn.Margin = new Padding(4, 6, 4, 6);
            openDirBtn.MouseState = MaterialSkin.MouseState.HOVER;
            openDirBtn.Name = "openDirBtn";
            openDirBtn.NoAccentTextColor = Color.Empty;
            openDirBtn.Size = new Size(142, 36);
            openDirBtn.TabIndex = 22;
            openDirBtn.Text = "Open Directory";
            openDirBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            openDirBtn.UseAccentColor = false;
            openDirBtn.UseVisualStyleBackColor = true;
            openDirBtn.Click += openDirBtn_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.signout;
            pictureBox2.Location = new Point(1078, 16);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(37, 34);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 23;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(1065, 59);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(62, 19);
            materialLabel2.TabIndex = 24;
            materialLabel2.Text = "Sign Out";
            // 
            // procodeBtn
            // 
            procodeBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            procodeBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            procodeBtn.Depth = 0;
            procodeBtn.HighEmphasis = true;
            procodeBtn.Icon = null;
            procodeBtn.Location = new Point(180, 64);
            procodeBtn.Margin = new Padding(4, 6, 4, 6);
            procodeBtn.MouseState = MaterialSkin.MouseState.HOVER;
            procodeBtn.Name = "procodeBtn";
            procodeBtn.NoAccentTextColor = Color.Empty;
            procodeBtn.Size = new Size(88, 36);
            procodeBtn.TabIndex = 25;
            procodeBtn.Text = "procode";
            procodeBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            procodeBtn.UseAccentColor = false;
            procodeBtn.UseVisualStyleBackColor = true;
            procodeBtn.Click += procodeBtn_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 761);
            Controls.Add(procodeBtn);
            Controls.Add(materialLabel2);
            Controls.Add(pictureBox2);
            Controls.Add(openDirBtn);
            Controls.Add(SuperUserBtn);
            Controls.Add(BranchBtn);
            Controls.Add(pictureBox1);
            Controls.Add(containerPanel);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            StateCommon.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right;
            StateCommon.Border.Rounding = 20;
            Text = "Loan Report Generator - TechCos Inc";
            Load += Form2_Load;
            LoanListPanel.ResumeLayout(false);
            LoanListPanel.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            containerPanel.ResumeLayout(false);
            containerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel LoanListPanel;
        private Panel panel1;
        private DataGridView dataGridView;
        private Label label3;
        private Label label2;
        private Panel containerPanel;
        private PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialButton BranchBtn;
        private MaterialSkin.Controls.MaterialButton SuperUserBtn;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialComboBox branchComboBox;
        private MaterialSkin.Controls.MaterialButton PersonalBtn;
        private MaterialSkin.Controls.MaterialButton GroupBtn;
        private MaterialSkin.Controls.MaterialButton JlgBtn;
        private MaterialSkin.Controls.MaterialButton BusinessBtn;
        private MaterialSkin.Controls.MaterialButton openDirBtn;
        private PictureBox pictureBox2;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialButton procodeBtn;
    }
}