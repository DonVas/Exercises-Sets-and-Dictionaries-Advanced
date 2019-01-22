using System;
using System.Collections.Generic;

namespace Problem_5._Count_Symbols
{
    public class CountSymbols
    {
        public static void Main()
        {

            char[] text = Console.ReadLine().ToCharArray();
            SortedDictionary<char,int> rechnik=new SortedDictionary<char, int>();
            
            foreach (var charecter in text)
            {
                if (!rechnik.ContainsKey(charecter))
                {
                    rechnik[charecter] = 0;
                }
                rechnik[charecter] += 1;
            }

            foreach (var simbol in rechnik)
            {
                Console.WriteLine($"{simbol.Key}: {simbol.Value} time/s");
            }
        }
    }
}
