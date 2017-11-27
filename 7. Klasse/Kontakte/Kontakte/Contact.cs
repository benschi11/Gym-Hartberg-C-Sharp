/*
 * Created by SharpDevelop.
 * User: neuhold.benedikt
 * Date: 25.10.2017
 * Time: 11:57
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Kontakte
{
	/// <summary>
	/// Description of Contact.
	/// </summary>
	public class Contact
	{
		public Contact()
		{
		}
		
		private string m_prename; // Variable zur Speicherung
		public string Prename {
			set {
				m_prename = value;
			}
			
			get {
				return m_prename;
			}
		}
		
		string surname;
		
		public string Surname {
			get { return surname; }
			set { surname = value; }
		}
		
		string mail;
		
		public string Mail {
			get { return mail; }
			set { mail = value; }
		}
		
		string phone;
		
		public string Phone {
			get { return phone; }
			set { phone = value; }
		}
		
		public string Info {
			get {
				return "Vorname: " + this.Prename + Environment.NewLine
					+ "Nachname: " + this.Surname + Environment.NewLine
					+ "E-Mail: " + this.Mail + Environment.NewLine
					+ "Telefon: " + this.Phone;
			}
		}
		
		public override string ToString()
		{
			return string.Format("{0} {1}", m_prename, surname);
		}

		
		
		
		
	}
}
