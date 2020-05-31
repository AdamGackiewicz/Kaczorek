using System;
using System.Collections.Generic;

namespace Kaczorek.BL
{
    class Produkt
    {
        public Produkt()
        {

        }
        public Produkt(int produktId)
        {
            ProduktId = produktId;
        }
        public  int ProduktId { get; private set; }
        public Decimal? AktualnaCena { get; set; }
        public string Opis { get; set; }
        public string NazwaProduktu { get; set; }

        //Metody

        /// <summary>
        /// Sprawdza dane produktu
        /// </summary>
         /// <returns></returns>
        public bool Zwaliduj()
        {
            var poprawne = true;

            if (string.IsNullOrWhiteSpace(NazwaProduktu))
                poprawne = false;
            if (AktualnaCena == null)
                poprawne = false;            
            return poprawne;
        }

        /// <summary>
        /// Zapisuje produkt
        /// </summary>
        /// <returns></returns>
        public bool Zapisz()
        {
            //Kod który zapiszuje definiowany produkt
            return true;
        }

        /// <summary>
        /// Pobieramy jednen produkt
        /// </summary>
        /// <param name="produktId"></param>
        /// <returns></returns>
        public Klient Pobierz(int produktId)
        {
            //Kod który pobiera określony produkt
            return new Klient();
        }

        /// <summary>
        /// Pobieramy wszystkie produkty
        /// </summary>
        /// <returns></returns>
        public List<Produkt> Pobierz()
        {
            //Kod króty pobierze wszystkie produkty
            return new List<Produkt>();
        }

    }
}
