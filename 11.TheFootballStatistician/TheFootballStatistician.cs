using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace FootballStatistician
{
    class scoreTable
    {
        public string teamName { get; set; }
        public int score { get; set; }
        public override string ToString()
        {
            return teamName + " - " + score + " points.";
        }
        public void changeScore(int p)
        {
            score += p;
        }
    }
    class FootballStatistician
    {
        public static string convertStr(string str)
        {
            StringBuilder sb = new StringBuilder();
            bool check = false;
            foreach (char c in str)
            {
                if (char.IsUpper(c) && check)
                {
                    sb.Append(' ');
                }
                sb.Append(c);
                check = true;
            }
            return sb.ToString();
        }
        public static string removeSpace(string str)
        {
            StringBuilder sb = new StringBuilder();
            int a = 0;
            foreach (char c in str)
            {
                if (c == ' ')
                {
                    if (a == 0)
                    {
                        a = 1;
                        sb.Append(' ');
                    }
                }
                else
                {
                    sb.Append(c);
                    a = 0;
                }
            }
            return sb.ToString();
        }
        static void Main()
        {
            double price = double.Parse(Console.ReadLine());
            int matchesCount = 0;
            List<string> inputData = new List<string>();
            string input = String.Empty;
            while (input != "End of the league.")
            {
                input = Console.ReadLine();
                if (input != "End of the league.")
                {
                    inputData.Add(input);
                    matchesCount++;
                }
            }
            price = Math.Abs(price) * matchesCount * 1.94d;
            List<scoreTable> FinallTable = new List<scoreTable>();
            FinallTable.Add(new scoreTable { teamName = "Arsenal", score = 0 });
            FinallTable.Add(new scoreTable { teamName = "Chelsea", score = 0 });
            FinallTable.Add(new scoreTable { teamName = "Manchester City", score = 0 });
            FinallTable.Add(new scoreTable { teamName = "Manchester United", score = 0 });
            FinallTable.Add(new scoreTable { teamName = "Liverpool", score = 0 });
            FinallTable.Add(new scoreTable { teamName = "Everton", score = 0 });
            FinallTable.Add(new scoreTable { teamName = "Southampton", score = 0 });
            FinallTable.Add(new scoreTable { teamName = "Tottenham", score = 0 });
            int index;
            foreach (string v in inputData)
            {
                string[] check = removeSpace(v).Split();
                check[0] = convertStr(check[0]);
                check[2] = convertStr(check[2]);
                if (check[1] == "1")
                {
                    index = FinallTable.FindIndex(s => s.teamName.Contains(check[0]));
                    FinallTable[index].changeScore(3);
                }
                else if (check[1] == "2")
                {
                    index = FinallTable.FindIndex(s => s.teamName.Contains(check[2]));
                    FinallTable[index].changeScore(3);
                }
                else if (check[1] == "x" || check[1] == "X")
                {
                    index = FinallTable.FindIndex(s => s.teamName.Contains(check[0]));
                    FinallTable[index].changeScore(1);
                    index = FinallTable.FindIndex(s => s.teamName.Contains(check[2]));
                    FinallTable[index].changeScore(1);
                }
            }
            FinallTable.Sort(delegate(scoreTable x, scoreTable y)
            {
                if (x.teamName == null && y.teamName == null) return 0;
                else if (x.teamName == null) return -1;
                else if (y.teamName == null) return 1;
                else return x.teamName.CompareTo(y.teamName);
            });
            Console.WriteLine("{0:F2}lv.", Math.Round(price, 2));
            foreach (scoreTable v in FinallTable)
            {
                Console.WriteLine(v);
            }
        }
    }
}
