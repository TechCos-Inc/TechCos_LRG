using Microsoft.Office.Interop.Word;
using PdfSharp.Drawing;
using PdfSharp.Drawing.Layout;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace TechCos_LRG
{
    public partial class BusinessLoan : Form
    {
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr;
        Microsoft.Office.Interop.Word.Application app;
        Microsoft.Office.Interop.Word.Document doc;
        object objMiss = Missing.Value;
        object tmpfile = System.IO.Path.GetTempPath()+"hello.pdf";
        object FileLocation = @"C:\Users\Harish K\Documents\sample.docx";

        public BusinessLoan()
        {
            InitializeComponent();

            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
        }



        private void BusinessLoan_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Harish K\\source\\repos\\HarishK-CS\\TechCos_LRG\\Database.mdf\";Integrated Security=True");
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

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }


        private void generateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                app = new Microsoft.Office.Interop.Word.Application();
                doc = app.Documents.Open(ref FileLocation, ref objMiss, ref objMiss, ref objMiss, ref objMiss, ref objMiss, ref objMiss, ref objMiss, ref objMiss, ref objMiss, ref objMiss, ref objMiss, ref objMiss, ref objMiss, ref objMiss, ref objMiss);

                FindAndReplace("[name]", "HK");
                FindAndReplace("[addr]", "vsdvsdvsdv\nfcsadfas\n");

                doc.ExportAsFixedFormat(tmpfile.ToString(), Microsoft.Office.Interop.Word.WdExportFormat.wdExportFormatPDF);



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { 
                doc.Close(WdSaveOptions.wdDoNotSaveChanges,WdOriginalFormat.wdOriginalDocumentFormat,false); 
                app.Quit(WdSaveOptions.wdDoNotSaveChanges);
            }


        }

        private void FindAndReplace(object FindText,object ReplaceText)
        {
            this.app.Selection.Find.Execute(ref FindText,true,true,false,false,false,true,false,1,ref ReplaceText,2,false,false,false,false);
        }


        private void BLBackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }
    }
}
