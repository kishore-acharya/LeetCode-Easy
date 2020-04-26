//https://leetcode.com/problems/roman-to-integer/
//Given a roman numeral, convert it to an integer. Input is guaranteed to be within the range from 1 to 3999.
using System;

namespace Roman_To_Integer
{
    class Program
    {
        public class Solution
        {

            public int RomanToInt(string s)
            {
                int len = s.Length;
                if (len == 1)
                {
                    return GetValue(s[0]);
                }
                int sum = 0;
                int current = 0;
                int next = 0;
                for (int i = 0; i < len; i++)
                {
                    current = GetValue(s[i]);
                    next = 0;
                    next = (i + 1) >= len ? 0 : GetValue(s[i + 1]);
                    if (current < next & next != 0)
                    {
                        sum += next - current;
                        i++;
                    }
                    else
                    {
                        sum += current;
                    }
                }
                return sum;
            }

            private int GetValue(char a)
            {
                switch (a)
                {
                    case 'I':
                        {
                            return 1;

                        }
                    case 'V':
                        {
                            return 5;
                        }
                    case 'X':
                        {
                            return 10;

                        }
                    case 'L':
                        {
                            return 50;

                        }
                    case 'C':
                        {
                            return 100;

                        }
                    case 'D':
                        {
                            return 500;

                        }
                    case 'M':
                        {
                            return 1000;

                        }
                    default:
                        {
                            return 0;
                        }

                }


            }
        }
        //Driver
        static void Main(string[] args)
        {
            Solution s = new Solution();
            string TestCase = "MCMXCIV";
            Console.WriteLine("Leet Code:13");
            Console.WriteLine("Test Case:MCMXCIV");
            Console.WriteLine(s.RomanToInt(TestCase));
        }
    }
}
