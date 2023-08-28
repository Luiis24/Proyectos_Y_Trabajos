/*
 * Creado por SharpDevelop.
 * Usuario: SENA
 * Fecha: 28/04/2023
 * Hora: 7:13 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace suma5
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
		void CalcularClick(object sender, EventArgs e)
		{
			
		}
		void MainFormLoad(object sender, EventArgs e)
		{
	
		}
		void BtnSalirClick(object sender, EventArgs e)
		{
			this.Close(); //Salir//
		}
		void BtnCalcularClick(object sender, EventArgs e)
		{
	this.TxtSuma.Text = (this.v1.Value + this.v2.Value + this.v3.Value + this.v4.Value).ToString();
	this.TxtResta.Text = (Convert.ToDecimal(this.TxtSuma.Text) - this.v4.Value).ToString();
	this.listBoxResultado.Items.Clear(); //para que el historial no se repita
	this.listBoxResultado.Items.Add("Valor 1:" + this.v1.Value);
	this.listBoxResultado.Items.Add("Valor 2:" +this.v2.Value);
	this.listBoxResultado.Items.Add("Valor 3:" +this.v3.Value);
	this.listBoxResultado.Items.Add("Valor 4:" +this.v4.Value);
	this.listBoxResultado.Items.Add("Suma:" +this.TxtSuma.Text);
	this.listBoxResultado.Items.Add("Resta:" +this.TxtResta.Text);
	//Historial o agregar un item usado//
		}
		void BtnLimpiarClick(object sender, EventArgs e)
		{
			this.v1.Value= 0; //Refrescar//
			this.v2.Value= 0;
			this.v3.Value= 0;
			this.v4.Value= 0;
			this.TxtSuma.Text= "0,0";
			this.TxtResta.Text= "0,0";
			this.listBoxResultado.Items.Clear();//para que el historial se limpie
		}
		void ListBoxResultadoSelectedIndexChanged(object sender, EventArgs e)
		{
	
		}
		void Panel1Paint(object sender, PaintEventArgs e)
		{
	
		}
		void Button1Click(object sender, EventArgs e)
		{
	this.Close(); //Salir//
		}
		
	}
}
