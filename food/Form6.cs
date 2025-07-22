using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace GUI_CW_v1._0
{
    public partial class frmdesserts : Form
    {
        Dictionary<string, decimal> itemPrices = new Dictionary<string, decimal>();
        decimal totalPrice = 0;
        public frmdesserts()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.frmdesserts_Load);

        }
        private void frmdesserts_Load(object sender, EventArgs e)
        {

            LoadPricesFromDatabase();
            DisplayPricesOnForm();
            UpdateTotalPrice();
        }

        private void LoadPricesFromDatabase()
        {
            string connString = "Data Source=DESKTOP-5T6LL7T\\SQLEXPRESS;Initial Catalog=GUIP;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                string query = "SELECT dessertname, price FROM desserts";
                SqlCommand cmd = new SqlCommand(query, conn);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        itemPrices[reader["dessertname"].ToString()] = Convert.ToDecimal(reader["price"]);
                    }
                }
            }
        }
        private void DisplayPricesOnForm()
        {
            lblpriceofcake.Text = itemPrices.ContainsKey("Cake") ? "Rs." +itemPrices["Cake"].ToString() : "Rs.0.00";
            lblpriceoficecream.Text = itemPrices.ContainsKey("Ice Cream") ? "Rs." +itemPrices["Ice Cream"].ToString() : "Rs.0.00";
            lblpriceofdoughnuts.Text = itemPrices.ContainsKey("Doughnuts") ? "Rs." +itemPrices["Doughnuts"].ToString() : "Rs.0.00";
            lblpriceofbrownies.Text = itemPrices.ContainsKey("Brownies") ? "Rs." +itemPrices["Brownies"].ToString() : "Rs.0.00";
            lblpriceoffrozenyoughurt.Text = itemPrices.ContainsKey("Frozen Youghurt") ? "Rs." +itemPrices["Frozen Youghurt"].ToString() : "0.00";
            lblpriceofwaffles.Text = itemPrices.ContainsKey("Waffles") ? "Rs." +itemPrices["Waffles"].ToString() : "Rs.0.00";
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            frmdrinks d2 = new frmdrinks();
            d2.Show();
            this.Hide();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            frmmeals f2 = new frmmeals();
            f2.Show();
            this.Hide();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
        private void UpdateTotalPrice()
        {
            totalPrice = 0;

            // Add up the prices based on the numeric up-down values            // Calculate total based on numeric up-down values and item prices
            totalPrice += (decimal)cncake.Value * itemPrices["Cake"];
            totalPrice += (decimal)cnicecream.Value * itemPrices["Ice Cream"];
            totalPrice += (decimal)cndoughnuts.Value * itemPrices["Doughnuts"];
            totalPrice += (decimal)cnbrownies.Value * itemPrices["Brownies"];
            totalPrice += (decimal)cnfrozenyoughurt.Value * itemPrices["Frozen Youghurt"];
            totalPrice += (decimal)cnwaffles.Value * itemPrices["Waffles"];

            lbltotalindesserst.Text = "Total:Rs. " + totalPrice.ToString(); // Update the total price label
            Globals.TotalAmount = totalPrice;

            Globals.FoodItems.Clear();
            if (cncake.Value > 0)
                Globals.FoodItems.Add(("Cake", itemPrices["Cake"], (int)cncake.Value));
            if (cnicecream.Value > 0)
                Globals.FoodItems.Add(("Ice Cream", itemPrices["Ice Cream"], (int)cnicecream.Value));
            if (cndoughnuts.Value > 0)
                Globals.FoodItems.Add(("Doughnuts", itemPrices["Doughnuts"], (int)cndoughnuts.Value));
            if (cnbrownies.Value > 0)
                Globals.FoodItems.Add(("Brownies", itemPrices["Brownies"], (int)cnbrownies.Value));
            if (cnfrozenyoughurt.Value > 0)
                Globals.FoodItems.Add(("Frozen Youghurt", itemPrices["Frozen Youghurt"], (int)cnfrozenyoughurt.Value));
            if (cnwaffles.Value > 0)
                Globals.FoodItems.Add(("Waffles", itemPrices["Waffles"], (int)cnwaffles.Value));

        }
         public static class Globals
        {
            public static decimal TotalAmount { get; set; } = 0;
            public static List<(string FoodName, decimal Price, int Quantity)> FoodItems { get; set; } = new List<(string, decimal, int)>();
        }

        private void btnorderindesserts_Click(object sender, EventArgs e)
        {
            frmpayment v1 = new frmpayment();
            v1.Show();
            this.Hide();
        }

        private void btnbackindesserts_Click(object sender, EventArgs e)
        {
            frmmenu f2 = new frmmenu();
            f2.Show();
            this.Show();
        }

        private void lbltotalindesserst_Click(object sender, EventArgs e)
        {

        }

        private void cncake_ValueChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
        }

        private void cnicecream_ValueChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
        }

        private void cndoughnuts_ValueChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
        }

        private void cnbrownies_ValueChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
        }

        private void cnfrozenyoughurt_ValueChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
        }

        private void cnwaffles_ValueChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
        }
    }
}
