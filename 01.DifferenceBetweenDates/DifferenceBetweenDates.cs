using System;

namespace _01.DifferenceBetweenDates
{
    class DifferenceBetweenDates
    {
        static void Main()
        {
            DateTime first = DateTime.Parse(Console.ReadLine());
            DateTime second = DateTime.Parse(Console.ReadLine());
            Console.WriteLine((second - first).Days);
        }
    }
}
