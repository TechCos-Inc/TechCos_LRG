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
    public partial class Form2 : Form
    {
        public static Form2 instance;
        public ComboBox branchCB;
        SqlConnection cn ;
        SqlCommand cmd ;
        SqlDataReader dr ;

        public Form2()
        {
            InitializeComponent();
            instance = this;
            branchCB = branchComboBox;
            LoanListPanel.Hide();
            dataGridView.Hide();
            branchComboBox.Items.Add("Pondy");

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Harish K\\source\\repos\\TechCos_LRG\\Database.mdf\";Integrated Security=True");
            cn.Open();
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
            LoanListPanel.Show();
            dataGridView.Show();
            TableData();
        }
        public void TableData()
        {
            try
            {
                String sqlQuery = "Select * from BusinessLoan ";
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


    }
}
