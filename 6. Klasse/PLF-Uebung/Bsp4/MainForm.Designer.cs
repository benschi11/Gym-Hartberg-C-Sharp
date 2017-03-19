/*
 * Created by SharpDevelop.
 * User: Benedikt Neuhold
 * Date: 19.03.2017
 * Time: 19:22
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Bsp4
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button m_btnCalc;
		private System.Windows.Forms.Label m_lblOutput;
		private System.Windows.Forms.TextBox m_tbEndZahl;
		
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
			this.m_btnCalc = new System.Windows.Forms.Button();
			this.m_lblOutput = new System.Windows.Forms.Label();
			this.m_tbEndZahl = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// m_btnCalc
			// 
			this.m_btnCalc.Location = new System.Drawing.Point(12, 70);
			this.m_btnCalc.Name = "m_btnCalc";
			this.m_btnCalc.Size = new System.Drawing.Size(260, 58);
			this.m_btnCalc.TabIndex = 0;
			this.m_btnCalc.Text = "Berechne Summe 1 bis x";
			this.m_btnCalc.UseVisualStyleBackColor = true;
			this.m_btnCalc.Click += new System.EventHandler(this.M_btnCalcClick);
			// 
			// m_lblOutput
			// 
			this.m_lblOutput.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.m_lblOutput.Location = new System.Drawing.Point(12, 154);
			this.m_lblOutput.Name = "m_lblOutput";
			this.m_lblOutput.Size = new System.Drawing.Size(260, 98);
			this.m_lblOutput.TabIndex = 1;
			// 
			// m_tbEndZahl
			// 
			this.m_tbEndZahl.Location = new System.Drawing.Point(12, 26);
			this.m_tbEndZahl.Name = "m_tbEndZahl";
			this.m_tbEndZahl.Size = new System.Drawing.Size(260, 20);
			this.m_tbEndZahl.TabIndex = 2;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.m_tbEndZahl);
			this.Controls.Add(this.m_lblOutput);
			this.Controls.Add(this.m_btnCalc);
			this.Name = "MainForm";
			this.Text = "Bsp4";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
