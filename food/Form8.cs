﻿using System;
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
    public partial class frminventory : Form
    {
        public frminventory()
        {
            InitializeComponent();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            frmdesserts d4 = new frmdesserts();
            d4.Show();
            this.Hide();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            frmmenu f4 = new frmmenu();
            f4.Show();
            this.Hide();
        }
    }
}
