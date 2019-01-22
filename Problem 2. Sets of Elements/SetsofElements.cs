using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace Problem_2._Sets_of_Elements
{
    public class SetsofElements
    {
        public static void Main()
        {
            int[] dimentions = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int n = dimentions[0];

            int m = dimentions[1];

            Dictionary<int, int> dictionary = new Dictionary<int, int>();
            HashSet<int> set1 = new HashSet<int>();
            HashSet<int> set2 =new HashSet<int>();
            HashSet<int> result=new HashSet<int>();
            for (int i = 0; i < n; i++)
            {
                set1.Add(int.Parse(Console.ReadLine()));
            }

            for (int i = 0; i < m; i++)
            {
                set2.Add(int.Parse(Console.ReadLine()));
            }

            foreach (var item in set1)
            {               
               foreach (var item2 in set2)
               {
                  if (item == item2)
                  {
                      result.Add(item);
                  }
                      
               }
                
            }
            Console.WriteLine(string.Join(" ",result));
        }
    }
}
