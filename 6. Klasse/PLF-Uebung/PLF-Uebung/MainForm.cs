/*
 * Created by SharpDevelop.
 * User: Benedikt Neuhold
 * Date: 19.03.2017
 * Time: 19:13
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Bsp3
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
		void M_btnDateiClick(object sender, EventArgs e)
		{
			if(m_ofdOpen.ShowDialog() == DialogResult.OK)
			{
				m_tbPfad.Text = m_ofdOpen.FileName;
			}
		}
		void M_btnDoItClick(object sender, EventArgs e)
		{
			string dateipfad = m_tbPfad.Text;
			string text = System.IO.File.ReadAllText(dateipfad);
			
			if(text.Length > 100)
			{
				MessageBox.Show("Ihr Text ist leider zu lange. Versuchen Sie einen anderen");
			}
			else
			{
				string[] textArray = text.Split(' ');
				
				string textOhneLeerzeichen = "";
				
				for(int i = 0; i < textArray.Length; i++)
				{
					textOhneLeerzeichen = textOhneLeerzeichen + textArray[i];
				}
				
				m_lblOutput.Text = textOhneLeerzeichen;
			}
		}
	}
}
