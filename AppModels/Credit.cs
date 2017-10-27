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
        private double remainder;

        public double CalculateTotalAmountToPay(double amount, double interestRate)
        {


            return totalAmountToPay;
        }

        public double CalculateMonthAmountToPay(double amount, double interestRate, int termInMonths)
        {


            return monthAmountToPay;
        }

        public double CalculateRemainder()
        {


            return remainder;
        }
    }
}
