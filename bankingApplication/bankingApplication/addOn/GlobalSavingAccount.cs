using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace bankingApplication.addOn
{
    class GlobalSavingAccount : SavingAccount, IExchangeable
    {
        public GlobalSavingAccount(double sb, double ai) : base(sb, ai)
        {
            startingBalance = sb;
            annualInterest = ai;
        }

        public double USValue (double rate)
        {
            double tempBalance = currentBalance;
            return (tempBalance *= rate);
        }
    }
}
