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
	public partial class reorderleveltype : System.Windows.Forms.Form
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
            this.btnbackup = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.btnaddproduct = new System.Windows.Forms.Button();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnbackup
            // 
            this.btnbackup.BackColor = System.Drawing.Color.LightGray;
            this.btnbackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbackup.Location = new System.Drawing.Point(515, 201);
            this.btnbackup.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnbackup.Name = "btnbackup";
            this.btnbackup.Size = new System.Drawing.Size(196, 82);
            this.btnbackup.TabIndex = 8;
            this.btnbackup.Text = "Category C";
            this.btnbackup.UseVisualStyleBackColor = false;
            this.btnbackup.Click += new System.EventHandler(this.btnbackup_Click);
            // 
            // Button1
            // 
            this.Button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button1.Location = new System.Drawing.Point(13, 201);
            this.Button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(201, 82);
            this.Button1.TabIndex = 6;
            this.Button1.Text = "ReOrder Level For Products";
            this.Button1.UseVisualStyleBackColor = false;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnaddproduct
            // 
            this.btnaddproduct.BackColor = System.Drawing.Color.Silver;
            this.btnaddproduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddproduct.Location = new System.Drawing.Point(276, 201);
            this.btnaddproduct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnaddproduct.Name = "btnaddproduct";
            this.btnaddproduct.Size = new System.Drawing.Size(186, 82);
            this.btnaddproduct.TabIndex = 5;
            this.btnaddproduct.Text = "Category B";
            this.btnaddproduct.UseVisualStyleBackColor = false;
            this.btnaddproduct.Click += new System.EventHandler(this.btnaddproduct_Click);
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.BackColor = System.Drawing.Color.Black;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Label5.Location = new System.Drawing.Point(206, 71);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(326, 20);
            this.Label5.TabIndex = 92;
            this.Label5.Text = "Okha Market , Sapele Road, Benin City.\r\n";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.ForeColor = System.Drawing.Color.Red;
            this.Label6.Location = new System.Drawing.Point(205, 28);
            this.Label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(336, 25);
            this.Label6.TabIndex = 91;
            this.Label6.Text = "WELCOME TO TRENDY SHOP\r\n";
            // 
            // reorderleveltype
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 355);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.btnbackup);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.btnaddproduct);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "reorderleveltype";
            this.Text = "Reorder Level Type";
            this.Load += new System.EventHandler(this.reorderleveltype_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		internal System.Windows.Forms.Button btnbackup;
		internal System.Windows.Forms.Button Button1;
		internal System.Windows.Forms.Button btnaddproduct;
		internal System.Windows.Forms.Label Label5;
		internal System.Windows.Forms.Label Label6;
	}

}