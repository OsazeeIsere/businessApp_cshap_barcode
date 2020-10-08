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
	public partial class delet : System.Windows.Forms.Form
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
            this.txtproductname = new System.Windows.Forms.TextBox();
            this.Button1 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtproductid = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(15, 21);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(294, 20);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Are You Sure You Want To Delete: ";
            this.Label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // txtproductname
            // 
            this.txtproductname.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtproductname.Location = new System.Drawing.Point(13, 48);
            this.txtproductname.Name = "txtproductname";
            this.txtproductname.Size = new System.Drawing.Size(468, 20);
            this.txtproductname.TabIndex = 1;
            this.txtproductname.TextChanged += new System.EventHandler(this.txtproductname_TextChanged);
            // 
            // Button1
            // 
            this.Button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button1.Location = new System.Drawing.Point(26, 129);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(120, 43);
            this.Button1.TabIndex = 2;
            this.Button1.Text = "YES";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Button2
            // 
            this.Button2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button2.Location = new System.Drawing.Point(344, 129);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(107, 39);
            this.Button2.TabIndex = 3;
            this.Button2.Text = "NO";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Label2
            // 
            this.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(19, 79);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(136, 20);
            this.Label2.TabIndex = 5;
            this.Label2.Text = "With Product ID";
            this.Label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // txtproductid
            // 
            this.txtproductid.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtproductid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtproductid.Location = new System.Drawing.Point(161, 76);
            this.txtproductid.Name = "txtproductid";
            this.txtproductid.Size = new System.Drawing.Size(96, 26);
            this.txtproductid.TabIndex = 6;
            this.txtproductid.TextChanged += new System.EventHandler(this.txtproductid_TextChanged);
            // 
            // delet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 211);
            this.Controls.Add(this.txtproductid);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.txtproductname);
            this.Controls.Add(this.Label1);
            this.MinimumSize = new System.Drawing.Size(500, 250);
            this.Name = "delet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "delet";
            this.Load += new System.EventHandler(this.delet_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.TextBox txtproductname;
		internal System.Windows.Forms.Button Button1;
		internal System.Windows.Forms.Button Button2;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.TextBox txtproductid;
	}

}