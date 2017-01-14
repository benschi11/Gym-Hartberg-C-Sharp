/*
 * Created by SharpDevelop.
 * User: nb
 * Date: 05.12.2016
 * Time: 12:06
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Modulo
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox m_tbDividend;
		private System.Windows.Forms.TextBox m_tbDivisor;
		private System.Windows.Forms.TextBox m_tbQuotient;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox m_tbRest;
		private System.Windows.Forms.Button m_btnBerechne;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button m_btnBerechneModulo;
		
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
			this.m_tbDividend = new System.Windows.Forms.TextBox();
			this.m_tbDivisor = new System.Windows.Forms.TextBox();
			this.m_tbQuotient = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.m_tbRest = new System.Windows.Forms.TextBox();
			this.m_btnBerechne = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.m_btnBerechneModulo = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// m_tbDividend
			// 
			this.m_tbDividend.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.m_tbDividend.Location = new System.Drawing.Point(25, 19);
			this.m_tbDividend.Name = "m_tbDividend";
			this.m_tbDividend.Size = new System.Drawing.Size(60, 29);
			this.m_tbDividend.TabIndex = 0;
			// 
			// m_tbDivisor
			// 
			this.m_tbDivisor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.m_tbDivisor.Location = new System.Drawing.Point(138, 19);
			this.m_tbDivisor.Name = "m_tbDivisor";
			this.m_tbDivisor.Size = new System.Drawing.Size(60, 29);
			this.m_tbDivisor.TabIndex = 1;
			// 
			// m_tbQuotient
			// 
			this.m_tbQuotient.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.m_tbQuotient.Location = new System.Drawing.Point(255, 19);
			this.m_tbQuotient.Name = "m_tbQuotient";
			this.m_tbQuotient.ReadOnly = true;
			this.m_tbQuotient.Size = new System.Drawing.Size(60, 29);
			this.m_tbQuotient.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(63, 71);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(69, 24);
			this.label1.TabIndex = 3;
			this.label1.Text = "Rest:";
			// 
			// m_tbRest
			// 
			this.m_tbRest.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.m_tbRest.Location = new System.Drawing.Point(138, 68);
			this.m_tbRest.Name = "m_tbRest";
			this.m_tbRest.ReadOnly = true;
			this.m_tbRest.Size = new System.Drawing.Size(60, 29);
			this.m_tbRest.TabIndex = 4;
			// 
			// m_btnBerechne
			// 
			this.m_btnBerechne.Location = new System.Drawing.Point(12, 108);
			this.m_btnBerechne.Name = "m_btnBerechne";
			this.m_btnBerechne.Size = new System.Drawing.Size(346, 36);
			this.m_btnBerechne.TabIndex = 5;
			this.m_btnBerechne.Text = "Berechne";
			this.m_btnBerechne.UseVisualStyleBackColor = true;
			this.m_btnBerechne.Click += new System.EventHandler(this.M_btnBerechneClick);
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(102, 22);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(15, 24);
			this.label2.TabIndex = 6;
			this.label2.Text = ":";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(218, 22);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(15, 24);
			this.label3.TabIndex = 7;
			this.label3.Text = "=";
			// 
			// m_btnBerechneModulo
			// 
			this.m_btnBerechneModulo.Location = new System.Drawing.Point(12, 150);
			this.m_btnBerechneModulo.Name = "m_btnBerechneModulo";
			this.m_btnBerechneModulo.Size = new System.Drawing.Size(346, 36);
			this.m_btnBerechneModulo.TabIndex = 8;
			this.m_btnBerechneModulo.Text = "Berechne mit modulo";
			this.m_btnBerechneModulo.UseVisualStyleBackColor = true;
			this.m_btnBerechneModulo.Click += new System.EventHandler(this.M_btnBerechneModuloClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(370, 262);
			this.Controls.Add(this.m_btnBerechneModulo);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.m_btnBerechne);
			this.Controls.Add(this.m_tbRest);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.m_tbQuotient);
			this.Controls.Add(this.m_tbDivisor);
			this.Controls.Add(this.m_tbDividend);
			this.Name = "MainForm";
			this.Text = "Modulo";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
