/*
 * Created by SharpDevelop.
 * User: neuhold.benedikt
 * Date: 16.10.2017
 * Time: 13:48
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Objekte
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
			
			// Erzeuge eine neue Instanz vom Typ Auto
			Auto bmw = new Auto();
			bmw.Name = "BMW 1";
			bmw.Gear = 6;
			bmw.MaxSpeed = 200;
			
			Auto porsche = new Auto("Porsche 911", 8, 300);
			
//			porsche.Name = "Porsche 911";
//			porsche.Gear = 16;
//			porsche.MaxSpeed = 300;
			
			bmw.ShiftGear(1);
			porsche.ShiftGear(2);
			
			porsche.ShiftGear(7);
			
			m_lblOutput.Text = bmw.Info;
			
			m_lblOutput.Text += porsche.Info;
			
		}
	}
}
