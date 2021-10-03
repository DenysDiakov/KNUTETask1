using KNUTETask;
using System.Windows;

namespace KNUTETask2
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			if (validate())
			{
				string login = LoginTextBox.Text;
				string password = PasswordTextBox.Text;

				if (UsersRepository.UserExists(login))
				{
					var user = UsersRepository.FindByLogin(login);
					if (password.Equals(user.Password))
					{
						authorize(user);
						return;
					}
					MessageBox.Show("Неверный пароль!");
					return;
				}
				MessageBox.Show($"Пользователь не найден!");
			}
		}

		private void authorize(User user)
		{
			LoginTextBox.Visibility = PasswordTextBox.Visibility = LoginButton.Visibility =
				LoginLabel.Visibility = PasswordLabel.Visibility = Visibility.Hidden;
			HelloLabel.Visibility = Visibility.Visible;
			HelloLabel.Content = "Здравствуйте, " + user.Login;
		}

		private bool validate()
		{
			if (string.IsNullOrEmpty(LoginTextBox.Text))
			{
				MessageBox.Show("Логин не должен быть пустым");
				return false;
			}
			if (string.IsNullOrEmpty(PasswordTextBox.Text))
			{
				MessageBox.Show("Пароль не должен быть пустым");
				return false;
			}
			return true;
		}
	}
}
