//INSTANT C# NOTE: Formerly VB project-level imports:
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.Linq;
using System.Xml.Linq;

using MySql.Data;

namespace BusinessApp
{
	[Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
	public partial class cashier : System.Windows.Forms.Form
	{
		//Form overrides dispose to clean up the component list.
		[System.Diagnostics.DebuggerNonUserCode()]
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing && components != null)
				{
					components.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		//Required by the Windows Form Designer
		private System.ComponentModel.IContainer components;

		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.  
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
			this.Label1 = new System.Windows.Forms.Label();
			this.txtcashiername = new System.Windows.Forms.TextBox();
			this.lblpassword = new System.Windows.Forms.Label();
			this.txtcashierpassword = new System.Windows.Forms.TextBox();
			this.Button1 = new System.Windows.Forms.Button();
			this.PictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)this.PictureBox1).BeginInit();
			this.SuspendLayout();
			//
			//Label1
			//
			this.Label1.AutoSize = true;
			this.Label1.Location = new System.Drawing.Point(24, 30);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(73, 13);
			this.Label1.TabIndex = 0;
			this.Label1.Text = "Cashier Name";
			//
			//txtcashiername
			//
			this.txtcashiername.Location = new System.Drawing.Point(108, 30);
			this.txtcashiername.Name = "txtcashiername";
			this.txtcashiername.Size = new System.Drawing.Size(143, 20);
			this.txtcashiername.TabIndex = 1;
			//
			//lblpassword
			//
			this.lblpassword.AutoSize = true;
			this.lblpassword.Location = new System.Drawing.Point(44, 83);
			this.lblpassword.Name = "lblpassword";
			this.lblpassword.Size = new System.Drawing.Size(53, 13);
			this.lblpassword.TabIndex = 2;
			this.lblpassword.Text = "Password";
			//
			//txtcashierpassword
			//
			this.txtcashierpassword.Location = new System.Drawing.Point(108, 76);
			this.txtcashierpassword.Name = "txtcashierpassword";
			this.txtcashierpassword.PasswordChar = (char)42;
			this.txtcashierpassword.Size = new System.Drawing.Size(145, 20);
			this.txtcashierpassword.TabIndex = 3;
			//
			//Button1
			//
			this.Button1.Cursor = System.Windows.Forms.Cursors.Default;
			this.Button1.Location = new System.Drawing.Point(275, 30);
			this.Button1.Name = "Button1";
			this.Button1.Size = new System.Drawing.Size(200, 66);
			this.Button1.TabIndex = 4;
			this.Button1.Text = "Login";
			this.Button1.UseVisualStyleBackColor = true;
			//
			//PictureBox1
			//
			this.PictureBox1.Image = BusinessApp.Properties.Resources.key3;
			this.PictureBox1.Location = new System.Drawing.Point(47, 102);
			this.PictureBox1.Name = "PictureBox1";
			this.PictureBox1.Size = new System.Drawing.Size(152, 105);
			this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.PictureBox1.TabIndex = 5;
			this.PictureBox1.TabStop = false;
			//
			//cashier
			//
			this.AcceptButton = this.Button1;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6.0F, 13.0F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(487, 216);
			this.Controls.Add(this.PictureBox1);
			this.Controls.Add(this.Button1);
			this.Controls.Add(this.txtcashierpassword);
			this.Controls.Add(this.lblpassword);
			this.Controls.Add(this.txtcashiername);
			this.Controls.Add(this.Label1);
			this.Name = "cashier";
			this.Text = "cashier";
			((System.ComponentModel.ISupportInitialize)this.PictureBox1).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

//INSTANT C# NOTE: Converted design-time event handler wireups:
			lblpassword.Click += new System.EventHandler(lblpassword_Click);
			txtcashierpassword.TextChanged += new System.EventHandler(txtcashierpassword_TextChanged);
			Button1.Click += new System.EventHandler(Button1_Click);
			base.Load += new System.EventHandler(cashier_Load);
			PictureBox1.Click += new System.EventHandler(PictureBox1_Click);
			Label1.Click += new System.EventHandler(Label1_Click);
			txtcashiername.TextChanged += new System.EventHandler(txtcashiername_TextChanged);
		}
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.TextBox txtcashiername;
		internal System.Windows.Forms.Label lblpassword;
		internal System.Windows.Forms.TextBox txtcashierpassword;
		internal System.Windows.Forms.Button Button1;
		internal System.Windows.Forms.PictureBox PictureBox1;
	}

}