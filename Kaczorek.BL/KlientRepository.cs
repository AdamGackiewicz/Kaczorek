using System.Collections.Generic;

namespace Kaczorek.BL
{
    public class KlientRepository
    {
        //Metody

        /// <summary>
        /// Pobieramy jednego klienta
        /// </summary>
        /// <param name="klientId"></param>
        /// <returns></returns>
        public Klient Pobierz(int klientId)
        {
            //Tworzymy instancje klasy klienta
            Klient klient = new Klient(klientId);

            //Kod który pobiera określonego klienta
            if(klientId == 1)
            {
                klient.Email = "marcin@dev-hobby.pl";
                klient.Imie = "Marcin";
                klient.Nazwisko = "Kowal";                
            }


            return klient;
            //return new Klient();
        }

        /// <summary>
        /// Pobieramy wszystkich klientów
        /// </summary>
        /// <returns></returns>
        public List<Klient> Pobierz()
        {
            //Kod króty pobierze wszystkich klientów
            return new List<Klient>();
        }
        
        /// <summary>
        /// Zapisuje klienta
        /// </summary>
        /// <returns></returns>
        public bool Zapisz()
        {
            //Kod który zapiszuje definiowanego klienta
            return true;
        }
    }
}
