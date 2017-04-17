using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using D20170417.main;
using System.Collections.Generic;

namespace D20170417
{
    [TestClass]
    public class LinkedQueueUnitTest
    {
        private LinkedQueue queue;

        [TestInitialize]
        public void SetUp()
        {
            queue = new LinkedQueue();
        }

        [TestMethod]
        [Priority(0)]
        public void TestCount()
        {
            int count = queue.Count();
            Assert.AreEqual(count, 0);
        }

        [TestMethod]
        [Priority(1)]
        public void TestInQueue()
        {
            queue.InQueue(new Node("1"));
            Assert.AreEqual(1, queue.Count());
        }

        [TestMethod]
        [Priority(2)]
        public void TestOutQueue()
        {
            queue.InQueue(new Node("1"));
            Node outNode = queue.OutQueue();
            Assert.AreEqual("1", outNode.Value);
            Assert.AreEqual(0, queue.Count());
        }

        [TestMethod]
        [Priority(2)]
        public void TestListAll()
        {
            queue.InQueue(new Node("1"));
            queue.InQueue(new Node("2"));
            List<Node> list = queue.ListAll();
            Assert.AreEqual(2, list.Count);
            Assert.AreEqual("1", list[0].Value);
            Assert.AreEqual("2", list[1].Value);
        }
    }
}
