using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.ExtractURL
{
    class ExtractURL
    {
        static void Main()
        {
            string text = Console.ReadLine();
            var urls = text.Split(' ').Where(s => 
                s.StartsWith("http://") || 
                s.StartsWith("www.") || 
                s.StartsWith("https://"));
            foreach (var v in urls)
            {
                Console.WriteLine(v);
            }
        }
    }
}
