using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce2_lavendetta
{
    public class Alimentare: Prodotto
    {
        string[] ingredienti = new string[10];



        public string[] Ingredienti
        {
            get
            {
                return ingredienti;
            }
            private set
            {
                if (value != null)
                {
                    ingredienti = value;
                }
            }
        }



        public Alimentare(string[] ingredienti, string date)
        {
          
        }
        /*
        public float getSconto(float price, DateTime scadenza)
        {
           
          data una data di scadenza verifica se oggi siamo 7 gg prima, in caso affermativo applica uno sconto del 50%
          

        }

        public override float getPrezzo()
        {
          ritorna il prezzo scontato
        }

        */
    }
}
