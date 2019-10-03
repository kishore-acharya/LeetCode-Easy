//https://leetcode.com/problems/valid-anagram/
//Given two strings s and t , write a function to determine if t is an anagram of s
//Time Complexity: O(n)
//Using Semi Hash Table
using System;

namespace Valid_Anagram
{
    class Program
    {
        public class Solution
        {
            public bool IsAnagram(string s, string t)
            {
                if (s.Length != t.Length)
                {
                    return false;
                }
                int[] table = new int[26];
                for (int i = 0; i < s.Length; i++)
                {
                    table[s[i] - 'a']++;
                }
                for (int i = 0; i < t.Length; i++)
                {
                    table[t[i] - 'a']--;
                    if (table[t[i] - 'a'] < 0)
                    {
                        return false;
                    }
                }
                return true;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Leet Code:242");
            Solution solution = new Solution();
            string s = "anagram";
            string t = "nagaram";
            Console.WriteLine("Test Case: String 1 = anagram and string 2 = nagaram");
            Console.WriteLine("Is it anagram "+ solution.IsAnagram(s, t)); 
        }
    }
}
