/*
 * Created by SharpDevelop.
 * User: Benedikt Neuhold
 * Date: 13.11.2016
 * Time: 20:52
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace While_Schleife
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
		void M_btnCalcClick1(object sender, EventArgs e)
		{
			// Berechne Quadratzahlen von 1 bis 3
			
			// Methode 1 - Schreibe alle Händisch
			int result1 = 1*1;
			m_lblOutput.Text = Convert.ToString(result1);
			
			int result2 = 2*2;
			m_lblOutput.Text = m_lblOutput.Text + Environment.NewLine + Convert.ToString(result2);
			
			int result3 = 3*3;
			m_lblOutput.Text = m_lblOutput.Text + Environment.NewLine + Convert.ToString(result3);
			
			
		}
		void M_btnCalc2Click(object sender, EventArgs e)
		{
			// Zählvariable erstellen - wir starten mit 1*1 -> counter = 1
			int counter = 1;
			
			// Solange die Variable counter kleiner oder gleich ist wie 3 führe aus
			while(counter <=3)
			{
				int result = counter * counter;
				m_lblOutput.Text = m_lblOutput.Text + Environment.NewLine + Convert.ToString(result);
				counter++;
			}
		}
		void M_btnCalc3Click(object sender, EventArgs e)
		{
			int counter = 2;
			
			while(counter <=100)
			{
				int result = counter * counter;
				
				// Vermeide - zu Beginn
				if(counter == 2)
				{
					m_lblOutput.Text = Convert.ToString(result);
				}
				else
				{
					m_lblOutput.Text = m_lblOutput.Text + " - " + Convert.ToString(result);
				}

				counter = counter +2;
			}
		}
	}
}
