
namespace KNUTETask
{
	partial class MainForm
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
			this.greetingsLabel = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// greetingsLabel
			// 
			this.greetingsLabel.AutoSize = true;
			this.greetingsLabel.Location = new System.Drawing.Point(11, 38);
			this.greetingsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.greetingsLabel.Name = "greetingsLabel";
			this.greetingsLabel.Size = new System.Drawing.Size(29, 13);
			this.greetingsLabel.TabIndex = 0;
			this.greetingsLabel.Text = "Hey!";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(82, 325);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(114, 38);
			this.button1.TabIndex = 1;
			this.button1.Text = "Выйти из аккаунта";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(289, 375);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.greetingsLabel);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.MaximumSize = new System.Drawing.Size(305, 414);
			this.MinimumSize = new System.Drawing.Size(305, 414);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Личный кабинет";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label greetingsLabel;
		private System.Windows.Forms.Button button1;
	}
}