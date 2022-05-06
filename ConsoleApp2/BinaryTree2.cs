using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
	public class BinaryTree2
	{
		public Node root;

		public virtual bool BST
		{
			get { return isBSTUtil(root, int.MinValue, int.MaxValue); }
		}

		public virtual bool isBSTUtil(Node node, int min, int max)
		{
			if (node == null)
			{
				return true;
			}

			if (node.data < min || node.data > max)
			{
				return false;
			}

			return (isBSTUtil(node.left, min, node.data - 1) && isBSTUtil(node.right, node.data + 1, max));
		}
	}
}
