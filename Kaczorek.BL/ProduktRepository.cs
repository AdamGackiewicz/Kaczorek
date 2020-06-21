using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaczorek.BL
{
   public class ProduktRepository
    {
        

        /// <summary>
        /// Pobieramy jednen produkt
        /// </summary>
        /// <param name="produktId"></param>
        /// <returns></returns>
        public Produkt Pobierz(int produktId)
        {
            //tworzenie instancji produktu
            Produkt produkt = new Produkt(produktId);

            //Kod który pobiera określony produkt

            //Tymczasowo zakodowane wartości produktu
            if (produktId == 5)
            {
                produkt.NazwaProduktu = "Klocki";
                produkt.Opis = "klocki dla dzieci";
                produkt.AktualnaCena = 89.99M;
            }


            return produkt;
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

        /// <summary>
        /// Zapisuje produkt
        /// </summary>
        /// <returns></returns>
        public bool Zapisz()
        {
            //Kod który zapiszuje definiowany produkt
            return true;
        }
    }
}
