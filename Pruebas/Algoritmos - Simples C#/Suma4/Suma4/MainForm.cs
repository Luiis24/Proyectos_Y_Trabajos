/*
 * Creado por SharpDevelop.
 * Usuario: SENA
 * Fecha: 27/04/2023
 * Hora: 10:44 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Suma4
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
		void MainFormLoad(object sender, EventArgs e)
		{
	
		}
		void Button1Click(object sender, EventArgs e)
		{
			this.suma.Text = (this.numericUpDown1.Value + this.numericUpDown2.Value + this.numericUpDown3.Value + this.numericUpDown4.Value).ToString();
			this.resta.Text = (this.numericUpDown1.Value + this.numericUpDown2.Value + this.numericUpDown3.Value).ToString();
		}
	}
}
