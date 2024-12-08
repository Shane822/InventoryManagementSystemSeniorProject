using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace seniorproject
{
    public partial class Add : Form
    {
        private readonly InvManagement activeForm;
        public Add(InvManagement imgmt)
        {
            InitializeComponent();

            activeForm = imgmt;
        }

        private void nameBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            // Get input from text boxes
            // string productIDText = idNumBox.Text;      
            string description = nameBox.Text;   
            string quantityText = quantBox.Text;     
            string categoryName = categoryBox.Text;
            string prodColor = colorBox.Text;
            string locationIDText = locationBox.Text;
            string supplierIDText = supplierIDBox.Text;

            // Convert productID to integer
            /*if (!int.TryParse(productIDText, out int productID))
            {
                MessageBox.Show("Incorrect ID format. Please use a ");
                return;
            }*/

            // Convert quantity to integer
            if (!int.TryParse(quantityText, out int quantity))
            {
                MessageBox.Show("Incorrect quantity format. Please use a number");
                return;
            }
            // Convert locationID to integer
            if (!int.TryParse(locationIDText, out int locationID))
            {
                MessageBox.Show("Incorrect ID format. Please use a number");
                return;
            }// Convert supplierID to integer
            if (!int.TryParse(supplierIDText, out int supplierID))
            {
                MessageBox.Show("Incorrect ID format. Please use a number");
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(InvManagement.connectionString))
                {
                    connection.Open();

                    // Insert into CATEGORY table if it doesn't already exist
                    string insertCategoryQuery = @"
                        IF NOT EXISTS (SELECT 1 FROM CATEGORY WHERE CategoryName = @CategoryName)
                        INSERT INTO CATEGORY (CategoryName) VALUES (@CategoryName)";

                    using (SqlCommand cmdCategory = new SqlCommand(insertCategoryQuery, connection))
                    {
                        cmdCategory.Parameters.AddWithValue("@CategoryName", categoryName);
                        cmdCategory.ExecuteNonQuery();
                    }

                    // Get the CategoryID
                    string getCategoryIDQuery = "SELECT CategoryID FROM CATEGORY WHERE CategoryName = @CategoryName";
                    int categoryID;
                    using (SqlCommand cmdGetCategoryID = new SqlCommand(getCategoryIDQuery, connection))
                    {
                        cmdGetCategoryID.Parameters.AddWithValue("@CategoryName", categoryName);
                        categoryID = (int)cmdGetCategoryID.ExecuteScalar();
                    }

                    // Insert into PRODUCT table
                    string insertProductQuery = @"
                        INSERT INTO PRODUCT (CategoryID, SupplierID, Description, Color) 
                        VALUES (@CategoryID, @SupplierID, @Description, @prodColor)";

                    using (SqlCommand cmdProduct = new SqlCommand(insertProductQuery, connection))
                    {
                        cmdProduct.Parameters.AddWithValue("@CategoryID", categoryID);
                        cmdProduct.Parameters.AddWithValue("@SupplierID", supplierID);
                        cmdProduct.Parameters.AddWithValue("@Description", description);
                        cmdProduct.Parameters.AddWithValue("@prodColor", prodColor);
                        cmdProduct.ExecuteNonQuery();
                    }
                    
                    string getProductIDQuery = "SELECT ProductID FROM PRODUCT WHERE Description = @Description";
                    int tempProdID;
                    using (SqlCommand cmdGetProductID = new SqlCommand(getProductIDQuery, connection))
                    {
                        cmdGetProductID.Parameters.AddWithValue("@Description", description);
                        tempProdID = (int)cmdGetProductID.ExecuteScalar();
                    }

                    // INSERT into INVENTORY table
                    string insertInventoryQuery = @"
                        INSERT INTO INVENTORY (ProductID, LocationID, Quantity) 
                        VALUES (@ProductID, @LocationID, @Quantity)";

                    using (SqlCommand cmdProduct = new SqlCommand(insertInventoryQuery, connection))
                    {
                        cmdProduct.Parameters.AddWithValue("@ProductID", tempProdID);
                        cmdProduct.Parameters.AddWithValue("@LocationID", locationID);
                        cmdProduct.Parameters.AddWithValue("@Quantity", quantity);
                        cmdProduct.ExecuteNonQuery();
                    }
                    // Optional: Feedback to the user
                    MessageBox.Show("Product data inserted successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Insertion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnSave_Click(sender, e);
            activeForm.refreshDGV();
            this.Close();
        }

        private void Add_Load(object sender, EventArgs e)
        {

        }
    }
}
