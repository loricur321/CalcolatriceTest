using Microsoft.VisualStudio.TestTools.UnitTesting;
using AS2021_4H_TPSIT_CurziLorenzo_Calcolatrice;

namespace AS2021_4H_TPSIT_CurziLorenzo_CalcolatriceTest
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Test della somma
        /// </summary>
        [TestMethod]
        public void TestSomma()
        {
            Calcolatrice c = new();

            Assert.AreEqual(c.Operazione(2, "+", 3), 5);
        }

        /// <summary>
        /// Test della differenza
        /// </summary>
        [TestMethod]
        public void TestDifferenza()
        {
            Calcolatrice c = new();

            Assert.AreEqual(c.Operazione(5, "-", 3), 2);
        }

        /// <summary>
        /// Test della moltiplicazione
        /// </summary>
        [TestMethod]
        public void TestMoltiplicazione()
        {
            Calcolatrice c = new();

            Assert.AreEqual(c.Operazione(5, "*", 3), 15);
        }

        /// <summary>
        /// Test della divisione
        /// </summary>
        [TestMethod]
        public void TestDivisione()
        {
            Calcolatrice c = new();

            Assert.AreEqual(c.Operazione(15, "/", 3), 5);
        }

        /// <summary>
        /// Test dell'elevamento a potenza
        /// </summary>
        [TestMethod]
        public void TestElevamento()
        {
            Calcolatrice c = new();

            Assert.AreEqual(c.Operazione(2, "^", 3), 8);
        }

        /// <summary>
        /// Test del fattoriale
        /// </summary>
        [TestMethod]
        public void TestFattoriale()
        {
            Calcolatrice c = new();

            Assert.AreEqual(c.Operazione(7, "!"), 5040);
        }
    }
}

