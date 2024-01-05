namespace TechCos_LRG.JLG.JLGUserControl
{
    partial class VisitReport
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
            label17 = new Label();
            SuspendLayout();
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label17.Location = new Point(477, 288);
            label17.Name = "label17";
            label17.Size = new Size(113, 28);
            label17.TabIndex = 153;
            label17.Text = "Visit Report";
            // 
            // VisitReport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label17);
            Name = "VisitReport";
            Size = new Size(1150, 605);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label17;
    }
}
