//https://leetcode.com/problems/fizz-buzz/
//Write a program that outputs the string representation of numbers from 1 to n.
//But for multiples of three it should output “Fizz” instead of the number and for the multiples of five output “Buzz”. 
//For numbers which are multiples of both three and five output “FizzBuzz”.
using System;
using System.Collections.Generic;

namespace FizzBuzz
{
    class Program
    {
        public class Solution
        {
            public IList<string> FizzBuzz(int n)
            {
                IList<string> ans = new List<string>();
                string a = null;
                for (int i = 1; i <= n; i++)
                {
                    if (i % 5 == 0 && i % 3 == 0)
                    {
                        a = "FizzBuzz";
                    }
                    else if (i % 3 == 0)
                    {
                        a = "Fizz";
                    }
                    else if (i % 5 == 0)
                    {
                        a = "Buzz";
                    }
                    else a = i.ToString();
                    ans.Add(a);
                }
                return ans;
            }
        }
        //Driver
        static void Main(string[] args)
        {
            Console.WriteLine("Leet Code:");
            int TestCase = 15;
            Solution s = new Solution();
            foreach(string a in s.FizzBuzz(TestCase))
            {
                Console.WriteLine(a);
            }
        }
    }
}
