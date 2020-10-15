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
            if (startingBalance > 25 || currentBalance > 25)
            {
                accountStatus = AccountStatus.active;
                if (accountStatus == AccountStatus.active)
                {
                    base.MakeWithdrawl(wValue);
                    if (currentBalance < 25)
                    {
                        accountStatus = AccountStatus.inactive;
                    }
                }
            }
            else
            {
                accountStatus = AccountStatus.inactive;
                Console.WriteLine("Account is inactive. Sorry for the inconvenience");
            }
        }
        
        public void MakeADeposit(double dValue)
        {
            base.MakeDeposit(dValue);
            if (startingBalance + dValue > 25 || currentBalance + dValue > 25)
            {
                accountStatus = AccountStatus.active;
            }
            else
            {
                accountStatus = AccountStatus.inactive;
                Console.WriteLine("To activate the account please enter an amount to make the balance higher than $25.00 \nCurrent Balance: " + currentBalance);
            }
        }
        public void closeAndReportSaving()
        {
            if (amountOfWithdrawal > 4)
            {
                serviceCharge += 1;
                Console.WriteLine("A service charge of of $1 has been added. Total service charge: " + serviceCharge+".");
                Console.WriteLine(base.closeAndReport());
            }
            else
            {
                Console.WriteLine("No service charge has been added.");
                Console.WriteLine(base.closeAndReport());
            }


        }

    }
}
