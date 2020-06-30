using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursach
{
    class DataClients
    {
        private List<Product> products;
        private List<Client> clients;
        public List<Product> productToAdd;
        public DataClients()
        {
            clients = new List<Client>();
            products = new List<Product>();
        }
        public void AddProduct(Client client)
        {
            var maxId = 0;
            var ids = clients.Select(u => u.ClientId);
            if (ids.Count() != 0)
            {
                maxId = ids.Max();
            }
            client.ClientId = maxId + 1;
            clients.Add(client);
        }
        public void DeleteClient(int clientId)
        {
            var SelectClient = clients.FirstOrDefault(u => u.ClientId == clientId);
            if (SelectClient != null)
            {
                clients.Remove(SelectClient);
            }
        }
        public void DeleteProduct(int productId)
        {
            var selectProdoct = products.FirstOrDefault(u => u.ProductId == productId);
            if (selectProdoct != null)
            {
                products.Remove(selectProdoct);
            }
        }
        public List<Client> GetClients()
        {
            return clients;
        }
        public Client GetClientId(int clientId)
        {
            Client findClient = clients.Find(item => item.ClientId == clientId);
            return findClient;
        }
        public Product GetProductId(int productId)
        {
            Product findProduct = products.Find(item => item.ProductId == productId);
            return findProduct;
        }
        public List<Product> GetProduct()
        {
            return products;
        }
        public List<ClientViewModel> GetClientViewModels()
        {
            var client = GetClients();
            var clientModels = client.Select(u => ClientViewModel.ToModel(u));
            return clientModels.ToList();
        }

    }
}
