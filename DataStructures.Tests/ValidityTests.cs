using Xunit;
using BinaryTree;

namespace DataStructuresTests
{
    public class ValidityTests
    {
        [Fact]
        public void GenerateBSTTest()
        {
            //Arrange

            BinarySearchTree tree = new BinarySearchTree();
            int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7};

            //Act

            tree.root = tree.GenerateBST(array, 0, array.Length - 1);
            string preOrder = tree.preOrder(tree.root);

            //Assert
            Assert.Equal("4 2 1 3 6 5 7 ", preOrder);

        }
    }
}