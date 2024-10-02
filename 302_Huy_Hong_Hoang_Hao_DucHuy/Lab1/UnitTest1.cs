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

            int exp = 100;
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

          o.Max(aConvert, b, c);
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void TestMethod5()
        {
            object a = 10.7;
            int aConvert = Convert.ToInt32(a);
            int b = 20;
            int c = 30;

           o.Max(aConvert, b, c);
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void TestMethod6()
        {
            int a = 10;
            int b = -10;
            int c = 30;

            int exp = 30;
            Assert.AreEqual(exp, o.Max(a, b, c));
        }
        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void TestMethod7()
        {
            int a = 10;
            int b = 100;
            int c = 30;

            int exp = 100;
            Assert.AreEqual(exp, o.Max(a, b, c));
        }
        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void TestMethod8()
        {
            int a = 10;
            string b = "max";
            int bConvert = int.Parse(b);
            int c = 30;
            o.Max(a, bConvert, c);
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void TestMethod9()
        {
            int a = 10;
            object b = 10.7;
            int bConvert = Convert.ToInt32(b);
            int c = 30;

            o.Max(a, bConvert, c);
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void TestMethod10()
        {
            int a = 10;
            int b = 20;
            int c = -10;
             o.Max(a, b, c);
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void TestMethod11()
        {
            int a = 10;
            int b = 20;
            int c = 100;

          o.Max(a, b, c);
        }
        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void TestMethod12()
        {
            int a = 10;
            int b = 20;
            string c = "max";
            int cConvert = Convert.ToInt32(c);

           o.Max(a, b, cConvert);
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void TestMethod13()
        {
            int a = 10;
            int b = 20;
            object c = 10.7;
            int cConvert = Convert.ToInt32(c);

            o.Max(a, b, cConvert);
        }
        [TestMethod]
        public void TestMethod14()
        {
            int a = 1;
            int b = 1;
            int c = 1;

            int exp = 1;
            Assert.AreEqual(exp, o.Max(a, b, c));
        }

        [TestMethod]
        public void TestMethod15()
        {
            int a = 50;
            int b = 50;
            int c = 50;

            int exp = 50;
            Assert.AreEqual(exp, o.Max(a, b, c));
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void TestMethod16()
        {
            int a = 0;
            int b = 0;
            int c = 0;

            int exp = 0;
            Assert.AreEqual(exp, o.Max(a, b, c));
        }
        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void TestMethod17()
        {
            int a = 51;
            int b = 51;
            int c = 51;

            int exp = 51;
            Assert.AreEqual(exp, o.Max(a, b, c));
        }
    }
}
