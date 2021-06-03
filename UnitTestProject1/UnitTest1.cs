using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OOP4;
using System.Threading;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int k = 1;
            var t1 = new Thread(() => k = Lab4.Main());
            t1.Name = "Thread 1";
            var t2 = new Thread(() => k = Lab4.Main());
            t2.Name = "Thread 2";
            var t3 = new Thread(() => k = Lab4.Main());
            t3.Name = "Thread 3";
            t1.Start();
            t2.Start();
            t3.Start();
            t1.Join();
            t2.Join();
            t3.Join();

            Assert.AreEqual(-1, k);
        }

        [TestMethod]
        public void TestMethod2()
        {
            int k = 1;
            var t1 = new Thread(() => k = Lab4.Main());
            t1.Name = "Thread 1";
            t1.Start();
            t1.Join();

            Assert.AreEqual(0, k);
        }
    }
}
