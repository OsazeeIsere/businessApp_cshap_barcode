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
using Microsoft.Office.Interop.Excel;

namespace BusinessApp
{
	[Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
	public partial class action : System.Windows.Forms.Form
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
			this.Button1 = new System.Windows.Forms.Button();
			this.Button2 = new System.Windows.Forms.Button();
			this.Label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			//
			//Button1
			//
			this.Button1.Location = new System.Drawing.Point(27, 50);
			this.Button1.Name = "Button1";
			this.Button1.Size = new System.Drawing.Size(87, 32);
			this.Button1.TabIndex = 0;
			this.Button1.Text = "YES";
			this.Button1.UseVisualStyleBackColor = true;
			//
			//Button2
			//
			this.Button2.Location = new System.Drawing.Point(237, 50);
			this.Button2.Name = "Button2";
			this.Button2.Size = new System.Drawing.Size(75, 32);
			this.Button2.TabIndex = 1;
			this.Button2.Text = "NO";
			this.Button2.UseVisualStyleBackColor = true;
			//
			//Label1
			//
			this.Label1.AutoSize = true;
			this.Label1.Location = new System.Drawing.Point(37, 23);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(266, 13);
			this.Label1.TabIndex = 2;
			this.Label1.Text = "Do You Want To clear Every Information In this Table?";
			//
			//action
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6.0F, 13.0F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(334, 100);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.Button2);
			this.Controls.Add(this.Button1);
			this.Name = "action";
			this.Text = "action";
			this.ResumeLayout(false);
			this.PerformLayout();

//INSTANT C# NOTE: Converted design-time event handler wireups:
			Button1.Click += new System.EventHandler(Button1_Click);
			Button2.Click += new System.EventHandler(Button2_Click);
		}
		internal System.Windows.Forms.Button Button1;
		internal System.Windows.Forms.Button Button2;
		internal System.Windows.Forms.Label Label1;
	}

}