using System;

/*You have 2 very large binary trees: T1 with millions of nodes, and T2 with hundreds of nodes. 
 * Create an algorithm to decide if T2 is a subtree of T1. 
 * A tree T2 is a subtree of T1 if there exists a node n in T1 such that the subtree of n is identical to T2. 
 * That is, if you cut off the tree at node n, the two trees would be identical.*/
namespace Tree2_3
{
    public class Node
    {
        public Node left;
        public Node right;
        public int data;

        public Node()
        {
            left = null;
            right = null;
        }

        public Node(int value)
        {
            left = null;
            right = null;
            data = value;
        }
    }

    public class BinaryTree
    {
        public Node root;

        public BinaryTree()
        {
            root = null;
        }

        
    }
        class Program
    {
        static void Main(string[] args)
        {
            Node node = new Node(50);

            node.left = new Node(30);
            node.left.left = new Node(10);
            node.left.right = new Node(60);
            node.left.right.right = new Node(70);
            node.right = new Node(15);
            node.right.left = new Node(20);
            node.right.right = new Node(40);
            node.right.right.right = new Node(80);
            BinaryTree bt1 = new BinaryTree();
            bt1.root = node;


            node = new Node(40);
            //node.left = new Node(5);
            node.right = new Node(80);
            BinaryTree bt2 = new BinaryTree();
            bt2.root = node;

            bool tree;
            tree = IsSubtree(bt1.root, bt2.root);
            if (tree)
                Console.WriteLine("T2 is a subtree of T1");
            else
                Console.WriteLine("T2 is NOT a subtree of T1");

            /*--------------------------*/
            bool IsSubtree(Node root1, Node root2)
            {
                if (root2 == null) return true;

                if (root1 == null)
                    return false;
                else
                {
                    if (IsIdentical(root1, root2))
                        return true;
                    else
                        return (IsSubtree(root1.left, root2) || IsSubtree(root1.right, root2));
                }
            }

            /*--------------------------*/
            bool IsIdentical(Node node1, Node node2)
            {
                if (node1 == null && node2 == null)
                    return true;

                if (node1 != null && node2 != null)
                {
                    if (node1.data == node2.data &&
                        IsIdentical(node1.left, node2.left) &&
                        IsIdentical(node1.right, node2.right))
                    {
                        return true;
                    }
                }
                return false;
            }
            /*--------------------------*/

        }
    }
}
