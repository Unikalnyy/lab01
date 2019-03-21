using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace HelloConsoleVBDialog
{
    class Program
    {
        static void Main(string[] args)
        {


            string imie = Interaction.InputBox("Podaj swoje imię", "Wprowadzanie imienia");
            Interaction.MsgBox("Twoje imię to: "+imie, MsgBoxStyle.OkOnly | MsgBoxStyle.Information, "Imię");

            string nazwisko = Interaction.InputBox("Podaj swoje nazwisko", "Wprowadzanie nazwiska");
            Interaction.MsgBox("Twoje nazwisko to: " + nazwisko, MsgBoxStyle.OkOnly | MsgBoxStyle.Information, "Nazwisko");

            Interaction.MsgBox("Czy: " + imie+", W rzeczywistości nazywa się: "+imie+" "+nazwisko+"?", MsgBoxStyle.OkOnly | MsgBoxStyle.Information, "Nazwisko");


            Interaction.MsgBox("System do sprawdzania wieku emerytalnego.", MsgBoxStyle.OkOnly | MsgBoxStyle.Information, "Wiek emerytalny");
            int wiek = Convert.ToInt32(Interaction.InputBox("Podaj swój wiek","Wiek"));
            if (wiek < 0)
            {
                Interaction.InputBox("Błędne dane!");
            }
            else if (wiek < 67)
            {
                Interaction.MsgBox("Lata pozostałe do emerytury: "+ (67 - wiek), MsgBoxStyle.OkOnly | MsgBoxStyle.Information, "Twój wiek emerytalny");
            }
            else
            {
                Interaction.InputBox("Gratulacje! Możesz cieszyć się emeryturą!");
            }
        }
    }
}
