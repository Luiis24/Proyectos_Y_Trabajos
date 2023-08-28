/*
 * Created by SharpDevelop.
 * User: SENA
 * Date: 4/05/2023
 * Time: 9:53 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace AprendiendoIngles
{
	partial class Vocales
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vocales));
			this.panel1 = new System.Windows.Forms.Panel();
			this.BtnU = new System.Windows.Forms.Button();
			this.BtnO = new System.Windows.Forms.Button();
			this.Btni = new System.Windows.Forms.Button();
			this.BtnE = new System.Windows.Forms.Button();
			this.BtnA = new System.Windows.Forms.Button();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.button1 = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.panel1.BackColor = System.Drawing.Color.White;
			this.panel1.Controls.Add(this.BtnU);
			this.panel1.Controls.Add(this.BtnO);
			this.panel1.Controls.Add(this.Btni);
			this.panel1.Controls.Add(this.BtnE);
			this.panel1.Controls.Add(this.BtnA);
			this.panel1.Location = new System.Drawing.Point(82, 66);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(585, 429);
			this.panel1.TabIndex = 0;
			// 
			// BtnU
			// 
			this.BtnU.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BtnU.FlatAppearance.BorderSize = 0;
			this.BtnU.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.BtnU.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.BtnU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnU.Image = ((System.Drawing.Image)(resources.GetObject("BtnU.Image")));
			this.BtnU.Location = new System.Drawing.Point(425, 242);
			this.BtnU.Name = "BtnU";
			this.BtnU.Size = new System.Drawing.Size(157, 184);
			this.BtnU.TabIndex = 12;
			this.BtnU.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.toolTip1.SetToolTip(this.BtnU, "iU");
			this.BtnU.UseVisualStyleBackColor = true;
			this.BtnU.Click += new System.EventHandler(this.BtnUClick);
			// 
			// BtnO
			// 
			this.BtnO.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BtnO.FlatAppearance.BorderSize = 0;
			this.BtnO.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.BtnO.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.BtnO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnO.Image = ((System.Drawing.Image)(resources.GetObject("BtnO.Image")));
			this.BtnO.Location = new System.Drawing.Point(3, 242);
			this.BtnO.Name = "BtnO";
			this.BtnO.Size = new System.Drawing.Size(157, 184);
			this.BtnO.TabIndex = 11;
			this.BtnO.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.toolTip1.SetToolTip(this.BtnO, "OU");
			this.BtnO.UseVisualStyleBackColor = true;
			this.BtnO.Click += new System.EventHandler(this.BtnOClick);
			// 
			// Btni
			// 
			this.Btni.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Btni.FlatAppearance.BorderSize = 0;
			this.Btni.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.Btni.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.Btni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Btni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Btni.Image = ((System.Drawing.Image)(resources.GetObject("Btni.Image")));
			this.Btni.Location = new System.Drawing.Point(425, 3);
			this.Btni.Name = "Btni";
			this.Btni.Size = new System.Drawing.Size(157, 184);
			this.Btni.TabIndex = 10;
			this.Btni.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.toolTip1.SetToolTip(this.Btni, "Ai");
			this.Btni.UseVisualStyleBackColor = true;
			this.Btni.Click += new System.EventHandler(this.BtniClick);
			// 
			// BtnE
			// 
			this.BtnE.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BtnE.FlatAppearance.BorderSize = 0;
			this.BtnE.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.BtnE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.BtnE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnE.Image = ((System.Drawing.Image)(resources.GetObject("BtnE.Image")));
			this.BtnE.Location = new System.Drawing.Point(204, 117);
			this.BtnE.Name = "BtnE";
			this.BtnE.Size = new System.Drawing.Size(157, 184);
			this.BtnE.TabIndex = 9;
			this.BtnE.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.toolTip1.SetToolTip(this.BtnE, "i");
			this.BtnE.UseVisualStyleBackColor = true;
			this.BtnE.Click += new System.EventHandler(this.BtnEClick);
			// 
			// BtnA
			// 
			this.BtnA.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BtnA.FlatAppearance.BorderSize = 0;
			this.BtnA.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.BtnA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.BtnA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnA.Image = ((System.Drawing.Image)(resources.GetObject("BtnA.Image")));
			this.BtnA.Location = new System.Drawing.Point(3, 3);
			this.BtnA.Name = "BtnA";
			this.BtnA.Size = new System.Drawing.Size(157, 184);
			this.BtnA.TabIndex = 8;
			this.BtnA.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.toolTip1.SetToolTip(this.BtnA, "Ei");
			this.BtnA.UseVisualStyleBackColor = true;
			this.BtnA.Click += new System.EventHandler(this.BtnAClick);
			// 
			// button1
			// 
			this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
			this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
			this.button1.Location = new System.Drawing.Point(12, 12);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(67, 66);
			this.button1.TabIndex = 14;
			this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.toolTip1.SetToolTip(this.button1, "CLOSE");
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// Vocales
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(749, 561);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.panel1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Vocales";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Vocales";
			this.Load += new System.EventHandler(this.VocalesLoad);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button BtnU;
		private System.Windows.Forms.Button BtnO;
		private System.Windows.Forms.Button Btni;
		private System.Windows.Forms.Button BtnE;
		private System.Windows.Forms.Button BtnA;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.Button button1;
	}
}
