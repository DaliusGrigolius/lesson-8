using Microsoft.VisualStudio.TestTools.UnitTesting;
using paskaita_8_darbas_02.Bussines;

namespace PalmeTestai
{
    [TestClass]
    public class PalmeTestas
    {
        [TestMethod]
        public void AmziusDaugiauNegu12()
        {
            Palme palme = new Palme(12, 0);
            palme.Prideti1MenAmziaus();

            Assert.AreEqual(0, palme.Amzius);
        }

        [TestMethod]
        public void Amzius5MenVaisiuKiekis15()
        {
            Palme palme1 = new Palme(4, 0);
            palme1.Prideti1MenAmziaus();

            Assert.AreEqual(15, palme1.VaisiuKiekis);
        }

        [TestMethod]
        public void Amzius12MenVaisiuKiekis36()
        {
            Palme palme2 = new Palme(11, 0);
            palme2.Prideti1MenAmziaus();

            Assert.AreEqual(36, palme2.VaisiuKiekis);
        }

        [TestMethod]
        public void Amzius4MenVaisiuKiekis0()
        {
            Palme palme3 = new Palme(3, 0);
            palme3.Prideti1MenAmziaus();

            Assert.AreEqual(0, palme3.VaisiuKiekis);
        }
    }
}
