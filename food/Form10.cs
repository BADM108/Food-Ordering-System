using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_CW_v1._0
{
    public partial class frmpayment : Form
    {
        public frmpayment()
        {
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        {

           
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            frmcardpayment gg = new frmcardpayment();
            gg.ShowDialog();
            this.Hide();
        }

        private void btncashondeliveryinpayment_Click(object sender, EventArgs e)
        {
            frmaddress hh = new frmaddress();
            hh.ShowDialog();    
            this.Hide();
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            frmmenu hh = new frmmenu();
            hh.Show();
            this.Hide();    
        }
    }
}
