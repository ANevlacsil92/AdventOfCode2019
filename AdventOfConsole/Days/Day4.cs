using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace AdventOfConsole.Days
{
    public static class Day4
    {
        static List<string> numbers = new List<string>();
        internal static void christmassySolvePuzzleOne()
        {
            for(int i = int.Parse(MainWindow.input.Text.Split("-")[0]); i <= int.Parse(MainWindow.input.Text.Split("-")[1]); i++)
            {
                bool hasMulti = false;
                bool failsCriteria = false;
                int last = 0;

                foreach(int d in i.ToString().Select(digit => int.Parse(digit.ToString())))
                {
                    if (d == last) hasMulti = true;
                    if (d < last) failsCriteria = true;
                    last = d;
                }

                if (hasMulti && !failsCriteria) numbers.Add(i.ToString());

            }

            MainWindow.answerOne.Text = numbers.Count.ToString();
        }

        internal static void christmassySolvePuzzleTwo()
        {
            int counter = 0;
            foreach(string s in numbers)
            {
                bool hasDouble = false;
                for(int i = 1; i<=9; i++)
                {
                    if (s.Contains(i.ToString() + i.ToString()) && !(s.Contains(i.ToString() + i.ToString() + i.ToString()))) hasDouble = true;
                }
                if (hasDouble) counter++;
            }
            MainWindow.answerTwo.Text = counter.ToString();
        }
    }
}
