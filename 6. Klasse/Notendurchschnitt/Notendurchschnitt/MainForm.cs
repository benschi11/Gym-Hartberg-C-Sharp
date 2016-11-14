/*
 * Created by SharpDevelop.
 * User: nb
 * Date: 10/17/2016
 * Time: 12:11
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Notendurchschnitt
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
		void M_btnCalcClick(object sender, EventArgs e)
		{
			// Werte einlesen und speichern
			int math = Convert.ToInt32(m_tbMath.Text);
			int german = Convert.ToInt32(m_tbGerman.Text);
			int english = Convert.ToInt32(m_tbEnglish.Text);
			int secondLanguage = Convert.ToInt32(m_tbSecondLanguage.Text);
			int biology = Convert.ToInt32(m_tbBiology.Text);
			int computerScience = Convert.ToInt32(m_tbComputerScience.Text);
			
			// Um die Autovervollständigung zu aktivieren drücke STRG + Leertaste
			double average = (math + german + english + secondLanguage
			                  + biology+computerScience) / 6;
			
			// Ausgabe
			m_lblSuccess.Text = "";
			m_lblOutput.Text = Convert.ToString(average);
			
			
			if(average <= 2.0)
			{
				// Wird ausgeführt wenn average <= 2.0
				m_lblSuccess.Text = "Guter Erfolg";
			}
			
			if(average <= 1.5)
			{
				// Wird ausgeführt wenn average <= 1.5
				m_lblSuccess.Text = "Ausgzeichneter Erfolg";
			}
			
		}
	}
}
