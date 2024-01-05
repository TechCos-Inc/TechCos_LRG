using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechCos_LRG.JLG.JLGUserControl
{
    public partial class PreSanctionSurvey : UserControl
    {
        public PreSanctionSurvey()
        {
            InitializeComponent();
        }

        private void continueImg_Click(object sender, EventArgs e)
        {
            JLGLoan.instance.AddContUserControl(JLGLoan.instance.dueDiligenceReport);
            JLGLoan.instance.duediliBtn.Enabled = true;
        }
    }
}
