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
            base.MakeWithdrawl(wValue);
            if (currentBalance < 0)
            {
                serviceCharge += 15;
                currentBalance += wValue;
            }

        }

        public void MakeADeposit(double dValue)
        {
            base.MakeDeposit(dValue);
        }

        public void closeAndReportChequing()
        {
            var montlhyFee = 5;
            var extraFee = amountOfWithdrawal * 0.10;
            var fee = (montlhyFee + extraFee + serviceCharge);
            currentBalance -= fee;
            Console.WriteLine("A service charge of of " + extraFee + " has been added. Total service charge: " + fee + ".");
            base.closeAndReport();
        }
    }
}
