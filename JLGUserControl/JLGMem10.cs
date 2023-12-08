using Krypton.Toolkit;
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
    public partial class JLGmem10 : UserControl
    {
        public static JLGmem10 instance;
        public MaterialTextBox memname1, memsb1, memfather1, memrelation1, memwork1, memage1, memaadhar1, memph1, memadds11, memadds21, memadds31, memadds41, mempincode1;
        public MaterialComboBox memmarital1, memcomm1, memgender1;
        public DateTimePicker memdob1dt;
        public JLGmem10()
        {
            InitializeComponent();
            instance = this;
            memname1 = memname1txt;
            memsb1 = memsb1txt;
            memfather1 = memfather1txt;
            memrelation1 = memrelation1txt;
            memwork1 = memwork1txt;
            memage1 = memage1txt;
            memaadhar1 = memaadhar1txt;
            memph1 = memph1txt;
            memadds11 = memadds11txt;
            memadds21 = memadds21txt;
            memadds31 = memadds31txt;
            memadds41 = memadds41txt;
            memgender1 = memgen1cmb;
            mempincode1 = mempincode1txt;
            memmarital1 = memmaritstatus1cmb;
            memgender1 = memgen1cmb;
            memcomm1 = memcomm1cmb;
            memdob1dt = memdob1;
            memmaritstatus1cmb.Items.Add("Married");
            memmaritstatus1cmb.Items.Add("Unmarried");
            memcomm1cmb.Items.Add("OBC");
            memcomm1cmb.Items.Add("MBC");
            memcomm1cmb.Items.Add("SC");
            memcomm1cmb.Items.Add("ST");
            memgen1cmb.Items.Add("Male");
            memgen1cmb.Items.Add("Female");
        }
    }
}
