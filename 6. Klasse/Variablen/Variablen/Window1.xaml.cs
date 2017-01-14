/*
 * Created by SharpDevelop.
 * User: nb
 * Date: 10/10/2016
 * Time: 12:43
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

namespace Variablen
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
			// Deklaration einer Variable a vom Typ double
			double a;
			
			// Initialisierung der Variable a
			a = Convert.ToDouble(m_tbNumber.Text);
			
			// Quadriere a
			double result = a * a;
			
			// Ausgabe ins Label
			m_lblOutput.Content = result;
		}
		void m_btnCalcC_Click(object sender, RoutedEventArgs e)
		{
			// Einlesen der Werte und speichern in Variablen
			double a = Convert.ToDouble(m_tbA.Text);
			double b = Convert.ToDouble(m_tbB.Text);
			
			// Berechne c mit Satz des Pythagoras a² + b² = c²
			double c = Math.Sqrt(a*a + b*b);
			
			// Ausgabe in die Textbox
			m_tbC.Text = Convert.ToString(c);
			
		}
	}
}