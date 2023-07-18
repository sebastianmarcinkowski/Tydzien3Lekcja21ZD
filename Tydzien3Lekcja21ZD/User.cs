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
		public string GetInfo()
		{
			return $"Cześć {_name}, urodziłeś się w {_cityOfBirth} i masz {GetAge()} lat.";
		}
	}
}
