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
	public partial class clearholdsalescart : System.Windows.Forms.Form
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
            this.Button2 = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Button2
            // 
            this.Button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button2.Location = new System.Drawing.Point(313, 168);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(119, 33);
            this.Button2.TabIndex = 5;
            this.Button2.Text = "NO";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Button1
            // 
            this.Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button1.Location = new System.Drawing.Point(34, 169);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(118, 33);
            this.Button1.TabIndex = 4;
            this.Button1.Text = "YES";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(32, 60);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(370, 20);
            this.Label1.TabIndex = 3;
            this.Label1.Text = "Are You Sure You Want To Clear The CART?";
            // 
            // clearholdsalescart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 262);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.Label1);
            this.Name = "clearholdsalescart";
            this.Text = "clearholdsalescart";
            this.Load += new System.EventHandler(this.clearholdsalescart_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		internal System.Windows.Forms.Button Button2;
		internal System.Windows.Forms.Button Button1;
		internal System.Windows.Forms.Label Label1;
	}

}