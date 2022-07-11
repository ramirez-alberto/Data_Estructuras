using BinaryTree;

BinarySearchTree tree = new BinarySearchTree();
int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
tree.root = tree.GenerateBST(array, 0, array.Length - 1);
tree.preOrder(tree.root);