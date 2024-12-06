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
            /*const string connectionString =
            "Data Source=DESKTOP-OSSQ7FV;" +
            "Initial Catalog=InvManagementSystem;" +
            "Integrated Security=True;";

            const string joinData = "SELECT p.ProductID, p.Description, cat.CategoryName, inv.Quantity FROM PRODUCT p INNER JOIN CATEGORY cat INNER JOIN INVENTORY inv ON p.ProductID=cat.ProductID=inv.ProductID";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                DataSet ds = new DataSet();
                SqlCommand cmd = new SqlCommand(joinData, connection);
                //SqlCommand cmd = connection.CreateCommand();
                //cmd.CommandText = "SELECT p.ProductID, p.Description, cat.CategoryName, inv.Quantity FROM PRODUCT AS p INNER JOIN CATEGORY AS cat ON p.CategoryID=cat.CategoryID INNER JOIN INVENTORY AS inv ON p.ProductID=inv.ProductID";
                try
                {
                    connection.Open();
                    SqlDataAdapter cmdadapt = new SqlDataAdapter(cmd);
                    cmdadapt.Fill(ds);

                    productView.DataSource = ds.Tables[0].DefaultView;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }*/
        }

        
        // *****NEED TO CHANGE DATA SOURCE TO THE LOCAL SERVER WHICH YOU ARE PULLING DATA, ALSO MAKE SURE THE INITIAL CATALOG MATCHES THE DATABASE ON THE LOCAL SERVER*****
        private const string connectionString = "Data Source=DESKTOP-OSSQ7FV;Initial Catalog=InvManagementSystem;Integrated Security=True;";

        /*private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'invManagementSystemDataSet2.CATEGORY' table. You can move, or remove it, as needed.
            //this.cATEGORYTableAdapter.Fill(this.invManagementSystemDataSet2.CATEGORY);
            // TODO: This line of code loads data into the 'invManagementSystemDataSet2.INVENTORY' table. You can move, or remove it, as needed.
            //this.iNVENTORYTableAdapter.Fill(this.invManagementSystemDataSet2.INVENTORY);
            //TODO: This line of code loads data into the 'invManagementSystemDataSet2.PRODUCT' table. You can move, or remove it, as needed.
            //this.pRODUCTTableAdapter3.Fill(this.invManagementSystemDataSet2.PRODUCT);
            // TODO: This line of code loads data into the 'invManagementSystemDataSet.PRODUCT' table. You can move, or remove it, as needed.
            //this.pRODUCTTableAdapter.Fill(this.invManagementSystemDataSet.PRODUCT);

        }*/

        private void LoadData(object sender, EventArgs e) //Queries database for 
        {
            try
            {
                // SQL query joining Product, Category, and Inventory tables
                string query = @"
                    SELECT p.ProductID, p.Description, c.CategoryName, i.Quantity
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

        private void button1_Click(object sender, EventArgs e)
        {

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
                if (e.ColumnIndex == 4)
                {
                    Restock stockItem = new Restock();
                    stockItem.Show();

                }
                else if (e.ColumnIndex == 5)
                {
                    Edit editItem = new Edit();
                    editItem.Show();
                }
            }
            else if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                Edit editItem = new Edit();
                editItem.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Add addItem = new Add();
            addItem.Show();
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.pRODUCTTableAdapter3.FillBy(this.invManagementSystemDataSet2.PRODUCT);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
