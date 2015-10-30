using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.SortingNumbers
{
    class SortingNumbers
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            List<int> numbers = new List<int>();
            for (int i = 0; i < number; i++)
            {
                numbers.Add(int.Parse(Console.ReadLine()));
            }
            numbers.Sort();
            foreach (int v in numbers)
            {
                Console.WriteLine(v);
            }
        }
    }
}
