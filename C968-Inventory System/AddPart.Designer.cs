namespace C968_Inventory_System
{
    partial class Add_Part
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
            this.partInHouse = new System.Windows.Forms.RadioButton();
            this.partOutsourced = new System.Windows.Forms.RadioButton();
            this.partID = new System.Windows.Forms.TextBox();
            this.partMachineID = new System.Windows.Forms.TextBox();
            this.partPrice = new System.Windows.Forms.TextBox();
            this.partInventory = new System.Windows.Forms.TextBox();
            this.partName = new System.Windows.Forms.TextBox();
            this.partMax = new System.Windows.Forms.TextBox();
            this.partMin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.partCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Part";
            // 
            // partInHouse
            // 
            this.partInHouse.AutoSize = true;
            this.partInHouse.Location = new System.Drawing.Point(126, 13);
            this.partInHouse.Name = "partInHouse";
            this.partInHouse.Size = new System.Drawing.Size(68, 17);
            this.partInHouse.TabIndex = 1;
            this.partInHouse.TabStop = true;
            this.partInHouse.Text = "In-House";
            this.partInHouse.UseVisualStyleBackColor = true;
            // 
            // partOutsourced
            // 
            this.partOutsourced.AutoSize = true;
            this.partOutsourced.Location = new System.Drawing.Point(217, 12);
            this.partOutsourced.Name = "partOutsourced";
            this.partOutsourced.Size = new System.Drawing.Size(80, 17);
            this.partOutsourced.TabIndex = 2;
            this.partOutsourced.TabStop = true;
            this.partOutsourced.Text = "Outsourced";
            this.partOutsourced.UseVisualStyleBackColor = true;
            // 
            // partID
            // 
            this.partID.Location = new System.Drawing.Point(113, 64);
            this.partID.Name = "partID";
            this.partID.Size = new System.Drawing.Size(171, 20);
            this.partID.TabIndex = 3;
            // 
            // partMachineID
            // 
            this.partMachineID.Location = new System.Drawing.Point(113, 260);
            this.partMachineID.Name = "partMachineID";
            this.partMachineID.Size = new System.Drawing.Size(171, 20);
            this.partMachineID.TabIndex = 4;
            // 
            // partPrice
            // 
            this.partPrice.Location = new System.Drawing.Point(113, 176);
            this.partPrice.Name = "partPrice";
            this.partPrice.Size = new System.Drawing.Size(171, 20);
            this.partPrice.TabIndex = 5;
            // 
            // partInventory
            // 
            this.partInventory.Location = new System.Drawing.Point(113, 139);
            this.partInventory.Name = "partInventory";
            this.partInventory.Size = new System.Drawing.Size(171, 20);
            this.partInventory.TabIndex = 6;
            // 
            // partName
            // 
            this.partName.Location = new System.Drawing.Point(113, 101);
            this.partName.Name = "partName";
            this.partName.Size = new System.Drawing.Size(171, 20);
            this.partName.TabIndex = 7;
            // 
            // partMax
            // 
            this.partMax.Location = new System.Drawing.Point(113, 217);
            this.partMax.Name = "partMax";
            this.partMax.Size = new System.Drawing.Size(81, 20);
            this.partMax.TabIndex = 8;
            // 
            // partMin
            // 
            this.partMin.Location = new System.Drawing.Point(242, 217);
            this.partMin.Name = "partMin";
            this.partMin.Size = new System.Drawing.Size(81, 20);
            this.partMin.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Inventory";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Price / Cost";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(78, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Max";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(212, 224);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Min";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(43, 267);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Machine ID";
            // 
            // partCancel
            // 
            this.partCancel.Location = new System.Drawing.Point(295, 400);
            this.partCancel.Name = "partCancel";
            this.partCancel.Size = new System.Drawing.Size(75, 23);
            this.partCancel.TabIndex = 17;
            this.partCancel.Text = "Cancel";
            this.partCancel.UseVisualStyleBackColor = true;
           
            // 
            // Add_Part
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 445);
            this.Controls.Add(this.partCancel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.partMin);
            this.Controls.Add(this.partMax);
            this.Controls.Add(this.partName);
            this.Controls.Add(this.partInventory);
            this.Controls.Add(this.partPrice);
            this.Controls.Add(this.partMachineID);
            this.Controls.Add(this.partID);
            this.Controls.Add(this.partOutsourced);
            this.Controls.Add(this.partInHouse);
            this.Controls.Add(this.label1);
            this.Name = "Add_Part";
            this.Text = "Add_Part";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton partInHouse;
        private System.Windows.Forms.RadioButton partOutsourced;
        private System.Windows.Forms.TextBox partID;
        private System.Windows.Forms.TextBox partMachineID;
        private System.Windows.Forms.TextBox partPrice;
        private System.Windows.Forms.TextBox partInventory;
        private System.Windows.Forms.TextBox partName;
        private System.Windows.Forms.TextBox partMax;
        private System.Windows.Forms.TextBox partMin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button partCancel;
    }
}