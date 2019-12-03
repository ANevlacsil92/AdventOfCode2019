using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdventOfConsole.Days
{
    public static class Day2
    {
        internal static void christmassySolvePuzzleOne()
        {
            int[] numbers = MainWindow.input.Text.Split(',').Select(Int32.Parse).ToArray();

            for(int i = 0 ; i < numbers.Length ; i+=4)
            {
                if (numbers[i] == 1) numbers[numbers[i + 3]] = numbers[numbers[i + 1]] + numbers[numbers[i + 2]];
                else if (numbers[i] == 2) numbers[numbers[i + 3]] = numbers[numbers[i + 1]] * numbers[numbers[i + 2]];
                else if (numbers[i] == 99) break;
            }
            MainWindow.answerOne.Text = numbers[0].ToString();
        }

        internal static void christmassySolvePuzzleTwo()
        {
            int[] numbers;
            int noun = 0,verb = 0;
            const int result = 19690720;

            for (noun = 0; noun <= 99; noun++)
            {
                for (verb = 0; verb <= 99; verb++)
                {
                    numbers = MainWindow.input.Text.Split(',').Select(Int32.Parse).ToArray();
                    numbers[1] = noun;
                    numbers[2] = verb;

                    for (int i = 0; i < numbers.Length; i += 4)
                    {
                        try {
                            if (numbers[i] == 1) numbers[numbers[i + 3]] = numbers[numbers[i + 1]] + numbers[numbers[i + 2]];
                            else if (numbers[i] == 2) numbers[numbers[i + 3]] = numbers[numbers[i + 1]] * numbers[numbers[i + 2]];
                            else if (numbers[i] == 99) break;
                        } catch {
                            break;
                        }
                    }

                    if (numbers[0] == result)
                    {
                        MainWindow.answerTwo.Text = (100 * noun + verb).ToString();
                        return;
                    }
                }
            }
        }
    }
}
