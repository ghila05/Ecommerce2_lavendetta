﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce2_lavendetta
{
    public class Alimentare: Prodotto
    {
        string[] ingredienti = new string[10];
        private DateTime scadenza;


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

        public bool ControllaScadenza(DateTime scadenza)
        {
            return scadenza < DateTime.Now;
        }

        public Alimentare(string[] ingredienti, string date)
        {
          
        }
    }
}
