using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Die Hauptfunktion "Main":
            // Hier startet das eigentliche Programm.
      
                // Begrüßung
                Console.WriteLine("Hallo Spieleprogrammierer!");
                Console.Write("Gib eine Zahl ein! ");

                // Zahl einlesen
                int zahl = int.Parse(Console.In.ReadLine());

                // Quadrat der Zahl ausgeben.
                Console.WriteLine("Das Quadrat von {0} ist: {1}", zahl, zahl * zahl);

                try
                {
                    // Fakultät der Zahl ausgeben.
                    Console.WriteLine("Die Fakultät von {0} ist: {1}", zahl, fakultät(zahl));
                }
                catch (Exception e)
                {
                    // Ein Fehler ist aufgetreten. Gib die Fehlermeldung aus.
                    Console.WriteLine("Fehler: {0}", e);
                }
            Console.ReadKey();
        }

        // Die folgende Funktion berechnet n!, die Fakultät von n.
        private static int fakultät(int n)
        {
            // Signalisiere einen Fehler, wenn n negativ ist.
            if (n < 0) throw new ArgumentOutOfRangeException("n", "Darf nicht negativ sein!");

            if (n == 0) return 1;               // 0! = 1
            else return n * fakultät(n - 1);    // Rekursion: n! = n * (n - 1)!
        }
        
    }
}

