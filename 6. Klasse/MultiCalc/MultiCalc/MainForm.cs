/*
* Created by SharpDevelop.
* User: Benedikt
* Date: 06.11.2016
* Time: 22:13
* 
* To change this template use Tools | Options | Coding | Edit Standard Headers.
*/
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MultiCalc
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
		void Button1Click(object sender, EventArgs e)
		{
			// Einlesen der Parameter von der GUI
			double param1 = Convert.ToDouble(m_tbParam1.Text);
			double param2 = Convert.ToDouble(m_tbParam2.Text);

			string operation = Convert.ToString(m_cbOperation.SelectedItem);

			// Result Variable definieren und auf 0 initalisieren
			double result = 0;

			switch (operation)
			{
				case "Addition":
					result = param1 + param2;
					break;
				case "Subtraktion":
					result = param1 - param2;
					break;
				case "Multiplikation":
					result = param1 * param2;
					break;
				case "Division":
					result = param1 / param2;
					break;
				default:
					MessageBox.Show("Ihre Eingabe ist fehlerhaft");
					break;
			}

			m_lblResult.Text = Convert.ToString(result);

			// IF-ELSE Anweisung zur obigen SWITCH Anweisung

			if (operation == "Addition")
			{
				result = param1 + param2;
			}
			else
			{
				if (operation == "Subtraktion")
				{
					result = param1 - param2;
				}
				else
				{
					if (operation == "Multiplikation")
					{
						result = param1 * param2;
					}
					else
					{
						if (operation == "Division")
						{
							result = param1 / param2;
						}
						else
						{
							MessageBox.Show("Ihre Eingabe ist fehlerhaft");
						}
					}
				}
			}

		}
	}
}
