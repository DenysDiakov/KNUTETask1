using System.Text;
using System.Windows.Forms;

namespace KNUTETask
{
	public partial class MainForm : Form
	{
		public User CurrentUser { get; }

		public MainForm(User user)
		{
			CurrentUser = user;
			InitializeComponent();
		}

		private void MainForm_Load(object sender, System.EventArgs e)
		{
			var sb = new StringBuilder();
			sb.AppendLine($"Приветствую, {CurrentUser.Login}");
			sb.AppendLine("Надеюсь вы не забыли, что ваша дата рождения");
			sb.AppendLine(CurrentUser.BirthDate.ToString("D"));
			sb.AppendLine(CurrentUser.HasCat ? "А еще у вас очень милый кот :)" : "И у вас нет кота!");
			greetingsLabel.Text = sb.ToString();
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			FormManager.ShowForm(new LoginForm());
		}
	}
}
