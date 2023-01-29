using System;
using System.Diagnostics.CodeAnalysis;

namespace task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 535;
            int sum = 0;
            while (num > 0)
            {
                sum += num % 10;
                num= num / 10;
            }
            Console.WriteLine(sum);
        }
    }
}
