//https://leetcode.com/problems/reverse-linked-list/
//Reverse a singly linked list.
using System;

namespace Reverse_Link_List
{
    class Program
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }

        public class Solution
        {
            public ListNode ReverseList(ListNode head)
            {

                ListNode prev = null;
                ListNode curr = head;
                ListNode next = null;
                while (curr != null)
                {

                    next = curr.next;
                    curr.next = prev;
                    prev = curr;
                    curr = next;
                }
                return prev;
            }

        }
        //Driver
        static void Main(string[] args)
        {
            Console.WriteLine("LeetCode:206");
            int[] TestCase = { 1, 2, 3, 4, 5 };
            ListNode head=null;
            ListNode node=null;
            head = node;
            foreach (int a in TestCase)
            {
                node = new ListNode(a);
                node = node.next;
            }
            Solution s = new Solution();
            s.ReverseList(node);
            Console.WriteLine("The Link list has been reversed");
            


        }
    }
}
