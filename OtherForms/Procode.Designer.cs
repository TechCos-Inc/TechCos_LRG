namespace TechCos_LRG
{
    partial class Procode
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
            importBtn = new MaterialSkin.Controls.MaterialButton();
            openFD = new OpenFileDialog();
            dataGridView1 = new DataGridView();
            saveBtn = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)CloseBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // CloseBtn
            // 
            CloseBtn.BackgroundImageLayout = ImageLayout.Stretch;
            CloseBtn.Image = Properties.Resources.cancel;
            CloseBtn.Location = new Point(1151, 12);
            CloseBtn.Name = "CloseBtn";
            CloseBtn.Size = new Size(37, 34);
            CloseBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            CloseBtn.TabIndex = 12;
            CloseBtn.TabStop = false;
            CloseBtn.Click += CloseBtn_Click;
            // 
            // importBtn
            // 
            importBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            importBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            importBtn.Depth = 0;
            importBtn.HighEmphasis = true;
            importBtn.Icon = null;
            importBtn.Location = new Point(31, 136);
            importBtn.Margin = new Padding(4, 6, 4, 6);
            importBtn.MouseState = MaterialSkin.MouseState.HOVER;
            importBtn.Name = "importBtn";
            importBtn.NoAccentTextColor = Color.Empty;
            importBtn.Size = new Size(123, 36);
            importBtn.TabIndex = 14;
            importBtn.Text = "IMPORT EXCEL";
            importBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            importBtn.UseAccentColor = false;
            importBtn.UseVisualStyleBackColor = true;
            importBtn.Click += importBtn_Click;
            // 
            // openFD
            // 
            openFD.FileName = "openFD";
            openFD.FileOk += openFD_FileOk;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(31, 226);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1133, 539);
            dataGridView1.TabIndex = 15;
            // 
            // saveBtn
            // 
            saveBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            saveBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            saveBtn.Depth = 0;
            saveBtn.HighEmphasis = true;
            saveBtn.Icon = null;
            saveBtn.Location = new Point(199, 136);
            saveBtn.Margin = new Padding(4, 6, 4, 6);
            saveBtn.MouseState = MaterialSkin.MouseState.HOVER;
            saveBtn.Name = "saveBtn";
            saveBtn.NoAccentTextColor = Color.Empty;
            saveBtn.Size = new Size(64, 36);
            saveBtn.TabIndex = 16;
            saveBtn.Text = "Save";
            saveBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            saveBtn.UseAccentColor = false;
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
            // 
            // Procode
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 800);
            ControlBox = false;
            Controls.Add(saveBtn);
            Controls.Add(dataGridView1);
            Controls.Add(importBtn);
            Controls.Add(CloseBtn);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Procode";
            StateCommon.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right;
            StateCommon.Border.Rounding = 20;
            Text = "Procode";
            Load += Procode_Load;
            ((System.ComponentModel.ISupportInitialize)CloseBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox CloseBtn;
        private MaterialSkin.Controls.MaterialButton importBtn;
        private OpenFileDialog openFD;
        private DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialButton saveBtn;
    }
}