/*
 * Created by SharpDevelop.
 * User: nb
 * Date: 12.12.2016
 * Time: 12:30
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Umrechner
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
			// Einlesen der Werte
			
			int a = Convert.ToInt32(m_tbLength.Text);
			int U = Convert.ToInt32(m_tbHeight.Text);
			
			// Berechne b
			
			double b = U / 2.0 - a;
			
			

		}
	}
}
