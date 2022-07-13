using System.Linq;

namespace BinaryTree
{
    public class Node : IComparable
    {
        public int data;
        public Node? left, right;

        public Node(int d)
        {
            data = d;
            left = right = null;
        }
        int IComparable.CompareTo(object? obj)
        {
            if (obj == null) return 1;
            if (obj == this) return 0;

            Node? node = obj as Node;
            if (node != null)
            {
                return data.CompareTo(node.data);
            }
            else
            {
                throw new ArgumentException("Object is not a Node");
            }
        }
    }

    public class BinarySearchTree
    {
        public Node? root;
        private string preorder = "";

        public virtual Node? GenerateBST(int[] arr, int start, int end)
        {
            //A simple array for learning purposes.
            int[] array = arr.Distinct().ToArray();

            // Base Case
            if (start > end)
                return null;

            int middle = start + (end - start) / 2;
            Node node = new Node(array[middle]);

            node.left = GenerateBST(array, start, middle - 1);
            node.right = GenerateBST(array, middle + 1, end);

            root = node;
            return node;

        }

        public Node? InsertNode(int value)
        { 
            return InsertNodeRecursive(root,value); 
        }
        public Node? InsertNodeRecursive(Node? node, int value)
        {
            if(node == null) return null;
            return root;
        }
        public Node? DeleteNode(int value)
        {
            return DeleteNodeRecursive(root, value);
        }
        public Node? DeleteNodeRecursive(Node? node, int value)
        {
            if (node == null) return null;

            if(value < node.data)
                node.left = DeleteNodeRecursive(node.left,value);
            else if(value > node.data)
                node.right = DeleteNodeRecursive(node.right,value);
        // if key is same as root's key, then This is the
        // node to be deleted
            else
            {
                // node with only one child or no child
                if (node.left == null)
                    return node.right;
                else if (node.right == null)
                    return node.left;

                // node with two children: Get the
                // inorder successor (smallest
                // in the right subtree)
                node.data = minValue(node.right);

                // Delete the inorder successor
                node.right = DeleteNodeRecursive(node.right, node.data);
            }
            return node;
        }

        int minValue(Node node)
        {
            int minv = node.data;
            while (node.left != null)
            {
                minv = node.left.data;
                node = node.left;
            }
            return minv;
        }
        public Node? Search(int n)
        {
            return SearchRecursive(root, n);
        }
        private Node? SearchRecursive(Node? node, int numberTofind)
        {
            if (node == null || node.data == numberTofind) return node;            
            
            if (node.data < numberTofind)
                return SearchRecursive(node.right, numberTofind);
            
                return SearchRecursive(node.left, numberTofind);
        }

        public virtual string preOrder(Node? node)
        {
            if (node == null)
            {
                return String.Empty;
            }
            preorder += node.data + " ";
            preOrder(node.left);
            preOrder(node.right);
            return preorder;
        }
    }


}