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
    public partial class GeneralForm : Form
    {
        private DataClients data = new DataClients();
        public DateTime BirthDate { get; set; }
        public GeneralForm(DataClients data)
        {
            InitializeComponent();
            data.GetClients();
            UpdateClientGrid();
            UpdateProductGrid();
        }
        private void AddClient()
        {
            var clientForm = new AddClientForm(data.GetProduct());
            if (clientForm.ShowDialog() == DialogResult.OK)
            {
                var name = clientForm.FirstName;
                var lastname = clientForm.LastName;
                var patronymic = clientForm.Patronymic;
                var bt = clientForm.BirthDate;
                var product = clientForm.productToAdd;
                var client = new Client();
                client.FirstName = name;
                client.LastName = lastname;
                client.Patronymic = patronymic;
                client.BirthDate = bt.Date;
                client.Products = product;
                data.AddClient(client);
                UpdateClientGrid();
            }
        }
        private void AddProduct()
        {
            var productForm = new ProductForm();
            if (productForm.ShowDialog() == DialogResult.OK)
            {
                var Title = productForm.Title;
                var description = productForm.Description;
                var product = new Product();
                product.Title = Title;
                product.Description = description;
                ctldataProductGridView.AutoGenerateColumns = false;
                data.AddProduct(product);
                UpdateProductGrid();
            }
        }
        private void UpdateClientGrid()
        {
            ctlClientDataGridViewClients.AutoGenerateColumns = false;
            var clients = data.GetClientViewModels();
            ctlClientDataGridViewClients.DataSource = clients;
            ctlClientDataGridViewClients.Refresh();

        }
        private void UpdateProductGrid()
        {
            ctldataProductGridView.AutoGenerateColumns = false;
            var products = data.GetProduct();
            ctldataProductGridView.DataSource = null;
            ctldataProductGridView.DataSource = products;
            ctlClientDataGridViewClients.Refresh();
        }
        public void DeleteClient(int clientId)
        {
            if (CheckedMessageYesOrNo() == DialogResult.Yes)
            {
                data.DeleteClient(clientId);
                UpdateClientGrid();
            }
        }
        private void DeleteProduct(int productId)
        {
            if (CheckedMessageYesOrNo() == DialogResult.Yes)
            {
                bool find = data.SearchingSameProductInDataClient(productId);
                if (find)
                {
                    MessageBox.Show("Удаление не возможно,  продукт принадлежит " +
                        "клиенту");
                }
                else
                {
                    data.DeleteProduct(productId);
                    UpdateProductGrid();
                    UpdateClientGrid();
                }
            }
        }
        private DialogResult CheckedMessageYesOrNo()
        {
            var res = MessageBox.Show(
                "Вы уверены?",
                "Подтверждение",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            return res;
        }
        private int GetCProductId()
        {
            var index = ctldataProductGridView.SelectedCells[0].RowIndex;
            var id = (int)ctldataProductGridView[ProductId.Name, index].Value;
            return id;
        }
        private int GetClientID()
        {
            var index = ctlClientDataGridViewClients.SelectedCells[0].RowIndex;
            var id = (int)ctlClientDataGridViewClients[ctlId.Name, index].Value;
            return id;
        }
        public void EditClient(int clientId)
        {
            var selectClient = data.GetClients().FirstOrDefault(u => u.ClientId == clientId);
            var BinarySeachClient = data.GetClientId(clientId);
            var editClient = new EditClientForm(data.GetProduct(), selectClient.FirstName, selectClient.LastName, selectClient.Patronymic,
                selectClient.BirthDate);
            if (editClient.ShowDialog() == DialogResult.OK)
            {
                var FirstName = editClient.FirstName;
                var LastName = editClient.LastName;
                var Patronymic = editClient.Patronymic;
                DateTime BirthDate = editClient.BirthDate;
                var product = editClient.editProduct;
                selectClient.BirthDate = BirthDate;
                selectClient.FirstName = FirstName;
                selectClient.LastName = LastName;
                selectClient.Patronymic = Patronymic;
                selectClient.Products = product;
                data.UpdateClient(selectClient);
                UpdateClientGrid();
            }
        }
        private void EditProduct(int productId)
        {
            var selectProduct = data.GetProduct().FirstOrDefault(u => u.ProductId == productId);
            var editProduct = new EditProductForm(selectProduct);
            if (editProduct.ShowDialog() == DialogResult.OK)
            {
                var editTitle = editProduct.Title;
                var editDescription = editProduct.Descritions;
                selectProduct.Title = editTitle;
                selectProduct.Description = editDescription;
                data.UpdateProduct(selectProduct);
                data.CheckEditProductHave(selectProduct.ProductId);
                ctlClientDataGridViewClients.DataSource = data.GetClientViewModels();
                UpdateProductGrid();
                UpdateClientGrid();
            }

        }
        private void ctlClientDataGridViewClients_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SortDataGridViewClientLastName();
        }
        private void FindClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var clientArrayLength = data.GetClients().Capacity;
            var seachClient = new FindClientForm();
            if (seachClient.ShowDialog() == DialogResult.OK)
            {
                var client = data.GetClients().Find(u => u.ClientId == seachClient.ClienId);
                if (client == null)
                {
                    seachClient.ThatClientDontExistMessage();
                }
                else
                {
                    var findClientViewModel = new FindClientViewModel(this, client, client.Products, client.FirstName,
                        client.LastName, client.Patronymic, client.BirthDate);
                    if (findClientViewModel.ShowDialog() == DialogResult.OK)
                    {

                    }
                }
            }
        }
    }
}
