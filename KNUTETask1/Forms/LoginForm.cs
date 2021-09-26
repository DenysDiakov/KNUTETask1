using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Windows.Forms;

namespace KNUTETask
{
	public partial class LoginForm : Form
	{
		public LoginForm()
		{
			InitializeComponent();
		}

		private void loginButton_Click(object sender, System.EventArgs e)
		{
			string login = LoginTextbox.Text;
			string password = PasswordTextbox.Text;
			var user = new User(login, password);
			var context = new ValidationContext(user, null, null);
			var errors = new List<ValidationResult>();
			if (!Validator.TryValidateObject(user, context, errors, false))
			{
				foreach (var error in errors)
				{
					MessageBox.Show(error.ErrorMessage, "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}
			}
			if (UsersRepository.UserExists(login))
			{
				user = UsersRepository.FindByLogin(login);

				if (password.Equals(user.Password))
				{
					FormManager.ShowForm(new MainForm(user));
					return;
				}
				MessageBox.Show("Неверный пароль!");
				return;
			}
			MessageBox.Show($"Пользователь не найден!");
		}

		private void NoAccountButton_Click(object sender, System.EventArgs e)
		{
			FormManager.ShowForm(new RegistrationForm());
		}
	}
}
