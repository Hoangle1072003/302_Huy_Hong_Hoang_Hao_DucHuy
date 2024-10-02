using MethodLibrary;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lab8
{
    [TestClass]
    public class UnitTest1
    {
        MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();

        [TestMethod]
        public void TestMethod1()
        {
            int[] arr = { 10, 10, 10 };
            int left = 1;
            int right = 2;
            o.QuickSort(arr, left, right);
            CollectionAssert.AreEqual(arr, new int[] { 10, 10, 10 });
        }
        [TestMethod]
        public void TestMethod2()
        {
            int[] arr = { 3, 2, 1, 4, 10, 8 };
            int left = 1;
            int right = 3;
            System.Console.WriteLine("hello" + right);
            o.QuickSort(arr, left, right);
            CollectionAssert.AreEqual(arr, new int[] { 3, 1, 2, 4, 10, 8 });
        }
        [TestMethod]
        public void TestMethod3()
        {
            int[] arr = { 1, -1, 0 };
            int left = 1;
            int right = 0;
            o.QuickSort(arr, left, right);
            CollectionAssert.AreEqual(arr, new int[] { 1, -1, 0 });
        }
        // invalid input
        [TestMethod]
        public void TestMethod4()
        {
            int[] arr = { 10 };
            int left = 1;
            int right = 2;
            o.QuickSort(arr, left, right);
        }
        [TestMethod]
        public void TestMethod5()
        {
            int[] arr = { 48, 2, 13, 172 }
;
            int left = 1;
            int right = 5;
            o.QuickSort(arr, left, right);
        }
        [TestMethod]
        public void TestMethod6()
        {
            string hoang = "hoang";
            int hoangCover = int.Parse(hoang);
            int[] arr = { 10, hoangCover, 15 }
;
            int left = 0;
            int right = 2;
            o.QuickSort(arr, left, right);
        }
        [TestMethod]
        public void TestMethod7()
        {
            int[] arr = { }
;
            int left = 0;
            int right = 2;
            o.QuickSort(arr, left, right);
        }

        [TestMethod]
        public void TestMethod8()
        {
            int[] arr = { 20, 15, 10 }
;
            int left = -10;
            int right = 2;
            o.QuickSort(arr, left, right);
        }
        [TestMethod]
        public void TestMethod9()
        {
            int[] arr = { 20, 15, 10 }
;
            int left = 5;
            int right = 2;
            o.QuickSort(arr, left, right);
        }
        [TestMethod]
        public void TestMethod10()
        {
            int[] arr = { 20, 15, 10 };
            double left = 10.7;
            int leftConver = int.Parse(left.ToString());
            System.Console.WriteLine("hello " + leftConver);
            int right = 2;
            o.QuickSort(arr, leftConver, right);
        }

        [TestMethod]
        public void TestMethod11()
        {
            string hoang = "hoang";
            int hoangCover = int.Parse(hoang);
            int[] arr = { 20, 15, 10 }
;
            int left = int.Parse(hoang);
            int right = 2;
            o.QuickSort(arr, left, right);
        }

        [TestMethod]
        public void TestMethod12()
        {
            int[] arr = { 20, 15, 10 }
;
            int left = 0;
            int right = -1;
            o.QuickSort(arr, left, right);
            //CollectionAssert.AreEqual(arr, new int[] { 20, 15, 10 });
        }

        [TestMethod]
        public void TestMethod13()
        {
            int[] arr = { 48, 20 }
;
            int left = -1;
            int right = -1;
            o.QuickSort(arr, left, right);
            //CollectionAssert.AreEqual(arr, new int[] { 20, 15, 10 });
        }
    }
    }
