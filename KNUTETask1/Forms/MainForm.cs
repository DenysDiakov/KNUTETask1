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
			greetingsLabel.Text = $"{greetingsLabel.Text}, {CurrentUser.Name}";
		}
	}
}
