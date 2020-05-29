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
	public partial class Discount_Approval : System.Windows.Forms.Form
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
			this.txtadminpassword = new System.Windows.Forms.TextBox();
			this.Button1 = new System.Windows.Forms.Button();
			this.txtcashierN = new System.Windows.Forms.TextBox();
			this.Label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			//
			//Label1
			//
			this.Label1.AutoSize = true;
			this.Label1.Location = new System.Drawing.Point(13, 66);
			this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(438, 40);
			this.Label1.TabIndex = 0;
			this.Label1.Text = "Administrator, If You Are There, Please Enter Your Password" + "\r" + "\n" + "And Press Enter";
			this.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			//
			//txtadminpassword
			//
			this.txtadminpassword.Location = new System.Drawing.Point(34, 128);
			this.txtadminpassword.Name = "txtadminpassword";
			this.txtadminpassword.PasswordChar = (char)35;
			this.txtadminpassword.Size = new System.Drawing.Size(160, 26);
			this.txtadminpassword.TabIndex = 1;
			//
			//Button1
			//
			this.Button1.Location = new System.Drawing.Point(210, 121);
			this.Button1.Name = "Button1";
			this.Button1.Size = new System.Drawing.Size(130, 33);
			this.Button1.TabIndex = 2;
			this.Button1.Text = "Enter";
			this.Button1.UseVisualStyleBackColor = true;
			//
			//txtcashierN
			//
			this.txtcashierN.Location = new System.Drawing.Point(171, 14);
			this.txtcashierN.Name = "txtcashierN";
			this.txtcashierN.Size = new System.Drawing.Size(125, 26);
			this.txtcashierN.TabIndex = 3;
			//
			//Label2
			//
			this.Label2.AutoSize = true;
			this.Label2.Location = new System.Drawing.Point(45, 20);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(120, 20);
			this.Label2.TabIndex = 4;
			this.Label2.Text = "Current Cashier";
			//
			//Discount_Approval
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(9.0F, 20.0F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(448, 193);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.txtcashierN);
			this.Controls.Add(this.Button1);
			this.Controls.Add(this.txtadminpassword);
			this.Controls.Add(this.Label1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "Discount_Approval";
			this.Text = "Discount_Approval";
			this.ResumeLayout(false);
			this.PerformLayout();

//INSTANT C# NOTE: Converted design-time event handler wireups:
			Button1.Click += new System.EventHandler(Button1_Click);
			base.Load += new System.EventHandler(Discount_Approval_Load);
		}
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.TextBox txtadminpassword;
		internal System.Windows.Forms.Button Button1;
		internal System.Windows.Forms.TextBox txtcashierN;
		internal System.Windows.Forms.Label Label2;
	}

}