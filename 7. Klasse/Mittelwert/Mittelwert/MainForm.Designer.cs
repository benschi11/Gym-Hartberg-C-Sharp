/*
 * Created by SharpDevelop.
 * User: neuhold.benedikt
 * Date: 27.09.2017
 * Time: 11:59
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Mittelwert
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button m_btnMittelwert;
		private System.Windows.Forms.TextBox m_tbEingabe;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label m_lblAusgabe;
		private System.Windows.Forms.RadioButton m_rbBeistrich;
		private System.Windows.Forms.RadioButton m_rbSemikolon;
		private System.Windows.Forms.GroupBox m_grbTrennzeichen;
		
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
			this.m_btnMittelwert = new System.Windows.Forms.Button();
			this.m_tbEingabe = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.m_lblAusgabe = new System.Windows.Forms.Label();
			this.m_rbBeistrich = new System.Windows.Forms.RadioButton();
			this.m_rbSemikolon = new System.Windows.Forms.RadioButton();
			this.m_grbTrennzeichen = new System.Windows.Forms.GroupBox();
			this.m_grbTrennzeichen.SuspendLayout();
			this.SuspendLayout();
			// 
			// m_btnMittelwert
			// 
			this.m_btnMittelwert.Location = new System.Drawing.Point(12, 126);
			this.m_btnMittelwert.Name = "m_btnMittelwert";
			this.m_btnMittelwert.Size = new System.Drawing.Size(559, 50);
			this.m_btnMittelwert.TabIndex = 0;
			this.m_btnMittelwert.Text = "Mittelwert berechnen";
			this.m_btnMittelwert.UseVisualStyleBackColor = true;
			this.m_btnMittelwert.Click += new System.EventHandler(this.M_btnMittelwertClick);
			// 
			// m_tbEingabe
			// 
			this.m_tbEingabe.Location = new System.Drawing.Point(152, 30);
			this.m_tbEingabe.Name = "m_tbEingabe";
			this.m_tbEingabe.Size = new System.Drawing.Size(408, 20);
			this.m_tbEingabe.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(26, 35);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(65, 15);
			this.label1.TabIndex = 2;
			this.label1.Text = "Eingabe:";
			// 
			// m_lblAusgabe
			// 
			this.m_lblAusgabe.Location = new System.Drawing.Point(12, 253);
			this.m_lblAusgabe.Name = "m_lblAusgabe";
			this.m_lblAusgabe.Size = new System.Drawing.Size(558, 53);
			this.m_lblAusgabe.TabIndex = 3;
			// 
			// m_rbBeistrich
			// 
			this.m_rbBeistrich.Location = new System.Drawing.Point(6, 19);
			this.m_rbBeistrich.Name = "m_rbBeistrich";
			this.m_rbBeistrich.Size = new System.Drawing.Size(104, 24);
			this.m_rbBeistrich.TabIndex = 4;
			this.m_rbBeistrich.TabStop = true;
			this.m_rbBeistrich.Text = "Beistrich";
			this.m_rbBeistrich.UseVisualStyleBackColor = true;
			// 
			// m_rbSemikolon
			// 
			this.m_rbSemikolon.Location = new System.Drawing.Point(140, 19);
			this.m_rbSemikolon.Name = "m_rbSemikolon";
			this.m_rbSemikolon.Size = new System.Drawing.Size(104, 24);
			this.m_rbSemikolon.TabIndex = 5;
			this.m_rbSemikolon.TabStop = true;
			this.m_rbSemikolon.Text = "Semikolon";
			this.m_rbSemikolon.UseVisualStyleBackColor = true;
			// 
			// m_grbTrennzeichen
			// 
			this.m_grbTrennzeichen.Controls.Add(this.m_rbBeistrich);
			this.m_grbTrennzeichen.Controls.Add(this.m_rbSemikolon);
			this.m_grbTrennzeichen.Location = new System.Drawing.Point(232, 71);
			this.m_grbTrennzeichen.Name = "m_grbTrennzeichen";
			this.m_grbTrennzeichen.Size = new System.Drawing.Size(250, 49);
			this.m_grbTrennzeichen.TabIndex = 6;
			this.m_grbTrennzeichen.TabStop = false;
			this.m_grbTrennzeichen.Text = "Trennzeichen";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(583, 365);
			this.Controls.Add(this.m_grbTrennzeichen);
			this.Controls.Add(this.m_lblAusgabe);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.m_tbEingabe);
			this.Controls.Add(this.m_btnMittelwert);
			this.Name = "MainForm";
			this.Text = "Mittelwert";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainFormKeyDown);
			this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainFormKeyPress);
			this.m_grbTrennzeichen.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
