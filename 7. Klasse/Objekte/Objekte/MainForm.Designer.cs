/*
 * Created by SharpDevelop.
 * User: neuhold.benedikt
 * Date: 16.10.2017
 * Time: 13:48
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Objekte
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label m_lblOutput;
		
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
			this.SuspendLayout();
			// 
			// m_lblOutput
			// 
			this.m_lblOutput.BackColor = System.Drawing.SystemColors.ControlLight;
			this.m_lblOutput.Location = new System.Drawing.Point(12, 13);
			this.m_lblOutput.Name = "m_lblOutput";
			this.m_lblOutput.Size = new System.Drawing.Size(871, 474);
			this.m_lblOutput.TabIndex = 0;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(893, 498);
			this.Controls.Add(this.m_lblOutput);
			this.Name = "MainForm";
			this.Text = "Objekte";
			this.ResumeLayout(false);

		}
	}
}
