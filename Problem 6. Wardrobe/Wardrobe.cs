using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_6._Wardrobe
{
   public class Wardrobe
    {
       public static void Main()
        {
           Dictionary<string,Dictionary<string,int>> wardrobe =new Dictionary<string,Dictionary<string,int>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] text = Console.ReadLine()
                    .Split(new string[] { " -> ", "," }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

               
                    if (!wardrobe.ContainsKey(text[0]))
                    {
                        wardrobe[text[0]]= new Dictionary<string, int>();

                        for (int k = 1; k < text.Length; k++)
                        {
                            if (!wardrobe[text[0]].ContainsKey(text[k]))
                            {
                                wardrobe[text[0]][text[k]] = 0;
                            }
                           
                        }
                                             
                    }

                    for (int k = 1; k < text.Length ; k++)
                    {
                        if (!wardrobe[text[0]].ContainsKey(text[k]))
                        {
                            wardrobe[text[0]][text[k]] = 0;
                        }
                         wardrobe[text[0]][text[k]] += 1;
                }                                                   
            }

            string[] serchedItem = Console.ReadLine()
                .Split()
                .ToArray();

            foreach (var color in wardrobe)
            {
                Console.WriteLine($"{color.Key} clothes:");

                foreach (var item in color.Value)
                {
                    if (color.Key==serchedItem[0]&&item.Key==serchedItem[1])
                    {
                        Console.WriteLine($" * {item.Key} - {item.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($" * {item.Key} - {item.Value}");
                    }
                    
                }
            }
        }
    }
}
