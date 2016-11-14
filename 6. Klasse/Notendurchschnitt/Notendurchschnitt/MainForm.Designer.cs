/*
 * Created by SharpDevelop.
 * User: nb
 * Date: 10/17/2016
 * Time: 12:11
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Notendurchschnitt
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox m_tbMath;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox m_tbGerman;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox m_tbEnglish;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox m_tbSecondLanguage;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox m_tbBiology;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox m_tbComputerScience;
		private System.Windows.Forms.Button m_btnCalc;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label m_lblOutput;
		private System.Windows.Forms.Label m_lblSuccess;
		
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
			this.m_tbMath = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.m_tbGerman = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.m_tbEnglish = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.m_tbSecondLanguage = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.m_tbBiology = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.m_tbComputerScience = new System.Windows.Forms.TextBox();
			this.m_btnCalc = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.m_lblOutput = new System.Windows.Forms.Label();
			this.m_lblSuccess = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// m_tbMath
			// 
			this.m_tbMath.Location = new System.Drawing.Point(113, 44);
			this.m_tbMath.Name = "m_tbMath";
			this.m_tbMath.Size = new System.Drawing.Size(85, 20);
			this.m_tbMath.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 44);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(83, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "Mathematik:";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(12, 70);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(83, 23);
			this.label2.TabIndex = 3;
			this.label2.Text = "Deutsch:";
			// 
			// m_tbGerman
			// 
			this.m_tbGerman.Location = new System.Drawing.Point(113, 70);
			this.m_tbGerman.Name = "m_tbGerman";
			this.m_tbGerman.Size = new System.Drawing.Size(85, 20);
			this.m_tbGerman.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(12, 96);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(83, 23);
			this.label3.TabIndex = 5;
			this.label3.Text = "Englisch:";
			// 
			// m_tbEnglish
			// 
			this.m_tbEnglish.Location = new System.Drawing.Point(113, 96);
			this.m_tbEnglish.Name = "m_tbEnglish";
			this.m_tbEnglish.Size = new System.Drawing.Size(85, 20);
			this.m_tbEnglish.TabIndex = 4;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(12, 122);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(95, 23);
			this.label4.TabIndex = 7;
			this.label4.Text = "2. Fremdsprache";
			// 
			// m_tbSecondLanguage
			// 
			this.m_tbSecondLanguage.Location = new System.Drawing.Point(113, 122);
			this.m_tbSecondLanguage.Name = "m_tbSecondLanguage";
			this.m_tbSecondLanguage.Size = new System.Drawing.Size(85, 20);
			this.m_tbSecondLanguage.TabIndex = 6;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(12, 148);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(83, 23);
			this.label5.TabIndex = 9;
			this.label5.Text = "Biologie";
			// 
			// m_tbBiology
			// 
			this.m_tbBiology.Location = new System.Drawing.Point(113, 148);
			this.m_tbBiology.Name = "m_tbBiology";
			this.m_tbBiology.Size = new System.Drawing.Size(85, 20);
			this.m_tbBiology.TabIndex = 8;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(12, 174);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(83, 23);
			this.label6.TabIndex = 11;
			this.label6.Text = "Informatik:";
			// 
			// m_tbComputerScience
			// 
			this.m_tbComputerScience.Location = new System.Drawing.Point(113, 174);
			this.m_tbComputerScience.Name = "m_tbComputerScience";
			this.m_tbComputerScience.Size = new System.Drawing.Size(85, 20);
			this.m_tbComputerScience.TabIndex = 10;
			// 
			// m_btnCalc
			// 
			this.m_btnCalc.Location = new System.Drawing.Point(20, 205);
			this.m_btnCalc.Name = "m_btnCalc";
			this.m_btnCalc.Size = new System.Drawing.Size(387, 45);
			this.m_btnCalc.TabIndex = 12;
			this.m_btnCalc.Text = "&Notendurchschnitt berechnen";
			this.m_btnCalc.UseVisualStyleBackColor = true;
			this.m_btnCalc.Click += new System.EventHandler(this.M_btnCalcClick);
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(49, 13);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(337, 23);
			this.label7.TabIndex = 13;
			this.label7.Text = "Notendurchschnitt";
			// 
			// m_lblOutput
			// 
			this.m_lblOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.m_lblOutput.Location = new System.Drawing.Point(22, 273);
			this.m_lblOutput.Name = "m_lblOutput";
			this.m_lblOutput.Size = new System.Drawing.Size(384, 46);
			this.m_lblOutput.TabIndex = 14;
			this.m_lblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// m_lblSuccess
			// 
			this.m_lblSuccess.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.m_lblSuccess.Location = new System.Drawing.Point(22, 333);
			this.m_lblSuccess.Name = "m_lblSuccess";
			this.m_lblSuccess.Size = new System.Drawing.Size(384, 56);
			this.m_lblSuccess.TabIndex = 15;
			this.m_lblSuccess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(421, 408);
			this.Controls.Add(this.m_lblSuccess);
			this.Controls.Add(this.m_lblOutput);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.m_btnCalc);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.m_tbComputerScience);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.m_tbBiology);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.m_tbSecondLanguage);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.m_tbEnglish);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.m_tbGerman);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.m_tbMath);
			this.Name = "MainForm";
			this.Text = "Notendurchschnitt";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
