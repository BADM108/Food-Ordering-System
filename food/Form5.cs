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
    public partial class frmmeals : Form
    {
        Dictionary<string, decimal> itemPrices = new Dictionary<string, decimal>();
        decimal totalPrice = 0;
        public frmmeals()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.frmmeals_Load);

        }
        private void frmmeals_Load(object sender, EventArgs e)
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
                string query = "SELECT foodname, price FROM meals";
                SqlCommand cmd = new SqlCommand(query, conn);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        itemPrices[reader["foodname"].ToString()] = Convert.ToDecimal(reader["price"]);
                    }
                }
            }
        }
        private void DisplayPricesOnForm()
        {
            lblpriceofmojito.Text = itemPrices.ContainsKey("Chicken Burger") ? "Rs." +itemPrices["Chicken Burger"].ToString() : "Rs.0.00";
            lblpriceofsandwitch.Text = itemPrices.ContainsKey("Sandwitch") ? "Rs." +itemPrices["Sandwitch"].ToString() : "Rs.0.00";
            lblpriceofpizza.Text = itemPrices.ContainsKey("Pizza") ? "Rs." +itemPrices["Pizza"].ToString() : "Rs.0.00";
            lblpriceofhotdog.Text = itemPrices.ContainsKey("Hot Dog") ? "Rs." +itemPrices["Hot Dog"].ToString() : "Rs.0.00";
            lblpriceofchickennuggets.Text = itemPrices.ContainsKey("Chicken Nuggets") ? "Rs." +itemPrices["Chicken Nuggets"].ToString() : "0.00";
            lblpriceoffrenchfries.Text = itemPrices.ContainsKey("French Fries") ? "Rs." +itemPrices["French Fries"].ToString() : "Rs.0.00";
        }
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            frmdesserts b1 = new frmdesserts();
            b1.Show();
            this.Hide();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            frmdrinks c1 = new frmdrinks();
            c1.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void nupchickenburgerinmeals_ValueChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
        }

        private void btnorder1_Click(object sender, EventArgs e)
        {
            frmpayment v1 = new frmpayment();
            v1.Show();
            this.Hide();
        }
        private void UpdateTotalPrice()
        {
            totalPrice = 0;

            // Add up the prices based on the numeric up-down values            // Calculate total based on numeric up-down values and item prices
            totalPrice += (decimal)cnchickenburger.Value * itemPrices["Chicken Burger"];
            totalPrice += (decimal)cnsandwitch.Value * itemPrices["Sandwitch"];
            totalPrice += (decimal)cnpizza.Value * itemPrices["Pizza"];
            totalPrice += (decimal)cnhotdog.Value * itemPrices["Hot Dog"];
            totalPrice += (decimal)cnchickennuggets.Value * itemPrices["Chicken Nuggets"];
            totalPrice += (decimal)cnfrenchfries.Value * itemPrices["French Fries"];
      
            lbltotalinmeals .Text = "Total: Rs." + totalPrice.ToString(); // Update the total price label


            Globals.TotalAmount = totalPrice;

            Globals.FoodItems.Clear();
            if (cnchickenburger.Value > 0)
                Globals.FoodItems.Add(("Chicken Burger", itemPrices["Chicken Burger"], (int)cnchickenburger.Value));
            if (cnsandwitch.Value > 0)
                Globals.FoodItems.Add(("Sandwitch", itemPrices["Sandwitch"], (int)cnsandwitch.Value));
            if (cnpizza.Value > 0)
                Globals.FoodItems.Add(("Pizza", itemPrices["Pizza"], (int)cnpizza.Value));
            if (cnhotdog.Value > 0)
                Globals.FoodItems.Add(("Hot Dog", itemPrices["Hot Dog"], (int)cnhotdog.Value));
            if (cnchickennuggets.Value > 0)
                Globals.FoodItems.Add(("Chicken Nuggets", itemPrices["Chicken Nuggets"], (int)cnchickennuggets.Value));
            if (cnfrenchfries.Value > 0)
                Globals.FoodItems.Add(("French Fries", itemPrices["French Fries"], (int)cnfrenchfries.Value));
            
        }
        public static class Globals
        {
            public static decimal TotalAmount { get; set; } = 0;
            public static List<(string FoodName, decimal Price, int Quantity)> FoodItems { get; set; } = new List<(string, decimal, int)>();

            
        }

        private void btnbackinmeals_Click(object sender, EventArgs e)
        {
            frmmenu f1 = new frmmenu();
            f1.Show();
            this.Hide();
        }

        private void cnsandwitch_ValueChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
        }

        private void cnpizza_ValueChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
        }

        private void cnhotdog_ValueChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
        }

        private void cnchickennuggets_ValueChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
        }

        private void cnfrenchfries_ValueChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
        }

        private void btnmealsinmeals_Click(object sender, EventArgs e)
        {
            frmmeals f1 = new frmmeals();
            f1.Show();
            this.Hide();
        }

        private void lblpriceofsandwitch_Click(object sender, EventArgs e)
        {

        }
    }
}
