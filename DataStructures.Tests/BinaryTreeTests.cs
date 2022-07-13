using System;
using Xunit;
using BinaryTree;

namespace DataStructuresTests
{
    public class BinaryTreeTests
    {
        [Theory]
        [InlineData("4 2 1 3 6 5 7 ", new int[] { 1, 2, 3, 4, 5, 6, 7 })]
        [InlineData("2 1 3 ", new int[] { 1, 2, 3 })]
        public void Test_preOrderMethod(string expected, int[] arr)
        {
            //Arrange
            BinarySearchTree tree = new BinarySearchTree();
            tree.root = tree.GenerateBST(arr, 0, arr.Length - 1);

            //Act
            string preOrder = tree.preOrder(tree.root);

            //Assert
            Assert.Equal(expected, preOrder);

        }
    }

    public class NodeModule
    {
        [Fact]
        public void Test_SortMultipleNodes()
        {
            //Arrange
            string result = "";
            Node[] nodes = new Node[4];
            nodes[0] = new Node(3);
            nodes[1] = new Node(2);
            nodes[2] = new Node(4);
            nodes[3] = new Node(5);

            //Act
            Array.Sort(nodes);
            foreach (Node node in nodes)
            {
                result += node.data + ",";
            }
            
            //Assert
            Assert.Equal(4, nodes.Length);
            Assert.Equal("2,3,4,5,", result);
        }
    }
}