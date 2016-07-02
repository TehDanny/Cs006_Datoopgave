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

        public void MoveToNextDate()
        {
            int day = GetDag();
            int month = GetMaaned();
            int year = GetAar();
            int daysOnCurrentMonth = GetDaysOnMonth(month, year);

            if (day < daysOnCurrentMonth)
                day++;
            else if (day == daysOnCurrentMonth)
            {
                day = 1;
                if (month < 12)
                    month++;
                else if (month == 12)
                {
                    month = 1;
                    year++;
                }
            }

            SetDag(day);
            SetMaaned(month);
            SetAar(year);
        }

        public void MoveToPrevDate()
        {
            int day = GetDag();
            int month = GetMaaned();
            int year = GetAar();
            int daysOnPreviousMonth = 0;

            if (month > 1)
                daysOnPreviousMonth = GetDaysOnMonth(month-1, year);
            else if (month == 1)
                daysOnPreviousMonth = GetDaysOnMonth(12, year);

            if (day > 1)
                day--;
            else if (day == 1)
            {
                day = daysOnPreviousMonth;
                if (month > 1)
                {
                    month--;
                }
                else if (month == 1)
                {
                    month = 12;
                    year--;
                }
            }

            SetDag(day);
            SetMaaned(month);
            SetAar(year);
        }

        private int GetDaysOnMonth(int month, int year)
        {
            int daysOnMonth = 0;
            switch (month)
            {
                case 1:
                    daysOnMonth = 31;
                    break;

                case 2: // https://en.wikipedia.org/wiki/Leap_year
                    if (year % 4 != 0 && year % 400 != 0)
                        daysOnMonth = 28;
                    else if (year % 100 != 0)
                        daysOnMonth = 29;
                    else
                        daysOnMonth = 29;
                    break;

                case 3:
                    daysOnMonth = 31;
                    break;

                case 4:
                    daysOnMonth = 30;
                    break;

                case 5:
                    daysOnMonth = 31;
                    break;

                case 6:
                    daysOnMonth = 30;
                    break;

                case 7:
                    daysOnMonth = 31;
                    break;

                case 8:
                    daysOnMonth = 31;
                    break;

                case 9:
                    daysOnMonth = 30;
                    break;

                case 10:
                    daysOnMonth = 31;
                    break;

                case 11:
                    daysOnMonth = 30;
                    break;

                case 12:
                    daysOnMonth = 31;
                    break;

                default:
                    break;
            }
            return daysOnMonth;
        }

        public void MoveDays(int days)
        {
            if (days < 0)
            {
                for (int i = 0; i >= days+1; i--)
                {
                    MoveToPrevDate();
                }
            }
            else if (days > 0)
            {
                for (int i = 0; i <= days-1; i++)
                {
                    MoveToNextDate();
                }
            }
        }

        public int GetDagnr()
        {
            int daynr = 0;
            int day = GetDag();
            int month = GetMaaned();
            int year = GetAar();

            for (int i = 1; i < month; i++)
            {
                daynr += GetDaysOnMonth(i, year);
            }

            daynr += day;

            return daynr;
        }

        public void SetDagnr(int year, int daynr)
        {
            int day = 0;
            int month = 1;
            int dayCounter = 0;

            while (dayCounter < daynr && daynr - dayCounter > GetDaysOnMonth(month, year))
            {
                dayCounter += GetDaysOnMonth(month, year);
                month++;
            }

            day = daynr - dayCounter;

            SetAar(year);
            SetMaaned(month);
            SetDag(day);
        }

        /*
        public int GetAbsDagnr()
        {
            int daynr = 0;
            int year = GetAar();
            int month = GetMaaned();
            int day = GetDag();

            while (daynr - GetDaysOnMonth())
            {
                daynr += GetDaysOnMonth();
            }

            return daynr;
        }
        */

        public int GetUgedag()
        {
            int ugedag = GetJulianDayNumber() % 7 + 1;
            return ugedag;
        }

        //  the Julian day number of 1 July 2016 is 2457570. Calculating (2457570 mod 7 + 1) yields 4, corresponding to Friday.
        // https://en.wikipedia.org/wiki/Week

        enum Weekdays
        {
            Mandag =1,
            Tirsdag,
            Onsdag,
            Torsdag,
            Fredag,
            Lørdag,
            Søndag
        }

        public int GetUgenr()
        {
            int ugenr = 0;
            return ugenr;
        }

        // Julian calendar starts at January 1, 4713 BC
        public int GetJulianDayNumber()
        {
            int julianDayNumber = 0;
            int year = GetAar();
            int month = GetMaaned();
            int day = GetDag();
            int currentYear = -4713;
            int currentMonth = 1;
            bool keepRunning = true;

            while (keepRunning)
            {
                julianDayNumber += GetDaysOnMonth(currentMonth, currentYear);
                if (currentMonth <12)
                    currentMonth++;
                else if (currentMonth == 12)
                {
                    currentMonth = 1;
                    currentYear++;
                }
                if (currentYear == year && currentMonth == month)
                    keepRunning = false;
            }

            julianDayNumber += day - 1;
            
            return julianDayNumber;
        }
    }
}
