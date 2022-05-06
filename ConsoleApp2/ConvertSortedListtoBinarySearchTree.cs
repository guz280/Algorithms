using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
	// Definition for singly-linked list.
	public class ListNode
	{
		public int val;
		public ListNode next;
		public ListNode(int val = 0, ListNode next = null)
		{
			this.val = val;
			this.next = next;
		}
	}


	// Definition for a binary tree node.
	public class TreeNode2
	{
		public int val;
		public TreeNode left;
		public TreeNode right;
		public TreeNode2(int val = 0, TreeNode left = null, TreeNode right = null)
		{
			this.val = val;
			this.left = left;
			this.right = right;
		}
	}


	// Given the head of a singly linked list where elements are sorted in ascending order, convert it to a height balanced BST.
	// For this problem, a height-balanced binary tree is defined as a binary tree in which the depth of the two subtrees
	// of every node never differ by more than 1.
	public static class ConvertSortedListtoBinarySearchTree
	{
		// count the number of nodes in the ListNode (next)
		// get midpoint of the head 0
		// 


		public static TreeNode2 SortedListToBST(ListNode head)
		{



			return new TreeNode2();
		}
	}
}
