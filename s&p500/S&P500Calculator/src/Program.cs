using System;

namespace S&P500Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            Console.WriteLine("Welcome to the S&P 500 Dollar Average Cost Calculator!");

            Console.Write("Enter the total cost of the shares purchased: ");
            decimal totalCost = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Enter the total number of shares purchased: ");
            int totalShares = Convert.ToInt32(Console.ReadLine());

            decimal averageCost = calculator.CalculateAverageCost(totalCost, totalShares);

            Console.WriteLine($"The average cost per share is: {averageCost:C}");
        }
    }
}