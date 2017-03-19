/*
 * Created by SharpDevelop.
 * User: Benedikt Neuhold
 * Date: 19.03.2017
 * Time: 19:22
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Bsp4
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
			// Einlesen
			int endzahl = Convert.ToInt32(m_tbEndZahl.Text);
			
			// Funktionsaufruf
			int gesamtSumme = BerechneSumme(endzahl);
			
			// Ausgabe
			m_lblOutput.Text = gesamtSumme.ToString();
		}
		
		int BerechneSumme(int endzahl)
		{
			int summe = 0;
			for(int i = 1; i <= endzahl; i++)
			{
				summe = summe + i;
			}
			
			return summe;
		}
	}
}
