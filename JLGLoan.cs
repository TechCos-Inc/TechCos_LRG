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
using Spire.Doc;


namespace TechCos_LRG
{
    public partial class JLGLoan : KryptonForm
    {
        public static JLGLoan instance;
        public Panel contPanel;
        public MaterialButton borBtn, memBtn, amtBtn, expBtn;
        JLGBorrower jlgBor;
        public JLGmem1 jlgMem1;
        public memberpageNum membpageNum;
        public JLGAmount jLGAmount;
        public Panel memBottomPanel;
        SqlConnection cn;
        SqlCommand cmd, cmd1,cmd2, cmd3, cmd4, cmd5, cmd6, cmd7, cmd8, cmd9, cmd10, cmd11, cmd15, cmd12, cmd13, cmd14, cmd16,cmd17;
        SqlDataReader dr;
        Microsoft.Office.Interop.Word.Application app;
        Microsoft.Office.Interop.Word.Document doc;
        object objMiss = Missing.Value;
        object baseDir = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\TechCos LRG\\";
        object tmpfile;
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
            jlgMem1 = new JLGmem1();
            membpageNum = new memberpageNum();
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

        public void export()
        {
            // getting Members Count
            int count;
            if (JLGBorrower.Instance.memcountCmb.SelectedItem == null)
            {
                count = 15;
            }
            else
            {
                count = int.Parse(JLGBorrower.Instance.memcountCmb.SelectedItem.ToString());
            }



            // Borrower SQL Insert Operation

            cmd = new SqlCommand("insert into JLGBorrower values(@presph,@jlgname,@adds1,@adds2,@adds3,@adds4,@pincode,@presname,@secrname,@secrph,@docdate,@appldate,@brname,@sb_no,@memcount)", cn);
            cmd.Parameters.AddWithValue("presph", JLGBorrower.Instance.presno.Text);
            cmd.Parameters.AddWithValue("jlgname", JLGBorrower.Instance.jlgname.Text.ToUpper());
            cmd.Parameters.AddWithValue("adds1", JLGBorrower.Instance.adds1.Text.ToUpper());
            cmd.Parameters.AddWithValue("adds2", JLGBorrower.Instance.adds2.Text.ToUpper());
            cmd.Parameters.AddWithValue("adds3", JLGBorrower.Instance.adds3.Text.ToUpper());
            cmd.Parameters.AddWithValue("adds4", JLGBorrower.Instance.adds4.Text.ToUpper());
            cmd.Parameters.AddWithValue("pincode", JLGBorrower.Instance.pincode.Text);
            cmd.Parameters.AddWithValue("presname", JLGBorrower.Instance.presname.Text.ToUpper());
            cmd.Parameters.AddWithValue("secrname", JLGBorrower.Instance.secrname.Text.ToUpper());
            cmd.Parameters.AddWithValue("secrph", JLGBorrower.Instance.secrno.Text);
            cmd.Parameters.AddWithValue("memcount", count);
            //  String docdate = Doc_date.Value.Date
            //   String appdate = App_date.Value.Date.ToString("dd/MM/yyyy");

            //   String appdate = App_date.Value.ToString("dd/MM/yyyy");
            cmd.Parameters.AddWithValue("docdate", JLGBorrower.Instance.doc_date.Value.Date);
            cmd.Parameters.AddWithValue("appldate", JLGBorrower.Instance.app_date.Value.Date);
            cmd.Parameters.AddWithValue("sb_no", JLGBorrower.Instance.sbno.Text);
            cmd.Parameters.AddWithValue("brname", Form2.instance.branchCB.SelectedItem);


            cmd.ExecuteNonQuery();



            // Member SQL Insertion
            switch (count)
            {
                case 1:
                    Mem1Operation();
                    break;
                case 2:
                    Mem1Operation();
                    Mem2Operation();
                    break;
                case 3:
                    Mem1Operation();
                    Mem2Operation();
                    Mem3Operation();
                    break;
                case 4:
                    Mem1Operation();
                    Mem2Operation();
                    Mem3Operation();
                    Mem4Operation();
                    break;
                case 5:
                    Mem1Operation();
                    Mem2Operation();
                    Mem3Operation();
                    Mem4Operation();
                    Mem5Operation();
                    break;
                case 6:
                    Mem1Operation();
                    Mem2Operation();
                    Mem3Operation();
                    Mem4Operation();
                    Mem5Operation();
                    Mem6Operation();
                    break;
                case 7:
                    Mem1Operation();
                    Mem2Operation();
                    Mem3Operation();
                    Mem4Operation();
                    Mem5Operation();
                    Mem6Operation();
                    Mem7Operation();
                    break;
                case 8:
                    Mem1Operation();
                    Mem2Operation();
                    Mem3Operation();
                    Mem4Operation();
                    Mem5Operation();
                    Mem6Operation();
                    Mem7Operation();
                    Mem8Operation();
                    break;
                case 9:
                    Mem1Operation();
                    Mem2Operation();
                    Mem3Operation();
                    Mem4Operation();
                    Mem5Operation();
                    Mem6Operation();
                    Mem7Operation();
                    Mem8Operation();
                    Mem9Operation();
                    break;
                case 10:
                    Mem1Operation();
                    Mem2Operation();
                    Mem3Operation();
                    Mem4Operation();
                    Mem5Operation();
                    Mem6Operation();
                    Mem7Operation();
                    Mem8Operation();
                    Mem9Operation();
                    Mem10Operation();
                    break;
                
            }
         

            // Amount SQL

            cmd17 = new SqlCommand("insert into JLGAmountDetail values(@presph,@dateform,@typeofcredit,@procode1,@procode2,@amount,@interest,@mclr,@spread,@emiamount,@noofmonth)",cn);
            cmd17.Parameters.AddWithValue("presph", JLGBorrower.Instance.presno.Text);
            cmd17.Parameters.AddWithValue("dateform",JLGAmount.instance.dateofFormation.Value.Date);
            cmd17.Parameters.AddWithValue("typeofcredit", JLGAmount.instance.typeOfCredit.Text);
            cmd17.Parameters.AddWithValue("procode1", JLGAmount.instance.procode1.Text);
            cmd17.Parameters.AddWithValue("procode2", JLGAmount.instance.procode2.Text);
            cmd17.Parameters.AddWithValue("amount", JLGAmount.instance.amount.Text);
            cmd17.Parameters.AddWithValue("interest", JLGAmount.instance.interest.Text);
            cmd17.Parameters.AddWithValue("mclr", JLGAmount.instance.mclr.Text);
            cmd17.Parameters.AddWithValue("spread", JLGAmount.instance.spread.Text);
            cmd17.Parameters.AddWithValue("emiamount", JLGAmount.instance.emiAmount.Text);
            cmd17.Parameters.AddWithValue("noofmonth", JLGAmount.instance.noOfMonths.Text);
            cmd17.ExecuteNonQuery();


            /*        cmd = new SqlCommand("insert into JLGMemberDetail values(@presph,@mname,@msbno,@mfathername,@mmarital," +
                        "@mrealtionship,@mcomm,@mwork,@mdob,@mage,@mgender,@maadhar,@mphno,@madds1,@madds2,@madds3,@madds4,@mpincode)",cn);
                    cmd.Parameters.AddWithValue("presph", JLGBorrower.Instance.presno.Text);
                    cmd.Parameters.AddWithValue("mname", JLGmem1.instance.memname1.Text);
                    cmd.Parameters.AddWithValue("msbno", JLGmem1.instance.memsb1.Text);
                    cmd.Parameters.AddWithValue("mfathername", JLGmem1.instance.memfather1.Text);
                    cmd.Parameters.AddWithValue("mmarital", JLGmem1.instance.memmarital1.Text);
                    cmd.Parameters.AddWithValue("mrealtionship", JLGmem1.instance.memrelation1.Text);
                    cmd.Parameters.AddWithValue("mcomm", JLGmem1.instance.memcomm1.Text);
                    cmd.Parameters.AddWithValue("mwork", JLGmem1.instance.memwork1.Text);
                    cmd.Parameters.AddWithValue("mdob", JLGmem1.instance.memdob1dt.Value.Date);
                    cmd.Parameters.AddWithValue("mage", JLGmem1.instance.memage1.Text);
                    cmd.Parameters.AddWithValue("mgender", JLGmem1.instance.memgender1.Text);
                    cmd.Parameters.AddWithValue("maadhar", JLGmem1.instance.memaadhar1.Text);
                    cmd.Parameters.AddWithValue("mphno", JLGmem1.instance.memph1.Text);
                    cmd.Parameters.AddWithValue("madds1", JLGmem1.instance.memadds11.Text);
                    cmd.Parameters.AddWithValue("madds2", JLGmem1.instance.memadds21.Text);
                    cmd.Parameters.AddWithValue("madds3", JLGmem1.instance.memadds31.Text);
                    cmd.Parameters.AddWithValue("madds4", JLGmem1.instance.memadds41.Text);
                    cmd.Parameters.AddWithValue("mpincode", JLGmem1.instance.mempincode1.Text);
            */

            // Getting Bank Branch Details
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


            // Word Processing
            try
            {

                app = new Microsoft.Office.Interop.Word.Application();
                doc = app.Documents.Open(ref FileLocation, ref objMiss, ref objMiss, ref objMiss, ref objMiss, ref objMiss, ref objMiss, ref objMiss, ref objMiss, ref objMiss, ref objMiss, ref objMiss, ref objMiss, ref objMiss, ref objMiss, ref objMiss);

               



                tmpfile = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\TechCos LRG\\" + JLGBorrower.Instance.jlgname.Text + "_" + DateTime.Now.ToString("dd-MM-yyyy-hh-mm-ss") + ".pdf";

                // Borrower Data Binding Operation 
                FindAndReplace("[BrAddress]", braddr);
                FindAndReplace("[BrEmail]", bremail);
                FindAndReplace("[BrPh]", brphno);
                FindAndReplace("[Br_Mgr_Name]", brmgr);
                FindAndReplace("[BrName]", brname);
                FindAndReplace("[BrPinCode]", pincode);
                FindAndReplace("[JLG_Name]", JLGBorrower.Instance.jlgname.Text.ToUpper());
                FindAndReplace("[ADDs1]", JLGBorrower.Instance.adds1.Text.ToUpper());
                FindAndReplace("[ADDs2]", JLGBorrower.Instance.adds2.Text.ToUpper());
                FindAndReplace("[ADDs3]", JLGBorrower.Instance.adds3.Text.ToUpper());
                FindAndReplace("[ADDs4]", JLGBorrower.Instance.adds4.Text.ToUpper());
                FindAndReplace("[Pincode]", JLGBorrower.Instance.pincode.Text);
                FindAndReplace("[SB_no]", JLGBorrower.Instance.sbno.Text);
                FindAndReplace("[PRES_Name]", JLGBorrower.Instance.presname.Text.ToUpper());
                FindAndReplace("[SECR_Name]", JLGBorrower.Instance.secrname.Text.ToUpper());
                FindAndReplace("[PRES_Ph]", JLGBorrower.Instance.presno.Text);
                FindAndReplace("[SECR_Ph]", JLGBorrower.Instance.secrno.Text);
                FindAndReplace("[MEM_COUNT]", JLGBorrower.Instance.memcountCmb.SelectedItem);
                // Mem 1
                FindAndReplace("[PRES_Name]", JLGmem1.instance.memname1.Text);
                FindAndReplace("[PRES_Ph]", JLGmem1.instance.memph1.Text);
                FindAndReplace("[PRES_HusName]", JLGmem1.instance.memfather1.Text);
                FindAndReplace("[PRES_Occ]", JLGmem1.instance.memwork1.Text);
                FindAndReplace("[PRES_AddS1]", JLGmem1.instance.memadds11.Text);
                FindAndReplace("[PRES_AddS2]", JLGmem1.instance.memadds21.Text);
                FindAndReplace("[PRES_AddS3]", JLGmem1.instance.memadds31.Text);
                FindAndReplace("[PRES_AddS4]", JLGmem1.instance.memadds41.Text);
                FindAndReplace("[PRES_Gen]", JLGmem1.instance.memgender1.SelectedItem);
                FindAndReplace("[PRES_Age]", JLGmem1.instance.memage1.Text);
                // Mem 2
                FindAndReplace("[SECR_Name]", JLGmem2.instance.memname1.Text);
                FindAndReplace("[SECR_Ph]", JLGmem2.instance.memph1.Text);
                FindAndReplace("[SECR_HusName]", JLGmem2.instance.memfather1.Text);
                FindAndReplace("[SECR_Occ]", JLGmem2.instance.memwork1.Text);
                FindAndReplace("[SECR_AddS1]", JLGmem2.instance.memadds11.Text);
                FindAndReplace("[SECR_AddS2]", JLGmem2.instance.memadds21.Text);
                FindAndReplace("[SECR_AddS3]", JLGmem2.instance.memadds31.Text);
                FindAndReplace("[SECR_AddS4]", JLGmem2.instance.memadds41.Text);
                FindAndReplace("[SECR_Gen]", JLGmem2.instance.memgender1.SelectedItem);
                FindAndReplace("[SECR_Age]", JLGmem2.instance.memage1.Text);
                // Mem 3
                FindAndReplace("[MEM3_Name]", JLGmem3.instance.memname1.Text);
                FindAndReplace("[MEM3_HusName]", JLGmem3.instance.memfather1.Text);
                FindAndReplace("[MEM3_Occ]", JLGmem3.instance.memwork1.Text);
                FindAndReplace("[MEM3_AddS1]", JLGmem3.instance.memadds11.Text);
                FindAndReplace("[MEM3_AddS2]", JLGmem3.instance.memadds21.Text);
                FindAndReplace("[MEM3_AddS3]", JLGmem3.instance.memadds31.Text);
                FindAndReplace("[MEM3_AddS4]", JLGmem3.instance.memadds41.Text);
                FindAndReplace("[MEM3_Gen]", JLGmem3.instance.memgender1.SelectedItem);
                FindAndReplace("[MEM3_Age]", JLGmem3.instance.memage1.Text);
                // Mem 4
                FindAndReplace("[MEM4_Name]", JLGmem4.instance.memname1.Text);
                FindAndReplace("[MEM4_HusName]", JLGmem4.instance.memfather1.Text);
                FindAndReplace("[MEM4_Occ]", JLGmem4.instance.memwork1.Text);
                FindAndReplace("[MEM4_AddS1]", JLGmem4.instance.memadds11.Text);
                FindAndReplace("[MEM4_AddS2]", JLGmem4.instance.memadds21.Text);
                FindAndReplace("[MEM4_AddS3]", JLGmem4.instance.memadds31.Text);
                FindAndReplace("[MEM4_AddS4]", JLGmem4.instance.memadds41.Text);
                FindAndReplace("[MEM4_Gen]", JLGmem4.instance.memgender1.SelectedItem);
                FindAndReplace("[MEM4_Age]", JLGmem4.instance.memage1.Text);
                // Mem 5
                FindAndReplace("[MEM5_Name]", JLGmem5.instance.memname1.Text);
                FindAndReplace("[MEM5_HusName]", JLGmem5.instance.memfather1.Text);
                FindAndReplace("[MEM5_Occ]", JLGmem5.instance.memwork1.Text);
                FindAndReplace("[MEM5_AddS1]", JLGmem5.instance.memadds11.Text);
                FindAndReplace("[MEM5_AddS2]", JLGmem5.instance.memadds21.Text);
                FindAndReplace("[MEM5_AddS3]", JLGmem5.instance.memadds31.Text);
                FindAndReplace("[MEM5_AddS4]", JLGmem5.instance.memadds41.Text);
                FindAndReplace("[MEM5_Gen]", JLGmem5.instance.memgender1.SelectedItem);
                FindAndReplace("[MEM5_Age]", JLGmem5.instance.memage1.Text);
                // Mem 6
                FindAndReplace("[MEM6_Name]", JLGmem6.instance.memname1.Text);
                FindAndReplace("[MEM6_HusName]", JLGmem6.instance.memfather1.Text);
                FindAndReplace("[MEM6_Occ]", JLGmem6.instance.memwork1.Text);
                FindAndReplace("[MEM6_AddS1]", JLGmem6.instance.memadds11.Text);
                FindAndReplace("[MEM6_AddS2]", JLGmem6.instance.memadds21.Text);
                FindAndReplace("[MEM6_AddS3]", JLGmem6.instance.memadds31.Text);
                FindAndReplace("[MEM6_AddS4]", JLGmem6.instance.memadds41.Text);
                FindAndReplace("[MEM6_Gen]", JLGmem6.instance.memgender1.SelectedItem);
                FindAndReplace("[MEM6_Age]", JLGmem6.instance.memage1.Text);
                // Mem 7
                FindAndReplace("[MEM7_Name]", JLGmem7.instance.memname1.Text);
                FindAndReplace("[MEM7_HusName]", JLGmem7.instance.memfather1.Text);
                FindAndReplace("[MEM7_Occ]", JLGmem7.instance.memwork1.Text);
                FindAndReplace("[MEM7_AddS1]", JLGmem7.instance.memadds11.Text);
                FindAndReplace("[MEM7_AddS2]", JLGmem7.instance.memadds21.Text);
                FindAndReplace("[MEM7_AddS3]", JLGmem7.instance.memadds31.Text);
                FindAndReplace("[MEM7_AddS4]", JLGmem7.instance.memadds41.Text);
                FindAndReplace("[MEM7_Gen]", JLGmem7.instance.memgender1.SelectedItem);
                FindAndReplace("[MEM7_Age]", JLGmem7.instance.memage1.Text);
                // Mem 8
                FindAndReplace("[MEM8_Name]", JLGmem8.instance.memname1.Text);
                FindAndReplace("[MEM8_HusName]", JLGmem8.instance.memfather1.Text);
                FindAndReplace("[MEM8_Occ]", JLGmem8.instance.memwork1.Text);
                FindAndReplace("[MEM8_AddS1]", JLGmem8.instance.memadds11.Text);
                FindAndReplace("[MEM8_AddS2]", JLGmem8.instance.memadds21.Text);
                FindAndReplace("[MEM8_AddS3]", JLGmem8.instance.memadds31.Text);
                FindAndReplace("[MEM8_AddS4]", JLGmem8.instance.memadds41.Text);
                FindAndReplace("[MEM8_Gen]", JLGmem8.instance.memgender1.SelectedItem);
                FindAndReplace("[MEM8_Age]", JLGmem8.instance.memage1.Text);
                // Mem 9
                FindAndReplace("[MEM9_Name]", JLGmem9.instance.memname1.Text);
                FindAndReplace("[MEM9_HusName]", JLGmem9.instance.memfather1.Text);
                FindAndReplace("[MEM9_Occ]", JLGmem9.instance.memwork1.Text);
                FindAndReplace("[MEM9_AddS1]", JLGmem9.instance.memadds11.Text);
                FindAndReplace("[MEM9_AddS2]", JLGmem9.instance.memadds21.Text);
                FindAndReplace("[MEM9_AddS3]", JLGmem9.instance.memadds31.Text);
                FindAndReplace("[MEM9_AddS4]", JLGmem9.instance.memadds41.Text);
                FindAndReplace("[MEM9_Gen]", JLGmem9.instance.memgender1.SelectedItem);
                FindAndReplace("[MEM9_Age]", JLGmem9.instance.memage1.Text);
                // Mem 10
                FindAndReplace("[MEM10_Name]", JLGmem10.instance.memname1.Text);
                FindAndReplace("[MEM10_HusName]", JLGmem10.instance.memfather1.Text);
                FindAndReplace("[MEM10_Occ]", JLGmem10.instance.memwork1.Text);
                FindAndReplace("[MEM10_AddS1]", JLGmem10.instance.memadds11.Text);
                FindAndReplace("[MEM10_AddS2]", JLGmem10.instance.memadds21.Text);
                FindAndReplace("[MEM10_AddS3]", JLGmem10.instance.memadds31.Text);
                FindAndReplace("[MEM10_AddS4]", JLGmem10.instance.memadds41.Text);
                FindAndReplace("[MEM10_Gen]", JLGmem10.instance.memgender1.SelectedItem);
                FindAndReplace("[MEM10_Age]", JLGmem10.instance.memage1.Text);
                // Amount
                // FindAndReplace("[MEM10_AddS4]", JLGAmount.instance.dateofFormation.Value.Date);
                FindAndReplace("[Credit_Type]", JLGAmount.instance.typeOfCredit.Text);
                //FindAndReplace("[MEM10_AddS4]", JLGAmount.instance.procode1.Text);
                //FindAndReplace("[MEM10_AddS4]", JLGAmount.instance.procode2.Text);
                FindAndReplace("[LOAN_Amt]", JLGAmount.instance.amount.Text);
                FindAndReplace("[INTEREST]", JLGAmount.instance.interest.Text);
                FindAndReplace("[SPREAD]", JLGAmount.instance.spread.Text);
                FindAndReplace("[MCLR]", JLGAmount.instance.mclr.Text);
                FindAndReplace("[EMI]", JLGAmount.instance.emiAmount.Text);
                FindAndReplace("[TOT_MTS]", JLGAmount.instance.noOfMonths.Text);

                // Exporting Word

                doc.ExportAsFixedFormat(tmpfile.ToString(), Microsoft.Office.Interop.Word.WdExportFormat.wdExportFormatPDF);
                MessageBox.Show("PDF Succesfully Generated", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);




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



        public void Mem1Operation()
        {
            try
            {
                cmd2 = new SqlCommand("insert into JLGMemberDetail values(@presph,@mname,@msbno,@mfathername,@mmarital,@mrealtionship,@mcomm,@mwork,@mdob,@mage,@mgender,@maadhar,@mphno,@madds1,@madds2,@madds3,@madds4,@mpincode)", cn);
                cmd2.Parameters.AddWithValue("presph", JLGBorrower.Instance.presno.Text);
                cmd2.Parameters.AddWithValue("mname", JLGmem1.instance.memname1.Text);
                cmd2.Parameters.AddWithValue("msbno", JLGmem1.instance.memsb1.Text);
                cmd2.Parameters.AddWithValue("mfathername", JLGmem1.instance.memfather1.Text);
                cmd2.Parameters.AddWithValue("mmarital", JLGmem1.instance.memmarital1.SelectedItem);
                cmd2.Parameters.AddWithValue("mrealtionship", JLGmem1.instance.memrelation1.Text);
                cmd2.Parameters.AddWithValue("mcomm", JLGmem1.instance.memcomm1.SelectedItem);
                cmd2.Parameters.AddWithValue("mwork", JLGmem1.instance.memwork1.Text);
                cmd2.Parameters.AddWithValue("mdob", JLGmem1.instance.memdob1dt.Value.Date);
                cmd2.Parameters.AddWithValue("mage", JLGmem1.instance.memage1.Text);
                cmd2.Parameters.AddWithValue("mgender", JLGmem1.instance.memgender1.SelectedItem);
                cmd2.Parameters.AddWithValue("maadhar", JLGmem1.instance.memaadhar1.Text);
                cmd2.Parameters.AddWithValue("mphno", JLGmem1.instance.memph1.Text);
                cmd2.Parameters.AddWithValue("madds1", JLGmem1.instance.memadds11.Text);
                cmd2.Parameters.AddWithValue("madds2", JLGmem1.instance.memadds21.Text);
                cmd2.Parameters.AddWithValue("madds3", JLGmem1.instance.memadds31.Text);
                cmd2.Parameters.AddWithValue("madds4", JLGmem1.instance.memadds41.Text);
                cmd2.Parameters.AddWithValue("mpincode", JLGmem1.instance.mempincode1.Text);
                cmd2.ExecuteNonQuery();
                MessageBox.Show("Mem 1 added successfully");

                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public void Mem2Operation()
        {
            try
            {
                cmd3 = new SqlCommand("insert into JLGMemberDetail values(@presph,@mname,@msbno,@mfathername,@mmarital,@mrealtionship,@mcomm,@mwork,@mdob,@mage,@mgender,@maadhar,@mphno,@madds1,@madds2,@madds3,@madds4,@mpincode)", cn);
                cmd3.Parameters.AddWithValue("presph", JLGBorrower.Instance.presno.Text);
                cmd3.Parameters.AddWithValue("mname", JLGmem2.instance.memname1.Text);
                cmd3.Parameters.AddWithValue("msbno", JLGmem2.instance.memsb1.Text);
                cmd3.Parameters.AddWithValue("mfathername", JLGmem2.instance.memfather1.Text);
                cmd3.Parameters.AddWithValue("mmarital", JLGmem2.instance.memmarital1.SelectedItem.ToString());
                cmd3.Parameters.AddWithValue("mrealtionship", JLGmem2.instance.memrelation1.Text);
                cmd3.Parameters.AddWithValue("mcomm", JLGmem2.instance.memcomm1.SelectedItem);
                cmd3.Parameters.AddWithValue("mwork", JLGmem2.instance.memwork1.Text);
                cmd3.Parameters.AddWithValue("mdob", JLGmem2.instance.memdob1dt.Value.Date);
                cmd3.Parameters.AddWithValue("mage", JLGmem2.instance.memage1.Text);
                cmd3.Parameters.AddWithValue("mgender", JLGmem2.instance.memgender1.SelectedItem);
                cmd3.Parameters.AddWithValue("maadhar", JLGmem2.instance.memaadhar1.Text);
                cmd3.Parameters.AddWithValue("mphno", JLGmem2.instance.memph1.Text);
                cmd3.Parameters.AddWithValue("madds1", JLGmem2.instance.memadds11.Text);
                cmd3.Parameters.AddWithValue("madds2", JLGmem2.instance.memadds21.Text);
                cmd3.Parameters.AddWithValue("madds3", JLGmem2.instance.memadds31.Text);
                cmd3.Parameters.AddWithValue("madds4", JLGmem2.instance.memadds41.Text);
                cmd3.Parameters.AddWithValue("mpincode", JLGmem2.instance.mempincode1.Text);
                cmd3.ExecuteNonQuery();
                MessageBox.Show("Mem 2 added successfully");




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public void Mem3Operation()
        {
            try
            {
                cmd4 = new SqlCommand("insert into JLGMemberDetail values(@presph,@mname,@msbno,@mfathername,@mmarital,@mrealtionship,@mcomm,@mwork,@mdob,@mage,@mgender,@maadhar,@mphno,@madds1,@madds2,@madds3,@madds4,@mpincode)", cn);
                cmd4.Parameters.AddWithValue("presph", JLGBorrower.Instance.presno.Text);
                cmd4.Parameters.AddWithValue("mname", JLGmem3.instance.memname1.Text);
                cmd4.Parameters.AddWithValue("msbno", JLGmem3.instance.memsb1.Text);
                cmd4.Parameters.AddWithValue("mfathername", JLGmem3.instance.memfather1.Text);
                cmd4.Parameters.AddWithValue("mmarital", JLGmem3.instance.memmarital1.SelectedItem);
                cmd4.Parameters.AddWithValue("mrealtionship", JLGmem3.instance.memrelation1.Text);
                cmd4.Parameters.AddWithValue("mcomm", JLGmem3.instance.memcomm1.SelectedItem);
                cmd4.Parameters.AddWithValue("mwork", JLGmem3.instance.memwork1.Text);
                cmd4.Parameters.AddWithValue("mdob", JLGmem3.instance.memdob1dt.Value.Date);
                cmd4.Parameters.AddWithValue("mage", JLGmem3.instance.memage1.Text);
                cmd4.Parameters.AddWithValue("mgender", JLGmem3.instance.memgender1.SelectedItem);
                cmd4.Parameters.AddWithValue("maadhar", JLGmem3.instance.memaadhar1.Text);
                cmd4.Parameters.AddWithValue("mphno", JLGmem3.instance.memph1.Text);
                cmd4.Parameters.AddWithValue("madds1", JLGmem3.instance.memadds11.Text);
                cmd4.Parameters.AddWithValue("madds2", JLGmem3.instance.memadds21.Text);
                cmd4.Parameters.AddWithValue("madds3", JLGmem3.instance.memadds31.Text);
                cmd4.Parameters.AddWithValue("madds4", JLGmem3.instance.memadds41.Text);
                cmd4.Parameters.AddWithValue("mpincode", JLGmem3.instance.mempincode1.Text);
                cmd4.ExecuteNonQuery();
                MessageBox.Show("Mem 3 added successfully");


                // FindAndReplace("[MEM3_HusName]", JLGmem1.instance.memph1.Text);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public void Mem4Operation()
        {
            try
            {
                cmd5 = new SqlCommand("insert into JLGMemberDetail values(@presph,@mname,@msbno,@mfathername,@mmarital,@mrealtionship,@mcomm,@mwork,@mdob,@mage,@mgender,@maadhar,@mphno,@madds1,@madds2,@madds3,@madds4,@mpincode)", cn);
                cmd5.Parameters.AddWithValue("presph", JLGBorrower.Instance.presno.Text);
                cmd5.Parameters.AddWithValue("mname", JLGmem4.instance.memname1.Text);
                cmd5.Parameters.AddWithValue("msbno", JLGmem4.instance.memsb1.Text);
                cmd5.Parameters.AddWithValue("mfathername", JLGmem4.instance.memfather1.Text);
                cmd5.Parameters.AddWithValue("mmarital", JLGmem4.instance.memmarital1.SelectedItem);
                cmd5.Parameters.AddWithValue("mrealtionship", JLGmem4.instance.memrelation1.Text);
                cmd5.Parameters.AddWithValue("mcomm", JLGmem4.instance.memcomm1.SelectedItem);
                cmd5.Parameters.AddWithValue("mwork", JLGmem4.instance.memwork1.Text);
                cmd5.Parameters.AddWithValue("mdob", JLGmem4.instance.memdob1dt.Value.Date);
                cmd5.Parameters.AddWithValue("mage", JLGmem4.instance.memage1.Text);
                cmd5.Parameters.AddWithValue("mgender", JLGmem4.instance.memgender1.SelectedItem);
                cmd5.Parameters.AddWithValue("maadhar", JLGmem4.instance.memaadhar1.Text);
                cmd5.Parameters.AddWithValue("mphno", JLGmem4.instance.memph1.Text);
                cmd5.Parameters.AddWithValue("madds1", JLGmem4.instance.memadds11.Text);
                cmd5.Parameters.AddWithValue("madds2", JLGmem4.instance.memadds21.Text);
                cmd5.Parameters.AddWithValue("madds3", JLGmem4.instance.memadds31.Text);
                cmd5.Parameters.AddWithValue("madds4", JLGmem4.instance.memadds41.Text);
                cmd5.Parameters.AddWithValue("mpincode", JLGmem4.instance.mempincode1.Text);
                cmd5.ExecuteNonQuery();
                MessageBox.Show("Mem 4 added successfully");

            

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public void Mem5Operation()
        {
            try
            {
                cmd6 = new SqlCommand("insert into JLGMemberDetail values(@presph,@mname,@msbno,@mfathername,@mmarital,@mrealtionship,@mcomm,@mwork,@mdob,@mage,@mgender,@maadhar,@mphno,@madds1,@madds2,@madds3,@madds4,@mpincode)", cn);
                cmd6.Parameters.AddWithValue("presph", JLGBorrower.Instance.presno.Text);
                cmd6.Parameters.AddWithValue("mname", JLGmem5.instance.memname1.Text);
                cmd6.Parameters.AddWithValue("msbno", JLGmem5.instance.memsb1.Text);
                cmd6.Parameters.AddWithValue("mfathername", JLGmem5.instance.memfather1.Text);
                cmd6.Parameters.AddWithValue("mmarital", JLGmem5.instance.memmarital1.SelectedItem);
                cmd6.Parameters.AddWithValue("mrealtionship", JLGmem5.instance.memrelation1.Text);
                cmd6.Parameters.AddWithValue("mcomm", JLGmem5.instance.memcomm1.SelectedItem);
                cmd6.Parameters.AddWithValue("mwork", JLGmem5.instance.memwork1.Text);
                cmd6.Parameters.AddWithValue("mdob", JLGmem5.instance.memdob1dt.Value.Date);
                cmd6.Parameters.AddWithValue("mage", JLGmem5.instance.memage1.Text);
                cmd6.Parameters.AddWithValue("mgender", JLGmem5.instance.memgender1.SelectedItem);
                cmd6.Parameters.AddWithValue("maadhar", JLGmem5.instance.memaadhar1.Text);
                cmd6.Parameters.AddWithValue("mphno", JLGmem5.instance.memph1.Text);
                cmd6.Parameters.AddWithValue("madds1", JLGmem5.instance.memadds11.Text);
                cmd6.Parameters.AddWithValue("madds2", JLGmem5.instance.memadds21.Text);
                cmd6.Parameters.AddWithValue("madds3", JLGmem5.instance.memadds31.Text);
                cmd6.Parameters.AddWithValue("madds4", JLGmem5.instance.memadds41.Text);
                cmd6.Parameters.AddWithValue("mpincode", JLGmem5.instance.mempincode1.Text);
                cmd6.ExecuteNonQuery();
                MessageBox.Show("Mem 5 added successfully");

             
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void Mem6Operation()
        {
            try
            {
                cmd7 = new SqlCommand("insert into JLGMemberDetail values(@presph,@mname,@msbno,@mfathername,@mmarital,@mrealtionship,@mcomm,@mwork,@mdob,@mage,@mgender,@maadhar,@mphno,@madds1,@madds2,@madds3,@madds4,@mpincode)", cn);
                cmd7.Parameters.AddWithValue("presph", JLGBorrower.Instance.presno.Text);
                cmd7.Parameters.AddWithValue("mname", JLGmem6.instance.memname1.Text);
                cmd7.Parameters.AddWithValue("msbno", JLGmem6.instance.memsb1.Text);
                cmd7.Parameters.AddWithValue("mfathername", JLGmem6.instance.memfather1.Text);
                cmd7.Parameters.AddWithValue("mmarital", JLGmem6.instance.memmarital1.SelectedItem);
                cmd7.Parameters.AddWithValue("mrealtionship", JLGmem6.instance.memrelation1.Text);
                cmd7.Parameters.AddWithValue("mcomm", JLGmem6.instance.memcomm1.SelectedItem);
                cmd7.Parameters.AddWithValue("mwork", JLGmem6.instance.memwork1.Text);
                cmd7.Parameters.AddWithValue("mdob", JLGmem6.instance.memdob1dt.Value.Date);
                cmd7.Parameters.AddWithValue("mage", JLGmem6.instance.memage1.Text);
                cmd7.Parameters.AddWithValue("mgender", JLGmem6.instance.memgender1.SelectedItem);
                cmd7.Parameters.AddWithValue("maadhar", JLGmem6.instance.memaadhar1.Text);
                cmd7.Parameters.AddWithValue("mphno", JLGmem6.instance.memph1.Text);
                cmd7.Parameters.AddWithValue("madds1", JLGmem6.instance.memadds11.Text);
                cmd7.Parameters.AddWithValue("madds2", JLGmem6.instance.memadds21.Text);
                cmd7.Parameters.AddWithValue("madds3", JLGmem6.instance.memadds31.Text);
                cmd7.Parameters.AddWithValue("madds4", JLGmem6.instance.memadds41.Text);
                cmd7.Parameters.AddWithValue("mpincode", JLGmem6.instance.mempincode1.Text);
                cmd7.ExecuteNonQuery();
                MessageBox.Show("Mem 6 added successfully");

              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void Mem7Operation()
        {
            try
            {
                cmd8 = new SqlCommand("insert into JLGMemberDetail values(@presph,@mname,@msbno,@mfathername,@mmarital,@mrealtionship,@mcomm,@mwork,@mdob,@mage,@mgender,@maadhar,@mphno,@madds1,@madds2,@madds3,@madds4,@mpincode)", cn);
                cmd8.Parameters.AddWithValue("presph", JLGBorrower.Instance.presno.Text);
                cmd8.Parameters.AddWithValue("mname", JLGmem7.instance.memname1.Text);
                cmd8.Parameters.AddWithValue("msbno", JLGmem7.instance.memsb1.Text);
                cmd8.Parameters.AddWithValue("mfathername", JLGmem7.instance.memfather1.Text);
                cmd8.Parameters.AddWithValue("mmarital", JLGmem7.instance.memmarital1.SelectedItem);
                cmd8.Parameters.AddWithValue("mrealtionship", JLGmem7.instance.memrelation1.Text);
                cmd8.Parameters.AddWithValue("mcomm", JLGmem7.instance.memcomm1.SelectedItem);
                cmd8.Parameters.AddWithValue("mwork", JLGmem7.instance.memwork1.Text);
                cmd8.Parameters.AddWithValue("mdob", JLGmem7.instance.memdob1dt.Value.Date);
                cmd8.Parameters.AddWithValue("mage", JLGmem7.instance.memage1.Text);
                cmd8.Parameters.AddWithValue("mgender", JLGmem7.instance.memgender1.SelectedItem);
                cmd8.Parameters.AddWithValue("maadhar", JLGmem7.instance.memaadhar1.Text);
                cmd8.Parameters.AddWithValue("mphno", JLGmem7.instance.memph1.Text);
                cmd8.Parameters.AddWithValue("madds1", JLGmem7.instance.memadds11.Text);
                cmd8.Parameters.AddWithValue("madds2", JLGmem7.instance.memadds21.Text);
                cmd8.Parameters.AddWithValue("madds3", JLGmem7.instance.memadds31.Text);
                cmd8.Parameters.AddWithValue("madds4", JLGmem7.instance.memadds41.Text);
                cmd8.Parameters.AddWithValue("mpincode", JLGmem7.instance.mempincode1.Text);
                cmd8.ExecuteNonQuery();
                MessageBox.Show("Mem 7 added successfully");


              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void Mem8Operation()
        {
            try
            {
                cmd9 = new SqlCommand("insert into JLGMemberDetail values(@presph,@mname,@msbno,@mfathername,@mmarital,@mrealtionship,@mcomm,@mwork,@mdob,@mage,@mgender,@maadhar,@mphno,@madds1,@madds2,@madds3,@madds4,@mpincode)", cn);
                cmd9.Parameters.AddWithValue("presph", JLGBorrower.Instance.presno.Text);
                cmd9.Parameters.AddWithValue("mname", JLGmem8.instance.memname1.Text);
                cmd9.Parameters.AddWithValue("msbno", JLGmem8.instance.memsb1.Text);
                cmd9.Parameters.AddWithValue("mfathername", JLGmem8.instance.memfather1.Text);
                cmd9.Parameters.AddWithValue("mmarital", JLGmem8.instance.memmarital1.SelectedItem);
                cmd9.Parameters.AddWithValue("mrealtionship", JLGmem8.instance.memrelation1.Text);
                cmd9.Parameters.AddWithValue("mcomm", JLGmem8.instance.memcomm1.SelectedItem);
                cmd9.Parameters.AddWithValue("mwork", JLGmem8.instance.memwork1.Text);
                cmd9.Parameters.AddWithValue("mdob", JLGmem8.instance.memdob1dt.Value.Date);
                cmd9.Parameters.AddWithValue("mage", JLGmem8.instance.memage1.Text);
                cmd9.Parameters.AddWithValue("mgender", JLGmem8.instance.memgender1.SelectedItem);
                cmd9.Parameters.AddWithValue("maadhar", JLGmem8.instance.memaadhar1.Text);
                cmd9.Parameters.AddWithValue("mphno", JLGmem8.instance.memph1.Text);
                cmd9.Parameters.AddWithValue("madds1", JLGmem8.instance.memadds11.Text);
                cmd9.Parameters.AddWithValue("madds2", JLGmem8.instance.memadds21.Text);
                cmd9.Parameters.AddWithValue("madds3", JLGmem8.instance.memadds31.Text);
                cmd9.Parameters.AddWithValue("madds4", JLGmem8.instance.memadds41.Text);
                cmd9.Parameters.AddWithValue("mpincode", JLGmem8.instance.mempincode1.Text);
                cmd9.ExecuteNonQuery();
                MessageBox.Show("Mem 8 added successfully");

             

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void Mem9Operation()
        {
            try
            {
                cmd10 = new SqlCommand("insert into JLGMemberDetail values(@presph,@mname,@msbno,@mfathername,@mmarital,@mrealtionship,@mcomm,@mwork,@mdob,@mage,@mgender,@maadhar,@mphno,@madds1,@madds2,@madds3,@madds4,@mpincode)", cn);
                cmd10.Parameters.AddWithValue("presph", JLGBorrower.Instance.presno.Text);
                cmd10.Parameters.AddWithValue("mname", JLGmem9.instance.memname1.Text);
                cmd10.Parameters.AddWithValue("msbno", JLGmem9.instance.memsb1.Text);
                cmd10.Parameters.AddWithValue("mfathername", JLGmem9.instance.memfather1.Text);
                cmd10.Parameters.AddWithValue("mmarital", JLGmem9.instance.memmarital1.SelectedItem);
                cmd10.Parameters.AddWithValue("mrealtionship", JLGmem9.instance.memrelation1.Text);
                cmd10.Parameters.AddWithValue("mcomm", JLGmem9.instance.memcomm1.SelectedItem);
                cmd10.Parameters.AddWithValue("mwork", JLGmem9.instance.memwork1.Text);
                cmd10.Parameters.AddWithValue("mdob", JLGmem9.instance.memdob1dt.Value.Date);
                cmd10.Parameters.AddWithValue("mage", JLGmem9.instance.memage1.Text);
                cmd10.Parameters.AddWithValue("mgender", JLGmem9.instance.memgender1.SelectedItem);
                cmd10.Parameters.AddWithValue("maadhar", JLGmem9.instance.memaadhar1.Text);
                cmd10.Parameters.AddWithValue("mphno", JLGmem9.instance.memph1.Text);
                cmd10.Parameters.AddWithValue("madds1", JLGmem9.instance.memadds11.Text);
                cmd10.Parameters.AddWithValue("madds2", JLGmem9.instance.memadds21.Text);
                cmd10.Parameters.AddWithValue("madds3", JLGmem9.instance.memadds31.Text);
                cmd10.Parameters.AddWithValue("madds4", JLGmem9.instance.memadds41.Text);
                cmd10.Parameters.AddWithValue("mpincode", JLGmem9.instance.mempincode1.Text);
                cmd10.ExecuteNonQuery();
                MessageBox.Show("Mem 9 added successfully");

               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public void Mem10Operation()
        {
            try
            {
                cmd11 = new SqlCommand("insert into JLGMemberDetail values(@presph,@mname,@msbno,@mfathername,@mmarital,@mrealtionship,@mcomm,@mwork,@mdob,@mage,@mgender,@maadhar,@mphno,@madds1,@madds2,@madds3,@madds4,@mpincode)", cn);
                cmd11.Parameters.AddWithValue("presph", JLGBorrower.Instance.presno.Text);
                cmd11.Parameters.AddWithValue("mname", JLGmem10.instance.memname1.Text);
                cmd10.Parameters.AddWithValue("msbno", JLGmem10.instance.memsb1.Text);
                cmd11.Parameters.AddWithValue("mfathername", JLGmem10.instance.memfather1.Text);
                cmd11.Parameters.AddWithValue("mmarital", JLGmem10.instance.memmarital1.SelectedItem);
                cmd11.Parameters.AddWithValue("mrealtionship", JLGmem10.instance.memrelation1.Text);
                cmd11.Parameters.AddWithValue("mcomm", JLGmem10.instance.memcomm1.SelectedItem);
                cmd11.Parameters.AddWithValue("mwork", JLGmem10.instance.memwork1.Text);
                cmd11.Parameters.AddWithValue("mdob", JLGmem10.instance.memdob1dt.Value.Date);
                cmd11.Parameters.AddWithValue("mage", JLGmem10.instance.memage1.Text);
                cmd11.Parameters.AddWithValue("mgender", JLGmem10.instance.memgender1.SelectedItem);
                cmd11.Parameters.AddWithValue("maadhar", JLGmem10.instance.memaadhar1.Text);
                cmd11.Parameters.AddWithValue("mphno", JLGmem10.instance.memph1.Text);
                cmd11.Parameters.AddWithValue("madds1", JLGmem10.instance.memadds11.Text);
                cmd11.Parameters.AddWithValue("madds2", JLGmem10.instance.memadds21.Text);
                cmd11.Parameters.AddWithValue("madds3", JLGmem10.instance.memadds31.Text);
                cmd11.Parameters.AddWithValue("madds4", JLGmem10.instance.memadds41.Text);
                cmd11.Parameters.AddWithValue("mpincode", JLGmem10.instance.mempincode1.Text);
                cmd11.ExecuteNonQuery();
                MessageBox.Show("Mem 10 added successfully");

              

            }
            catch (Exception ex)
            {
               MessageBox.Show(ex.Message);
            }
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

            AddContUserControl(jlgMem1);
            bottomMemPgPanel.Visible = true;
        }

        private void amountDetailsBtn_Click(object sender, EventArgs e)
        {

            AddContUserControl(jLGAmount);
            bottomMemPgPanel.Visible = false;
        }

        private void exportBtn_Click(object sender, EventArgs e)
        {
            export();
        }
        private void FindAndReplace(object FindText, object ReplaceText)
        {
            this.app.Selection.Find.Execute(ref FindText, true, true, false, false, false, true, false, 1, ref ReplaceText, 2, false, false, false, false);
        }
    }
}
