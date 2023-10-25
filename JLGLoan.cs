using ComponentFactory.Krypton.Toolkit;
using MaterialSkin.Controls;
using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TechCos_LRG.JLG_usercontrol;

namespace TechCos_LRG
{
    public partial class JLGLoan : KryptonForm
    {
        public static JLGLoan instance;
        public Panel contPanel;
        public MaterialButton borBtn, memBtn, amtBtn, expBtn;
        JLGBorrower jlgBor;
        JLGMem1 jlgMem;
        JLGAmount jLGAmount;
        public Panel memBottomPanel;
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
        public JLGLoan()
        {
            InitializeComponent();
            instance = this;
            contPanel = containerPanel;
            borBtn = borrowerBtn;
            memBtn = memberDetailsBtn;
            amtBtn = amountDetailsBtn;
            expBtn = exportBtn;
            memBottomPanel = bottomMemPgPanel;
            jlgBor = new JLGBorrower();
            jlgMem = new JLGMem1();
            jLGAmount = new JLGAmount();
            AddContUserControl(jlgBor);
            memberDetailsBtn.Enabled = false;
            amountDetailsBtn.Enabled = false;
            exportBtn.Visible = false;

        }

        private void JLGLoan_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Harish K\\source\\repos\\HarishK-CS\\TechCos_LRG\\Database.mdf\";Integrated Security=True");
            cn.Open();
        }

        // Export
/*
        public void export()
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
*/
        private void FindAndReplace(object FindText, object ReplaceText)
        {
            this.app.Selection.Find.Execute(ref FindText, true, true, false, false, false, true, false, 1, ref ReplaceText, 2, false, false, false, false);
        }

        public void AddContUserControl(UserControl userControl)
        {
            containerPanel.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            containerPanel.Controls.Add(userControl);
            userControl.BringToFront();
        }

        public void AddBottoMemPgUserControl(UserControl userControl)
        {
            bottomMemPgPanel.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            bottomMemPgPanel.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void panelBottom_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BackBtn_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void CloseBtn_Click_1(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void borrowerBtn_Click(object sender, EventArgs e)
        {
            AddContUserControl(jlgBor);
            bottomMemPgPanel.Visible = false;
        }

        private void memberDetailsBtn_Click(object sender, EventArgs e)
        {

            AddContUserControl(jlgMem);
            bottomMemPgPanel.Visible = true;
        }

        private void amountDetailsBtn_Click(object sender, EventArgs e)
        {

            AddContUserControl(jLGAmount);
            bottomMemPgPanel.Visible = false;
        }

     
    }
}
