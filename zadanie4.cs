using System;

class Program
{
    static void Main()
    {
        string imie = "Adrian";
        string nazwisko = "LaśNiak";
        string wiekString = "67";
        string email = "adrianLesniarski@yahoooooo.com";
        string telefon = "676767676";

        bool imieOk = imie != "";
        bool nazwiskoOk = nazwisko != "";
        bool wiekOk = int.TryParse(wiekString, out int wiek) && wiek >= 18 && wiek <= 100;
        bool emailOk = email.Contains("@");
        bool telefonOk = telefon.Length == 9;

        Console.WriteLine("Imię: " + (imieOk ? "OK" : "Błąd"));
        Console.WriteLine("Nazwisko: " + (nazwiskoOk ? "OK" : "Błąd"));
        Console.WriteLine("Wiek: " + (wiekOk ? "OK" : "Błąd"));
        Console.WriteLine("Email: " + (emailOk ? "OK" : "Błąd"));
        Console.WriteLine("Numer telefonu: " + (telefonOk ? "OK" : "Błąd"));

        if (imieOk && nazwiskoOk && wiekOk && emailOk && telefonOk)
            Console.WriteLine("Wszystkie dane są poprawne. Rejestracja zakończona sukcesem!");
        else
            Console.WriteLine("Formularz zawiera błędy. Popraw dane i spróbuj ponownie.");
    }
}
