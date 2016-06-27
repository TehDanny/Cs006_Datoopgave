using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs006_Datoopgave
{
    class Dato
    {
        private int datoen;

        public Dato(int aar, int maaned, int dag)
        {
            datoen = aar + maaned + dag;
        }

        public int GetAar()
        {
            int aar = this.datoen;
            return aar;
        }
    }
}
