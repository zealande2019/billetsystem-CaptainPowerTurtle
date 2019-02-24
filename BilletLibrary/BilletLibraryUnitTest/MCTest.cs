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
        public void KøretøjTypeTest()
        {
            //arrange
            var mc = new MC();
            //act
            string køretøj = mc.Type();
            //assert
            Assert.AreEqual("Motorcykel", køretøj);
        }
        [TestMethod]
        public void MCNummerpladeTjek()
        {
            //arrange
            var mc = new MC();
            //act
            string nummerplade = mc.Nummerplade();
            //assert
            Assert.AreEqual("Motorcykel", nummerplade);
        }
    }
}