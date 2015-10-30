using System;
using System.Collections.Generic;

namespace _08.LongestWord
{
    class LongestWord
    {
        static void Main()
        {
            List<string> text = new List<string>(Console.ReadLine().Split(' '));
            int lenght = 0;
            string word = string.Empty;
            foreach (string v in text)
            {
                if (lenght < v.Length)
                {
                    lenght = v.Length;
                    word = v.Replace('.', ' ');
                }
            }
            Console.WriteLine(word);
        }
    }
}
