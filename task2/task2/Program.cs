using System;

namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {65,7771657,753,387,4896,5445,};
            var max = 0;
            for(int i=0;i<arr.Length;i++)
            {
                if(arr[i] >max)
                    max= arr[i];
            }
            Console.WriteLine(max);
        }
    }
}
