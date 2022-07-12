using Xunit;
using BinaryTree;

namespace DataStructuresTests
{
    public class ValidityTests
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
}