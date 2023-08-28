/*
 * Created by SharpDevelop.
 * User: SENA
 * Date: 4/05/2023
 * Time: 9:54 a. m.
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
	/// Description of Familia.
	/// </summary>
	public partial class Familia : Form
	{
		public Familia()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void FamiliaLoad(object sender, EventArgs e)
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
		void Button6Click(object sender, EventArgs e)
		{
			this.Close();
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			Sonidos.voz("sister");
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			Sonidos.voz("mother");
		}
		
		void Button4Click(object sender, EventArgs e)
		{
			Sonidos.voz("brother");
		}
		
		void BtnAbueloClick(object sender, EventArgs e)
		{
			Sonidos.voz("grandfather");
		}
		
		void Button5Click(object sender, EventArgs e)
		{
			Sonidos.voz("grandmother");
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			Sonidos.voz("father");
		}
	}
}
