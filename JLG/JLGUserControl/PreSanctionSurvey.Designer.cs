namespace TechCos_LRG.JLG.JLGUserControl
{
    partial class PreSanctionSurvey
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            continueImg = new PictureBox();
            label17 = new Label();
            ((System.ComponentModel.ISupportInitialize)continueImg).BeginInit();
            SuspendLayout();
            // 
            // continueImg
            // 
            continueImg.BackColor = Color.Transparent;
            continueImg.Image = Properties.Resources._continue;
            continueImg.Location = new Point(1020, 543);
            continueImg.Name = "continueImg";
            continueImg.Size = new Size(58, 50);
            continueImg.SizeMode = PictureBoxSizeMode.StretchImage;
            continueImg.TabIndex = 151;
            continueImg.TabStop = false;
            continueImg.Click += continueImg_Click;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label17.Location = new Point(477, 288);
            label17.Name = "label17";
            label17.Size = new Size(177, 28);
            label17.TabIndex = 153;
            label17.Text = "Presanction Survey";
            // 
            // PreSanctionSurvey
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label17);
            Controls.Add(continueImg);
            Name = "PreSanctionSurvey";
            Size = new Size(1150, 605);
            ((System.ComponentModel.ISupportInitialize)continueImg).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox continueImg;
        private Label label17;
    }
}
