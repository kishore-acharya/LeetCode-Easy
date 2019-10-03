//https://leetcode.com/problems/reverse-string/
//Write a function that reverses a string. The input string is given as an array of characters char[].
//Do not allocate extra space for another array, you must do this by modifying the input array in-place with O(1) extra memory.
//You may assume all the characters consist of printable ascii characters.
//Runtime:O(1)
using System;

namespace ReverseString
{
    class Program
    {
        public class Solution
        {
            public void ReverseString(char[] s)
            {
                char t;
                int l = s.Length - 1;
                for (int i = 0; i < l; i++, l--)
                {
                    t = s[i];
                    s[i] = s[l];
                    s[l] = t;
                }
                
            }
        }
        //Driver
        static void Main(string[] args)
        {
            Console.WriteLine("LeetCode:344");
            char[] testcase = {'h','e','l','l','o'};
            Solution s = new Solution();
            s.ReverseString(testcase);
            foreach(char a in testcase)
            {
                Console.Write(a);
            }
        }
        
    }
}
