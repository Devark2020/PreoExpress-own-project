using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreoExpress
{
    internal class Loader : Workers
    {
        public decimal Total(int numberOfLoaders, int hours)
        {
            decimal summa = (numberOfLoaders * Payment) * hours;
            return summa;
        }
    }
}
