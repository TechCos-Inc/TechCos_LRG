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
        public static memberpageNum instance;
        //public JLGmem1 mem1;
        public JLGmem2 mem2;
        public JLGmem3 mem3;
        public JLGmem4 mem4;
        public JLGmem5 mem5;
        public JLGmem6 mem6;
        public JLGmem7 mem7;
        public JLGmem8 mem8;
        public JLGmem9 mem9;
        public JLGmem10 mem10;




        public memberpageNum()
        {
            InitializeComponent();
            instance = this;
            //   mem1 = new JLGmem1();
            mem2 = new JLGmem2();
            mem3 = new JLGmem3();
            mem4 = new JLGmem4();
            mem5 = new JLGmem5();
            mem6 = new JLGmem6();
            mem7 = new JLGmem7();
            mem8 = new JLGmem8();
            mem9 = new JLGmem9();
            mem10 = new JLGmem10();


        }

        private void memberpageNum_Load(object sender, EventArgs e)
        {
            if (JLGDetails.Instance.memcountCmb.SelectedItem != null)
            {
                hidePg(JLGDetails.Instance.memcountCmb.SelectedItem.ToString());
            }


            //   MessageBox.Show(this.Controls.IndexOf(mpage5).ToString());


            ;
        }


        public void hidePg(String num)
        {
            try
            {
                String name;
                for (int i = int.Parse(num) + 1; i <= 10; i++)
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
            JLGLoan.instance.AddContUserControl(JLGLoan.instance.jlgMem1);
        }

        private void mpage2_Click(object sender, EventArgs e)
        {
            JLGLoan.instance.AddContUserControl(mem2);

        }

        private void mpage3_Click(object sender, EventArgs e)
        {

            JLGLoan.instance.AddContUserControl(mem3);
        }

        private void mpage4_Click(object sender, EventArgs e)
        {

            JLGLoan.instance.AddContUserControl(mem4);
        }

        private void mpage5_Click(object sender, EventArgs e)
        {

            JLGLoan.instance.AddContUserControl(mem5);
        }

        private void mpage6_Click(object sender, EventArgs e)
        {

            JLGLoan.instance.AddContUserControl(mem6);

        }

        private void mpage7_Click(object sender, EventArgs e)
        {

            JLGLoan.instance.AddContUserControl(mem7);

        }

        private void mpage8_Click(object sender, EventArgs e)
        {

            JLGLoan.instance.AddContUserControl(mem8);
        }

        private void mpage9_Click(object sender, EventArgs e)
        {

            JLGLoan.instance.AddContUserControl(mem9);
        }

        private void mpage10_Click(object sender, EventArgs e)
        {

            JLGLoan.instance.AddContUserControl(mem10);
        }


        private void continueImg_Click(object sender, EventArgs e)
        {
            JLGLoan.instance.AddContUserControl(JLGLoan.instance.jLGAmount);
            JLGLoan.instance.amtBtn.Enabled = true;
            JLGLoan.instance.memBottomPanel.Visible = false;
            JLGLoan.instance.expBtn.Visible = true;
        }

        private void mpage13_Click(object sender, EventArgs e)
        {

        }
    }

}
