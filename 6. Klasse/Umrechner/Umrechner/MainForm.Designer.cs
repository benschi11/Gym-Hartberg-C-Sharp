/*
 * Created by SharpDevelop.
 * User: nb
 * Date: 12.12.2016
 * Time: 12:30
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Umrechner
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button m_btnCalc;
		private System.Windows.Forms.TextBox m_tbLength;
		private System.Windows.Forms.TextBox m_tbArea;
		private System.Windows.Forms.TextBox m_tbPerimeter;
		private System.Windows.Forms.TextBox m_tbHeight;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		
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
			this.m_tbLength = new System.Windows.Forms.TextBox();
			this.m_tbArea = new System.Windows.Forms.TextBox();
			this.m_tbPerimeter = new System.Windows.Forms.TextBox();
			this.m_tbHeight = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// m_btnCalc
			// 
			this.m_btnCalc.Location = new System.Drawing.Point(333, 174);
			this.m_btnCalc.Name = "m_btnCalc";
			this.m_btnCalc.Size = new System.Drawing.Size(140, 32);
			this.m_btnCalc.TabIndex = 0;
			this.m_btnCalc.Text = "Berechne";
			this.m_btnCalc.UseVisualStyleBackColor = true;
			this.m_btnCalc.Click += new System.EventHandler(this.M_btnCalcClick);
			// 
			// m_tbLength
			// 
			this.m_tbLength.Location = new System.Drawing.Point(93, 34);
			this.m_tbLength.Name = "m_tbLength";
			this.m_tbLength.ReadOnly = true;
			this.m_tbLength.Size = new System.Drawing.Size(88, 20);
			this.m_tbLength.TabIndex = 1;
			// 
			// m_tbArea
			// 
			this.m_tbArea.Location = new System.Drawing.Point(93, 112);
			this.m_tbArea.Name = "m_tbArea";
			this.m_tbArea.ReadOnly = true;
			this.m_tbArea.Size = new System.Drawing.Size(88, 20);
			this.m_tbArea.TabIndex = 2;
			// 
			// m_tbPerimeter
			// 
			this.m_tbPerimeter.Location = new System.Drawing.Point(93, 86);
			this.m_tbPerimeter.Name = "m_tbPerimeter";
			this.m_tbPerimeter.Size = new System.Drawing.Size(88, 20);
			this.m_tbPerimeter.TabIndex = 3;
			// 
			// m_tbHeight
			// 
			this.m_tbHeight.Location = new System.Drawing.Point(93, 60);
			this.m_tbHeight.Name = "m_tbHeight";
			this.m_tbHeight.Size = new System.Drawing.Size(88, 20);
			this.m_tbHeight.TabIndex = 4;
			// 
			// label1
			// 
			this.label1.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(62, 31);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(25, 30);
			this.label1.TabIndex = 5;
			this.label1.Text = "a:";
			// 
			// label2
			// 
			this.label2.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(62, 60);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(25, 30);
			this.label2.TabIndex = 6;
			this.label2.Text = "b:";
			// 
			// label3
			// 
			this.label3.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(62, 86);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(25, 30);
			this.label3.TabIndex = 7;
			this.label3.Text = "U:";
			// 
			// label4
			// 
			this.label4.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(62, 112);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(25, 30);
			this.label4.TabIndex = 8;
			this.label4.Text = "A:";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(485, 262);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.m_tbHeight);
			this.Controls.Add(this.m_tbPerimeter);
			this.Controls.Add(this.m_tbArea);
			this.Controls.Add(this.m_tbLength);
			this.Controls.Add(this.m_btnCalc);
			this.Name = "MainForm";
			this.Text = "Umrechner";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
