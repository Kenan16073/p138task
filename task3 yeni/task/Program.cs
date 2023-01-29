using System;

namespace task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 42, 84, 55, 60 };
            double sum = 0;
            double count = 0;
            for (int i = 0; i < arr.Length; i++) 
            {
                if (arr [i] % 21 == 0)
                {
                    sum += arr[i];
                        count++;
                }
                
                
                  
                
            }
                 Console.WriteLine(sum/count);

        }
    }
}
