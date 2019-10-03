//https://leetcode.com/problems/contains-duplicate/
//Given an array of integers, find if the array contains any duplicates.
//Your function should return true if any value appears at least twice in the array, 
//and it should return false if every element is distinct.
//Time Complexity : O(n)
using System;
using System.Collections.Generic;

namespace Contains_Duplicate
{
    class Program
    {
        public class Solution
        {
            public bool ContainsDuplicate(int[] nums)
            {
                HashSet<int> p = new HashSet<int>();
                for (int i = 0; i < nums.Length; i++)
                {
                    if (p.Contains(nums[i]))
                    {
                        return true;
                    }
                    else
                    {
                        p.Add(nums[i]);
                    }


                }
                return false;

            }
        }
        //Driver
        static void Main(string[] args)
        {
            Console.WriteLine("Leet Code:217");
            Solution s = new Solution();
            int[] TestCase = { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 };
            Console.WriteLine("Test Case: 1,1,1,3,3,4,3,2,4,2");
            Console.WriteLine("Contains Duplicate: "+s.ContainsDuplicate(TestCase));
        }
    }
}
