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
    public partial class AddClientForm : Form
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Patronymic { get; set; }
        public DateTime BirthDate { get; set; }
        private List<Product> products;
        public List<Product> productToAdd = new List<Product>();

        public AddClientForm(List<Product> products)
        {
            this.products = products;
            InitializeComponent();
            AddProductInCheckBox();
        }
        
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                DialogResult = DialogResult.None;
            }
        }
        private void AddProductInCheckBox()
        {
            if (products != null)
            {
                foreach (var item in products)
                {
                    checkedListProduct.Items.Add(item.Title, CheckState.Unchecked);
                }
            }
        }
        private void CheckListProduct_Validated(object sender, EventArgs e)
        {
            if (checkedListProduct.CheckedItems != null)
            {
                foreach(int item in checkedListProduct.CheckedIndices)
                {
                    productToAdd.Add(products[item]);
                }
            }
        }
        

    }
}
