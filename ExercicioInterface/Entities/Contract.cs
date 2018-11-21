using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioInterface.Entities
{
    class Contract
    {
        public int number { get; set; }
        public DateTime date { get; set; }
        public double totalValue { get; set; }
        public int installmentsQte { get; set; }
        public Installments[] installments { get; set; }

        public Contract(int number, DateTime date, double totalValue, int installmentsQte)
        {
            this.number = number;
            this.date = date;
            this.totalValue = totalValue;
            this.installmentsQte = installmentsQte;
        }

        public void installmentsValue()
        {
            double installmentsFracionate;

            installmentsFracionate = totalValue / installmentsQte;

            for (int i = 1; i <= installmentsQte; i++)
            {
                installmentsFracionate = (installmentsFracionate + (installmentsFracionate * 0.1)) * i;

                installmentsFracionate = installmentsFracionate + (installmentsFracionate * 0.2);                
            }
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
