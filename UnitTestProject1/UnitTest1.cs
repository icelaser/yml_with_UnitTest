using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void eins_plus_eins_gleich_zwei()
        {
            Assert.AreEqual((1 + 1), 2);
        }
    }
}
