using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace aoc2020
{

    class Day1
    {
        public static int part1() 
        {
            string filePath = "./input.txt";
            List<string> lines = File.ReadAllLines(filePath).ToList();

            for (int i = 0; i < lines.Count; i++)
            {
                for (int j = 1; j < lines.Count - 1; j++)
                {
                    int a = int.Parse(lines[i]);
                    int b = int.Parse(lines[j]);
                    if (a + b == 2020)
                    {
                        return a * b;
                    }
                }
                lines.RemoveAt(i);
            }
            return -1;
        }

        public static int part2()
        {
            string filePath = "./input.txt";
            List<string> lines = File.ReadAllLines(filePath).ToList();

            for (int i = 0; i < lines.Count; i++)
            {
                for (int j = 1; j < lines.Count - 1; j++)
                {
                    for (int k = 2; k < lines.Count - 2; k++)
                    {
                        int a = int.Parse(lines[i]);
                        int b = int.Parse(lines[j]);
                        int c = int.Parse(lines[k]);

                        if ((a + b + c) == 2020)
                        {
                            return a * b * c;
                        }
                    }
                }
                lines.RemoveAt(i);
            }
            return -1;
        }

        public static void display()
        {
            Console.WriteLine("\n******************** DAY 1 ********************");
            Console.WriteLine("Part1 = " + Day1.part1());
            Console.WriteLine("Part2 = " + Day1.part2());
            Console.WriteLine("***********************************************");
        }

    }

    class Day2
    {
        public static int part1() 
        {
            string filePath = "./input_Day2.txt";
            List<string> lines = File.ReadAllLines(filePath).ToList();

            int res = 0;

            for (int i = 0; i < lines.Count; i++)
            {
                string line = lines[i];

                char[] separators = new char[] { ' ', '-', ':' };
                string[] subs = line.Split(separators, StringSplitOptions.RemoveEmptyEntries);

                int policyMin = int.Parse(subs[0]);
                int policyMax = int.Parse(subs[1]);
                char letter = char.Parse(subs[2]);
                string password = subs[3];
                // Console.WriteLine($"{i} {policyMin} {policyMax} {letter} {password} ");

                int freq = password.Count(f => (f == letter));
                if (freq >= policyMin && freq <= policyMax)
                {
                    res++;
                }
            }
            return res;
        }

        public static int part2()
        {
            string filePath = "./input_Day2.txt";
            List<string> lines = File.ReadAllLines(filePath).ToList();

            int res = 0;

            for (int i = 0; i < lines.Count; i++)
            {
                string line = lines[i];

                char[] separators = new char[] { ' ', '-', ':' };
                string[] subs = line.Split(separators, StringSplitOptions.RemoveEmptyEntries);

                int index1 = int.Parse(subs[0]);
                int index2 = int.Parse(subs[1]);
                char letter = char.Parse(subs[2]);
                string password = subs[3];
                // Console.WriteLine($"{i} {index1} {index2} {letter} {password} ");

                if (password[index1 - 1] == letter && password[index2 - 1] != letter)
                {
                    res++;
                }
                if (password[index1 - 1] != letter && password[index2 - 1] == letter)
                {
                    res++;
                }
            }
            return res;
        }

        public static void display()
        {
            Console.WriteLine("\n******************** DAY 2 ********************");
            Console.WriteLine("Part1 = " + Day2.part1());
            Console.WriteLine("Part2 = " + Day2.part2());
            Console.WriteLine("***********************************************");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Day1.display();
            Day2.display();
        }
    }


}
