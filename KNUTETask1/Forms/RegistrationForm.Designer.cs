
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
			this.components = new System.ComponentModel.Container();
			this.LoginTextbox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.PasswordTextbox = new System.Windows.Forms.TextBox();
			this.passLabel = new System.Windows.Forms.Label();
			this.NameTextbox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.label3 = new System.Windows.Forms.Label();
			this.catCheckBox = new System.Windows.Forms.CheckBox();
			this.registrationButton = new System.Windows.Forms.Button();
			this.AlreadyHasAccountButton = new System.Windows.Forms.Button();
			this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
			this.SuspendLayout();
			// 
			// LoginTextbox
			// 
			this.LoginTextbox.Location = new System.Drawing.Point(142, 27);
			this.LoginTextbox.Name = "LoginTextbox";
			this.LoginTextbox.Size = new System.Drawing.Size(100, 22);
			this.LoginTextbox.TabIndex = 0;
			this.LoginTextbox.Validating += new System.ComponentModel.CancelEventHandler(this.LoginTextbox_Validating);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(25, 27);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(47, 17);
			this.label1.TabIndex = 1;
			this.label1.Text = "Логин";
			// 
			// PasswordTextbox
			// 
			this.PasswordTextbox.Location = new System.Drawing.Point(142, 68);
			this.PasswordTextbox.Name = "PasswordTextbox";
			this.PasswordTextbox.Size = new System.Drawing.Size(100, 22);
			this.PasswordTextbox.TabIndex = 2;
			this.PasswordTextbox.Validating += new System.ComponentModel.CancelEventHandler(this.PasswordTextbox_Validating);
			// 
			// passLabel
			// 
			this.passLabel.AutoSize = true;
			this.passLabel.Location = new System.Drawing.Point(25, 68);
			this.passLabel.Name = "passLabel";
			this.passLabel.Size = new System.Drawing.Size(57, 17);
			this.passLabel.TabIndex = 3;
			this.passLabel.Text = "Пароль";
			// 
			// NameTextbox
			// 
			this.NameTextbox.Location = new System.Drawing.Point(142, 108);
			this.NameTextbox.Name = "NameTextbox";
			this.NameTextbox.Size = new System.Drawing.Size(100, 22);
			this.NameTextbox.TabIndex = 4;
			this.NameTextbox.Validating += new System.ComponentModel.CancelEventHandler(this.NameTextbox_Validating);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(25, 108);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(35, 17);
			this.label2.TabIndex = 5;
			this.label2.Text = "Имя";
			// 
			// dateTimePicker
			// 
			this.dateTimePicker.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.dateTimePicker.Location = new System.Drawing.Point(142, 151);
			this.dateTimePicker.Name = "dateTimePicker";
			this.dateTimePicker.Size = new System.Drawing.Size(200, 22);
			this.dateTimePicker.TabIndex = 6;
			this.dateTimePicker.Value = new System.DateTime(2021, 9, 24, 0, 0, 0, 0);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(25, 151);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(111, 17);
			this.label3.TabIndex = 7;
			this.label3.Text = "Дата рождения";
			// 
			// catCheckBox
			// 
			this.catCheckBox.AutoSize = true;
			this.catCheckBox.Location = new System.Drawing.Point(144, 193);
			this.catCheckBox.Name = "catCheckBox";
			this.catCheckBox.Size = new System.Drawing.Size(132, 21);
			this.catCheckBox.TabIndex = 8;
			this.catCheckBox.Text = "У вас есть кот?";
			this.catCheckBox.UseVisualStyleBackColor = true;
			// 
			// registrationButton
			// 
			this.registrationButton.Location = new System.Drawing.Point(109, 243);
			this.registrationButton.Name = "registrationButton";
			this.registrationButton.Size = new System.Drawing.Size(167, 33);
			this.registrationButton.TabIndex = 9;
			this.registrationButton.Text = "Зарегистрироваться";
			this.registrationButton.UseVisualStyleBackColor = true;
			this.registrationButton.Click += new System.EventHandler(this.RegistrationButton_Click);
			// 
			// AlreadyHasAccountButton
			// 
			this.AlreadyHasAccountButton.Location = new System.Drawing.Point(165, 401);
			this.AlreadyHasAccountButton.Name = "AlreadyHasAccountButton";
			this.AlreadyHasAccountButton.Size = new System.Drawing.Size(198, 30);
			this.AlreadyHasAccountButton.TabIndex = 10;
			this.AlreadyHasAccountButton.Text = "Уже зарегистрированы?";
			this.AlreadyHasAccountButton.UseVisualStyleBackColor = true;
			this.AlreadyHasAccountButton.Click += new System.EventHandler(this.AlreadyHasAccountButton_Click);
			// 
			// errorProvider
			// 
			this.errorProvider.ContainerControl = this;
			// 
			// RegistrationForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(382, 453);
			this.Controls.Add(this.AlreadyHasAccountButton);
			this.Controls.Add(this.registrationButton);
			this.Controls.Add(this.catCheckBox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.dateTimePicker);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.NameTextbox);
			this.Controls.Add(this.passLabel);
			this.Controls.Add(this.PasswordTextbox);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.LoginTextbox);
			this.MaximumSize = new System.Drawing.Size(400, 500);
			this.MinimumSize = new System.Drawing.Size(400, 500);
			this.Name = "RegistrationForm";
			this.Text = "Окно регистрации";
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox LoginTextbox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox PasswordTextbox;
		private System.Windows.Forms.Label passLabel;
		private System.Windows.Forms.TextBox NameTextbox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DateTimePicker dateTimePicker;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.CheckBox catCheckBox;
		private System.Windows.Forms.Button registrationButton;
		private System.Windows.Forms.Button AlreadyHasAccountButton;
		private System.Windows.Forms.ErrorProvider errorProvider;
	}
}

