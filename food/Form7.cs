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
    public partial class frmdrinks : Form
    {
        Dictionary<string, decimal> itemPrices = new Dictionary<string, decimal>();
        decimal totalPrice = 0;
        public frmdrinks()
        {
            InitializeComponent();
            Load += new System.EventHandler(frmdrinks_Load);
        }
        private void frmdrinks_Load(object sender, EventArgs e)
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
                string query = "SELECT drinkname, price FROM drinks";
                SqlCommand cmd = new SqlCommand(query, conn);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        itemPrices[reader["drinkname"].ToString()] = Convert.ToDecimal(reader["price"]);
                    }
                }
            }
        }
        private void DisplayPricesOnForm()
        {
            lblpriceofmojito.Text = itemPrices.ContainsKey("Mojito") ? "Rs."+itemPrices["Mojito"].ToString() : "Rs.0.00";
            lblpriceoforangejuice.Text = itemPrices.ContainsKey("Orange Juice") ? "Rs."+itemPrices["Orange Juice"].ToString() : "Rs.0.00";
            lblpriceofcocacola.Text = itemPrices.ContainsKey("Coca Cola") ? "Rs." +itemPrices["Coca Cola"].ToString() : "Rs.0.00";
            lblpriceoficedcoffee.Text = itemPrices.ContainsKey("Iced Coffee") ? "Rs." +itemPrices["Iced Coffee"].ToString() : "Rs.0.00";
            lblpriceofsprite.Text = itemPrices.ContainsKey("Sprite") ? "Rs." +itemPrices["Sprite"].ToString() : "0.00";
            lblpriceofmilkshake.Text = itemPrices.ContainsKey("Milkshake") ? "Rs." +itemPrices["Milkshake"].ToString() : "Rs.0.00";
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            frmmeals f1 = new frmmeals();
            f1.Show();
            Close();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            frmdesserts d1 = new frmdesserts();
            d1.Show();
            Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
        private void UpdateTotalPrice()
        {
            totalPrice = 0;

            // Add up the prices based on the numeric up-down values            // Calculate total based on numeric up-down values and item prices
            totalPrice += (decimal)cnmojito.Value * itemPrices["Mojito"];
            totalPrice += (decimal)cnorangejuice.Value * itemPrices["Orange Juice"];
            totalPrice += (decimal)cncocacola.Value * itemPrices["Coca Cola"];
            totalPrice += (decimal)cnicedcoffee.Value * itemPrices["Iced Coffee"];
            totalPrice += (decimal)cnsprite.Value * itemPrices["Sprite"];
            totalPrice += (decimal)cnmilkshake.Value * itemPrices["Milkshake"];

            lbltotlindrinks.Text = "Total: Rs. " + totalPrice.ToString(); // Update the total price label
            Globals.TotalAmount = totalPrice;

            Globals.FoodItems.Clear();
            if (cnmojito.Value > 0)
                Globals.FoodItems.Add(("Mojito", itemPrices["Mojito"], (int)cnmojito.Value));
            if (cnorangejuice.Value > 0)
                Globals.FoodItems.Add(("Orange Juice", itemPrices["Orange Juice"], (int)cnorangejuice.Value));
            if (cncocacola.Value > 0)
                Globals.FoodItems.Add(("Coca Cola", itemPrices["Coca Cola"], (int)cncocacola.Value));
            if (cnicedcoffee.Value > 0)
                Globals.FoodItems.Add(("Iced Coffee", itemPrices["Iced Coffee"], (int)cnicedcoffee.Value));
            if (cnsprite.Value > 0)
                Globals.FoodItems.Add(("Sprite", itemPrices["Sprite"], (int)cnsprite.Value));
            if (cnmilkshake.Value > 0)
                Globals.FoodItems.Add(("Milkshake", itemPrices["Milkshake"], (int)cnmilkshake.Value));

        }

        private void btnorderindrinks_Click(object sender, EventArgs e)
        {
            frmpayment v1 = new frmpayment();
            v1.Show();
            this.Hide();
        }

        
        public static class Globals
        {
            public static decimal TotalAmount { get; set; } = 0;
            public static List<(string FoodName, decimal Price, int Quantity)> FoodItems { get; set; } = new List<(string, decimal, int)>();
        }

        private void btnbackindrinks_Click(object sender, EventArgs e)
        {
            frmmenu f3 = new frmmenu();
            f3.Show();
            Hide();
        }

        private void lblpriceofmojito_Click(object sender, EventArgs e)
        {

        }

        private void cnmojito_ValueChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
        }

        private void cnorangejuice_ValueChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
        }

        private void cncocacola_ValueChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
        }

        private void cnicedcoffee_ValueChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
        }

        private void cnsprite_ValueChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
        }

        private void cnmilkshake_ValueChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
        }
    }
}
