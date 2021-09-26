using System.Windows.Forms;

namespace KNUTETask
{
	public static class FormManager
	{
		public static void ShowForm(Form form)
		{
			Form.ActiveForm.Hide();
			form.Show();
		}
	}
}
