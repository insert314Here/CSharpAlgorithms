using System;

namespace TreeTraversals
{
    internal class Program
    {
        class Node
        {
            public Node Left { get; set; }
            public Node Right { get; set; }
            public int Data { get; set; }
        }

        class BinaryTree
        {
            public static void PreOrder(Node root)
            {
                if (root==null)
                {
                    return;
                }
                Console.Write($"{root.Data} ");
                PreOrder(root.Left);
                PreOrder(root.Right);
            }

            public static void InOrder(Node root)
            {
                if (root == null)
                {
                    return;
                }
                
                InOrder(root.Left);
                Console.Write($"{root.Data} ");
                InOrder(root.Right);
            }

            public static void PostOrder(Node root)
            {
                if (root == null)
                {
                    return;
                }

                PostOrder(root.Left);
                PostOrder(root.Right);
                Console.Write($"{root.Data} ");
            }
        }

        public static void PrintTree(string type)
        {
            Console.WriteLine("\n");
            Console.WriteLine("       4   ");
            Console.WriteLine("    1     3 ");
            Console.WriteLine("  8   9  6");
            Console.WriteLine($"\n{type} Method\n----------------");
        }
        static void Main(string[] args)
        {
            //       4
            //    1     3
            //  8   9  6
            
            //creating the tree
            Node rootNode = new Node();
            rootNode.Data = 4;

            Node nodeOne = new Node();
            nodeOne.Data = 1;

            Node nodeThree = new Node();
            nodeThree.Data = 3;

            Node nodeEight = new Node();
            nodeEight.Data = 8;

            Node nodeNine = new Node();
            nodeNine.Data = 9;

            Node nodeSix = new Node();
            nodeSix.Data = 6;

            rootNode.Left = nodeOne;
            rootNode.Right = nodeThree;
            nodeOne.Left = nodeEight;
            nodeOne.Right = nodeNine;
            nodeThree.Left = nodeSix;

            PrintTree("PreOrder");
            BinaryTree.PreOrder(rootNode);
            Console.WriteLine();
            PrintTree("InOrder");
            BinaryTree.InOrder(rootNode);
            Console.WriteLine();
            PrintTree("PostOrder");
            BinaryTree.PostOrder(rootNode);
            Console.WriteLine();
        }
    }
}

/*NOTES:
 * with a binary tree, data is not stored in any order
 * 
 * each node can have at most, 2 direct child nodes
 *      this creates need for traversal to find an element
 *      
 * IN ORDER: recursively visit left subtree, visit root, and recursively visit right subtree
 *      9,7,10,6,8
 *                              6
 *                             / \
 *                            7   8
 *                           / \   \
 *                          9  10
 *              
 * PRE ORDER: visit the root, recursive visit to left subtree, and recursive visit right subtree...6, 7, 9, 10, 8
 * 
 * POST ORDER: V Recurse the left subtree, recurse the right subtree, and visit the root
 *      9,10,7,8,6
 *      
 *          USE CASES:
 *  Pre: explores roots before leaves
 *  Post: explore leaves before roots
 *  IN: explores data sequentially
 */
