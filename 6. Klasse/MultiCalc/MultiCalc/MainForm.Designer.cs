/*
 * Created by SharpDevelop.
 * User: Benedikt
 * Date: 06.11.2016
 * Time: 22:13
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace MultiCalc
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button m_btnCalc;
		private System.Windows.Forms.ComboBox m_cbOperation;
		private System.Windows.Forms.TextBox m_tbParam1;
		private System.Windows.Forms.TextBox m_tbParam2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label m_lblResult;
		
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
			this.m_cbOperation = new System.Windows.Forms.ComboBox();
			this.m_tbParam1 = new System.Windows.Forms.TextBox();
			this.m_tbParam2 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.m_lblResult = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// m_btnCalc
			// 
			this.m_btnCalc.Location = new System.Drawing.Point(31, 192);
			this.m_btnCalc.Name = "m_btnCalc";
			this.m_btnCalc.Size = new System.Drawing.Size(135, 36);
			this.m_btnCalc.TabIndex = 3;
			this.m_btnCalc.Text = "&Berechne";
			this.m_btnCalc.UseVisualStyleBackColor = true;
			this.m_btnCalc.Click += new System.EventHandler(this.Button1Click);
			// 
			// m_cbOperation
			// 
			this.m_cbOperation.FormattingEnabled = true;
			this.m_cbOperation.Items.AddRange(new object[] {
			"Addition",
			"Subtraktion",
			"Multiplikation",
			"Division"});
			this.m_cbOperation.Location = new System.Drawing.Point(31, 139);
			this.m_cbOperation.Name = "m_cbOperation";
			this.m_cbOperation.Size = new System.Drawing.Size(163, 21);
			this.m_cbOperation.TabIndex = 4;
			// 
			// m_tbParam1
			// 
			this.m_tbParam1.Location = new System.Drawing.Point(132, 30);
			this.m_tbParam1.Name = "m_tbParam1";
			this.m_tbParam1.Size = new System.Drawing.Size(100, 20);
			this.m_tbParam1.TabIndex = 5;
			// 
			// m_tbParam2
			// 
			this.m_tbParam2.Location = new System.Drawing.Point(132, 65);
			this.m_tbParam2.Name = "m_tbParam2";
			this.m_tbParam2.Size = new System.Drawing.Size(100, 20);
			this.m_tbParam2.TabIndex = 6;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(44, 33);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(60, 23);
			this.label1.TabIndex = 7;
			this.label1.Text = "Paramter 1";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(44, 68);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(60, 23);
			this.label2.TabIndex = 8;
			this.label2.Text = "Paramter 2";
			// 
			// m_lblResult
			// 
			this.m_lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.m_lblResult.Location = new System.Drawing.Point(35, 238);
			this.m_lblResult.Name = "m_lblResult";
			this.m_lblResult.Size = new System.Drawing.Size(289, 60);
			this.m_lblResult.TabIndex = 9;
			this.m_lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(350, 323);
			this.Controls.Add(this.m_lblResult);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.m_tbParam2);
			this.Controls.Add(this.m_tbParam1);
			this.Controls.Add(this.m_cbOperation);
			this.Controls.Add(this.m_btnCalc);
			this.Name = "MainForm";
			this.Text = "MultiCalc";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
