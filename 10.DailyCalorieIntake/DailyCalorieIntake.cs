using System;

namespace DailyCalorieIntake
{
    class DailyCalorieIntake
    {
        static void Main()
        {
            int weight = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            int age = int.Parse(Console.ReadLine());
            char gender = char.Parse(Console.ReadLine());
            int workoutsPerWeek = int.Parse(Console.ReadLine());
            double calorieIntakeMale = (66.5d + (13.75d * (weight / 2.2d)) + (5.003d * (height * 2.54d)) - (6.755d * age));
            double calorieIntakeFemale = (655 + (9.563d * (weight / 2.2d)) + (1.850d * (height * 2.54d)) - (4.676d * age));
            if (gender == 'm' || gender == 'M')
            {
                if (workoutsPerWeek <= 0)
                {
                    calorieIntakeMale *= 1.2d;
                    Console.WriteLine(Math.Floor(calorieIntakeMale));
                }
                else if (workoutsPerWeek >= 1 && workoutsPerWeek <= 3)
                {
                    calorieIntakeMale *= 1.375d;
                    Console.WriteLine(Math.Floor(calorieIntakeMale));
                }
                else if (workoutsPerWeek >= 4 && workoutsPerWeek <= 6)
                {
                    calorieIntakeMale *= 1.55d;
                    Console.WriteLine(Math.Floor(calorieIntakeMale));
                }
                else if (workoutsPerWeek >= 7 && workoutsPerWeek <= 9)
                {
                    calorieIntakeMale *= 1.725d;
                    Console.WriteLine(Math.Floor(calorieIntakeMale));
                }
                else
                {
                    calorieIntakeMale *= 1.9d;
                    Console.WriteLine(Math.Floor(calorieIntakeMale));
                }
            }
            else
            {
                if (workoutsPerWeek <= 0)
                {
                    calorieIntakeFemale *= 1.2d;
                    Console.WriteLine(Math.Floor(calorieIntakeFemale));
                }
                else if (workoutsPerWeek >= 1 && workoutsPerWeek <= 3)
                {
                    calorieIntakeFemale *= 1.375d;
                    Console.WriteLine(Math.Floor(calorieIntakeFemale));
                }
                else if (workoutsPerWeek >= 4 && workoutsPerWeek <= 6)
                {
                    calorieIntakeFemale *= 1.55d;
                    Console.WriteLine(Math.Floor(calorieIntakeFemale));
                }
                else if (workoutsPerWeek >= 7 && workoutsPerWeek <= 9)
                {
                    calorieIntakeFemale *= 1.725d;
                    Console.WriteLine(Math.Floor(calorieIntakeFemale));
                }
                else
                {
                    calorieIntakeFemale *= 1.9d;
                    Console.WriteLine(Math.Floor(calorieIntakeFemale));
                }
            }


        }


    }
}
