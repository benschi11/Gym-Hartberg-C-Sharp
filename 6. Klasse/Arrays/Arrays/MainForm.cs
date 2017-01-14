/*
 * Created by SharpDevelop.
 * User: nb
 * Date: 11.01.2017
 * Time: 14:04
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace Arrays
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void M_btnBerechneClick(object sender, EventArgs e)
		{
			// Neues Array vom Typ int anlegen
			int[] zahlen = new int[4];
			
			// Zahlen in Array speichern
			zahlen[0] = 10;
			zahlen[1] = 20;
			zahlen[2] = 30;
			zahlen[3] = 30;
			
			// Durchschnitt berechnen
			double anzahl = 0;
			double summe = 0;
			
			for(int i = 0; i < 4; i++)
			{
				// summe += zahlen[i];
				summe = summe + zahlen[i];
				
				// Erhöhe Zähler
				anzahl++;
			}
			
			double durchschnitt = summe/anzahl;
			
			m_lblAusgabe.Text = durchschnitt.ToString();
		}
		void M_btnBerechneMitEingabeClick(object sender, EventArgs e)
		{
			// Einlesen des Datenstrings
			string daten = m_tbEingabe.Text;
			
			// Aufteilen der Daten
			string[] datenArray = daten.Split(';');
			
			// definiere Maximum
			int max = int.MinValue; // kleinste Zahl, die ein Integer annehmen kann
			
			// foreach-Schleife
			foreach(string zahl in datenArray)
			{
				// Konvertiere zu einer Zahl
				int wert = Convert.ToInt32(zahl);
				
				// Überprüfe ob wert > als aktuelles max
				if(wert > max)
				{
					max = wert;
				}
			}
			
			// Ausgabe
			m_lblAusgabe.Text = max.ToString();
			
		}
	}
}
