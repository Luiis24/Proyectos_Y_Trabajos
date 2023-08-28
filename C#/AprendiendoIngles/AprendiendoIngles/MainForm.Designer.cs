/*
 * Created by SharpDevelop.
 * User: SENA
 * Date: 4/05/2023
 * Time: 9:21 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace AprendiendoIngles
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button BtnVocales;
		private System.Windows.Forms.Button BtnMeses;
		private System.Windows.Forms.Button BtnDias;
		private System.Windows.Forms.Button BtnNumeros;
		private System.Windows.Forms.Button BtnFamilia;
		private System.Windows.Forms.Button BtnColores;
		private System.Windows.Forms.Button BtnAnimales;
		private System.Windows.Forms.Button BtnFiguras;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label1;
		
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.BtnAnimales = new System.Windows.Forms.Button();
			this.BtnFiguras = new System.Windows.Forms.Button();
			this.BtnMeses = new System.Windows.Forms.Button();
			this.BtnDias = new System.Windows.Forms.Button();
			this.BtnNumeros = new System.Windows.Forms.Button();
			this.BtnFamilia = new System.Windows.Forms.Button();
			this.BtnColores = new System.Windows.Forms.Button();
			this.BtnVocales = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.panel1.Controls.Add(this.BtnAnimales);
			this.panel1.Controls.Add(this.BtnFiguras);
			this.panel1.Controls.Add(this.BtnMeses);
			this.panel1.Controls.Add(this.BtnDias);
			this.panel1.Controls.Add(this.BtnNumeros);
			this.panel1.Controls.Add(this.BtnFamilia);
			this.panel1.Controls.Add(this.BtnColores);
			this.panel1.Controls.Add(this.BtnVocales);
			this.panel1.Location = new System.Drawing.Point(100, 131);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(791, 405);
			this.panel1.TabIndex = 0;
			this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1Paint);
			// 
			// BtnAnimales
			// 
			this.BtnAnimales.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BtnAnimales.FlatAppearance.BorderSize = 0;
			this.BtnAnimales.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.BtnAnimales.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.BtnAnimales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnAnimales.Font = new System.Drawing.Font("Comic Sans MS", 12F);
			this.BtnAnimales.Image = ((System.Drawing.Image)(resources.GetObject("BtnAnimales.Image")));
			this.BtnAnimales.Location = new System.Drawing.Point(40, 16);
			this.BtnAnimales.Name = "BtnAnimales";
			this.BtnAnimales.Size = new System.Drawing.Size(157, 184);
			this.BtnAnimales.TabIndex = 7;
			this.BtnAnimales.Text = "Animals";
			this.BtnAnimales.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.toolTip1.SetToolTip(this.BtnAnimales, "Animales");
			this.BtnAnimales.UseVisualStyleBackColor = true;
			this.BtnAnimales.Click += new System.EventHandler(this.BtnAnimalesClick);
			// 
			// BtnFiguras
			// 
			this.BtnFiguras.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BtnFiguras.FlatAppearance.BorderSize = 0;
			this.BtnFiguras.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.BtnFiguras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.BtnFiguras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnFiguras.Font = new System.Drawing.Font("Comic Sans MS", 12F);
			this.BtnFiguras.Image = ((System.Drawing.Image)(resources.GetObject("BtnFiguras.Image")));
			this.BtnFiguras.Location = new System.Drawing.Point(40, 206);
			this.BtnFiguras.Name = "BtnFiguras";
			this.BtnFiguras.Size = new System.Drawing.Size(157, 177);
			this.BtnFiguras.TabIndex = 6;
			this.BtnFiguras.Text = "Figures";
			this.BtnFiguras.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.toolTip1.SetToolTip(this.BtnFiguras, "Figuras");
			this.BtnFiguras.UseVisualStyleBackColor = true;
			this.BtnFiguras.Click += new System.EventHandler(this.BtnFigurasClick);
			// 
			// BtnMeses
			// 
			this.BtnMeses.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BtnMeses.FlatAppearance.BorderSize = 0;
			this.BtnMeses.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.BtnMeses.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.BtnMeses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnMeses.Font = new System.Drawing.Font("Comic Sans MS", 12F);
			this.BtnMeses.Image = ((System.Drawing.Image)(resources.GetObject("BtnMeses.Image")));
			this.BtnMeses.Location = new System.Drawing.Point(448, 206);
			this.BtnMeses.Name = "BtnMeses";
			this.BtnMeses.Size = new System.Drawing.Size(142, 181);
			this.BtnMeses.TabIndex = 5;
			this.BtnMeses.Text = "Months";
			this.BtnMeses.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.toolTip1.SetToolTip(this.BtnMeses, "Meses");
			this.BtnMeses.UseVisualStyleBackColor = true;
			this.BtnMeses.Click += new System.EventHandler(this.BtnMesesClick);
			// 
			// BtnDias
			// 
			this.BtnDias.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BtnDias.FlatAppearance.BorderSize = 0;
			this.BtnDias.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.BtnDias.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.BtnDias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnDias.Font = new System.Drawing.Font("Comic Sans MS", 12F);
			this.BtnDias.Image = ((System.Drawing.Image)(resources.GetObject("BtnDias.Image")));
			this.BtnDias.Location = new System.Drawing.Point(448, 16);
			this.BtnDias.Name = "BtnDias";
			this.BtnDias.Size = new System.Drawing.Size(145, 184);
			this.BtnDias.TabIndex = 4;
			this.BtnDias.Text = "Days";
			this.BtnDias.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.toolTip1.SetToolTip(this.BtnDias, "Dias");
			this.BtnDias.UseVisualStyleBackColor = true;
			this.BtnDias.Click += new System.EventHandler(this.BtnDiasClick);
			// 
			// BtnNumeros
			// 
			this.BtnNumeros.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BtnNumeros.FlatAppearance.BorderSize = 0;
			this.BtnNumeros.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.BtnNumeros.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.BtnNumeros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnNumeros.Font = new System.Drawing.Font("Comic Sans MS", 12F);
			this.BtnNumeros.Image = ((System.Drawing.Image)(resources.GetObject("BtnNumeros.Image")));
			this.BtnNumeros.Location = new System.Drawing.Point(249, 206);
			this.BtnNumeros.Name = "BtnNumeros";
			this.BtnNumeros.Size = new System.Drawing.Size(155, 177);
			this.BtnNumeros.TabIndex = 3;
			this.BtnNumeros.Text = "Numbers";
			this.BtnNumeros.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.toolTip1.SetToolTip(this.BtnNumeros, "Numeros");
			this.BtnNumeros.UseVisualStyleBackColor = true;
			this.BtnNumeros.Click += new System.EventHandler(this.BtnNumerosClick);
			// 
			// BtnFamilia
			// 
			this.BtnFamilia.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BtnFamilia.FlatAppearance.BorderSize = 0;
			this.BtnFamilia.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.BtnFamilia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.BtnFamilia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnFamilia.Font = new System.Drawing.Font("Comic Sans MS", 12F);
			this.BtnFamilia.Image = ((System.Drawing.Image)(resources.GetObject("BtnFamilia.Image")));
			this.BtnFamilia.Location = new System.Drawing.Point(633, 16);
			this.BtnFamilia.Name = "BtnFamilia";
			this.BtnFamilia.Size = new System.Drawing.Size(143, 184);
			this.BtnFamilia.TabIndex = 2;
			this.BtnFamilia.Text = "Family";
			this.BtnFamilia.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.toolTip1.SetToolTip(this.BtnFamilia, "Familia");
			this.BtnFamilia.UseVisualStyleBackColor = true;
			this.BtnFamilia.Click += new System.EventHandler(this.BtnFamiliaClick);
			// 
			// BtnColores
			// 
			this.BtnColores.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BtnColores.FlatAppearance.BorderSize = 0;
			this.BtnColores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.BtnColores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.BtnColores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnColores.Font = new System.Drawing.Font("Comic Sans MS", 12F);
			this.BtnColores.Image = ((System.Drawing.Image)(resources.GetObject("BtnColores.Image")));
			this.BtnColores.Location = new System.Drawing.Point(249, 16);
			this.BtnColores.Name = "BtnColores";
			this.BtnColores.Size = new System.Drawing.Size(155, 184);
			this.BtnColores.TabIndex = 1;
			this.BtnColores.Text = "Colors";
			this.BtnColores.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.toolTip1.SetToolTip(this.BtnColores, "Colores");
			this.BtnColores.UseVisualStyleBackColor = true;
			this.BtnColores.Click += new System.EventHandler(this.BtnColoresClick);
			// 
			// BtnVocales
			// 
			this.BtnVocales.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BtnVocales.FlatAppearance.BorderSize = 0;
			this.BtnVocales.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.BtnVocales.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.BtnVocales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnVocales.Font = new System.Drawing.Font("Comic Sans MS", 12F);
			this.BtnVocales.Image = ((System.Drawing.Image)(resources.GetObject("BtnVocales.Image")));
			this.BtnVocales.Location = new System.Drawing.Point(633, 221);
			this.BtnVocales.Name = "BtnVocales";
			this.BtnVocales.Size = new System.Drawing.Size(143, 166);
			this.BtnVocales.TabIndex = 0;
			this.BtnVocales.Text = "Vocals";
			this.BtnVocales.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.toolTip1.SetToolTip(this.BtnVocales, "Vocales");
			this.BtnVocales.UseVisualStyleBackColor = true;
			this.BtnVocales.Click += new System.EventHandler(this.BtnVocalesClick);
			// 
			// panel2
			// 
			this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.panel2.Controls.Add(this.pictureBox1);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Location = new System.Drawing.Point(100, 72);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(791, 53);
			this.panel2.TabIndex = 1;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(124, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(578, 69);
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(209, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(323, 38);
			this.label1.TabIndex = 0;
			this.label1.Text = "LEARNING ENGLISH";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label1.Click += new System.EventHandler(this.Label1Click);
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
			this.button1.Location = new System.Drawing.Point(905, 503);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(71, 70);
			this.button1.TabIndex = 9;
			this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.toolTip1.SetToolTip(this.button1, "Acerca De...");
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(988, 621);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.Text = "AprendiendoIngles";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ToolTip toolTip1;
	}
}
