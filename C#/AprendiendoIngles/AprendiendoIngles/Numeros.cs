/*
 * Created by SharpDevelop.
 * User: SENA
 * Date: 4/05/2023
 * Time: 10:07 a. m.
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
	/// Description of Numeros.
	/// </summary>
	public partial class Numeros : Form
	{
		public Numeros()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void NumerosLoad(object sender, EventArgs e)
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
		
		void Btn0Click(object sender, EventArgs e)
		{
			Sonidos.voz("0");
		}
		
		void Btn1Click(object sender, EventArgs e)
		{
			Sonidos.voz("1");
		}
		
		void Btn2Click(object sender, EventArgs e)
		{
			Sonidos.voz("2");
		}
		
		void Btn3Click(object sender, EventArgs e)
		{
			Sonidos.voz("3");
		}
		
		void Btn4Click(object sender, EventArgs e)
		{
			Sonidos.voz("4");
		}
		
		void Btn5Click(object sender, EventArgs e)
		{
			Sonidos.voz("5");
		}
		
		void Btn6Click(object sender, EventArgs e)
		{
			Sonidos.voz("6");
		}
		
		void Btn7Click(object sender, EventArgs e)
		{
			Sonidos.voz("7");
		}
		
		void Btn8Click(object sender, EventArgs e)
		{
			Sonidos.voz("8");
		}
		
		void Btn9Click(object sender, EventArgs e)
		{
			Sonidos.voz("9");
		}
		
		void Btn10Click(object sender, EventArgs e)
		{
			Sonidos.voz("10");
		}
	}
}
