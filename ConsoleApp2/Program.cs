using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp2
{
    internal class Program
    {
		static void Main(string[] args)
		{

            //var res = RomanNumbers.RomanToInt("III");
            //var res2 = RomanNumbers.RomanToInt("LVIII");
            //var res3 = RomanNumbers.RomanToInt("MCMXCIV");

            //var res = RomanNumbers.RomanToInt_JC("III");
            //var res2 = RomanNumbers.RomanToInt_JC("LVIII");
            //var res3 = RomanNumbers.RomanToInt_JC("MCMXCIV");

            //************************************************************************************************************/
            //************************************************************************************************************/
            //************************************************************************************************************/

            //var t = ReorganizeStringClass.ReorganizeString("bbaaa");
            //var t1 = ReorganizeStringClass.ReorganizeString("bbabaaaa");
            //var t2 = ReorganizeStringClass.ReorganizeString("bbab");
            //Console.WriteLine(t);

            //************************************************************************************************************/
            //************************************************************************************************************/
            //************************************************************************************************************/

            //int[] arr = { 1, 2, 3, 7, 5 };
            //var t = ContinuousSubArray.SubarraySum(arr, 5, 12);

            //************************************************************************************************************/
            //************************************************************************************************************/
            //************************************************************************************************************/

            //// Ex:1
            //int[] numbers = { 4, 3, 5, 6, 1, 2 };
            //int target = 6;
            //// Ex:"
            ////int[] numbers = { 3,3,3 };
            ////int target = 9;
            //// Ex: 3
            ////int[] numbers = { -3, 3, 3 };
            ////int target = 3;
            //// Ex: 4
            ////int[] numbers = { 4, 3, 5, 6, 1, 2 };
            ////int target = 20;

            //Array.Sort(numbers);
            ////Array.Reverse(numbers);
            //Console.WriteLine(Sum.Sum3(numbers, target));
            //Console.WriteLine(Sum.Sum2_Hash(numbers, target));


            //************************************************************************************************************/
            //************************************************************************************************************/
            //************************************************************************************************************/



            //BinaryTree2 tree2 = new BinaryTree2();
            //tree2.root = new Node(4);
            //tree2.root.left = new Node(2);
            //tree2.root.right = new Node(5);
            //tree2.root.left.left = new Node(1);//put 10 as value is not BST
            //tree2.root.left.right = new Node(3);


            //var t = BinaryTree3.isBST(tree2.root);


            //************************************************************************************************************/
            //************************************************************************************************************/
            //************************************************************************************************************/




            //BinaryTree tree = new BinaryTree();
            //Node root = null;
            //root = tree.insert(root, 4);
            //tree.insert(root, 2);
            //tree.insert(root, 1);
            //tree.insert(root, 3);
            //tree.insert(root, 6);
            //tree.insert(root, 5);

            //Console.WriteLine("Minimum value of BST is: " + tree.minvalue(root));
            //Console.WriteLine("Minimum value of BST is: " + tree.maxValue(root));


            //BinaryTree2 tree2 = new BinaryTree2();
            //tree2.root = new Node(4);
            //tree2.root.left = new Node(2);
            //tree2.root.right = new Node(5);
            //tree2.root.left.left = new Node(1);//put 10 as value is not BST
            //tree2.root.left.right = new Node(3);

            //if (tree2.BST)
            //{
            //	Console.WriteLine("IS BST");
            //}
            //else
            //{
            //	Console.WriteLine("Not a BST");
            //}


            //************************************************************************************************************/
            //************************************************************************************************************/
            //************************************************************************************************************/



            //TreeNode pTreeNode = new TreeNode(1);
            //pTreeNode.left = new TreeNode(2);
            //pTreeNode.right = new TreeNode(3);

            //TreeNode qTreeNode = new TreeNode(1);
            //qTreeNode.left = new TreeNode(2);
            //qTreeNode.right = new TreeNode(3);

            //var result = SameTree.IsSameTree(pTreeNode, qTreeNode);


            //************************************************************************************************************/
            //************************************************************************************************************/
            //************************************************************************************************************/



            //TreeNode treeNode = new TreeNode(3);
            //treeNode.left = new TreeNode(9);
            //treeNode.right = new TreeNode(20);
            //treeNode.right.left = new TreeNode(15);
            //treeNode.right.right = new TreeNode(7);


            //var result = LevelOrderTraversal.LevelOrder(treeNode);

            //************************************************************************************************************/
            //************************************************************************************************************/
            //************************************************************************************************************/


            ////int[] prices = new int[] { 7, 1, 5, 3, 6, 4 };
            //int[] prices = new int[] { 7, 6, 4, 3, 1 };
            //var result = BestTimetoBuyandSellStock.MaxProfit(prices);


            //************************************************************************************************************/
            //************************************************************************************************************/
            //************************************************************************************************************/


            //// very difficult to understand it 
            //// TRIE https://www.geeksforgeeks.org/trie-insert-and-search/
            //WordDictionary wordDictionary = new WordDictionary();
            //wordDictionary.AddWord("bad");
            //wordDictionary.AddWord("dad");
            //wordDictionary.AddWord("mad");
            //var r = wordDictionary.Search("pad"); // return False
            //var r2 = wordDictionary.Search("bad"); // return True
            //var r3 = wordDictionary.Search(".ad"); // return True
            //var r4 = wordDictionary.Search("b.."); // return True



            //************************************************************************************************************/
            //************************************************************************************************************/
            //************************************************************************************************************/

            //ListNode listNode = new ListNode(-10);
            //listNode.next = new ListNode(-3);
            //listNode.next.next = new ListNode(0);
            //listNode.next.next.next = new ListNode(5);
            //listNode.next.next.next.next = new ListNode(9);
            //var result = ConvertSortedListtoBinarySearchTree.SortedListToBST(listNode);



            //************************************************************************************************************/
            //************************************************************************************************************/
            //************************************************************************************************************/

            // Same output
            int n = 4;
            var r1 = Fibonacci.FibonacciRecursion(n);
            var r2 = Fibonacci.FibonacciDynamic(n);

      

            
        }



















        //      static void Main(string[] args)
        //      {
        //          //           int[][,] a = new int[][,]
        //          //{
        //          //   new int[,]
        //          //   {
        //          //       {1, 1, 1, 1},
        //          //       {1, 1, 1, 1},
        //          //       {1, 1, 1, 1},
        //          //       {1, 1, 1, 1},

        //          //   },
        //          //   new int[,]
        //          //   {
        //          //       {1, 1, 1, 1},
        //          //       {1, 0, 0, 1},
        //          //       {1, 0, 0, 1},
        //          //       {1, 1, 1, 1},
        //          //   }
        //          //};

        //          char[,] grid = new char[4, 5] {
        //              { '1', '1', '1', '1', '0' },
        //              { '1', '1', '0', '1', '0' },
        //              { '1', '1', '0', '0', '0' },
        //              { '0', '0', '0', '0', '0' }
        //          };


        //          char[][] grid2 = new char
        //              [
        //                  ['1', '1', '1', '1', '0'],
        //                  ['1', '1', '0', '1', '0'],
        //                  ['1', '1', '0', '0', '0'],
        //                  ['0', '0', '0', '0', '0']
        //              ];

        //          var t = NumIslands(grid);

        //	Console.WriteLine(t);

        //}

        //static void Main(string[] args)
        //{

        //}




        //static void Main(string[] args)
        //      {



        //          
        //}



























        //Given an m x n 2D binary grid grid which represents a map of '1's(land) and '0's(water), return the number of islands.
        //An island is surrounded by water and is formed by connecting adjacent lands horizontally or vertically.
        //You may assume all four edges of the grid are all surrounded by water.
        public static int NumIslands(char[][] grid)
        {

            //linkedlist
            int count = 0;
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    // count successfully processed islands
                    count += sink(grid, i, j);
                }
            }
            return count;

        }

        static int sink(char[][] grid, int i, int j)
        {
            // if we are outside the grid i<0 || j<0 
            // or the current cell is visited  grid[i][j] == '0'
            // or we are at the bottom of the grid j == grid[i].Length
            // Not processed skip and return count 0 
            if (i < 0 || j < 0 || i == grid.Length || j == grid[i].Length || grid[i][j] == '0')
                return 0;
            // else process
            grid[i][j] = '0';  // sink current or turn current to visited
            sink(grid, i + 1, j); // sink right, do recursion as current
            sink(grid, i - 1, j); // sink left, do recursion as current
            sink(grid, i, j + 1); // sink down, do recursion as current
            sink(grid, i, j - 1); // sink up, do recursion as current
                                  // if all processed --> an island was found
            return 1;
        }


    }
}
