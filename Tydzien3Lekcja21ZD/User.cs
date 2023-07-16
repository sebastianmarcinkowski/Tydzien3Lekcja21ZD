using System;

namespace Tydzien3Lekcja21ZD
{
	internal class User
	{
		private string _name { get; set; }
		private DateTime _dateOfBirth { get; set; }
		private string _cityOfBirth { get; set; }

		public User(string Name, int DayOfBirth, int MonthOfBirth, int YearOfBirth, string CityOfBirth)
		{
			this._name = Name;
			this._dateOfBirth = new DateTime(YearOfBirth, MonthOfBirth, DayOfBirth);
			this._cityOfBirth = CityOfBirth;
		}

		public int GetAge()
		{
			DateTime today = DateTime.Now;
			var age = today.Year - this._dateOfBirth.Year;
			if (today.DayOfYear < this._dateOfBirth.DayOfYear) age -= 1;
			if (age < 0) age = 0;
			return age;
		}

		public void GetInfo()
		{
			Console.WriteLine($"Cześć {this._name}, urodziłeś się w {this._cityOfBirth} i masz {this.GetAge()} lat.");
		}

		public static int GetDayInput()
		{
			if (!(int.TryParse(Console.ReadLine(), out int input)))
				throw new Exception("Nieprawidłowa wartość!");
			else
				if (input < 1 || input > 31) throw new Exception("Nieprawidłowa wartość!");
			return input;
		}

		public static int GetMonthInput()
		{
			if (!(int.TryParse(Console.ReadLine(), out int input)))
				throw new Exception("Nieprawidłowa wartość!");
			else
				if (input < 1 || input > 12) throw new Exception("Nieprawidłowa wartość!");
			return input;
		}
		public static int GetYearInput()
		{
			if (!(int.TryParse(Console.ReadLine(), out int input)))
				throw new Exception("Nieprawidłowa wartość!");
			else
				if (input < 1 || input > DateTime.Now.Year) throw new Exception("Nieprawidłowa wartość!");
			return input;
		}
	}

}
