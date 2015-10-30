using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.LongestAreaArray
{
    class Program
    {
        static void Main()
        {
            List<string> strings = new List<string>();
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                strings.Add(Console.ReadLine());
            }
            var groupStr =
                from str in strings
                group str by str into grpStr
                select new { grpStr.Key, Count = grpStr.Count() };
            int maxCount = 0;
            string word = string.Empty;
            foreach (var v in groupStr)
            {
                if (maxCount < v.Count)
                {
                    maxCount = v.Count;
                    word = v.Key;
                }
            }
            Console.WriteLine(maxCount);
            for (int i = 0; i < maxCount; i++)
            {
                Console.WriteLine(word);
            }
        }
    }
}
