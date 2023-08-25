using Microsoft.SqlServer.Management.Smo;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;


namespace TechCos_LRG
{
    public partial class Form1 : Form
    {
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader rdr;

        public Form1()
        {
            InitializeComponent();
            AdminLoginPanel.Visible = false;
            UserloginPanel.Visible = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Harish K\\Documents\\sample.mdf\";Integrated Security=True;Connect Timeout=30");
            cn.Open();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginInfoPanel.Visible = false;
            UserloginPanel.Visible = false;
            AdminLoginPanel.Visible = true;
        }



        private void button2_Click(object sender, EventArgs e)
        {
            LoginInfoPanel.Visible = false;
            AdminLoginPanel.Visible = false;
            UserloginPanel.Visible = true;
        }

        private void backUserBtn_Click(object sender, EventArgs e)
        {

            UserloginPanel.Visible = false;
            AdminLoginPanel.Visible = false;
            LoginInfoPanel.Visible = true;

        }

        private void backAdminBtn_Click(object sender, EventArgs e)
        {

            AdminLoginPanel.Visible = false;
            UserloginPanel.Visible = false;
            LoginInfoPanel.Visible = true;

        }

        private void AdminSubmitBtn_Click(object sender, EventArgs e)
        {
            if (UsernameAdminLoginTxtField.Text == "")
            {
                MessageBox.Show("Enter Valid Username !", "Loan Report Generator - TechCos Inc");
            }else if (PasswordAdminLoginTxtField.Text == "")
            {
                MessageBox.Show("Enter Valid Password !", "Loan Report Generator - TechCos Inc");
            }
            if(UsernameAdminLoginTxtField.Text=="admin" && PasswordAdminLoginTxtField.Text == "admin1234")
            {
                MessageBox.Show("Succesfully Loged In !", "Loan Report Generator - TechCos Inc");
                this.Hide();
                Form form = new Form2();
                form.ShowDialog();  
                
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

        }


    }
}