/*
 * Created by SharpDevelop.
 * User: SENA
 * Date: 27/04/2023
 * Time: 8:02 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace AreaTriangulo
{
	partial class MainAreaTriangulo
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.NumericUpDown NumericBase;
		private System.Windows.Forms.NumericUpDown NumericAltura;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox TextArea;
		
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
			this.NumericBase = new System.Windows.Forms.NumericUpDown();
			this.NumericAltura = new System.Windows.Forms.NumericUpDown();
			this.button1 = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.TextArea = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.NumericBase)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.NumericAltura)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(13, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(193, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Escribe El Valor De La Base";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(13, 76);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(193, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Escribe El Valor De El Area";
			// 
			// NumericBase
			// 
			this.NumericBase.DecimalPlaces = 1;
			this.NumericBase.Location = new System.Drawing.Point(13, 40);
			this.NumericBase.Name = "NumericBase";
			this.NumericBase.Size = new System.Drawing.Size(120, 20);
			this.NumericBase.TabIndex = 2;
			// 
			// NumericAltura
			// 
			this.NumericAltura.DecimalPlaces = 1;
			this.NumericAltura.Location = new System.Drawing.Point(13, 103);
			this.NumericAltura.Name = "NumericAltura";
			this.NumericAltura.Size = new System.Drawing.Size(120, 20);
			this.NumericAltura.TabIndex = 3;
			// 
			// button1
			// 
			this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button1.Location = new System.Drawing.Point(12, 182);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 4;
			this.button1.Text = "Calcular";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(13, 140);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(74, 23);
			this.label3.TabIndex = 5;
			this.label3.Text = "Resultado:";
			this.label3.Click += new System.EventHandler(this.Label3Click);
			// 
			// TextArea
			// 
			this.TextArea.Enabled = false;
			this.TextArea.Location = new System.Drawing.Point(95, 139);
			this.TextArea.Name = "TextArea";
			this.TextArea.Size = new System.Drawing.Size(77, 20);
			this.TextArea.TabIndex = 6;
			// 
			// MainAreaTriangulo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.TextArea);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.NumericAltura);
			this.Controls.Add(this.NumericBase);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainAreaTriangulo";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Area Del Triangulo";
			this.Load += new System.EventHandler(this.MainFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.NumericBase)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.NumericAltura)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
