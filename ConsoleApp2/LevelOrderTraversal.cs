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
			for(int i = 0; i <= height; i++)
			{
				levels = PrintCurrentLevel(levels, root, i+1);
			}


			return levels;
		}


		public static int Height(TreeNode root)
		{
			if(root == null)
			{ return 0;}

			else
			{
				//compute height
				int lHeight = Height(root.left);
				int rHeight = Height(root.right);

				// use larger height
				if(lHeight > rHeight)
				{
					return lHeight + 1;
				}
				else 
				{ 
					return lHeight + 1; 
				}	
			}
		}


		public static List<int> PrintCurrentLevel(List<int> levels, TreeNode root, int level)
		{
			if(root == null)
			{
				return levels;
			}
			if(level == 1)
			{
				levels.Add(root.val);
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
