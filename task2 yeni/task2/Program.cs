using System.Dynamic;

using System;

namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ededi daxil edin");
            string input1 = Console.ReadLine();
            int num1 = Convert.ToInt32(input1);

            if (num1 > 64&&num1<100)
            {
                Console.WriteLine("mezun oldunuz");
            }
            else if (num1 < 64&&num1>0)
            {
                Console.WriteLine("mezun olmadiniz");

            }
            if (num1 > 100)
            {
                Console.WriteLine("qiymeti duzgun daxil edin");
                
            }
            else if (num1 < 0)
            {
                Console.WriteLine("qiymeti duzgun daxil edin");
            }
        }
            
    }
}
