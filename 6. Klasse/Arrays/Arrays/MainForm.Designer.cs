/*
 * Created by SharpDevelop.
 * User: nb
 * Date: 11.01.2017
 * Time: 14:04
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Arrays
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button m_btnBerechne;
		private System.Windows.Forms.Label m_lblAusgabe;
		private System.Windows.Forms.Button m_btnBerechneMitEingabe;
		private System.Windows.Forms.TextBox m_tbEingabe;
		
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
			this.m_btnBerechne = new System.Windows.Forms.Button();
			this.m_lblAusgabe = new System.Windows.Forms.Label();
			this.m_btnBerechneMitEingabe = new System.Windows.Forms.Button();
			this.m_tbEingabe = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// m_btnBerechne
			// 
			this.m_btnBerechne.Location = new System.Drawing.Point(12, 143);
			this.m_btnBerechne.Name = "m_btnBerechne";
			this.m_btnBerechne.Size = new System.Drawing.Size(406, 47);
			this.m_btnBerechne.TabIndex = 0;
			this.m_btnBerechne.Text = "&Berechne";
			this.m_btnBerechne.UseVisualStyleBackColor = true;
			this.m_btnBerechne.Click += new System.EventHandler(this.M_btnBerechneClick);
			// 
			// m_lblAusgabe
			// 
			this.m_lblAusgabe.BackColor = System.Drawing.SystemColors.ControlDark;
			this.m_lblAusgabe.Location = new System.Drawing.Point(12, 215);
			this.m_lblAusgabe.Name = "m_lblAusgabe";
			this.m_lblAusgabe.Size = new System.Drawing.Size(406, 61);
			this.m_lblAusgabe.TabIndex = 1;
			// 
			// m_btnBerechneMitEingabe
			// 
			this.m_btnBerechneMitEingabe.Location = new System.Drawing.Point(12, 70);
			this.m_btnBerechneMitEingabe.Name = "m_btnBerechneMitEingabe";
			this.m_btnBerechneMitEingabe.Size = new System.Drawing.Size(406, 47);
			this.m_btnBerechneMitEingabe.TabIndex = 2;
			this.m_btnBerechneMitEingabe.Text = "&Berechne mit Eingabe";
			this.m_btnBerechneMitEingabe.UseVisualStyleBackColor = true;
			this.m_btnBerechneMitEingabe.Click += new System.EventHandler(this.M_btnBerechneMitEingabeClick);
			// 
			// m_tbEingabe
			// 
			this.m_tbEingabe.Location = new System.Drawing.Point(12, 23);
			this.m_tbEingabe.Name = "m_tbEingabe";
			this.m_tbEingabe.Size = new System.Drawing.Size(406, 20);
			this.m_tbEingabe.TabIndex = 3;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(430, 306);
			this.Controls.Add(this.m_tbEingabe);
			this.Controls.Add(this.m_btnBerechneMitEingabe);
			this.Controls.Add(this.m_lblAusgabe);
			this.Controls.Add(this.m_btnBerechne);
			this.Name = "MainForm";
			this.Text = "Arrays";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
