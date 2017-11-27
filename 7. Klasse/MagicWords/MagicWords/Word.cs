/*
 * Created by SharpDevelop.
 * User: neuhold.benedikt
 * Date: 27.11.2017
 * Time: 14:37
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace MagicWords
{
	/// <summary>
	/// Description of Word.
	/// </summary>
	public class Word
	{
		public Word()
		{
		}
		
		public Word(string text)
		{
			this.Text = text;
		}
		
		#region Text
		
		private string m_text;
		
		public string Text {
			get {
				return m_text;
			}
			
			set {
				m_text = value;
			}
		}
		
		#endregion
		
		public override string ToString()
		{
			return string.Format("{0}", m_text);
		}

	}
}
