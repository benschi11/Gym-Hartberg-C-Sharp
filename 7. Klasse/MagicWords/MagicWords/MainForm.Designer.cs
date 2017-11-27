/*
 * Created by SharpDevelop.
 * User: neuhold.benedikt
 * Date: 27.11.2017
 * Time: 14:33
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace MagicWords
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.ListBox m_lbxWords;
		private System.Windows.Forms.TextBox m_tbWord;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button m_btnAdd;
		private System.Windows.Forms.Button m_btnUpperCase;
		
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
			this.m_lbxWords = new System.Windows.Forms.ListBox();
			this.m_tbWord = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.m_btnAdd = new System.Windows.Forms.Button();
			this.m_btnUpperCase = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// m_lbxWords
			// 
			this.m_lbxWords.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.m_lbxWords.FormattingEnabled = true;
			this.m_lbxWords.ItemHeight = 21;
			this.m_lbxWords.Location = new System.Drawing.Point(12, 48);
			this.m_lbxWords.Name = "m_lbxWords";
			this.m_lbxWords.Size = new System.Drawing.Size(157, 256);
			this.m_lbxWords.TabIndex = 0;
			// 
			// m_tbWord
			// 
			this.m_tbWord.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.m_tbWord.Location = new System.Drawing.Point(358, 48);
			this.m_tbWord.Name = "m_tbWord";
			this.m_tbWord.Size = new System.Drawing.Size(188, 29);
			this.m_tbWord.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(241, 48);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(111, 29);
			this.label1.TabIndex = 2;
			this.label1.Text = "Text eingeben";
			// 
			// m_btnAdd
			// 
			this.m_btnAdd.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.m_btnAdd.Location = new System.Drawing.Point(241, 94);
			this.m_btnAdd.Name = "m_btnAdd";
			this.m_btnAdd.Size = new System.Drawing.Size(304, 56);
			this.m_btnAdd.TabIndex = 3;
			this.m_btnAdd.Text = "Eintragen";
			this.m_btnAdd.UseVisualStyleBackColor = true;
			this.m_btnAdd.Click += new System.EventHandler(this.M_btnAddClick);
			// 
			// m_btnUpperCase
			// 
			this.m_btnUpperCase.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.m_btnUpperCase.Location = new System.Drawing.Point(241, 173);
			this.m_btnUpperCase.Name = "m_btnUpperCase";
			this.m_btnUpperCase.Size = new System.Drawing.Size(304, 56);
			this.m_btnUpperCase.TabIndex = 4;
			this.m_btnUpperCase.Text = "Alles Großbuchstaben";
			this.m_btnUpperCase.UseVisualStyleBackColor = true;
			this.m_btnUpperCase.Click += new System.EventHandler(this.M_btnUpperCaseClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(652, 440);
			this.Controls.Add(this.m_btnUpperCase);
			this.Controls.Add(this.m_btnAdd);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.m_tbWord);
			this.Controls.Add(this.m_lbxWords);
			this.Name = "MainForm";
			this.Text = "MagicWords";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
