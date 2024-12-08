using System.Data;

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
            this.components = new System.ComponentModel.Container();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.productView = new System.Windows.Forms.DataGridView();
            this.idNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodCat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodQuant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.restockButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.editButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.prodCatInvBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prodCatInv = new seniorproject.ProdCatInv();
            this.addButton = new System.Windows.Forms.Button();
            this.refreshData = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.productView)).BeginInit();
            this.SuspendLayout();
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(703, 14);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(117, 35);
            this.searchButton.TabIndex = 0;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // searchBox
            // 
            this.searchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox.Location = new System.Drawing.Point(39, 20);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(658, 22);
            this.searchBox.TabIndex = 1;
            this.searchBox.Text = "Search for item...";
            this.searchBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // productView
            // 
            this.productView.AutoGenerateColumns = false;
            this.productView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idNum,
            this.prodName,
            this.prodCat,
            this.prodColor,
            this.locationID,
            this.prodQuant,
            this.restockButton,
            this.editButton});
            this.productView.DataSource = this.prodCatInvBindingSource;
            this.productView.Location = new System.Drawing.Point(39, 97);
            this.productView.Name = "productView";
            this.productView.Size = new System.Drawing.Size(1094, 498);
            this.productView.TabIndex = 3;
            this.productView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idNum
            // 
            this.idNum.DataPropertyName = "ProductID";
            this.idNum.HeaderText = "ID";
            this.idNum.Name = "idNum";
            this.idNum.ReadOnly = true;
            this.idNum.Width = 50;
            // 
            // prodName
            // 
            this.prodName.DataPropertyName = "Description";
            this.prodName.HeaderText = "Product Name";
            this.prodName.Name = "prodName";
            this.prodName.ReadOnly = true;
            this.prodName.Width = 300;
            // 
            // prodCat
            // 
            this.prodCat.DataPropertyName = "CategoryName";
            this.prodCat.HeaderText = "Category Name";
            this.prodCat.Name = "prodCat";
            this.prodCat.ReadOnly = true;
            this.prodCat.Width = 200;
            // 
            // prodColor
            // 
            this.prodColor.DataPropertyName = "Color";
            this.prodColor.HeaderText = "Color";
            this.prodColor.Name = "prodColor";
            this.prodColor.ReadOnly = true;
            // 
            // locationID
            // 
            this.locationID.DataPropertyName = "LocationID";
            this.locationID.HeaderText = "Location ID";
            this.locationID.Name = "locationID";
            this.locationID.ReadOnly = true;
            // 
            // prodQuant
            // 
            this.prodQuant.DataPropertyName = "Quantity";
            this.prodQuant.HeaderText = "Quantity";
            this.prodQuant.Name = "prodQuant";
            this.prodQuant.ReadOnly = true;
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
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(80, 57);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(101, 34);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "Add Item";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.button2_Click);
            //
            // refreshData
            // 
            this.refreshData.Location = new System.Drawing.Point(895, 68);
            this.refreshData.Name = "refreshData";
            this.refreshData.Size = new System.Drawing.Size(75, 23);
            this.refreshData.TabIndex = 5;
            this.refreshData.Text = "Refresh";
            this.refreshData.UseVisualStyleBackColor = true;
            this.refreshData.Click += new System.EventHandler(this.refreshData_Click);
            // 
            // InvManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 612);
            this.Controls.Add(this.refreshData);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.productView);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.searchButton);
            this.Name = "InvManagement";
            this.Text = "Inventory Management System";
            this.Load += new System.EventHandler(this.LoadData);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchBox;
        public System.Windows.Forms.DataGridView productView;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.BindingSource prodCatInvBindingSource;
        private ProdCatInv prodCatInv;
        private System.Windows.Forms.Button refreshData;
        private System.Windows.Forms.DataGridViewTextBoxColumn idNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodName;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodCat;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodColor;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationID;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodQuant;
        private System.Windows.Forms.DataGridViewButtonColumn restockButton;
        private System.Windows.Forms.DataGridViewButtonColumn editButton;
    }
}

