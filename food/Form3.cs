using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_CW_v1._0
{
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();
        }

        private void btnbackinlogin_Click(object sender, EventArgs e)
        {
            frmhome h2 = new frmhome();
            h2.Show();
            this.Hide();
        }

        private void linklblsignuphereonlogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmsignup s1 = new frmsignup();
            s1.Show();
            this.Hide();
        }

        private void frmlogin_Load(object sender, EventArgs e)
        {

        }

        private void btncontinueinlogin_Click(object sender, EventArgs e)
        {

            string email = txtemailinlogin.Text;
            string password = txtpasswordinlogin.Text;


            if (email == "BADM@gmail.com" && password == "9999")
            {

                frmloading loadingForm = new frmloading();
                loadingForm.Show();


                Timer timer = new Timer();
                timer.Interval = 2000;
                timer.Tick += (s, args) =>
                {
                    timer.Stop();
                    loadingForm.Close();


                    frmadminhome nextForm = new frmadminhome();
                    nextForm.Show();
                    this.Hide();
                };
                timer.Start();


            }
            else
            {

                string connstring = "Data Source=DESKTOP-5T6LL7T\\SQLEXPRESS;Initial Catalog=GUIP;Integrated Security=True";
                SqlConnection conn = new SqlConnection(connstring);
                conn.Open();

                string Email, Password;
                Email = txtemailinlogin.Text;
                Password = txtpasswordinlogin.Text;
                string mycommand = "SELECT COUNT(1) FROM customer WHERE email = @Email AND password = @password";
                SqlCommand comm = new SqlCommand(mycommand, conn);
                comm.Parameters.AddWithValue("@email", Email);
                comm.Parameters.AddWithValue("@password", Password);
                try
                {

                    int count = Convert.ToInt32(comm.ExecuteScalar());


                    if (count == 1)
                    {
                        frmloading loadingForm = new frmloading();

                        MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        conn.Close();
                        this.Hide();
                        loadingForm.Show();


                        Timer timer = new Timer();
                        timer.Interval = 2000;
                        timer.Tick += (s, args) =>
                        {
                            timer.Stop();
                            loadingForm.Close();


                            frmmenu nextForm = new frmmenu();
                            nextForm.Show();

                        };
                        timer.Start();

                    }
                    else
                    {
                        string emailCheckCommand = "SELECT COUNT(1) FROM customer WHERE email = @email";
                        SqlCommand emailCmd = new SqlCommand(emailCheckCommand, conn);
                        emailCmd.Parameters.AddWithValue("@email", Email);
                        string passwordCheckCommand = "SELECT COUNT(1) FROM customer WHERE password = @Password";
                        SqlCommand passwordCmd = new SqlCommand(passwordCheckCommand, conn);
                        passwordCmd.Parameters.AddWithValue("@password", Password);

                        int emailExists = Convert.ToInt32(emailCmd.ExecuteScalar());
                        int passwordExists = Convert.ToInt32(passwordCmd.ExecuteScalar());

                        if (emailExists == 1)
                        {
                            MessageBox.Show("Password does not match.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else if (passwordExists == 1)
                        {
                            MessageBox.Show("Emial does not match.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        }

                        else
                        {
                            MessageBox.Show("You must sign up first.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }
}
