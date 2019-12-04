using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdventOfConsole.Days
{
    public static class Day3
    {
        static List<List<String>> positions = new List<List<String>>();
        static string firstIntersection;
        internal static void christmassySolvePuzzleOne()
        {
            int counter;

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


            String tmpVal;
            int tmpSum = -1, currSum;
            bool hasFirst = false;
            foreach (String s in equals)
            {
                if (!hasFirst)
                {
                    hasFirst = true;
                    firstIntersection = s;
                }
                currSum = Math.Abs(int.Parse(s.Split(":")[0])) + Math.Abs(int.Parse(s.Split(":")[1]));
                if (tmpSum == -1 || tmpSum > currSum)
                {
                    tmpSum = currSum;
                    tmpVal = s;
                }
            }
        }

        internal static void christmassySolvePuzzleTwo()
        {

            int counter;
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

            MainWindow.answerOne.Text = count.ToString();
        }
    }
}
