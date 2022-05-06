using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
	public class Node
	{
		public int data;
		public Node left, right;

		public Node(int d)
		{
			data = d;
			left = right = null;
		}
	}

	public class BinaryTree
	{
		public static Node head;

		public virtual Node insert(Node node, int data)
		{
			if (node == null)
			{
				return new Node(data);
			}
			else
			{
				if (data <= node.data)
				{
					node.left = insert(node.left, data);
				}
				else
				{
					node.right = insert(node.right, data);
				}
				return node;
			}
		}

		public virtual int minvalue(Node node)
		{
			Node current = node;

			while (current.left != null)
			{
				current = current.left;
			}

			return current.data;
		}


		public virtual int maxValue(Node node)
		{
			Node current = node;

			while (current.right != null)
			{
				current = current.right;
			}
			return current.data;
		}
	}
}
