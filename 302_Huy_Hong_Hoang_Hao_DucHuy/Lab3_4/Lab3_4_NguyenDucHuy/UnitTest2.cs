using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MethodLibrary;
namespace Lab3_4_NguyenDucHuy
{
    [TestClass]
    public class UnitTest2
    {
        public TestContext TestContext { get; set; }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
    "|DataDirectory|\\data2.csv", "data2#csv",
DataAccessMethod.Sequential),
DeploymentItem("data2.csv"), TestMethod]
        public void tinhTienDien()
        {
            long s0 = Convert.ToInt32(TestContext.DataRow["s0"]);
            long s = Convert.ToInt32(TestContext.DataRow["s"]);
            MethodLibrary.MethodLibrary m = new MethodLibrary.MethodLibrary(); ;

            long rs = m.Sum(s0,out s);

            double ex = -1;
            Assert.AreEqual(ex, rs);
        }
    }
}
