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
            branchComboBox = new ComboBox();
            label1 = new Label();
            PersonalBtn = new Button();
            BusinessBtn = new Button();
            GroupBtn = new Button();
            LoanListPanel = new Panel();
            panel1 = new Panel();
            dataGridView = new DataGridView();
            LoanListPanel.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // branchComboBox
            // 
            branchComboBox.FormattingEnabled = true;
            branchComboBox.Location = new Point(186, 35);
            branchComboBox.Name = "branchComboBox";
            branchComboBox.Size = new Size(121, 23);
            branchComboBox.TabIndex = 0;
            branchComboBox.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(29, 32);
            label1.Name = "label1";
            label1.Size = new Size(65, 25);
            label1.TabIndex = 1;
            label1.Text = "Branch";
            // 
            // PersonalBtn
            // 
            PersonalBtn.Location = new Point(41, 40);
            PersonalBtn.Name = "PersonalBtn";
            PersonalBtn.Size = new Size(75, 23);
            PersonalBtn.TabIndex = 2;
            PersonalBtn.Text = "Personal";
            PersonalBtn.UseVisualStyleBackColor = true;
            PersonalBtn.Click += PersonalBtn_Click;
            // 
            // BusinessBtn
            // 
            BusinessBtn.Location = new Point(161, 40);
            BusinessBtn.Name = "BusinessBtn";
            BusinessBtn.Size = new Size(122, 23);
            BusinessBtn.TabIndex = 3;
            BusinessBtn.Text = "Business (Muthra)";
            BusinessBtn.UseVisualStyleBackColor = true;
            BusinessBtn.Click += BusinessBtn_Click;
            // 
            // GroupBtn
            // 
            GroupBtn.Location = new Point(344, 40);
            GroupBtn.Name = "GroupBtn";
            GroupBtn.Size = new Size(75, 23);
            GroupBtn.TabIndex = 4;
            GroupBtn.Text = "Group";
            GroupBtn.UseVisualStyleBackColor = true;
            // 
            // LoanListPanel
            // 
            LoanListPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            LoanListPanel.BackgroundImageLayout = ImageLayout.Center;
            LoanListPanel.Controls.Add(PersonalBtn);
            LoanListPanel.Controls.Add(GroupBtn);
            LoanListPanel.Controls.Add(BusinessBtn);
            LoanListPanel.Location = new Point(488, 142);
            LoanListPanel.Name = "LoanListPanel";
            LoanListPanel.Size = new Size(492, 122);
            LoanListPanel.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackgroundImageLayout = ImageLayout.Center;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(branchComboBox);
            panel1.Location = new Point(570, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(322, 100);
            panel1.TabIndex = 6;
            // 
            // dataGridView
            // 
            dataGridView.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(162, 302);
            dataGridView.Name = "dataGridView";
            dataGridView.RowTemplate.Height = 25;
            dataGridView.Size = new Size(1137, 319);
            dataGridView.TabIndex = 7;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1454, 761);
            Controls.Add(dataGridView);
            Controls.Add(panel1);
            Controls.Add(LoanListPanel);
            Name = "Form2";
            Text = "Loan Report Generator - TechCos Inc";
            WindowState = FormWindowState.Maximized;
            Load += Form2_Load;
            LoanListPanel.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox branchComboBox;
        private Label label1;
        private Button PersonalBtn;
        private Button BusinessBtn;
        private Button GroupBtn;
        private Panel LoanListPanel;
        private Panel panel1;
        private DataGridView dataGridView;
    }
}