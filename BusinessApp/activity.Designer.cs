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
	public partial class activity : System.Windows.Forms.Form
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
            this.Panel1 = new System.Windows.Forms.Panel();
            this.Button2 = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.btndrugs = new System.Windows.Forms.Button();
            this.Button4 = new System.Windows.Forms.Button();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.Button3 = new System.Windows.Forms.Button();
            this.txtcashiername1 = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label16 = new System.Windows.Forms.Label();
            this.txtadminpassword = new System.Windows.Forms.TextBox();
            this.lbaddress = new System.Windows.Forms.Label();
            this.lbname = new System.Windows.Forms.Label();
            this.lbtel = new System.Windows.Forms.Label();
            this.Panel1.SuspendLayout();
            this.Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Panel1.Controls.Add(this.Button2);
            this.Panel1.Controls.Add(this.Button1);
            this.Panel1.Controls.Add(this.btndrugs);
            this.Panel1.ForeColor = System.Drawing.Color.Red;
            this.Panel1.Location = new System.Drawing.Point(27, 180);
            this.Panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(216, 204);
            this.Panel1.TabIndex = 8;
            // 
            // Button2
            // 
            this.Button2.Location = new System.Drawing.Point(20, 78);
            this.Button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(176, 50);
            this.Button2.TabIndex = 2;
            this.Button2.Text = "Category B";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(20, 138);
            this.Button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(176, 50);
            this.Button1.TabIndex = 1;
            this.Button1.Text = "Category C";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btndrugs
            // 
            this.btndrugs.Location = new System.Drawing.Point(20, 16);
            this.btndrugs.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btndrugs.Name = "btndrugs";
            this.btndrugs.Size = new System.Drawing.Size(176, 50);
            this.btndrugs.TabIndex = 0;
            this.btndrugs.Text = "Enter Products Purchased";
            this.btndrugs.UseVisualStyleBackColor = true;
            this.btndrugs.Click += new System.EventHandler(this.btndrugs_Click);
            // 
            // Button4
            // 
            this.Button4.Location = new System.Drawing.Point(20, 96);
            this.Button4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(169, 72);
            this.Button4.TabIndex = 0;
            this.Button4.Text = "Sell As Cashier";
            this.Button4.UseVisualStyleBackColor = true;
            this.Button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // Panel2
            // 
            this.Panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Panel2.BackColor = System.Drawing.Color.Magenta;
            this.Panel2.Controls.Add(this.Button3);
            this.Panel2.Controls.Add(this.Button4);
            this.Panel2.ForeColor = System.Drawing.Color.Black;
            this.Panel2.Location = new System.Drawing.Point(508, 180);
            this.Panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(215, 188);
            this.Panel2.TabIndex = 10;
            // 
            // Button3
            // 
            this.Button3.Location = new System.Drawing.Point(20, 8);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(170, 66);
            this.Button3.TabIndex = 1;
            this.Button3.Text = "Sell As Adninistrator";
            this.Button3.UseVisualStyleBackColor = true;
            this.Button3.Click += new System.EventHandler(this.Button3_Click_1);
            // 
            // txtcashiername1
            // 
            this.txtcashiername1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtcashiername1.Location = new System.Drawing.Point(168, 103);
            this.txtcashiername1.Name = "txtcashiername1";
            this.txtcashiername1.Size = new System.Drawing.Size(191, 26);
            this.txtcashiername1.TabIndex = 19;
            // 
            // Label5
            // 
            this.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(57, 103);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(89, 20);
            this.Label5.TabIndex = 18;
            this.Label5.Text = "User Name";
            // 
            // Label16
            // 
            this.Label16.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Label16.AutoSize = true;
            this.Label16.Location = new System.Drawing.Point(332, 149);
            this.Label16.Name = "Label16";
            this.Label16.Size = new System.Drawing.Size(170, 20);
            this.Label16.TabIndex = 101;
            this.Label16.Text = "Enter Admin Password";
            // 
            // txtadminpassword
            // 
            this.txtadminpassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtadminpassword.Location = new System.Drawing.Point(508, 146);
            this.txtadminpassword.Name = "txtadminpassword";
            this.txtadminpassword.PasswordChar = '#';
            this.txtadminpassword.Size = new System.Drawing.Size(215, 26);
            this.txtadminpassword.TabIndex = 100;
            // 
            // lbaddress
            // 
            this.lbaddress.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbaddress.AutoSize = true;
            this.lbaddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbaddress.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbaddress.Location = new System.Drawing.Point(253, 56);
            this.lbaddress.Name = "lbaddress";
            this.lbaddress.Size = new System.Drawing.Size(27, 18);
            this.lbaddress.TabIndex = 103;
            this.lbaddress.Text = "lb2";
            this.lbaddress.Click += new System.EventHandler(this.Label2_Click);
            // 
            // lbname
            // 
            this.lbname.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbname.AutoSize = true;
            this.lbname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbname.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbname.Location = new System.Drawing.Point(291, 18);
            this.lbname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbname.Name = "lbname";
            this.lbname.Size = new System.Drawing.Size(44, 25);
            this.lbname.TabIndex = 102;
            this.lbname.Text = "lb1";
            this.lbname.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbtel
            // 
            this.lbtel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbtel.AutoSize = true;
            this.lbtel.Location = new System.Drawing.Point(368, 77);
            this.lbtel.Name = "lbtel";
            this.lbtel.Size = new System.Drawing.Size(51, 20);
            this.lbtel.TabIndex = 104;
            this.lbtel.Text = "label1";
            // 
            // activity
            // 
            this.AcceptButton = this.Button4;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 428);
            this.Controls.Add(this.lbtel);
            this.Controls.Add(this.lbaddress);
            this.Controls.Add(this.lbname);
            this.Controls.Add(this.Label16);
            this.Controls.Add(this.txtadminpassword);
            this.Controls.Add(this.txtcashiername1);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.Panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "activity";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "activity";
            this.Load += new System.EventHandler(this.activity_Load);
            this.Panel1.ResumeLayout(false);
            this.Panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		internal System.Windows.Forms.Panel Panel1;
		internal System.Windows.Forms.Button btndrugs;
		internal System.Windows.Forms.Button Button4;
		internal System.Windows.Forms.Panel Panel2;
		internal System.Windows.Forms.TextBox txtcashiername1;
		internal System.Windows.Forms.Label Label5;
		internal System.Windows.Forms.Button Button2;
		internal System.Windows.Forms.Button Button1;
		internal System.Windows.Forms.Button Button3;
		internal System.Windows.Forms.Label Label16;
		internal System.Windows.Forms.TextBox txtadminpassword;
		internal System.Windows.Forms.Label lbaddress;
		internal System.Windows.Forms.Label lbname;
        private Label lbtel;
    }

}