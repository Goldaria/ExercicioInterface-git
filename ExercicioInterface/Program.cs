using System;
using System.Globalization;
using ExercicioInterface.Entities;

namespace ExercicioInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());

            Console.Write("Date (dd/MM/yyyy): ");
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

            Console.Write("Contract value: ");
            double totalValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Enter number of installments: ");
            int installmentsQte = int.Parse(Console.ReadLine());

            Contract contracts = new Contract(number, date, totalValue, installmentsQte);

            Console.WriteLine(contracts);

            Console.ReadLine();
        }
    }
}
