using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdventOfConsole.Days
{
    public static class Day3
    {
        static List<List<String>> positions;
        static List<String> intersections;
        static List<int> results;

        internal static void christmassySolvePuzzleOne()
        {
            positions = new List<List<string>>();
            intersections = new List<string>();
            results = new List<int>();

            int counter = 0;

            foreach (string path in MainWindow.input.Text.Split("\r\n"))
            {
                int currentX = 0;
                int currentY = 0;
                List<String> position = new List<string>();
                foreach (string s in path.Split(","))
                {
                    switch (s.Substring(0, 1))
                    {
                        case "R":
                            for (counter = 1; counter <= int.Parse(s.Substring(1)); counter++)
                            {
                                currentX++;
                                position.Add(currentX + ":" + currentY);
                            }
                            break;
                        case "D":
                            for (counter = 1; counter <= int.Parse(s.Substring(1)); counter++)
                            {
                                currentY++;
                                position.Add(currentX + ":" + currentY);
                            }
                            break;
                        case "U":
                            for (counter = 1; counter <= int.Parse(s.Substring(1)); counter++)
                            {
                                currentY--;
                                position.Add(currentX + ":" + currentY);
                            }
                            break;
                        case "L":
                            for (counter = 1; counter <= int.Parse(s.Substring(1)); counter++)
                            {
                                currentX--;
                                position.Add(currentX + ":" + currentY);
                            }
                            break;
                    }
                }
                positions.Add(position);
            }

            var equals = positions[0].Intersect(positions[1]);

            foreach (String s in equals)
            {
                intersections.Add(s);
                results.Add(Math.Abs(int.Parse(s.Split(":")[0])) + Math.Abs(int.Parse(s.Split(":")[1])));
            }

            MainWindow.answerOne.Text = results.Min().ToString();
        }

        internal static void christmassySolvePuzzleTwo()
        {
            results.Clear();

            foreach (string inters in intersections)
            {
                results.Add(positions[0].IndexOf(inters) + positions[1].IndexOf(inters) + 2);
            }
            
            MainWindow.answerTwo.Text = results.Min().ToString();
        }
    }
}
