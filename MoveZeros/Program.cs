//https://leetcode.com/problems/move-zeroes/
//Given an array nums, write a function to move all 0's to the end of it while maintaining the relative order of the non-zero elements.
//Note:
//*You must do this in-place without making a copy of the array.
//*Minimize the total number of operations.
using System;

namespace MoveZeros
{
    class Program
    {
        public class Solution
        {
            public void MoveZeroes(int[] nums)
            {
                int lastZeroAt = 0;
                for (int current = 0; current < nums.Length; current++)
                {
                    if (nums[current] != 0)
                    {
                        if (nums[lastZeroAt] == 0)
                        {
                            nums[lastZeroAt] = nums[current];
                            nums[current] = 0;
                        }
                        lastZeroAt++;
                    }

                }

            }

        }
        //Driver
        static void Main(string[] args)
        {
            Console.WriteLine("LeetCode:283");
            Solution s = new Solution();
            int[] TestCase = { 0, 1, 0, 3, 12 };
            Console.WriteLine("Test Case: { 0, 1, 0, 3, 12 }");
            s.MoveZeroes(TestCase);
            foreach(int i in TestCase)
            {
                Console.Write(i+" ");
            }
        }
    }
}
