using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreoExpress
{
    internal class Workers
    {
        public decimal Payment { get; set; }
        public int Hours { get; set; }
        public int NumberOfWorkers { get; set; }
        public decimal TotalSumma { get; set; }
        public decimal TotalSummaWorkers { get; set; }
        public decimal TotalSummaWithVat { get; set; }
        public decimal Vat { get; set; }
        public decimal Rut { get; set; }

        public decimal TotalPriceWithVat(int hours, int numbersOfWorkers)
        {
            decimal total = ((numbersOfWorkers * hours) * Payment);
            decimal summaWithVat = total * Vat;
            return summaWithVat;
        }

        public decimal TotalPriceForAllWorkers(decimal drivers, decimal loaders)
        {
            decimal total = drivers + loaders;
            return total;
        }

        public decimal Rutavdrag(decimal summa)
        {
            decimal rut = Convert.ToDecimal(0.5);
            decimal total = summa * rut;
            return total;
        }
    }
}
