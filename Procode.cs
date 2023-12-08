using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using Microsoft.UI.Xaml;
using System.Data.OleDb;
using System.IO;
using DataTable = System.Data.DataTable;
using System.Data.SqlClient;

namespace TechCos_LRG
{
    public partial class Procode : KryptonForm
    {
        SqlConnection cn;
        private string Excel03ConString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties='Excel 8.0;HDR={1}'";
        private string Excel07ConString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties='Excel 8.0;HDR={1}'";
        public Procode()
        {
            InitializeComponent();
        }
        private void Procode_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Harish K\\source\\repos\\HarishK-CS\\TechCos_LRG\\Database.mdf\";Integrated Security=True");
            cn.Open();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void importBtn_Click(object sender, EventArgs e)
        {


            openFD.Filter = "Excel Office | *.xls; *xlsx";
            openFD.ShowDialog();




        }

        private void openFD_FileOk(object sender, CancelEventArgs e)
        {
            string filePath = openFD.FileName;
            string extension = Path.GetExtension(filePath);
            string conString = "";
            string sheetName = "";
            switch (extension)
            {
                case ".xls":
                    conString = string.Format(Excel03ConString, filePath, "YES");
                    break;
                case ".xlsx":
                    conString = string.Format(Excel07ConString, filePath, "YES");
                    break;
            }
            using (OleDbConnection con = new OleDbConnection(conString))
            {
                using (OleDbCommand cmd = new OleDbCommand())
                {
                    cmd.Connection = con;
                    con.Open();
                    System.Data.DataTable dt = con.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                    sheetName = dt.Rows[0]["Table_Name"].ToString();
                    MessageBox.Show(sheetName);
                    con.Close();
                }
            }
            using (OleDbConnection con1 = new OleDbConnection(conString))
            {
                using (OleDbCommand cmd1 = new OleDbCommand())
                {
                    OleDbDataAdapter oda = new OleDbDataAdapter();
                    cmd1.CommandText = "SELECT * FROM [" + sheetName + "]";
                    cmd1.CommandType = CommandType.Text;
                    cmd1.Connection = con1;
                    con1.Open();
                    oda.SelectCommand = cmd1;
                    DataTable dt = new DataTable();
                    oda.Fill(dt);
                    con1.Close();
                    dataGridView1.DataSource = dt;
                }
            }

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[14] {
        new DataColumn("ACCT_TYPE", typeof(int)),
        new DataColumn("INT_CAT", typeof(int)),
        new DataColumn("ACCT_DESCRIPTION", typeof(string)),
        new DataColumn("COMP_FREQ", typeof(string)),
        new DataColumn("CAPN_FREQ", typeof(string)),
        new DataColumn("REPAY_FREQ", typeof(string)),
        new DataColumn("NEG_RATE_IND", typeof(int)),
        new DataColumn("MIN_TERM", typeof(int)),
        new DataColumn("MAX_TERM", typeof(int)),
        new DataColumn("MIN_LOAN", typeof(int)),
        new DataColumn("MAX_LOAN", typeof(int)),
        new DataColumn("ADDNL_LOAN", typeof(string)),
        new DataColumn("SUBSIDY_IND", typeof(string)),
        new DataColumn("REMARKS", typeof(string))
    });
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                int ACCT_TYPE = Convert.ToInt32(row.Cells[0].Value);
                int INT_CAT = Convert.ToInt32(row.Cells[1].Value);
                string ACCT_DESCRIPTION = (String)row.Cells[2].Value;
                string COMP_FREQ = (String)row.Cells[3].Value;
                string CAPN_FREQ = (String)row.Cells[4].Value;
                string REPAY_FREQ = (String)row.Cells[5].Value;
                int NEG_RATE_IND = Convert.ToInt32(row.Cells[6].Value);
                int MIN_TERM = Convert.ToInt32(row.Cells[7].Value);
                int MAX_TERM = Convert.ToInt32(row.Cells[8].Value);
                int MIN_LOAN = Convert.ToInt32(row.Cells[9].Value);
                int MAX_LOAN = (int)Convert.ToInt64(row.Cells[10].Value);
                 //   int.Parse(row.Cells[10].Value.ToString());
                string ADDNL_LOAN = (String)row.Cells[11].Value;
                string SUBSIDY_IND = (String)row.Cells[12].Value;
                string val13;
                if (row.Cells[13].Value == null)
                {
                    val13 = "";
                }
                else
                {
                    val13 = row.Cells[13].Value.ToString();
                }
                string REMARKS = val13;
                dt.Rows.Add(ACCT_TYPE, INT_CAT, ACCT_DESCRIPTION, COMP_FREQ, CAPN_FREQ, REPAY_FREQ, NEG_RATE_IND, MIN_TERM, MAX_TERM, MIN_LOAN, MAX_LOAN, ADDNL_LOAN, SUBSIDY_IND, REMARKS);
            }
            if (dt.Rows.Count > 0)
            {
                
                    using (SqlBulkCopy sqlBulkCopy = new SqlBulkCopy(cn))
                    {
                        sqlBulkCopy.DestinationTableName = "dbo.Procode";
                        sqlBulkCopy.ColumnMappings.Add("ACCT_TYPE", "ACCT_TYPE");
                        sqlBulkCopy.ColumnMappings.Add("INT_CAT", "INT_CAT");
                        sqlBulkCopy.ColumnMappings.Add("ACCT_DESCRIPTION", "ACCT_DESCRIPTION");
                        sqlBulkCopy.ColumnMappings.Add("COMP_FREQ", "COMP_FREQ");
                        sqlBulkCopy.ColumnMappings.Add("CAPN_FREQ", "CAPN_FREQ");
                        sqlBulkCopy.ColumnMappings.Add("REPAY_FREQ", "REPAY_FREQ");
                        sqlBulkCopy.ColumnMappings.Add("NEG_RATE_IND", "NEG_RATE_IND");
                        sqlBulkCopy.ColumnMappings.Add("MIN_TERM", "MIN_TERM");
                        sqlBulkCopy.ColumnMappings.Add("MAX_TERM", "MAX_TERM");
                        sqlBulkCopy.ColumnMappings.Add("MIN_LOAN", "MIN_LOAN");
                        sqlBulkCopy.ColumnMappings.Add("MAX_LOAN", "MAX_LOAN");
                        sqlBulkCopy.ColumnMappings.Add("ADDNL_LOAN", "ADDNL_LOAN");
                        sqlBulkCopy.ColumnMappings.Add("SUBSIDY_IND", "SUBSIDY_IND");
                        sqlBulkCopy.ColumnMappings.Add("REMARKS", "REMARKS");
                        
                        sqlBulkCopy.WriteToServer(dt);
                        cn.Close();
                    }
                
            }
        }

       
    }
}
