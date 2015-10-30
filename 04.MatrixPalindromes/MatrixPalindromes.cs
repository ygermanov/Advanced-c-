using System;

namespace _04.MatrixPalindromes
{
    class MatrixPalindromes
    {
        static void Main()
        {
            char symbol = 'a';
            string[] matrix = Console.ReadLine().Split(' ');
            int x = int.Parse(matrix[0]);
            int y = int.Parse(matrix[1]);
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.Write("{0}{1}{0} ", symbol, (char)(symbol + j));
                }
                Console.WriteLine();
                symbol = (char)(symbol + 1);
            }
        }
    }
}
