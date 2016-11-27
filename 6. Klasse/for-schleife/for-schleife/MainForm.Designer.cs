/*
 * Created by SharpDevelop.
 * User: schueler
 * Date: 21.11.2016
 * Time: 12:30
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace for_schleife
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button m_btnSum;
		private System.Windows.Forms.Label m_lblOutput;
		private System.Windows.Forms.TextBox m_tbNumber1;
		private System.Windows.Forms.Button m_btnSumEven;
		
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
			this.m_btnSum = new System.Windows.Forms.Button();
			this.m_lblOutput = new System.Windows.Forms.Label();
			this.m_tbNumber1 = new System.Windows.Forms.TextBox();
			this.m_btnSumEven = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// m_btnSum
			// 
			this.m_btnSum.Location = new System.Drawing.Point(12, 125);
			this.m_btnSum.Name = "m_btnSum";
			this.m_btnSum.Size = new System.Drawing.Size(350, 28);
			this.m_btnSum.TabIndex = 0;
			this.m_btnSum.Text = "Summe berechnen";
			this.m_btnSum.UseVisualStyleBackColor = true;
			this.m_btnSum.Click += new System.EventHandler(this.M_btnSumClick);
			// 
			// m_lblOutput
			// 
			this.m_lblOutput.Location = new System.Drawing.Point(12, 167);
			this.m_lblOutput.Name = "m_lblOutput";
			this.m_lblOutput.Size = new System.Drawing.Size(350, 104);
			this.m_lblOutput.TabIndex = 1;
			this.m_lblOutput.Text = "label1";
			// 
			// m_tbNumber1
			// 
			this.m_tbNumber1.Location = new System.Drawing.Point(32, 49);
			this.m_tbNumber1.Name = "m_tbNumber1";
			this.m_tbNumber1.Size = new System.Drawing.Size(100, 20);
			this.m_tbNumber1.TabIndex = 2;
			// 
			// m_btnSumEven
			// 
			this.m_btnSumEven.Location = new System.Drawing.Point(12, 91);
			this.m_btnSumEven.Name = "m_btnSumEven";
			this.m_btnSumEven.Size = new System.Drawing.Size(350, 28);
			this.m_btnSumEven.TabIndex = 3;
			this.m_btnSumEven.Text = "Summe aller geraden Zahlen";
			this.m_btnSumEven.UseVisualStyleBackColor = true;
			this.m_btnSumEven.Click += new System.EventHandler(this.M_btnSumEvenClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(374, 303);
			this.Controls.Add(this.m_btnSumEven);
			this.Controls.Add(this.m_tbNumber1);
			this.Controls.Add(this.m_lblOutput);
			this.Controls.Add(this.m_btnSum);
			this.Name = "MainForm";
			this.Text = "for-schleife";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
