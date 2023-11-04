namespace C968_Inventory_System
{
    partial class Form1
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
            this.btnAddPart = new System.Windows.Forms.Button();
            this.btnModifyPart = new System.Windows.Forms.Button();
            this.btnDeletePart = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnModifyProduct = new System.Windows.Forms.Button();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.btnExitApp = new System.Windows.Forms.Button();
            this.btnSearchPart = new System.Windows.Forms.Button();
            this.btnSearchProduct = new System.Windows.Forms.Button();
            this.partView = new System.Windows.Forms.DataGridView();
            this.productView = new System.Windows.Forms.DataGridView();
            this.partSearch = new System.Windows.Forms.TextBox();
            this.productSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PartID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmInventory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProdName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProdInventory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProdPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProdMin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProdMax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.partView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddPart
            // 
            this.btnAddPart.Location = new System.Drawing.Point(298, 327);
            this.btnAddPart.Name = "btnAddPart";
            this.btnAddPart.Size = new System.Drawing.Size(53, 31);
            this.btnAddPart.TabIndex = 0;
            this.btnAddPart.Text = "Add";
            this.btnAddPart.UseVisualStyleBackColor = true;
            this.btnAddPart.Click += new System.EventHandler(this.btnAddPart_Click);
            // 
            // btnModifyPart
            // 
            this.btnModifyPart.Location = new System.Drawing.Point(357, 327);
            this.btnModifyPart.Name = "btnModifyPart";
            this.btnModifyPart.Size = new System.Drawing.Size(53, 31);
            this.btnModifyPart.TabIndex = 1;
            this.btnModifyPart.Text = "Modify";
            this.btnModifyPart.UseVisualStyleBackColor = true;
            this.btnModifyPart.Click += new System.EventHandler(this.btnModifyPart_Click);
            // 
            // btnDeletePart
            // 
            this.btnDeletePart.Location = new System.Drawing.Point(416, 327);
            this.btnDeletePart.Name = "btnDeletePart";
            this.btnDeletePart.Size = new System.Drawing.Size(53, 31);
            this.btnDeletePart.TabIndex = 2;
            this.btnDeletePart.Text = "Delete";
            this.btnDeletePart.UseVisualStyleBackColor = true;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(823, 327);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(53, 31);
            this.btnAddProduct.TabIndex = 3;
            this.btnAddProduct.Text = "Add";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            // 
            // btnModifyProduct
            // 
            this.btnModifyProduct.Location = new System.Drawing.Point(882, 327);
            this.btnModifyProduct.Name = "btnModifyProduct";
            this.btnModifyProduct.Size = new System.Drawing.Size(53, 31);
            this.btnModifyProduct.TabIndex = 4;
            this.btnModifyProduct.Text = "Modify";
            this.btnModifyProduct.UseVisualStyleBackColor = true;
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Location = new System.Drawing.Point(941, 327);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(53, 31);
            this.btnDeleteProduct.TabIndex = 5;
            this.btnDeleteProduct.Text = "Delete";
            this.btnDeleteProduct.UseVisualStyleBackColor = true;
            // 
            // btnExitApp
            // 
            this.btnExitApp.Location = new System.Drawing.Point(941, 375);
            this.btnExitApp.Name = "btnExitApp";
            this.btnExitApp.Size = new System.Drawing.Size(53, 31);
            this.btnExitApp.TabIndex = 6;
            this.btnExitApp.Text = "Exit";
            this.btnExitApp.UseVisualStyleBackColor = true;
            // 
            // btnSearchPart
            // 
            this.btnSearchPart.Location = new System.Drawing.Point(226, 57);
            this.btnSearchPart.Name = "btnSearchPart";
            this.btnSearchPart.Size = new System.Drawing.Size(70, 20);
            this.btnSearchPart.TabIndex = 7;
            this.btnSearchPart.Text = "Search";
            this.btnSearchPart.UseVisualStyleBackColor = true;
            // 
            // btnSearchProduct
            // 
            this.btnSearchProduct.Location = new System.Drawing.Point(751, 57);
            this.btnSearchProduct.Name = "btnSearchProduct";
            this.btnSearchProduct.Size = new System.Drawing.Size(70, 20);
            this.btnSearchProduct.TabIndex = 8;
            this.btnSearchProduct.Text = "Search";
            this.btnSearchProduct.UseVisualStyleBackColor = true;
            this.btnSearchProduct.Click += new System.EventHandler(this.btnSearchProduct_Click);
            // 
            // partView
            // 
            this.partView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.partView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PartID,
            this.clmName,
            this.clmInventory,
            this.clmPrice,
            this.clmMin,
            this.clmMax});
            this.partView.Location = new System.Drawing.Point(15, 80);
            this.partView.Name = "partView";
            this.partView.RowHeadersVisible = false;
            this.partView.Size = new System.Drawing.Size(454, 241);
            this.partView.TabIndex = 9;
            this.partView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.partView_CellContentClick);
            // 
            // productView
            // 
            this.productView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmProductID,
            this.clmProdName,
            this.clmProdInventory,
            this.clmProdPrice,
            this.clmProdMin,
            this.clmProdMax});
            this.productView.Location = new System.Drawing.Point(511, 80);
            this.productView.Name = "productView";
            this.productView.RowHeadersVisible = false;
            this.productView.Size = new System.Drawing.Size(483, 241);
            this.productView.TabIndex = 10;
            // 
            // partSearch
            // 
            this.partSearch.Location = new System.Drawing.Point(302, 57);
            this.partSearch.Name = "partSearch";
            this.partSearch.Size = new System.Drawing.Size(167, 20);
            this.partSearch.TabIndex = 11;
            // 
            // productSearch
            // 
            this.productSearch.Location = new System.Drawing.Point(827, 57);
            this.productSearch.Name = "productSearch";
            this.productSearch.Size = new System.Drawing.Size(167, 20);
            this.productSearch.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Parts";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(508, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Products";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Inventory Management System";
            // 
            // PartID
            // 
            this.PartID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PartID.HeaderText = "Part ID";
            this.PartID.Name = "PartID";
            // 
            // clmName
            // 
            this.clmName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmName.HeaderText = "Name";
            this.clmName.Name = "clmName";
            // 
            // clmInventory
            // 
            this.clmInventory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmInventory.HeaderText = "Inventory";
            this.clmInventory.Name = "clmInventory";
            // 
            // clmPrice
            // 
            this.clmPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmPrice.HeaderText = "Price";
            this.clmPrice.Name = "clmPrice";
            // 
            // clmMin
            // 
            this.clmMin.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmMin.HeaderText = "Min";
            this.clmMin.Name = "clmMin";
            // 
            // clmMax
            // 
            this.clmMax.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmMax.HeaderText = "Max";
            this.clmMax.Name = "clmMax";
            // 
            // clmProductID
            // 
            this.clmProductID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmProductID.HeaderText = "Product ID";
            this.clmProductID.Name = "clmProductID";
            // 
            // clmProdName
            // 
            this.clmProdName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmProdName.HeaderText = "Name";
            this.clmProdName.Name = "clmProdName";
            // 
            // clmProdInventory
            // 
            this.clmProdInventory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmProdInventory.HeaderText = "Inventory";
            this.clmProdInventory.Name = "clmProdInventory";
            // 
            // clmProdPrice
            // 
            this.clmProdPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmProdPrice.HeaderText = "Price";
            this.clmProdPrice.Name = "clmProdPrice";
            // 
            // clmProdMin
            // 
            this.clmProdMin.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmProdMin.HeaderText = "Min";
            this.clmProdMin.Name = "clmProdMin";
            // 
            // clmProdMax
            // 
            this.clmProdMax.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmProdMax.HeaderText = "Max";
            this.clmProdMax.Name = "clmProdMax";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 429);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.productSearch);
            this.Controls.Add(this.partSearch);
            this.Controls.Add(this.productView);
            this.Controls.Add(this.partView);
            this.Controls.Add(this.btnSearchProduct);
            this.Controls.Add(this.btnSearchPart);
            this.Controls.Add(this.btnExitApp);
            this.Controls.Add(this.btnDeleteProduct);
            this.Controls.Add(this.btnModifyProduct);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.btnDeletePart);
            this.Controls.Add(this.btnModifyPart);
            this.Controls.Add(this.btnAddPart);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.partView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddPart;
        private System.Windows.Forms.Button btnModifyPart;
        private System.Windows.Forms.Button btnDeletePart;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnModifyProduct;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.Button btnExitApp;
        private System.Windows.Forms.Button btnSearchPart;
        private System.Windows.Forms.Button btnSearchProduct;
        private System.Windows.Forms.DataGridView partView;
        private System.Windows.Forms.DataGridView productView;
        private System.Windows.Forms.TextBox partSearch;
        private System.Windows.Forms.TextBox productSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmInventory;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMin;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMax;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProdName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProdInventory;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProdPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProdMin;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProdMax;
    }
}

