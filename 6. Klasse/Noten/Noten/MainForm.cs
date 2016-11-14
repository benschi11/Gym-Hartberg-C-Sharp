/*
 * Created by SharpDevelop.
 * User: nb
 * Date: 07.11.2016
 * Time: 11:48
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Noten
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
		void M_btnPressClick(object sender, EventArgs e)
		{
			int note = Convert.ToInt32(m_tbNote.Text);
			
			// Wenn Note kleiner als 1 ODER größer als 5
			if(note < 1 || note > 5)
			{
				// Messagebox ausgaben
				MessageBox.Show("Sie haben keine gültige Note eingeben",
				                "Fehler", MessageBoxButtons.OK,
				                MessageBoxIcon.Error);
			}
			else {
				// Wenn kein Fehler -> führe diesen Code aus
				
				// Definiere Ausgabevariable
				string output;
				
				// Switch Anweisung
				switch (note)
				{
					// Falls Note 1
				case 1:
					output = "Sehr gut";
					break;
					// Falls Note 2
				case 2:
					output = "Gut";
					break;
				case 3:
					output = "Befriedigend";
					break;
				case 4:
					output = "Genügend";
					break;
				case 5:
					output = "Nicht genügend";
					break;
				default:
					output = "Fehler";
					break;
				}
				
				m_lblAusgabe.Text = output;
				
			}
			
		}
	}
}
