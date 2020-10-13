using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankingApplication.addOn
{
    class ChequingAccount : Account
    {

        public ChequingAccount(double sb, double ai) : base(sb, ai)
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
    }
}
