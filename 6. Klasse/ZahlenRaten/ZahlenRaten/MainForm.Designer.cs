/*
 * Created by SharpDevelop.
 * User: nb
 * Date: 19.10.2016
 * Time: 14:29
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
		private System.Windows.Forms.Button m_btnGuessWhat;
		private System.Windows.Forms.Label m_lblOutput;
		private System.Windows.Forms.TextBox m_tbNumber;
		private System.Windows.Forms.Button m_btnNewNumber;
		
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
			this.m_btnGuessWhat = new System.Windows.Forms.Button();
			this.m_lblOutput = new System.Windows.Forms.Label();
			this.m_tbNumber = new System.Windows.Forms.TextBox();
			this.m_btnNewNumber = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// m_btnGuessWhat
			// 
			this.m_btnGuessWhat.Font = new System.Drawing.Font("Arial Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.m_btnGuessWhat.ForeColor = System.Drawing.Color.Red;
			this.m_btnGuessWhat.Location = new System.Drawing.Point(12, 100);
			this.m_btnGuessWhat.Name = "m_btnGuessWhat";
			this.m_btnGuessWhat.Size = new System.Drawing.Size(425, 49);
			this.m_btnGuessWhat.TabIndex = 0;
			this.m_btnGuessWhat.Text = "Guess What!";
			this.m_btnGuessWhat.UseVisualStyleBackColor = true;
			this.m_btnGuessWhat.Click += new System.EventHandler(this.M_btnGuessWhatClick);
			// 
			// m_lblOutput
			// 
			this.m_lblOutput.Location = new System.Drawing.Point(12, 74);
			this.m_lblOutput.Name = "m_lblOutput";
			this.m_lblOutput.Size = new System.Drawing.Size(425, 23);
			this.m_lblOutput.TabIndex = 1;
			// 
			// m_tbNumber
			// 
			this.m_tbNumber.Location = new System.Drawing.Point(85, 34);
			this.m_tbNumber.Name = "m_tbNumber";
			this.m_tbNumber.Size = new System.Drawing.Size(100, 20);
			this.m_tbNumber.TabIndex = 2;
			// 
			// m_btnNewNumber
			// 
			this.m_btnNewNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.m_btnNewNumber.Location = new System.Drawing.Point(12, 171);
			this.m_btnNewNumber.Name = "m_btnNewNumber";
			this.m_btnNewNumber.Size = new System.Drawing.Size(424, 54);
			this.m_btnNewNumber.TabIndex = 3;
			this.m_btnNewNumber.Text = "New Number";
			this.m_btnNewNumber.UseVisualStyleBackColor = true;
			this.m_btnNewNumber.Click += new System.EventHandler(this.M_btnNewNumberClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(449, 293);
			this.Controls.Add(this.m_btnNewNumber);
			this.Controls.Add(this.m_tbNumber);
			this.Controls.Add(this.m_lblOutput);
			this.Controls.Add(this.m_btnGuessWhat);
			this.Name = "MainForm";
			this.Text = "ZahlenRaten";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
