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
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(31, 46);
            this.Label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(109, 20);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Cashier Name";
            this.Label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // txtcashiername
            // 
            this.txtcashiername.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtcashiername.Location = new System.Drawing.Point(157, 46);
            this.txtcashiername.Margin = new System.Windows.Forms.Padding(5);
            this.txtcashiername.Name = "txtcashiername";
            this.txtcashiername.Size = new System.Drawing.Size(213, 26);
            this.txtcashiername.TabIndex = 1;
            this.txtcashiername.TextChanged += new System.EventHandler(this.txtcashiername_TextChanged);
            // 
            // lblpassword
            // 
            this.lblpassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblpassword.AutoSize = true;
            this.lblpassword.Location = new System.Drawing.Point(61, 127);
            this.lblpassword.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(78, 20);
            this.lblpassword.TabIndex = 2;
            this.lblpassword.Text = "Password";
            this.lblpassword.Click += new System.EventHandler(this.lblpassword_Click);
            // 
            // txtcashierpassword
            // 
            this.txtcashierpassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtcashierpassword.Location = new System.Drawing.Point(157, 117);
            this.txtcashierpassword.Margin = new System.Windows.Forms.Padding(5);
            this.txtcashierpassword.Name = "txtcashierpassword";
            this.txtcashierpassword.PasswordChar = '*';
            this.txtcashierpassword.Size = new System.Drawing.Size(216, 26);
            this.txtcashierpassword.TabIndex = 3;
            this.txtcashierpassword.TextChanged += new System.EventHandler(this.txtcashierpassword_TextChanged);
            // 
            // Button1
            // 
            this.Button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.Button1.Location = new System.Drawing.Point(407, 46);
            this.Button1.Margin = new System.Windows.Forms.Padding(5);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(300, 102);
            this.Button1.TabIndex = 4;
            this.Button1.Text = "Login";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // PictureBox1
            // 
            this.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PictureBox1.Image = global::BusinessApp.Properties.Resources.key3;
            this.PictureBox1.Location = new System.Drawing.Point(65, 157);
            this.PictureBox1.Margin = new System.Windows.Forms.Padding(5);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(228, 162);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox1.TabIndex = 5;
            this.PictureBox1.TabStop = false;
            this.PictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // cashier
            // 
            this.AcceptButton = this.Button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 325);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.txtcashierpassword);
            this.Controls.Add(this.lblpassword);
            this.Controls.Add(this.txtcashiername);
            this.Controls.Add(this.Label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximumSize = new System.Drawing.Size(742, 364);
            this.MinimumSize = new System.Drawing.Size(742, 364);
            this.Name = "cashier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "cashier";
            this.Load += new System.EventHandler(this.cashier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.TextBox txtcashiername;
		internal System.Windows.Forms.Label lblpassword;
		internal System.Windows.Forms.TextBox txtcashierpassword;
		internal System.Windows.Forms.Button Button1;
		internal System.Windows.Forms.PictureBox PictureBox1;
	}

}