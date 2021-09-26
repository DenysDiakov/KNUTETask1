
namespace KNUTETask
{
	partial class LoginForm
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
			this.loginLabel = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.PasswordTextbox = new System.Windows.Forms.TextBox();
			this.loginButton = new System.Windows.Forms.Button();
			this.NoAccountButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// LoginTextbox
			// 
			this.LoginTextbox.Location = new System.Drawing.Point(154, 93);
			this.LoginTextbox.Margin = new System.Windows.Forms.Padding(2);
			this.LoginTextbox.Name = "LoginTextbox";
			this.LoginTextbox.Size = new System.Drawing.Size(76, 20);
			this.LoginTextbox.TabIndex = 1;
			// 
			// loginLabel
			// 
			this.loginLabel.AutoSize = true;
			this.loginLabel.Location = new System.Drawing.Point(70, 96);
			this.loginLabel.Name = "loginLabel";
			this.loginLabel.Size = new System.Drawing.Size(38, 13);
			this.loginLabel.TabIndex = 2;
			this.loginLabel.Text = "Логин";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(70, 130);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(45, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Пароль";
			// 
			// PasswordTextbox
			// 
			this.PasswordTextbox.Location = new System.Drawing.Point(154, 130);
			this.PasswordTextbox.Margin = new System.Windows.Forms.Padding(2);
			this.PasswordTextbox.Name = "PasswordTextbox";
			this.PasswordTextbox.Size = new System.Drawing.Size(76, 20);
			this.PasswordTextbox.TabIndex = 4;
			// 
			// loginButton
			// 
			this.loginButton.Location = new System.Drawing.Point(88, 187);
			this.loginButton.Name = "loginButton";
			this.loginButton.Size = new System.Drawing.Size(103, 23);
			this.loginButton.TabIndex = 5;
			this.loginButton.Text = "Авторизоваться";
			this.loginButton.UseVisualStyleBackColor = true;
			this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
			// 
			// NoAccountButton
			// 
			this.NoAccountButton.Location = new System.Drawing.Point(162, 331);
			this.NoAccountButton.Name = "NoAccountButton";
			this.NoAccountButton.Size = new System.Drawing.Size(114, 30);
			this.NoAccountButton.TabIndex = 6;
			this.NoAccountButton.Text = "Нет аккаунта?";
			this.NoAccountButton.UseVisualStyleBackColor = true;
			this.NoAccountButton.Click += new System.EventHandler(this.NoAccountButton_Click);
			// 
			// LoginForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(288, 375);
			this.Controls.Add(this.NoAccountButton);
			this.Controls.Add(this.loginButton);
			this.Controls.Add(this.PasswordTextbox);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.loginLabel);
			this.Controls.Add(this.LoginTextbox);
			this.MaximumSize = new System.Drawing.Size(304, 414);
			this.MinimumSize = new System.Drawing.Size(304, 414);
			this.Name = "LoginForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Авторизоваться";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox LoginTextbox;
		private System.Windows.Forms.Label loginLabel;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox PasswordTextbox;
		private System.Windows.Forms.Button loginButton;
		private System.Windows.Forms.Button NoAccountButton;
	}
}