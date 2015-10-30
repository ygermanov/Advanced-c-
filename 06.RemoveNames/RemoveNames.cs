using System;
namespace _06.RemoveNames
{
    class RemoveNames
    {
        static bool Contains(string[] one, string two)
        {
            foreach (string v in one)
            {
                if (v == two)
                {
                    return true;
                }
            }
            return false;
        }
        static void Main()
        {
            string[] firstLine = Console.ReadLine().Split(' ');
            string[] secondLine = Console.ReadLine().Split(' ');
            foreach (string v in firstLine)
            {
                if (!Contains(secondLine, v))
                {
                    Console.Write(v + " ");
                }
                
            }
            Console.WriteLine();
        }
    }
}
