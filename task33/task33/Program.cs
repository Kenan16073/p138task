using System;

namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, -8 };
            var count = 0;
            for (int i=0;i<arr.Length;i++)
            {
                if (arr[i] < 0)
                {
                    count++;
                    Console.WriteLine(arr[i]);
                }
            }
            if (count== 0)
            {
                Console.WriteLine("menfi eded yoxdur");
            }
        }
    }
}
