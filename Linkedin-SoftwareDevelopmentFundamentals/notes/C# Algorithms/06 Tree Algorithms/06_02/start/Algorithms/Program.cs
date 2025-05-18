using System;

namespace Algorithms {
    
    class Program {

        class Node {
            public Node Left { get; set; }
            public Node Right { get; set; }
            public int Data { get; set; }
        }

        class BinarySearchTree {
            public static Node Insert(Node root, int value) { //creating node insert method
                if (root == null) { // if node doesnt exist
                    root = new Node(); //create new node
                    root.Data = value; //give node a value
                    return root; //return new node with value
                } else {
                    if (value < root.Data) { //if the node's value is less than the head
                        //insert on left
                        root.Left = Insert(root.Left, value); //insert left
                    } else if (value > root.Data) { //if the node's value more than the head
                        //insert on the right
                        root.Right = Insert(root.Right, value); //insert right
                    }
                }
            }
        }

        static void Main(string[] args) {
            Node rootNode = new Node();
            rootNode.Data = 4; //head
            BinarySearchTree.Insert(rootNode, 2); // left
            BinarySearchTree.Insert(rootNode, 3);// left, right
            BinarySearchTree.Insert(rootNode, 5);// right
            BinarySearchTree.Insert(rootNode, 6);//right right
            BinarySearchTree.Insert(rootNode, 4);// right left 
        }
    }
}