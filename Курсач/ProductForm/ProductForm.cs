using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Kursach
{
    public partial class ProductForm : Form
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public ProductForm()
        {
            InitializeComponent();
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
        private string DeleteAllBesidesWords(string str)
        {
            return Regex.Replace(str, "\\W", "");
        }
        private void btnOkProduct_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                DialogResult = DialogResult.None;
            }
        }

        private void txtDescription_Validating(object sender, CancelEventArgs e)
        {
            Validate(txtDescription, txtDescription.Text.Trim(), "Поле не может быть пустым!", e);
        }

        private void txtDescription_Validated(object sender, EventArgs e)
        {
            Description = txtDescription.Text;
        }

        private void txtNameProduct_Validating(object sender, CancelEventArgs e)
        {
            Validate(txtNameProduct, txtNameProduct.Text.Trim(), "Поле не может быть пустым!", e);
        }

        private void txtNameProduct_Validated(object sender, EventArgs e)
        {
            Title = txtNameProduct.Text;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
