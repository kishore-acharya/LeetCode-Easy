//https://leetcode.com/problems/maximum-depth-of-binary-tree/
//Given a binary tree, find its maximum depth.
//The maximum depth is the number of nodes along the longest path from the root node down to the farthest leaf node.
//Note: A leaf is a node with no children.
using System;

namespace Maximum_Depth_of_Binary_Tree
{
    class Program
    {


        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x) { val = x; }
        }

        public class Solution
        {
            public int MaxDepth(TreeNode root)
            {
                return FindMaxHeight(root);
            }


            public int FindMaxHeight(TreeNode node)
            {
                if (node == null)
                    return 0;

                int a = 1 + FindMaxHeight(node.left);
                int b = 1 + FindMaxHeight(node.right);
                if (a > b)
                    return a;
                else
                    return b;

            }


        }
        //Driver
        static void Main(string[] args)
        {
            Console.WriteLine("LeetCode:104");
            TreeNode root = new TreeNode(3);
            root.left = new TreeNode(9);
            root.right = new TreeNode(20);
            root.right.left = new TreeNode(15);
            root.right.right = new TreeNode(7);
            //    3
            //  /   \
            //  9   20
            //     /  \
            //    15   7
            Solution s = new Solution();
            Console.WriteLine(s.FindMaxHeight(root)); 
            
        }


    }
}
