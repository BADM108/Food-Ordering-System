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
    public partial class frmmenu : Form
    {
        public frmmenu()
        {
            InitializeComponent();
        }

        private void btnmealsinmenu_Click(object sender, EventArgs e)
        {
            frmmeals m1 = new frmmeals();
            m1.Show();
            this.Hide();
        }

        private void btndrinksinenu_Click(object sender, EventArgs e)
        {
            frmdrinks d1 = new frmdrinks();
            d1.Show();
            this.Hide();
        }

        private void btndessertsinmenu_Click(object sender, EventArgs e)
        {
            frmdesserts s1 = new frmdesserts();
            s1.Show();
            this.Hide();
        }

        private void btnbackinmenu_Click(object sender, EventArgs e)
        {
            frmlogin f1 = new frmlogin();
            f1.Show();
            this.Hide();
        }
    }
}
