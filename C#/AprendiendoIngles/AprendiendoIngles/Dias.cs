/*
 * Created by SharpDevelop.
 * User: SENA
 * Date: 4/05/2023
 * Time: 9:56 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace AprendiendoIngles
{
	/// <summary>
	/// Description of Dias.
	/// </summary>
	public partial class Dias : Form
	{
		public Dias()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void DiasLoad(object sender, EventArgs e)
		{
					Random random = new Random();
			// obtener una lista de todos los botones en el panel
			List<Button> buttons = new List<Button>();
			foreach (Control control in panel1.Controls) {
				Button button = control as Button;
				if(button != null)
				{
					buttons.Add(button);
				}
			}
			// mover los botones de forma aleatroia dentro del panel
			for (int i = 0; i < buttons.Count; i++)
			{
				int j = random.Next(i, buttons.Count);
				Point temp  = buttons[i].Location;
				buttons[i].Location = buttons [j].Location;
				buttons[j].Location = temp;
				
				//agregar cada boton al panel
				panel1.Controls.Add(buttons[i]);
			}
		}
		void Button1Click(object sender, EventArgs e)
		{
			this.Close();
		}
		
		void BtnLunesClick(object sender, EventArgs e)
		{
			Sonidos.voz("Lunes");
		}
		
		void BtnMartesClick(object sender, EventArgs e)
		{
			Sonidos.voz("Martes");
		}
		
		void BtnMiercolesClick(object sender, EventArgs e)
		{
			Sonidos.voz("Miercoles");
		}
		
		void BtnJuevesClick(object sender, EventArgs e)
		{
			Sonidos.voz("Jueves");
		}
		
		void BtnViernesClick(object sender, EventArgs e)
		{
			Sonidos.voz("Viernes");
		}
		
		void BtnSabadoClick(object sender, EventArgs e)
		{
			Sonidos.voz("Sabado");
		}
		
		void BtnDomingoClick(object sender, EventArgs e)
		{
			Sonidos.voz("Domingo");
		}
	}
}
