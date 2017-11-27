/*
 * Created by SharpDevelop.
 * User: neuhold.benedikt
 * Date: 16.10.2017
 * Time: 13:56
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Objekte
{
	/// <summary>
	/// Description of Auto.
	/// </summary>
	public class Auto
	{
		// Constructor der Klasse Auto
		public Auto()
		{
		}
		
		// Überladen des Constructors
		public Auto(string name, int maxGear, int maxSpeed)
		{
			this.Name = name;
			this.Gear = maxGear;
			this.MaxSpeed = maxSpeed;
		}
		
		// Eigenschaften
		
		#region Name
		private string m_name;
		
		public string Name {
			// Setzen der variable
			set {
				m_name = value;
			}
			
			// Zurückgeben der Variable
			get {
				return m_name;
			}
		}
		#endregion
		
		#region Gear
		private int m_gear;
		
		public int Gear {
			set {
				if(value > 0 && value <= 9)
				{
					m_gear = value;
				}
				else
				{
					m_gear = 6; // default value
				}
			}
			
			get {
				return m_gear;
			}
		}
		#endregion
		
		#region Info
		public string Info {
			get {
				return "Auto: " + this.Name +
					" Anzahl der Gänge: " + this.Gear
					+ " Maximalgeschwindigkeit: " + this.MaxSpeed
					+ " Aktueller Gang: " + this.currentGear
					+ Environment.NewLine;
			}
		}
		#endregion
		
		#region MaxSpeed
		
		private int m_maxSpeed;
		
		public int MaxSpeed {
			get {
				return m_maxSpeed;
			}
			
			set {
				m_maxSpeed = value;
			}
		}
		
		#endregion
		
		#region ShiftGear
		private int currentGear;
		
		// Methode zum Schalten
		public bool ShiftGear(int gear)
		{
			if(gear <=0 || gear >= this.Gear)
			{
				return false;
			}
			else
			{
				currentGear = gear;
				return true;
			}
		}
		#endregion
	}
}
