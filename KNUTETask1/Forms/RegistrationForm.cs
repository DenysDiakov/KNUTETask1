using KNUTETask1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace KNUTETask
{
	public partial class RegistrationForm : Form
	{
		public RegistrationForm()
		{
			InitializeComponent();
		}

		private void RegistrationButton_Click(object sender, System.EventArgs e)
		{
			if (ValidateChildren(ValidationConstraints.Enabled))
			{
				string login = LoginTextbox.Text;
				if (UsersRepository.UserExists(login))
				{
					MessageBox.Show($"Пользователь с логином {login} уже зарегистрирован в системе!");
					return;
				}
				var user = new User(
					login,
					PasswordTextbox.Text,
					NameTextbox.Text,
					catCheckBox.Checked,
					dateTimePicker.Value);
				UsersRepository.AddUser(user);
				FormManager.ShowForm(new MainForm(user));
				//MainForm mainForm = new MainForm(user);
				//mainForm.Show();
				//this.Hide();
			}
		}

		private void AlreadyHasAccountButton_Click(object sender, System.EventArgs e)
		{
			FormManager.ShowForm(new LoginForm());
		}

		private void LoginTextbox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
		{
			var checks = new ValidationOptions(LoginTextbox, errorProvider, e);
			var validator = new Validator()
			{
				Args = new Dictionary<Validator.CustomAction, object>()
				{
					{ checks.IsNullOrEmpty , null }
				}
			};
			validator.Validate();
		}

		private void PasswordTextbox_Validating(object sender, CancelEventArgs e)
		{
			var checks = new ValidationOptions(PasswordTextbox, errorProvider, e);
			var validator = new Validator()
			{
				Args = new Dictionary<Validator.CustomAction, object>()
				{
					{ checks.IsNullOrEmpty , null },
					{ checks.PasswordLowerThen, 4}
				}
			};
			validator.Validate();
		}

		private void NameTextbox_Validating(object sender, CancelEventArgs e)
		{
			var checks = new ValidationOptions(NameTextbox, errorProvider, e);
			var validator = new Validator()
			{
				Args = new Dictionary<Validator.CustomAction, object>()
				{
					{ checks.IsNullOrEmpty , null }
				}
			};
			validator.Validate();
		}
	}


}

//public class Validator
//{
//	public Control Control { get; private set; }

//	public ErrorProvider ErrorProvider { get; private set; }

//	public Validator(Control control, ErrorProvider errorProvider)
//	{
//		Control = control;
//		ErrorProvider = errorProvider;
//	}

//	void test()
//	{
//		var dic = new Dictionary<string, CancelEventArgs>()
//		{
//			{ "Не делай єто ебать", new CancelEventArgs() }
//		};
//		ValidateAll(dic, IsNullOrEmpty);
//	}

//	public void IsNullOrEmpty(string message, CancelEventArgs e)
//	{
//		if (string.IsNullOrEmpty(Control.Text))
//		{
//			e.Cancel = true;
//			Control.Focus();
//			ErrorProvider.SetError(Control, message);
//		}
//	}

//	public void FieldTooMuch()
//	{

//	}

//	public void Validate(Dictionary<Dictionary<string, CancelEventArgs>, Action<string, CancelEventArgs>> checks) 
//	{
//		foreach (var check in checks)
//		{
//			validate(check.Key, check.Value);
//		}
//	}

//	private void validate(Dictionary<string, CancelEventArgs> errorMessages, Action<string, CancelEventArgs> check)
//	{
//		foreach (var message in errorMessages)
//		{
//			string messageText = message.Key;
//			var cancelEvent = message.Value;
//			check.Invoke(messageText, cancelEvent);
//		}
//	}
//}

public class Validator
{
	public delegate void CustomAction(object value = null);

	public delegate void CustomActionTEST(int value = 2);


	//public Dictionary<Dictionary<object, string>, List<CustomAction>> Args { get; private set; }

	public Dictionary<CustomAction, object> Args { get; set; }

	public Control Control { get; private set; }

	public ErrorProvider ErrorProvider { get; private set; }

	public CancelEventArgs CancelEventArg { get; private set; }

	public Validator(/*Control control, ErrorProvider errorProvider, CancelEventArgs cancelEventArgs*/)
	{
		//Control = control;
		//ErrorProvider = errorProvider;
		//CancelEventArg = cancelEventArgs;
	}

	public void Validate()
	{
		foreach (var arg in Args)
		{
			var parameter = arg.Value;
			arg.Key.Invoke(parameter);
		}
	}
}

public class ValidationOptions
{
	public Control Control { get; private set; }

	public ErrorProvider ErrorProvider { get; private set; }

	public CancelEventArgs CancelEventArg { get; private set; }

	public ValidationOptions(Control control, ErrorProvider errorProvider, CancelEventArgs cancelEventArgs)
	{
		Control = control;
		ErrorProvider = errorProvider;
		CancelEventArg = cancelEventArgs;
	}

	// TO DO Убрать костыль с передачей объекта заглушки просто чтобы не ругался делегат
	public void IsNullOrEmpty(object value = null)
	{
		if (string.IsNullOrEmpty(Control.Text))
		{
			CancelEventArg.Cancel = true;
			Control.Focus();
			ErrorProvider.SetError(Control, "Поле не должно быть пустым!");
		}
	}

	public void PasswordLowerThen(object value)
	{
		int passwordCountMinimumAllowableValue = (int)value;
		if (Control.Text.Length < passwordCountMinimumAllowableValue)
		{
			CancelEventArg.Cancel = true;
			Control.Focus();
			ErrorProvider.SetError(Control, $"Пароль не должен быть меньше, чем {passwordCountMinimumAllowableValue}");
		}
	}
}

