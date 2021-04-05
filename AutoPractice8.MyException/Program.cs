using System;

namespace AutoPractice8.MyException
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalAmount = 10;
            Console.Write("Welcome to Shopping site!\nHow many headphones you want to buy (Total 10 in stock): ");
            int acceptOrder = Convert.ToInt32(Console.ReadLine());
            try
            {
                if (acceptOrder == totalAmount || acceptOrder < totalAmount)
                {
                    Console.WriteLine("\tCongratulations! You have bought {0} headphones\n\n", acceptOrder);
                }
                else
                {
                    throw new OutOfStockException("\nOutOfStockException. The number of items you want to buy is out of stock.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}