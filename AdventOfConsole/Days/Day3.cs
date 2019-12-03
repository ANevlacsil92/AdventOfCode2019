using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdventOfConsole.Days
{
    public static class Day3
    {
        internal static void christmassySolvePuzzleOne()
        {
            List<List<String>> positions = new List<List<String>>();

            int counter;
            int currentX = 0;
            int currentY = 0;

            foreach(string path in MainWindow.input.Text.Split("\r\n"))
            {
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

            foreach(String s in equals)
            {
                currSum = Math.Abs(int.Parse(s.Split(":")[0])) + Math.Abs(int.Parse(s.Split(":")[1]));
                if (tmpSum == -1 || tmpSum > currSum)
                {
                    tmpSum = currSum;
                    tmpVal = s;
                }
            }

            MainWindow.answerOne.Text = tmpSum.ToString();
        }

        internal static void christmassySolvePuzzleTwo()
        {

            int count = 0;

            foreach (string i in MainWindow.input.Text.Split("\r\n"))
            {
                count += (int.Parse(i)) / 3 - 2;
            }
            MainWindow.answerOne.Text = count.ToString();
        }
    }
}
