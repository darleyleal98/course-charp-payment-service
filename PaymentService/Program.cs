using PaymentService.Entities.Exceptions;
using PaymentService.Entities;
using PaymentService.Services;
using System;

namespace PaymentSystem
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter contract data");
                Console.Write("Number: ");
                int numberOfContrat = int.Parse(Console.ReadLine());

                Console.Write("Date (dd/MM/yyyy): ");
                DateTime dateOfContract = DateTime.Parse(Console.ReadLine());

                Console.Write("Contract Value: ");
                double valueOfContract = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter the number of installments: ");
                int months = int.Parse(Console.ReadLine());

                for (int i = 0; i < months; i++)
                {
                    Contract contract = new Contract(numberOfContrat, dateOfContract, valueOfContract);
                }
            }
            catch(PaymentException exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}