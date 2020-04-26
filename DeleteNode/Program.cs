//https://leetcode.com/problems/delete-node-in-a-linked-list/
//Write a function to delete a node (except the tail) in a singly linked list, given only access to that node.
//Note:
//*The linked list will have at least two elements.
//*All of the nodes' values will be unique.
//*The given node will not be the tail and it will always be a valid node of the linked list.
//*Do not return anything from your function.
using System;

namespace DeleteNode
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
            public void DeleteNode(ListNode node)
            {
                node.val = node.next.val;
                node.next = node.next.next;
            }
        }
        //Driver
        static void Main(string[] args)
        {
            Console.WriteLine("LeetCode:237");
            Solution s = new Solution();
            //4,5,1,9 and delete 5
            ListNode head = new ListNode(4);
            head.next = new ListNode(5);
            ListNode TestCase = head.next;
            head.next = new ListNode(1);
            head.next.next.next = new ListNode(9);
            s.DeleteNode(TestCase);
            Console.WriteLine("Particular Node has been delted");
        }
    }
}
