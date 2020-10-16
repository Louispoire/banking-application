using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankingApplication.addOn
{
    abstract class Account : IAccount
    {
        public bool reportLimit = true;
        public double startingBalance;
        public double currentBalance;
        public int amountOfDeposit = 0;
        public double cumulatedAmountOfDeposit = 0;
        public int amountOfWithdrawal = 0;
        public double cumulatedAmountOfWithdrawal = 0;
        public double annualInterest;
        public double serviceCharge = 0.0;
        public AccountStatus accountStatus;

        public Account(double sb, double ai)
        {
            startingBalance = sb;
            currentBalance += sb;
            annualInterest = ai;
        }

        public void CaclculateInterest()
        {
            double monthlyInterestRate = (annualInterest / 12);
            double monthlyInterest = currentBalance * monthlyInterestRate;
            currentBalance = currentBalance + monthlyInterest;  
        }

        /*
        public double getPercentageChange()
        {
            double increase = Math.Round(((currentBalance / startingBalance) * 100), 2);
            return increase;
        }
        */

        public string closeAndReport()
        {
            currentBalance -= serviceCharge;
            CaclculateInterest();
            double a = Extensions.getPercentageChange(currentBalance,startingBalance);
            amountOfDeposit = 0;
            amountOfWithdrawal = 0;
            cumulatedAmountOfDeposit = 0;
            cumulatedAmountOfWithdrawal = 0;
            Math.Round(currentBalance, 2);
            Math.Round(startingBalance, 2);
            if (startingBalance > currentBalance)
            {
                string report = "Previous Balance = $" + startingBalance.ToString("0.00") + " | New Balance: $" + currentBalance.ToString("0.00 ") +
                    "\nYour account has seen a decrease of -" + a + "% in terms of value";
                startingBalance = currentBalance;
                reportLimit = true;
                return report;
            }
            else
            {
                string report = "Previous Balance = $" + startingBalance.ToString("0.00") + " | New Balance: $" + currentBalance.ToString("0.00 ") +
                    "\nYour account has seen an increase of " + a + "% in terms of value";
                startingBalance = currentBalance;
                reportLimit = true;
                return report;
            }
        }

        public void MakeDeposit(double amount)
        {
            reportLimit = false;
            currentBalance += amount;
            amountOfDeposit++;
            cumulatedAmountOfDeposit += amount;
            Math.Round(currentBalance, 2);
            Console.WriteLine("Amount of: $" + amount.ToString("0.00") + " has been deposit. You have now $"+ currentBalance.ToString("0.00") +" in your account!");
        }

        public void MakeWithdrawl(double amount)
        {
            reportLimit = false;
            currentBalance -= amount;
            amountOfWithdrawal++;
            cumulatedAmountOfWithdrawal += amount;
            Math.Round(currentBalance, 2);
            Console.WriteLine("Amount of: $" + amount.ToString("0.00") + " has been withdrawned. You have now $"+ currentBalance.ToString("0.00") + " in your account!");
        }
    }
}
