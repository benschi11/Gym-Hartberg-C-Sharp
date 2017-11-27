/*
 * Created by SharpDevelop.
 * User: neuhold.benedikt
 * Date: 13.11.2017
 * Time: 11:53
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Wecker
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label m_lblUhrzeit;
		private System.Windows.Forms.ListBox m_lbxAlarms;
		private System.Windows.Forms.DateTimePicker m_dtpUhrzeit;
		private System.Windows.Forms.TextBox m_tbName;
		private System.Windows.Forms.Timer m_tmUhr;
		private System.Windows.Forms.Button m_btnAddAlarm;
		private System.Windows.Forms.Label m_lblDebug;
		
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
			this.m_lblUhrzeit = new System.Windows.Forms.Label();
			this.m_lbxAlarms = new System.Windows.Forms.ListBox();
			this.m_dtpUhrzeit = new System.Windows.Forms.DateTimePicker();
			this.m_tbName = new System.Windows.Forms.TextBox();
			this.m_tmUhr = new System.Windows.Forms.Timer(this.components);
			this.m_btnAddAlarm = new System.Windows.Forms.Button();
			this.m_lblDebug = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// m_lblUhrzeit
			// 
			this.m_lblUhrzeit.Font = new System.Drawing.Font("Segoe UI Semibold", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.m_lblUhrzeit.Location = new System.Drawing.Point(29, 34);
			this.m_lblUhrzeit.Name = "m_lblUhrzeit";
			this.m_lblUhrzeit.Size = new System.Drawing.Size(365, 109);
			this.m_lblUhrzeit.TabIndex = 0;
			this.m_lblUhrzeit.Text = "label1";
			this.m_lblUhrzeit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// m_lbxAlarms
			// 
			this.m_lbxAlarms.FormattingEnabled = true;
			this.m_lbxAlarms.Location = new System.Drawing.Point(12, 182);
			this.m_lbxAlarms.Name = "m_lbxAlarms";
			this.m_lbxAlarms.Size = new System.Drawing.Size(142, 173);
			this.m_lbxAlarms.TabIndex = 1;
			// 
			// m_dtpUhrzeit
			// 
			this.m_dtpUhrzeit.CustomFormat = "hh:mm";
			this.m_dtpUhrzeit.Font = new System.Drawing.Font("Segoe UI Light", 20F);
			this.m_dtpUhrzeit.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.m_dtpUhrzeit.Location = new System.Drawing.Point(200, 267);
			this.m_dtpUhrzeit.Name = "m_dtpUhrzeit";
			this.m_dtpUhrzeit.ShowUpDown = true;
			this.m_dtpUhrzeit.Size = new System.Drawing.Size(194, 43);
			this.m_dtpUhrzeit.TabIndex = 2;
			// 
			// m_tbName
			// 
			this.m_tbName.Font = new System.Drawing.Font("Segoe UI Light", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.m_tbName.Location = new System.Drawing.Point(200, 187);
			this.m_tbName.Name = "m_tbName";
			this.m_tbName.Size = new System.Drawing.Size(194, 52);
			this.m_tbName.TabIndex = 3;
			// 
			// m_tmUhr
			// 
			this.m_tmUhr.Interval = 1000;
			this.m_tmUhr.Tick += new System.EventHandler(this.M_tmUhrTick);
			// 
			// m_btnAddAlarm
			// 
			this.m_btnAddAlarm.Font = new System.Drawing.Font("Segoe UI Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.m_btnAddAlarm.Location = new System.Drawing.Point(200, 324);
			this.m_btnAddAlarm.Name = "m_btnAddAlarm";
			this.m_btnAddAlarm.Size = new System.Drawing.Size(194, 57);
			this.m_btnAddAlarm.TabIndex = 4;
			this.m_btnAddAlarm.Text = "Hinzufügen";
			this.m_btnAddAlarm.UseVisualStyleBackColor = true;
			this.m_btnAddAlarm.Click += new System.EventHandler(this.M_btnAddAlarmClick);
			// 
			// m_lblDebug
			// 
			this.m_lblDebug.Location = new System.Drawing.Point(12, 358);
			this.m_lblDebug.Name = "m_lblDebug";
			this.m_lblDebug.Size = new System.Drawing.Size(142, 54);
			this.m_lblDebug.TabIndex = 5;
			this.m_lblDebug.Text = "label1";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(425, 443);
			this.Controls.Add(this.m_lblDebug);
			this.Controls.Add(this.m_btnAddAlarm);
			this.Controls.Add(this.m_tbName);
			this.Controls.Add(this.m_dtpUhrzeit);
			this.Controls.Add(this.m_lbxAlarms);
			this.Controls.Add(this.m_lblUhrzeit);
			this.Name = "MainForm";
			this.Text = "Wecker";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
