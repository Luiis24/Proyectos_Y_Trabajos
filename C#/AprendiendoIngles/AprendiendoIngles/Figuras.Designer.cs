﻿/*
 * Created by SharpDevelop.
 * User: SENA
 * Date: 4/05/2023
 * Time: 9:54 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace AprendiendoIngles
{
	partial class Figuras
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button BtnCirculo;
		private System.Windows.Forms.Button button12;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Figuras));
			this.panel1 = new System.Windows.Forms.Panel();
			this.button6 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.BtnCirculo = new System.Windows.Forms.Button();
			this.button12 = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.White;
			this.panel1.Controls.Add(this.button6);
			this.panel1.Controls.Add(this.button5);
			this.panel1.Controls.Add(this.button4);
			this.panel1.Controls.Add(this.button3);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.BtnCirculo);
			this.panel1.Location = new System.Drawing.Point(61, 37);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(577, 449);
			this.panel1.TabIndex = 0;
			// 
			// button6
			// 
			this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button6.FlatAppearance.BorderSize = 0;
			this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button6.Font = new System.Drawing.Font("Comic Sans MS", 12F);
			this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
			this.button6.Location = new System.Drawing.Point(14, 260);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(145, 173);
			this.button6.TabIndex = 14;
			this.button6.Text = "Rectangle";
			this.button6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.Button6Click);
			// 
			// button5
			// 
			this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button5.FlatAppearance.BorderSize = 0;
			this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button5.Font = new System.Drawing.Font("Comic Sans MS", 12F);
			this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
			this.button5.Location = new System.Drawing.Point(221, 19);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(145, 185);
			this.button5.TabIndex = 13;
			this.button5.Text = "Rombo";
			this.button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.Button5Click);
			// 
			// button4
			// 
			this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button4.FlatAppearance.BorderSize = 0;
			this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button4.Font = new System.Drawing.Font("Comic Sans MS", 12F);
			this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
			this.button4.Location = new System.Drawing.Point(409, 260);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(145, 186);
			this.button4.TabIndex = 12;
			this.button4.Text = "Triangle";
			this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.Button4Click);
			// 
			// button3
			// 
			this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button3.FlatAppearance.BorderSize = 0;
			this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.Font = new System.Drawing.Font("Comic Sans MS", 12F);
			this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
			this.button3.Location = new System.Drawing.Point(409, 19);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(145, 185);
			this.button3.TabIndex = 11;
			this.button3.Text = "Oval";
			this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// button1
			// 
			this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Comic Sans MS", 12F);
			this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
			this.button1.Location = new System.Drawing.Point(221, 259);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(145, 187);
			this.button1.TabIndex = 9;
			this.button1.Text = "Square";
			this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// BtnCirculo
			// 
			this.BtnCirculo.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BtnCirculo.FlatAppearance.BorderSize = 0;
			this.BtnCirculo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.BtnCirculo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.BtnCirculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnCirculo.Font = new System.Drawing.Font("Comic Sans MS", 12F);
			this.BtnCirculo.Image = ((System.Drawing.Image)(resources.GetObject("BtnCirculo.Image")));
			this.BtnCirculo.Location = new System.Drawing.Point(14, 19);
			this.BtnCirculo.Name = "BtnCirculo";
			this.BtnCirculo.Size = new System.Drawing.Size(145, 185);
			this.BtnCirculo.TabIndex = 8;
			this.BtnCirculo.Text = "Circle";
			this.BtnCirculo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.BtnCirculo.UseVisualStyleBackColor = true;
			this.BtnCirculo.Click += new System.EventHandler(this.BtnCirculoClick);
			// 
			// button12
			// 
			this.button12.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button12.FlatAppearance.BorderSize = 0;
			this.button12.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
			this.button12.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button12.Image = ((System.Drawing.Image)(resources.GetObject("button12.Image")));
			this.button12.Location = new System.Drawing.Point(12, 12);
			this.button12.Name = "button12";
			this.button12.Size = new System.Drawing.Size(67, 66);
			this.button12.TabIndex = 19;
			this.button12.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.button12.UseVisualStyleBackColor = true;
			this.button12.Click += new System.EventHandler(this.Button12Click);
			// 
			// Figuras
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(674, 516);
			this.Controls.Add(this.button12);
			this.Controls.Add(this.panel1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Figuras";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Figuras";
			this.Load += new System.EventHandler(this.FigurasLoad);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);
		}
	}
}
