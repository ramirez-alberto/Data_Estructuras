using BinaryTree;

BinarySearchTree tree = new BinarySearchTree();
int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
var root = tree.GenerateBST(array, 0, array.Length - 1);
var preorder = tree.preOrder(tree.root);
Console.WriteLine(preorder);
Console.WriteLine(tree.Search(6).data);