using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace seniorproject
{
    public partial class Edit : Form
    {
        private int productID;
        private string productName;
        private string categoryName;
        private string productColor;
        private int locationID;
        private int productQuantity;
        InvManagement activeForm;
        public Edit(int ProdID, string ProdName, string CatName, string ProdColor, int LocID, int Quantity, InvManagement imgmt)
        {
            InitializeComponent();

            productID = ProdID;
            productName = ProdName;
            categoryName = CatName;
            productColor = ProdColor;
            locationID = LocID;
            productQuantity = Quantity;
            activeForm = imgmt;
        }

        private void nameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Edit_Load(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(InvManagement.connectionString))
                {
                    connection.Open();

                    int locID = int.Parse(locationIDBox.Text);


                    if (!string.IsNullOrWhiteSpace(nameBox.Text) || !string.IsNullOrWhiteSpace(colorBox.Text) || !string.IsNullOrWhiteSpace(categoryBox.Text) || !string.IsNullOrWhiteSpace(locationIDBox.Text))
                    {


                        // Check Category Object in Database for already existing objects with desired category name for editted product
                        string categoryCheckQuery = @"
                        SELECT CategoryID
                        FROM CATEGORY
                        WHERE CategoryName = @CategoryName";
                        using (SqlCommand checkCatCommand = new SqlCommand(categoryCheckQuery, connection))
                        {
                            checkCatCommand.Parameters.AddWithValue("@CategoryName", categoryBox.Text);

                            object result = checkCatCommand.ExecuteScalar(); // Checks if the category name already exists as a Category in the database

                            if (result != null) // if category does exist then it will update product with the according categoryID
                            {
                                int catID = Convert.ToInt32(result);
                                // UPDATE Product table
                                string updateProdQuery = @"
                                UPDATE PRODUCT
                                SET Description = @ProductName, CategoryID = @CategoryID, Color = @Color
                                WHERE ProductID = @ProductID";

                                using (SqlCommand cmdProduct = new SqlCommand(updateProdQuery, connection))
                                {
                                    cmdProduct.Parameters.AddWithValue("@ProductID", productID);
                                    cmdProduct.Parameters.AddWithValue("@ProductName", nameBox.Text);
                                    cmdProduct.Parameters.AddWithValue("@CategoryID", catID);
                                    cmdProduct.Parameters.AddWithValue("@Color", colorBox.Text);

                                    int rows = cmdProduct.ExecuteNonQuery();
                                }

                                // UPDATE INVENTORY table
                                string updateInventoryQuery = @"
                                UPDATE INVENTORY 
                                SET LocationID = @LocationID
                                WHERE ProductID = @ProductID AND Quantity = @Quantity";

                                using (SqlCommand cmdInventory = new SqlCommand(updateInventoryQuery, connection))
                                {
                                    cmdInventory.Parameters.AddWithValue("@ProductID", productID);
                                    cmdInventory.Parameters.AddWithValue("@LocationID", locID);
                                    cmdInventory.Parameters.AddWithValue("@Quantity", productQuantity);

                                    int rows = cmdInventory.ExecuteNonQuery();
                                    MessageBox.Show("Product updated successfully!");
                                    activeForm.refreshDGV();
                                    this.Close();
                                }
                            }
                            else // else it will insert a new category and will then update the product with the corresponding new categoryID
                            {
                                // Insert into CATEGORY table
                                string insertCategoryQuery = @"
                                INSERT INTO CATEGORY (CategoryName) 
                                VALUES (@CategoryName)";

                                using (SqlCommand cmdCategory = new SqlCommand(insertCategoryQuery, connection))
                                {
                                    cmdCategory.Parameters.AddWithValue("@CategoryName", categoryName);
                                    cmdCategory.ExecuteNonQuery();
                                }

                                // Get the CategoryID
                                string getCategoryIDQuery = "SELECT CategoryID FROM CATEGORY WHERE CategoryName = @CategoryName";
                                int catID;
                                using (SqlCommand cmdGetCategoryID = new SqlCommand(getCategoryIDQuery, connection))
                                {
                                    cmdGetCategoryID.Parameters.AddWithValue("@CategoryName", categoryName);
                                    catID = (int)cmdGetCategoryID.ExecuteScalar();
                                }

                                // Update Product Table
                                string updateProdQuery = @"
                                UPDATE PRODUCT
                                SET Description = @ProductName, CategoryID = @CategoryID, Color = @Color
                                WHERE ProductID = @ProductID";

                                using (SqlCommand cmdInventory = new SqlCommand(updateProdQuery, connection))
                                {
                                    cmdInventory.Parameters.AddWithValue("@ProductID", productID);
                                    cmdInventory.Parameters.AddWithValue("@ProductName", nameBox.Text);
                                    cmdInventory.Parameters.AddWithValue("@CategoryID", catID);
                                    cmdInventory.Parameters.AddWithValue("@Color", colorBox.Text);

                                    int rows = cmdInventory.ExecuteNonQuery();
                                }
                                // UPDATE INVENTORY table
                                string updateInventoryQuery = @"
                                UPDATE INVENTORY 
                                SET LocationID = @LocationID
                                WHERE ProductID = @ProductID AND Quantity = @Quantity";

                                using (SqlCommand cmdInventory = new SqlCommand(updateInventoryQuery, connection))
                                {
                                    cmdInventory.Parameters.AddWithValue("@ProductID", productID);
                                    cmdInventory.Parameters.AddWithValue("@LocationID", locID);
                                    cmdInventory.Parameters.AddWithValue("@Quantity", productQuantity);

                                    int rows = cmdInventory.ExecuteNonQuery();
                                    MessageBox.Show("Product updated successfully!");
                                    activeForm.refreshDGV();
                                    this.Close();
                                }
                            }
                        }
                    }
                    else
                        MessageBox.Show("Please enter information into each box. If nothing needs to be changed, please enter the same value into the corresponding box.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Insertion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(InvManagement.connectionString))
                {
                    connection.Open();
                    DialogResult confirmDeletion = MessageBox.Show($"Please confirm that you want to delete the product " + productName + " with Product ID {productID}", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (confirmDeletion == DialogResult.Yes)
                    {
                        string deleteProdOrderQuery = "DELETE FROM PRODUCT_ORDER WHERE ProductID = @ProductID";
                        using (SqlCommand command = new SqlCommand(deleteProdOrderQuery, connection))
                        {
                            command.Parameters.AddWithValue("@ProductID", productID);

                            int rowsAffected = command.ExecuteNonQuery();
                        }
                        string deleteProdSupplierQuery = "DELETE FROM PRODUCT_SUPPLIER WHERE ProductID = @ProductID";
                        using (SqlCommand command = new SqlCommand(deleteProdSupplierQuery, connection))
                        {
                            command.Parameters.AddWithValue("@ProductID", productID);

                            int rowsAffected = command.ExecuteNonQuery();
                        }
                        string deleteInvQuery = "DELETE FROM INVENTORY WHERE ProductID = @ProductID";
                        using (SqlCommand command = new SqlCommand(deleteInvQuery, connection))
                        {
                            command.Parameters.AddWithValue("@ProductID", productID);

                            int rowsAffected = command.ExecuteNonQuery();

                            
                        }
                        string deleteOrderQuery = "DELETE FROM [ORDER] WHERE ProductID = @ProductID";
                        using (SqlCommand command = new SqlCommand(deleteOrderQuery, connection))
                        {
                            command.Parameters.AddWithValue("@ProductID", productID);

                            int rowsAffected = command.ExecuteNonQuery();
                        }
                        string deleteProdQuery = "DELETE FROM PRODUCT WHERE ProductID = @ProductID";
                        using (SqlCommand command = new SqlCommand(deleteProdQuery, connection))
                        {
                            command.Parameters.AddWithValue("@ProductID", productID);

                            int rowsAffected = command.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Product deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                activeForm.refreshDGV();
                                this.Close();
                            }
                        }
                    }
                    else if (confirmDeletion == DialogResult.No)
                    {
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Insertion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
