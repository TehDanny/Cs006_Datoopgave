using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs006_Datoopgave
{
    class Program
    {
        Dato dato;

        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Run();
        }

        private void Run()
        {
            MainMenu();
        }

        private void MainMenu()
        {
            bool keepRunning = true;
            do
            {
                ShowMenu();
                int choice = ChooseAction();
                switch (choice)
                {
                    case 0:
                        keepRunning = false;
                        break;

                    case 1:
                        CreateDate();
                        Console.WriteLine("Oprettet dato.");
                        Console.WriteLine("Tryk på en vilkårlig tast for at fortsætte...");
                        Console.ReadKey();
                        break;

                    case 2:
                        Console.WriteLine("\nÅret er: {0}", dato.GetAar());
                        Console.WriteLine("Tryk på en vilkårlig tast for at fortsætte...");
                        Console.ReadKey();
                        break;

                    case 3:
                        Console.WriteLine("\nMåneden er: {0}", dato.GetMaaned());
                        Console.WriteLine("Tryk på en vilkårlig tast for at fortsætte...");
                        Console.ReadKey();
                        break;

                    case 4:
                        Console.WriteLine("\nDagen er: {0}", dato.GetDag());
                        Console.WriteLine("Tryk på en vilkårlig tast for at fortsætte...");
                        Console.ReadKey();
                        break;

                    case 5:
                        SetAar();
                        Console.WriteLine("\nÅret er skiftet til: {0}", dato.GetAar());
                        Console.WriteLine("Tryk på en vilkårlig tast for at fortsætte...");
                        Console.ReadKey();
                        break;

                    case 6:
                        SetMaaned();
                        Console.WriteLine("\nMåneden er skiftet til: {0}", dato.GetMaaned());
                        Console.WriteLine("Tryk på en vilkårlig tast for at fortsætte...");
                        Console.ReadKey();
                        break;

                    case 7:
                        SetDag();
                        Console.WriteLine("\nDagen er skiftet til: {0}", dato.GetDag());
                        Console.WriteLine("Tryk på en vilkårlig tast for at fortsætte...");
                        Console.ReadKey();
                        break;

                    case 8:
                        Console.WriteLine("\nDatoen er: {0}", dato.GetDatoStringAMD());
                        Console.WriteLine("Tryk på en vilkårlig tast for at fortsætte...");
                        Console.ReadKey();
                        break;

                    case 9:
                        Console.WriteLine("\nDatoen er: {0}", dato.GetDatoStringDMA());
                        Console.WriteLine("Tryk på en vilkårlig tast for at fortsætte...");
                        Console.ReadKey();
                        break;

                    case 10:
                        Console.WriteLine("\nKvartal: {0}", dato.GetKvartal());
                        Console.WriteLine("Tryk på en vilkårlig tast for at fortsætte...");
                        Console.ReadKey();
                        break;

                    case 11:
                        Console.WriteLine("\nMåned i tekstformat: {0}", dato.GetMaanedTxt());
                        Console.WriteLine("Tryk på en vilkårlig tast for at fortsætte...");
                        Console.ReadKey();
                        break;

                    case 12:
                        Console.WriteLine("\nKvartal i tekstformat: {0}", dato.GetKvartalTxt());
                        Console.WriteLine("Tryk på en vilkårlig tast for at fortsætte...");
                        Console.ReadKey();
                        break;

                    case 13:
                        dato.MoveToNextDate();
                        Console.WriteLine("\nDatoen er: {0}", dato.GetDatoStringAMD());
                        Console.WriteLine("Tryk på en vilkårlig tast for at fortsætte...");
                        Console.ReadKey();
                        break;

                    case 14:
                        dato.MoveToPrevDate();
                        Console.WriteLine("\nDatoen er: {0}", dato.GetDatoStringAMD());
                        Console.WriteLine("Tryk på en vilkårlig tast for at fortsætte...");
                        Console.ReadKey();
                        break;

                    case 15:
                        int days = QueryAmountOfDays();
                        dato.MoveDays(days);
                        Console.WriteLine("\nDatoen er: {0}", dato.GetDatoStringAMD());
                        Console.WriteLine("Tryk på en vilkårlig tast for at fortsætte...");
                        Console.ReadKey();
                        break;

                    case 16:
                        Console.WriteLine("Dagnr på året er: {0}", dato.GetDagnr()); ;
                        Console.WriteLine("Tryk på en vilkårlig tast for at fortsætte...");
                        Console.ReadKey();
                        break;

                    case 17:
                        int year = QueryYear();
                        int daynr = QueryDaynr();
                        dato.SetDagnr(year, daynr);
                        Console.WriteLine("\nDatoen er: {0}", dato.GetDatoStringAMD());
                        Console.WriteLine("Tryk på en vilkårlig tast for at fortsætte...");
                        Console.ReadKey();
                        break;

                    /*
                case 18:
                    Console.WriteLine("\nDagnr fra år 0 er: {0}", dato.GetAbsDagnr());
                    Console.WriteLine("Tryk på en vilkårlig tast for at fortsætte...");
                    Console.ReadKey();
                    break;
                    */

                    case 19:
                        Console.WriteLine("Det Julianske dags nummer er {0}", dato.GetJulianDayNumber());
                        Console.WriteLine("Tryk på en vilkårlig tast for at fortsætte...");
                        Console.ReadKey();
                        break;

                    case 20:
                        Console.WriteLine("Dagen på ugen er {0}", dato.GetUgedag());
                        Console.WriteLine("Tryk på en vilkårlig tast for at fortsætte...");
                        Console.ReadKey();
                        break;

                    case -1:
                        Console.WriteLine("Indtast venligst et tal");
                        Console.WriteLine("Tryk på en vilkårlig tast for at fortsætte...");
                        Console.ReadKey();
                        break;

                    default:
                        Console.WriteLine("Indtast venligst et gyldigt tal");
                        Console.WriteLine("Tryk på en vilkårlig tast for at fortsætte...");
                        Console.ReadKey();
                        break;
                }
            } while (keepRunning);
        }

        private void ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("Dato program");
            Console.WriteLine("0. Afslut program");
            Console.WriteLine("1. Opret dato");
            Console.WriteLine("2. Hent år");
            Console.WriteLine("3. Hent måned");
            Console.WriteLine("4. Hent dag");
            Console.WriteLine("5. Skift år");
            Console.WriteLine("6. Skift måned");
            Console.WriteLine("7. Skift dag");
            Console.WriteLine("8. Hent dato [AAAA-MM-DD]");
            Console.WriteLine("9. Hent dato [DD/MM/AA]");
            Console.WriteLine("10. Hent kvartal");
            Console.WriteLine("11. Hent måned i tekst-format");
            Console.WriteLine("12. Hent kvartal i tekst-format");
            Console.WriteLine("13. Flyt dato én dag frem");
            Console.WriteLine("14. Flyt dato én dag tilbage");
            Console.WriteLine("15. Flyt dato et antal dage frem eller tilbage");
            Console.WriteLine("16. Hent dagnr på året");
            Console.WriteLine("17. Skift dato til valgt årstal og dagnr på året");
            //Console.WriteLine("18. Hent dagnr fra år 0");
            Console.WriteLine("19. Hent det Julianske dags nummer");
            Console.WriteLine("20. Hent dag på ugen");
            Console.Write("\nDit valg: ");
        }

        private int ChooseAction()
        {
            int choice = -1;
            try
            {
                choice = Int32.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                choice = -1;
                return choice;
            }
            return choice;
        }

        private void CreateDate()
        {
            Console.Clear();
            Console.WriteLine("Opret en dato");
            Console.Write("År: ");
            string aar = Console.ReadLine();

            Console.Write("\nMåned: ");
            string maaned = Console.ReadLine();
            if (maaned.Length != 2)
                maaned = 0 + maaned;

            Console.Write("\nDag: ");
            string dag = Console.ReadLine();
            if (dag.Length != 2)
                dag = 0 + dag;

            Dato dato = new Dato(aar, maaned, dag);
            this.dato = dato;
        }

        private void SetAar()
        {
            Console.Clear();
            Console.Write("Skift år til: ");
            int aar = int.Parse(Console.ReadLine());
            dato.SetAar(aar);
        }

        private void SetMaaned()
        {
            Console.Clear();
            Console.Write("Skift måned til: ");
            int maaned = int.Parse(Console.ReadLine());
            dato.SetMaaned(maaned);
        }

        private void SetDag()
        {
            Console.Clear();
            Console.Write("Skift dag til: ");
            int dag = int.Parse(Console.ReadLine());
            dato.SetDag(dag);
        }

        private int QueryAmountOfDays()
        {
            int days;
            Console.Clear();
            Console.Write("Hvor mange dage vil du flytte datoen? (negativt tal for at gå antal dage tilbage)");
            days = int.Parse(Console.ReadLine());
            return days;
        }

        private int QueryYear()
        {
            Console.Clear();
            Console.Write("Vælg et år: ");
            int year = int.Parse(Console.ReadLine());
            return year;
        }

        private int QueryDaynr()
        {
            Console.Clear();
            Console.Write("Vælg et dagnr på året: ");
            int daynr = int.Parse(Console.ReadLine());
            return daynr;
        }
    }
}
