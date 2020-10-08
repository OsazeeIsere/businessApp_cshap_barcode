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
	public partial class addbackup : System.Windows.Forms.Form
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
            this.Label2 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.txtbackupname = new System.Windows.Forms.TextBox();
            this.txtbackuppassword1 = new System.Windows.Forms.TextBox();
            this.txtbackuppassword2 = new System.Windows.Forms.TextBox();
            this.btnaddbackup = new System.Windows.Forms.Button();
            this.btnaddcashier = new System.Windows.Forms.Button();
            this.btnoperation = new System.Windows.Forms.Button();
            this.txtcashierpassword1 = new System.Windows.Forms.TextBox();
            this.lblpassword = new System.Windows.Forms.Label();
            this.txtcashiername = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.txtcashierpassword2 = new System.Windows.Forms.TextBox();
            this.lbadmin = new System.Windows.Forms.Label();
            this.Button1 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(73, 89);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(109, 20);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Backup Name";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(104, 151);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(78, 20);
            this.Label2.TabIndex = 1;
            this.Label2.Text = "Password";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(49, 220);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(133, 20);
            this.Label3.TabIndex = 2;
            this.Label3.Text = "Retype Password";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(268, 9);
            this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(304, 29);
            this.Label4.TabIndex = 3;
            this.Label4.Text = "Setup The Various Users";
            this.Label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // txtbackupname
            // 
            this.txtbackupname.Location = new System.Drawing.Point(208, 89);
            this.txtbackupname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbackupname.Name = "txtbackupname";
            this.txtbackupname.Size = new System.Drawing.Size(205, 26);
            this.txtbackupname.TabIndex = 4;
            // 
            // txtbackuppassword1
            // 
            this.txtbackuppassword1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbackuppassword1.Location = new System.Drawing.Point(208, 148);
            this.txtbackuppassword1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbackuppassword1.Name = "txtbackuppassword1";
            this.txtbackuppassword1.PasswordChar = '*';
            this.txtbackuppassword1.Size = new System.Drawing.Size(205, 26);
            this.txtbackuppassword1.TabIndex = 5;
            // 
            // txtbackuppassword2
            // 
            this.txtbackuppassword2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbackuppassword2.Location = new System.Drawing.Point(207, 214);
            this.txtbackuppassword2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbackuppassword2.Name = "txtbackuppassword2";
            this.txtbackuppassword2.PasswordChar = '*';
            this.txtbackuppassword2.Size = new System.Drawing.Size(206, 26);
            this.txtbackuppassword2.TabIndex = 6;
            // 
            // btnaddbackup
            // 
            this.btnaddbackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddbackup.Location = new System.Drawing.Point(207, 268);
            this.btnaddbackup.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnaddbackup.Name = "btnaddbackup";
            this.btnaddbackup.Size = new System.Drawing.Size(206, 57);
            this.btnaddbackup.TabIndex = 7;
            this.btnaddbackup.Text = "Add Backup";
            this.btnaddbackup.UseVisualStyleBackColor = true;
            this.btnaddbackup.Click += new System.EventHandler(this.btnaddbackup_Click);
            // 
            // btnaddcashier
            // 
            this.btnaddcashier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddcashier.Location = new System.Drawing.Point(686, 268);
            this.btnaddcashier.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnaddcashier.Name = "btnaddcashier";
            this.btnaddcashier.Size = new System.Drawing.Size(159, 55);
            this.btnaddcashier.TabIndex = 8;
            this.btnaddcashier.Text = "Add cashier";
            this.btnaddcashier.UseVisualStyleBackColor = true;
            this.btnaddcashier.Click += new System.EventHandler(this.btnaddcashier_Click);
            // 
            // btnoperation
            // 
            this.btnoperation.Location = new System.Drawing.Point(421, 257);
            this.btnoperation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnoperation.Name = "btnoperation";
            this.btnoperation.Size = new System.Drawing.Size(238, 68);
            this.btnoperation.TabIndex = 9;
            this.btnoperation.Text = "Choose Actvity";
            this.btnoperation.UseVisualStyleBackColor = true;
            this.btnoperation.Click += new System.EventHandler(this.btnoperation_Click);
            // 
            // txtcashierpassword1
            // 
            this.txtcashierpassword1.Location = new System.Drawing.Point(686, 151);
            this.txtcashierpassword1.Name = "txtcashierpassword1";
            this.txtcashierpassword1.PasswordChar = '*';
            this.txtcashierpassword1.Size = new System.Drawing.Size(161, 26);
            this.txtcashierpassword1.TabIndex = 13;
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.Location = new System.Drawing.Point(581, 148);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(78, 20);
            this.lblpassword.TabIndex = 12;
            this.lblpassword.Text = "Password";
            // 
            // txtcashiername
            // 
            this.txtcashiername.Location = new System.Drawing.Point(686, 92);
            this.txtcashiername.Name = "txtcashiername";
            this.txtcashiername.Size = new System.Drawing.Size(159, 26);
            this.txtcashiername.TabIndex = 11;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(550, 92);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(109, 20);
            this.Label5.TabIndex = 10;
            this.Label5.Text = "Cashier Name";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(526, 201);
            this.Label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(133, 20);
            this.Label6.TabIndex = 14;
            this.Label6.Text = "Retype Password";
            // 
            // txtcashierpassword2
            // 
            this.txtcashierpassword2.Location = new System.Drawing.Point(686, 201);
            this.txtcashierpassword2.Name = "txtcashierpassword2";
            this.txtcashierpassword2.PasswordChar = '*';
            this.txtcashierpassword2.Size = new System.Drawing.Size(161, 26);
            this.txtcashierpassword2.TabIndex = 15;
            // 
            // lbadmin
            // 
            this.lbadmin.AutoSize = true;
            this.lbadmin.Location = new System.Drawing.Point(31, 28);
            this.lbadmin.Name = "lbadmin";
            this.lbadmin.Size = new System.Drawing.Size(103, 20);
            this.lbadmin.TabIndex = 16;
            this.lbadmin.Text = "Administrator";
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(208, 364);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(305, 56);
            this.Button1.TabIndex = 17;
            this.Button1.Text = "View Current Assets";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Button2
            // 
            this.Button2.BackColor = System.Drawing.Color.Magenta;
            this.Button2.Location = new System.Drawing.Point(566, 364);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(280, 56);
            this.Button2.TabIndex = 18;
            this.Button2.Text = "Patient Electronic Record";
            this.Button2.UseVisualStyleBackColor = false;
            this.Button2.Click += new System.EventHandler(this.Button2_Click_1);
            // 
            // addbackup
            // 
            this.AcceptButton = this.btnoperation;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(913, 447);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.lbadmin);
            this.Controls.Add(this.txtcashierpassword2);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.txtcashierpassword1);
            this.Controls.Add(this.lblpassword);
            this.Controls.Add(this.txtcashiername);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.btnoperation);
            this.Controls.Add(this.btnaddcashier);
            this.Controls.Add(this.btnaddbackup);
            this.Controls.Add(this.txtbackuppassword2);
            this.Controls.Add(this.txtbackuppassword1);
            this.Controls.Add(this.txtbackupname);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "addbackup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Backup";
            this.Load += new System.EventHandler(this.addbackup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.TextBox txtbackupname;
		internal System.Windows.Forms.TextBox txtbackuppassword1;
		internal System.Windows.Forms.TextBox txtbackuppassword2;
		internal System.Windows.Forms.Button btnaddbackup;
		internal System.Windows.Forms.Button btnaddcashier;
		internal System.Windows.Forms.Button btnoperation;
		internal System.Windows.Forms.TextBox txtcashierpassword1;
		internal System.Windows.Forms.Label lblpassword;
		internal System.Windows.Forms.TextBox txtcashiername;
		internal System.Windows.Forms.Label Label5;
		internal System.Windows.Forms.Label Label6;
		internal System.Windows.Forms.TextBox txtcashierpassword2;
		internal System.Windows.Forms.Label lbadmin;
		internal System.Windows.Forms.Button Button1;
		internal System.Windows.Forms.Button Button2;
	}

}