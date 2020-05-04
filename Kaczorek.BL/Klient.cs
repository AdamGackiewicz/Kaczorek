using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaczorek.BL
{
    public class Klient
    {
        public static int Licznik { get; set; }


        private string _nazwisko;
        
        public string Nazwisko
        {
            get
            {
                //jakiś kod
                return _nazwisko;
            }
            set
            {
                //jakiś kod
                _nazwisko = value;
            }

        }

        public string Imie { get; set; }

        public String Email { get; set; }

        public int KlientId { get; private set; }

        public string ImieNazwisko
        {
            get
            {
                string imieNazwisko = Imie;
                if (!string.IsNullOrWhiteSpace(Nazwisko))
                {
                    if (!string.IsNullOrWhiteSpace(imieNazwisko))
                    {
                        imieNazwisko += ", ";
                    }
                    imieNazwisko += Nazwisko;
                }
                return imieNazwisko;
            } 
        }
    }
}
