/*
 * Created by SharpDevelop.
 * User: neuhold.benedikt
 * Date: 11.10.2017
 * Time: 11:49
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Login
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button m_btnLogin;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox m_tbUser;
		private System.Windows.Forms.TextBox m_tbPassword;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.m_btnLogin = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.m_tbUser = new System.Windows.Forms.TextBox();
			this.m_tbPassword = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// m_btnLogin
			// 
			this.m_btnLogin.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.m_btnLogin.Location = new System.Drawing.Point(12, 200);
			this.m_btnLogin.Name = "m_btnLogin";
			this.m_btnLogin.Size = new System.Drawing.Size(390, 51);
			this.m_btnLogin.TabIndex = 0;
			this.m_btnLogin.Text = "Anmelden";
			this.m_btnLogin.UseVisualStyleBackColor = true;
			this.m_btnLogin.Click += new System.EventHandler(this.M_btnLoginClick);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(390, 44);
			this.label1.TabIndex = 1;
			this.label1.Text = "Login";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(12, 118);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Passwort";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(12, 65);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 3;
			this.label3.Text = "Benutzer:";
			// 
			// m_tbUser
			// 
			this.m_tbUser.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.m_tbUser.Location = new System.Drawing.Point(134, 62);
			this.m_tbUser.Name = "m_tbUser";
			this.m_tbUser.Size = new System.Drawing.Size(232, 32);
			this.m_tbUser.TabIndex = 4;
			// 
			// m_tbPassword
			// 
			this.m_tbPassword.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.m_tbPassword.Location = new System.Drawing.Point(134, 115);
			this.m_tbPassword.Name = "m_tbPassword";
			this.m_tbPassword.Size = new System.Drawing.Size(232, 32);
			this.m_tbPassword.TabIndex = 5;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(414, 287);
			this.Controls.Add(this.m_tbPassword);
			this.Controls.Add(this.m_tbUser);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.m_btnLogin);
			this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "MainForm";
			this.Text = "Login";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
