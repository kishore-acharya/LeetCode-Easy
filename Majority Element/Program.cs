//https://leetcode.com/problems/majority-element/
//Given an array of size n, find the majority element.The majority element is the element that appears more than ⌊ n/2 ⌋ times.
//You may assume that the array is non-empty and the majority element always exist in the array.
//++I am Using Boyer Morre Voting Algorithm++//
//Time Complexity : O(n)
using System;

namespace Majority_Element
{
    class Program
    {
        public class Solution
        {
            public int MajorityElement(int[] nums)
            {
                int count = 0;
                int candidate = 0;
                for (int i = 0; i < nums.Length; i++)
                {
                    if (count == 0)
                    {
                        candidate = nums[i];
                    }
                    count += (nums[i] == candidate) ? 1 : -1;
                }
                return candidate;
            }
        }
        //Driver
        static void Main(string[] args)
        {
            Console.WriteLine("LeetCode:169");
            Solution s = new Solution();
            int[] TestCase = { 2, 2, 1, 1, 1, 2, 2 };
            Console.WriteLine("TestCase = { 2, 2, 1, 1, 1, 2, 2 }");
            Console.WriteLine(s.MajorityElement(TestCase));
        }
    }
}
