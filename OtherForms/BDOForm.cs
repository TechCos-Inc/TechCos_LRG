using ComponentFactory.Krypton.Toolkit;
using Microsoft.SqlServer.Management.Sdk.Sfc;
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
    public partial class BDOForm : KryptonForm
    {
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr;

        public BDOForm()
        {
            InitializeComponent();

        }

        private void BDOForm_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(ConnectionString.ConnStr);
            cn.Open();

            if (Form1.instance.role.Equals("Normal"))
            {
                AddBtn.Visible = false;
                updateBtn.Visible = false;
            }

            TableData();

        }

     
        public void TableData()
        {
            try
            {
                String sqlQuery = "Select * from Bdo ";
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


        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void BranchBackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.ShowDialog();

        }

        private void AddBtn_Click_1(object sender, EventArgs e)
        {
            /* if (codeTxt.Text == "" || BdoNameTxt.Text == "" || nameTxt.Text == "" || adds1Txt.Text == ""
                || adds2Txt.Text == "" || adds3Txt.Text == ""
                || adds4Txt.Text == "" || stateTxt.Text == "" || pincodeTxt.Text == "")
             {
                 MessageBox.Show("Fill All the Fields !", "Loan Report Generator - TechCos Inc");
             }
             else
             {*/
            cmd = new SqlCommand("insert into Bdo values(@name,@adds1,@adds2,@adds3,@adds4,@state,@pincode,@code,@names,@phno)", cn);
            cmd.Parameters.AddWithValue("code", codeTxt.Text);
            cmd.Parameters.AddWithValue("name", BdoNameTxt.Text);
            cmd.Parameters.AddWithValue("names", nameTxt.Text);
            cmd.Parameters.AddWithValue("adds1", adds1Txt.Text);
            cmd.Parameters.AddWithValue("adds2", adds2Txt.Text);
            cmd.Parameters.AddWithValue("adds3", adds3Txt.Text);
            cmd.Parameters.AddWithValue("adds4", adds4Txt.Text);
            cmd.Parameters.AddWithValue("state", stateTxt.Text);
            cmd.Parameters.AddWithValue("phno", phnoTxt.Text);
            cmd.Parameters.AddWithValue("pincode", pincodeTxt.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("BDO was Added Successfully.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
/*        }*/
        }

        private void updateBtn_Click_1(object sender, EventArgs e)
        {
           /* if (codeTxt.Text == "" || BdoNameTxt.Text == "" || nameTxt.Text == "" || adds1Txt.Text == ""
               || adds2Txt.Text == "" || adds3Txt.Text == ""
               || adds4Txt.Text == "" || stateTxt.Text == "" || pincodeTxt.Text == "")
            {
                MessageBox.Show("Fill All the Fields !", "Loan Report Generator - TechCos Inc");
            }
            else
            {*/
                cmd = cn.CreateCommand();
                cmd.CommandText = "update  Bdo set name=@name,adds1=@adds1,adds2=@adds2,adds3=@adds3,adds4=@adds4,state=@state,pincode=@pincode,code=@code,name=@name,phno=@phno where code=@code";
                cmd.Parameters.AddWithValue("code", codeTxt.Text);
                cmd.Parameters.AddWithValue("name", BdoNameTxt.Text);
                cmd.Parameters.AddWithValue("names", nameTxt.Text);
                cmd.Parameters.AddWithValue("adds1", adds1Txt.Text);
                cmd.Parameters.AddWithValue("adds2", adds2Txt.Text);
                cmd.Parameters.AddWithValue("adds3", adds3Txt.Text);
                cmd.Parameters.AddWithValue("adds4", adds4Txt.Text);
                cmd.Parameters.AddWithValue("state", stateTxt.Text);
                cmd.Parameters.AddWithValue("phno", phnoTxt.Text);
                cmd.Parameters.AddWithValue("pincode", pincodeTxt.Text);
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                MessageBox.Show("BDO has been Updated Successfully.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
          /*  }*/
            TableData();
        }

        private void ClearBtn_Click_1(object sender, EventArgs e)
        {
            BdoNameTxt.Text = null;
            nameTxt.Text = null;
            adds1Txt.Text = null;
            adds2Txt.Text = null;
            adds3Txt.Text = null;
            adds4Txt.Text = null;
            stateTxt.Text = null;
            phnoTxt.Text = null;
            pincodeTxt.Text = null;
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView.Rows[e.RowIndex];
            String id = row.Cells["Id"].Value.ToString() ?? "";
            try
            {
                String query = "Select * from Branch where Id='" + id.Trim() + "'";
                cmd = new SqlCommand(query, cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    nameTxt.Text = dr.GetString(1);
                    adds1Txt.Text = dr.GetString(2);
                    adds2Txt.Text = dr.GetString(3);
                    adds3Txt.Text = dr.GetString(4);
                    adds4Txt.Text = dr.GetString(5);
                    stateTxt.Text = dr.GetString(6);
                    pincodeTxt.Text = dr.GetString(7);
                    codeTxt.Text = dr.GetString(8);
                    BdoNameTxt.Text = dr.GetString(9);
                    phnoTxt.Text = dr.GetString(10);

                }
            }
            catch (SqlException se)
            {
                MessageBox.Show(se.Message);
            }
            finally { dr.Close(); }
        }
    }
}
