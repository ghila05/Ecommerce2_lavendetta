using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce2_lavendetta
{
    public class Penne: Cancelleria
    {
        string funzionamento;

        public string Funzionamento
        {
            get
            {
                return funzionamento;
            }
            set
            {
                if ( value != "")
                {
                    funzionamento = value;
                }
            }
        }

        public Penne(string funzionamento)
        {
            Funzionamento = funzionamento;

        }
    }
}
