using Microsoft.Office.Interop.Word;
using Microsoft.UI.Xaml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechCos_LRG.JLG_usercontrol
{
    public partial class memberpageNum : UserControl
    {
        public memberpageNum()
        {
            InitializeComponent();


        }

        private void memberpageNum_Load(object sender, EventArgs e)
        {
            if (JLGBorrower.Instance.memcountCmb.SelectedItem != null)
            {
                hidePg(JLGBorrower.Instance.memcountCmb.SelectedItem.ToString());
            }
            
            
            //   MessageBox.Show(this.Controls.IndexOf(mpage5).ToString());


            ;
        }


        public void hidePg(String num)
        {
            try
            {
                String name;
                for (int i = int.Parse(num) + 1; i <= 15; i++)
                {
                    //  MessageBox.Show(i.ToString());
                    // this.Controls.RemoveAt(i);
                    name = "mpage" + i.ToString();
                    this.Controls.RemoveByKey(name);
                }

            }
            catch (Exception ex) { }
        }

        private void mpage1_Click(object sender, EventArgs e)
        {
            JLGMem1 mem1 = new JLGMem1();
            JLGLoan.instance.AddContUserControl(mem1);
        }

        private void mpage2_Click(object sender, EventArgs e)
        {
            JLGmem2 jLGmem2 = new JLGmem2();
            JLGLoan.instance.AddContUserControl(jLGmem2);

        }

        private void mpage3_Click(object sender, EventArgs e)
        {
            JLGmem3 jLGmem3 = new JLGmem3();
            JLGLoan.instance.AddContUserControl(jLGmem3);
        }

        private void mpage4_Click(object sender, EventArgs e)
        {
            JLGmem4 jLGmem4 = new JLGmem4();
            JLGLoan.instance.AddContUserControl(jLGmem4);
        }

        private void mpage5_Click(object sender, EventArgs e)
        {
            JLGmem5 jLGmem5 = new JLGmem5();
            JLGLoan.instance.AddContUserControl(jLGmem5);
        }

        private void mpage6_Click(object sender, EventArgs e)
        {
            JLGmem6 jLGmem6 = new JLGmem6();
            JLGLoan.instance.AddContUserControl(jLGmem6);

        }

        private void mpage7_Click(object sender, EventArgs e)
        {
            JLGmem7 jLGmem7 = new JLGmem7();
            JLGLoan.instance.AddContUserControl(jLGmem7);

        }

        private void mpage8_Click(object sender, EventArgs e)
        {
            JLGmem8 jLGmem8 = new JLGmem8();
            JLGLoan.instance.AddContUserControl(jLGmem8);
        }

        private void mpage9_Click(object sender, EventArgs e)
        {
            JLGmem9 jLGmem9 = new JLGmem9();
            JLGLoan.instance.AddContUserControl(jLGmem9);
        }

        private void mpage10_Click(object sender, EventArgs e)
        {
            JLGmem10 jLGmem10 = new JLGmem10();
            JLGLoan.instance.AddContUserControl(jLGmem10);
        }

        private void mpage11_Click(object sender, EventArgs e)
        {
            JLGmem11 jLGmem11 = new JLGmem11();
            JLGLoan.instance.AddContUserControl(jLGmem11);
        }

        private void mpage12_Click(object sender, EventArgs e)
        {
            JLGmem12 jLGmem12 = new JLGmem12();
            JLGLoan.instance.AddContUserControl(jLGmem12);

        }

        private void mpage13_Click(object sender, EventArgs e)
        {
            JLGmem13 jLGmem13 = new JLGmem13();
            JLGLoan.instance.AddContUserControl(jLGmem13);
        }

        private void mpage14_Click(object sender, EventArgs e)
        {
            JLGmem14 jLGmem14 = new JLGmem14();
            JLGLoan.instance.AddContUserControl(jLGmem14);
        }

        private void mpage15_Click(object sender, EventArgs e)
        {
            JLGmem15 jLGmem15 = new JLGmem15();
            JLGLoan.instance.AddContUserControl(jLGmem15);
        }

        private void continueImg_Click(object sender, EventArgs e)
        {
            JLGAmount jLGAmount = new JLGAmount();
            JLGLoan.instance.AddContUserControl(jLGAmount);
            JLGLoan.instance.amtBtn.Enabled = true;
            JLGLoan.instance.memBottomPanel.Visible = false;
            JLGLoan.instance.expBtn.Visible = true;
        }
    }

}
