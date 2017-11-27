/*
 * Created by SharpDevelop.
 * User: neuhold.benedikt
 * Date: 22.11.2017
 * Time: 11:47
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Testtermine
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		List<Test> Testlist;
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			m_lblClock.Text = DateTime.Now.ToString("HH:mm:ss");
			
			// Schalte Timer ein
			m_timerClock.Enabled = true;
			
			Testlist = new List<Test>();
		}
		void M_btnAddClick(object sender, EventArgs e)
		{
			string subject = m_cbSubject.Text;
			DateTime date = m_dtpDate.Value;
			string topics = m_tbTopics.Text;
			
			Test t = new Test(subject, date, topics);
			Testlist.Add(t);
			RefreshListBox();
		}
		
		void RefreshListBox()
		{
			m_lbxList.DataSource = null;
			m_lbxList.DataSource = Testlist;
		}
		
		void M_lbxListSelectedIndexChanged(object sender, EventArgs e)
		{
			Test currentTest = (Test)m_lbxList.SelectedItem;
			if(currentTest != null)
			{
				m_lblOutput.Text = currentTest.Topics;
			}
		}
		
		void M_timerClockTick(object sender, EventArgs e)
		{
			m_lblClock.Text = DateTime.Now.ToString("HH:mm:ss");
		}
		
		void M_btnDeletePastTestsClick(object sender, EventArgs e)
		{
			// Temporäre Liste zum Speichern der zu löschenden
			// Objekte
			List<Test> ItemsToDelete = new List<Test>();
			
			// Durchsuche Liste nach vergangenen Tests
			foreach(Test currentTest in Testlist)
			{
				if(currentTest.Date < DateTime.Now)
				{
					ItemsToDelete.Add(currentTest);
				}
			}
			
			// Schleife zum löschen der Elemente
			foreach(Test t in ItemsToDelete)
			{
				// Lösche Test aus aktueller Liste
				Testlist.Remove(t);
			}
			
			RefreshListBox();
		}
	}
}
