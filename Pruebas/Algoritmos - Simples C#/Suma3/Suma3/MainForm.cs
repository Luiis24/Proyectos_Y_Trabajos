/*
 * Creado por SharpDevelop.
 * Usuario: SENA
 * Fecha: 27/04/2023
 * Hora: 9:43 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Suma3
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
		void Label1Click(object sender, EventArgs e)
		{
	
		}
		void CalcularClick(object sender, EventArgs e)
		{
			this.textresult.Text= (this.valor1.Value + this.valor2.Value + this.valor3.Value).ToString();
		}
	}
}
