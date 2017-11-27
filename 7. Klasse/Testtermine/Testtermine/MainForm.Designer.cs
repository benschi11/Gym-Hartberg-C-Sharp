/*
 * Created by SharpDevelop.
 * User: neuhold.benedikt
 * Date: 22.11.2017
 * Time: 11:47
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Testtermine
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.ListBox m_lbxList;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DateTimePicker m_dtpDate;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button m_btnAdd;
		private System.Windows.Forms.ComboBox m_cbSubject;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox m_tbTopics;
		private System.Windows.Forms.Label m_lblOutput;
		private System.Windows.Forms.Label m_lblClock;
		private System.Windows.Forms.Timer m_timerClock;
		private System.Windows.Forms.Button m_btnDeletePastTests;
		
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
			this.components = new System.ComponentModel.Container();
			this.m_lbxList = new System.Windows.Forms.ListBox();
			this.label1 = new System.Windows.Forms.Label();
			this.m_dtpDate = new System.Windows.Forms.DateTimePicker();
			this.label2 = new System.Windows.Forms.Label();
			this.m_btnAdd = new System.Windows.Forms.Button();
			this.m_cbSubject = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.m_tbTopics = new System.Windows.Forms.TextBox();
			this.m_lblOutput = new System.Windows.Forms.Label();
			this.m_lblClock = new System.Windows.Forms.Label();
			this.m_timerClock = new System.Windows.Forms.Timer(this.components);
			this.m_btnDeletePastTests = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// m_lbxList
			// 
			this.m_lbxList.FormattingEnabled = true;
			this.m_lbxList.ItemHeight = 21;
			this.m_lbxList.Location = new System.Drawing.Point(13, 85);
			this.m_lbxList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.m_lbxList.Name = "m_lbxList";
			this.m_lbxList.Size = new System.Drawing.Size(256, 298);
			this.m_lbxList.TabIndex = 0;
			this.m_lbxList.SelectedIndexChanged += new System.EventHandler(this.M_lbxListSelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(274, 86);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(165, 26);
			this.label1.TabIndex = 2;
			this.label1.Text = "Fach:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// m_dtpDate
			// 
			this.m_dtpDate.Location = new System.Drawing.Point(445, 158);
			this.m_dtpDate.Name = "m_dtpDate";
			this.m_dtpDate.Size = new System.Drawing.Size(265, 29);
			this.m_dtpDate.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(274, 158);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(165, 26);
			this.label2.TabIndex = 4;
			this.label2.Text = "Datum:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// m_btnAdd
			// 
			this.m_btnAdd.Location = new System.Drawing.Point(445, 387);
			this.m_btnAdd.Name = "m_btnAdd";
			this.m_btnAdd.Size = new System.Drawing.Size(265, 54);
			this.m_btnAdd.TabIndex = 5;
			this.m_btnAdd.Text = "&Eintragen";
			this.m_btnAdd.UseVisualStyleBackColor = true;
			this.m_btnAdd.Click += new System.EventHandler(this.M_btnAddClick);
			// 
			// m_cbSubject
			// 
			this.m_cbSubject.FormattingEnabled = true;
			this.m_cbSubject.Items.AddRange(new object[] {
			"Deutsch",
			"Englisch",
			"Mathematik",
			"Informatik",
			"Sprachen"});
			this.m_cbSubject.Location = new System.Drawing.Point(445, 86);
			this.m_cbSubject.Name = "m_cbSubject";
			this.m_cbSubject.Size = new System.Drawing.Size(265, 29);
			this.m_cbSubject.TabIndex = 6;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(274, 202);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(165, 26);
			this.label3.TabIndex = 7;
			this.label3.Text = "Stoff:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// m_tbTopics
			// 
			this.m_tbTopics.Location = new System.Drawing.Point(445, 206);
			this.m_tbTopics.Multiline = true;
			this.m_tbTopics.Name = "m_tbTopics";
			this.m_tbTopics.Size = new System.Drawing.Size(265, 156);
			this.m_tbTopics.TabIndex = 8;
			// 
			// m_lblOutput
			// 
			this.m_lblOutput.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.m_lblOutput.Location = new System.Drawing.Point(12, 388);
			this.m_lblOutput.Name = "m_lblOutput";
			this.m_lblOutput.Size = new System.Drawing.Size(256, 130);
			this.m_lblOutput.TabIndex = 9;
			// 
			// m_lblClock
			// 
			this.m_lblClock.Location = new System.Drawing.Point(695, 9);
			this.m_lblClock.Name = "m_lblClock";
			this.m_lblClock.Size = new System.Drawing.Size(138, 32);
			this.m_lblClock.TabIndex = 10;
			this.m_lblClock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// m_timerClock
			// 
			this.m_timerClock.Interval = 10;
			this.m_timerClock.Tick += new System.EventHandler(this.M_timerClockTick);
			// 
			// m_btnDeletePastTests
			// 
			this.m_btnDeletePastTests.Location = new System.Drawing.Point(445, 464);
			this.m_btnDeletePastTests.Name = "m_btnDeletePastTests";
			this.m_btnDeletePastTests.Size = new System.Drawing.Size(265, 54);
			this.m_btnDeletePastTests.TabIndex = 11;
			this.m_btnDeletePastTests.Text = "Alle vergangenen Termine löschen";
			this.m_btnDeletePastTests.UseVisualStyleBackColor = true;
			this.m_btnDeletePastTests.Click += new System.EventHandler(this.M_btnDeletePastTestsClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(839, 537);
			this.Controls.Add(this.m_btnDeletePastTests);
			this.Controls.Add(this.m_lblClock);
			this.Controls.Add(this.m_lblOutput);
			this.Controls.Add(this.m_tbTopics);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.m_cbSubject);
			this.Controls.Add(this.m_btnAdd);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.m_dtpDate);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.m_lbxList);
			this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "MainForm";
			this.Text = "Testtermine";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
