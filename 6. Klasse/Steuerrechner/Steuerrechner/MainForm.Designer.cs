/*
 * Created by SharpDevelop.
 * User: nb
 * Date: 24.10.2016
 * Time: 12:03
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Steuerrechner
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox m_tbGehalt;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button m_btnBerechne;
		private System.Windows.Forms.Label m_lblSteuer;
		private System.Windows.Forms.Label m_lblGehaltMonat;
		
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
			this.m_tbGehalt = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.m_btnBerechne = new System.Windows.Forms.Button();
			this.m_lblSteuer = new System.Windows.Forms.Label();
			this.m_lblGehaltMonat = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// m_tbGehalt
			// 
			this.m_tbGehalt.Location = new System.Drawing.Point(160, 34);
			this.m_tbGehalt.Name = "m_tbGehalt";
			this.m_tbGehalt.Size = new System.Drawing.Size(189, 20);
			this.m_tbGehalt.TabIndex = 0;
			this.m_tbGehalt.TextChanged += new System.EventHandler(this.TextBox1TextChanged);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 37);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(142, 21);
			this.label1.TabIndex = 1;
			this.label1.Text = "Brutto Gehalt abzgl. SV";
			this.label1.Click += new System.EventHandler(this.Label1Click);
			// 
			// m_btnBerechne
			// 
			this.m_btnBerechne.Location = new System.Drawing.Point(12, 78);
			this.m_btnBerechne.Name = "m_btnBerechne";
			this.m_btnBerechne.Size = new System.Drawing.Size(480, 34);
			this.m_btnBerechne.TabIndex = 2;
			this.m_btnBerechne.Text = "Berechne Steuer";
			this.m_btnBerechne.UseVisualStyleBackColor = true;
			this.m_btnBerechne.Click += new System.EventHandler(this.M_btnBerechneClick);
			// 
			// m_lblSteuer
			// 
			this.m_lblSteuer.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.m_lblSteuer.Location = new System.Drawing.Point(12, 133);
			this.m_lblSteuer.Name = "m_lblSteuer";
			this.m_lblSteuer.Size = new System.Drawing.Size(479, 59);
			this.m_lblSteuer.TabIndex = 3;
			// 
			// m_lblGehaltMonat
			// 
			this.m_lblGehaltMonat.Location = new System.Drawing.Point(12, 217);
			this.m_lblGehaltMonat.Name = "m_lblGehaltMonat";
			this.m_lblGehaltMonat.Size = new System.Drawing.Size(246, 35);
			this.m_lblGehaltMonat.TabIndex = 4;
			this.m_lblGehaltMonat.Text = "label2";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(504, 322);
			this.Controls.Add(this.m_lblGehaltMonat);
			this.Controls.Add(this.m_lblSteuer);
			this.Controls.Add(this.m_btnBerechne);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.m_tbGehalt);
			this.Name = "MainForm";
			this.Text = "Steuerrechner";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
