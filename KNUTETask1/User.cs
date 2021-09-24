using System;

namespace KNUTETask
{
	public class User
	{
		public string Login { get; set; }

		public string Name { get; set; }

		public string Password { get; set; }

		public bool HasCat { get; set; }

		private DateTime _birthDate;
		public DateTime BirthDate
		{
			get { return _birthDate.Date; }
			set { _birthDate = value; }
		}

		public User(string login, string password) : this(login, password, null, false, DateTime.MinValue)
		{
		}

		public User(string login, string password, string name, bool hasCat, DateTime date)
		{
			Login = login;
			Name = name;
			Password = password;
			HasCat = hasCat;
			BirthDate = date;
		}
	}
}
