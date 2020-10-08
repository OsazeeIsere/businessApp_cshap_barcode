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
	public partial class drugslog : System.Windows.Forms.Form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvsaleslog = new System.Windows.Forms.DataGridView();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.txttotalsales = new System.Windows.Forms.TextBox();
            this.txttotaprofit = new System.Windows.Forms.TextBox();
            this.Button1 = new System.Windows.Forms.Button();
            this.DateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Label3 = new System.Windows.Forms.Label();
            this.cbocashier = new System.Windows.Forms.ComboBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.txtcustomer = new System.Windows.Forms.TextBox();
            this.DateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.Label8 = new System.Windows.Forms.Label();
            this.PrintDocument1 = new System.Drawing.Printing.PrintDocument();
            this.txtpassword1 = new System.Windows.Forms.TextBox();
            this.lbaddress = new System.Windows.Forms.Label();
            this.lbname = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsaleslog)).BeginInit();
            this.SuspendLayout();
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvsaleslog.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvsaleslog.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvsaleslog.Location = new System.Drawing.Point(22, 75);
            this.dgvsaleslog.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvsaleslog.Name = "dgvsaleslog";
            this.dgvsaleslog.ReadOnly = true;
            this.dgvsaleslog.Size = new System.Drawing.Size(1249, 403);
            this.dgvsaleslog.TabIndex = 0;
            this.dgvsaleslog.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvsaleslog_CellContentClick);
            // 
            // Label1
            // 
            this.Label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(807, 534);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(165, 24);
            this.Label1.TabIndex = 25;
            this.Label1.Text = "Total Amount Sold";
            this.Label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // Label2
            // 
            this.Label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(862, 586);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(97, 24);
            this.Label2.TabIndex = 26;
            this.Label2.Text = "Total Profit";
            this.Label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // txttotalsales
            // 
            this.txttotalsales.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txttotalsales.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotalsales.Location = new System.Drawing.Point(971, 531);
            this.txttotalsales.Name = "txttotalsales";
            this.txttotalsales.ReadOnly = true;
            this.txttotalsales.Size = new System.Drawing.Size(101, 31);
            this.txttotalsales.TabIndex = 27;
            this.txttotalsales.TextChanged += new System.EventHandler(this.txttotalsales_TextChanged);
            // 
            // txttotaprofit
            // 
            this.txttotaprofit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txttotaprofit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotaprofit.Location = new System.Drawing.Point(971, 584);
            this.txttotaprofit.Name = "txttotaprofit";
            this.txttotaprofit.ReadOnly = true;
            this.txttotaprofit.Size = new System.Drawing.Size(101, 29);
            this.txttotaprofit.TabIndex = 28;
            this.txttotaprofit.TextChanged += new System.EventHandler(this.txttotaprofit_TextChanged);
            // 
            // Button1
            // 
            this.Button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Button1.Location = new System.Drawing.Point(466, 635);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(254, 31);
            this.Button1.TabIndex = 29;
            this.Button1.Text = "Sales For The Cashier";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // DateTimePicker1
            // 
            this.DateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.DateTimePicker1.Location = new System.Drawing.Point(461, 530);
            this.DateTimePicker1.Name = "DateTimePicker1";
            this.DateTimePicker1.Size = new System.Drawing.Size(260, 26);
            this.DateTimePicker1.TabIndex = 30;
            this.DateTimePicker1.ValueChanged += new System.EventHandler(this.DateTimePicker1_ValueChanged);
            // 
            // Label3
            // 
            this.Label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(52, 533);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(112, 20);
            this.Label3.TabIndex = 31;
            this.Label3.Text = "Select Cashier";
            this.Label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // cbocashier
            // 
            this.cbocashier.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cbocashier.FormattingEnabled = true;
            this.cbocashier.Location = new System.Drawing.Point(170, 530);
            this.cbocashier.Name = "cbocashier";
            this.cbocashier.Size = new System.Drawing.Size(167, 28);
            this.cbocashier.TabIndex = 32;
            this.cbocashier.SelectedIndexChanged += new System.EventHandler(this.cbocashier_SelectedIndexChanged);
            // 
            // Label4
            // 
            this.Label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(343, 533);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(120, 20);
            this.Label4.TabIndex = 33;
            this.Label4.Text = "From First Date";
            this.Label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // Label7
            // 
            this.Label7.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(804, 635);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(155, 20);
            this.Label7.TabIndex = 34;
            this.Label7.Text = "Customer Response";
            this.Label7.Click += new System.EventHandler(this.Label7_Click);
            // 
            // txtcustomer
            // 
            this.txtcustomer.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtcustomer.Location = new System.Drawing.Point(971, 632);
            this.txtcustomer.Name = "txtcustomer";
            this.txtcustomer.ReadOnly = true;
            this.txtcustomer.Size = new System.Drawing.Size(101, 26);
            this.txtcustomer.TabIndex = 35;
            this.txtcustomer.TextChanged += new System.EventHandler(this.txtcustomer_TextChanged);
            // 
            // DateTimePicker2
            // 
            this.DateTimePicker2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.DateTimePicker2.Location = new System.Drawing.Point(466, 588);
            this.DateTimePicker2.Name = "DateTimePicker2";
            this.DateTimePicker2.Size = new System.Drawing.Size(254, 26);
            this.DateTimePicker2.TabIndex = 36;
            this.DateTimePicker2.ValueChanged += new System.EventHandler(this.DateTimePicker2_ValueChanged);
            // 
            // Label8
            // 
            this.Label8.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(343, 594);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(125, 20);
            this.Label8.TabIndex = 37;
            this.Label8.Text = "To Second Date";
            this.Label8.Click += new System.EventHandler(this.Label8_Click);
            // 
            // txtpassword1
            // 
            this.txtpassword1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtpassword1.Location = new System.Drawing.Point(47, 20);
            this.txtpassword1.Name = "txtpassword1";
            this.txtpassword1.PasswordChar = '*';
            this.txtpassword1.ReadOnly = true;
            this.txtpassword1.Size = new System.Drawing.Size(142, 26);
            this.txtpassword1.TabIndex = 38;
            // 
            // lbaddress
            // 
            this.lbaddress.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbaddress.AutoSize = true;
            this.lbaddress.BackColor = System.Drawing.Color.Black;
            this.lbaddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbaddress.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbaddress.Location = new System.Drawing.Point(484, 48);
            this.lbaddress.Name = "lbaddress";
            this.lbaddress.Size = new System.Drawing.Size(27, 18);
            this.lbaddress.TabIndex = 40;
            this.lbaddress.Text = "lb2";
            // 
            // lbname
            // 
            this.lbname.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbname.AutoSize = true;
            this.lbname.BackColor = System.Drawing.Color.Red;
            this.lbname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbname.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbname.Location = new System.Drawing.Point(545, 9);
            this.lbname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbname.Name = "lbname";
            this.lbname.Size = new System.Drawing.Size(44, 25);
            this.lbname.TabIndex = 39;
            this.lbname.Text = "lb1";
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(232, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(163, 45);
            this.button2.TabIndex = 59;
            this.button2.Text = "Cancel Sales";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // drugslog
            // 
            this.AcceptButton = this.Button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1294, 782);
            this.Controls.Add(this.button2);
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
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "drugslog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Product Sales log";
            this.Load += new System.EventHandler(this.saleslog_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.drugslog_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.dgvsaleslog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		internal System.Windows.Forms.DataGridView dgvsaleslog;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.TextBox txttotalsales;
		internal System.Windows.Forms.TextBox txttotaprofit;
		internal System.Windows.Forms.Button Button1;
		internal System.Windows.Forms.DateTimePicker DateTimePicker1;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.ComboBox cbocashier;
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.Label Label7;
		internal System.Windows.Forms.TextBox txtcustomer;
		internal System.Windows.Forms.DateTimePicker DateTimePicker2;
		internal System.Windows.Forms.Label Label8;
		internal System.Drawing.Printing.PrintDocument PrintDocument1;
		internal System.Windows.Forms.TextBox txtpassword1;
		internal System.Windows.Forms.Label lbaddress;
		internal System.Windows.Forms.Label lbname;
        private System.Windows.Forms.Button button2;
    }

}