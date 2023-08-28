/*
 * Created by SharpDevelop.
 * User: SENA
 * Date: 4/05/2023
 * Time: 9:21 a. m.
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
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}

		void BtnVocalesClick(object sender, EventArgs e)
		{
			Vocales ad = new Vocales();
			ad.ShowDialog();
		}
		void BtnColoresClick(object sender, EventArgs e)
		{
			Colores ad = new Colores();
			ad.ShowDialog();
		}
		void BtnFamiliaClick(object sender, EventArgs e)
		{
			Familia ad = new Familia();
			ad.ShowDialog();
		}
		void BtnAnimalesClick(object sender, EventArgs e)
		{
			Animales ad = new Animales();
			ad.ShowDialog();
		}
		void BtnNumerosClick(object sender, EventArgs e)
		{
			Numeros ad = new Numeros();
			ad.ShowDialog();
		}
		void BtnDiasClick(object sender, EventArgs e)
		{
			Dias ad = new Dias();
			ad.ShowDialog();
		}
		void BtnMesesClick(object sender, EventArgs e)
		{
			Meses ad = new Meses();
			ad.ShowDialog();
		}
		void BtnFigurasClick(object sender, EventArgs e)
		{
			Figuras ad = new Figuras();
			ad.ShowDialog();
		}
		void Label1Click(object sender, EventArgs e)
		{
	
		}
		void Panel1Paint(object sender, PaintEventArgs e)
		{
	
		}
		void MainFormLoad(object sender, EventArgs e)
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
		void PictureBox2Click(object sender, EventArgs e)
		{
	
		}
		void Button1Click(object sender, EventArgs e)
		{
	Copi ad = new Copi();
			ad.ShowDialog();
		}
	}
}
