using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MethodLibrary;

namespace Test3_4
{
    [TestClass]
    public class UnitTest1
    {
        public TestContext TestContext { get; set; }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
    "|DataDirectory|\\Data3.csv", "Data3#csv",
DataAccessMethod.Sequential),
DeploymentItem("Data3.csv"), TestMethod] 

        public void tinhTienDien()
        {
            MethodLibrary.MethodLibrary me = new MethodLibrary.MethodLibrary();
            double kq = me.TinhTienDien(100,-1);
            double ex = 81620;
            Assert.AreEqual(ex, kq);
        }
        public void Sum()
        {
            MethodLibrary.MethodLibrary me = new MethodLibrary.MethodLibrary();
            long s = -1; ;
            long kq = me.Sum(0, out s);
            long exK = 1;
            Assert.AreEqual(exK, kq);
            
        }

    }
}
