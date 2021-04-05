using System;

namespace AutoPractice8.GUID
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = Guid.NewGuid();
            Console.WriteLine(result);

            Console.WriteLine("Byte length: {0}", result.ToByteArray().Length);
            Guid obj = new Guid();
            Console.WriteLine(obj.ToString());

            Console.ReadLine();
        }
    }
}
