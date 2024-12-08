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

namespace seniorproject
{
    public partial class InvManagement : Form
    {
        public InvManagement()
        {
            InitializeComponent();
            
        }

        
        // *****NEED TO CHANGE DATA SOURCE TO THE LOCAL SERVER WHICH YOU ARE PULLING DATA, ALSO MAKE SURE THE INITIAL CATALOG MATCHES THE DATABASE ON THE LOCAL SERVER*****
        public const string connectionString = "Data Source=DESKTOP-OSSQ7FV;Initial Catalog=InvManagementSystem;Integrated Security=True;";

        

        private void LoadData(object sender, EventArgs e) //fills the datagridview with all the products available
        {
            try
            {
                // SQL query joining Product, Category, and Inventory tables
                string query = @"
                    SELECT p.ProductID, i.LocationID, p.Color, p.Description, c.CategoryName, i.Quantity
                    FROM Product p
                    INNER JOIN Category c ON c.CategoryID = p.CategoryID
                    INNER JOIN Inventory i ON p.ProductID = i.ProductID";

                // Using SqlConnection to connect to the database
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // SqlDataAdapter to fetch data based on the query
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();

                    // Fill the DataTable with the results
                    adapter.Fill(dataTable);

                    // Bind the DataTable to the DataGridView
                    productView.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Data Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e) // searches the database for matching products to wanted query by user
        {
            string searchQuery = searchBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(searchQuery))
            {
                MessageBox.Show("Please enter something to search.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // SQL query to search for products with similar descriptions
                    string query = @"
                    SELECT 
                        ProductID, 
                        CategoryID, 
                        SupplierID, 
                        Description, 
                        Color 
                    FROM PRODUCT
                    WHERE Description LIKE @SearchQuery";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Use a parameterized query to prevent SQL injection
                        command.Parameters.AddWithValue("@SearchQuery", "%" + searchQuery + "%");

                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            // Fill a DataTable with the search results
                            DataTable searchResults = new DataTable();
                            adapter.Fill(searchResults);

                            // Bind the DataTable to the DataGridView
                            productView.DataSource = searchResults;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while searching: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                if (e.ColumnIndex == 6)
                {
                    string id = productView.Rows[e.RowIndex].Cells["idNum"].Value.ToString(); //Pulling productID from the productView
                    int idInt = Convert.ToInt32(id); //converting id to int
                    string locID = productView.Rows[e.RowIndex].Cells["locationID"].Value.ToString(); //Pulling locationID from the productView
                    int locIDInt = Convert.ToInt32(locID); //converting locID to int
                    Restock stockItem = new Restock(idInt, locIDInt, this);
                    stockItem.Show();
                }
                else if (e.ColumnIndex == 7)
                {
                    string pName = productView.Rows[e.RowIndex].Cells["prodName"].Value.ToString(); //Pulling productName from the productView
                    string cName = productView.Rows[e.RowIndex].Cells["prodCat"].Value.ToString(); //Pulling categoryName from the productView
                    string pColor = productView.Rows[e.RowIndex].Cells["prodColor"].Value.ToString(); //Pulling productColor from the productView
                    string quant = productView.Rows[e.RowIndex].Cells["prodQuant"].Value.ToString(); //Pulling productQuantity from the productView
                    int pQuant = Convert.ToInt32(quant);
                    string id = productView.Rows[e.RowIndex].Cells["idNum"].Value.ToString(); //Pulling productID from the productView
                    int idInt = Convert.ToInt32(id); //converting id to int
                    string locID = productView.Rows[e.RowIndex].Cells["locationID"].Value.ToString(); //Pulling locationID from the productView
                    int locIDInt = Convert.ToInt32(locID); //converting locID to int
                    Edit editItem = new Edit(idInt, pName, cName, pColor, locIDInt, pQuant, this);
                    editItem.Show();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e) //opens up the Add Item window
        {
            Add addItem = new Add(this);
            addItem.Show();
        }

        public void refreshDGV() //refreshes the datagridview to default to display all products available
        {
            try
            {
                // SQL query joining Product, Category, and Inventory tables
                string query = @"
                    SELECT p.ProductID, i.LocationID, p.Color, p.Description, c.CategoryName, i.Quantity
                    FROM Product p
                    INNER JOIN Category c ON c.CategoryID = p.CategoryID
                    INNER JOIN Inventory i ON p.ProductID = i.ProductID";

                // Using SqlConnection to connect to the database
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // SqlDataAdapter to fetch data based on the query
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();

                    // Fill the DataTable with the results
                    adapter.Fill(dataTable);

                    // Bind the DataTable to the DataGridView
                    productView.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Data Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void refreshData_Click(object sender, EventArgs e) //button to refresh the datagridview
        {
            refreshDGV();
        }
    }
}
