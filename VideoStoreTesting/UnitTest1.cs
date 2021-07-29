using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using VideoStore;

namespace VideoStoreTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestConnection()
        {
            DataOperation operation = new DataOperation();
            Assert.AreEqual(operation.CheckState(), true);
        }

        [TestMethod]
        public void TestValidator()
        {
            string invalid_number = "POE124";
            Assert.AreEqual(Validator.CheckNumber(invalid_number), false);

        }
    }
}
