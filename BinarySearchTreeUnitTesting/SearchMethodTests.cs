using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using BinarySearchTreeProj;

namespace BinarySearchTreeUnitTesting
{
    [TestClass]
    public class SearchMethodTests
    {
        [TestMethod]
        public void Search_Add3Nodes_Node23DataMatchesExpected()
        {
            BinarySearchTree tree = new BinarySearchTree();
            Node node1 = new Node(3);
            Node node2 = new Node(1);
            Node node23 = new Node(23);
            Node result;

            int expected = 23;
            int actual;

            tree.Add(node1);
            tree.Add(node2);
            tree.Add(node23);

            result = tree.Search(23);
            actual = result.data;

            Assert.AreEqual(expected, actual);
        }
    }
}
