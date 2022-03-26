using _8_lesson_8.Business;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace GetSet
{
    [TestClass]
    public class SaskaitosTestai
    {
        [TestMethod]
        public void CreateAccountFieldsSetCorrectly()
        {
            Saskaita saskaita = new Saskaita("gavejas2", "siuntejas2", 55);

            Assert.AreEqual("gavejas2", saskaita.Gavejas);
            Assert.AreEqual("siuntejas2", saskaita.Siuntejas);
            Assert.AreEqual(55, saskaita.MoketiViso);
            Assert.AreEqual($"NR_{DateTime.Now.ToString("yyyy_MM_dd")}_01", saskaita.SaskaitosNumeris);
        }
    }
}
