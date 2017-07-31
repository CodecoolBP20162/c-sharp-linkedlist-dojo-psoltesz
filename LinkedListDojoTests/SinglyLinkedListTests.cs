using Microsoft.VisualStudio.TestTools.UnitTesting;
using LinkedListDojo;

namespace LinkedListDojo.Tests
{
    [TestClass()]
    public class SinglyLinkedListTests
    {

        [TestMethod()]
        public void AddTest()
        {
            string listContent = "3, 7, 2";
            SinglyLinkedList<int> intList = new SinglyLinkedList<int>();
            intList.Add(3);
            intList.Add(7);
            intList.Add(2);
            Assert.AreEqual(listContent, intList.ToString());
        }

        [TestMethod()]
        public void InsertTest()
        {
            string listContent = "3, 11, 7, 2";
            SinglyLinkedList<int> intList = new SinglyLinkedList<int>();
            intList.Add(3);
            intList.Add(7);
            intList.Add(2);
            intList.Insert(11, 1);
            Assert.AreEqual(listContent, intList.ToString());
        }

        [TestMethod()]
        public void RemoveTest()
        {
            string listContent = "3, 11, 2";
            SinglyLinkedList<int> intList = new SinglyLinkedList<int>();
            intList.Add(3);
            intList.Add(11);
            intList.Add(7);
            intList.Add(2);
            intList.Remove(2);
            Assert.AreEqual(listContent, intList.ToString());
        }
    }
}