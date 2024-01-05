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
    public partial class BranchForm : KryptonForm
    {
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr;

        public BranchForm()
        {
            InitializeComponent();
            ClassCombo.Items.Add("Rural");
            ClassCombo.Items.Add("Urban");
            ClassCombo.Items.Add("Semi Urban");
        }

        private void BranchForm_Load(object sender, EventArgs e)
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

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (IFSCtxt.Text == "" || BrNametxt.Text == "" || BrManagerNametxt.Text == "" || Addresstxt.Text == ""
                || PhNotxt.Text == "" || PinCodetxt.Text == "" || Emailtxt.Text == "" || ClassCombo.SelectedIndex == -1)
            {
                MessageBox.Show("Fill All the Fields !", "Loan Report Generator - TechCos Inc");
            }
            else
            {
                cmd = new SqlCommand("insert into Branch values(@ifsc,@brname,@brmanager,@address,@pincode,@class,@ph,@email)", cn);
                cmd.Parameters.AddWithValue("ifsc", IFSCtxt.Text);
                cmd.Parameters.AddWithValue("brname", BrNametxt.Text);
                cmd.Parameters.AddWithValue("brmanager", BrManagerNametxt.Text);
                cmd.Parameters.AddWithValue("address", Addresstxt.Text);
                cmd.Parameters.AddWithValue("pincode", PinCodetxt.Text);
                cmd.Parameters.AddWithValue("class", ClassCombo.SelectedItem);
                cmd.Parameters.AddWithValue("ph", PhNotxt.Text);
                cmd.Parameters.AddWithValue("email", Emailtxt.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("YBranch was Added Successfully.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            IFSCtxt.Text = null;
            BrNametxt.Text = null;
            BrManagerNametxt.Text = null;
            Addresstxt.Text = null;
            PinCodetxt.Text = null;
            ClassCombo.SelectedIndex = -1;
            PhNotxt.Text = null;
            Emailtxt.Text = null;
        }
        public void TableData()
        {
            try
            {
                String sqlQuery = "Select * from Branch ";
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

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView.Rows[e.RowIndex];
            String ifsc = row.Cells["IFSC"].Value.ToString() ?? "";
            try
            {
                String query = "Select * from Branch where IFSC='" + ifsc.Trim() + "'";
                int TempIndex;
                cmd = new SqlCommand(query, cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    IFSCtxt.Text = dr.GetString(0);
                    BrNametxt.Text = dr.GetString(1);
                    BrManagerNametxt.Text = dr.GetString(2);
                    Addresstxt.Text = dr.GetString(3);
                    PinCodetxt.Text = dr["PinCode"].ToString() ?? "";
                    if (dr.GetString(5).Trim().Equals("Rural"))
                    {
                        TempIndex = 0;
                    }
                    else if (dr.GetString(5).Trim().Equals("Urban"))
                    {
                        TempIndex = 1;
                    }
                    else
                    {
                        TempIndex = 2;
                    }


                    ClassCombo.SelectedIndex = TempIndex;
                    string tempPh = dr["PhoneNo"].ToString() ?? "";
                    PhNotxt.Text = tempPh;
                    Emailtxt.Text = dr.GetString(7);

                }
            }
            catch (SqlException se)
            {
                MessageBox.Show(se.Message);
            }
            finally { dr.Close(); }

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

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (IFSCtxt.Text == "" || BrNametxt.Text == "" || BrManagerNametxt.Text == "" || Addresstxt.Text == ""
                || PhNotxt.Text == "" || PinCodetxt.Text == "" || Emailtxt.Text == "" || ClassCombo.SelectedIndex == -1)
            {
                MessageBox.Show("Fill All the Fields !", "Loan Report Generator - TechCos Inc");
            }
            else
            {
                cmd = cn.CreateCommand();
                cmd.CommandText = "update  Branch set BranchName=@brname,BranchManagerName=@brmanager,Address=@address,PinCode=@pincode,Classification=@class,PhoneNo=@ph,Email=@email where  IFSC=@ifsc";
                cmd.Parameters.AddWithValue("ifsc", IFSCtxt.Text);
                cmd.Parameters.AddWithValue("brname", BrNametxt.Text);
                cmd.Parameters.AddWithValue("brmanager", BrManagerNametxt.Text);
                cmd.Parameters.AddWithValue("address", Addresstxt.Text);
                cmd.Parameters.AddWithValue("pincode", PinCodetxt.Text);
                cmd.Parameters.AddWithValue("class", ClassCombo.SelectedItem);
                cmd.Parameters.AddWithValue("ph", PhNotxt.Text);
                cmd.Parameters.AddWithValue("email", Emailtxt.Text);
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Branch has been Updated Successfully.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            TableData();

        }

        private void AddBtn_Click_1(object sender, EventArgs e)
        {

        }
    }
}
