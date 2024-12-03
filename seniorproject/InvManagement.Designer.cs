namespace seniorproject
{
    partial class InvManagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.idNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodCat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodQuant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.restockButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.editButton = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(703, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(39, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(658, 22);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Search for item...";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idNum,
            this.prodName,
            this.prodCat,
            this.prodQuant,
            this.restockButton,
            this.editButton});
            this.dataGridView1.Location = new System.Drawing.Point(39, 106);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(893, 451);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(80, 57);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 34);
            this.button2.TabIndex = 4;
            this.button2.Text = "Add Item";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // idNum
            // 
            this.idNum.HeaderText = "ID";
            this.idNum.Name = "idNum";
            // 
            // prodName
            // 
            this.prodName.HeaderText = "Product Name";
            this.prodName.Name = "prodName";
            this.prodName.Width = 300;
            // 
            // prodCat
            // 
            this.prodCat.HeaderText = "Category";
            this.prodCat.Name = "prodCat";
            this.prodCat.Width = 150;
            // 
            // prodQuant
            // 
            this.prodQuant.HeaderText = "Quantity";
            this.prodQuant.Name = "prodQuant";
            // 
            // restockButton
            // 
            this.restockButton.HeaderText = "Restock";
            this.restockButton.Name = "restockButton";
            this.restockButton.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.restockButton.Text = "Restock";
            this.restockButton.ToolTipText = "restock";
            this.restockButton.UseColumnTextForButtonValue = true;
            // 
            // editButton
            // 
            this.editButton.HeaderText = "Edit";
            this.editButton.Name = "editButton";
            this.editButton.Text = "Edit";
            this.editButton.UseColumnTextForButtonValue = true;
            // 
            // InvManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 573);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "InvManagement";
            this.Text = "Inventory Management System";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodName;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodCat;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodQuant;
        private System.Windows.Forms.DataGridViewButtonColumn restockButton;
        private System.Windows.Forms.DataGridViewButtonColumn editButton;
    }
}

