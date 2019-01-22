using System;
using System.Collections.Generic;

namespace Problem_4._Even_Times
{
     public class EvenTimes
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<int,int> evenNumbers = new Dictionary<int, int>();

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (!evenNumbers.ContainsKey(number))
                {
                    evenNumbers[number] = 0;
                }

                evenNumbers[number] += 1;
            }

            foreach (var evenNumber in evenNumbers)
            {
                if (evenNumber.Value % 2 ==0)
                {
                    Console.WriteLine(evenNumber.Key); 
                }
                
            }
        }
    }
}
