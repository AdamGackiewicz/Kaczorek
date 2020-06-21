using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kaczorek.BL;

namespace UnitTestProject1
{
    [TestClass]
    public class KlientRepositoryTest
    {
        [TestMethod]
        public void PobierzKlientaTest()
        {
            // Arange (przygotuj test)
            var klientRepository = new KlientRepository();
            var oczekiwana = new Klient(1)
            {
                Email = "marcin@dev-hobby.pl",
                Imie = "Marcin",
                Nazwisko = "Kowal"
            };

            // Action ( działaj)
            var aktualna = klientRepository.Pobierz(1);
            //Assert (potwierdź test)
            // Assert.AreEqual(oczekiwana, aktualna) ;
            Assert.AreEqual(oczekiwana.KlientId, aktualna.KlientId);
            Assert.AreEqual(oczekiwana.Email, aktualna.Email);
            Assert.AreEqual(oczekiwana.Imie, aktualna.Imie);
            Assert.AreEqual(oczekiwana.Nazwisko, aktualna.Nazwisko);
        }
    }
}
