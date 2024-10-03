
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lab6
{
    [TestClass]
    public class UnitTest1
    {
        // Testcase Valid Parameter
        [TestMethod]
        public void TestValidParameter()
        {
            // Testcase 1
            string result1 = StringReplacement.ThayThe("dh cong nghiep", "dh", "dai hoc");
            Assert.AreEqual("dai hoc cong nghiep", result1);
        }

        // Testcase Invalid Parameter
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestInvalidParameterS1()
        {
            // Testcase: s1 là null
            StringReplacement.ThayThe(null, "dh", "dai hoc");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestInvalidParameterS2()
        {
            // Testcase: s2 là null
            StringReplacement.ThayThe("dh cong nghiep", null, "dai hoc");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestInvalidParameterS3()
        {
            // Testcase: s3 là null
            StringReplacement.ThayThe("dh cong nghiep", "dh", null);
        }

        // Testcase Valid Boundary
        [TestMethod]
        public void TestValidBoundary()
        {
            // Testcase: Tất cả chuỗi đều rỗng
            string result = StringReplacement.ThayThe("", "", "");
            Assert.AreEqual("", result); // Kỳ vọng chuỗi rỗng
        }

        // Testcase Invalid Boundary
        [TestMethod]
        public void TestInvalidBoundary()
        {
            // Testcase: s1 hợp lệ, s2 và s3 rỗng
            string result = StringReplacement.ThayThe("abc", "", "");
            Assert.AreEqual("abc", result); // Kỳ vọng chuỗi không thay đổi
        }
    }
}
