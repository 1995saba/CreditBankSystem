using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppModels
{
    public class Client
    {
        public long Pin { get; set; }
        public string FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public string HomeAddress { get; set; }
        public string PlaceOfWork { get; set; }
        public string WorkPhoneNumber { get; set; }
        public string PersonalPhoneNumber { get; set; }
        public bool HasCredit { get; set; }
        public double MonthlyIncome { get; set; }
        public Guarantor Guarantor { get; set; }
        public Credit Credit { get; set; }


        private string password;

        private string GetPassword()
        {
            int size = 16;
            int[] arr = new int[size];
            Random rnd = new Random();
            string password = "";

            for (int i = 0; i < size / 2; i++)
            {
                arr[i] = rnd.Next(0, 9);
                password += (char)arr[i];
            }

            for (int i = size / 2; i < size; i++)
            {
                arr[i] = rnd.Next(33, 125);
                password += (char)arr[i];
            }

            return password;
        }
    }
}
