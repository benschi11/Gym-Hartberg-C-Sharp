/*
 * Created by SharpDevelop.
 * User: nb
 * Date: 10.10.2016
 * Time: 11:42
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

namespace FontSize
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
		
		// Wird ausgeführt wenn Button SetPreview gedrückt
		void m_btnSetPreview_Click(object sender, RoutedEventArgs e)
		{
			m_lblPreview.Content = m_tbPreview.Text;
		}
		void m_btnFontSizeUp_Click(object sender, RoutedEventArgs e)
		{
			m_lblPreview.FontSize = m_lblPreview.FontSize + 2;
			m_tbFontSizeOutput.Text = Convert.ToString(m_lblPreview.FontSize);
		}
		void m_btnFontSizeDown_Click(object sender, RoutedEventArgs e)
		{
			m_lblPreview.FontSize = m_lblPreview.FontSize - 2;
			m_tbFontSizeOutput.Text = Convert.ToString(m_lblPreview.FontSize);
		}
		void m_btnSetFontSize_Click(object sender, RoutedEventArgs e)
		{
			m_lblPreview.FontSize = Convert.ToDouble(m_tbFontSize.Text);
			m_tbFontSizeOutput.Text = Convert.ToString(m_lblPreview.FontSize);s
		}
		void m_btnDeletePreview_Click(object sender, RoutedEventArgs e)
		{
			m_tbPreview.Text = "";
			m_lblPreview.Content = "";
		}
	}
}