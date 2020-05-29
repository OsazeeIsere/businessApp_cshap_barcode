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

namespace BusinessApp
{
	[Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
	public partial class expenditure : System.Windows.Forms.Form
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
            this.Label5 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtmisc = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.ComboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.BackColor = System.Drawing.Color.White;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label5.Location = new System.Drawing.Point(238, 59);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(381, 24);
            this.Label5.TabIndex = 67;
            this.Label5.Text = "No. 218, 2nd, East Circular Road, Benin City.";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.ForeColor = System.Drawing.Color.Aqua;
            this.Label6.Location = new System.Drawing.Point(240, 20);
            this.Label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(379, 29);
            this.Label6.TabIndex = 66;
            this.Label6.Text = "WELCOME TO TRENDY SHOP\r\n";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(48, 161);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(174, 20);
            this.Label1.TabIndex = 68;
            this.Label1.Text = "Miscellanous Expenses";
            this.Label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // txtmisc
            // 
            this.txtmisc.Location = new System.Drawing.Point(232, 161);
            this.txtmisc.Name = "txtmisc";
            this.txtmisc.Size = new System.Drawing.Size(105, 26);
            this.txtmisc.TabIndex = 69;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(429, 158);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(0, 20);
            this.Label2.TabIndex = 70;
            // 
            // ComboBox1
            // 
            this.ComboBox1.FormattingEnabled = true;
            this.ComboBox1.Location = new System.Drawing.Point(421, 161);
            this.ComboBox1.Name = "ComboBox1";
            this.ComboBox1.Size = new System.Drawing.Size(124, 28);
            this.ComboBox1.TabIndex = 71;
            // 
            // expenditure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 512);
            this.Controls.Add(this.ComboBox1);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.txtmisc);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label6);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "expenditure";
            this.Text = "expenditure";
            this.Load += new System.EventHandler(this.expenditure_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		internal System.Windows.Forms.Label Label5;
		internal System.Windows.Forms.Label Label6;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.TextBox txtmisc;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.ComboBox ComboBox1;
	}

}