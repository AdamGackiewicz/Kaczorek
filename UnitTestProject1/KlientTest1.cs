using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kaczorek.BL;

namespace Kaczorek.BL.Test
{
    [TestClass]
    public class KlientTest
    {
        [TestMethod]
        public void ImieNazwiskoTest()
        {
            // Arange
            Klient klient = new Klient();
            klient.Imie = "Robert";
            klient.Nazwisko = "Kowal";

            string oczekiwana = "Robert, Kowal";
            // Action ( działaj)
            string aktualna = klient.ImieNazwisko;
            
            //Assert (potwierdź test)
            Assert.AreEqual(oczekiwana, aktualna);
        }
        [TestMethod]
        public void ImieNazwiskoImiePusteTest()
        {
            // Arange
            Klient klient = new Klient();
            klient.Nazwisko = "Kowal";

            string oczekiwana = "Kowal";
            // Action ( działaj)
            string aktualna = klient.ImieNazwisko;

            //Assert (potwierdź test)
            Assert.AreEqual(oczekiwana, aktualna);
        }
        [TestMethod]
        public void ImieNazwiskoNazwiskoPusteTest()
        {
            // Arange
            Klient klient = new Klient();
            klient.Imie = "Robert";
            

            string oczekiwana = "Robert";
            // Action ( działaj)
            string aktualna = klient.ImieNazwisko;

            //Assert (potwierdź test)
            Assert.AreEqual(oczekiwana, aktualna);
        }
        [TestMethod]
        public void StaticTest()
        {
            // Arange
            var kln1 = new Klient();
            kln1.Imie = "Jacek";
            Klient.Licznik += 1;

            var kln2 = new Klient();
            kln2.Imie = "Maciek";
            Klient.Licznik += 1;

            var kln3 = new Klient();
            kln3.Imie = "Irek";
            Klient.Licznik += 1;
            

            // Action ( działaj)



            //Assert (potwierdź test)
            Assert.AreEqual(3, Klient.Licznik);

        }
    }
}
