/*
 * Created by SharpDevelop.
 * User: Benedikt
 * Date: 09.10.2016
 * Time: 18:11
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;

namespace Addierer
{
	/// <summary>
	/// Interaction logic for Window1.xaml
	/// </summary>
	public partial class Window1 : Window
	{
		public Window1()
		{
			InitializeComponent();
		}
		void m_btnCalculate_Click(object sender, RoutedEventArgs e)
		{
			// Einlesen der Zahlen aus den Textboxen
			double number1 = Convert.ToDouble(m_tbNumber1.Text);
			double number2 = Convert.ToDouble(m_tbNumber2.Text);
			
			// Addieren und Summe in sum speichern
			double sum = number1 + number2;
			
			// Ausgabe des Ergebnisses in das Label
			m_lblSum.Content = Convert.ToString(sum);
		}
	}
}