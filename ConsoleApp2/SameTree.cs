using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
	//Definition for a binary tree node.
	public class TreeNode
	{
		public int val;
		public TreeNode left;
		public TreeNode right;
		public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
		{
			this.val = val;
			this.left = left;
			this.right = right;
		}
	}

	public static class SameTree
	{
		// check value(int valp, int valq)
		// compare valp == valq
		// == true - != false

		// traverse tree
		// start from the Node -> pNode qNode
		// check if null
		// if one of them is null return false
		// else CompareValue
		// continue to check left node & then right node, recursively
		//
		public static bool IsSameTree(TreeNode p, TreeNode q)
		{
			if(p == null && q == null)
			{
				return true;
			}


			if(p != null && q != null)
			{
				return (p.val == q.val && IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right));
			}

			return false;
		}

	}
}
