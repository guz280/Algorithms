using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
	public static class BinaryTree3
	{
        //Function to check whether a Binary Tree is BST or not.
        public static bool isBST(Node root)
        {
            //10
            //5         15
            //2     6     12    18

            // root null return true
            // root.left < root  good
            // root.right > root good

            //isBST(root.left) && isBST(root.right)

            if (root == null)
            {
                return true;
            }


            if ((root.left != null && root.left.data > root.data) || (root.right != null && root.right.data < root.data))
            {
                return false;
            }

            return (isBST(root.left) && isBST(root.right));
        }
    }
}
