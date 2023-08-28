/*
 * Creado por SharpDevelop.
 * Usuario: SENA
 * Fecha: 27/04/2023
 * Hora: 9:43 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Suma3
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.NumericUpDown valor1;
		private System.Windows.Forms.NumericUpDown valor3;
		private System.Windows.Forms.NumericUpDown valor2;
		private System.Windows.Forms.Button calcular;
		private System.Windows.Forms.TextBox textresult;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.valor1 = new System.Windows.Forms.NumericUpDown();
			this.valor3 = new System.Windows.Forms.NumericUpDown();
			this.valor2 = new System.Windows.Forms.NumericUpDown();
			this.calcular = new System.Windows.Forms.Button();
			this.textresult = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.valor1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.valor3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.valor2)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(13, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Valor 1";
			this.label1.Click += new System.EventHandler(this.Label1Click);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(13, 111);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Valor 3";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(13, 61);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "Valor 2";
			// 
			// valor1
			// 
			this.valor1.DecimalPlaces = 1;
			this.valor1.Location = new System.Drawing.Point(13, 30);
			this.valor1.Name = "valor1";
			this.valor1.Size = new System.Drawing.Size(120, 20);
			this.valor1.TabIndex = 3;
			// 
			// valor3
			// 
			this.valor3.DecimalPlaces = 1;
			this.valor3.Location = new System.Drawing.Point(13, 132);
			this.valor3.Name = "valor3";
			this.valor3.Size = new System.Drawing.Size(120, 20);
			this.valor3.TabIndex = 4;
			// 
			// valor2
			// 
			this.valor2.DecimalPlaces = 1;
			this.valor2.Location = new System.Drawing.Point(13, 83);
			this.valor2.Name = "valor2";
			this.valor2.Size = new System.Drawing.Size(120, 20);
			this.valor2.TabIndex = 5;
			// 
			// calcular
			// 
			this.calcular.Location = new System.Drawing.Point(13, 209);
			this.calcular.Name = "calcular";
			this.calcular.Size = new System.Drawing.Size(75, 23);
			this.calcular.TabIndex = 6;
			this.calcular.Text = "Calcular";
			this.calcular.UseVisualStyleBackColor = true;
			this.calcular.Click += new System.EventHandler(this.CalcularClick);
			// 
			// textresult
			// 
			this.textresult.Enabled = false;
			this.textresult.Location = new System.Drawing.Point(13, 169);
			this.textresult.Name = "textresult";
			this.textresult.Size = new System.Drawing.Size(100, 20);
			this.textresult.TabIndex = 7;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.textresult);
			this.Controls.Add(this.calcular);
			this.Controls.Add(this.valor2);
			this.Controls.Add(this.valor3);
			this.Controls.Add(this.valor1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Suma3";
			((System.ComponentModel.ISupportInitialize)(this.valor1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.valor3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.valor2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
