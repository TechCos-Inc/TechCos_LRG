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
    public partial class BusinessLoan : Form
    {
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr;
        public BusinessLoan()
        {
            InitializeComponent();
        }



        private void BusinessLoan_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Harish K\\source\\repos\\TechCos_LRG\\Database.mdf\";Integrated Security=True");
            cn.Open();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {

            if (BNameTxt.Text == "")
            {
                MessageBox.Show("Enter Valid Username !", "Loan Report Generator - TechCos Inc");
            }
            else if (BAddressTxt.Text == "")
            {
                MessageBox.Show("Enter Valid Password !", "Loan Report Generator - TechCos Inc");
            }
            cmd = new SqlCommand("insert into BusinessLoan values(@name,@address,@branch)", cn);
            cmd.Parameters.AddWithValue("name", BNameTxt.Text);
            cmd.Parameters.AddWithValue("address", BAddressTxt.Text);
            cmd.Parameters.AddWithValue("branch", Form2.instance.branchCB.SelectedItem);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Added Succesful.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
