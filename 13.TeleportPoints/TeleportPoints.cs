using System;
using System.Collections.Generic;

namespace TeleportingPoints
{
    class Teleportingpoints
    {
        static void Main()
        {
            List<string> coordinates = new List<string>();
            double radius;
            double step;
            double[] dimensions = new double[4];
            string[] helper;
            int counter = 0;
            for (int i = 0; i < 4; i++)
            {
                coordinates.Add(Console.ReadLine());
            }
            radius = double.Parse(Console.ReadLine());
            step = double.Parse(Console.ReadLine());
            helper = coordinates[0].Split(' ');
            dimensions[0] = double.Parse(helper[0]);
            dimensions[2] = double.Parse(helper[1]);
            helper = coordinates[2].Split(' ');
            dimensions[1] = double.Parse(helper[0]);
            dimensions[3] = double.Parse(helper[1]);
            for (double i = 0; i <= radius; i += step)
            {
                for (double j = 0; j <= radius; j += step)
                {
                    if (Math.Pow(i, 2) + Math.Pow(j, 2) <= Math.Pow(radius, 2))
                    {
                        if ((i > dimensions[0] && i < dimensions[1]) && (j > dimensions[2] && j < dimensions[3]))
                        {
                            counter++;
                        }
                    }
                }
                for (double j = -step; j >= -radius; j -= step)
                {
                    if (Math.Pow(i, 2) + Math.Pow(j, 2) <= Math.Pow(radius, 2))
                    {
                        if ((i > dimensions[0] && i < dimensions[1]) && (j > dimensions[2] && j < dimensions[3]))
                        {
                            counter++;
                        }
                    }
                }
            }
            for (double i = -step; i >= -radius; i -= step)
            {
                for (double j = 0; j <= radius; j += step)
                {
                    if (Math.Pow(i, 2) + Math.Pow(j, 2) <= Math.Pow(radius, 2))
                    {
                        if ((i > dimensions[0] && i < dimensions[1]) && (j > dimensions[2] && j < dimensions[3]))
                        {
                            counter++;
                        }
                    }
                }
                for (double j = -step; j >= -radius; j -= step)
                {
                    if (Math.Pow(i, 2) + Math.Pow(j, 2) <= Math.Pow(radius, 2))
                    {
                        if ((i > dimensions[0] && i < dimensions[1]) && (j > dimensions[2] && j < dimensions[3]))
                        {
                            counter++;
                        }
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}
