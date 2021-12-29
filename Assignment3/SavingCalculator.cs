using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class SavingCalculator
    {
        //This class do not interact with the user in any way.
        //This class i created to use the given input and make some 
        //calculation to get a visual of the saving increse.
        private double deposit;
        private int period;
        private double intrestRate = 0.10 / 12; //a yearly intrest at 10%
        private double balance;
        public double GetDeposit()
        {
            return deposit;
        }
        public void SetDeposit(double deposit)
        {
            if (deposit >= 0.0)
                this.deposit = deposit;
        }
        public int GetPeriod()
        {
            return period;
        }
        public void SetPeriod(int period)
        {
            if (period >= 0.0)
                this.period = period;
        }
        public double GetBalance()
        {
            return balance;
        }


        public int calculateMonth()
        {//method that reform years to months
            int months = period * 12;
            return months;
        } 

        public string calculateBalance()
        {
            //calulates the savning balance
            int months = calculateMonth();
            balance = deposit;
            for (int i = 0; i < months; i++)
            {
                double interestEarned = intrestRate * balance;
                balance += interestEarned + deposit;
            }
            return balance.ToString("0.00");
        }
        public string calculatePaid()
        { // caluclation the full paid amout without intrest
            int months = calculateMonth();
            double paid = deposit * months;
            return paid.ToString();
        }

    }
}
