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
        float sconto = 5/100;
        DateTime scadenza;


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



        public Alimentare(string[] ingredienti, DateTime scadenza,string id, string nome,string prod,string descr,float prezzo) :base (id,nome,prod,descr,prezzo) 
        {
          
        }
        
        public float getSconto(float price, DateTime scadenza)
        {
           scadenza = scadenza.AddDays(-7);
            int comp = DateTime.Compare(scadenza, DateTime.Now);
           if (comp <= 0)
           {
               return this.Prezzo * sconto;
           }
            else
            {
                return this.Prezzo;
            }

          

        }

        public override float getPrezzo()
        {
           return getSconto(Prezzo, scadenza);
        }

        
    }
}
