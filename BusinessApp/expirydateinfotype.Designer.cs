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
	public partial class expirydateinfotype : System.Windows.Forms.Form
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
            this.Button3 = new System.Windows.Forms.Button();
            this.Button4 = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(18, 183);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(222, 55);
            this.Button1.TabIndex = 83;
            this.Button1.Text = "Products Expiry \r\nDate Info.";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Button2
            // 
            this.Button2.Location = new System.Drawing.Point(271, 182);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(189, 55);
            this.Button2.TabIndex = 84;
            this.Button2.Text = "Category B";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Button3
            // 
            this.Button3.Location = new System.Drawing.Point(486, 185);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(185, 52);
            this.Button3.TabIndex = 85;
            this.Button3.Text = "Category C";
            this.Button3.UseVisualStyleBackColor = true;
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // Button4
            // 
            this.Button4.Location = new System.Drawing.Point(284, 282);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(176, 52);
            this.Button4.TabIndex = 86;
            this.Button4.Text = "Purchase History";
            this.Button4.UseVisualStyleBackColor = true;
            this.Button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.Color.Black;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Label2.Location = new System.Drawing.Point(181, 60);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(269, 18);
            this.Label2.TabIndex = 88;
            this.Label2.Text = "Okha Market , Sapele Road, Benin City.\r\n";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Label1.Location = new System.Drawing.Point(148, 23);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(336, 25);
            this.Label1.TabIndex = 87;
            this.Label1.Text = "WELCOME TO TRENDY SHOP\r\n";
            // 
            // expirydateinfotype
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 403);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Button4);
            this.Controls.Add(this.Button3);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "expirydateinfotype";
            this.Text = "Expiry Date Info. Type";
            this.Load += new System.EventHandler(this.expirydateinfotype_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		internal System.Windows.Forms.Button Button1;
		internal System.Windows.Forms.Button Button2;
		internal System.Windows.Forms.Button Button3;
		internal System.Windows.Forms.Button Button4;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.Label Label1;
	}

}