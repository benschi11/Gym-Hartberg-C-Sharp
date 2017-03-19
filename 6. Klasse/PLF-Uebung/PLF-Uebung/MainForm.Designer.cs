/*
 * Created by SharpDevelop.
 * User: Benedikt Neuhold
 * Date: 19.03.2017
 * Time: 19:13
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Bsp3
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button m_btnDatei;
		private System.Windows.Forms.TextBox m_tbPfad;
		private System.Windows.Forms.Label m_lblOutput;
		private System.Windows.Forms.Button m_btnDoIt;
		private System.Windows.Forms.OpenFileDialog m_ofdOpen;
		
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
			this.m_btnDatei = new System.Windows.Forms.Button();
			this.m_tbPfad = new System.Windows.Forms.TextBox();
			this.m_lblOutput = new System.Windows.Forms.Label();
			this.m_btnDoIt = new System.Windows.Forms.Button();
			this.m_ofdOpen = new System.Windows.Forms.OpenFileDialog();
			this.SuspendLayout();
			// 
			// m_btnDatei
			// 
			this.m_btnDatei.Location = new System.Drawing.Point(274, 15);
			this.m_btnDatei.Name = "m_btnDatei";
			this.m_btnDatei.Size = new System.Drawing.Size(100, 23);
			this.m_btnDatei.TabIndex = 0;
			this.m_btnDatei.Text = "Datei auswählen";
			this.m_btnDatei.UseVisualStyleBackColor = true;
			this.m_btnDatei.Click += new System.EventHandler(this.M_btnDateiClick);
			// 
			// m_tbPfad
			// 
			this.m_tbPfad.Location = new System.Drawing.Point(12, 15);
			this.m_tbPfad.Name = "m_tbPfad";
			this.m_tbPfad.Size = new System.Drawing.Size(256, 20);
			this.m_tbPfad.TabIndex = 1;
			// 
			// m_lblOutput
			// 
			this.m_lblOutput.BackColor = System.Drawing.SystemColors.ControlDark;
			this.m_lblOutput.Location = new System.Drawing.Point(9, 54);
			this.m_lblOutput.Name = "m_lblOutput";
			this.m_lblOutput.Size = new System.Drawing.Size(364, 262);
			this.m_lblOutput.TabIndex = 2;
			this.m_lblOutput.Text = "label1";
			// 
			// m_btnDoIt
			// 
			this.m_btnDoIt.Location = new System.Drawing.Point(9, 338);
			this.m_btnDoIt.Name = "m_btnDoIt";
			this.m_btnDoIt.Size = new System.Drawing.Size(365, 83);
			this.m_btnDoIt.TabIndex = 3;
			this.m_btnDoIt.Text = "Auswerten";
			this.m_btnDoIt.UseVisualStyleBackColor = true;
			this.m_btnDoIt.Click += new System.EventHandler(this.M_btnDoItClick);
			// 
			// m_ofdOpen
			// 
			this.m_ofdOpen.FileName = "openFileDialog1";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(386, 433);
			this.Controls.Add(this.m_btnDoIt);
			this.Controls.Add(this.m_lblOutput);
			this.Controls.Add(this.m_tbPfad);
			this.Controls.Add(this.m_btnDatei);
			this.Name = "MainForm";
			this.Text = "PLF-Uebung";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
