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
            int optcode;
            int inVal = 1;
            for(int i = 0 ; i < numbers.Length ; i+=lastParamLength)
            {
                if (numbers[i] % 100 == 1)
                {

                    Debug.WriteLine(numbers[i]);
                    Debug.WriteLine((numbers[i]/ 100) % 10 + ((numbers[i] / 100)%10 == 0 ? "address" : "value"));
                    Debug.WriteLine((numbers[i]/ 1000) % 10 + ((numbers[i] / 1000) % 10 == 0 ? "address" : "value"));
                    Debug.WriteLine((numbers[i]/ 10000) % 10 + ((numbers[i] / 10000) % 10 == 0 ? "address" : "value"));
                    Debug.WriteLine("numbers[" + ((numbers[i] / 10000)%10 == 0 ? numbers[i + 3] : i + 3) + "] = numbers[" + ((numbers[i] / 100) % 10 == 0 ? numbers[i + 1] : i + 1) + "] + numbers[" + ((numbers[i] / 1000) % 10 == 0 ? numbers[i + 2] : i + 2) + "];");
                    numbers[((numbers[i] / 10000) % 10 == 0 ? numbers[i + 3] : i+3)] = numbers[((numbers[i] / 100) % 10 == 0 ? numbers[i + 1] : i + 1)] + numbers[((numbers[i] / 1000) % 10 == 0 ? numbers[i + 2] : i + 2)];
                    lastParamLength = 4;
                }
                else if (numbers[i] % 100 == 2)
                {
                    Debug.WriteLine(numbers[i]);
                    Debug.WriteLine(numbers[i] / 100 + (numbers[i] / 100 == 0 ? "address" : "value"));
                    Debug.WriteLine(numbers[i] / 1000 + (numbers[i] / 1000 == 0 ? "address" : "value"));
                    Debug.WriteLine(numbers[i] / 10000 + (numbers[i] / 10000 == 0 ? "address" : "value"));
                    Debug.WriteLine("numbers[" + ((numbers[i] / 10000 == 0 ? numbers[i + 3] : i + 3)%10) + "] = numbers[" + (numbers[i] / 100 == 0 ? numbers[i + 1] : i + 1) + "] * numbers[" + (numbers[i] / 1000 == 0 ? numbers[i + 2] : i + 2) + "];");
                    numbers[((numbers[i] / 10000) % 10 == 0 ? numbers[i + 3] : i + 3)] = numbers[((numbers[i] / 100) % 10 == 0 ? numbers[i + 1] : i + 1)] * numbers[((numbers[i] / 1000) % 10 == 0 ? numbers[i + 2] : i + 2)];
                    lastParamLength = 4;
                }
                else if (numbers[i] % 100 == 3)
                {
                    numbers[((numbers[i] / 100) % 10 == 0 ? numbers[i + 1] : i + 1)] = inVal;
                    lastParamLength = 2;
                }
                else if (numbers[i] % 100 == 4)
                {
                    MainWindow.answerOne.Text =  (numbers[((numbers[i] / 100) % 10 == 0 ? numbers[i + 1] : i + 1)]).ToString();
                    lastParamLength = 2;
                }
                else if (numbers[i] == 99) { 
                    break;
                }
            }
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
