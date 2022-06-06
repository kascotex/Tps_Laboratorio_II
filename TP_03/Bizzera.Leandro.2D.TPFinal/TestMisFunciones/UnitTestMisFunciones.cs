using Microsoft.VisualStudio.TestTools.UnitTesting;
using MisFunciones;

namespace TestMisFunciones
{
    [TestClass]
    public class UnitTestMisFunciones
    {
        [TestMethod]
        public void MfString_EstaVaciaEnBlancoNull_IsFalse()
        {
            string[] data = { " ", "", null, "a" };

            bool assert = MfString.EstaVaciaEnBlancoNull(data);

            Assert.IsFalse(assert);
        }

        [TestMethod]
        public void MfString_QuitarEspacios_AreEqual()
        {
            string data = " unica - formula  @Mail ";

            string assert = "unica-formula@Mail";

            string val = MfString.QuitarEspacios(data);

            Assert.AreEqual(assert, val);
        }
        [TestMethod]
        public void MfBasic_EnRango_IsFalse()
        {
            int min = 34;
            int max = 48;

            bool assert = MfBasic.EnRango(12,min,max);

            Assert.IsFalse(assert);
        }
        [TestMethod]
        public void MfBasic_EnRango_IsTrue()
        {
            int min = 34;
            int max = 48;

            bool assert = MfBasic.EnRango(40, min, max);

            Assert.IsTrue(assert);
        }

        [TestMethod]
        public void MfBasic_EstaContenido_IsFalse()
        {
            int[] lista = { 34, 35, 37, 60, 62, 91, 92, 93 };

            bool assert = MfBasic.EstaContenido(lista, 61);

            Assert.IsFalse(assert);
        }
        [TestMethod]
        public void MfBasic_EstaContenido_IsTrue()
        {
            int[] lista = { 34, 35, 37, 60, 62, 91, 92, 93 };
            bool assert = MfBasic.EstaContenido(lista, 60);

            Assert.IsTrue(assert);
        }
        [TestMethod]
        public void MfBasic_ContieneNull_IsTrue()
        {
            bool assert = MfBasic.ContieneNull(null, true);

            Assert.IsTrue(assert);
        }
        [TestMethod]
        public void MfBasic_ContieneNull_IsFalse()
        {
            bool assert = MfBasic.ContieneNull(1, '\n');

            Assert.IsFalse(assert);
        }
        [TestMethod]
        public void MfBasic_EsMultiplo_IsFalse()
        {
            bool assert = MfBasic.EsMultiplo(11, 3);

            Assert.IsFalse(assert);
        }
       

    }
}
