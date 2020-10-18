using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankingApplication.addOn
{
    public static class Extensions
    {
        public static double getPercentageChange(double a, double b)
        {
            double increase = Math.Round(((a / b) * 100), 2);
            return increase;
        }
    }
}
