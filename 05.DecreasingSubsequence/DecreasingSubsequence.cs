using System;
using System.Collections.Generic;

namespace _05.DecreasingSubsequence
{
    class DecreasingSubsequence
    {
        static void Main()
        {
            string[] symbols = Console.ReadLine().Split(' ');
            string subSeqStr = symbols[0];
            string tempStr = symbols[0];
            int count = 1;
            int temp = 0;
            for (int i = 0; i < symbols.GetLength(0); i++)
            {
                if (symbols.GetLength(0) - i > count)
                {
                    for (int j = i + 1; j < symbols.GetLength(0); j++)
                    {
                        
                    }
                }
            }
        }
    }
}
