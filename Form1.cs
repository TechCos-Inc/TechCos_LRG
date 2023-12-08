using Microsoft.SqlServer.Management.Smo;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO.Compression;
using ComponentFactory.Krypton.Toolkit;
using MaterialSkin.Controls;
using System.Reflection.Metadata;
using Spire.Doc;
using Document = Spire.Doc.Document;

namespace TechCos_LRG
{
    public partial class Form1 : KryptonForm
    {
        public static Form1 instance;
        public MaterialTextBox username;
        public String role;
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr;
        Button AdminBtn, UserBtn;

        public Form1()
        {
            InitializeComponent();
            instance = this;
            role = "";
            username = UsernameTxt;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Harish K\\source\\repos\\HarishK-CS\\TechCos_LRG\\Database.mdf\";Integrated Security=True");
            cn.Open();
            string dir = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\TechCos LRG";
            System.IO.Directory.CreateDirectory(dir);

        }


        /*    private void UserSubmitBtn_Click(object sender, EventArgs e)
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
                    //MessageBox.Show("Succesfully Loged In !", "Loan Report Generator - TechCos Inc");
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
        */


        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        public void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }



        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            if (UsernameTxt.Text == "")
            {
                MessageBox.Show("Enter Valid Username !", "Loan Report Generator - TechCos Inc");
            }
            else if (PasswordTxt.Text == "")
            {
                MessageBox.Show("Enter Valid Password !", "Loan Report Generator - TechCos Inc");
            }
            cmd = new SqlCommand("select * from userslist where username='" + UsernameTxt.Text + "' and password='" + PasswordTxt.Text + "'", cn);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                role = dr.GetString(2);
                //MessageBox.Show("Succesfully Loged In !", "Loan Report Generator - TechCos Inc");
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

        private void procodeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Procode procode = new Procode();
            procode.ShowDialog();
        }


        private void materialButton1_Click(object sender, EventArgs e)
        {
            Document document = new Document();
            document.LoadFromFile(@"C:\Users\Harish K\Documents\A.docx", FileFormat.Docx);
            document.InsertTextFromFile(@"C:\Users\Harish K\Documents\B.docx", FileFormat.Docx);
            document.InsertTextFromFile(@"C:\Users\Harish K\Documents\C.docx", FileFormat.Docx);
            document.SaveToFile("MergeFile.docx", FileFormat.Docx);
        }
    }
}
