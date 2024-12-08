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

namespace seniorproject
{
    public partial class Restock : Form
    {
        private int prodID;
        private int locID;
        private readonly InvManagement activeForm;
        public Restock(int ProductID, int LocationID, InvManagement imgmt)
        {
            InitializeComponent();

            prodID = ProductID;
            locID = LocationID;
            activeForm = imgmt;
        }

        
        private void Restock_Load(object sender, EventArgs e)
        {

        }

        private void amountTracker_Scroll(object sender, EventArgs e)
        {
            amountBox.Text = amountTracker.Value.ToString();
        }

        private void amountBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int x = 0;
                if (Int32.TryParse(amountBox.Text, out x))
                {
                    amountTracker.Value = x;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Too large of value. Please enter value below 10,000", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(InvManagement.connectionString))
                {
                    connection.Open();
                    // UPDATE INVENTORY table
                    string updateInventoryQuery = @"
                        UPDATE INVENTORY 
                        SET Quantity = @Quantity
                        WHERE ProductID = @ProductID AND LocationID = @LocationID";
                       // VALUES (@ProductID, @LocationID, @Quantity)";

                    using (SqlCommand cmdInventory = new SqlCommand(updateInventoryQuery, connection))
                    {
                        cmdInventory.Parameters.AddWithValue("@ProductID", prodID);
                        cmdInventory.Parameters.AddWithValue("@LocationID", locID);
                        cmdInventory.Parameters.AddWithValue("@Quantity", amountTracker.Value);

                        int rows = cmdInventory.ExecuteNonQuery();
                        if (rows > 0)
                        {
                            MessageBox.Show("Inventory data updated successfully!");
                            activeForm.refreshDGV();
                            this.Close();
                        }
                        else
                            MessageBox.Show("No inventory exists for this item");
                            
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Insertion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
