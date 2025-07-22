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
    public partial class frmsignup : Form
    {
        public frmsignup()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnbackinsignup_Click(object sender, EventArgs e)
        {
            frmhome h1 = new frmhome();
            h1.Show();
           this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btncontinueinsignup_Click(object sender, EventArgs e)
        {
            //Opening an sql connection to my server 
            string connstring = " Data Source=DESKTOP-5T6LL7T\\SQLEXPRESS;Initial Catalog=GUIP;Integrated Security=True;";
            SqlConnection conn = new SqlConnection(connstring);
            conn.Open();
            //creating strings
            string Fname, Lname, Cnumber, Email, Address, Password, Cpassword;
            Fname = txtfnameinsignup.Text;
            Lname = txtlnameinsignup.Text;
            Cnumber = txtnuminsignup.Text;
            Email = txtemailinsignup.Text;
            Address = txtaddressinsignup.Text;
            Password = txtpasswordinsignup.Text;
            Cpassword = txtconfirmpinsignup.Text;
            if (Password != Cpassword)
            {
                MessageBox.Show("The Passwords Don't Match!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(Fname) ||
                 string.IsNullOrWhiteSpace(Lname) ||
                 string.IsNullOrWhiteSpace(Cnumber) ||
                 string.IsNullOrWhiteSpace(Email) ||
                 string.IsNullOrWhiteSpace(Address) ||
                 string.IsNullOrWhiteSpace(Password))

            {

                MessageBox.Show("Please fill in all fields. None of the fields should be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!checkboxcaptcha.Checked)
            {
                MessageBox.Show("You must agree to the terms and conditions.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string mycommand = "INSERT INTO customer(fname, lname, cno, email, address, password) VALUES (@Fname, @Lname, @Cnumber, @Email, @Address, @Password)";
            SqlCommand comm = new SqlCommand(mycommand, conn);
            comm.Parameters.AddWithValue("@Fname", Fname);
            comm.Parameters.AddWithValue("@Lname", Lname);
            comm.Parameters.AddWithValue("@Cnumber", Cnumber);
            comm.Parameters.AddWithValue("@Email", Email);
            comm.Parameters.AddWithValue("@Address", Address);
            comm.Parameters.AddWithValue("@Password", Password);
            comm.ExecuteNonQuery();
            MessageBox.Show("YOU HAVE SIGNED IN SUCCESSFULLY *_*");
            conn.Close();
            frmlogin f2 = new frmlogin();
            f2.Show();
            this.Close();
        }

        private void txtnuminsignup_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
