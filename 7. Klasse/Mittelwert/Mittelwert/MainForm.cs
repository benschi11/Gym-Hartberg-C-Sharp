/*
 * Created by SharpDevelop.
 * User: neuhold.benedikt
 * Date: 27.09.2017
 * Time: 11:59
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Mittelwert
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
		void M_btnMittelwertClick(object sender, EventArgs e)
		{
			// Daten einlesen
			string eingabe = m_tbEingabe.Text;
			
			// Splitzeichen auswählen
			char splitZeichen = ',';
			
			if(m_rbSemikolon.Checked == true)
			{
				splitZeichen = ';';
			}
			
			// Daten aufspalten
			string[] werteAlsText = eingabe.Split(splitZeichen);
			
			// Werte konvertieren
			int[] werte = new int[werteAlsText.Length];
			
			for(int i = 0; i < werte.Length; i++)
			{
				werte[i] = Convert.ToInt32(werteAlsText[i]);
			}
			
			double mittelwert = MittelwertBerechnen(werte);
			
			// Ausgabe
			m_lblAusgabe.Text = mittelwert.ToString();
		}
		
		double MittelwertBerechnen(int[] daten)
		{
			double summe = 0;
			
			for(int i = 0; i < daten.Length; i++)
			{
				summe = summe + daten[i];
			}
			
			double mittelwert = summe/daten.Length;
			
			return mittelwert;
		}
		void MainFormKeyDown(object sender, KeyEventArgs e)
		{
			if (e.Modifiers == Keys.Shift && e.KeyCode == Keys.Up)
			{
			    MessageBox.Show("My message");
			}			
		}
		void MainFormKeyPress(object sender, KeyPressEventArgs e)
		{
			if(e.KeyChar == 'a')
			{
				MessageBox.Show("test");
			}
		}
	}
}
