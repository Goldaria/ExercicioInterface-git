using System;

namespace ExercicioInterface.Entities
{
    class Installments
    {
        public DateTime dueDate { get; set; }
        public double amount { get; set; }        

        public Installments(DateTime dueDate, double amount)
        {
            this.dueDate = dueDate;
            this.amount = amount;            
        }
    }
}
