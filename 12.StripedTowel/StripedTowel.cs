using System;

namespace StripedTowel
{
    class StripedTowel
    {
        static void Main()
        {
            char[] symbols = { '#', '.', '.' };
            int width = int.Parse(Console.ReadLine());
            int height = (int)Math.Floor(width * 1.5);
            int symbCount = 0;
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (j == width - 1)
                    {
                        Console.Write("{0}\n", symbols[symbCount]);
                        symbCount = (i + 1) % 3;
                    }
                    else
                    {
                        Console.Write(symbols[symbCount]);
                        if (symbCount == 2) symbCount = 0;
                        else symbCount++;
                    }
                }
            }
        }
    }
}
