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
            Console.WriteLine("******************** DAY 1 ********************");
            Console.WriteLine("Part1 = " + Day1.part1());
            Console.WriteLine("Part2 = " + Day1.part2());
            Console.WriteLine("***********************************************");
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            Day1.display();
        }
    }


}
