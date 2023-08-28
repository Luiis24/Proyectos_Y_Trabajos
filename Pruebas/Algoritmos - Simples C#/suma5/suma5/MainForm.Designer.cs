/*
 * Creado por SharpDevelop.
 * Usuario: SENA
 * Fecha: 28/04/2023
 * Hora: 7:13 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace suma5
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
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.NumericUpDown v1;
		private System.Windows.Forms.NumericUpDown v2;
		private System.Windows.Forms.NumericUpDown v3;
		private System.Windows.Forms.NumericUpDown v4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox TxtSuma;
		private System.Windows.Forms.TextBox TxtResta;
		private System.Windows.Forms.Button BtnCalcular;
		private System.Windows.Forms.Button BtnLimpiar;
		private System.Windows.Forms.Button BtnSalir;
		private System.Windows.Forms.ListBox listBoxResultado;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button BtnCerrar;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.Button button1;
		
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.v1 = new System.Windows.Forms.NumericUpDown();
			this.v2 = new System.Windows.Forms.NumericUpDown();
			this.v3 = new System.Windows.Forms.NumericUpDown();
			this.v4 = new System.Windows.Forms.NumericUpDown();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.TxtSuma = new System.Windows.Forms.TextBox();
			this.TxtResta = new System.Windows.Forms.TextBox();
			this.BtnCalcular = new System.Windows.Forms.Button();
			this.BtnLimpiar = new System.Windows.Forms.Button();
			this.BtnSalir = new System.Windows.Forms.Button();
			this.listBoxResultado = new System.Windows.Forms.ListBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.button1 = new System.Windows.Forms.Button();
			this.BtnCerrar = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			((System.ComponentModel.ISupportInitialize)(this.v1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.v2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.v3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.v4)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(68, 84);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Valor 1:";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(68, 111);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Valor 2:";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(68, 138);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "Valor 3:";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(68, 165);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 3;
			this.label4.Text = "Valor 4:";
			// 
			// v1
			// 
			this.v1.DecimalPlaces = 1;
			this.v1.Location = new System.Drawing.Point(129, 84);
			this.v1.Name = "v1";
			this.v1.Size = new System.Drawing.Size(120, 20);
			this.v1.TabIndex = 5;
			// 
			// v2
			// 
			this.v2.DecimalPlaces = 1;
			this.v2.Location = new System.Drawing.Point(129, 109);
			this.v2.Name = "v2";
			this.v2.Size = new System.Drawing.Size(120, 20);
			this.v2.TabIndex = 6;
			// 
			// v3
			// 
			this.v3.DecimalPlaces = 1;
			this.v3.Location = new System.Drawing.Point(129, 136);
			this.v3.Name = "v3";
			this.v3.Size = new System.Drawing.Size(120, 20);
			this.v3.TabIndex = 7;
			// 
			// v4
			// 
			this.v4.DecimalPlaces = 1;
			this.v4.Location = new System.Drawing.Point(129, 163);
			this.v4.Name = "v4";
			this.v4.Size = new System.Drawing.Size(120, 20);
			this.v4.TabIndex = 8;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(68, 200);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 9;
			this.label5.Text = "Suma:";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(68, 238);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 23);
			this.label6.TabIndex = 10;
			this.label6.Text = "Resta:";
			// 
			// TxtSuma
			// 
			this.TxtSuma.Enabled = false;
			this.TxtSuma.Location = new System.Drawing.Point(129, 197);
			this.TxtSuma.Name = "TxtSuma";
			this.TxtSuma.Size = new System.Drawing.Size(120, 20);
			this.TxtSuma.TabIndex = 11;
			this.TxtSuma.Text = "0,0";
			// 
			// TxtResta
			// 
			this.TxtResta.Enabled = false;
			this.TxtResta.Location = new System.Drawing.Point(129, 238);
			this.TxtResta.Name = "TxtResta";
			this.TxtResta.Size = new System.Drawing.Size(120, 20);
			this.TxtResta.TabIndex = 12;
			this.TxtResta.Text = "0,0";
			// 
			// BtnCalcular
			// 
			this.BtnCalcular.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BtnCalcular.FlatAppearance.BorderSize = 0;
			this.BtnCalcular.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
			this.BtnCalcular.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.BtnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnCalcular.Location = new System.Drawing.Point(92, 319);
			this.BtnCalcular.Name = "BtnCalcular";
			this.BtnCalcular.Size = new System.Drawing.Size(83, 36);
			this.BtnCalcular.TabIndex = 13;
			this.BtnCalcular.Text = "Calcular";
			this.BtnCalcular.UseVisualStyleBackColor = true;
			this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcularClick);
			// 
			// BtnLimpiar
			// 
			this.BtnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BtnLimpiar.FlatAppearance.BorderSize = 0;
			this.BtnLimpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
			this.BtnLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.BtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnLimpiar.Location = new System.Drawing.Point(217, 319);
			this.BtnLimpiar.Name = "BtnLimpiar";
			this.BtnLimpiar.Size = new System.Drawing.Size(83, 36);
			this.BtnLimpiar.TabIndex = 14;
			this.BtnLimpiar.Text = "Limpiar";
			this.BtnLimpiar.UseVisualStyleBackColor = true;
			this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiarClick);
			// 
			// BtnSalir
			// 
			this.BtnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BtnSalir.FlatAppearance.BorderSize = 0;
			this.BtnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.BtnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnSalir.Location = new System.Drawing.Point(341, 319);
			this.BtnSalir.Name = "BtnSalir";
			this.BtnSalir.Size = new System.Drawing.Size(83, 36);
			this.BtnSalir.TabIndex = 15;
			this.BtnSalir.Text = "Salir";
			this.BtnSalir.UseVisualStyleBackColor = true;
			this.BtnSalir.Click += new System.EventHandler(this.BtnSalirClick);
			// 
			// listBoxResultado
			// 
			this.listBoxResultado.FormattingEnabled = true;
			this.listBoxResultado.Location = new System.Drawing.Point(334, 84);
			this.listBoxResultado.Name = "listBoxResultado";
			this.listBoxResultado.Size = new System.Drawing.Size(173, 173);
			this.listBoxResultado.TabIndex = 16;
			this.listBoxResultado.SelectedIndexChanged += new System.EventHandler(this.ListBoxResultadoSelectedIndexChanged);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.SpringGreen;
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.BtnCerrar);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(556, 31);
			this.panel1.TabIndex = 17;
			this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1Paint);
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
			this.button1.Location = new System.Drawing.Point(504, 2);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(21, 27);
			this.button1.TabIndex = 2;
			this.toolTip1.SetToolTip(this.button1, "Acerca De..");
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// BtnCerrar
			// 
			this.BtnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BtnCerrar.FlatAppearance.BorderSize = 0;
			this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("BtnCerrar.Image")));
			this.BtnCerrar.Location = new System.Drawing.Point(526, 2);
			this.BtnCerrar.Name = "BtnCerrar";
			this.BtnCerrar.Size = new System.Drawing.Size(27, 26);
			this.BtnCerrar.TabIndex = 1;
			this.toolTip1.SetToolTip(this.BtnCerrar, "Cerrar");
			this.BtnCerrar.UseVisualStyleBackColor = true;
			this.BtnCerrar.Click += new System.EventHandler(this.Button1Click);
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.White;
			this.label7.Location = new System.Drawing.Point(4, 4);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(179, 23);
			this.label7.TabIndex = 0;
			this.label7.Text = "Por Cualquier Titulo";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(556, 403);
			this.ControlBox = false;
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.listBoxResultado);
			this.Controls.Add(this.BtnSalir);
			this.Controls.Add(this.BtnLimpiar);
			this.Controls.Add(this.BtnCalcular);
			this.Controls.Add(this.TxtResta);
			this.Controls.Add(this.TxtSuma);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.v4);
			this.Controls.Add(this.v3);
			this.Controls.Add(this.v2);
			this.Controls.Add(this.v1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "eje3";
			this.Load += new System.EventHandler(this.MainFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.v1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.v2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.v3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.v4)).EndInit();
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
