/*
 * Created by SharpDevelop.
 * User: nb
 * Date: 19.10.2016
 * Time: 14:29
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
		// Deklariere zu erratende Zahl
		int search;
		// Zählt die Versuche mit
		int counter;
		
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
		void M_btnGuessWhatClick(object sender, EventArgs e)
		{
			// Counter um 1 erhöhen
			// counter = counter + 1;
			counter++; // erhöht counter um 1
			
			// Einlesen der Benutzereingabe
			int number = Convert.ToInt32(m_tbNumber.Text);
			
			// Ist meine gewählte Nummer schon die richtige?
			if (number == search) 
			{
				m_lblOutput.Text = "Super du hast die Zahl erraten! Du hast " + counter.ToString() + " Versuche gebraucht!";
			}
			else 
			{
				// Ist die gewählte Zahl größer als die gesuchte?
				if (number > search) 
				{
					m_lblOutput.Text = "Die Zahl ist zu groß!";
				} 
				else
				{
					m_lblOutput.Text = "Die Zahl ist zu klein";
				}
			}
		}
		void M_btnNewNumberClick(object sender, EventArgs e)
		{
			counter = 0;
			// Zufallsgenerator erzeugen
			Random r = new Random();
			
			search = r.Next(1,20);
		}
	}
}
