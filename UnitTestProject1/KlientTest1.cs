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
            // Arange (przygotuj test)
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
            // Arange (przygotuj test)
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
            // Arange (przygotuj test)
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
            // Arange (przygotuj test)
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

        [TestMethod]
        public void ZwalidujTest()
        {
            // Arange (przygotuj test)
            var klient = new Klient();
            klient.Nazwisko = "Kowal";
            klient.Email = "marcin@dev-hobby.pl";
            var oczekiwania = true;

            // Action ( działaj)
            var aktualna = klient.Zwaliduj();

            //Assert (potwierdź test)
            Assert.AreEqual(oczekiwania, aktualna);

        }
        [TestMethod]
        public void ZwalidujBrakNazwiskaTest()
        {
            // Arange (przygotuj test)
            var klient = new Klient();
            klient.Email = "marcin@dev-hobby.pl";
            var oczekiwania = false;

            // Action ( działaj)
            var aktualna = klient.Zwaliduj();

            //Assert (potwierdź test)
            Assert.AreEqual(oczekiwania, aktualna);
        }
        [TestMethod]
        public void ZwalidujBrakEmailTest()
        {
            // Arange (przygotuj test)
            var klient = new Klient();
            klient.Nazwisko = "Kowal";
            var oczekiwania = false;

            // Action ( działaj)
            var aktualna = klient.Zwaliduj();

            //Assert (potwierdź test)
            Assert.AreEqual(oczekiwania, aktualna);

        }
    }
}
