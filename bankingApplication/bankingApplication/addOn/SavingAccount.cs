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
            startingBalance = sb;
            annualInterest = ai;
        }

        public void MakeWithdraw(double wValue)
        {
            var accStat = AccountStatus.active;
            if (accStat == AccountStatus.active)
            {
                base.MakeWithdrawl(wValue);
            }
            else
            {
                Console.WriteLine("Account is inactive. Sorry for the inconvenience");
            }
        }
        
        public void MakeADeposit(double dValue)
        {
            var accStat = AccountStatus.active;
            if (accStat == AccountStatus.active)
            {
                if (dValue > 25)
                {
                    base.MakeDeposit(dValue);
                }
                else
                {
                    Console.WriteLine("Entered amount need to be higher than $25.00");
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
