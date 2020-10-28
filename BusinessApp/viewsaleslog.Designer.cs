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
	public partial class viewsaleslog : System.Windows.Forms.Form
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
            this.Label3 = new System.Windows.Forms.Label();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.Label6 = new System.Windows.Forms.Label();
            this.txtcashierpassword = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.Button4 = new System.Windows.Forms.Button();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.Label7 = new System.Windows.Forms.Label();
            this.txtadminpassword = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.Button2 = new System.Windows.Forms.Button();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.Panel2.SuspendLayout();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label3
            // 
            this.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(249, 201);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(305, 31);
            this.Label3.TabIndex = 12;
            this.Label3.Text = "Abeg  Who   You   Be?";
            this.Label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // Panel2
            // 
            this.Panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Panel2.BackColor = System.Drawing.Color.Magenta;
            this.Panel2.Controls.Add(this.Label6);
            this.Panel2.Controls.Add(this.txtcashierpassword);
            this.Panel2.Controls.Add(this.Label5);
            this.Panel2.Controls.Add(this.Button4);
            this.Panel2.ForeColor = System.Drawing.Color.Black;
            this.Panel2.Location = new System.Drawing.Point(410, 287);
            this.Panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(377, 204);
            this.Panel2.TabIndex = 1;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(18, 65);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(159, 20);
            this.Label6.TabIndex = 3;
            this.Label6.Text = "Enter Your Password";
            // 
            // txtcashierpassword
            // 
            this.txtcashierpassword.Location = new System.Drawing.Point(183, 62);
            this.txtcashierpassword.Name = "txtcashierpassword";
            this.txtcashierpassword.PasswordChar = '*';
            this.txtcashierpassword.Size = new System.Drawing.Size(167, 26);
            this.txtcashierpassword.TabIndex = 0;
            this.txtcashierpassword.Click += new System.EventHandler(this.txtcashierpassword_Click);
            this.txtcashierpassword.ModifiedChanged += new System.EventHandler(this.txtcashierpassword_ModifiedChanged);
            this.txtcashierpassword.MultilineChanged += new System.EventHandler(this.txtcashierpassword_MultilineChanged);
            this.txtcashierpassword.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            this.txtcashierpassword.MouseEnter += new System.EventHandler(this.txtcashierpassword_MouseEnter);
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(119, 16);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(153, 20);
            this.Label5.TabIndex = 1;
            this.Label5.Text = "If You Be CASHIER";
            this.Label5.Click += new System.EventHandler(this.Label5_Click);
            // 
            // Button4
            // 
            this.Button4.Location = new System.Drawing.Point(179, 137);
            this.Button4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(171, 50);
            this.Button4.TabIndex = 1;
            this.Button4.Text = "You FIt See Sales Log";
            this.Button4.UseVisualStyleBackColor = true;
            this.Button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // Panel1
            // 
            this.Panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Panel1.Controls.Add(this.Label7);
            this.Panel1.Controls.Add(this.txtadminpassword);
            this.Panel1.Controls.Add(this.Label4);
            this.Panel1.Controls.Add(this.Button2);
            this.Panel1.ForeColor = System.Drawing.Color.Red;
            this.Panel1.Location = new System.Drawing.Point(14, 287);
            this.Panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(369, 204);
            this.Panel1.TabIndex = 0;
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(17, 71);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(159, 20);
            this.Label7.TabIndex = 5;
            this.Label7.Text = "Enter Your Password";
            // 
            // txtadminpassword
            // 
            this.txtadminpassword.Location = new System.Drawing.Point(174, 71);
            this.txtadminpassword.Name = "txtadminpassword";
            this.txtadminpassword.PasswordChar = '*';
            this.txtadminpassword.Size = new System.Drawing.Size(176, 26);
            this.txtadminpassword.TabIndex = 1;
            this.txtadminpassword.TextChanged += new System.EventHandler(this.txtadminpassword_TextChanged);
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(84, 16);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(219, 20);
            this.Label4.TabIndex = 3;
            this.Label4.Text = "If You Be ADMIN or BACKUP";
            // 
            // Button2
            // 
            this.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Button2.Location = new System.Drawing.Point(174, 137);
            this.Button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(176, 50);
            this.Button2.TabIndex = 2;
            this.Button2.Text = "You FIt See Sales Log";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // txtaddress
            // 
            this.txtaddress.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtaddress.Location = new System.Drawing.Point(0, 26);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.ReadOnly = true;
            this.txtaddress.Size = new System.Drawing.Size(814, 26);
            this.txtaddress.TabIndex = 186;
            this.txtaddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtname
            // 
            this.txtname.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtname.Location = new System.Drawing.Point(0, 0);
            this.txtname.Name = "txtname";
            this.txtname.ReadOnly = true;
            this.txtname.Size = new System.Drawing.Size(814, 26);
            this.txtname.TabIndex = 185;
            this.txtname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // viewsaleslog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.CancelButton = this.Button2;
            this.ClientSize = new System.Drawing.Size(814, 561);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.Label3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "viewsaleslog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Sales Log";
            this.Load += new System.EventHandler(this.viewsaleslog_Load);
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.Panel Panel2;
		internal System.Windows.Forms.Label Label5;
		internal System.Windows.Forms.Button Button4;
		internal System.Windows.Forms.Panel Panel1;
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.Button Button2;
		internal System.Windows.Forms.Label Label6;
		internal System.Windows.Forms.TextBox txtcashierpassword;
		internal System.Windows.Forms.TextBox txtadminpassword;
		internal System.Windows.Forms.Label Label7;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.TextBox txtname;
    }

}