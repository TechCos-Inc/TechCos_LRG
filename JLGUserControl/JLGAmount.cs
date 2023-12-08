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
        public MaterialTextBox typeOfCredit, procode1, procode2, amount, interest, spread, mclr, emiAmount, noOfMonths;
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
            mclr = mclrTxt;
            emiAmount = emiAmountTxt;
            noOfMonths = noOfMonthTxt;

        }
    }
}
