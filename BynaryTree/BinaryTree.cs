﻿namespace BinaryTree
{
    public class Node
    {
        public int data;
        public Node? left, right;

        public Node(int d)
        {
            data = d;
            left = right = null;
        }
    }

    public class BinarySearchTree
    {
        public Node? root;
        private string preorder = "";

        public virtual Node? GenerateBST(int[] array, int start, int end)
        {
            // Base Case
            if (start > end)
                return null;

            int middle = start + (end - start) / 2;
            Node node = new Node(array[middle]);

            node.left = GenerateBST(array, start, middle - 1);
            node.right = GenerateBST(array, middle + 1, end);

            return node;

        }
        public virtual string preOrder(Node? node)
        {
            if (node == null)
            {
                return "";
            }
            preorder += node.data + " ";
            preOrder(node.left);
            preOrder(node.right);
            return preorder;
        }
    }


}