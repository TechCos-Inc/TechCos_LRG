namespace TechCos_LRG
{
    partial class JLGLoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JLGLoan));
            exportBtn = new MaterialSkin.Controls.MaterialButton();
            containerPanel = new Panel();
            topPanel = new Krypton.Toolkit.KryptonPanel();
            amountDetailsBtn = new MaterialSkin.Controls.MaterialButton();
            memberDetailsBtn = new MaterialSkin.Controls.MaterialButton();
            borrowerBtn = new MaterialSkin.Controls.MaterialButton();
            BackBtn = new PictureBox();
            CloseBtn = new PictureBox();
            bottomMemPgPanel = new Panel();
            ((System.ComponentModel.ISupportInitialize)topPanel).BeginInit();
            topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BackBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CloseBtn).BeginInit();
            SuspendLayout();
            // 
            // exportBtn
            // 
            exportBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            exportBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            exportBtn.Depth = 0;
            exportBtn.HighEmphasis = true;
            exportBtn.Icon = null;
            exportBtn.Location = new Point(1052, 710);
            exportBtn.Margin = new Padding(4, 6, 4, 6);
            exportBtn.MouseState = MaterialSkin.MouseState.HOVER;
            exportBtn.Name = "exportBtn";
            exportBtn.NoAccentTextColor = Color.Empty;
            exportBtn.Size = new Size(77, 36);
            exportBtn.TabIndex = 0;
            exportBtn.Text = "Export";
            exportBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            exportBtn.UseAccentColor = false;
            exportBtn.UseVisualStyleBackColor = true;
            exportBtn.Click += exportBtn_Click;
            // 
            // containerPanel
            // 
            containerPanel.Location = new Point(-4, 92);
            containerPanel.Margin = new Padding(0, 0, 0, 3);
            containerPanel.Name = "containerPanel";
            containerPanel.Size = new Size(1184, 605);
            containerPanel.TabIndex = 2;
            // 
            // topPanel
            // 
            topPanel.Controls.Add(amountDetailsBtn);
            topPanel.Controls.Add(memberDetailsBtn);
            topPanel.Controls.Add(borrowerBtn);
            topPanel.Controls.Add(BackBtn);
            topPanel.Controls.Add(CloseBtn);
            topPanel.Dock = DockStyle.Top;
            topPanel.Location = new Point(0, 0);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(1184, 83);
            topPanel.TabIndex = 0;
            // 
            // amountDetailsBtn
            // 
            amountDetailsBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            amountDetailsBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            amountDetailsBtn.Depth = 0;
            amountDetailsBtn.HighEmphasis = true;
            amountDetailsBtn.Icon = null;
            amountDetailsBtn.Location = new Point(766, 24);
            amountDetailsBtn.Margin = new Padding(4, 6, 4, 6);
            amountDetailsBtn.MouseState = MaterialSkin.MouseState.HOVER;
            amountDetailsBtn.Name = "amountDetailsBtn";
            amountDetailsBtn.NoAccentTextColor = Color.Empty;
            amountDetailsBtn.Size = new Size(145, 36);
            amountDetailsBtn.TabIndex = 22;
            amountDetailsBtn.Text = "Amount Details";
            amountDetailsBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            amountDetailsBtn.UseAccentColor = false;
            amountDetailsBtn.UseVisualStyleBackColor = true;
            amountDetailsBtn.Click += amountDetailsBtn_Click;
            // 
            // memberDetailsBtn
            // 
            memberDetailsBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            memberDetailsBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            memberDetailsBtn.Depth = 0;
            memberDetailsBtn.HighEmphasis = true;
            memberDetailsBtn.Icon = null;
            memberDetailsBtn.Location = new Point(491, 24);
            memberDetailsBtn.Margin = new Padding(4, 6, 4, 6);
            memberDetailsBtn.MouseState = MaterialSkin.MouseState.HOVER;
            memberDetailsBtn.Name = "memberDetailsBtn";
            memberDetailsBtn.NoAccentTextColor = Color.Empty;
            memberDetailsBtn.Size = new Size(144, 36);
            memberDetailsBtn.TabIndex = 21;
            memberDetailsBtn.Text = "Member Details";
            memberDetailsBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            memberDetailsBtn.UseAccentColor = false;
            memberDetailsBtn.UseVisualStyleBackColor = true;
            memberDetailsBtn.Click += memberDetailsBtn_Click;
            // 
            // borrowerBtn
            // 
            borrowerBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            borrowerBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            borrowerBtn.Depth = 0;
            borrowerBtn.HighEmphasis = true;
            borrowerBtn.Icon = null;
            borrowerBtn.Location = new Point(203, 24);
            borrowerBtn.Margin = new Padding(4, 6, 4, 6);
            borrowerBtn.MouseState = MaterialSkin.MouseState.HOVER;
            borrowerBtn.Name = "borrowerBtn";
            borrowerBtn.NoAccentTextColor = Color.Empty;
            borrowerBtn.Size = new Size(161, 36);
            borrowerBtn.TabIndex = 20;
            borrowerBtn.Text = "Borrower Details";
            borrowerBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            borrowerBtn.UseAccentColor = false;
            borrowerBtn.UseVisualStyleBackColor = true;
            borrowerBtn.Click += borrowerBtn_Click;
            // 
            // BackBtn
            // 
            BackBtn.BackColor = Color.Transparent;
            BackBtn.Image = Properties.Resources.icons8_back_arrow_100;
            BackBtn.Location = new Point(1076, 10);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(37, 34);
            BackBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            BackBtn.TabIndex = 19;
            BackBtn.TabStop = false;
            BackBtn.Click += BackBtn_Click_1;
            // 
            // CloseBtn
            // 
            CloseBtn.BackColor = Color.Transparent;
            CloseBtn.BackgroundImage = Properties.Resources.cancel;
            CloseBtn.BackgroundImageLayout = ImageLayout.Stretch;
            CloseBtn.Location = new Point(1132, 10);
            CloseBtn.Name = "CloseBtn";
            CloseBtn.Size = new Size(37, 34);
            CloseBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            CloseBtn.TabIndex = 18;
            CloseBtn.TabStop = false;
            CloseBtn.Click += CloseBtn_Click_1;
            // 
            // bottomMemPgPanel
            // 
            bottomMemPgPanel.Location = new Point(261, 703);
            bottomMemPgPanel.Name = "bottomMemPgPanel";
            bottomMemPgPanel.Size = new Size(680, 55);
            bottomMemPgPanel.TabIndex = 3;
            // 
            // JLGLoan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 761);
            Controls.Add(bottomMemPgPanel);
            Controls.Add(topPanel);
            Controls.Add(exportBtn);
            Controls.Add(containerPanel);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "JLGLoan";
            StartPosition = FormStartPosition.CenterScreen;
            StateCommon.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right;
            StateCommon.Border.Rounding = 20;
            Text = "JLGLoan";
            Load += JLGLoan_Load;
            ((System.ComponentModel.ISupportInitialize)topPanel).EndInit();
            topPanel.ResumeLayout(false);
            topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)BackBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)CloseBtn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel containerPanel;
        private Button button10;
        private MaterialSkin.Controls.MaterialButton exportBtn;
        private Krypton.Toolkit.KryptonPanel topPanel;
        private MaterialSkin.Controls.MaterialButton amountDetailsBtn;
        private MaterialSkin.Controls.MaterialButton memberDetailsBtn;
        private MaterialSkin.Controls.MaterialButton borrowerBtn;
        private PictureBox BackBtn;
        private PictureBox CloseBtn;
        private Panel bottomMemPgPanel;
    }
}