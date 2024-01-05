using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechCos_LRG.JLG_usercontrol
{
    public partial class JLGDetails : UserControl
    {
        public static JLGDetails Instance;
        public DateTimePicker doc_date, app_date,presan_date,grpmeet_date,facilitae_date;
        public MaterialTextBox jlgname, sbno, adds1, adds2, adds3, adds4, pincode, presname, presno, secrname, secrno, amount,savings,loanhistory;
        public MaterialComboBox memcountCmb;
        public JLGDetails()
        {
            InitializeComponent();
            Instance = this;
            memCountCombo.Items.Add("1");
            memCountCombo.Items.Add("2");
            memCountCombo.Items.Add("3");
            memCountCombo.Items.Add("4");
            memCountCombo.Items.Add("5");
            memCountCombo.Items.Add("6");
            memCountCombo.Items.Add("7");
            memCountCombo.Items.Add("8");
            memCountCombo.Items.Add("9");
            memCountCombo.Items.Add("10");
            amount = AmtText;
            savings = savingsTxt;
            loanhistory = LoanHisTxt;
            doc_date = Doc_date;
            app_date = App_date;
            presan_date = Presan_date;
            grpmeet_date = GrpMeet_date;
            jlgname = JlgNameTxt;
            sbno = SbNoTxt;
            adds1 = ADDs1Txt;
            adds2 = ADDs2Txt;
            adds3 = ADDs3Txt;
            adds4 = ADDs4Txt;
            pincode = PinCodeTxt;
            presname = PRESNameTxt;
            presno = PRESNoTxt;
            secrname = SECRNameTxt;
            secrno = SECRNoTxt;
            memcountCmb = memCountCombo;
        }


        private void continueImg_Click(object sender, EventArgs e)
        {
            JLGLoan.instance.AddContUserControl(JLGLoan.instance.jlgMem1);
            JLGLoan.instance.memBottomPanel.Visible = true;
            JLGLoan.instance.AddBottoMemPgUserControl(JLGLoan.instance.membpageNum);
            JLGLoan.instance.memBtn.Enabled = true;
        }

      
    }
       
}
