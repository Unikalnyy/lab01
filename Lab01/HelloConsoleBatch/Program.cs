using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloConsoleBatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program na powitanie.");
            string imie = args[0];
            string nazwisko = args[1];
            Console.WriteLine("Witaj {0} {1}. Czy Pan {0} w rzeczywistości nazywa się {1}", imie, nazwisko);


            Console.WriteLine("System do sprawdzania ile lat zostało do Emerytury.");
            int wiek = Convert.ToInt32(args[2]);
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
