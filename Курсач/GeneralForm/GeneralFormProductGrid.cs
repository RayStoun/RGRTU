using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursach
{
    partial class  GeneralForm:Form
    {
        private void AddProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddProduct();
        }
        private void DeleteProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteProduct(GetCProductId());
        }
        private void EdditProductToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EditProduct(GetCProductId());
        }
        private void EditProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditProduct(GetCProductId());
        }

        private void DeleteProductToolContextStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteProduct(GetCProductId());
        }

        private void AddProductToolStripContextMenuItem_Click(object sender, EventArgs e)
        {
            AddProduct();
        }
    }
}
