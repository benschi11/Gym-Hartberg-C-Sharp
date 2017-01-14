/*
 * Created by SharpDevelop.
 * User: schueler
 * Date: 21.11.2016
 * Time: 12:30
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace for_schleife
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
		void M_btnSumClick(object sender, EventArgs e)
		{
			// Werte einlesen
			int number1 = Convert.ToInt32(m_tbNumber1.Text);
			
//			int zaehler = 1;
//			
//			while(zaehler <= number1)
//			{
//				// aufaddieren
//				zaehler = zaehler + 1; // zaehler++;
//			}
			
			// Summenvariable
			int result = 0;
			
			// for-Schleife
			for(int i = 1; i <= number1; i=i+1)
			{
				result = result + i;
			}
			
			m_lblOutput.Text = Convert.ToString(result);
		}
		void M_btnSumEvenClick(object sender, EventArgs e)
		{
			
		}
	}
}
