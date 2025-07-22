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
    public partial class frmcardpayment : Form
    {
        public frmcardpayment()
        {
            InitializeComponent();
        }

        private void btncontinueincardp_Click(object sender, EventArgs e)
        {
            string Cname, Cnumber, month, year, cvv;
            Cname = txtcardholdernameincardp.Text;
            Cnumber = txtcardnumberincardp.Text;
            month = txtmonthincardp.Text;
            year = txtyearincardp.Text;
            cvv = txtcvvincardp.Text;
            if (string.IsNullOrWhiteSpace(Cname) ||
                string.IsNullOrWhiteSpace(month) ||
                string.IsNullOrWhiteSpace(Cnumber) ||
                string.IsNullOrWhiteSpace(year) ||
                string.IsNullOrWhiteSpace(cvv))

            {

                MessageBox.Show("Please fill in all fields. None of the fields should be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!checkBox1.Checked == !checkBox2.Checked) // Check all three checkboxes
            {
                MessageBox.Show("You must Select A payment Card.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Create and show the loading form
            frmloading loadingForm = new frmloading();
            loadingForm.Show(); // Show the loading form non-modally

            // Start a timer to close the loading form after 2 seconds
            Timer timer = new Timer();
            timer.Interval = 2000; // Set the interval to 2 seconds (2000 ms)
            timer.Tick += (s, args) =>
            {
                timer.Stop(); // Stop the timer
                loadingForm.Close(); // Close the loading form

                // Open the next form
                frmaddress nextForm = new frmaddress();
                nextForm.Show(); // Show the next form
                this.Hide(); // Optionally hide the current form
            };
            timer.Start(); // Start the timer

        }

        private void btncancelincardp_Click(object sender, EventArgs e)
        {
            frmpayment h1 = new frmpayment();
            h1.Show();
            this.Hide();
        }
    }
}
