namespace C968_Inventory_System
{
    partial class Add_Product
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.addProductSearch = new System.Windows.Forms.Button();
            this.allPartsView = new System.Windows.Forms.DataGridView();
            this.associatedPartsView = new System.Windows.Forms.DataGridView();
            this.productAdd = new System.Windows.Forms.Button();
            this.saveProduct = new System.Windows.Forms.Button();
            this.productCancel = new System.Windows.Forms.Button();
            this.productDelete = new System.Windows.Forms.Button();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.txtProductPrice = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtProductMin = new System.Windows.Forms.TextBox();
            this.txtProductMax = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtProductInventory = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.allPartID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.allName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.allInventory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.allPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.allMin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.allMax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asPartID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asInventory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asMin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asMax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.allPartsView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.associatedPartsView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Product";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(581, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(174, 20);
            this.textBox1.TabIndex = 1;
            // 
            // addProductSearch
            // 
            this.addProductSearch.Location = new System.Drawing.Point(504, 46);
            this.addProductSearch.Name = "addProductSearch";
            this.addProductSearch.Size = new System.Drawing.Size(71, 20);
            this.addProductSearch.TabIndex = 2;
            this.addProductSearch.Text = "Search";
            this.addProductSearch.UseVisualStyleBackColor = true;
            // 
            // allPartsView
            // 
            this.allPartsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allPartsView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.allPartID,
            this.allName,
            this.allInventory,
            this.allPrice,
            this.allMin,
            this.allMax});
            this.allPartsView.Location = new System.Drawing.Point(332, 82);
            this.allPartsView.Name = "allPartsView";
            this.allPartsView.RowHeadersVisible = false;
            this.allPartsView.Size = new System.Drawing.Size(423, 149);
            this.allPartsView.TabIndex = 3;
            // 
            // associatedPartsView
            // 
            this.associatedPartsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.associatedPartsView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.asPartID,
            this.asName,
            this.asInventory,
            this.asPrice,
            this.asMin,
            this.asMax});
            this.associatedPartsView.Location = new System.Drawing.Point(332, 289);
            this.associatedPartsView.Name = "associatedPartsView";
            this.associatedPartsView.RowHeadersVisible = false;
            this.associatedPartsView.Size = new System.Drawing.Size(423, 149);
            this.associatedPartsView.TabIndex = 4;
            // 
            // productAdd
            // 
            this.productAdd.Location = new System.Drawing.Point(683, 237);
            this.productAdd.Name = "productAdd";
            this.productAdd.Size = new System.Drawing.Size(62, 27);
            this.productAdd.TabIndex = 5;
            this.productAdd.Text = "Add";
            this.productAdd.UseVisualStyleBackColor = true;
            // 
            // saveProduct
            // 
            this.saveProduct.Location = new System.Drawing.Point(615, 477);
            this.saveProduct.Name = "saveProduct";
            this.saveProduct.Size = new System.Drawing.Size(62, 27);
            this.saveProduct.TabIndex = 6;
            this.saveProduct.Text = "Save";
            this.saveProduct.UseVisualStyleBackColor = true;
            // 
            // productCancel
            // 
            this.productCancel.Location = new System.Drawing.Point(683, 477);
            this.productCancel.Name = "productCancel";
            this.productCancel.Size = new System.Drawing.Size(62, 27);
            this.productCancel.TabIndex = 7;
            this.productCancel.Text = "Cancel";
            this.productCancel.UseVisualStyleBackColor = true;
            // 
            // productDelete
            // 
            this.productDelete.Location = new System.Drawing.Point(683, 444);
            this.productDelete.Name = "productDelete";
            this.productDelete.Size = new System.Drawing.Size(62, 27);
            this.productDelete.TabIndex = 8;
            this.productDelete.Text = "Delete";
            this.productDelete.UseVisualStyleBackColor = true;
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(101, 211);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(125, 20);
            this.txtProductID.TabIndex = 9;
            // 
            // txtProductPrice
            // 
            this.txtProductPrice.Location = new System.Drawing.Point(101, 289);
            this.txtProductPrice.Name = "txtProductPrice";
            this.txtProductPrice.Size = new System.Drawing.Size(125, 20);
            this.txtProductPrice.TabIndex = 10;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(101, 237);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(125, 20);
            this.txtProductName.TabIndex = 12;
            // 
            // txtProductMin
            // 
            this.txtProductMin.Location = new System.Drawing.Point(220, 315);
            this.txtProductMin.Name = "txtProductMin";
            this.txtProductMin.Size = new System.Drawing.Size(82, 20);
            this.txtProductMin.TabIndex = 13;
            // 
            // txtProductMax
            // 
            this.txtProductMax.Location = new System.Drawing.Point(89, 315);
            this.txtProductMax.Name = "txtProductMax";
            this.txtProductMax.Size = new System.Drawing.Size(83, 20);
            this.txtProductMax.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Inventory";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 315);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Max";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(190, 318);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Min";
            // 
            // txtProductInventory
            // 
            this.txtProductInventory.Location = new System.Drawing.Point(101, 263);
            this.txtProductInventory.Name = "txtProductInventory";
            this.txtProductInventory.Size = new System.Drawing.Size(125, 20);
            this.txtProductInventory.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(341, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "All Candidate Parts";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(344, 270);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(167, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Parts Associated with this Product";
            // 
            // allPartID
            // 
            this.allPartID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.allPartID.HeaderText = "Part ID";
            this.allPartID.Name = "allPartID";
            // 
            // allName
            // 
            this.allName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.allName.HeaderText = "Name";
            this.allName.Name = "allName";
            // 
            // allInventory
            // 
            this.allInventory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.allInventory.HeaderText = "Inventory";
            this.allInventory.Name = "allInventory";
            // 
            // allPrice
            // 
            this.allPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.allPrice.HeaderText = "Price";
            this.allPrice.Name = "allPrice";
            // 
            // allMin
            // 
            this.allMin.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.allMin.HeaderText = "Min";
            this.allMin.Name = "allMin";
            // 
            // allMax
            // 
            this.allMax.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.allMax.HeaderText = "Max";
            this.allMax.Name = "allMax";
            // 
            // asPartID
            // 
            this.asPartID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.asPartID.HeaderText = "Part ID";
            this.asPartID.Name = "asPartID";
            // 
            // asName
            // 
            this.asName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.asName.HeaderText = "Name";
            this.asName.Name = "asName";
            // 
            // asInventory
            // 
            this.asInventory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.asInventory.HeaderText = "Inventory";
            this.asInventory.Name = "asInventory";
            // 
            // asPrice
            // 
            this.asPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.asPrice.HeaderText = "Price";
            this.asPrice.Name = "asPrice";
            // 
            // asMin
            // 
            this.asMin.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.asMin.HeaderText = "Min";
            this.asMin.Name = "asMin";
            // 
            // asMax
            // 
            this.asMax.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.asMax.HeaderText = "Max";
            this.asMax.Name = "asMax";
            // 
            // Add_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 535);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtProductMax);
            this.Controls.Add(this.txtProductMin);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.txtProductInventory);
            this.Controls.Add(this.txtProductPrice);
            this.Controls.Add(this.txtProductID);
            this.Controls.Add(this.productDelete);
            this.Controls.Add(this.productCancel);
            this.Controls.Add(this.saveProduct);
            this.Controls.Add(this.productAdd);
            this.Controls.Add(this.associatedPartsView);
            this.Controls.Add(this.allPartsView);
            this.Controls.Add(this.addProductSearch);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Add_Product";
            this.Text = "Add_Product";
            this.Load += new System.EventHandler(this.Add_Product_Load);
            ((System.ComponentModel.ISupportInitialize)(this.allPartsView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.associatedPartsView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button addProductSearch;
        private System.Windows.Forms.DataGridView allPartsView;
        private System.Windows.Forms.DataGridView associatedPartsView;
        private System.Windows.Forms.Button productAdd;
        private System.Windows.Forms.Button saveProduct;
        private System.Windows.Forms.Button productCancel;
        private System.Windows.Forms.Button productDelete;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.TextBox txtProductPrice;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtProductMin;
        private System.Windows.Forms.TextBox txtProductMax;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtProductInventory;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn allPartID;
        private System.Windows.Forms.DataGridViewTextBoxColumn allName;
        private System.Windows.Forms.DataGridViewTextBoxColumn allInventory;
        private System.Windows.Forms.DataGridViewTextBoxColumn allPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn allMin;
        private System.Windows.Forms.DataGridViewTextBoxColumn allMax;
        private System.Windows.Forms.DataGridViewTextBoxColumn asPartID;
        private System.Windows.Forms.DataGridViewTextBoxColumn asName;
        private System.Windows.Forms.DataGridViewTextBoxColumn asInventory;
        private System.Windows.Forms.DataGridViewTextBoxColumn asPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn asMin;
        private System.Windows.Forms.DataGridViewTextBoxColumn asMax;
    }
}