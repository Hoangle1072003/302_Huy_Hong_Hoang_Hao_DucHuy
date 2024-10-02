using MethodLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
namespace Lab1
{
    [TestClass]
    public class UnitTest1
    {
        MethodLibrary.MethodLibrary o = new  MethodLibrary.MethodLibrary();
        [TestMethod]
        public void TestMethod1()
        {
            int a = 10;
            int b = 20;
            int c = 30;
            
            int exp = 30;
            Assert.AreEqual(exp, o.Max(a, b, c));
        }
        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void TestMethod2()
        {
            int a = -10;
            int b = 20;
            int c = 30;

            int exp = 30;
            Assert.AreEqual(exp, o.Max(a, b, c));
        }
        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void TestMethod3()
        {
           
            int a = 100;
            int b = 20;
            int c = 30;

            int exp = 30;
            Assert.AreEqual(exp, o.Max(a, b, c));
        }
        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void TestMethod4()
        {
            String a = "max";
            int aConvert = int.Parse(a);
            int b = 20;
            int c = 30;

            int exp = 30;
            Assert.AreEqual(exp, o.Max(aConvert, b, c));
        }
    }
}
