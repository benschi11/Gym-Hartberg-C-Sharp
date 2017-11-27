/*
 * Created by SharpDevelop.
 * User: neuhold.benedikt
 * Date: 25.10.2017
 * Time: 11:46
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace Kontakte
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		List<Contact> Liste;
		List<Contact> gefilderteListe;
		string datei;
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			Liste = new List<Contact>();
			gefilderteListe = new List<Contact>();
			datei = "T:/kontakte.7b"; // Standard Datei
			ReadFromDisk();
			// Verknüpfe ListBox mit Listenvariable
			m_lbxFiltered.DataSource = gefilderteListe;
		}
		void M_btnSaveClick(object sender, EventArgs e)
		{
			// Einlesen der Daten aus der GUI
			string vorname = m_tbPreName.Text;
			string nachname = m_tbSurName.Text;
			string mail = m_tbMail.Text;
			string tele = m_tbTele.Text;
			
			Contact c1 = new Contact();
			c1.Prename = vorname;
			c1.Surname = nachname;
			c1.Mail = mail;
			c1.Phone = tele;
			
			Liste.Add(c1);
			
			RefreshListBox();
			
			SaveToDisk();
		}
		
		void RefreshListBox()
		{
			// Aktualisieren der Listebox
			m_lbxFiltered.DataSource = null;
			m_lbxFiltered.DataSource = Liste;
		}
		
		
		void Anzeigen()
		{
			 int selectedIndex = m_lbxFiltered.SelectedIndex;
			
			if(selectedIndex >=0)
			{
				// Lösche alten Text
				m_lblOutput.Text = "";
				
				m_lblOutput.Text += gefilderteListe[selectedIndex].Info;
			}
		}
		
		
		
		
		// Speichert die List auf die Festplatte
		void SaveToDisk()
		{
			// Überschreibe Datei mit leerer Datei
			File.WriteAllText(datei, "");
			
			// Schreibe Liste in Datei
			foreach(Contact currentContact in Liste)
			{
				File.AppendAllText(datei,
				                   currentContact.Prename + ";"
				                   + currentContact.Surname + ";"
				                   + currentContact.Mail + ";"
				                   + currentContact.Phone+ Environment.NewLine);
			}
		}
		
		void ReadFromDisk()
		{
			Liste.Clear();
			string[] text = File.ReadAllLines(datei);
			
			for(int i = 0; i< text.Length; i++)
			{
				string zeile = text[i];
				
				// Aufspalten der Zeile
				string[] daten = zeile.Split(';');
				
				Contact c = new Contact();
				c.Prename = daten[0];
				c.Surname = daten[1];
				c.Mail = daten[2];
				c.Phone = daten[3];
				
				Liste.Add(c);
				gefilderteListe.Add(c);
			}
		}
		void M_btnDeleteClick(object sender, EventArgs e)
		{
			int selectedIndex = m_lbxFiltered.SelectedIndex;
			Contact selectedContact = gefilderteListe[selectedIndex];
			
			Liste.Remove(selectedContact);
			
			RefreshListBox();
			
			SaveToDisk();
		}
		void M_btnEditClick(object sender, EventArgs e)
		{
			int selectedIndex = m_lbxFiltered.SelectedIndex;
			
			Contact selectedContact = gefilderteListe[selectedIndex];
			
			m_tbPreName.Text = selectedContact.Prename;
			m_tbSurName.Text = selectedContact.Surname;
			m_tbMail.Text = selectedContact.Mail;
			m_tbTele.Text = selectedContact.Phone;
				
			
			Liste.Remove(selectedContact);
		}
		
		void M_btnOpenClick(object sender, EventArgs e)
		{
			if(m_ofdOpenFile.ShowDialog() == DialogResult.OK)
			{
				string pfadZurDatei = m_ofdOpenFile.FileName;
				datei = pfadZurDatei;
				ReadFromDisk();
				RefreshListBox();
			
			}
		}
		void M_tbSearchKeyUp(object sender, KeyEventArgs e)
		{
			string suchtext = m_tbSearch.Text;
			
			// Ausleeren der Liste
			gefilderteListe.Clear();
			
			foreach(Contact current in Liste)
			{
				if(current.Surname.Contains(suchtext)
				   || current.Prename.Contains(suchtext))
				{
					gefilderteListe.Add(current);
				}
			}
			
			// Refresh der Liste
			m_lbxFiltered.DataSource = null;
			m_lbxFiltered.DataSource = gefilderteListe;
		}
		void M_lbxFilteredSelectedIndexChanged(object sender, EventArgs e)
		{
			Anzeigen();
		}
	}
}
