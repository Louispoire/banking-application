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
            var accStat = AccountStatus.inactive;
            if(startingBalance > 25 && accStat == AccountStatus.inactive) {
                accStat = AccountStatus.active;
                base.MakeWithdrawl(wValue);
                if (currentBalance < 25)
                    accStat = AccountStatus.inactive; 
            }
            else
            {
                Console.WriteLine("Account is inactive. Sorry for the inconvenience");
            }
        }
        
        public void MakeADeposit(double dValue)
        {
            var accStat = AccountStatus.inactive;
            if (accStat == AccountStatus.inactive)
            {
                base.MakeDeposit(dValue);
                if (currentBalance > 25)
                {
                   accStat = AccountStatus.active;
                }
                else
                {
                    Console.WriteLine("To activate the account please enter an amount to make the balance higher than $25.00 \nCurrent Balance: " + currentBalance);
                }
            }
            else
            {
                Console.WriteLine("Account is inactive. Sorry for the inconvenience");
            }

        }
        public void closeAndReportSaving()
        {
            if (amountOfWithdrawal > 4)
            {
                serviceCharge += 1;
                Console.WriteLine("A service charge of of $1 has been added. Total service charge: " + serviceCharge+".");
                base.closeAndReport();
            }
            else
            {
                Console.WriteLine("No service charge has been added.");
                base.closeAndReport();
            }


        }

    }
}
