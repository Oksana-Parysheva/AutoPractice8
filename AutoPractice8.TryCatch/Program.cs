using System;

namespace AutoPractice8.TryCatch
{
    class Program
    {
        static void Main()
        {
            label:
            try
            {
                decimal num1, num2, result;

                Console.WriteLine("Divide App. You have to enter 2 numbers");
                Console.Write("\tEnter 1st number: ");
                num1 = Convert.ToDecimal(Console.ReadLine());
                Console.Write("\tEnter 2nd number: ");
                num2 = Convert.ToDecimal(Console.ReadLine());

                result = num1 / num2;
                Console.WriteLine("\n\tDivide: {0}\n", result);
            }
            catch (DivideByZeroException dex)
            {
                Console.WriteLine("EXCEPTION");
                Console.WriteLine("You have entered 0");
                Console.WriteLine("More details about error: \n\n{0}\n\n", dex);
                throw;
                goto label;
            }
            catch (FormatException fex) when (fex.Message != null)
            {
                Console.WriteLine("EXCEPTION");
                Console.WriteLine("Invalid input");
                Console.WriteLine("More details about error: \n\n{0}\n\n", fex);
                throw new InvalidOperationException("Use a more friendly message", fex);
            }
            catch (Exception ex)
            {
                Console.WriteLine("EXCEPTION");
                Console.WriteLine("\nOther exception raised {0}\n\n", ex);
            }
            finally
            {
                Console.WriteLine("Finally block: to continue press enter and for Exit press Ctrl + c\n");
                Console.ReadLine();
            }
        }
    }
}
