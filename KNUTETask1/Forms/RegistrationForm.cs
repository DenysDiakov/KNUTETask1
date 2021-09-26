using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Windows.Forms;

namespace KNUTETask
{
	public partial class RegistrationForm : Form
	{
		public RegistrationForm()
		{
			InitializeComponent();
		}

		private void RegistrationButton_Click(object sender, EventArgs e)
		{
			string login = LoginTextbox.Text;
			var user = new User(
					login,
					PasswordTextbox.Text,
					catCheckBox.Checked,
					dateTimePicker.Value);
			var context = new ValidationContext(user, null, null);
			var errors = new List<ValidationResult>();
			if (!Validator.TryValidateObject(user, context, errors, true))
			{
				foreach (var error in errors)
				{
					MessageBox.Show(error.ErrorMessage, "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}
			}
			if (UsersRepository.UserExists(login))
			{
				MessageBox.Show($"Пользователь с логином {login} уже зарегистрирован в системе!");
				return;
			}
			UsersRepository.AddUser(user);
			FormManager.ShowForm(new MainForm(user));
		}

		private void AlreadyHasAccountButton_Click(object sender, EventArgs e)
		{
			FormManager.ShowForm(new LoginForm());
		}
	}
}

