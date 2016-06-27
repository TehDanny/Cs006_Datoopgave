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

        public int GetMaaned()
        {
            int maaned = int.Parse(datoen.ToString().Substring(4, 2));
            return maaned;
        }

        public int GetDag()
        {
            int dag = int.Parse(datoen.ToString().Substring(6, 2));
            return dag;
        }
    }
}
