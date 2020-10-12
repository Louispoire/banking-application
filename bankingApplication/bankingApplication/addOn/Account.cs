using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankingApplication.addOn
{
    abstract class Account : IAccount
    {
        public double startingBalance;
        public double currentBalance;
        public int amountOfDeposit = 0;
        public double cumulatedAmountOfDeposit = 0;
        public int amountOfWithdrawal = 0;
        public double cumulatedAmountOfWithdrawal = 0;
        public double annualInterest = 0.0;
        public double serviceCharge = 0.0;

        public Account(double sb, double ai)
        {
            startingBalance = sb;
            annualInterest = ai;
        }

        public void CaclculateInterest()
        {
            double monthlyInterestRate = (annualInterest / 12);
            double monthlyInterest = currentBalance * monthlyInterestRate;
            currentBalance = currentBalance + monthlyInterest;
            
        }

        public string closeAndReport()
        {
            currentBalance -= serviceCharge;
            CaclculateInterest();
            amountOfDeposit = 0;
            amountOfWithdrawal = 0;
            cumulatedAmountOfDeposit = 0;
            cumulatedAmountOfWithdrawal = 0;
            double increase = (startingBalance - currentBalance) * 100;
            string report = "Previous Balance = " +startingBalance+ " | New Balance: " +currentBalance+ " \nYour account has seen an increase of "+increase+"% in terms of value";
            return report;


        }

        public void MakeDeposit(double amount)
        {
            currentBalance += amount;
            amountOfDeposit++;
            cumulatedAmountOfDeposit += amount;
            Console.WriteLine("Amount of: " + amount + " has been deposit. You have now "+currentBalance+" in your account!");
        }

        public void MakeWithdrawl(double amount)
        {
            currentBalance -= amount;
            amountOfWithdrawal++;
            cumulatedAmountOfWithdrawal += amount;
            Console.WriteLine("Amount of: " + amount + " has been withdrawned. You have now "+currentBalance+" in your account!");
        }
    }
}
