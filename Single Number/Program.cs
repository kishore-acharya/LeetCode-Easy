//https://leetcode.com/problems/single-number/
//Given a non-empty array of integers, every element appears twice except for one.Find that single one.
//Note:
//Your algorithm should have a linear runtime complexity. Could you implement it without using extra memory?
using System;

namespace Single_Number
{
    class Program
    {

        public class Solution
        {
            public int SingleNumber(int[] nums)
            {
                int result = 0;
                for (int i = 0; i < nums.Length; i++)
                {
                    result ^= nums[i];
                }
                return result;

            }
        }
        //Driver
        static void Main(string[] args)
        {
            Console.WriteLine("Leet Code:136");
            int[] TestCase = { 4, 1, 2, 1, 2 };
            Solution s = new Solution();
            Console.WriteLine(s.SingleNumber(TestCase));


        }
    }
}