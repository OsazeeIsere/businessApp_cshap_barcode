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
	public partial class backup : System.Windows.Forms.Form
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
            this.txtbackuppassword = new System.Windows.Forms.TextBox();
            this.txtbackupname = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Button1 = new System.Windows.Forms.Button();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtbackuppassword
            // 
            this.txtbackuppassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtbackuppassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbackuppassword.Location = new System.Drawing.Point(274, 201);
            this.txtbackuppassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbackuppassword.Name = "txtbackuppassword";
            this.txtbackuppassword.PasswordChar = '*';
            this.txtbackuppassword.Size = new System.Drawing.Size(264, 26);
            this.txtbackuppassword.TabIndex = 11;
            // 
            // txtbackupname
            // 
            this.txtbackupname.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtbackupname.Location = new System.Drawing.Point(270, 139);
            this.txtbackupname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbackupname.Name = "txtbackupname";
            this.txtbackupname.Size = new System.Drawing.Size(266, 26);
            this.txtbackupname.TabIndex = 10;
            // 
            // Label2
            // 
            this.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(94, 201);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(78, 20);
            this.Label2.TabIndex = 8;
            this.Label2.Text = "Password";
            // 
            // Label1
            // 
            this.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(63, 139);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(109, 20);
            this.Label1.TabIndex = 7;
            this.Label1.Text = "Backup Name";
            // 
            // Label4
            // 
            this.Label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(57, 36);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(478, 25);
            this.Label4.TabIndex = 13;
            this.Label4.Text = "WELCOME AS A BACKUP ADMINISTRATOR";
            // 
            // Button1
            // 
            this.Button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Button1.Location = new System.Drawing.Point(270, 289);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(259, 42);
            this.Button1.TabIndex = 14;
            this.Button1.Text = "Login";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // PictureBox1
            // 
            this.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PictureBox1.Image = global::BusinessApp.Properties.Resources.key2;
            this.PictureBox1.Location = new System.Drawing.Point(49, 224);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(215, 154);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox1.TabIndex = 15;
            this.PictureBox1.TabStop = false;
            // 
            // backup
            // 
            this.AcceptButton = this.Button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.txtbackuppassword);
            this.Controls.Add(this.txtbackupname);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(600, 450);
            this.Name = "backup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "backup";
            this.Load += new System.EventHandler(this.backup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		internal System.Windows.Forms.TextBox txtbackuppassword;
		internal System.Windows.Forms.TextBox txtbackupname;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.Button Button1;
		internal System.Windows.Forms.PictureBox PictureBox1;
	}

}