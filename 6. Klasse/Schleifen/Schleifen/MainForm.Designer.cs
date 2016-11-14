/*
 * Created by SharpDevelop.
 * User: nb
 * Date: 14.11.2016
 * Time: 12:15
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Schleifen
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label m_lblOutput;
		private System.Windows.Forms.Button m_btnCalc1;
		private System.Windows.Forms.Button m_btnCalc2;
		private System.Windows.Forms.Button m_btnCrazy;
		
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
			this.m_lblOutput = new System.Windows.Forms.Label();
			this.m_btnCalc1 = new System.Windows.Forms.Button();
			this.m_btnCalc2 = new System.Windows.Forms.Button();
			this.m_btnCrazy = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// m_lblOutput
			// 
			this.m_lblOutput.Location = new System.Drawing.Point(12, 9);
			this.m_lblOutput.Name = "m_lblOutput";
			this.m_lblOutput.Size = new System.Drawing.Size(347, 155);
			this.m_lblOutput.TabIndex = 0;
			// 
			// m_btnCalc1
			// 
			this.m_btnCalc1.Location = new System.Drawing.Point(12, 192);
			this.m_btnCalc1.Name = "m_btnCalc1";
			this.m_btnCalc1.Size = new System.Drawing.Size(347, 32);
			this.m_btnCalc1.TabIndex = 1;
			this.m_btnCalc1.Text = "Quadratzahlen ausgeben (händisch)";
			this.m_btnCalc1.UseVisualStyleBackColor = true;
			this.m_btnCalc1.Click += new System.EventHandler(this.M_btnCalc1Click);
			// 
			// m_btnCalc2
			// 
			this.m_btnCalc2.Location = new System.Drawing.Point(12, 230);
			this.m_btnCalc2.Name = "m_btnCalc2";
			this.m_btnCalc2.Size = new System.Drawing.Size(347, 30);
			this.m_btnCalc2.TabIndex = 2;
			this.m_btnCalc2.Text = "Quadratzahlen ausgeben (while)";
			this.m_btnCalc2.UseVisualStyleBackColor = true;
			this.m_btnCalc2.Click += new System.EventHandler(this.M_btnCalc2Click);
			// 
			// m_btnCrazy
			// 
			this.m_btnCrazy.Location = new System.Drawing.Point(12, 266);
			this.m_btnCrazy.Name = "m_btnCrazy";
			this.m_btnCrazy.Size = new System.Drawing.Size(347, 32);
			this.m_btnCrazy.TabIndex = 3;
			this.m_btnCrazy.Text = "Nervig";
			this.m_btnCrazy.UseVisualStyleBackColor = true;
			this.m_btnCrazy.Click += new System.EventHandler(this.M_btnCrazyClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(371, 324);
			this.Controls.Add(this.m_btnCrazy);
			this.Controls.Add(this.m_btnCalc2);
			this.Controls.Add(this.m_btnCalc1);
			this.Controls.Add(this.m_lblOutput);
			this.Name = "MainForm";
			this.Text = "Schleifen";
			this.ResumeLayout(false);

		}
	}
}
