/*
 * Created by SharpDevelop.
 * User: nb
 * Date: 05.12.2016
 * Time: 12:06
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Modulo
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
			// Werte einlesen und in Variablen speichern
			int divident = Convert.ToInt32(m_tbDividend.Text);
			int divisor = Convert.ToInt32(m_tbDivisor.Text);
			
			
			// ganzahlige Integer-Division durchführen
			int quotient = divident / divisor;
			
			// Ausgabe des Quotienten
			m_tbQuotient.Text = quotient.ToString();
			
			// Rest berechnen
			int rest = divident - (divisor * quotient);
			
			// Ausgabe des Rests
			m_tbRest.Text = rest.ToString();
		}
		void M_btnBerechneModuloClick(object sender, EventArgs e)
		{
			// Werte einlesen und in Variablen speichern
			int divident = Convert.ToInt32(m_tbDividend.Text);
			int divisor = Convert.ToInt32(m_tbDivisor.Text);
			
			
			// ganzahlige Integer-Division durchführen
			int quotient = divident / divisor;
			
			// Ausgabe des Quotienten
			m_tbQuotient.Text = quotient.ToString();
			
			// Verwenden es modulo-Operators
			// Der Modulo Operator gibt den Rest der ganzzahligen Division zurück
			int rest = divident % divisor;
			
			// Ausgabe des Rests
			m_tbRest.Text = rest.ToString();
		}
	}
}
