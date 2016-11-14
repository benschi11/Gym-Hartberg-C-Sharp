/*
 * Created by SharpDevelop.
 * User: nb
 * Date: 03.10.2016
 * Time: 12:46
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

namespace HelloWorld
{
	/// <summary>
	/// Interaction logic for Window1.xaml
	/// </summary>
	public partial class Window1 : Window
	{
		// Constructor - wird beim Laden des Fensters ausgeführt
		public Window1()
		{
			InitializeComponent();
			m_lblOutput.Content = "Hello World!";
		}
		
		// Diese Funktion wird beim Klicken des Button Start ausgeführt
		void m_btnStart_Click(object sender, RoutedEventArgs e)
		{
			m_lblOutput.Content = "Benedikt Neuhold";
			m_btnStart.Content = "Press me!";
		}
		
		// Diese Funktion wird beim Klicken des Button HelloWorld ausgeführt
		void m_btnHelloWorld_Click(object sender, RoutedEventArgs e)
		{
			m_lblOutput.Content = "Hello World!";
			m_btnStart.Content = "OK";
		}
		
		// wird ausgeführt bei Button FontSizeBig
		void m_btnFontSizeBig_Click(object sender, RoutedEventArgs e)
		{
			m_lblOutput.FontSize = 20;
		}
		
		// wird ausgeführt bei Button FontSizeSmall
		void m_btnFontSizeSmall_Click(object sender, RoutedEventArgs e)
		{
			m_lblOutput.FontSize = 10;
		}
		
		void m_btn_Click(object sender, RoutedEventArgs e)
		{
			// "Convert.ToDouble()" konvertiert einen Text in eine Dezimalzahl
			// string -> Text
			// int -> ganze Zahl
			// double -> Kommazahl
			m_lblOutput.FontSize = Convert.ToDouble(m_tbFontSize.Text);
		}
	}
}