using System;
using System.CodeDom;
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
            startingBalance = sb;
            annualInterest = ai;
        }

        public void MakeWithdraw(double wValue)
        {
            if (currentBalance > 25)
            {
                accountStatus = AccountStatus.active;
                if(currentBalance - wValue < 0) //Exception
                {
                    Console.WriteLine("\nSorry, you don't have sufficient funds for this withdrawawl.");
                }
                else
                {
                    base.MakeWithdrawl(wValue);
                }
            }
            else
            {
                accountStatus = AccountStatus.inactive;
                Console.WriteLine("Your account is inactive." 
                    + "\nYour account hasn't been charged. You still have $" + currentBalance.ToString("0.00") + " in your account.");
            }
        }
        
        public void MakeADeposit(double dValue)
        {
            base.MakeDeposit(dValue);
            if (currentBalance + dValue > 25)
                accountStatus = AccountStatus.active;
        }
        public void closeAndReportSaving()
        {
            if (amountOfWithdrawal > 4)
            {
                serviceCharge += 1;
                Console.WriteLine("A service charge of of $1 has been added. Total service charge: " + serviceCharge.ToString("0.00") + ".\n Your account is " +accountStatus);
                Console.WriteLine(base.closeAndReport());
            }
            else
            {
                Console.WriteLine("No service charge has been added. \nYour account is " + accountStatus);
                Console.WriteLine(base.closeAndReport());
            }
        }
    }
}
