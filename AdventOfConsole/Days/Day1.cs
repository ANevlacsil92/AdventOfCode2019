using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfConsole.Days
{
    public static class Day1
    {
        internal static void christmassySolvePuzzleOne()
        {
            int count = 0;

            foreach (string i in MainWindow.input.Text.Split("\r\n"))
            {
                count += (int.Parse(i)) / 3 - 2;
            }
            MainWindow.answerOne.Text = count.ToString();
        }

        internal static void christmassySolvePuzzleTwo()
        {
            int count = 0;

            foreach (string i in MainWindow.input.Text.Split("\r\n"))
            {
                int current = int.Parse(i);
                do
                {
                    current = current / 3 - 2;
                    count += (current > 0) ? current : 0;
                } while (current > 0);
            }

            MainWindow.answerTwo.Text = count.ToString();
        }
    }
}
