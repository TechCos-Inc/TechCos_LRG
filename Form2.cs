using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechCos_LRG
{
    public partial class Form2 : KryptonForm
    {
        public static Form2 instance;
        public ComboBox branchCB;
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr, dra;
        object baseDir = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\TechCos LRG\\";
        public Form2()
        {
            InitializeComponent();
            instance = this;
            branchCB = branchComboBox;
            containerPanel.Hide();

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(ConnectionString.ConnStr);
            cn.Open();
            string Sql = "select BranchName from Branch";

            cmd = new SqlCommand(Sql, cn);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                branchComboBox.Items.Add(dr[0]);
            }

            dr.Close();

            if (Form1.instance.role.Equals("Normal"))
            {
                SuperUserBtn.Visible = false;
                procodeBtn.Visible = false;
            }

        }





        private void PersonalBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            PersonalLoan personalLoan = new PersonalLoan();
            personalLoan.ShowDialog();
        }

        private void BusinessBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            BusinessLoan businessLoan = new BusinessLoan();
            businessLoan.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            containerPanel.Show();
            TableData();
        }
        public void TableData()
        {
            try
            {
                String sqlQuery = "Select * from JLGBorrower where BranchName='" + branchCB.SelectedItem + "'";
                DataTable dt = new DataTable("Records");
                SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, cn);
                adapter.Fill(dt);
                dataGridView.DataSource = dt;


            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }





        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void SuperUserBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            SuperUserForm superUserForm = new SuperUserForm();
            superUserForm.ShowDialog();
        }

        private void branchComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            containerPanel.Show();
            TableData();

        }


        private void BranchBtn_Click_1(object sender, EventArgs e)
        {

            this.Hide();
            BranchForm branchForm = new BranchForm();
            branchForm.ShowDialog();
        }

        private void JlgBtn_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            JLGLoan jLGLoan = new JLGLoan();
            jLGLoan.ShowDialog();

        }

        private void PersonalBtn_Click_1(object sender, EventArgs e)
        {

        }

        private void BusinessBtn_Click_1(object sender, EventArgs e)
        {

        }

        private void GroupBtn_Click(object sender, EventArgs e)
        {

        }

        private void openDirBtn_Click(object sender, EventArgs e)
        {
            //string cmd = "explorer.exe";
            //string arg = "/select, " + baseDir.ToString() ;
            //Process.Start(cmd, arg);
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo()
            {
                FileName = baseDir.ToString(),
                UseShellExecute = true,
                Verb = "open"
            });
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        private void procodeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Procode procode = new Procode();
            procode.ShowDialog();
        }

        private void BdoBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            BDOForm bdo = new BDOForm();
            bdo.ShowDialog();
        }
    }
}
