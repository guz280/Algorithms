using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
	public static class LevelOrderTraversal
	{
		//https://leetcode.com/problems/binary-tree-level-order-traversal/
		//Given the root of a binary tree, return the level order traversal of its nodes'
		//values. (i.e., from left to right, level by level).

		// I have issue with the return because it is IList<IList<int>> no idea what it is
		public static List<int> LevelOrder(TreeNode root)
		{
			// declare a list of int
			// check if null return empty list
			// start from root return val
			// check if left is null -> not null add val to list 
					// check right is null -> not null add val to list

			List<int> levels = new List<int>();


			var height = Height(root);
			for(int i = 1; i <= height; i++)
			{
				levels = PrintCurrentLevel(levels, root, i);
			}


			return levels;
		}


		public static int Height(TreeNode root)
		{
			if(root == null)
			{ return 0;}

			else
			{
				//compute height of each subtree
				int lHeight = Height(root.left);
				int rHeight = Height(root.right);

				// use larger height
				if(lHeight > rHeight)
				{
					return lHeight + 1;
				}
				else 
				{ 
					return rHeight + 1; 
				}	
			}
		}

		/* Print nodes at the current level */
		public static List<int> PrintCurrentLevel(List<int> levels, TreeNode root, int level)
		{
			if(root == null)
			{
				return levels;
			}
			if(level == 1)
			{
				levels.Add(root.val); //Console.Write(root.data + " ");
			}
			else if (level > 1)
			{
				PrintCurrentLevel(levels, root.left, level - 1);
				PrintCurrentLevel(levels, root.right, level - 1);
			}
			return levels;
		}








		
	}
}
