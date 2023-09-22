using Microsoft.SqlServer.Management.Smo;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;


namespace TechCos_LRG
{
    public partial class Form1 : Form
    {
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr;

        public Form1()
        {
            InitializeComponent();
            AdminLoginPanel.Hide();
            UserloginPanel.Hide();
            SuperUserPanel.Hide();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Harish K\\source\\repos\\HarishK-CS\\TechCos_LRG\\Database.mdf\";Integrated Security=True");
            cn.Open();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginInfoPanel.Hide();
            UserloginPanel.Hide();
            AdminLoginPanel.Show();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            LoginInfoPanel.Hide();
            AdminLoginPanel.Hide();
            UserloginPanel.Show();
        }

        private void backUserBtn_Click(object sender, EventArgs e)
        {

            UserloginPanel.Hide();
            AdminLoginPanel.Hide();
            LoginInfoPanel.Show();

        }

        private void backAdminBtn_Click(object sender, EventArgs e)
        {

            AdminLoginPanel.Hide();
            UserloginPanel.Hide();
            LoginInfoPanel.Show();

        }

        private void AdminSubmitBtn_Click(object sender, EventArgs e)
        {
            if (UsernameAdminLoginTxtField.Text == "")
            {
                MessageBox.Show("Enter Valid Username !", "Loan Report Generator - TechCos Inc");
            }
            else if (PasswordAdminLoginTxtField.Text == "")
            {
                MessageBox.Show("Enter Valid Password !", "Loan Report Generator - TechCos Inc");
            }


            cmd = new SqlCommand("select * from userslist where username='" + UsernameAdminLoginTxtField.Text + "' and password='" + PasswordAdminLoginTxtField.Text + "' and role='Admin'", cn);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Succesfully Loged In !", "Loan Report Generator - TechCos Inc");
                dr.Close();
                this.Hide();
                Form2 form = new Form2();
                form.ShowDialog();
            }
            else
            {
                dr.Close();
                MessageBox.Show("No Account avilable with this username and password ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



            //  this.Hide();


        }

        private void UserSubmitBtn_Click(object sender, EventArgs e)
        {
            if (UsernameUserLoginTxtField.Text == "")
            {
                MessageBox.Show("Enter Valid Username !", "Loan Report Generator - TechCos Inc");
            }
            else if (PasswordUserLoginTxtField.Text == "")
            {
                MessageBox.Show("Enter Valid Password !", "Loan Report Generator - TechCos Inc");
            }
            cmd = new SqlCommand("select * from userslist where username='" + UsernameUserLoginTxtField.Text + "' and password='" + PasswordUserLoginTxtField.Text + "' and role='Normal'", cn);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Succesfully Loged In !", "Loan Report Generator - TechCos Inc");
                dr.Close();
                this.Hide();
                Form2 form = new Form2();
                form.ShowDialog();
            }
            else
            {
                dr.Close();
                MessageBox.Show("No Account avilable with this username and password ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void SuperUserBtn_Click(object sender, EventArgs e)
        {
            roleCombo.Items.Add("Admin");
            roleCombo.Items.Add("Normal");
            LoginInfoPanel.Hide();
            SuperUserPanel.Show();
        }

        private void AddUserBtn_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select * from UsersList where username='" + addName.Text + "'", cn);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                dr.Close();
                MessageBox.Show("Username Already exist please try another ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                dr.Close();
                cmd = new SqlCommand("insert into UsersList values(@username,@password,@role)", cn);
                cmd.Parameters.AddWithValue("username", addName.Text);
                cmd.Parameters.AddWithValue("password", addPass.Text);
                cmd.Parameters.AddWithValue("role", roleCombo.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Your Account is created . Please login now.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void superusrBackBtn_Click(object sender, EventArgs e)
        {
            SuperUserPanel.Visible = false;
            AdminLoginPanel.Visible = false;
            UserloginPanel.Visible = false;
            LoginInfoPanel.Visible = true;
        }

        private void loginInfo1_Load(object sender, EventArgs e)
        {

        }

        private void BranchBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            BranchForm branchForm = new BranchForm();
            branchForm.ShowDialog();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}