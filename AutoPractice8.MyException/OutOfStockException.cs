using System;

namespace AutoPractice8.MyException
{
    public class OutOfStockException : Exception
    {
        public OutOfStockException(string message)
            : base(message)
        {
        }
    }
}
