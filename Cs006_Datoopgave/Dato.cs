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

        public void SetAar(int aar)
        {
            datoen = int.Parse(aar.ToString() + datoen.ToString().Substring(4, 4));
        }

        public void SetMaaned(int maaned)
        {
            string maanedStr = maaned.ToString();
            if (maanedStr.Length != 2)
                maanedStr = 0 + maanedStr;

            datoen = int.Parse(datoen.ToString().Substring(0, 4) + maanedStr + datoen.ToString().Substring(6, 2));
        }

        public void SetDag(int dag)
        {
            string dagStr = dag.ToString();
            if (dagStr.Length != 2)
                dagStr = 0 + dagStr;

            datoen = int.Parse(datoen.ToString().Substring(0, 6) + dagStr);
        }

        public string GetDatoStringAMD()
        {
            string dato = datoen.ToString().Substring(0,4)+"-"+ datoen.ToString().Substring(4, 2) + "-" + datoen.ToString().Substring(6, 2);

            return dato;
        }

        public string GetDatoStringDMA()
        {
            string dato = datoen.ToString().Substring(6,2)+"/"+datoen.ToString().Substring(4,2)+"/"+datoen.ToString().Substring(2,2);

            return dato;
        }

    }
}
