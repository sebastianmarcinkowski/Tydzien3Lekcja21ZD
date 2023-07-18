using System;

namespace Tydzien3Lekcja21ZD
{
	internal class Program
	{
		static void Main(string[] args)
		{
			try
			{
				var name = GetString("Podaj imię: ");

				var dayOfBirth = GetDayInput();
				var monthOfBirth = GetMonthInput();
				var yearOfBirth = GetYearInput();

				var cityOfBirth = GetString("Podaj miasto urodzenia: ");

				var user = new User(name, dayOfBirth, monthOfBirth, yearOfBirth, cityOfBirth);

				Console.WriteLine(user.GetInfo());
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
