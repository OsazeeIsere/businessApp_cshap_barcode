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
	public partial class clearcart : System.Windows.Forms.Form
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
			this.Button1 = new System.Windows.Forms.Button();
			this.Button2 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			//
			//Label1
			//
			this.Label1.AutoSize = true;
			this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label1.Location = new System.Drawing.Point(22, 35);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(370, 20);
			this.Label1.TabIndex = 0;
			this.Label1.Text = "Are You Sure You Want To Clear The CART?";
			//
			//Button1
			//
			this.Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Button1.Location = new System.Drawing.Point(24, 144);
			this.Button1.Name = "Button1";
			this.Button1.Size = new System.Drawing.Size(118, 33);
			this.Button1.TabIndex = 1;
			this.Button1.Text = "YES";
			this.Button1.UseVisualStyleBackColor = true;
			//
			//Button2
			//
			this.Button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Button2.Location = new System.Drawing.Point(303, 143);
			this.Button2.Name = "Button2";
			this.Button2.Size = new System.Drawing.Size(119, 33);
			this.Button2.TabIndex = 2;
			this.Button2.Text = "NO";
			this.Button2.UseVisualStyleBackColor = true;
			//
			//clearcart
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6.0F, 13.0F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(439, 208);
			this.Controls.Add(this.Button2);
			this.Controls.Add(this.Button1);
			this.Controls.Add(this.Label1);
			this.Name = "clearcart";
			this.Text = "clearcart";
			this.ResumeLayout(false);
			this.PerformLayout();

//INSTANT C# NOTE: Converted design-time event handler wireups:
			Button1.Click += new System.EventHandler(Button1_Click);
			base.Load += new System.EventHandler(clearcart_Load);
			Button2.Click += new System.EventHandler(Button2_Click);
			Label1.Click += new System.EventHandler(Label1_Click);
		}
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.Button Button1;
		internal System.Windows.Forms.Button Button2;
	}

}