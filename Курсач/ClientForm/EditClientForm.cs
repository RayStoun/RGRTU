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
    public partial class EditClientForm : Form
    {

        public EditClientForm()
        {
            InitializeComponent();
        }
        public DateTime BirthDate   = new DateTime();
        public string FirstName = String.Empty;
        public string LastName = String.Empty;
        public string Patronymic =String.Empty;
        private List<Product> products;
        public List<Product> editProduct = new List<Product>();
        public EditClientForm(List<Product> products, string Name, string lastName,string patronymic, DateTime db)
        {
            InitializeComponent();
            this.products = products;
            txtEditFirstName.Text = Name;
            txtEditLastName.Text = lastName;
            if (patronymic == null)
            {
                txtEditPatronymic.Text = String.Empty;
            }
            else
            {
                txtEditPatronymic.Text = patronymic;
            }
            txtEditDateTime.Value = db;
            AddProductsInCheckBox();
        }
        private void AddProductsInCheckBox()
        {
            if (products != null)
            {
                foreach (var item in products)
                {

                    checkedEditListBox.Items.Add(item.Title);
                }
            }

        }
        private void CheckListProduct_Validated(object sender, EventArgs e)
        {
            if (checkedEditListBox.CheckedItems != null)
            {
                foreach (int item in checkedEditListBox.CheckedIndices)
                {
                    editProduct.Add(products[item]);
                }
            }
        }
        private void ValidatingDate(Control control, DateTime txteditDateTime, string errorMessage, CancelEventArgs e)
        {
            
            if (txteditDateTime == null || DateTime.Now.Year - 80 >= txteditDateTime.Year)
            {
                errorProvEditForm.SetError(control, errorMessage);
                e.Cancel = true;
            }
            else
            {
                errorProvEditForm.SetError(txtEditDateTime, string.Empty);
                e.Cancel = false;
            }
        }
        private void Validate(Control control, string ctrValue, string ErrorMessage, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(ctrValue))
            {
                errorProvEditForm.SetError(control, ErrorMessage);
                e.Cancel = true;
            }
            else
            {
                errorProvEditForm.SetError(control, string.Empty);
                e.Cancel = false;
            }
        }
        private string DeleteAllBesidesWords(string str)
        {
            return Regex.Replace(str, "\\W", "");
        }

        private void txtEditName_Validated(object sender, EventArgs e)
        {
            FirstName = DeleteAllBesidesWords(txtEditFirstName.Text.Trim());
        }

        private void txtEditName_Validating(object sender, CancelEventArgs e)
        {
            Validate(txtEditFirstName, txtEditFirstName.Text.Trim(), "Имя не может быть пустое!", e);
        }

        private void txtEditLastName_Validating(object sender, CancelEventArgs e)
        {
            Validate(txtEditLastName, txtEditLastName.Text.Trim(), "Поле фамилия не должно быть пустым!", e);
        }

        private void txtEditLastName_Validated(object sender, EventArgs e)
        {
            LastName = DeleteAllBesidesWords(txtEditLastName.Text.Trim());
        }


        private void TxtEditDateTime_Validating(object sender, CancelEventArgs e)
        {
            ValidatingDate(txtEditDateTime, txtEditDateTime.Value, "День рождения должен быть заполнен!", e);
        }

        private void TxtEditDateTime_Validated(object sender, EventArgs e)
        {
            BirthDate = txtEditDateTime.Value;
        }

        private void txtEditPatronymic_Validated(object sender, EventArgs e)
        {
            Patronymic = DeleteAllBesidesWords(txtEditPatronymic.Text.Trim());
        }

        private void txtEditDateTime_Leave(object sender, EventArgs e)
        {
            BirthDate = txtEditDateTime.Value;
        }

        private void txtEditDateTime_Layout(object sender, LayoutEventArgs e)
        {
            BirthDate = txtEditDateTime.Value;
        }

        private void txtEditPatronymic_Layout(object sender, LayoutEventArgs e)
        {
            Patronymic = txtEditPatronymic.Text;
        }

        private void txtEditLastName_Layout(object sender, LayoutEventArgs e)
        {
            LastName = txtEditLastName.Text;
        }

        private void txtEditFirstName_Layout(object sender, LayoutEventArgs e)
        {
            FirstName = txtEditFirstName.Text;
        }

        private void txtEditLastName_Leave(object sender, EventArgs e)
        {
            LastName = txtEditLastName.Text;
        }
    }
}
