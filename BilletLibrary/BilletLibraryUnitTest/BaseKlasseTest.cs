using System;
using BilletLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BilletLibraryUnitTest
{
    [TestClass]
    public class BaseKlasseTest
    {
        [TestMethod]
        public void SætNummerPladeVærdi()
        {
            //arrange
            BaseKlasse nummerplade = new MC();
            string værdi = "AB12345";
            //act
            nummerplade.Nummerplade = værdi;
            //assert
            Assert.AreEqual("AB12345", værdi);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TjekNummerpladeLængde()
        {
            //arrange
            BaseKlasse nummerplade = new MC();
            //act
            nummerplade.Nummerplade = "AB123456";
            //assert
            Assert.Fail();
        }
    }
}