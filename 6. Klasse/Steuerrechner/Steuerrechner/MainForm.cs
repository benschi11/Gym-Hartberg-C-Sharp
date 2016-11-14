/*
 * Created by SharpDevelop.
 * User: nb
 * Date: 24.10.2016
 * Time: 12:03
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Steuerrechner
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
		void Label1Click(object sender, EventArgs e)
		{
	
		}
		void TextBox1TextChanged(object sender, EventArgs e)
		{
	
		}
		void M_btnBerechneClick(object sender, EventArgs e)
		{
			// Einlesen und konvertieren des Gehalts
			double gehalt = Convert.ToDouble(m_tbGehalt.Text);
			double steuer = 0;
			
			if(gehalt <= 11000)
			{
				m_lblSteuer.Text = "Sie zahlen keine Steuer :)";
			}
			
			// Verbinden der beiden Ausdrücke mit und (&&)
			if(gehalt > 11000 && gehalt <= 18000)
			{
				steuer = (gehalt - 11000) * 0.25;
				m_lblSteuer.Text = "Sie zahlen " + steuer.ToString() + " € Steuer";
			}
			
			if(gehalt > 18000 && gehalt <= 31000)
			{
				double steuerVorgruppen = 7000 * 0.25;
				steuer = (gehalt - 18000) * 0.35 + steuerVorgruppen;
				m_lblSteuer.Text = "Sie zahlen " + steuer.ToString() + " € Steuer";
			}
			
			if(gehalt > 31000 && gehalt <= 60000)
			{
				double steuerVorgruppen = 7000 * 0.25 + 13000*0.35;
				steuer = (gehalt - 31000) * 0.42 + steuerVorgruppen;
				m_lblSteuer.Text = "Sie zahlen " + steuer.ToString() + " € Steuer";
			}
			
			if(gehalt > 60000 && gehalt <= 90000)
			{
				double steuerVorgruppen = 7000 * 0.25 + 13000*0.35 + 29000 * 0.42;
				steuer = (gehalt - 60000) * 0.48 + steuerVorgruppen;
				m_lblSteuer.Text = "Sie zahlen " + steuer.ToString() + " € Steuer";
			}
			
			// Ausgabe des monatlichen Gehalts
			double monatGehalt = (gehalt - steuer)/12;
			m_lblGehaltMonat.Text = Convert.ToString(monatGehalt);
		}
	}
}
