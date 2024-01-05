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
using TechCos_LRG.Utils;

namespace TechCos_LRG
{
    public partial class SuperUserForm : KryptonForm
    {
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr;
        public SuperUserForm()
        {
            InitializeComponent();
        }

        private void superusrBackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 form = new Form2();
            form.ShowDialog();
        }

        private void SuperUserForm_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(ConnectionString.ConnStr);
            cn.Open();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
            Application.Exit();
        }

        private void materialLabel2_Click(object sender, EventArgs e)
        {

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            string value = "";
            bool isChecked = adminRadioButton.Checked;
            if (isChecked)
                value = "Admin";
            else
                value = "Normal";
            cmd = new SqlCommand("select * from UsersList where username='" + addUserNameTxt.Text + "'", cn);
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
                cmd.Parameters.AddWithValue("username", addUserNameTxt.Text);
                cmd.Parameters.AddWithValue("password", addUserPassTxt.Text);
                cmd.Parameters.AddWithValue("role", value);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Your Account is created . Please login now.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
