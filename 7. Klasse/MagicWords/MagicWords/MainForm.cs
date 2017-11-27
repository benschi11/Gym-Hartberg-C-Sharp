/*
 * Created by SharpDevelop.
 * User: neuhold.benedikt
 * Date: 27.11.2017
 * Time: 14:33
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MagicWords
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		List<Word> Wordlist;
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			Wordlist = new List<Word>();
		}
		
		void RefreshListbox()
		{
			m_lbxWords.DataSource = null;
			m_lbxWords.DataSource = Wordlist;
		}
		
		void M_btnAddClick(object sender, EventArgs e)
		{
			string text = m_tbWord.Text;
			
			// Erstelle neue Instanz der Klasse
			// Word
			Word w = new Word(text);
			
			Wordlist.Add(w);
			RefreshListbox();
		}
		void M_btnUpperCaseClick(object sender, EventArgs e)
		{
			Word currentWord = (Word)m_lbxWords.SelectedItem;
			
			MessageBox.Show(currentWord.Text.ToUpper(), "MagicWord");
		}
	}
}
