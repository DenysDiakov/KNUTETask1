using System;
using System.ComponentModel.DataAnnotations;

namespace KNUTETask
{
	public class User
	{
		[Required(ErrorMessage = "Укажите логин")]
		[MinLength(5, ErrorMessage = "Минимальная длина имени должна быть не менее 5 символов")]
		public string Login { get; set; }

		[Required(ErrorMessage = "Укажите пароль")]
		public string Password { get; set; }

		public bool HasCat { get; set; }

		private DateTime _birthDate;
		public DateTime BirthDate
		{
			get { return _birthDate.Date; }
			set { _birthDate = value; }
		}

		public User(string login, string password) : this(login, password, false, DateTime.MinValue)
		{
		}

		public User(string login, string password, bool hasCat, DateTime date)
		{
			Login = login;
			Password = password;
			HasCat = hasCat;
			BirthDate = date;
		}
	}
}
