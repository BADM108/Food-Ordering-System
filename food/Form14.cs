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
    public partial class frmaddress : Form
    {
        public frmaddress()
        {
            InitializeComponent();
        }

        private void btncontinueindelivery_Click(object sender, EventArgs e)
        {
            string email, number, adress;
            email = txtemailindelivery.Text;
            number = txtconactnumberindelivery.Text;
            adress = txtadf.Text;
            if (string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(number) ||
                string.IsNullOrWhiteSpace(adress))

            {

                MessageBox.Show("Please fill in all fields. None of the fields should be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            // Create and show the loading form
            frmloading loadingForm = new frmloading();
            loadingForm.Show(); 
            // Show the loading form non-modally

            // Start a timer to close the loading form after 2 seconds
            Timer timer = new Timer();
            timer.Interval = 2000; // Set the interval to 2 seconds (2000 ms)
            timer.Tick += (s, args) =>
            {
                timer.Stop(); // Stop the timer
                loadingForm.Close(); // Close the loading form

                // Open the next form
                frmend nextForm = new frmend();
                nextForm.Show(); // Show the next form
                this.Hide(); // Optionally hide the current form
            };
            timer.Start(); // 
        }

        private void btnbackindelivery_Click(object sender, EventArgs e)
        {
           frmpayment frmpayment = new frmpayment();
            frmpayment.Show();
            this.Hide();
        }
    }
}
