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
    }
}
