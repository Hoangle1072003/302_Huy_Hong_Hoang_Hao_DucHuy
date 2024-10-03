using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MethodLibrary;
namespace Lab5
{
    [TestClass]

    public class UT_Lab5
    {
        [TestMethod]
        public void TestCase1()
        {
            MethodLibrary.MethodLibrary obj = new MethodLibrary.MethodLibrary();
            string actual = obj.HuyChuoi("software testing", 8, 1);
            string expected = "stesting";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestCase2()
        {
            MethodLibrary.MethodLibrary obj = new MethodLibrary.MethodLibrary();
            string actual = obj.HuyChuoi("software testing", 9, 18);
            string expected = "software testing";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestCase3()
        {
            MethodLibrary.MethodLibrary obj = new MethodLibrary.MethodLibrary();
            string actual = obj.HuyChuoi("software testing", 9, -6);
            string expected = "software testing";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestCase4()
        {
            MethodLibrary.MethodLibrary obj = new MethodLibrary.MethodLibrary();
            string actual = obj.HuyChuoi("software testing", 18, 1);
            string expected = "s";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestCase5()
        {
            MethodLibrary.MethodLibrary obj = new MethodLibrary.MethodLibrary();
            string actual = obj.HuyChuoi("software testing", -7, 1);
            string expected = "software testing";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestCase6()
        {
            MethodLibrary.MethodLibrary obj = new MethodLibrary.MethodLibrary();
            string actual = obj.HuyChuoi("software testing", 9, 0);
            string expected = "testing";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestCase7()
        {
            MethodLibrary.MethodLibrary obj = new MethodLibrary.MethodLibrary();
            string actual = obj.HuyChuoi("software testing", 1, 15);
            string expected = "software testin";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestCase8()
        {
            MethodLibrary.MethodLibrary obj = new MethodLibrary.MethodLibrary();
            string actual = obj.HuyChuoi("software testing", 0, 9);
            string expected = "software testing";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestCase9()
        {
            MethodLibrary.MethodLibrary obj = new MethodLibrary.MethodLibrary();
            string actual = obj.HuyChuoi("software testing", 7, 8);
            string expected = "software";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestCase10()
        {
            MethodLibrary.MethodLibrary obj = new MethodLibrary.MethodLibrary();
            string actual = obj.HuyChuoi("software testing", 5, -1);
            string expected = "software testing";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestCase11()
        {
            MethodLibrary.MethodLibrary obj = new MethodLibrary.MethodLibrary();
            string actual = obj.HuyChuoi("software testing", 4, 16);
            string expected = "software testing";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestCase12()
        {
            MethodLibrary.MethodLibrary obj = new MethodLibrary.MethodLibrary();
            string actual = obj.HuyChuoi("software testing", -1, 0);
            string expected = "software testing";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestCase13()
        {
            MethodLibrary.MethodLibrary obj = new MethodLibrary.MethodLibrary();
            string actual = obj.HuyChuoi("software testing", 8, 8);
            string expected = "software";
            Assert.AreEqual(expected, actual);
        }
    }

}
