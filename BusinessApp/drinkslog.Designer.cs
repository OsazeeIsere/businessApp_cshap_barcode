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
	public partial class drinkslog : System.Windows.Forms.Form
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
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			this.Label8 = new System.Windows.Forms.Label();
			this.DateTimePicker2 = new System.Windows.Forms.DateTimePicker();
			this.txtcustomer = new System.Windows.Forms.TextBox();
			this.Label7 = new System.Windows.Forms.Label();
			this.Label4 = new System.Windows.Forms.Label();
			this.cbocashier = new System.Windows.Forms.ComboBox();
			this.Label3 = new System.Windows.Forms.Label();
			this.DateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.btndrinkslog = new System.Windows.Forms.Button();
			this.txttotaprofit = new System.Windows.Forms.TextBox();
			this.txttotalsales = new System.Windows.Forms.TextBox();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.dgvdrinkslog = new System.Windows.Forms.DataGridView();
			this.Label9 = new System.Windows.Forms.Label();
			this.Label10 = new System.Windows.Forms.Label();
			this.txtpassword1 = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)this.dgvdrinkslog).BeginInit();
			this.SuspendLayout();
			//
			//Label8
			//
			this.Label8.AutoSize = true;
			this.Label8.Location = new System.Drawing.Point(342, 481);
			this.Label8.Name = "Label8";
			this.Label8.Size = new System.Drawing.Size(108, 19);
			this.Label8.TabIndex = 53;
			this.Label8.Text = "To Second Date";
			//
			//DateTimePicker2
			//
			this.DateTimePicker2.Location = new System.Drawing.Point(465, 475);
			this.DateTimePicker2.Name = "DateTimePicker2";
			this.DateTimePicker2.Size = new System.Drawing.Size(254, 26);
			this.DateTimePicker2.TabIndex = 52;
			//
			//txtcustomer
			//
			this.txtcustomer.Location = new System.Drawing.Point(970, 519);
			this.txtcustomer.Name = "txtcustomer";
			this.txtcustomer.Size = new System.Drawing.Size(101, 26);
			this.txtcustomer.TabIndex = 51;
			//
			//Label7
			//
			this.Label7.AutoSize = true;
			this.Label7.Location = new System.Drawing.Point(827, 522);
			this.Label7.Name = "Label7";
			this.Label7.Size = new System.Drawing.Size(131, 19);
			this.Label7.TabIndex = 50;
			this.Label7.Text = "Customer Response";
			//
			//Label4
			//
			this.Label4.AutoSize = true;
			this.Label4.Location = new System.Drawing.Point(342, 420);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(106, 19);
			this.Label4.TabIndex = 49;
			this.Label4.Text = "From First Date";
			//
			//cbocashier
			//
			this.cbocashier.FormattingEnabled = true;
			this.cbocashier.Location = new System.Drawing.Point(145, 417);
			this.cbocashier.Name = "cbocashier";
			this.cbocashier.Size = new System.Drawing.Size(170, 27);
			this.cbocashier.TabIndex = 48;
			//
			//Label3
			//
			this.Label3.AutoSize = true;
			this.Label3.Location = new System.Drawing.Point(27, 420);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(96, 19);
			this.Label3.TabIndex = 47;
			this.Label3.Text = "Select Cashier";
			//
			//DateTimePicker1
			//
			this.DateTimePicker1.Location = new System.Drawing.Point(460, 417);
			this.DateTimePicker1.Name = "DateTimePicker1";
			this.DateTimePicker1.Size = new System.Drawing.Size(260, 26);
			this.DateTimePicker1.TabIndex = 46;
			//
			//btndrinkslog
			//
			this.btndrinkslog.Location = new System.Drawing.Point(465, 522);
			this.btndrinkslog.Name = "btndrinkslog";
			this.btndrinkslog.Size = new System.Drawing.Size(254, 31);
			this.btndrinkslog.TabIndex = 45;
			this.btndrinkslog.Text = "Sales For The Cashier";
			this.btndrinkslog.UseVisualStyleBackColor = true;
			//
			//txttotaprofit
			//
			this.txttotaprofit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.txttotaprofit.Location = new System.Drawing.Point(970, 471);
			this.txttotaprofit.Name = "txttotaprofit";
			this.txttotaprofit.Size = new System.Drawing.Size(101, 29);
			this.txttotaprofit.TabIndex = 44;
			//
			//txttotalsales
			//
			this.txttotalsales.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.txttotalsales.Location = new System.Drawing.Point(970, 418);
			this.txttotalsales.Name = "txttotalsales";
			this.txttotalsales.Size = new System.Drawing.Size(101, 31);
			this.txttotalsales.TabIndex = 43;
			//
			//Label2
			//
			this.Label2.AutoSize = true;
			this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label2.Location = new System.Drawing.Point(861, 473);
			this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(97, 24);
			this.Label2.TabIndex = 42;
			this.Label2.Text = "Total Profit";
			//
			//Label1
			//
			this.Label1.AutoSize = true;
			this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label1.Location = new System.Drawing.Point(806, 421);
			this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(165, 24);
			this.Label1.TabIndex = 41;
			this.Label1.Text = "Total Amount Sold";
			//
			//dgvdrinkslog
			//
			this.dgvdrinkslog.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvdrinkslog.BackgroundColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(255)), Convert.ToInt32(Convert.ToByte(192)), Convert.ToInt32(Convert.ToByte(192)));
			this.dgvdrinkslog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(255)), Convert.ToInt32(Convert.ToByte(224)), Convert.ToInt32(Convert.ToByte(192)));
			DataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
			DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(255)), Convert.ToInt32(Convert.ToByte(128)), Convert.ToInt32(Convert.ToByte(255)));
			DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvdrinkslog.DefaultCellStyle = DataGridViewCellStyle1;
			this.dgvdrinkslog.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.dgvdrinkslog.Location = new System.Drawing.Point(13, 86);
			this.dgvdrinkslog.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.dgvdrinkslog.Name = "dgvdrinkslog";
			this.dgvdrinkslog.Size = new System.Drawing.Size(1248, 316);
			this.dgvdrinkslog.TabIndex = 38;
			//
			//Label9
			//
			this.Label9.AutoSize = true;
			this.Label9.BackColor = System.Drawing.Color.White;
			this.Label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label9.ForeColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(64)), Convert.ToInt32(Convert.ToByte(0)), Convert.ToInt32(Convert.ToByte(64)));
			this.Label9.Location = new System.Drawing.Point(440, 47);
			this.Label9.Name = "Label9";
			this.Label9.Size = new System.Drawing.Size(381, 24);
			this.Label9.TabIndex = 55;
			this.Label9.Text = "No. 218, 2nd, East Circular Road, Benin City.";
			//
			//Label10
			//
			this.Label10.AutoSize = true;
			this.Label10.BackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(64)), Convert.ToInt32(Convert.ToByte(0)), Convert.ToInt32(Convert.ToByte(64)));
			this.Label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label10.ForeColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(192)), Convert.ToInt32(Convert.ToByte(255)), Convert.ToInt32(Convert.ToByte(192)));
			this.Label10.Location = new System.Drawing.Point(341, 9);
			this.Label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label10.Name = "Label10";
			this.Label10.Size = new System.Drawing.Size(642, 25);
			this.Label10.TabIndex = 54;
			this.Label10.Text = "WELCOME TO JULIA AND SYL PHARMACY  AND STORES ";
			//
			//txtpassword1
			//
			this.txtpassword1.Location = new System.Drawing.Point(23, 8);
			this.txtpassword1.Name = "txtpassword1";
			this.txtpassword1.PasswordChar = (char)42;
			this.txtpassword1.Size = new System.Drawing.Size(178, 26);
			this.txtpassword1.TabIndex = 56;
			//
			//drinkslog
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(9.0F, 19.0F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(255)), Convert.ToInt32(Convert.ToByte(128)), Convert.ToInt32(Convert.ToByte(0)));
			this.ClientSize = new System.Drawing.Size(1284, 627);
			this.Controls.Add(this.txtpassword1);
			this.Controls.Add(this.Label9);
			this.Controls.Add(this.Label10);
			this.Controls.Add(this.Label8);
			this.Controls.Add(this.DateTimePicker2);
			this.Controls.Add(this.txtcustomer);
			this.Controls.Add(this.Label7);
			this.Controls.Add(this.Label4);
			this.Controls.Add(this.cbocashier);
			this.Controls.Add(this.Label3);
			this.Controls.Add(this.DateTimePicker1);
			this.Controls.Add(this.btndrinkslog);
			this.Controls.Add(this.txttotaprofit);
			this.Controls.Add(this.txttotalsales);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.dgvdrinkslog);
			this.Font = new System.Drawing.Font("Times New Roman", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "drinkslog";
			this.Text = "Drinks Sales log";
			((System.ComponentModel.ISupportInitialize)this.dgvdrinkslog).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

//INSTANT C# NOTE: Converted design-time event handler wireups:
			btndrinkslog.Click += new System.EventHandler(Button1_Click);
			base.Load += new System.EventHandler(drinkslog_Load);
			Label9.Click += new System.EventHandler(Label9_Click);
			Label10.Click += new System.EventHandler(Label10_Click);
		}
		internal System.Windows.Forms.Label Label8;
		internal System.Windows.Forms.DateTimePicker DateTimePicker2;
		internal System.Windows.Forms.TextBox txtcustomer;
		internal System.Windows.Forms.Label Label7;
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.ComboBox cbocashier;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.DateTimePicker DateTimePicker1;
		internal System.Windows.Forms.Button btndrinkslog;
		internal System.Windows.Forms.TextBox txttotaprofit;
		internal System.Windows.Forms.TextBox txttotalsales;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.DataGridView dgvdrinkslog;
		internal System.Windows.Forms.Label Label9;
		internal System.Windows.Forms.Label Label10;
		internal System.Windows.Forms.TextBox txtpassword1;
	}

}