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
    public partial class FindClientViewModel : Form
    {
        GeneralForm generalForm;
        Client client;
        List<Product> products;
        public FindClientViewModel(GeneralForm generalForm,Client client,List<Product> products,string firstName, string lastName, string patronymic,DateTime birthDate)
        {
            this.client = client;
            this.products = products;
            this.generalForm = generalForm;
            InitializeComponent();
            lblLastName2.Text = lastName;
            lblFirstName2.Text = firstName;
            lblPatronymic2.Text = patronymic;
            if (products != null)
            {
                lblProduct2.Text = String.Empty;
                for (int i = 0; i < products.Count; i++)
                {
                    lblProduct2.Text += " " + products[i].Title+"\n";
                }
            }
            lblDataTime2.Text = birthDate.Date.ToShortDateString();
        }
        private void UpdateFindClientForm()
        {
            lblLastName2.Text = client.LastName;
            lblFirstName2.Text = client.FirstName;
            lblPatronymic2.Text = client.Patronymic;
            if (products != null)
            {
                lblProduct2.Text = String.Empty;
                for (int i = 0; i < products.Count; i++)
                {
                    lblProduct2.Text += " " + products[i].Title + "\n";
                }
            }
            lblDataTime2.Text = client.BirthDate.Date.ToShortDateString();

        }
        public FindClientViewModel()
        {
            InitializeComponent();

        }

        private void btnEditClient_Click(object sender, EventArgs e)
        {
            generalForm.EditClient(client.ClientId);
            UpdateFindClientForm();
        }

        private void BtnDeleteClient_Click(object sender, EventArgs e)
        {
            generalForm.DeleteClient(client.ClientId);
            this.Close();
        }
    }
}
