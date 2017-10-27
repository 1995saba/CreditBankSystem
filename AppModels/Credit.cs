using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppModels
{
    public class Credit
    {
        public double Amount { get; set; }
        public double InterestRate { get; set; }
        public int TermInMonths { get; set; }

        private double totalAmountToPay;
        private double monthAmountToPay;

        public double CalculateTotalAmountToPay()
        {
            return totalAmountToPay=Amount*(1+InterestRate);
        }

        public double CalculateMonthAmountToPay()
        {
            return monthAmountToPay=totalAmountToPay/TermInMonths;
        }
    }
}
