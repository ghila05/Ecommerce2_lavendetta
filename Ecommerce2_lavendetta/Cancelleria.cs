﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce2_lavendetta
{
    public class Cancelleria : Prodotto
    {
        public Cancelleria()
        {

        }

        float sconto = 0,97;

        public override float getPrezzo()
        {
            if(DateTime.Now.Day % 2 == 0)
            {
                return this.Prezzo * sconto
            }
        }
    }
}
