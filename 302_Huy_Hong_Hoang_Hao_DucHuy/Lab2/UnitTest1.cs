using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MethodLibrary;


namespace Lab2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            float x1 = 0.0f;
            float x2 = 0.0f;
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            String kq = o.SolveQuadratic(1, -5, 6, out x1, out x2);
            Assert.AreEqual(2, x1);
            Assert.AreEqual(3, x2);
            //Assert.AreEqual("Có 2 nghiệm phân biệt", kq);

        }
        [TestMethod]
        public void TestMethod2()
        {
            float x1 = 0.0f;
            float x2 = 0.0f;
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            String kq = o.SolveQuadratic(1, -5, 6, out x1, out x2);
            Assert.AreEqual("Có 2 nghiệm phân biệt", kq);

        }
        [TestMethod]
        public void TestMethod3()
        {
            float x1 = 0.0f;
            float x2 = 0.0f;
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            String kq = o.SolveQuadratic(0, 0, 0, out x1, out x2);
            Assert.AreEqual("Vô số nghiệm", kq);

        }
        [TestMethod]
        public void TestMethod4()
        {
            float x1 = 0.0f;
            float x2 = 0.0f;
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            String kq = o.SolveQuadratic(8, 3, 3, out x1, out x2);
            Assert.AreEqual("Vô nghiệm", kq);

        }
        [TestMethod]
        public void TestMethod5()
        {
            float x1 = 0.0f;
            float x2 = 0.0f;
            MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
            String kq = o.SolveQuadratic(1, -10, 25, out x1, out x2);
            Assert.AreEqual("Có nghiệm kép", kq);

        }
        //[TestMethod]
        //public void TestMethod6()
        //{
        //    float x1 = 0.0f;
        //    float x2 = 0.0f;
        //    MethodLibrary.MethodLibrary o = new MethodLibrary.MethodLibrary();
        //    String kq = o.SolveQuadratic(2.3, 5, 7, out x1, out x2);
        //    Assert.AreEqual("Có nghiệm kép", kq);

        //}
    }
}
