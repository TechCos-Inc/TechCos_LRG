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
    public partial class JLGAmount : UserControl
    {
        public static JLGAmount instance;
        public DateTimePicker dateofFormation;

        public MaterialTextBox typeOfCredit, procode1, procode2, amount, interest, spread, itspread, prspread, penalinterest, mclr, emiAmount, noOfMonths;
        public JLGAmount()
        {
            InitializeComponent();
            instance = this;
            dateofFormation = dateOfFormationdt;
            typeOfCredit = typeOfCredittTxt;
            procode1 = productCode1Txt;
            procode2 = productCode2Txt;
            amount = amountTxt;
            interest = interestTxt;
            spread = spreadTxt;
            prspread = prSpreadTxt;
            penalinterest = penalInterestTxt;
            itspread = itSpreadTxt;
            mclr = mclrTxt;
            emiAmount = emiAmountTxt;
            noOfMonths = noOfMonthTxt;

        }
        public float getSpread()
        {
            float spread;
            spread = float.Parse(itspread.Text + prspread.Text);
            MessageBox.Show("Spread is ", " " + spread.ToString());
            return spread;
        }

        private void continueImg_Click(object sender, EventArgs e)
        {
            JLGLoan.instance.AddContUserControl(JLGLoan.instance.preSanctionSurvey);
            JLGLoan.instance.presanBtn.Enabled = true;
        }
    }
}
