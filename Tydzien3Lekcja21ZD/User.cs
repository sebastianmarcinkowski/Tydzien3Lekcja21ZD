using System;

namespace Tydzien3Lekcja21ZD
{
    internal class User
    {
        private string _name;
        private DateTime _dateOfBirth;
        private string _cityOfBirth;

        public User(string name, int dayOfBirth, int monthOfBirth, int yearOfBirth, string cityOfBirth)
        {
            _name = name;
            _dateOfBirth = new DateTime(yearOfBirth, monthOfBirth, dayOfBirth);
            _cityOfBirth = cityOfBirth;
        }
        public int GetAge()
        {
            DateTime today = DateTime.Now;
            var age = today.Year - _dateOfBirth.Year;
            if (today.DayOfYear < _dateOfBirth.DayOfYear) age -= 1;
            if (age < 0) age = 0;
            return age;
        }
        public void GetInfo()
        {
            Console.WriteLine($"Cześć {_name}, urodziłeś się w {_cityOfBirth} i masz {GetAge()} lat.");
        }
        public static int GetDayInput()
        {
            while (true)
            {
                try
                {
                    Console.Write("Podaj dzień urodzenia: ");

                    if (!(int.TryParse(Console.ReadLine(), out int input)))
                        throw new Exception("Nieprawidłowa wartość!");
                    else
                        if (input < 1 || input > 31) throw new Exception("Nieprawidłowa wartość!");

                    Console.Clear();
                    return input;
                }
                catch (Exception ex)
                {
                    Console.Clear();
                    Console.WriteLine(ex.Message);
                }
            }
        }
        public static int GetMonthInput()
        {
            while (true)
            {
                try
                {
                    Console.Write("Podaj miesiąc urodzenia [od 1 do 12]: ");

                    if (!(int.TryParse(Console.ReadLine(), out int input)))
                        throw new Exception("Nieprawidłowa wartość!");
                    else
                        if (input < 1 || input > 12) throw new Exception("Nieprawidłowa wartość!");

                    Console.Clear();
                    return input;
                }
                catch (Exception ex)
                {
                    Console.Clear();
                    Console.WriteLine(ex.Message);
                }
            }
        }
        public static int GetYearInput()
        {
            while (true)
            {
                try
                {
                    Console.Write("Podaj rok urodzenia: ");

                    if (!(int.TryParse(Console.ReadLine(), out int input)))
                        throw new Exception("Nieprawidłowa wartość!");
                    else
                        if (input < 1 || input > DateTime.Now.Year) throw new Exception("Nieprawidłowa wartość!");

                    Console.Clear();
                    return input;
                }
                catch (Exception ex)
                {
                    Console.Clear();
                    Console.WriteLine(ex.Message);
                }
            }
        }
        public static string GetString(string text)
        {
            Console.Write(text);
            string output = Console.ReadLine();
            Console.Clear();
            return output;
        }
    }
}
