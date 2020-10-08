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
            this.lbaddress = new System.Windows.Forms.Label();
            this.lbname = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsaleslog)).BeginInit();
            this.SuspendLayout();
            // 
            // Label8
            // 
            this.Label8.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(324, 482);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(125, 20);
            this.Label8.TabIndex = 69;
            this.Label8.Text = "To Second Date";
            // 
            // DateTimePicker2
            // 
            this.DateTimePicker2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.DateTimePicker2.Location = new System.Drawing.Point(447, 476);
            this.DateTimePicker2.Name = "DateTimePicker2";
            this.DateTimePicker2.Size = new System.Drawing.Size(254, 26);
            this.DateTimePicker2.TabIndex = 68;
            // 
            // txtcustomer
            // 
            this.txtcustomer.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtcustomer.Location = new System.Drawing.Point(894, 520);
            this.txtcustomer.Name = "txtcustomer";
            this.txtcustomer.Size = new System.Drawing.Size(101, 26);
            this.txtcustomer.TabIndex = 67;
            // 
            // Label7
            // 
            this.Label7.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(727, 523);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(155, 20);
            this.Label7.TabIndex = 66;
            this.Label7.Text = "Customer Response";
            // 
            // Label4
            // 
            this.Label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(324, 421);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(120, 20);
            this.Label4.TabIndex = 65;
            this.Label4.Text = "From First Date";
            // 
            // cbocashier
            // 
            this.cbocashier.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cbocashier.FormattingEnabled = true;
            this.cbocashier.Location = new System.Drawing.Point(127, 418);
            this.cbocashier.Name = "cbocashier";
            this.cbocashier.Size = new System.Drawing.Size(163, 28);
            this.cbocashier.TabIndex = 64;
            // 
            // Label3
            // 
            this.Label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(9, 421);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(112, 20);
            this.Label3.TabIndex = 63;
            this.Label3.Text = "Select Cashier";
            // 
            // DateTimePicker1
            // 
            this.DateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.DateTimePicker1.Location = new System.Drawing.Point(442, 418);
            this.DateTimePicker1.Name = "DateTimePicker1";
            this.DateTimePicker1.Size = new System.Drawing.Size(260, 26);
            this.DateTimePicker1.TabIndex = 62;
            // 
            // Button1
            // 
            this.Button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
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
            this.txttotaprofit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txttotaprofit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotaprofit.Location = new System.Drawing.Point(894, 472);
            this.txttotaprofit.Name = "txttotaprofit";
            this.txttotaprofit.Size = new System.Drawing.Size(101, 29);
            this.txttotaprofit.TabIndex = 60;
            // 
            // txttotalsales
            // 
            this.txttotalsales.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txttotalsales.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotalsales.Location = new System.Drawing.Point(894, 419);
            this.txttotalsales.Name = "txttotalsales";
            this.txttotalsales.Size = new System.Drawing.Size(101, 31);
            this.txttotalsales.TabIndex = 59;
            // 
            // Label2
            // 
            this.Label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
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
            this.Label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
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
            this.dgvsaleslog.Location = new System.Drawing.Point(19, 71);
            this.dgvsaleslog.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvsaleslog.Name = "dgvsaleslog";
            this.dgvsaleslog.Size = new System.Drawing.Size(1017, 334);
            this.dgvsaleslog.TabIndex = 54;
            // 
            // lbaddress
            // 
            this.lbaddress.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbaddress.AutoSize = true;
            this.lbaddress.BackColor = System.Drawing.Color.Red;
            this.lbaddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbaddress.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbaddress.Location = new System.Drawing.Point(379, 48);
            this.lbaddress.Name = "lbaddress";
            this.lbaddress.Size = new System.Drawing.Size(27, 18);
            this.lbaddress.TabIndex = 71;
            this.lbaddress.Text = "lb2";
            // 
            // lbname
            // 
            this.lbname.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbname.AutoSize = true;
            this.lbname.BackColor = System.Drawing.Color.Red;
            this.lbname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbname.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbname.Location = new System.Drawing.Point(437, 9);
            this.lbname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbname.Name = "lbname";
            this.lbname.Size = new System.Drawing.Size(44, 25);
            this.lbname.TabIndex = 70;
            this.lbname.Text = "lb1";
            this.lbname.Click += new System.EventHandler(this.Label6_Click);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 463);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 20);
            this.label9.TabIndex = 72;
            this.label9.Text = "label9";
            // 
            // admingenerasaleslog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1049, 669);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbaddress);
            this.Controls.Add(this.lbname);
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
            this.Name = "admingenerasaleslog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
		internal System.Windows.Forms.Label lbaddress;
		internal System.Windows.Forms.Label lbname;
        private System.Windows.Forms.Label label9;
    }

}