using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Kursach
{
    [Serializable]
    public class DataClients
    {

        private List<Product> products;
        private List<Client> clients;
        public List<Product> productToAdd;
        public DataClients()
        {
            clients = new List<Client>();
            products = new List<Product>();
           // HardCodeProduct();
            //HardCodeClientAndProduct();
        }
        public void WriteInFileProduct()
        {
            using(Stream output = File.Create("ProductData.dat"))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(output, products);
            }
        }
        private void ReadONFileProduct()
        {
            using(Stream input= File.OpenRead("ProductData.dat"))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                products = (List<Product>)formatter.Deserialize(input);
            }
        }
        private void WriteInFileDataClient()
        {
            using(Stream output = File.Create("ClientData.dat"))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(output, clients);
            }
        }
        private void ReadFileDataClient()
        {
            using(Stream input = File.OpenRead("ClientData.dat"))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                clients = (List<Client>)formatter.Deserialize(input);
            }
        }
        public void SortFirstNameClient(bool AscendingSort)
        {
            if (AscendingSort)
            {
                clients = clients.OrderBy(u => u.FirstName).ToList();
            }
            else
            {
                clients = clients.OrderByDescending(u => u.FirstName).ToList();
            }
            WriteInFileDataClient();
        }
        public void SortLastName(bool AscendingSort)
        {
            if (AscendingSort)
            {
                clients = clients.OrderBy(u => u.LastName).ToList();
            }
            else
            {
                clients = clients.OrderByDescending(u => u.LastName).ToList();
            }
            WriteInFileDataClient();
        }
        public void SortById()
        {
            ShellSortClientId();
            WriteInFileDataClient();
        }
        static void Swap(ref int e1, ref int e2)
        {
            var temp = e1;
            e1 = e2;
            e2 = temp;
        }
       
        //сортировка Шеннона
        private void ShellSortClientId( )
        {
            //расстояние между элементами, которые сравниваются
            var d = clients.Count / 2;
            while (d >= 1)
            {
                for (var i = d; i < clients.Count; i++)
                {
                    var j = i;
                    while ((j >= d) && (clients[j - d].ClientId > clients[j].ClientId))
                    {// Swap 
                        var t = clients[j].ClientId;
                        clients[j].ClientId = clients[j - d].ClientId;
                        clients[j - d].ClientId = t;
                        j = j - d;
                    }
                }
                d = d / 2;
                WriteInFileDataClient();
            }
        }
        public void AddClient(Client client)
        {
            var maxId = 0;
            var ids = clients.Select(u => u.ClientId);
            if (ids.Count() != 0)
            {
                maxId = ids.Max();
            }
            client.ClientId = maxId + 1;
            clients.Add(client);
            WriteInFileDataClient();
        }
        public void AddProduct(Product product)
        {
            var maxId = 0;
            var ids = products.Select(u => u.ProductId);
            if (ids.Count() != 0)
            {
                maxId = ids.Max();
            }
            product.ProductId = maxId + 1;
            products.Add(product);
            WriteInFileProduct();
        }
        public void DeleteClient(int clientId)
        {
            var indexClient= BinarySearch(clients, clientId, 0, clients.Count);
            var SelectClient = clients[indexClient];
            if (SelectClient != null)
            {
                clients.Remove(SelectClient);
            }
            WriteInFileDataClient();
        }
        public bool SearchingSameProductInDataClient(int productId)
        {
            var selectProduct = products.FirstOrDefault(u => u.ProductId == productId);
            if (selectProduct != null)
            {
                for (int i = 0; i < clients.Count; i++)
                {
                    if (clients[i].Products != null)
                    {
                        for (int j = 0; j < clients[i].Products.Count; j++)
                        {
                            if (selectProduct.ProductId == clients[i].Products[j].ProductId)
                            {
                                return true;

                            }
                        }
                    }

                }
            }
            return false;
        }
        public void DeleteProduct(int productId)
        {
            var selectProduct = products.FirstOrDefault(u => u.ProductId == productId);
            if (selectProduct != null)
            {
                for (int i = 0; i < clients.Count; i++)
                {
                    if (clients[i].Products != null)
                    {
                        for (int j = 0; j < clients[i].Products.Count; j++)
                        {
                            if (selectProduct.ProductId == clients[i].Products[j].ProductId)
                            {
                                clients[i].Products.Remove(clients[i].Products[j]);
                                ClientViewModel.ToModel(clients[i]);

                            }
                        }
                    }
                    
                }
                products.Remove(selectProduct);
            }
            WriteInFileProduct();
            WriteInFileDataClient();
        }
        public List<Client> GetClients()
        {
            ReadFileDataClient();
            return clients;
        }
        public List<Product> GetProduct()
        {
            ReadONFileProduct();
            return products;
        }
        public Client GetClientId(int clientId)
        {
            int indexClient = BinarySearch(clients, clientId, 0, clients.Count);
            var findClient = clients[indexClient];
            //Client findclientBinarySearch = clients[Search<Client>(clients, clientId)];
           // Client findClient = clients.Find(item => item.ClientId == clientId);
            return findClient;
        }


        public Client[] CopyInMassive()
        {
            Client[] clientArray = new Client[clients.Capacity];
            for (int i = 0; i <clients.Capacity; i++)
            {
                clientArray[i] = clients[i];
            }
            return clientArray;
        }

        static int BinarySearch(List<Client> list, int searchedValue, int first, int last)
        {
            //границы сошлись
            if (first > last)
            {
                //элемент не найден
                return -1;
            }

            //средний индекс подмассива
            var middle = first+(last-first) / 2;
            //значение в средине подмассива
            var middleValue = list[middle];

            if (middleValue.ClientId == searchedValue)
            {
                return middle;
            }
            else
            {
                if (middleValue.ClientId > searchedValue)
                {
                    //рекурсивный вызов поиска для левого подмассива
                    return BinarySearch(list, searchedValue, first, middle - 1);
                }
                else
                {
                    //рекурсивный вызов поиска для правого подмассива
                    return BinarySearch(list, searchedValue, middle + 1, last);
                }
            }
        }       
        public Product GetProductId(int productId)
        {
            Product findProduct = products.Find(item => item.ProductId == productId);
            return findProduct;
        }
        
        public List<ClientViewModel> GetClientViewModels()
        {
            var client = GetClients();
            var clientModels = client.Select(u => ClientViewModel.ToModel(u));
            return clientModels.ToList();
        }
        public void UpdateClient(Client client)
        {
            var fiendClient = clients.Find(u => u.ClientId == client.ClientId);
            client = fiendClient;
            WriteInFileDataClient();
        }
        public void CheckEditProductHave(int productId)
        {
            var selectProduct = products.FirstOrDefault(u => u.ProductId == productId);
            if (selectProduct != null)
            {
                for (int i = 0; i < clients.Count; i++)
                {
                    if (clients[i].Products!=null)
                    {
                        for (int j = 0; j < clients[i].Products.Count; j++)
                        {
                            if (selectProduct.ProductId == clients[i].Products[j].ProductId)
                            {

                                clients[i].Products[j].Title = selectProduct.Title;
                                WriteInFileDataClient();
                            }
                        }
                    }
                }
            }
        }
        public void UpdateProduct(Product product)
        {
            var fiendProduct = products.Find(u => u.ProductId == product.ProductId);
            product = fiendProduct;
            WriteInFileProduct();
        }
        private void HardCodeProduct()
        {
            var credit = new Product();
            credit.Title = "Экспрес кредит наличными";
            credit.Description = "Можете получить в любом отделении банка, подать заявку можно на " +
                "сайте или в отделении банка";
            AddProduct(credit);
            var debitCard = new Product();
            debitCard.Title = "Дебетовая карта Мтс деньги Weekend";
            debitCard.Description = "Карта с кеш беком от 1-5% и с бесплатным обслуживанием при" +
                "выполнении условий";
            AddProduct(debitCard);
            var refinance = new Product();
            refinance.Title = "Рефинансирование";
            refinance.Description = "Это кредит по сниженной процентной ставке на погаешние кредитов в" +
                "сторонних банках";
            AddProduct(refinance);
        }
        private void HardCodeClientAndProduct()
        {
            var creditCard = new Product();
            creditCard.Title = "Мтс Деньги Weekend";
            creditCard.Description = "Карта имеет кредитный лимит до 299 999 тысяч рублей,а" +
                "также льготный период до 51 дня";
            AddProduct(creditCard);
            var student = new Client();
            student.BirthDate = new DateTime(1996, 12, 12);
            student.FirstName = "Алберт";
            student.LastName = "Соколовский";
            student.Patronymic = "Григорьевич";
            AddClient(student);
            var moskvich = new Client();
            moskvich.BirthDate = new DateTime(1971, 10,11);
            moskvich.FirstName = "Илон";
            moskvich.LastName = "Маск";
            moskvich.Patronymic = "Эролович";
           // moskvich.Products[0] = products[3];
            AddClient(moskvich);
            var russianMan = new Client();
            russianMan.FirstName = "Курт";
            russianMan.Patronymic = "Дональдович";
            russianMan.LastName = "Кобейн";
            russianMan.BirthDate = new DateTime(1967, 02, 20);
            var akter = new Client();
            akter.FirstName = "Джонатон-Майк";
            akter.LastName = "Дориан";
            akter.Patronymic = "";
            akter.BirthDate = new DateTime(1994, 12, 31);
            AddClient(akter);
            AddClient(russianMan);
        }
    }
}
