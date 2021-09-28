using LinkedListsTraining;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListTraining_tests
{
    [TestClass]
    public class MyLinkedList_tests
    {
        [TestMethod]
        public void AddAtHead_OneNumber_CanReturnNumber()
        {
            var input = 2;
            //var expected = 0;
            var expected = 2;
            var sut = new MyLinkedList();

            sut.AddAtHead(input);

            var actual = sut.Get(0);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddAtHead_ThreeNumber_CheckAtTop()
        {
            var input = 6;
            var expected = 6;
            var sut = new MyLinkedList();

            sut.AddAtHead(2); //last
            sut.AddAtHead(4);
            sut.AddAtHead(input); //first

            var actual = sut.Get(0);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddAtHead_ManyNumber_CheckAtBottom()
        {
            var input = 9;
            var expected = 9;
            var sut = new MyLinkedList();

            sut.AddAtHead(input);  //last
            sut.AddAtHead(7);
            sut.AddAtHead(9); 
            sut.AddAtHead(11);
            sut.AddAtHead(13);
            sut.AddAtHead(15);  //first

            var actual = sut.Get(5);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddAtTail_ManyNumber_CheckAtBottom()
        {
            var input = 100;
            var expected = 100;
            var sut = new MyLinkedList();

            sut.AddAtHead(5);  //last
            sut.AddAtHead(7);
            sut.AddAtHead(9);
            sut.AddAtHead(11);
            sut.AddAtHead(13);
            sut.AddAtHead(15);  //first

            sut.AddAtTail(input);

            var actual = sut.Get(6);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DeleteAtIndex_ManyNumber_DeleteFirstItem()
        {
            //var input = 9;
            var expected = 13;
            var sut = new MyLinkedList();

            sut.AddAtHead(5);  //last
            sut.AddAtHead(7);
            sut.AddAtHead(9);
            sut.AddAtHead(11);
            sut.AddAtHead(13);  //new first
            sut.AddAtHead(15);  //first deleted

            sut.DeleteAtIndex(0);

            var actual = sut.Get(0);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DeleteAtIndex_ManyNumber_DeleteLastItem()
        {
            //var input = 9;
            var expected = 7;
            var sut = new MyLinkedList();

            sut.AddAtHead(5);  //last deleted
            sut.AddAtHead(7);  //new last item
            sut.AddAtHead(9);
            sut.AddAtHead(11);
            sut.AddAtHead(13);  
            sut.AddAtHead(15);  //first

            sut.DeleteAtIndex(5);

            var actual = sut.Get(4);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DeleteAtIndex_ManyNumber_DeleteInMiddle()
        {
            //var input = 9;
            var expected = 9;
            var sut = new MyLinkedList();

            sut.AddAtHead(5);  //last deleted
            sut.AddAtHead(7);  
            sut.AddAtHead(9);  //check index item
            sut.AddAtHead(11);  //delete item
            sut.AddAtHead(13);
            sut.AddAtHead(15);  //first

            sut.DeleteAtIndex(2);

            var actual = sut.Get(2);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddAtIndex_ThreeNumbers_AddValue()
        {
            //var input = 9;
            var expected = 2;
            var sut = new MyLinkedList();

            sut.AddAtHead(1); 
            sut.AddAtTail(3);

            sut.AddAtIndex(1, 2);

            var actual = sut.Get(1);
            Assert.AreEqual(expected, actual);
        }
    }
}
