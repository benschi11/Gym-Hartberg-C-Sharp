/*
 * Created by SharpDevelop.
 * User: nb
 * Date: 14.11.2016
 * Time: 12:15
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;

namespace Schleifen
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
		void M_btnCalc1Click(object sender, EventArgs e)
		{
			// Händische Ausgabe der Quadratzahlen von 1 bis 3
			
			int result1 = 1*1;
			m_lblOutput.Text = Convert.ToString(result1);
			int result2 = 2*2;
			m_lblOutput.Text = m_lblOutput.Text + " - " +
				Convert.ToString(result2);
			int result3 = 3*3;
			m_lblOutput.Text = m_lblOutput.Text + " - " +
				Convert.ToString(result3);

		}
		void M_btnCalc2Click(object sender, EventArgs e)
		{
			// Ausgabe der Quadratzahlen mit While
			
			// Zähler definieren
			int counter = 1;
			
			// while-Schleife
			while(counter <= 100)
			{
				// Wird pro Schleifendurchlauf ausgeführt
				int result = counter * counter;
				
				// Ausgabe
				
				// 1ste Schleifendurchgang
				if(counter == 1)
				{
					m_lblOutput.Text = Convert.ToString(result);
				}
				else
				{					
					m_lblOutput.Text = m_lblOutput.Text + " - " +
				Convert.ToString(result);
				}

				
				// Zähler erhöhen
				counter = counter + 1; // counter++;
			}
		}
		void M_btnCrazyClick(object sender, EventArgs e)
		{
			// Zählvariable 
			int counter = 0;
			
			while(counter < 10)
			{
				MessageBox.Show("Ist das nervig?", "Hiho");
				
				// Zähler erhöhen
				counter++;
			}
		}
	}
}
