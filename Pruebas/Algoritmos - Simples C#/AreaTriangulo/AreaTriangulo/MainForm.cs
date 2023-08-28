/*
 * Created by SharpDevelop.
 * User: SENA
 * Date: 27/04/2023
 * Time: 8:02 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace AreaTriangulo
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainAreaTriangulo : Form
	{
		public MainAreaTriangulo()
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
		void TextBox1TextChanged(object sender, EventArgs e)
		{
	
		}
		void Label3Click(object sender, EventArgs e)
		{
	
		}
		void Button1Click(object sender, EventArgs e)
		{
			this.TextArea.Text = ((this.NumericBase.Value * this.NumericAltura.Value)/2).ToString();
		}
	}
}
