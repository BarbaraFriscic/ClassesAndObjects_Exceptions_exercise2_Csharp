using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _23_11_22_Predavanje
{
    internal class Knjiga
    {
        public string Naslov { get; set; }
        public string Autor { get; set; }
        public int BrojStranica { get; set; }
        private double cijena;
        public double Cijena
        {
            get { return cijena; }
            set 
            { 
                if(value/BrojStranica > 0.5)
                {
                    KnjigaException iznimka = new KnjigaException(Naslov, value, BrojStranica);
                    throw iznimka;   
                }
                   else  cijena = value;
            }
        }
        public Knjiga(string naslov, string autor, int brojStr, double cijena)
        {
            this.Naslov = naslov;
            this.Autor = autor;
            this.BrojStranica = brojStr;
            this.Cijena = cijena; 
        }
    }
    class KnjigaException : Exception
    {
        //Rješenje prof:  --> U FORMI TREBA ONDA ISPAVITI GDJE JE iznimka.Poruka u iznimka.Message
        /*
         public KnjigaException(string naslov, double cijena, int brojStranica) : base($"Knjiga {naslov} ima nedozvoljenu cijenu po stranici. \n...Cijena iznosi {cijena:C} za {brojStranica} stranica.")
        {
        }
         */
        
        private static string poruka;
        public string Poruka
        {
            get { return poruka; }
            set { poruka = value; }
        }
        public KnjigaException(string naslov, double cijena, int brojStranica)
        {
            this.Poruka = $"Knjiga {naslov} ima nedozvoljenu cijenu po stranici. \n...Cijena iznosi {cijena:C} za {brojStranica} stranica.";
        }
        public KnjigaException() : base(poruka)
        {
        } 
    }
}
