using System;
using System.IO;

namespace Proiect_Buget
{
    class Program
    { 
        static Venit v = new Venit();
        static Cheltuiala c = new Cheltuiala();
        static Economie e = new Economie();



        static void Main(string[] args)
        {
          
            bool arataMeniu = true;
            while (arataMeniu)
            {
                arataMeniu= Meniu();
            }
            
        }

        private static bool Meniu()
        {
            

            string input;
            Console.Clear();
            Console.WriteLine("Alege o optiune:");
            Console.WriteLine("1) Itroduceti venit");
            Console.WriteLine("2) Afisati venit");
            Console.WriteLine("3) Itroduceti cheltuieli");
            Console.WriteLine("4) Afisati cheltuieli");
            Console.WriteLine("5) Itroduceti economii");
            Console.WriteLine("6) Afisati economii");
            Console.WriteLine("7) Afisati fonduri disponibile");
            Console.WriteLine("9) Iesi");
            Console.Write("\r\nSelecteaza o optiune: ");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("Introduceti suma venituri:");
                    input = Console.ReadLine();
                    v.SetVenit(input);

                    Console.WriteLine("Introduceti sursa:");
                    input = Console.ReadLine();
                    v.SetSursa(input);

                    return true;
                case "2":
                    Console.WriteLine(v.ConversieLaSir());
                    Console.ReadKey();
                    return true;
                case "3":
                    Console.WriteLine("Introduceti suma cheltuieli: ");
                    input = Console.ReadLine();
                    c.SetCheltuiala(input);
                   
                    Console.WriteLine("Introduceti destinatia:");
                    input = Console.ReadLine();
                    c.SetDestinatie(input);
                    return true;
                case "4":
                    Console.WriteLine(c.ConversieLaSir());
                    Console.ReadKey();
                    return true;
                case "5":
                    Console.WriteLine("Introduceti suma economii:");
                    input = Console.ReadLine();
                    e.SetEconomie(input);

                    Console.WriteLine("Introduceti scopul");
                    input = Console.ReadLine();
                    e.SetScop(input);
                    return true;
                case "6":
                    Console.WriteLine(e.ConversieLaSir());
                    Console.ReadKey();
                    return true;
                case "7":
                    int venituri = v.GetVenit();
                    int economii = e.GetEconomie();
                    int cheltuieli = c.GetCheltuiala();
                    Console.WriteLine("Suma de bani disponibila este " + Buget.GetSumaDisponibila(venituri, economii, cheltuieli));
                    Console.ReadKey();
                    return true;
                case "9":
                    return false;
                default:
                    return true;
            }
    
        }
    }
}