﻿namespace TechCos_LRG
{
    partial class BranchForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BranchForm));
            dataGridView = new DataGridView();
            CloseBtn = new PictureBox();
            BranchBackBtn = new PictureBox();
            panel1 = new Panel();
            ClearBtn = new MaterialSkin.Controls.MaterialButton();
            Emailtxt = new TextBox();
            updateBtn = new MaterialSkin.Controls.MaterialButton();
            AddBtn = new MaterialSkin.Controls.MaterialButton();
            ClassCombo = new ComboBox();
            label5 = new Label();
            PinCodetxt = new TextBox();
            label6 = new Label();
            label7 = new Label();
            Addresstxt = new TextBox();
            label8 = new Label();
            PhNotxt = new TextBox();
            label3 = new Label();
            BrManagerNametxt = new TextBox();
            label4 = new Label();
            BrNametxt = new TextBox();
            label2 = new Label();
            IFSCtxt = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CloseBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BranchBackBtn).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView.Location = new Point(458, 74);
            dataGridView.Name = "dataGridView";
            dataGridView.RowTemplate.Height = 25;
            dataGridView.Size = new Size(706, 650);
            dataGridView.TabIndex = 3;
            dataGridView.CellClick += dataGridView_CellClick;
            // 
            // CloseBtn
            // 
            CloseBtn.BackgroundImage = Properties.Resources.cancel;
            CloseBtn.BackgroundImageLayout = ImageLayout.Stretch;
            CloseBtn.Location = new Point(1151, 12);
            CloseBtn.Name = "CloseBtn";
            CloseBtn.Size = new Size(37, 34);
            CloseBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            CloseBtn.TabIndex = 12;
            CloseBtn.TabStop = false;
            CloseBtn.Click += CloseBtn_Click;
            // 
            // BranchBackBtn
            // 
            BranchBackBtn.Image = Properties.Resources.icons8_back_arrow_100;
            BranchBackBtn.Location = new Point(1097, 12);
            BranchBackBtn.Name = "BranchBackBtn";
            BranchBackBtn.Size = new Size(37, 34);
            BranchBackBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            BranchBackBtn.TabIndex = 13;
            BranchBackBtn.TabStop = false;
            BranchBackBtn.Click += BranchBackBtn_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.BackColor = SystemColors.ActiveBorder;
            panel1.Controls.Add(ClearBtn);
            panel1.Controls.Add(Emailtxt);
            panel1.Controls.Add(updateBtn);
            panel1.Controls.Add(AddBtn);
            panel1.Controls.Add(ClassCombo);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(PinCodetxt);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(Addresstxt);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(PhNotxt);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(BrManagerNametxt);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(BrNametxt);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(IFSCtxt);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(26, 14);
            panel1.Name = "panel1";
            panel1.Size = new Size(386, 759);
            panel1.TabIndex = 2;
            // 
            // ClearBtn
            // 
            ClearBtn.AutoSize = false;
            ClearBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClearBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            ClearBtn.Depth = 0;
            ClearBtn.HighEmphasis = true;
            ClearBtn.Icon = null;
            ClearBtn.Location = new Point(47, 702);
            ClearBtn.Margin = new Padding(4, 6, 4, 6);
            ClearBtn.MouseState = MaterialSkin.MouseState.HOVER;
            ClearBtn.Name = "ClearBtn";
            ClearBtn.NoAccentTextColor = Color.Empty;
            ClearBtn.Size = new Size(282, 40);
            ClearBtn.TabIndex = 16;
            ClearBtn.Text = "CLEAR";
            ClearBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            ClearBtn.UseAccentColor = false;
            ClearBtn.UseVisualStyleBackColor = true;
            // 
            // Emailtxt
            // 
            Emailtxt.Location = new Point(247, 568);
            Emailtxt.Name = "Emailtxt";
            Emailtxt.Size = new Size(121, 23);
            Emailtxt.TabIndex = 31;
            // 
            // updateBtn
            // 
            updateBtn.AutoSize = false;
            updateBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            updateBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            updateBtn.Depth = 0;
            updateBtn.HighEmphasis = true;
            updateBtn.Icon = null;
            updateBtn.Location = new Point(47, 654);
            updateBtn.Margin = new Padding(4, 6, 4, 6);
            updateBtn.MouseState = MaterialSkin.MouseState.HOVER;
            updateBtn.Name = "updateBtn";
            updateBtn.NoAccentTextColor = Color.Empty;
            updateBtn.Size = new Size(139, 36);
            updateBtn.TabIndex = 14;
            updateBtn.Text = "UPDATE";
            updateBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            updateBtn.UseAccentColor = false;
            updateBtn.UseVisualStyleBackColor = true;
            // 
            // AddBtn
            // 
            AddBtn.AutoSize = false;
            AddBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            AddBtn.BackColor = SystemColors.ActiveBorder;
            AddBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            AddBtn.Depth = 0;
            AddBtn.ForeColor = SystemColors.ActiveBorder;
            AddBtn.HighEmphasis = true;
            AddBtn.Icon = null;
            AddBtn.Location = new Point(194, 654);
            AddBtn.Margin = new Padding(4, 6, 4, 6);
            AddBtn.MouseState = MaterialSkin.MouseState.HOVER;
            AddBtn.Name = "AddBtn";
            AddBtn.NoAccentTextColor = Color.Empty;
            AddBtn.Size = new Size(135, 36);
            AddBtn.TabIndex = 15;
            AddBtn.Text = "ADD";
            AddBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            AddBtn.UseAccentColor = false;
            AddBtn.UseVisualStyleBackColor = false;
            AddBtn.Click += AddBtn_Click_1;
            // 
            // ClassCombo
            // 
            ClassCombo.FormattingEnabled = true;
            ClassCombo.Location = new Point(247, 226);
            ClassCombo.Name = "ClassCombo";
            ClassCombo.Size = new Size(121, 23);
            ClassCombo.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(16, 563);
            label5.Name = "label5";
            label5.Size = new Size(59, 28);
            label5.TabIndex = 30;
            label5.Text = "Email";
            // 
            // PinCodetxt
            // 
            PinCodetxt.Location = new Point(247, 508);
            PinCodetxt.Name = "PinCodetxt";
            PinCodetxt.Size = new Size(121, 23);
            PinCodetxt.TabIndex = 29;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(16, 294);
            label6.Name = "label6";
            label6.Size = new Size(99, 28);
            label6.TabIndex = 28;
            label6.Text = "Phone No";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(16, 221);
            label7.Name = "label7";
            label7.Size = new Size(125, 28);
            label7.TabIndex = 27;
            label7.Text = "Classification";
            // 
            // Addresstxt
            // 
            Addresstxt.Location = new Point(247, 373);
            Addresstxt.Multiline = true;
            Addresstxt.Name = "Addresstxt";
            Addresstxt.Size = new Size(121, 104);
            Addresstxt.TabIndex = 26;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(16, 500);
            label8.Name = "label8";
            label8.Size = new Size(90, 28);
            label8.TabIndex = 25;
            label8.Text = "Pin Code";
            // 
            // PhNotxt
            // 
            PhNotxt.Location = new Point(247, 299);
            PhNotxt.Name = "PhNotxt";
            PhNotxt.Size = new Size(121, 23);
            PhNotxt.TabIndex = 24;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(16, 373);
            label3.Name = "label3";
            label3.Size = new Size(82, 28);
            label3.TabIndex = 23;
            label3.Text = "Address";
            // 
            // BrManagerNametxt
            // 
            BrManagerNametxt.Location = new Point(247, 149);
            BrManagerNametxt.Name = "BrManagerNametxt";
            BrManagerNametxt.Size = new Size(121, 23);
            BrManagerNametxt.TabIndex = 22;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(13, 141);
            label4.Name = "label4";
            label4.Size = new Size(211, 28);
            label4.TabIndex = 21;
            label4.Text = "Branch Manager Name";
            // 
            // BrNametxt
            // 
            BrNametxt.Location = new Point(247, 89);
            BrNametxt.Name = "BrNametxt";
            BrNametxt.Size = new Size(121, 23);
            BrNametxt.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(13, 81);
            label2.Name = "label2";
            label2.Size = new Size(128, 28);
            label2.TabIndex = 19;
            label2.Text = "Branch Name";
            // 
            // IFSCtxt
            // 
            IFSCtxt.Location = new Point(247, 29);
            IFSCtxt.Name = "IFSCtxt";
            IFSCtxt.Size = new Size(121, 23);
            IFSCtxt.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(13, 21);
            label1.Name = "label1";
            label1.Size = new Size(50, 28);
            label1.TabIndex = 17;
            label1.Text = "IFSC";
            // 
            // BranchForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 800);
            Controls.Add(BranchBackBtn);
            Controls.Add(CloseBtn);
            Controls.Add(dataGridView);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "BranchForm";
            StartPosition = FormStartPosition.CenterScreen;
            StateCommon.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right;
            StateCommon.Border.Rounding = 20;
            Text = "BranchForm";
            Load += BranchForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)CloseBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)BranchBackBtn).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dataGridView;
        private PictureBox CloseBtn;
        private PictureBox BranchBackBtn;
        private Panel panel1;
        private MaterialSkin.Controls.MaterialButton ClearBtn;
        private TextBox Emailtxt;
        private MaterialSkin.Controls.MaterialButton updateBtn;
        private MaterialSkin.Controls.MaterialButton AddBtn;
        private ComboBox ClassCombo;
        private Label label5;
        private TextBox PinCodetxt;
        private Label label6;
        private Label label7;
        private TextBox Addresstxt;
        private Label label8;
        private TextBox PhNotxt;
        private Label label3;
        private TextBox BrManagerNametxt;
        private Label label4;
        private TextBox BrNametxt;
        private Label label2;
        private TextBox IFSCtxt;
        private Label label1;
    }
}