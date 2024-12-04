/*You have a long flowerbed in which some of the plots are planted, and some are not. However, flowers cannot be planted in adjacent plots.
 *Given an integer array flowerbed containing 0's and 1's, where 0 means empty and 1 means not empty, and an integer n, return true if n new flowers can be planted in the flowerbed without violating the no-adjacent-flowers rule and false otherwise.
 *Example 1:
 *Input: flowerbed = [1, 0, 0, 0, 1], n = 1
 *Output: true
 *Example 2:
 *Input: flowerbed = [1, 0, 0, 0, 1], n = 2
 *Output: false*/

//How to Solve:
//Assume the array is {1,0,0,0,1} and n=1
//I first want to loop through the array

using System;

namespace CCAD16_Assignment5_3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] flowerBed = { 0, 1, 0, 0, 0, 0, 1 };
            int flowerCount = 1; // Number of flowers to plant

            Console.WriteLine($"Your array is: {string.Join(", ", flowerBed)}");

            bool result = CanPlaceFlowers(flowerBed, flowerCount);

            Console.WriteLine($"Can plant {flowerCount} flowers: {result}");
        }

        static bool CanPlaceFlowers(int[] flowerBed, int flowerCount)
        {
            int count = 0;

            for (int i = 0; i < flowerBed.Length; i++)
            {
                if (flowerBed[i] == 0 && (flowerBed[i] == 00 || flowerBed[i - 1] == 0 && (flowerBed[i] == flowerBed.Length - 1 || flowerBed[i + 1] == 0)))
                {
                    flowerBed[i] = 1;
                    count++;
                    i++;

                    if (count >= flowerCount)
                    {
                        return true;
                    }                       
                }
            }

            return count == flowerCount;
        }
    }
}
