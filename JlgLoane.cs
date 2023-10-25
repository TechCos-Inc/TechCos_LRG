using Microsoft.Office.Interop.Word;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechCos_LRG
{
    public partial class JlgLoane : Form
    {
        SqlConnection cn;
        SqlCommand cmd, cmd1;
        SqlDataReader dr;
        Microsoft.Office.Interop.Word.Application app;
        Microsoft.Office.Interop.Word.Document doc;
        object objMiss = Missing.Value;
        object baseDir = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\TechCos LRG\\";
        object tmpfile = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\TechCos LRG\\Hello.pdf";
        object FileLocation = @"C:\Users\Harish K\Documents\sample.docx";
        String Ifsc, brph, brmgr, brphno, braddr, pincode, bremail, brname;
        public JlgLoane()
        {
            InitializeComponent();

            OpenDirBtn.Hide();
            jlgamt.Hide();
            mem1.Hide();
            mem2.Hide();
            mem3.Hide();
            mem4.Hide();
            mem5.Hide();
            mem6.Hide();
            mem7.Hide();
            mem8.Hide();
            mem9.Hide();
            mem10.Hide();
            mem11.Hide();
            mem12.Hide();
            mem13.Hide();
            mem14.Hide();
            mem15.Hide();

            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

        }

        private void JlgLoane_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Harish K\\source\\repos\\HarishK-CS\\TechCos_LRG\\Database.mdf\";Integrated Security=True");
            cn.Open();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {
            JlgBrowor.BringToFront();
            JlgBrowor.Show();
            jlgamt.Hide();
            mem1.Hide();
            mem2.Hide();
            mem3.Hide();
            mem4.Hide();

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void SaveAndContinue1Btn_Click(object sender, EventArgs e)
        {
            /* if (BNameTxt.Text == "")
             {
                 MessageBox.Show("Enter Valid Username !", "Loan Report Generator - TechCos Inc");
             }
             else if (BAddressTxt.Text == "")
             {
                 MessageBox.Show("Enter Valid Password !", "Loan Report Generator - TechCos Inc");
             }
            */



        }

        private void ExportPdfBtn_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("insert into JLGLoan values(@presph,@jlgname,@adds1,@adds2,@adds3,@adds4,@pincode,@presname,@secrname,@secrph,@docdate,@appldate,@brname)", cn);
            cmd.Parameters.AddWithValue("presph", PRES_Ph.Text);
            cmd.Parameters.AddWithValue("jlgname", JLGName.Text);
            cmd.Parameters.AddWithValue("adds1", ADDs1.Text);
            cmd.Parameters.AddWithValue("adds2", ADDs2.Text);
            cmd.Parameters.AddWithValue("adds3", ADDs3.Text);
            cmd.Parameters.AddWithValue("adds4", ADDs4.Text);
            cmd.Parameters.AddWithValue("pincode", PinCode.Text);
            cmd.Parameters.AddWithValue("presname", PRES_Name.Text);
            cmd.Parameters.AddWithValue("secrname", SECR_Name.Text);
            cmd.Parameters.AddWithValue("secrph", SECR_Ph.Text);
            //  String docdate = Doc_date.Value.Date
            //   String appdate = App_date.Value.Date.ToString("dd/MM/yyyy");

            //   String appdate = App_date.Value.ToString("dd/MM/yyyy");
            cmd.Parameters.AddWithValue("docdate", Doc_date.Value.Date);
            cmd.Parameters.AddWithValue("appldate", App_date.Value.Date);
            cmd.Parameters.AddWithValue("brname", Form2.instance.branchCB.SelectedItem);






            cmd.ExecuteNonQuery();


            try
            {

                app = new Microsoft.Office.Interop.Word.Application();
                doc = app.Documents.Open(ref FileLocation, ref objMiss, ref objMiss, ref objMiss, ref objMiss, ref objMiss, ref objMiss, ref objMiss, ref objMiss, ref objMiss, ref objMiss, ref objMiss, ref objMiss, ref objMiss, ref objMiss, ref objMiss);

                try
                {
                    String query = "Select * from Branch where BranchName='" + Form2.instance.branchCB.SelectedItem + "'";
                    cmd1 = new SqlCommand(query, cn);
                    dr = cmd1.ExecuteReader();
                    while (dr.Read())
                    {
                        Ifsc = dr.GetString(0);
                        brname = dr.GetString(1);
                        brmgr = dr.GetString(2);
                        braddr = dr.GetString(3);
                        pincode = dr["PinCode"].ToString() ?? "";
                        string tempPh = dr["PhoneNo"].ToString() ?? "";
                        brphno = tempPh;


                        bremail = dr.GetString(7);

                    }
                }
                catch (SqlException se)
                {
                    MessageBox.Show(se.Message);
                }
                finally
                {

                    dr.Close();
                }

                FindAndReplace("[BrAddress]", braddr);
                FindAndReplace("[BrEmail]", bremail);
                FindAndReplace("[BrPh]", brphno);
                FindAndReplace("[BrName]", brname);
                FindAndReplace("[BrPinCode]", pincode);
                FindAndReplace("[JLG_Name]", JLGName.Text);
                FindAndReplace("[ADDs1]", ADDs1.Text);
                FindAndReplace("[ADDs2]", ADDs2.Text);
                FindAndReplace("[ADDs3]", ADDs3.Text);
                FindAndReplace("[ADDs4]", ADDs4.Text);
                FindAndReplace("[Pincode]", PinCode.Text);
                FindAndReplace("[SB_no]", "SBNO");
                FindAndReplace("[PRES_Name]", PRES_Name.Text);
                FindAndReplace("[SECR_Name]", SECR_Name.Text);
                FindAndReplace("[PRES_Ph]", PRES_Ph.Text);
                FindAndReplace("[SECR_Ph]", SECR_Ph.Text);


                doc.ExportAsFixedFormat(tmpfile.ToString(), Microsoft.Office.Interop.Word.WdExportFormat.wdExportFormatPDF);
                MessageBox.Show("PDF Succesfully Generated", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                OpenDirBtn.Show();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                doc.Close(WdSaveOptions.wdDoNotSaveChanges, WdOriginalFormat.wdOriginalDocumentFormat, false);
                app.Quit(WdSaveOptions.wdDoNotSaveChanges);
            }
        }

        private void FindAndReplace(object FindText, object ReplaceText)
        {
            this.app.Selection.Find.Execute(ref FindText, true, true, false, false, false, true, false, 1, ref ReplaceText, 2, false, false, false, false);
        }


        private void BLBackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.ShowDialog();
            cn.Close();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label37_Click(object sender, EventArgs e)
        {

        }

        private void label38_Click(object sender, EventArgs e)
        {

        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {

        }

        private void AmtBtn_Click(object sender, EventArgs e)
        {
            JlgBrowor.Hide();
            jlgamt.BringToFront();
            jlgamt.Show();
            mem1.Hide();
            mem2.Hide();
            mem3.Hide();
            mem4.Hide();

        }

        private void mem1Btn_Click(object sender, EventArgs e)
        {
            mem1.BringToFront();
            mem1.Show();
            JlgBrowor.Hide();
            jlgamt.Hide();
            mem2.Hide();
            mem3.Hide();
            mem4.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            JlgBrowor.Hide();
            jlgamt.Hide();
            mem1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {



        }

        private void jlgamt_Paint(object sender, PaintEventArgs e)
        {

        }

        private void JlgBrowor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void mem2btn_Click(object sender, EventArgs e)
        {
            mem2.Show();
            JlgBrowor.Hide();
            jlgamt.Hide();
            mem1.Hide();
            mem3.Hide();
            mem4.Hide();
        }

        private void mem3btn_Click(object sender, EventArgs e)
        {
            mem3.Show();
            JlgBrowor.Hide();
            jlgamt.Hide();
            mem1.Hide();
            mem2.Hide();
            mem4.Hide();
        }

        private void mem4btn_Click(object sender, EventArgs e)
        {
            mem4.Show();
            JlgBrowor.Hide();
            jlgamt.Hide();
            mem1.Hide();
            mem2.Hide();
            mem3.Hide();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void OpenDirBtn_Click(object sender, EventArgs e)
        {
            //string cmd = "explorer.exe";
            //string arg = "/select, " + baseDir.ToString() ;
            //Process.Start(cmd, arg);
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo()
            {
                FileName = baseDir.ToString(),
                UseShellExecute = true,
                Verb = "open"
            });
        }

        private void superusrBackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }
    }
}
