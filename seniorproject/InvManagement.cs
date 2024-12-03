using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace seniorproject
{
    public partial class InvManagement : Form
    {
        public InvManagement()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
    }
}
