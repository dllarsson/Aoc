using System;
using System.Collections.Generic;

namespace Aoc
{
    class Program
    {
        public static string input = "1,0,0,3,1,1,2,3,1,3,4,3,1,5,0,3,2,1,10,19,1,6,19,23,1,13,23,27,1,6,27,31,1,31,10,35,1,35,6,39,1,39,13,43,2,10,43,47,1,47,6,51,2,6,51,55,1,5,55,59,2,13,59,63,2,63,9,67,1,5,67,71,2,13,71,75,1,75,5,79,1,10,79,83,2,6,83,87,2,13,87,91,1,9,91,95,1,9,95,99,2,99,9,103,1,5,103,107,2,9,107,111,1,5,111,115,1,115,2,119,1,9,119,0,99,2,0,14,0";
        static void Main(string[] args)
        {
            string[] n = input.Split(',');
            List<int> nums = new List<int>();
            foreach (var num in n)
            {
                nums.Add(int.Parse(num));
            }
            for (int j = 0; j < 100; j++)
            {
                for (int k = 0; k < 100; k++)
                {
                    List<int> tempList = new List<int>(nums);
                    tempList[1] = j;
                    tempList[2] = k;
                    int answer = Number(tempList);
                    if (answer == 19690720)
                    {
                        Console.WriteLine(tempList[1]);
                        Console.WriteLine(tempList[2]);

                    }
                }
            }


        }
        public static int Number(List<int> nums)
        {
            List<int> tempNums = new List<int>(nums);
            for (int i = 0; i < tempNums.Count; i++)
            {
                if (tempNums[i] == 1)
                {
                    tempNums[tempNums[i + 3]] = tempNums[tempNums[i + 1]] + tempNums[tempNums[i + 2]];
                }
                else if (tempNums[i] == 2)
                {
                    tempNums[tempNums[i + 3]] = tempNums[tempNums[i + 1]] * tempNums[tempNums[i + 2]];

                }
                else if (tempNums[i] == 99)
                {
                    return tempNums[0];
                }
                i += 3;
            }
            return -1;

        }

    }
}
