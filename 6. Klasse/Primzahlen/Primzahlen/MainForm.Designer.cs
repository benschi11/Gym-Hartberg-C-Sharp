/*
 * Created by SharpDevelop.
 * User: nb
 * Date: 05.12.2016
 * Time: 12:51
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Primzahlen
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox m_tbEndzahl;
		private System.Windows.Forms.Button m_btnBerechne;
		private System.Windows.Forms.Label m_lblOutput;
		private System.Windows.Forms.TextBox m_tbAnzahl;
		
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
			this.m_tbEndzahl = new System.Windows.Forms.TextBox();
			this.m_btnBerechne = new System.Windows.Forms.Button();
			this.m_lblOutput = new System.Windows.Forms.Label();
			this.m_tbAnzahl = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// m_tbEndzahl
			// 
			this.m_tbEndzahl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.m_tbEndzahl.Location = new System.Drawing.Point(12, 23);
			this.m_tbEndzahl.Name = "m_tbEndzahl";
			this.m_tbEndzahl.Size = new System.Drawing.Size(100, 29);
			this.m_tbEndzahl.TabIndex = 0;
			// 
			// m_btnBerechne
			// 
			this.m_btnBerechne.Location = new System.Drawing.Point(137, 21);
			this.m_btnBerechne.Name = "m_btnBerechne";
			this.m_btnBerechne.Size = new System.Drawing.Size(145, 31);
			this.m_btnBerechne.TabIndex = 1;
			this.m_btnBerechne.Text = "Berechne";
			this.m_btnBerechne.UseVisualStyleBackColor = true;
			this.m_btnBerechne.Click += new System.EventHandler(this.M_btnBerechneClick);
			// 
			// m_lblOutput
			// 
			this.m_lblOutput.Location = new System.Drawing.Point(12, 70);
			this.m_lblOutput.Name = "m_lblOutput";
			this.m_lblOutput.Size = new System.Drawing.Size(1073, 525);
			this.m_lblOutput.TabIndex = 2;
			this.m_lblOutput.Text = "2";
			// 
			// m_tbAnzahl
			// 
			this.m_tbAnzahl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.m_tbAnzahl.Location = new System.Drawing.Point(311, 22);
			this.m_tbAnzahl.Name = "m_tbAnzahl";
			this.m_tbAnzahl.ReadOnly = true;
			this.m_tbAnzahl.Size = new System.Drawing.Size(123, 26);
			this.m_tbAnzahl.TabIndex = 3;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1097, 604);
			this.Controls.Add(this.m_tbAnzahl);
			this.Controls.Add(this.m_lblOutput);
			this.Controls.Add(this.m_btnBerechne);
			this.Controls.Add(this.m_tbEndzahl);
			this.Name = "MainForm";
			this.Text = "Primzahlen";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
