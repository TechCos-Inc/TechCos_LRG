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
            panelbtn = new Panel();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            mem1Btn = new Button();
            AmtBtn = new Button();
            JlgBtn = new Button();
            panelExpt = new Panel();
            JLGpanal = new Panel();
            panelbtn.SuspendLayout();
            SuspendLayout();
            // 
            // panelbtn
            // 
            panelbtn.BackColor = SystemColors.Highlight;
            panelbtn.Controls.Add(button7);
            panelbtn.Controls.Add(button6);
            panelbtn.Controls.Add(button5);
            panelbtn.Controls.Add(button4);
            panelbtn.Controls.Add(mem1Btn);
            panelbtn.Controls.Add(AmtBtn);
            panelbtn.Controls.Add(JlgBtn);
            panelbtn.Dock = DockStyle.Left;
            panelbtn.Location = new Point(0, 0);
            panelbtn.Name = "panelbtn";
            panelbtn.Size = new Size(200, 676);
            panelbtn.TabIndex = 0;
            // 
            // button7
            // 
            button7.Location = new Point(30, 524);
            button7.Name = "button7";
            button7.Size = new Size(151, 43);
            button7.TabIndex = 15;
            button7.Text = "button7";
            button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(30, 458);
            button6.Name = "button6";
            button6.Size = new Size(151, 43);
            button6.TabIndex = 14;
            button6.Text = "button6";
            button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(30, 382);
            button5.Name = "button5";
            button5.Size = new Size(151, 43);
            button5.TabIndex = 13;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(30, 308);
            button4.Name = "button4";
            button4.Size = new Size(151, 43);
            button4.TabIndex = 12;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // mem1Btn
            // 
            mem1Btn.Location = new Point(30, 238);
            mem1Btn.Name = "mem1Btn";
            mem1Btn.Size = new Size(151, 43);
            mem1Btn.TabIndex = 11;
            mem1Btn.Text = "member 1";
            mem1Btn.UseVisualStyleBackColor = true;
            mem1Btn.Click += mem1Btn_Click;
            // 
            // AmtBtn
            // 
            AmtBtn.Location = new Point(30, 167);
            AmtBtn.Name = "AmtBtn";
            AmtBtn.Size = new Size(151, 43);
            AmtBtn.TabIndex = 10;
            AmtBtn.Text = "Amount Detial";
            AmtBtn.UseVisualStyleBackColor = true;
            AmtBtn.Click += AmtBtn_Click;
            // 
            // JlgBtn
            // 
            JlgBtn.Location = new Point(30, 97);
            JlgBtn.Name = "JlgBtn";
            JlgBtn.Size = new Size(151, 43);
            JlgBtn.TabIndex = 9;
            JlgBtn.Text = "JLG Browor";
            JlgBtn.UseVisualStyleBackColor = true;
            JlgBtn.Click += JlgBtn_Click;
            // 
            // panelExpt
            // 
            panelExpt.BackColor = SystemColors.Highlight;
            panelExpt.Dock = DockStyle.Bottom;
            panelExpt.Location = new Point(200, 616);
            panelExpt.Name = "panelExpt";
            panelExpt.Size = new Size(885, 60);
            panelExpt.TabIndex = 1;
            // 
            // JLGpanal
            // 
            JLGpanal.BackColor = SystemColors.MenuHighlight;
            JLGpanal.Dock = DockStyle.Fill;
            JLGpanal.Location = new Point(200, 0);
            JLGpanal.Name = "JLGpanal";
            JLGpanal.Size = new Size(885, 616);
            JLGpanal.TabIndex = 2;
            // 
            // JLGLoan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1085, 676);
            Controls.Add(JLGpanal);
            Controls.Add(panelExpt);
            Controls.Add(panelbtn);
            Name = "JLGLoan";
            Text = "JLGLoan";
            panelbtn.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelbtn;
        private Panel panelExpt;
        private Panel JLGpanal;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button mem1Btn;
        private Button AmtBtn;
        private Button JlgBtn;
    }
}