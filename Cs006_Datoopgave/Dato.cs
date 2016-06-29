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

        internal int GetKvartal()
        {
            int kvartal = 0;
            int maaned = GetMaaned();
            if (maaned < 4)
                kvartal = 1;
            else if (maaned > 3 && maaned < 7)
                kvartal = 2;
            else if (maaned > 6 && maaned < 10)
                kvartal = 3;
            else if (maaned > 9)
                kvartal = 4;
            return kvartal;
        }

        public string GetMaanedTxt()
        {
            int maaned = GetMaaned();
            string maanedTxt = "";
            switch (maaned)
            {
                case 1:
                    maanedTxt = "Januar";
                    break;

                case 2:
                    maanedTxt = "Februar";
                    break;

                case 3:
                    maanedTxt = "Marts";
                    break;

                case 4:
                    maanedTxt = "April";
                    break;

                case 5:
                    maanedTxt = "Maj";
                    break;

                case 6:
                    maanedTxt = "Juni";
                    break;

                case 7:
                    maanedTxt = "Juli";
                    break;

                case 8:
                    maanedTxt = "August";
                    break;

                case 9:
                    maanedTxt = "September";
                    break;

                case 10:
                    maanedTxt = "Oktober";
                    break;

                case 11:
                    maanedTxt = "November";
                    break;

                case 12:
                    maanedTxt = "December";
                    break;

                default:
                    break;
            }
            return maanedTxt;
        }

        public string GetKvartalTxt()
        {
            int maaned = GetMaaned();
            string kvartalTxt = "";
            switch (maaned)
            {
                case 1:
                case 2:
                case 3:
                    kvartalTxt = "Første kvartal";
                    break;

                case 4:
                case 5:
                case 6:
                    kvartalTxt = "Andet kvartal";
                    break;

                case 7:
                case 8:
                case 9:
                    kvartalTxt = "Tredje kvartal";
                    break;

                case 10:
                case 11:
                case 12:
                    kvartalTxt = "Fjerde kvartal";
                    break;

                default:
                    break;
            }
            return kvartalTxt;
        }

        /*
        private enum Maaneder
        {
            Janaur = 1,
            Februar,
            Marts,
            April,
            Maj,
            Juni,
            Juli,
            August,
            September,
            Oktober,
            November,
            December
        }
        */
    }
}
