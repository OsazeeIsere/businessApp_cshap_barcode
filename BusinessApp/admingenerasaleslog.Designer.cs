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
	public partial class admingenerasaleslog : System.Windows.Forms.Form
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
            this.Label5 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsaleslog)).BeginInit();
            this.SuspendLayout();
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(324, 482);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(125, 20);
            this.Label8.TabIndex = 69;
            this.Label8.Text = "To Second Date";
            // 
            // DateTimePicker2
            // 
            this.DateTimePicker2.Location = new System.Drawing.Point(447, 476);
            this.DateTimePicker2.Name = "DateTimePicker2";
            this.DateTimePicker2.Size = new System.Drawing.Size(254, 26);
            this.DateTimePicker2.TabIndex = 68;
            // 
            // txtcustomer
            // 
            this.txtcustomer.Location = new System.Drawing.Point(894, 520);
            this.txtcustomer.Name = "txtcustomer";
            this.txtcustomer.Size = new System.Drawing.Size(101, 26);
            this.txtcustomer.TabIndex = 67;
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(727, 523);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(155, 20);
            this.Label7.TabIndex = 66;
            this.Label7.Text = "Customer Response";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(324, 421);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(120, 20);
            this.Label4.TabIndex = 65;
            this.Label4.Text = "From First Date";
            // 
            // cbocashier
            // 
            this.cbocashier.FormattingEnabled = true;
            this.cbocashier.Location = new System.Drawing.Point(127, 418);
            this.cbocashier.Name = "cbocashier";
            this.cbocashier.Size = new System.Drawing.Size(163, 28);
            this.cbocashier.TabIndex = 64;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(9, 421);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(112, 20);
            this.Label3.TabIndex = 63;
            this.Label3.Text = "Select Cashier";
            // 
            // DateTimePicker1
            // 
            this.DateTimePicker1.Location = new System.Drawing.Point(442, 418);
            this.DateTimePicker1.Name = "DateTimePicker1";
            this.DateTimePicker1.Size = new System.Drawing.Size(260, 26);
            this.DateTimePicker1.TabIndex = 62;
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(447, 523);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(254, 31);
            this.Button1.TabIndex = 61;
            this.Button1.Text = "Sales For The Cashier";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // txttotaprofit
            // 
            this.txttotaprofit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotaprofit.Location = new System.Drawing.Point(894, 472);
            this.txttotaprofit.Name = "txttotaprofit";
            this.txttotaprofit.Size = new System.Drawing.Size(101, 29);
            this.txttotaprofit.TabIndex = 60;
            // 
            // txttotalsales
            // 
            this.txttotalsales.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotalsales.Location = new System.Drawing.Point(894, 419);
            this.txttotalsales.Name = "txttotalsales";
            this.txttotalsales.Size = new System.Drawing.Size(101, 31);
            this.txttotalsales.TabIndex = 59;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(785, 474);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(97, 24);
            this.Label2.TabIndex = 58;
            this.Label2.Text = "Total Profit";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(730, 422);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(165, 24);
            this.Label1.TabIndex = 57;
            this.Label1.Text = "Total Amount Sold";
            // 
            // dgvsaleslog
            // 
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
            this.dgvsaleslog.Location = new System.Drawing.Point(13, 83);
            this.dgvsaleslog.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvsaleslog.Name = "dgvsaleslog";
            this.dgvsaleslog.Size = new System.Drawing.Size(1017, 334);
            this.dgvsaleslog.TabIndex = 54;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.BackColor = System.Drawing.Color.Red;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Label5.Location = new System.Drawing.Point(379, 48);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(269, 18);
            this.Label5.TabIndex = 71;
            this.Label5.Text = "Okha Market , Sapele Road, Benin City.\r\n";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.BackColor = System.Drawing.Color.Red;
            this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Label6.Location = new System.Drawing.Point(355, 9);
            this.Label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(336, 25);
            this.Label6.TabIndex = 70;
            this.Label6.Text = "WELCOME TO TRENDY SHOP\r\n";
            this.Label6.Click += new System.EventHandler(this.Label6_Click);
            // 
            // admingenerasaleslog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1049, 669);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label6);
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
            this.Name = "admingenerasaleslog";
            this.Text = "admingenerasaleslog";
            this.Load += new System.EventHandler(this.admingenerasaleslog_Load);
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
		internal System.Windows.Forms.Label Label5;
		internal System.Windows.Forms.Label Label6;
	}

}