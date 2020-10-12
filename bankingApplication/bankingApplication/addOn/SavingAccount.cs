using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankingApplication.addOn
{
    class SavingAccount : Account
    {
        public SavingAccount(double sb, double ai) : base(sb, ai)
        {
        }

        public void MakeWithdraw(string aStatus)
        {
          
        }
        public void MakeADeposit(double amount)
        {
            currentBalance += amount;
            amountOfDeposit++;
            cumulatedAmountOfDeposit += amount;
            Console.WriteLine("Amount of: " + amount + " has been deposit. You have now " + currentBalance + " in your account!");
        }
    }
}
