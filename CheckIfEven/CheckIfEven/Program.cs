using System;

namespace CheckIfEven
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            Console.Write("Enter the number: ");
            i = int.Parse(Console.ReadLine());
            if (i % 2 == 0)
            {
                Console.Write("The number is even.");
                Console.Read();
            }
            else
            {
                Console.Write("The number is odd.");
                Console.Read();
            }
        }
    }
}
