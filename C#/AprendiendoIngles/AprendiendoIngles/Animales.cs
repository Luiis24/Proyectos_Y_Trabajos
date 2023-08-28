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
	/// Description of Animales.
	/// </summary>
	public partial class Animales : Form
	{
		public Animales()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void AnimalesLoad(object sender, EventArgs e)
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
		void Button12Click(object sender, EventArgs e)
		{
			this.Close();
		}
		
		void BtnAbueloClick(object sender, EventArgs e)
		{
			Sonidos.voz("horse");
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			Sonidos.voz("pig");
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			Sonidos.voz("dog");
		}
		
		void Button4Click(object sender, EventArgs e)
		{
			Sonidos.voz("elephant");
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			Sonidos.voz("rooster");
		}
		
		void Button5Click(object sender, EventArgs e)
		{
			Sonidos.voz("cat");
		}
		
		void Button6Click(object sender, EventArgs e)
		{
			Sonidos.voz("bear");
		}
		
		void Button7Click(object sender, EventArgs e)
		{
			Sonidos.voz("lion");
		}
		
		void Button8Click(object sender, EventArgs e)
		{
			Sonidos.voz("sheep");
		}
		
		void Button11Click(object sender, EventArgs e)
		{
			Sonidos.voz("fish");
		}
		
		void Button9Click(object sender, EventArgs e)
		{
			Sonidos.voz("bird");
		}
		
		void Button10Click(object sender, EventArgs e)
		{
			Sonidos.voz("cow");
		}
	}
		}