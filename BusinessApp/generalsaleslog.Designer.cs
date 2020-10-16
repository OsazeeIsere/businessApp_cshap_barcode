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
	public partial class generalsaleslog : System.Windows.Forms.Form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Label8 = new System.Windows.Forms.Label();
            this.DateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.txtcustomer = new System.Windows.Forms.TextBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.cbocashier = new System.Windows.Forms.ComboBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.DateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Button1 = new System.Windows.Forms.Button();
            this.txttotaprofit = new System.Windows.Forms.TextBox();
            this.txttotalsales = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.dgvsaleslog = new System.Windows.Forms.DataGridView();
            this.txtpassword1 = new System.Windows.Forms.TextBox();
            this.lbaddress = new System.Windows.Forms.Label();
            this.lbname = new System.Windows.Forms.Label();
            this.txtadmin = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsaleslog)).BeginInit();
            this.SuspendLayout();
            // 
            // Label8
            // 
            this.Label8.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(353, 492);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(125, 20);
            this.Label8.TabIndex = 53;
            this.Label8.Text = "To Second Date";
            // 
            // DateTimePicker2
            // 
            this.DateTimePicker2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.DateTimePicker2.Location = new System.Drawing.Point(476, 486);
            this.DateTimePicker2.Name = "DateTimePicker2";
            this.DateTimePicker2.Size = new System.Drawing.Size(254, 26);
            this.DateTimePicker2.TabIndex = 52;
            // 
            // txtcustomer
            // 
            this.txtcustomer.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtcustomer.Location = new System.Drawing.Point(1054, 541);
            this.txtcustomer.Name = "txtcustomer";
            this.txtcustomer.ReadOnly = true;
            this.txtcustomer.Size = new System.Drawing.Size(101, 26);
            this.txtcustomer.TabIndex = 51;
            // 
            // Label7
            // 
            this.Label7.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(887, 544);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(155, 20);
            this.Label7.TabIndex = 50;
            this.Label7.Text = "Customer Response";
            // 
            // Label4
            // 
            this.Label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(353, 431);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(120, 20);
            this.Label4.TabIndex = 49;
            this.Label4.Text = "From First Date";
            // 
            // cbocashier
            // 
            this.cbocashier.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cbocashier.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbocashier.FormattingEnabled = true;
            this.cbocashier.Location = new System.Drawing.Point(139, 431);
            this.cbocashier.Name = "cbocashier";
            this.cbocashier.Size = new System.Drawing.Size(163, 28);
            this.cbocashier.TabIndex = 48;
            // 
            // Label3
            // 
            this.Label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(21, 434);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(112, 20);
            this.Label3.TabIndex = 47;
            this.Label3.Text = "Select Cashier";
            // 
            // DateTimePicker1
            // 
            this.DateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.DateTimePicker1.Location = new System.Drawing.Point(471, 428);
            this.DateTimePicker1.Name = "DateTimePicker1";
            this.DateTimePicker1.Size = new System.Drawing.Size(260, 26);
            this.DateTimePicker1.TabIndex = 46;
            // 
            // Button1
            // 
            this.Button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Button1.Location = new System.Drawing.Point(476, 533);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(254, 31);
            this.Button1.TabIndex = 45;
            this.Button1.Text = "Sales For The Cashier";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // txttotaprofit
            // 
            this.txttotaprofit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txttotaprofit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotaprofit.Location = new System.Drawing.Point(1054, 487);
            this.txttotaprofit.Name = "txttotaprofit";
            this.txttotaprofit.ReadOnly = true;
            this.txttotaprofit.Size = new System.Drawing.Size(101, 29);
            this.txttotaprofit.TabIndex = 44;
            // 
            // txttotalsales
            // 
            this.txttotalsales.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txttotalsales.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotalsales.Location = new System.Drawing.Point(1054, 434);
            this.txttotalsales.Name = "txttotalsales";
            this.txttotalsales.ReadOnly = true;
            this.txttotalsales.Size = new System.Drawing.Size(101, 31);
            this.txttotalsales.TabIndex = 43;
            // 
            // Label2
            // 
            this.Label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(945, 489);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(97, 24);
            this.Label2.TabIndex = 42;
            this.Label2.Text = "Total Profit";
            // 
            // Label1
            // 
            this.Label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(890, 437);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(165, 24);
            this.Label1.TabIndex = 41;
            this.Label1.Text = "Total Amount Sold";
            // 
            // dgvsaleslog
            // 
            this.dgvsaleslog.AllowUserToAddRows = false;
            this.dgvsaleslog.AllowUserToDeleteRows = false;
            this.dgvsaleslog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvsaleslog.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvsaleslog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvsaleslog.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvsaleslog.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvsaleslog.Location = new System.Drawing.Point(25, 86);
            this.dgvsaleslog.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvsaleslog.Name = "dgvsaleslog";
            this.dgvsaleslog.ReadOnly = true;
            this.dgvsaleslog.Size = new System.Drawing.Size(1130, 334);
            this.dgvsaleslog.TabIndex = 38;
            this.dgvsaleslog.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvsaleslog_UserDeletedRow);
            this.dgvsaleslog.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgvsaleslog_UserDeletingRow);
            // 
            // txtpassword1
            // 
            this.txtpassword1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtpassword1.Location = new System.Drawing.Point(40, -30);
            this.txtpassword1.Name = "txtpassword1";
            this.txtpassword1.PasswordChar = '*';
            this.txtpassword1.Size = new System.Drawing.Size(152, 26);
            this.txtpassword1.TabIndex = 54;
            // 
            // lbaddress
            // 
            this.lbaddress.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbaddress.AutoSize = true;
            this.lbaddress.BackColor = System.Drawing.Color.Black;
            this.lbaddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbaddress.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbaddress.Location = new System.Drawing.Point(500, 46);
            this.lbaddress.Name = "lbaddress";
            this.lbaddress.Size = new System.Drawing.Size(33, 20);
            this.lbaddress.TabIndex = 56;
            this.lbaddress.Text = "lb2";
            // 
            // lbname
            // 
            this.lbname.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbname.AutoSize = true;
            this.lbname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbname.ForeColor = System.Drawing.Color.Red;
            this.lbname.Location = new System.Drawing.Point(585, 9);
            this.lbname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbname.Name = "lbname";
            this.lbname.Size = new System.Drawing.Size(44, 25);
            this.lbname.TabIndex = 55;
            this.lbname.Text = "lb1";
            // 
            // txtadmin
            // 
            this.txtadmin.AccessibleName = "txtadmin";
            this.txtadmin.Location = new System.Drawing.Point(25, 9);
            this.txtadmin.Name = "txtadmin";
            this.txtadmin.PasswordChar = '#';
            this.txtadmin.ReadOnly = true;
            this.txtadmin.Size = new System.Drawing.Size(100, 26);
            this.txtadmin.TabIndex = 57;
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(139, 11);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(163, 45);
            this.button2.TabIndex = 58;
            this.button2.Text = "Cancel Sales";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // generalsaleslog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1253, 637);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtadmin);
            this.Controls.Add(this.lbaddress);
            this.Controls.Add(this.lbname);
            this.Controls.Add(this.txtpassword1);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.DateTimePicker2);
            this.Controls.Add(this.txtcustomer);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.cbocashier);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.DateTimePicker1);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.txttotaprofit);
            this.Controls.Add(this.txttotalsales);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.dgvsaleslog);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(800, 650);
            this.Name = "generalsaleslog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "general Sales Log";
            this.Load += new System.EventHandler(this.generalsaleslog_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.generalsaleslog_MouseClick_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvsaleslog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		internal System.Windows.Forms.Label Label8;
		internal System.Windows.Forms.DateTimePicker DateTimePicker2;
		internal System.Windows.Forms.TextBox txtcustomer;
		internal System.Windows.Forms.Label Label7;
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.ComboBox cbocashier;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.DateTimePicker DateTimePicker1;
		internal System.Windows.Forms.Button Button1;
		internal System.Windows.Forms.TextBox txttotaprofit;
		internal System.Windows.Forms.TextBox txttotalsales;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.DataGridView dgvsaleslog;
		internal System.Windows.Forms.TextBox txtpassword1;
		internal System.Windows.Forms.Label lbaddress;
		internal System.Windows.Forms.Label lbname;
        private System.Windows.Forms.TextBox txtadmin;
        private System.Windows.Forms.Button button2;
    }

}