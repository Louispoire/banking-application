using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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
            if (currentBalance - wValue < 0)
            {
                serviceCharge += 15.00;
                Console.WriteLine("\nSorry, you don't have sufficient funds for the withdrawawl.");
            }
            else
            {
                base.MakeWithdrawl(wValue);
            }
        }

        public void MakeADeposit(double dValue)
        {
            base.MakeDeposit(dValue);
        }

        public void closeAndReportChequing()
        {
            var montlhyFee = 5.00;
            var extraFee = amountOfWithdrawal * 0.10;
            var fee = (montlhyFee + extraFee + serviceCharge);
            currentBalance -= fee;
            Console.WriteLine("A service charge of " + extraFee.ToString("0.00") + " has been added. Total service charge: " + fee.ToString("0.00") + ".");
            Console.WriteLine(base.closeAndReport());
        }
    }
}
