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
	public partial class admin : System.Windows.Forms.Form
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
            this.txtadminname = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtadminpassword = new System.Windows.Forms.TextBox();
            this.lblpassword = new System.Windows.Forms.Label();
            this.Button1 = new System.Windows.Forms.Button();
            this.btnmanageuser = new System.Windows.Forms.Button();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtadminpassword1 = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.lbname = new System.Windows.Forms.Label();
            this.lbaddress = new System.Windows.Forms.Label();
            this.lbtel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtadminname
            // 
            this.txtadminname.Location = new System.Drawing.Point(300, 115);
            this.txtadminname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtadminname.Name = "txtadminname";
            this.txtadminname.Size = new System.Drawing.Size(188, 26);
            this.txtadminname.TabIndex = 3;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(40, 115);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(149, 20);
            this.Label1.TabIndex = 2;
            this.Label1.Text = "Administrator Name";
            // 
            // txtadminpassword
            // 
            this.txtadminpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtadminpassword.Location = new System.Drawing.Point(300, 169);
            this.txtadminpassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtadminpassword.Name = "txtadminpassword";
            this.txtadminpassword.PasswordChar = '*';
            this.txtadminpassword.Size = new System.Drawing.Size(192, 26);
            this.txtadminpassword.TabIndex = 5;
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpassword.Location = new System.Drawing.Point(40, 173);
            this.lblpassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(78, 20);
            this.lblpassword.TabIndex = 4;
            this.lblpassword.Text = "Password";
            // 
            // Button1
            // 
            this.Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button1.Location = new System.Drawing.Point(300, 275);
            this.Button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(189, 43);
            this.Button1.TabIndex = 6;
            this.Button1.Text = "Admin first Entry";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnmanageuser
            // 
            this.btnmanageuser.Location = new System.Drawing.Point(300, 341);
            this.btnmanageuser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnmanageuser.Name = "btnmanageuser";
            this.btnmanageuser.Size = new System.Drawing.Size(189, 62);
            this.btnmanageuser.TabIndex = 7;
            this.btnmanageuser.Text = "Manage Users";
            this.btnmanageuser.UseVisualStyleBackColor = true;
            this.btnmanageuser.Click += new System.EventHandler(this.btnmanageuser_Click);
            // 
            // PictureBox1
            // 
            this.PictureBox1.Image = global::BusinessApp.Properties.Resources.key_05;
            this.PictureBox1.Location = new System.Drawing.Point(44, 252);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(248, 151);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox1.TabIndex = 8;
            this.PictureBox1.TabStop = false;
            // 
            // txtadminpassword1
            // 
            this.txtadminpassword1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtadminpassword1.Location = new System.Drawing.Point(300, 216);
            this.txtadminpassword1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtadminpassword1.Name = "txtadminpassword1";
            this.txtadminpassword1.PasswordChar = '*';
            this.txtadminpassword1.Size = new System.Drawing.Size(192, 26);
            this.txtadminpassword1.TabIndex = 10;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(40, 220);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(252, 20);
            this.Label2.TabIndex = 9;
            this.Label2.Text = "If New Please, Re-Enter Password";
            // 
            // lbname
            // 
            this.lbname.AutoSize = true;
            this.lbname.Location = new System.Drawing.Point(114, 9);
            this.lbname.Name = "lbname";
            this.lbname.Size = new System.Drawing.Size(51, 20);
            this.lbname.TabIndex = 11;
            this.lbname.Text = "label3";
            // 
            // lbaddress
            // 
            this.lbaddress.AutoSize = true;
            this.lbaddress.Location = new System.Drawing.Point(108, 48);
            this.lbaddress.Name = "lbaddress";
            this.lbaddress.Size = new System.Drawing.Size(51, 20);
            this.lbaddress.TabIndex = 12;
            this.lbaddress.Text = "label3";
            // 
            // lbtel
            // 
            this.lbtel.AutoSize = true;
            this.lbtel.Location = new System.Drawing.Point(129, 72);
            this.lbtel.Name = "lbtel";
            this.lbtel.Size = new System.Drawing.Size(51, 20);
            this.lbtel.TabIndex = 13;
            this.lbtel.Text = "label3";
            // 
            // admin
            // 
            this.AcceptButton = this.btnmanageuser;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 448);
            this.Controls.Add(this.lbtel);
            this.Controls.Add(this.lbaddress);
            this.Controls.Add(this.lbname);
            this.Controls.Add(this.txtadminpassword1);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.btnmanageuser);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.txtadminpassword);
            this.Controls.Add(this.lblpassword);
            this.Controls.Add(this.txtadminname);
            this.Controls.Add(this.Label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "admin";
            this.Text = "admin";
            this.Load += new System.EventHandler(this.admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		internal System.Windows.Forms.TextBox txtadminname;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.TextBox txtadminpassword;
		internal System.Windows.Forms.Label lblpassword;
		internal System.Windows.Forms.Button Button1;
		internal System.Windows.Forms.Button btnmanageuser;
		internal System.Windows.Forms.PictureBox PictureBox1;
		internal System.Windows.Forms.TextBox txtadminpassword1;
		internal System.Windows.Forms.Label Label2;
        private Label lbname;
        private Label lbaddress;
        private Label lbtel;
    }

}