using System;

namespace BinarySearchTrees
{
    internal class Program
    {
        class Node
        {
            //this is our tree-> contains left and right node with a piece of data
            public Node Left { get; set; }
            public Node Right { get; set; }
            public int Data { get; set; }
        }

        //becomes a binary search tree when we include constraints
        class BinarySearchTree
        {
            //follow left/right reference to add data
            public static Node Insert(Node root, int value)
            {
                if (root == null)
                {
                    //inputed value will be turned into root node
                    root = new Node();
                    root.Data = value;
                    
                    //since its the only element in the tree, no left/right reference changes are needed at this time
                }
                else
                {
                    //if its not null then we need to insert value on the L/R side of tree
                    //if value = root -> we dont need to insert anything
                    if (value < root.Data)
                    {
                        //insert on left
                        root.Left = Insert(root.Left, value);
                    }
                    else if (value > root.Data)
                    {
                        //insert on right
                        root.Right = Insert(root.Right, value);
                    }
                }
                return root;
            }
        }
        static void Main(string[] args)
        {
            Node rootNode = new Node();
            rootNode.Data = 4;
            BinarySearchTree.Insert(rootNode, 2);
            BinarySearchTree.Insert(rootNode, 3);
            BinarySearchTree.Insert(rootNode, 5);
            BinarySearchTree.Insert(rootNode, 6);
            BinarySearchTree.Insert(rootNode, 4);

            
        }
    }
}

/*NOTES:
 * 
 * useful for working with nonLinear data
 * 
 * a tree is a collection of nodes, where each node might be linked to one or several nodes
 *                          
 *                          2  (root/parent node)
 *                        /   \
 *                       3     4    (child nodes and parents to proceeding nodes)
 *                      / \     \
 *                     8   3     1
 *                      
 *  linked nodes are called child nodes
 *  
 *  a tree is a collection of nodes that are connected by links
 *      constraints can be applied to manage data
 *      
 *  the linked list data structure is a specialized type of tree
 *      2->3->1->null
 *      
 *  BINARY TREE: each node has no more than 2 child nodes
 *      binary search tree: a binary tree that adds the constraint of order
 *          items to the left must be less than the parent
 *          items to the right must be greater than the parent
 *          -->order constraint allows us to make data assumptions
 */
