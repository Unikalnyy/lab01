using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //    Console.WriteLine("Podaj imię: ");
            //    string imie = Console.ReadLine();

            //    Console.WriteLine("Podaj nazwisko: ");
            //    string nazwisko = Console.ReadLine();

            //    Console.WriteLine("Witaj, " + imie + " " + nazwisko);

            //    Console.WriteLine("Witaj {0} {1}. Czy Pan {0} w rzeczywistości nazywa się {1}" ,imie,nazwisko);

            Console.WriteLine("System do sprawdzania ile lat zostało do Emerytury.");
            Console.WriteLine("Podaj swój wiek: ");
            int wiek = Convert.ToInt32(Console.ReadLine());

            if(wiek < 67)
            {
                Console.WriteLine("Lata pozostałe do emerytury: {0}", 67 - wiek);
            }
            else
            {
                Console.WriteLine("Gratulacje! Możesz cieszyć się emeryturą!");
            }
        }
    }
}
