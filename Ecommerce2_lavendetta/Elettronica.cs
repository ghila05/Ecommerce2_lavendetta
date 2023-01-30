﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce2_lavendetta
{
    public class Elettronica: Prodotto
    {
        string _modello;
        float sconto = 95/100;

        public string Modello
        {
            get
            {
                return _modello;
            }
            private set
            {
                if (value != "")
                {
                    _modello = value;
                }
            }
        }

        public Elettronica(string id, string nome, string prod, string descr, float prezzo, string modello): base (id,nome,prod,descr)
        {
            Modello = modello;
        }
        public Elettronica() : this(null,null,null,null,0,null)
        {

        }

        public double getSconto(float price)
        {
            if(DateTime.Today.DayOfWeek == DayOfWeek.Monday)
            {
                return price * sconto;
            }
            else
            {
                return price;
            }
        }

    }
}
