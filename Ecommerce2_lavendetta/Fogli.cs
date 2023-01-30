﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce2_lavendetta
{
    public class Fogli: Cancelleria
    {
        float grammatura;

        public float Grammatura
        {
            get
            {
                return grammatura;
            }
            set
            {
                if ( value > 0)
                {
                    grammatura = value;
                }
            }
        }

        public Fogli(float grammatura)
        {
            Grammatura = grammatura;

        }   
    }
}
