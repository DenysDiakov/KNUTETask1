using System;
using System.Collections.Generic;

namespace KNUTETask
{
	public static class UsersRepository
	{
		public static Lazy<List<User>> Users { get; private set; } = new Lazy<List<User>>(
			() => new List<User>
			{
				new User("admin", "qwerty", "Denys", hasCat: true, new DateTime(1999, 6, 21)),
				new User("len4ik", "glek221", "Lenya", hasCat: true, new DateTime(1999, 11, 21)),
				new User("Kitty233", "12345", "Masha", hasCat: false, new DateTime(2001, 1, 15)),
				new User("yourFriend", "VeryStrongPassword111", "Serhey", hasCat: false, new DateTime(1995, 4, 14)),
				new User("Oldman", "5427", "Valera", hasCat: true, new DateTime(1967, 9, 24))
			});

		public static void AddUser(User user)
		{
			Users.Value.Add(user);
		}

		public static bool UserExists(string login)
		{
			if (string.IsNullOrEmpty(login))
				throw new ArgumentNullException(nameof(login));

			return Users.Value.Exists(x => x.Login.Equals(login));

		}

		public static User FindByLogin(string login)
		{
			User user = Users.Value.Find(x => x.Login.Equals(login));
			return user;
		}
	}
}
