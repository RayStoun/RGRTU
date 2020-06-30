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
    public class ClientViewModel
    {
        public int ClientId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Patronymic { get; set; }
        public DateTime BirthDate { get; set; }
        public string Product { get; set; }

        public static ClientViewModel ToModel(Client client)
        {
            var model = new ClientViewModel();
            model.BirthDate = client.BirthDate;
            model.LastName = client.LastName;
            model.ClientId = client.ClientId;
            model.FirstName = client.FirstName;
            model.Patronymic = client.Patronymic;
            if (client.Products != null)
            {
                model.Product = (string.Join(", ", client.Products.Select(r => r.Title)));
            }
            else
            {
                model.Product = "";
            }
            return model;
        }
    }
}
