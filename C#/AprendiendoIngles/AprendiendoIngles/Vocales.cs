/*
 * Created by SharpDevelop.
 * User: SENA
 * Date: 4/05/2023
 * Time: 9:53 a. m.
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
	/// Description of Vocales.
	/// </summary>
	public partial class Vocales : Form
	{
		public Vocales()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void VocalesLoad(object sender, EventArgs e)
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
		void BtnAClick(object sender, EventArgs e)
		{
			Sonidos.voz("A");
		}
		void BtnEClick(object sender, EventArgs e)
		{
	Sonidos.voz("E");
		}
		void BtniClick(object sender, EventArgs e)
		{
	Sonidos.voz("I");
		}
		void BtnOClick(object sender, EventArgs e)
		{
	Sonidos.voz("O");
		}
		void BtnUClick(object sender, EventArgs e)
		{
	Sonidos.voz("U");
		}
		void Button1Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
