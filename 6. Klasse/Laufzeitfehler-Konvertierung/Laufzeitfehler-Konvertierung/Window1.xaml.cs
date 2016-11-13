/*
 * Created by SharpDevelop.
 * User: Benedikt
 * Date: 09.10.2016
 * Time: 19:21
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

namespace Laufzeitfehler_Konvertierung
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
		void m_btnStart_Click(object sender, RoutedEventArgs e)
		{
			double number = Convert.ToDouble(m_tbInput.Text);
		}
	}
}