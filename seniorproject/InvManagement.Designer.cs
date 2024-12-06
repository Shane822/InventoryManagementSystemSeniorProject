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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.productView = new System.Windows.Forms.DataGridView();
            this.prodCatInvBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prodCatInv = new seniorproject.ProdCatInv();
            this.invManagementSystemDataSet2BindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.invManagementSystemDataSet2 = new seniorproject.InvManagementSystemDataSet2();
            this.button2 = new System.Windows.Forms.Button();
            this.invManagementSystemDataSet = new seniorproject.InvManagementSystemDataSet();
            this.invManagementSystemDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pRODUCTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pRODUCTTableAdapter = new seniorproject.InvManagementSystemDataSetTableAdapters.PRODUCTTableAdapter();
            this.productTableAdapter1 = new seniorproject.InvManagementSystemDataSet1TableAdapters.PRODUCTTableAdapter();
            this.productTableAdapter2 = new seniorproject.InvManagementSystemDataSet1TableAdapters.PRODUCTTableAdapter();
            this.iNVENTORYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.invManagementSystemDataSet2BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.invManagementSystemDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pRODUCTBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pRODUCTTableAdapter3 = new seniorproject.InvManagementSystemDataSet2TableAdapters.PRODUCTTableAdapter();
            this.iNVENTORYTableAdapter = new seniorproject.InvManagementSystemDataSet2TableAdapters.INVENTORYTableAdapter();
            this.invManagementSystemDataSet21 = new seniorproject.InvManagementSystemDataSet2();
            this.invManagementSystemDataSet22 = new seniorproject.InvManagementSystemDataSet2();
            this.cATEGORYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cATEGORYTableAdapter = new seniorproject.InvManagementSystemDataSet2TableAdapters.CATEGORYTableAdapter();
            this.pRODUCTBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.pRODUCTBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.pRODUCTBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.invManagementSystemDataSet2BindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.idNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodCat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodQuant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.restockButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.editButton = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.productView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodCatInvBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodCatInv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invManagementSystemDataSet2BindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invManagementSystemDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invManagementSystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invManagementSystemDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNVENTORYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invManagementSystemDataSet2BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invManagementSystemDataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invManagementSystemDataSet21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invManagementSystemDataSet22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cATEGORYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invManagementSystemDataSet2BindingSource3)).BeginInit();
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
            // productView
            // 
            this.productView.AutoGenerateColumns = false;
            this.productView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idNum,
            this.prodName,
            this.prodCat,
            this.prodQuant,
            this.restockButton,
            this.editButton});
            this.productView.DataSource = this.prodCatInvBindingSource;
            this.productView.Location = new System.Drawing.Point(39, 97);
            this.productView.Name = "productView";
            this.productView.Size = new System.Drawing.Size(931, 455);
            this.productView.TabIndex = 3;
            this.productView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // prodCatInvBindingSource
            // 
            this.prodCatInvBindingSource.DataSource = this.prodCatInv;
            this.prodCatInvBindingSource.Position = 0;
            // 
            // prodCatInv
            // 
            this.prodCatInv.DataSetName = "ProdCatInv";
            this.prodCatInv.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // invManagementSystemDataSet2BindingSource2
            // 
            this.invManagementSystemDataSet2BindingSource2.DataSource = this.invManagementSystemDataSet2;
            this.invManagementSystemDataSet2BindingSource2.Position = 0;
            // 
            // invManagementSystemDataSet2
            // 
            this.invManagementSystemDataSet2.DataSetName = "InvManagementSystemDataSet2";
            this.invManagementSystemDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // invManagementSystemDataSet
            // 
            this.invManagementSystemDataSet.DataSetName = "InvManagementSystemDataSet";
            this.invManagementSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // invManagementSystemDataSetBindingSource
            // 
            this.invManagementSystemDataSetBindingSource.DataSource = this.invManagementSystemDataSet;
            this.invManagementSystemDataSetBindingSource.Position = 0;
            // 
            // pRODUCTBindingSource
            // 
            this.pRODUCTBindingSource.DataMember = "PRODUCT";
            this.pRODUCTBindingSource.DataSource = this.invManagementSystemDataSetBindingSource;
            // 
            // pRODUCTTableAdapter
            // 
            this.pRODUCTTableAdapter.ClearBeforeFill = true;
            // 
            // productTableAdapter1
            // 
            this.productTableAdapter1.ClearBeforeFill = true;
            // 
            // productTableAdapter2
            // 
            this.productTableAdapter2.ClearBeforeFill = true;
            // 
            // iNVENTORYBindingSource
            // 
            this.iNVENTORYBindingSource.DataMember = "INVENTORY";
            this.iNVENTORYBindingSource.DataSource = this.invManagementSystemDataSet2BindingSource1;
            // 
            // invManagementSystemDataSet2BindingSource1
            // 
            this.invManagementSystemDataSet2BindingSource1.DataSource = this.invManagementSystemDataSet2;
            this.invManagementSystemDataSet2BindingSource1.Position = 0;
            // 
            // invManagementSystemDataSet2BindingSource
            // 
            this.invManagementSystemDataSet2BindingSource.DataSource = this.invManagementSystemDataSet2;
            this.invManagementSystemDataSet2BindingSource.Position = 0;
            // 
            // pRODUCTBindingSource1
            // 
            this.pRODUCTBindingSource1.DataMember = "PRODUCT";
            this.pRODUCTBindingSource1.DataSource = this.invManagementSystemDataSet2;
            // 
            // pRODUCTTableAdapter3
            // 
            this.pRODUCTTableAdapter3.ClearBeforeFill = true;
            // 
            // iNVENTORYTableAdapter
            // 
            this.iNVENTORYTableAdapter.ClearBeforeFill = true;
            // 
            // invManagementSystemDataSet21
            // 
            this.invManagementSystemDataSet21.DataSetName = "InvManagementSystemDataSet2";
            this.invManagementSystemDataSet21.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // invManagementSystemDataSet22
            // 
            this.invManagementSystemDataSet22.DataSetName = "InvManagementSystemDataSet2";
            this.invManagementSystemDataSet22.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cATEGORYBindingSource
            // 
            this.cATEGORYBindingSource.DataMember = "CATEGORY";
            this.cATEGORYBindingSource.DataSource = this.invManagementSystemDataSet2BindingSource1;
            // 
            // cATEGORYTableAdapter
            // 
            this.cATEGORYTableAdapter.ClearBeforeFill = true;
            // 
            // pRODUCTBindingSource2
            // 
            this.pRODUCTBindingSource2.DataMember = "PRODUCT";
            this.pRODUCTBindingSource2.DataSource = this.invManagementSystemDataSet2BindingSource;
            // 
            // pRODUCTBindingSource3
            // 
            this.pRODUCTBindingSource3.DataMember = "PRODUCT";
            this.pRODUCTBindingSource3.DataSource = this.invManagementSystemDataSet2;
            // 
            // pRODUCTBindingSource4
            // 
            this.pRODUCTBindingSource4.DataMember = "PRODUCT";
            this.pRODUCTBindingSource4.DataSource = this.invManagementSystemDataSet2BindingSource;
            // 
            // invManagementSystemDataSet2BindingSource3
            // 
            this.invManagementSystemDataSet2BindingSource3.DataSource = this.invManagementSystemDataSet2;
            this.invManagementSystemDataSet2BindingSource3.Position = 0;
            // 
            // idNum
            // 
            this.idNum.DataPropertyName = "ProductID";
            this.idNum.HeaderText = "ID";
            this.idNum.Name = "idNum";
            this.idNum.ReadOnly = true;
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
            // InvManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 573);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.productView);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "InvManagement";
            this.Text = "Inventory Management System";
            this.Load += new System.EventHandler(this.LoadData);
            ((System.ComponentModel.ISupportInitialize)(this.productView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodCatInvBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodCatInv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invManagementSystemDataSet2BindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invManagementSystemDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invManagementSystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invManagementSystemDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNVENTORYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invManagementSystemDataSet2BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invManagementSystemDataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invManagementSystemDataSet21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invManagementSystemDataSet22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cATEGORYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invManagementSystemDataSet2BindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView productView;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource invManagementSystemDataSetBindingSource;
        private InvManagementSystemDataSet invManagementSystemDataSet;
        private System.Windows.Forms.BindingSource pRODUCTBindingSource;
        private InvManagementSystemDataSetTableAdapters.PRODUCTTableAdapter pRODUCTTableAdapter;
        private InvManagementSystemDataSet1TableAdapters.PRODUCTTableAdapter productTableAdapter1;
        private InvManagementSystemDataSet1TableAdapters.PRODUCTTableAdapter productTableAdapter2;
        private InvManagementSystemDataSet2 invManagementSystemDataSet2;
        private System.Windows.Forms.BindingSource invManagementSystemDataSet2BindingSource;
        private System.Windows.Forms.BindingSource invManagementSystemDataSet2BindingSource1;
        private System.Windows.Forms.BindingSource pRODUCTBindingSource1;
        private InvManagementSystemDataSet2TableAdapters.PRODUCTTableAdapter pRODUCTTableAdapter3;
        private System.Windows.Forms.BindingSource iNVENTORYBindingSource;
        private InvManagementSystemDataSet2TableAdapters.INVENTORYTableAdapter iNVENTORYTableAdapter;
        private InvManagementSystemDataSet2 invManagementSystemDataSet21;
        private System.Windows.Forms.BindingSource invManagementSystemDataSet2BindingSource2;
        public InvManagementSystemDataSet2 invManagementSystemDataSet22;
        private System.Windows.Forms.BindingSource cATEGORYBindingSource;
        private InvManagementSystemDataSet2TableAdapters.CATEGORYTableAdapter cATEGORYTableAdapter;
        private System.Windows.Forms.BindingSource pRODUCTBindingSource2;
        private System.Windows.Forms.BindingSource pRODUCTBindingSource3;
        private System.Windows.Forms.BindingSource invManagementSystemDataSet2BindingSource3;
        private System.Windows.Forms.BindingSource pRODUCTBindingSource4;
        private System.Windows.Forms.BindingSource prodCatInvBindingSource;
        private ProdCatInv prodCatInv;
        private System.Windows.Forms.DataGridViewTextBoxColumn idNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodName;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodCat;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodQuant;
        private System.Windows.Forms.DataGridViewButtonColumn restockButton;
        private System.Windows.Forms.DataGridViewButtonColumn editButton;
    }
}

