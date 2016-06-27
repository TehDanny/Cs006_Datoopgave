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

        public Dato(string aar, string maaned, string dag)
        {
            string strDato = aar + maaned + dag;
            datoen = int.Parse(strDato);
        }

        public int GetAar()
        {
            int aar = int.Parse(datoen.ToString().Substring(0,4));
            return aar;
        }
    }
}
