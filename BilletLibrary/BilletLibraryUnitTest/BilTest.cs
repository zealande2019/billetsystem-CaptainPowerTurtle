using System;
using BilletLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BilletLibraryUnitTest
{
    [TestClass]
    public class BilTest
    {
        [TestMethod]
        public void BilBilletPrisTest()
        {
            //arrange
            var bil = new Bil();
            //act
            decimal pris = bil.SetPrice();
            //assert
            Assert.AreEqual(240, pris);
        }
        [TestMethod]
        public void KøretøjTypeTest()
        {
            //arrange
            var bil = new Bil();
            //act
            string køretøj = bil.SetKøretøj();
            //assert
            Assert.AreEqual("Bil", køretøj);
        }
    }
}
