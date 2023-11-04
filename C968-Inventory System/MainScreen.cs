using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C968_Inventory_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSearchProduct_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAddPart_Click(object sender, EventArgs e)
        {
          
            Add_Part add_Part = new Add_Part();
            add_Part.Show();
            this.Close();
        }

      /*  private void btnModifyPart_Click(object sender, EventArgs e)
        {
            this.Close();

        }*/

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            this.Close();
            Add_Product add_Product = new Add_Product();
        }
        private void partView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnModifyPart_Click(object sender, EventArgs e)
        {

        }
    }
}
