using System;
using BilletLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BilletLibraryUnitTest
{
    [TestClass]
    public class MCTest
    {
        [TestMethod]
        public void MCBilletPrisTest()
        {
            //arrange
            var mc = new MC();
            //act
            decimal pris = mc.Pris();
            //assert
            Assert.AreEqual(125, pris);
        }
        [TestMethod]
        public void MCBilletPrisTest_MedDato()
        {
            //arrange
            var mc = new MC("AB12345", DateTime.Now);
            //act
            decimal pris = mc.Pris();
            //assert
            Assert.AreEqual(125, pris);
        }
        [TestMethod]
        public void KøretøjTypeTest()
        {
            //arrange
            var mc = new MC("AB12345", DateTime.Now);
            //act
            string køretøj = mc.Type();
            //assert
            Assert.AreEqual("Motorcykel", køretøj);
        }
        public void MCRabatTest_True()
        {
            //arrange
            var mc = new MC();
            //act
            decimal rabat = mc.RabatPris(true);
            //assert
            Assert.AreEqual(rabat, 118.75M);
        }
        public void MCRabatTest_False()
        {
            //arrange
            var mc = new MC();
            //act
            decimal rabat = mc.RabatPris(false);
            //assert
            Assert.AreEqual(rabat, 125M);
        }
    }
}