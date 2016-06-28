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
    }
}
