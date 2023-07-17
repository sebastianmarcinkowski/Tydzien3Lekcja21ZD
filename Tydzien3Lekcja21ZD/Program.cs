using System;

namespace Tydzien3Lekcja21ZD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var name = User.GetString("Podaj imię: ");

                var dayOfBirth = User.GetDayInput();
                var monthOfBirth = User.GetMonthInput();
                var yearOfBirth = User.GetYearInput();

                var cityOfBirth = User.GetString("Podaj miasto urodzenia: ");

                var user = new User(name, dayOfBirth, monthOfBirth, yearOfBirth, cityOfBirth);

                user.GetInfo();
            }
            catch (Exception)
            {
                Console.WriteLine("Wystąpił nieoczekiwany błąd, program zostanie zamknięty!");
            }
            finally
            {
                Console.Write("Aby zakończyć program naciśnij dowolny klawisz...");
                Console.ReadKey();
            }
        }
    }
}
