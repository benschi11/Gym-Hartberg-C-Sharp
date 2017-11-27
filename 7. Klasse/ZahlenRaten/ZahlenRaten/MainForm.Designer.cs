/*
 * Created by SharpDevelop.
 * User: neuhold.benedikt
 * Date: 20.09.2017
 * Time: 12:00
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ZahlenRaten
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox m_tbEingabe;
		private System.Windows.Forms.Button m_btnRate;
		private System.Windows.Forms.Label m_lblAusgabe;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button m_btnNeueZahl;
		
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
			this.label1 = new System.Windows.Forms.Label();
			this.m_tbEingabe = new System.Windows.Forms.TextBox();
			this.m_btnRate = new System.Windows.Forms.Button();
			this.m_lblAusgabe = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.m_btnNeueZahl = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label1.Location = new System.Drawing.Point(0, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(573, 53);
			this.label1.TabIndex = 0;
			this.label1.Text = "Zahlen raten";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// m_tbEingabe
			// 
			this.m_tbEingabe.Location = new System.Drawing.Point(157, 68);
			this.m_tbEingabe.Name = "m_tbEingabe";
			this.m_tbEingabe.Size = new System.Drawing.Size(116, 20);
			this.m_tbEingabe.TabIndex = 1;
			// 
			// m_btnRate
			// 
			this.m_btnRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.m_btnRate.Location = new System.Drawing.Point(24, 115);
			this.m_btnRate.Name = "m_btnRate";
			this.m_btnRate.Size = new System.Drawing.Size(536, 38);
			this.m_btnRate.TabIndex = 2;
			this.m_btnRate.Text = "&Rate";
			this.m_btnRate.UseVisualStyleBackColor = true;
			this.m_btnRate.Click += new System.EventHandler(this.M_btnRateClick);
			// 
			// m_lblAusgabe
			// 
			this.m_lblAusgabe.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.m_lblAusgabe.Location = new System.Drawing.Point(23, 170);
			this.m_lblAusgabe.Name = "m_lblAusgabe";
			this.m_lblAusgabe.Size = new System.Drawing.Size(533, 92);
			this.m_lblAusgabe.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(23, 71);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(111, 22);
			this.label3.TabIndex = 4;
			this.label3.Text = "Bitte Zahl eingeben";
			// 
			// m_btnNeueZahl
			// 
			this.m_btnNeueZahl.Location = new System.Drawing.Point(419, 65);
			this.m_btnNeueZahl.Name = "m_btnNeueZahl";
			this.m_btnNeueZahl.Size = new System.Drawing.Size(137, 25);
			this.m_btnNeueZahl.TabIndex = 5;
			this.m_btnNeueZahl.Text = "Neue Zahl";
			this.m_btnNeueZahl.UseVisualStyleBackColor = true;
			this.m_btnNeueZahl.Click += new System.EventHandler(this.M_btnNeueZahlClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(572, 315);
			this.Controls.Add(this.m_btnNeueZahl);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.m_lblAusgabe);
			this.Controls.Add(this.m_btnRate);
			this.Controls.Add(this.m_tbEingabe);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "ZahlenRaten";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
