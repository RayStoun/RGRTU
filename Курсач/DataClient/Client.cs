using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursach
{
    class Client
    {
        public int ClientId { get; set; }
        public string FirstName;
        public string LastName;
        public string Patronymic;
        public DateTime BirthDate { get; set; }
        public List<Product> Products { get; set; }
        public int Age
        {
            get
            {
                return GetDifferenceDate(BirthDate);
            }
        }
        public Client()
        {

        }
        static public int GetDifferenceDate(DateTime differenceTime)
        {
            DateTime dateNow = DateTime.Now;
            int age = dateNow.Year - differenceTime.Year;
            if (dateNow.Month < differenceTime.Month ||
            (dateNow.Month == differenceTime.Month && dateNow.Day < differenceTime.Day)) age--;
            return age;
        }

    }
}
