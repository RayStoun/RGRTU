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
    public partial class EditProductForm : Form
    {
        public string Title;
        public string Descritions;
        public EditProductForm(Product product)
        {
            InitializeComponent();
            txtTitle.Text = product.Title;
            txtDescription.Text = product.Description;
            
        }        
        private void Validate(Control control, string ctrValue, string ErrorMessage, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(ctrValue))
            {
                errorProvider1.SetError(control, ErrorMessage);
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(control, string.Empty);
                e.Cancel = false;
            }
        }
        private void txtTitle_Validated(object sender, EventArgs e)
        {
            Title = txtTitle.Text;
        }

        private void txtTitle_Layout(object sender, LayoutEventArgs e)
        {
            Title = txtTitle.Text;
        }

        private void txtDescription_Layout(object sender, LayoutEventArgs e)
        {
            Descritions = txtDescription.Text;
        }

        private void txtDescription_Validating(object sender, CancelEventArgs e)
        {
            Validate(txtDescription, txtDescription.Text, "У продукта должно быть описание", e);
        }

        private void txtDescription_Validated(object sender, EventArgs e)
        {
            Descritions = txtDescription.Text;
        }

        private void txtTitle_Validating(object sender, CancelEventArgs e)
        {
            Validate(txtTitle, txtTitle.Text, "У продукта должно быть имя", e);
        }
    }
}
