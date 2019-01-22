using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_3._Periodic_Table
{
    public class PeriodicTable
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            SortedSet<string> periodtabel= new SortedSet<string>();

            for (int i = 0; i < n; i++)
            {
                string[] text = Console.ReadLine()
                    .Split(" ")
                    .ToArray();
                for (int j = 0; j < text.Length ; j++)
                {
                    periodtabel.Add(text[j]);
                }             
            }
            Console.WriteLine(string.Join(" ",periodtabel));
        }
    }
}
