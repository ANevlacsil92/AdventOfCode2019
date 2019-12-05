using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace AdventOfConsole.Days
{
    public static class Day5
    {
        internal static void christmassySolvePuzzleOne()
        {
            int[] numbers = MainWindow.input.Text.Split(',').Select(Int32.Parse).ToArray();
            int lastParamLength = 4;
            int inVal = 1;

            for(int i = 0 ; i < numbers.Length ; i+=lastParamLength)
            {
                if (numbers[i] % 100 == 1)
                {
                    numbers[(numbers[i] % 100000 / 10000 == 0 ? numbers[i + 3] : i + 3)] = numbers[(numbers[i] % 1000 / 100 == 0 ? numbers[i + 1] : i + 1)] + numbers[(numbers[i] % 10000 / 1000 == 0 ? numbers[i + 2] : i + 2)];
                    lastParamLength = 4;
                }
                else if (numbers[i] % 100 == 2)
                {
                    numbers[(numbers[i] % 100000 / 10000 == 0 ? numbers[i + 3] : i + 3)] = numbers[(numbers[i] % 1000 / 100 == 0 ? numbers[i + 1] : i + 1)] * numbers[(numbers[i] % 10000 / 1000 == 0 ? numbers[i + 2] : i + 2)];
                    lastParamLength = 4;
                }
                else if (numbers[i] % 100 == 3)
                {
                    numbers[(numbers[i] % 1000 / 100 == 0 ? numbers[i + 1] : i + 1)] = inVal;
                    lastParamLength = 2;
                }
                else if (numbers[i] % 100 == 4)
                {
                    MainWindow.answerOne.Text += (numbers[(numbers[i] % 1000 / 100 == 0 ? numbers[i + 1] : i + 1)]).ToString();
                    lastParamLength = 2;
                }
                else if (numbers[i] == 99) { 
                    break;
                }
            }

            MainWindow.answerOne.Text += numbers[0].ToString();
        }

        internal static void christmassySolvePuzzleTwo()
        {
            int[] numbers = MainWindow.input.Text.Split(',').Select(Int32.Parse).ToArray();
            int lastParamLength = 4;
            int inVal = 5;

            for (int i = 0; i < numbers.Length; i += lastParamLength)
            {
                if (numbers[i] % 100 == 1)
                {
                    numbers[(numbers[i] % 100000 / 10000 == 0 ? numbers[i + 3] : i + 3)] = numbers[(numbers[i] % 1000 / 100 == 0 ? numbers[i + 1] : i + 1)] + numbers[(numbers[i] % 10000 / 1000 == 0 ? numbers[i + 2] : i + 2)];
                    lastParamLength = 4;
                }
                else if (numbers[i] % 100 == 2)
                {
                    numbers[(numbers[i] % 100000 / 10000 == 0 ? numbers[i + 3] : i + 3)] = numbers[(numbers[i] % 1000 / 100 == 0 ? numbers[i + 1] : i + 1)] * numbers[(numbers[i] % 10000 / 1000 == 0 ? numbers[i + 2] : i + 2)];
                    lastParamLength = 4;
                }
                else if (numbers[i] % 100 == 3)
                {
                    numbers[(numbers[i] % 1000 / 100 == 0 ? numbers[i + 1] : i + 1)] = inVal;
                    lastParamLength = 2;
                }
                else if (numbers[i] % 100 == 4)
                {
                    MainWindow.answerTwo.Text = (numbers[(numbers[i] % 1000 / 100 == 0 ? numbers[i + 1] : i + 1)]).ToString();
                    lastParamLength = 2;
                }
                else if (numbers[i] % 100 == 5)
                {
                    if (numbers[(numbers[i] % 1000 / 100 == 0 ? numbers[i + 1] : i + 1)] != 0)
                    {
                        i = numbers[(numbers[i] % 10000 / 1000 == 0 ? numbers[i + 2] : i + 2)];
                        lastParamLength = 0;
                    }
                    else lastParamLength = 3;
                }
                else if (numbers[i] % 100 == 6)
                {
                    if (numbers[(numbers[i] % 1000 / 100 == 0 ? numbers[i + 1] : i + 1)] == 0)
                    {
                        i = numbers[(numbers[i] % 10000 / 1000 == 0 ? numbers[i + 2] : i + 2)];
                        lastParamLength = 0;
                    }
                    else lastParamLength = 3;
                }
                else if (numbers[i] % 100 == 7)
                {
                    numbers[(numbers[i] % 100000 / 10000 == 0 ? numbers[i + 3] : i + 3)] = (numbers[(numbers[i] % 1000 / 100 == 0 ? numbers[i + 1] : i + 1)] < numbers[(numbers[i] % 10000 / 1000 == 0 ? numbers[i + 2] : i + 2)] ? 1 : 0);
                    lastParamLength = 4;
                }
                else if (numbers[i] % 100 == 8)
                {
                    numbers[(numbers[i] % 100000 / 10000 == 0 ? numbers[i + 3] : i + 3)] = (numbers[(numbers[i] % 1000 / 100 == 0 ? numbers[i + 1] : i + 1)] == numbers[(numbers[i] % 10000 / 1000 == 0 ? numbers[i + 2] : i + 2)] ? 1 : 0);
                    lastParamLength = 4;
                }
                else if (numbers[i] == 99)
                {
                    break;
                }
            }

        }
    }
}
