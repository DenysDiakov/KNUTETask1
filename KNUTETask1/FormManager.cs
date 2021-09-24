using System.Windows.Forms;

namespace KNUTETask1
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
