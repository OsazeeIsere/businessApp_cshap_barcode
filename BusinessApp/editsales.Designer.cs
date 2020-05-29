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
	public partial class editsales : System.Windows.Forms.Form
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
			this.txttransactionid = new System.Windows.Forms.TextBox();
			this.Label2 = new System.Windows.Forms.Label();
			this.Button2 = new System.Windows.Forms.Button();
			this.Button1 = new System.Windows.Forms.Button();
			this.txtitemsold = new System.Windows.Forms.TextBox();
			this.Label1 = new System.Windows.Forms.Label();
			this.txtcashiername1 = new System.Windows.Forms.TextBox();
			this.Label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			//
			//txttransactionid
			//
			this.txttransactionid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.txttransactionid.Location = new System.Drawing.Point(192, 106);
			this.txttransactionid.Name = "txttransactionid";
			this.txttransactionid.Size = new System.Drawing.Size(96, 26);
			this.txttransactionid.TabIndex = 12;
			//
			//Label2
			//
			this.Label2.AutoSize = true;
			this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label2.Location = new System.Drawing.Point(18, 111);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(168, 20);
			this.Label2.TabIndex = 11;
			this.Label2.Text = "With Transaction ID";
			//
			//Button2
			//
			this.Button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Button2.Location = new System.Drawing.Point(343, 161);
			this.Button2.Name = "Button2";
			this.Button2.Size = new System.Drawing.Size(107, 39);
			this.Button2.TabIndex = 10;
			this.Button2.Text = "NO";
			this.Button2.UseVisualStyleBackColor = true;
			//
			//Button1
			//
			this.Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Button1.Location = new System.Drawing.Point(25, 161);
			this.Button1.Name = "Button1";
			this.Button1.Size = new System.Drawing.Size(120, 43);
			this.Button1.TabIndex = 9;
			this.Button1.Text = "YES";
			this.Button1.UseVisualStyleBackColor = true;
			//
			//txtitemsold
			//
			this.txtitemsold.Location = new System.Drawing.Point(12, 80);
			this.txtitemsold.Name = "txtitemsold";
			this.txtitemsold.Size = new System.Drawing.Size(468, 20);
			this.txtitemsold.TabIndex = 8;
			//
			//Label1
			//
			this.Label1.AutoSize = true;
			this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label1.Location = new System.Drawing.Point(14, 53);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(426, 20);
			this.Label1.TabIndex = 7;
			this.Label1.Text = "Are You Sure You Want To Delet This Transaction? ";
			//
			//txtcashiername1
			//
			this.txtcashiername1.Location = new System.Drawing.Point(58, 5);
			this.txtcashiername1.Name = "txtcashiername1";
			this.txtcashiername1.Size = new System.Drawing.Size(107, 20);
			this.txtcashiername1.TabIndex = 20;
			//
			//Label3
			//
			this.Label3.AutoSize = true;
			this.Label3.Location = new System.Drawing.Point(7, 8);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(45, 13);
			this.Label3.TabIndex = 19;
			this.Label3.Text = "Cashier:";
			//
			//editsales
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6.0F, 13.0F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(489, 221);
			this.Controls.Add(this.txtcashiername1);
			this.Controls.Add(this.Label3);
			this.Controls.Add(this.txttransactionid);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.Button2);
			this.Controls.Add(this.Button1);
			this.Controls.Add(this.txtitemsold);
			this.Controls.Add(this.Label1);
			this.Name = "editsales";
			this.Text = "editsales";
			this.ResumeLayout(false);
			this.PerformLayout();

//INSTANT C# NOTE: Converted design-time event handler wireups:
			Button1.Click += new System.EventHandler(Button1_Click);
			Button2.Click += new System.EventHandler(Button2_Click);
			base.Load += new System.EventHandler(editsales_Load);
		}
		internal System.Windows.Forms.TextBox txttransactionid;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.Button Button2;
		internal System.Windows.Forms.Button Button1;
		internal System.Windows.Forms.TextBox txtitemsold;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.TextBox txtcashiername1;
		internal System.Windows.Forms.Label Label3;
	}

}