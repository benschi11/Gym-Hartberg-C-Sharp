/*
 * Created by SharpDevelop.
 * User: neuhold.benedikt
 * Date: 25.10.2017
 * Time: 11:46
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Kontakte
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button m_btnSave;
		private System.Windows.Forms.TextBox m_tbPreName;
		private System.Windows.Forms.TextBox m_tbTele;
		private System.Windows.Forms.TextBox m_tbMail;
		private System.Windows.Forms.TextBox m_tbSurName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button m_btnOpen;
		private System.Windows.Forms.Label m_lblOutput;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ListBox m_lbxNamen;
		private System.Windows.Forms.Button m_btnDelete;
		private System.Windows.Forms.Button m_btnEdit;
		private System.Windows.Forms.OpenFileDialog m_ofdOpenFile;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox m_tbSearch;
		private System.Windows.Forms.ListBox m_lbxFiltered;
		
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
			this.m_btnSave = new System.Windows.Forms.Button();
			this.m_tbPreName = new System.Windows.Forms.TextBox();
			this.m_tbTele = new System.Windows.Forms.TextBox();
			this.m_tbMail = new System.Windows.Forms.TextBox();
			this.m_tbSurName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.m_btnOpen = new System.Windows.Forms.Button();
			this.m_lblOutput = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.m_lbxNamen = new System.Windows.Forms.ListBox();
			this.m_btnDelete = new System.Windows.Forms.Button();
			this.m_btnEdit = new System.Windows.Forms.Button();
			this.m_ofdOpenFile = new System.Windows.Forms.OpenFileDialog();
			this.label6 = new System.Windows.Forms.Label();
			this.m_tbSearch = new System.Windows.Forms.TextBox();
			this.m_lbxFiltered = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// m_btnSave
			// 
			this.m_btnSave.Location = new System.Drawing.Point(34, 286);
			this.m_btnSave.Margin = new System.Windows.Forms.Padding(6);
			this.m_btnSave.Name = "m_btnSave";
			this.m_btnSave.Size = new System.Drawing.Size(371, 44);
			this.m_btnSave.TabIndex = 0;
			this.m_btnSave.Text = "Speichern";
			this.m_btnSave.UseVisualStyleBackColor = true;
			this.m_btnSave.Click += new System.EventHandler(this.M_btnSaveClick);
			// 
			// m_tbPreName
			// 
			this.m_tbPreName.Location = new System.Drawing.Point(225, 84);
			this.m_tbPreName.Margin = new System.Windows.Forms.Padding(6);
			this.m_tbPreName.Name = "m_tbPreName";
			this.m_tbPreName.Size = new System.Drawing.Size(180, 32);
			this.m_tbPreName.TabIndex = 1;
			// 
			// m_tbTele
			// 
			this.m_tbTele.Location = new System.Drawing.Point(225, 216);
			this.m_tbTele.Margin = new System.Windows.Forms.Padding(6);
			this.m_tbTele.Name = "m_tbTele";
			this.m_tbTele.Size = new System.Drawing.Size(180, 32);
			this.m_tbTele.TabIndex = 4;
			// 
			// m_tbMail
			// 
			this.m_tbMail.Location = new System.Drawing.Point(225, 172);
			this.m_tbMail.Margin = new System.Windows.Forms.Padding(6);
			this.m_tbMail.Name = "m_tbMail";
			this.m_tbMail.Size = new System.Drawing.Size(180, 32);
			this.m_tbMail.TabIndex = 3;
			// 
			// m_tbSurName
			// 
			this.m_tbSurName.Location = new System.Drawing.Point(225, 128);
			this.m_tbSurName.Margin = new System.Windows.Forms.Padding(6);
			this.m_tbSurName.Name = "m_tbSurName";
			this.m_tbSurName.Size = new System.Drawing.Size(180, 32);
			this.m_tbSurName.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(34, 87);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 5;
			this.label1.Text = "Vorname";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(34, 131);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(127, 23);
			this.label2.TabIndex = 6;
			this.label2.Text = "Nachname:";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(34, 175);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 29);
			this.label3.TabIndex = 7;
			this.label3.Text = "Email:";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(34, 219);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 8;
			this.label4.Text = "Telefon:";
			// 
			// m_btnOpen
			// 
			this.m_btnOpen.Location = new System.Drawing.Point(34, 454);
			this.m_btnOpen.Margin = new System.Windows.Forms.Padding(6);
			this.m_btnOpen.Name = "m_btnOpen";
			this.m_btnOpen.Size = new System.Drawing.Size(371, 44);
			this.m_btnOpen.TabIndex = 9;
			this.m_btnOpen.Text = "Datei auswählen";
			this.m_btnOpen.UseVisualStyleBackColor = true;
			this.m_btnOpen.Click += new System.EventHandler(this.M_btnOpenClick);
			// 
			// m_lblOutput
			// 
			this.m_lblOutput.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.m_lblOutput.Location = new System.Drawing.Point(469, 342);
			this.m_lblOutput.Name = "m_lblOutput";
			this.m_lblOutput.Size = new System.Drawing.Size(449, 239);
			this.m_lblOutput.TabIndex = 10;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(34, 9);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(371, 52);
			this.label5.TabIndex = 11;
			this.label5.Text = "Kontaktverwaltung:";
			// 
			// m_lbxNamen
			// 
			this.m_lbxNamen.FormattingEnabled = true;
			this.m_lbxNamen.ItemHeight = 25;
			this.m_lbxNamen.Location = new System.Drawing.Point(469, 84);
			this.m_lbxNamen.Name = "m_lbxNamen";
			this.m_lbxNamen.Size = new System.Drawing.Size(225, 229);
			this.m_lbxNamen.TabIndex = 12;
			// 
			// m_btnDelete
			// 
			this.m_btnDelete.Location = new System.Drawing.Point(34, 342);
			this.m_btnDelete.Margin = new System.Windows.Forms.Padding(6);
			this.m_btnDelete.Name = "m_btnDelete";
			this.m_btnDelete.Size = new System.Drawing.Size(371, 44);
			this.m_btnDelete.TabIndex = 13;
			this.m_btnDelete.Text = "Löschen";
			this.m_btnDelete.UseVisualStyleBackColor = true;
			this.m_btnDelete.Click += new System.EventHandler(this.M_btnDeleteClick);
			// 
			// m_btnEdit
			// 
			this.m_btnEdit.Location = new System.Drawing.Point(34, 398);
			this.m_btnEdit.Margin = new System.Windows.Forms.Padding(6);
			this.m_btnEdit.Name = "m_btnEdit";
			this.m_btnEdit.Size = new System.Drawing.Size(371, 44);
			this.m_btnEdit.TabIndex = 14;
			this.m_btnEdit.Text = "Bearbeiten";
			this.m_btnEdit.UseVisualStyleBackColor = true;
			this.m_btnEdit.Click += new System.EventHandler(this.M_btnEditClick);
			// 
			// m_ofdOpenFile
			// 
			this.m_ofdOpenFile.FileName = "openFileDialog1";
			this.m_ofdOpenFile.Filter = "7b-KontaktFile|*.7b";
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 16F);
			this.label6.Location = new System.Drawing.Point(469, 21);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(107, 31);
			this.label6.TabIndex = 15;
			this.label6.Text = "Suche:";
			// 
			// m_tbSearch
			// 
			this.m_tbSearch.Location = new System.Drawing.Point(546, 21);
			this.m_tbSearch.Name = "m_tbSearch";
			this.m_tbSearch.Size = new System.Drawing.Size(202, 32);
			this.m_tbSearch.TabIndex = 16;
			this.m_tbSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.M_tbSearchKeyUp);
			// 
			// m_lbxFiltered
			// 
			this.m_lbxFiltered.FormattingEnabled = true;
			this.m_lbxFiltered.ItemHeight = 25;
			this.m_lbxFiltered.Location = new System.Drawing.Point(713, 84);
			this.m_lbxFiltered.Name = "m_lbxFiltered";
			this.m_lbxFiltered.Size = new System.Drawing.Size(205, 229);
			this.m_lbxFiltered.TabIndex = 17;
			this.m_lbxFiltered.SelectedIndexChanged += new System.EventHandler(this.M_lbxFilteredSelectedIndexChanged);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(930, 590);
			this.Controls.Add(this.m_lbxFiltered);
			this.Controls.Add(this.m_tbSearch);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.m_btnEdit);
			this.Controls.Add(this.m_btnDelete);
			this.Controls.Add(this.m_lbxNamen);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.m_lblOutput);
			this.Controls.Add(this.m_btnOpen);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.m_tbSurName);
			this.Controls.Add(this.m_tbMail);
			this.Controls.Add(this.m_tbTele);
			this.Controls.Add(this.m_tbPreName);
			this.Controls.Add(this.m_btnSave);
			this.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(6);
			this.Name = "MainForm";
			this.Text = "Kontakte";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
