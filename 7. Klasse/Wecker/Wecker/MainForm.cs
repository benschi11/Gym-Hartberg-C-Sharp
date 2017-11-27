/*
 * Created by SharpDevelop.
 * User: neuhold.benedikt
 * Date: 13.11.2017
 * Time: 11:53
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Wecker
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		List<Alarm> _alarms;
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			
			m_tmUhr.Start();
			_alarms = new List<Alarm>();
			RefreshListBox();
		}
		void M_tmUhrTick(object sender, EventArgs e)
		{
			DateTime current = DateTime.Now;
			
			m_lblUhrzeit.Text = current.ToString("h:mm:s");
			m_lblDebug.Text = "";
			foreach(Alarm a in _alarms)
			{
				TimeSpan diff = a.Uhrzeit.TimeOfDay - current.TimeOfDay;
				m_lblDebug.Text += diff.Hours + ":" + diff.Minutes + ":" + diff.Seconds + Environment.NewLine;
				if(diff.Hours == 0 && diff.Minutes == 0 && diff.Seconds == 0)
				{
//					System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"c:\mywavfile.wav");
//					player.Play();
					MessageBox.Show(string.Format("Alarm - {0}", a.Name));
					System.Media.SystemSounds.Beep.Play();
				}
			}
			
			
		}
		void M_btnAddAlarmClick(object sender, EventArgs e)
		{
			string name = m_tbName.Text;
			DateTime uhrzeit = m_dtpUhrzeit.Value;
			uhrzeit = uhrzeit.AddSeconds(-uhrzeit.Second);
			uhrzeit = uhrzeit.AddMilliseconds(-uhrzeit.Millisecond);
			
			if(string.IsNullOrEmpty(name) || uhrzeit == DateTime.MinValue)
			{
				MessageBox.Show("Ihre Eingaben ware nicht korrekt");
			}
			else
			{
				Alarm a = new Alarm(name, uhrzeit);
				_alarms.Add(a);
				RefreshListBox();
			}
		}
		
		private void RefreshListBox()
		{
			m_lbxAlarms.DataSource = null;
			m_lbxAlarms.DataSource = _alarms;
		}
	}
}
