/*
 * Created by SharpDevelop.
 * User: nb
 * Date: 05.12.2016
 * Time: 12:51
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Primzahlen
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
			// Einlesen der Variablen
			int endzahl = Convert.ToInt32(m_tbEndzahl.Text);
			
			// Zähler für Primzahl definieren -> 1, da 2 bereits im Label
			int counter = 1;
			
			// Durchgehen aller Zahlen von 2 bis endzahl
			for(int i = 2;i<=endzahl;i++)
			{
				// Überprüfe ob Primzahl
				
				// Möglicher Teiler?
				int teiler = 2;
				
				// Flag: Ist eine Primzahl - bool -> Wahrheitswert -> true oder false
				bool isPrimzahl = true;
				
				do {
					// überprüfe ob Teiler -> da dann keine Primzahl
					if(i%teiler == 0)
					{
						isPrimzahl = false;
						// Verlässt Schleife
						break;
					}
					
					// prüfe nächsten Teiler
					teiler++;
					
				} while(teiler < i); // solange Teiler kleiner als Schleifenzähler i
				
				// Ausgabe
				// Nur ausgeben wenn Primzahl
				if(isPrimzahl == true)
				{
					m_lblOutput.Text = m_lblOutput.Text + " - " + i.ToString();
					
					// Erhöhe Zähler
					counter++;
					
					// Füge Zeilenumbruch nach 20 Zahlen ein
					if(counter % 20 == 0)
					{
						// m_lblOutput.Text = m_lblOutput.Text + Environment.NewLine;
						m_lblOutput.Text +=  Environment.NewLine;
					}
				}
			}
			
			// Ausgabe des Zählers
			m_tbAnzahl.Text = counter.ToString();
		}
		
		
	}
}
