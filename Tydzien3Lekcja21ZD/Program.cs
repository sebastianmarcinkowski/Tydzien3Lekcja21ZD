using System;

namespace Tydzien3Lekcja21ZD
{
	internal class Program
	{
		static void Main(string[] args)
		{
			try
			{
				int dayOfBirth, monthOfBirth, yearOfBirth;
				Console.Write("Podaj imię: ");
				var name = Console.ReadLine();

				while (true)
				{
					try
					{
						Console.Write("Podaj dzień urodzenia: ");
						dayOfBirth = User.GetDayInput();

						break;
					}
					catch (Exception ex)
					{
						Console.WriteLine(ex.Message);
					}
				}

				while (true)
				{
					try
					{
						Console.Write("Podaj miesiąc urodzenia [od 1 do 12]: ");
						monthOfBirth = User.GetMonthInput();

						break;
					}
					catch (Exception ex)
					{
						Console.WriteLine(ex.Message);
					}
				}

				while (true)
				{
					try
					{
						Console.Write("Podaj rok urodzenia: ");
						yearOfBirth = User.GetYearInput();

						break;
					}
					catch (Exception ex)
					{
						Console.WriteLine(ex.Message);
					}
				}

				Console.Write("Podaj miasto urodzenia: ");
				var cityOfBirth = Console.ReadLine();

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
