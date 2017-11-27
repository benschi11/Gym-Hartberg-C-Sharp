/*
 * Created by SharpDevelop.
 * User: neuhold.benedikt
 * Date: 11.10.2017
 * Time: 11:49
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Login
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		string user;
		string pw;
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			
			LoadUser();
			
		}
		
		void LoadUser()
		{
			user = "Sepp";
			pw = "Traktor";
		}

		void main_FormClosed(object sender, FormClosedEventArgs e)
		{
			// Gesamtes Programm beenden
			Application.Exit();
		}
		
		void M_btnLoginClick(object sender, EventArgs e)
		{
			// Einlesen der Daten
			string benutzer = m_tbUser.Text;
			string password = m_tbPassword.Text;
			
			// Überprüfen ob Login erfolgreich
			if(CheckLogin(benutzer,password)==true)
			{
				// Erstelle neue MainPage
				MainPage main = new MainPage();
				
				// Zeige MainPage an
				main.Show();
				
				// Verstecke die LoginForm
				this.Hide();
				
				// FormClosed Event
				main.FormClosed += main_FormClosed;
			}
			else
			{
				MessageBox.Show("Login falsch");
			}
		}
		
		bool CheckLogin(string u, string p)
		{
			if(u == user && p == pw)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		
		
	}
}
