
namespace KNUTETask
{
	partial class RegistrationForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.LoginTextbox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.PasswordTextbox = new System.Windows.Forms.TextBox();
			this.passLabel = new System.Windows.Forms.Label();
			this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.label3 = new System.Windows.Forms.Label();
			this.catCheckBox = new System.Windows.Forms.CheckBox();
			this.registrationButton = new System.Windows.Forms.Button();
			this.AlreadyHasAccountButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// LoginTextbox
			// 
			this.LoginTextbox.Location = new System.Drawing.Point(106, 22);
			this.LoginTextbox.Margin = new System.Windows.Forms.Padding(2);
			this.LoginTextbox.Name = "LoginTextbox";
			this.LoginTextbox.Size = new System.Drawing.Size(76, 20);
			this.LoginTextbox.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(19, 22);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(38, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Логин";
			// 
			// PasswordTextbox
			// 
			this.PasswordTextbox.Location = new System.Drawing.Point(106, 55);
			this.PasswordTextbox.Margin = new System.Windows.Forms.Padding(2);
			this.PasswordTextbox.Name = "PasswordTextbox";
			this.PasswordTextbox.Size = new System.Drawing.Size(76, 20);
			this.PasswordTextbox.TabIndex = 2;
			// 
			// passLabel
			// 
			this.passLabel.AutoSize = true;
			this.passLabel.Location = new System.Drawing.Point(19, 55);
			this.passLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.passLabel.Name = "passLabel";
			this.passLabel.Size = new System.Drawing.Size(45, 13);
			this.passLabel.TabIndex = 3;
			this.passLabel.Text = "Пароль";
			// 
			// dateTimePicker
			// 
			this.dateTimePicker.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.dateTimePicker.Location = new System.Drawing.Point(106, 95);
			this.dateTimePicker.Margin = new System.Windows.Forms.Padding(2);
			this.dateTimePicker.Name = "dateTimePicker";
			this.dateTimePicker.Size = new System.Drawing.Size(151, 20);
			this.dateTimePicker.TabIndex = 6;
			this.dateTimePicker.Value = new System.DateTime(2021, 9, 24, 0, 0, 0, 0);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(19, 95);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(86, 13);
			this.label3.TabIndex = 7;
			this.label3.Text = "Дата рождения";
			// 
			// catCheckBox
			// 
			this.catCheckBox.AutoSize = true;
			this.catCheckBox.Location = new System.Drawing.Point(108, 129);
			this.catCheckBox.Margin = new System.Windows.Forms.Padding(2);
			this.catCheckBox.Name = "catCheckBox";
			this.catCheckBox.Size = new System.Drawing.Size(107, 17);
			this.catCheckBox.TabIndex = 8;
			this.catCheckBox.Text = "У вас есть кот?";
			this.catCheckBox.UseVisualStyleBackColor = true;
			// 
			// registrationButton
			// 
			this.registrationButton.Location = new System.Drawing.Point(90, 178);
			this.registrationButton.Margin = new System.Windows.Forms.Padding(2);
			this.registrationButton.Name = "registrationButton";
			this.registrationButton.Size = new System.Drawing.Size(125, 27);
			this.registrationButton.TabIndex = 9;
			this.registrationButton.Text = "Зарегистрироваться";
			this.registrationButton.UseVisualStyleBackColor = true;
			this.registrationButton.Click += new System.EventHandler(this.RegistrationButton_Click);
			// 
			// AlreadyHasAccountButton
			// 
			this.AlreadyHasAccountButton.Location = new System.Drawing.Point(124, 326);
			this.AlreadyHasAccountButton.Margin = new System.Windows.Forms.Padding(2);
			this.AlreadyHasAccountButton.Name = "AlreadyHasAccountButton";
			this.AlreadyHasAccountButton.Size = new System.Drawing.Size(148, 24);
			this.AlreadyHasAccountButton.TabIndex = 10;
			this.AlreadyHasAccountButton.Text = "Уже зарегистрированы?";
			this.AlreadyHasAccountButton.UseVisualStyleBackColor = true;
			this.AlreadyHasAccountButton.Click += new System.EventHandler(this.AlreadyHasAccountButton_Click);
			// 
			// RegistrationForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.ClientSize = new System.Drawing.Size(288, 375);
			this.Controls.Add(this.AlreadyHasAccountButton);
			this.Controls.Add(this.registrationButton);
			this.Controls.Add(this.catCheckBox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.dateTimePicker);
			this.Controls.Add(this.passLabel);
			this.Controls.Add(this.PasswordTextbox);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.LoginTextbox);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.MaximumSize = new System.Drawing.Size(304, 414);
			this.MinimumSize = new System.Drawing.Size(304, 414);
			this.Name = "RegistrationForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Окно регистрации";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox LoginTextbox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox PasswordTextbox;
		private System.Windows.Forms.Label passLabel;
		private System.Windows.Forms.DateTimePicker dateTimePicker;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.CheckBox catCheckBox;
		private System.Windows.Forms.Button registrationButton;
		private System.Windows.Forms.Button AlreadyHasAccountButton;
	}
}

