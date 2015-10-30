using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.JoinLists
{
    class JoinLists
    {
        static void Main()
        {
            List<string> firstLine = new List<string>(Console.ReadLine().Split(' '));
            List<string> secondLine = new List<string>(Console.ReadLine().Split(' '));
            foreach (string v in secondLine)
            {
                firstLine.Add(v);
            }
            var groupStr =
                from str in firstLine
                group str by str into grpStr
                select new { grpStr.Key};
            secondLine = new List<string>();
            foreach (var v in groupStr)
            {
                secondLine.Add(v.Key);
            }
            secondLine.Sort();
            foreach (string v in secondLine)
            {
                Console.Write(v + " ");
            }
            Console.WriteLine();
        }
    }
}
