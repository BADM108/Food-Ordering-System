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
    public partial class frmadminhome : Form
    {
        public frmadminhome()
        {
            InitializeComponent();
        }
        private void LoadUserData()
        {
            string connString = "Data Source=DESKTOP-5T6LL7T\\SQLEXPRESS;Initial Catalog=GUIP;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                string query = "SELECT * FROM customer";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                boxgridviewusers.DataSource = dataTable;
            }
        }


        private void frmadminhome_Load(object sender, EventArgs e)
        {
            LoadUserData();
        }

        private void btnbackinsignup_Click(object sender, EventArgs e)
        {
            frmlogin gh = new frmlogin();
            gh.Show();
            this.Hide();
        }

        private void btnreport_Click(object sender, EventArgs e)
        {
            frmreport r1 = new frmreport(); 
            r1.Show();  
            this.Hide();
        }
    }
}
