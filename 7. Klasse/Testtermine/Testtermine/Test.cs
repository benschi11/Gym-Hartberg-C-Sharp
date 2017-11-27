/*
 * Created by SharpDevelop.
 * User: neuhold.benedikt
 * Date: 22.11.2017
 * Time: 12:05
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Testtermine
{
	/// <summary>
	/// Description of Test.
	/// </summary>
	public class Test
	{
		public Test()
		{
		}
		
		public Test(string subject, 
		            DateTime date, string topics)
		{
			this.Subject = subject;
			this.Date = date;
			this.Topics = topics;
		}
		
		
		
		#region Subject
		private string m_subject;
		
		public string Subject {
			get {
				return m_subject;
			}
			
			set {
				m_subject = value;
			}
		}
		#endregion
		
		#region Date
		private DateTime m_date;
		
		public DateTime Date {
			get {
				return m_date;
			}
			
			set {
				m_date = value;
			}
		}
		#endregion
		
		#region Topics
		private string m_topics;
		
		public string Topics {
			get {
				return m_topics;
			}
			
			set {
				m_topics = value;
			}
		}
		#endregion
		
		public override string ToString()
		{
			return string.Format("{0} : {1}", m_subject, m_date.ToString("dd.MM.yyyy"));
		}

	}
}
