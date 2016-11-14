/*
 * Created by SharpDevelop.
 * User: nb
 * Date: 07.11.2016
 * Time: 11:48
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Noten
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox m_tbNote;
		private System.Windows.Forms.Button m_btnPress;
		private System.Windows.Forms.Label m_lblAusgabe;
		
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
			this.m_tbNote = new System.Windows.Forms.TextBox();
			this.m_btnPress = new System.Windows.Forms.Button();
			this.m_lblAusgabe = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// m_tbNote
			// 
			this.m_tbNote.Location = new System.Drawing.Point(12, 40);
			this.m_tbNote.Name = "m_tbNote";
			this.m_tbNote.Size = new System.Drawing.Size(236, 20);
			this.m_tbNote.TabIndex = 0;
			// 
			// m_btnPress
			// 
			this.m_btnPress.Location = new System.Drawing.Point(12, 77);
			this.m_btnPress.Name = "m_btnPress";
			this.m_btnPress.Size = new System.Drawing.Size(236, 23);
			this.m_btnPress.TabIndex = 1;
			this.m_btnPress.Text = "Note ausgeben";
			this.m_btnPress.UseVisualStyleBackColor = true;
			this.m_btnPress.Click += new System.EventHandler(this.M_btnPressClick);
			// 
			// m_lblAusgabe
			// 
			this.m_lblAusgabe.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.m_lblAusgabe.Location = new System.Drawing.Point(12, 117);
			this.m_lblAusgabe.Name = "m_lblAusgabe";
			this.m_lblAusgabe.Size = new System.Drawing.Size(236, 72);
			this.m_lblAusgabe.TabIndex = 2;
			this.m_lblAusgabe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(260, 274);
			this.Controls.Add(this.m_lblAusgabe);
			this.Controls.Add(this.m_btnPress);
			this.Controls.Add(this.m_tbNote);
			this.Name = "MainForm";
			this.Text = "Noten";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
