using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreoExpress
{
    internal class Driver : Workers
    {
        public int Miltal { get; set; }
        public decimal MilePrice { get; set; }
        public decimal TotalPriceForMiles { get; set; }

        public decimal Total(int numberOfDrivers, int hours)
        {
            decimal summa = (numberOfDrivers * Payment) * hours;
            return summa;
        }
        public decimal TotalWithMile(int numbersOfDrivers, int hours)
        {
            decimal summa = ((numbersOfDrivers * Payment) * hours) + TotalPriceForMiles;
            return summa;
        }

    }
}
