using System;

namespace Algorithms {

    class Program {

        class Node {
            public Node Left { get; set; }
            public Node Right { get; set; }
            public int Data { get; set; }
        }

        class BinaryTree {
            public static void preOrderTraversal(Node root)
            {
                if (root == null)
                {
                    return;
                }
                Console.WriteLine(root.Data + " "); //Root
                preOrderTraversal(root.Left); //Left subtree
                preOrderTraversal(root.Right); //right subtree
            }
            public static void inOrderTraversal(Node root)
            {
                if (root == null)
                {
                    return;
                }
                inOrderTraversal(root.Left); //;eft subtree
                Console.WriteLine(root.Data + " "); //Root
                inOrderTraversal(root.Right); //Right subtree
            }
            public static void postOrderTraversal(Node root)
            {
                if (root == null)
                {
                    return;
                }
                postOrderTraversal(root.Left); //left subtree
                postOrderTraversal(root.Right); //right subtree
                Console.WriteLine(root.Data + " "); //Root
            }
            
        }

        static void Main(string[] args)
        {

            //       4
            //    1     3
            //  8   9  6
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

            BinaryTree.preOrderTraversal(rootNode);
            Console.WriteLine();

            BinaryTree.inOrderTraversal(rootNode);
            Console.WriteLine();

            BinaryTree.postOrderTraversal(rootNode);
            Console.WriteLine();
        }
    }
}