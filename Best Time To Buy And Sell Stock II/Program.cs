//https://leetcode.com/problems/best-time-to-buy-and-sell-stock-ii/
/*
 * Say you have an array for which the ith element is the price of a given stock on day i.
Design an algorithm to find the maximum profit. 
You may complete as many transactions as you like (i.e., buy one and sell one share of the stock multiple times).
Note: You may not engage in multiple transactions at the same time (i.e., you must sell the stock before you buy again).
 */
 //Time Complexity O(n)
using System;

namespace Best_Time_To_Buy_And_Sell_Stock_II
{
    class Program
    {

        public class Solution
        {
            public int MaxProfit(int[] prices)
            {
                int maxprofit = 0;
                for (int i = 1; i < prices.Length; i++)
                {
                    if (prices[i] > prices[i - 1])
                    {
                        maxprofit += prices[i] - prices[i - 1];
                    }
                }
                return maxprofit;
            }
        }

        //Driver
        static void Main(string[] args)
        {
            Console.WriteLine("Leet Code:122");
            int[] TestCase = { 7, 1, 5, 3, 6, 4 };
            Console.WriteLine("{ 7, 1, 5, 3, 6, 4 }");
            Solution s = new Solution();
            Console.WriteLine("Maximum Profit is : "+ s.MaxProfit(TestCase));
        }
    }
}
//Note:instead of looking for every peak following a valley,
//we can simply go on crawling over the slope and keep on adding the profit obtained from every consecutive transaction.
