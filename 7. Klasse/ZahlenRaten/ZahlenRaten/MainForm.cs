/*
 * Created by SharpDevelop.
 * User: neuhold.benedikt
 * Date: 20.09.2017
 * Time: 12:00
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ZahlenRaten
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		int zufallszahl;
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			SetzeZufallszahl();
		}
		
		void M_btnRateClick(object sender, EventArgs e)
		{
			// Daten einlesen
			int eingabe =Convert.ToInt32(m_tbEingabe.Text);
			
			// Überprüfen ob Zahl richtig

			if(eingabe == zufallszahl)
			{
				m_lblAusgabe.Text 
					= "Sie haben die Zahl erraten! Die Zahl war " + zufallszahl.ToString();
				SetzeZufallszahl();
			}
			else {
				
				if(eingabe > zufallszahl)
				{
					m_lblAusgabe.Text = "Die eingegebene Zahl ist zu groß";
				}
				else {
					m_lblAusgabe.Text = "Die eingegebene Zahl ist zu klein";
				}
			}
			
		}
		
		void M_btnNeueZahlClick(object sender, EventArgs e)
		{
			SetzeZufallszahl();
		}
		
		void SetzeZufallszahl()
		{
			// Zufallszahl generieren
			Random r = new Random();
			
			zufallszahl = r.Next(0,100);
		}
		
		
	}
}
