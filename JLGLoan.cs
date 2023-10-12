using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechCos_LRG
{
    public partial class JLGLoan : Form
    {
        public JLGLoan()
        {
            InitializeComponent();
        }
        public void loadform(object Form)
        {
            if (this.JLGpanal.Controls.Count > 0)
            {
                this.JLGpanal.Controls.RemoveAt(0);
                Form f = Form as form;
                f.TopLevel = false;
                f.Dock = DockStyle.Fill;
                this.JLGpanal.Controls.Add(f);
                this.JLGpanal.Tag = f;
                f.Show();
            }
        }

        private void JlgBtn_Click(object sender, EventArgs e)
        {

        }

        private void AmtBtn_Click(object sender, EventArgs e)
        {
            loadform(new JLGAmt());
        }

        private void mem1Btn_Click(object sender, EventArgs e)
        {
            loadform(new JLGMember1());
        }
    }
}
