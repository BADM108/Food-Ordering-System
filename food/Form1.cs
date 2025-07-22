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
    public partial class frmhome : Form
    {
        public frmhome()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            frmlogin li = new frmlogin();
            li.Show();
            this.Hide();
        }

        private void btnsignupinlogin_Click(object sender, EventArgs e)
        {
            frmsignup si = new frmsignup();
            si.Show();
            this.Hide();
        }

        private void btnquitinhome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmhome_Load(object sender, EventArgs e)
        {

        }
    }
}
