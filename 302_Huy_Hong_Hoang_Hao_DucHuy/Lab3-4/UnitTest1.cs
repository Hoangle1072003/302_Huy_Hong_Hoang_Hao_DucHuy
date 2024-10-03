using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MethodLibrary;

namespace Lab3_4
{
    [TestClass]
    public class UnitTest1
    {
        public TestContext TestContext { get; set; }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
    "|DataDirectory|\\data1.csv", "data1#csv",
DataAccessMethod.Sequential),
DeploymentItem("data1.csv"), TestMethod]
        public void tinhTienDien()
        {
            int chiSoCu = Convert.ToInt32(TestContext.DataRow["chiSoCu"]);
            int chiSoMoi = Convert.ToInt32(TestContext.DataRow["chiSoMoi"]);
            MethodLibrary.MethodLibrary m = new MethodLibrary.MethodLibrary(); ;
            double kq = m.TinhTienDien(chiSoCu, chiSoMoi);

            double ex = -1;
            Assert.AreEqual(ex, kq);
        }
    }
}
