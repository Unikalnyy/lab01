using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloConsoleAppBatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program na powitanie! Wykonał: Michał P.");
            Console.WriteLine("");
            string imie;
            string nazwisko;
            int wiek;

            if (args.Length == 3)
            {
                imie = args[0];
                nazwisko = args[1];
                wiek = Convert.ToInt32(args[2]);

                Console.WriteLine("Witaj {0} {1}", imie, nazwisko);
                Console.WriteLine("System do sprawdzania ile lat zostało do Emerytury.");
                if (wiek < 0)
                {
                    Console.WriteLine("Błedne dane!");
                    Console.ReadKey();
                }
                else if (wiek < 67)
                {
                    Console.WriteLine("Lata pozostałe do emerytury: {0}", 67 - wiek);
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Gratulacje! Możesz cieszyć się emeryturą!");
                    Console.ReadKey();
                }
            }
            else if (args.Length == 2) // Przypisując pierwszyi drugi parametr traktuje go jako IMIĘ i NAZWISKO, a wiek wprowadzamy sami.
            {
                imie = args[0];
                nazwisko = args[1];
                Console.WriteLine("Witaj {0} {1}. Czy Pan {0} w rzeczywistości nazywa się {1}", imie, nazwisko);

                Console.WriteLine("");

                Console.WriteLine("System do sprawdzania ile lat zostało do Emerytury.");
                Console.WriteLine("Podaj swój wiek: ");
                wiek = Convert.ToInt32(Console.ReadLine());
                if (wiek < 0)
                {
                    Console.WriteLine("Błedne dane!");
                    Console.ReadKey();
                }
                else if (wiek < 67)
                {
                    Console.WriteLine("Lata pozostałe do emerytury: {0}", 67 - wiek);
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Gratulacje! Możesz cieszyć się emeryturą!");
                    Console.ReadKey();
                }
            }
            else if (args.Length == 1) // Przypisując pierwszy parametr traktuje go jako IMIĘ, a pozostałe wprowadzamy sami.
            {
                imie = args[0];

                Console.WriteLine("Podaj nazwisko: ");
                nazwisko = Console.ReadLine();
                Console.WriteLine("Witaj {0} {1}. Czy Pan {0} w rzeczywistości nazywa się {1}", imie, nazwisko);

                Console.WriteLine("");

                Console.WriteLine("System do sprawdzania ile lat zostało do Emerytury.");
                Console.WriteLine("Podaj swój wiek: ");
                wiek = Convert.ToInt32(Console.ReadLine());
                if (wiek < 0)
                {
                    Console.WriteLine("Błedne dane!");
                    Console.ReadKey();
                }
                else if (wiek < 67)
                {
                    Console.WriteLine("Lata pozostałe do emerytury: {0}", 67 - wiek);
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Gratulacje! Możesz cieszyć się emeryturą!");
                    Console.ReadKey();
                }
            }
            else  // Trzeba samemu podać wszystkie zmienne
            {
                Console.WriteLine("Podaj imię: ");
                imie = Console.ReadLine();

                Console.WriteLine("Podaj nazwisko: ");
                nazwisko = Console.ReadLine();
                Console.WriteLine("Witaj {0} {1}. Czy Pan {0} w rzeczywistości nazywa się {1}", imie, nazwisko);

                Console.WriteLine("");

                Console.WriteLine("System do sprawdzania ile lat zostało do Emerytury.");
                Console.WriteLine("Podaj swój wiek: ");
                wiek = Convert.ToInt32(Console.ReadLine());
                if (wiek < 0)
                {
                    Console.WriteLine("Błedne dane!");
                    Console.ReadKey();
                }
                else if (wiek < 67)
                {
                    Console.WriteLine("Lata pozostałe do emerytury: {0}", 67 - wiek);
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Gratulacje! Możesz cieszyć się emeryturą!");
                    Console.ReadKey();
                }
            }
        }
    }
}
