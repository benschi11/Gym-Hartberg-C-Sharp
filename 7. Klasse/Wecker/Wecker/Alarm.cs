/*
 * Created by SharpDevelop.
 * User: neuhold.benedikt
 * Date: 13.11.2017
 * Time: 12:10
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Wecker
{
	/// <summary>
	/// Description of Alarm.
	/// </summary>
	public class Alarm
	{
		public Alarm(string name, DateTime uhrzeit)
		{
			this.Name = name;
			this.Uhrzeit = uhrzeit;
		}
		
		private string _name;
		
		public string Name {
			get {return _name; }
			set { _name = value; }
		}
		
		
		private DateTime _uhrzeit;
		
		public DateTime Uhrzeit {
			get {return _uhrzeit; }
			set {_uhrzeit = value; }
		}
		
		public override string ToString()
		{
			return string.Format("{0} - ({1})", Name, Uhrzeit.ToString("hh:mm"));
		}

	}
}
