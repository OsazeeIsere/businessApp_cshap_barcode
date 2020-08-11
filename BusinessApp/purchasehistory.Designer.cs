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
	public partial class purchasehistory : System.Windows.Forms.Form
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
            this.Label8 = new System.Windows.Forms.Label();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.lsvitems = new System.Windows.Forms.ListView();
            this.ColumnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.check = new System.Windows.Forms.Button();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbaddress = new System.Windows.Forms.Label();
            this.lbname = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(212, 251);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(60, 20);
            this.Label8.TabIndex = 87;
            this.Label8.Text = "Search";
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(83, 240);
            this.txtsearch.Multiline = true;
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(123, 31);
            this.txtsearch.TabIndex = 86;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // txttotal
            // 
            this.txttotal.Location = new System.Drawing.Point(296, 177);
            this.txttotal.Multiline = true;
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(82, 32);
            this.txttotal.TabIndex = 85;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(5, 189);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(285, 20);
            this.Label2.TabIndex = 84;
            this.Label2.Text = "The Total Number of Products Affected";
            // 
            // lsvitems
            // 
            this.lsvitems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader2,
            this.ColumnHeader3,
            this.ColumnHeader4,
            this.ColumnHeader5,
            this.ColumnHeader6,
            this.ColumnHeader1,
            this.ColumnHeader11,
            this.ColumnHeader7,
            this.ColumnHeader8,
            this.ColumnHeader9,
            this.ColumnHeader10});
            this.lsvitems.FullRowSelect = true;
            this.lsvitems.GridLines = true;
            this.lsvitems.Location = new System.Drawing.Point(12, 289);
            this.lsvitems.Name = "lsvitems";
            this.lsvitems.ShowItemToolTips = true;
            this.lsvitems.Size = new System.Drawing.Size(1260, 445);
            this.lsvitems.TabIndex = 83;
            this.lsvitems.UseCompatibleStateImageBehavior = false;
            this.lsvitems.View = System.Windows.Forms.View.Details;
            // 
            // ColumnHeader2
            // 
            this.ColumnHeader2.Text = "productname ";
            this.ColumnHeader2.Width = 134;
            // 
            // ColumnHeader3
            // 
            this.ColumnHeader3.Text = "quantity";
            this.ColumnHeader3.Width = 94;
            // 
            // ColumnHeader4
            // 
            this.ColumnHeader4.Text = "unitcostprice";
            this.ColumnHeader4.Width = 142;
            // 
            // ColumnHeader5
            // 
            this.ColumnHeader5.Text = "unitsalesprice";
            this.ColumnHeader5.Width = 113;
            // 
            // ColumnHeader6
            // 
            this.ColumnHeader6.Text = "expirydate";
            this.ColumnHeader6.Width = 104;
            // 
            // ColumnHeader1
            // 
            this.ColumnHeader1.Text = "Supplier Name";
            this.ColumnHeader1.Width = 125;
            // 
            // ColumnHeader11
            // 
            this.ColumnHeader11.Text = "Supplier Tel:";
            this.ColumnHeader11.Width = 116;
            // 
            // ColumnHeader7
            // 
            this.ColumnHeader7.Text = "Date Purchased";
            this.ColumnHeader7.Width = 128;
            // 
            // ColumnHeader8
            // 
            this.ColumnHeader8.Text = "Amount Paid";
            this.ColumnHeader8.Width = 110;
            // 
            // ColumnHeader9
            // 
            this.ColumnHeader9.Text = "Invoice Number";
            this.ColumnHeader9.Width = 116;
            // 
            // ColumnHeader10
            // 
            this.ColumnHeader10.Text = "entrydate";
            this.ColumnHeader10.Width = 87;
            // 
            // DateTimePicker1
            // 
            this.DateTimePicker1.Location = new System.Drawing.Point(736, 119);
            this.DateTimePicker1.Name = "DateTimePicker1";
            this.DateTimePicker1.Size = new System.Drawing.Size(261, 26);
            this.DateTimePicker1.TabIndex = 82;
            // 
            // check
            // 
            this.check.Location = new System.Drawing.Point(479, 171);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(223, 38);
            this.check.TabIndex = 81;
            this.check.Text = "Clear";
            this.check.UseVisualStyleBackColor = true;
            this.check.Click += new System.EventHandler(this.check_Click);
            // 
            // PictureBox1
            // 
            this.PictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PictureBox1.Image = global::BusinessApp.Properties.Resources.search2;
            this.PictureBox1.Location = new System.Drawing.Point(10, 240);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(67, 31);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox1.TabIndex = 88;
            this.PictureBox1.TabStop = false;
            // 
            // lbaddress
            // 
            this.lbaddress.AutoSize = true;
            this.lbaddress.BackColor = System.Drawing.Color.Black;
            this.lbaddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbaddress.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbaddress.Location = new System.Drawing.Point(499, 56);
            this.lbaddress.Name = "lbaddress";
            this.lbaddress.Size = new System.Drawing.Size(33, 20);
            this.lbaddress.TabIndex = 90;
            this.lbaddress.Text = "lb2";
            // 
            // lbname
            // 
            this.lbname.AutoSize = true;
            this.lbname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbname.ForeColor = System.Drawing.Color.Red;
            this.lbname.Location = new System.Drawing.Point(489, 22);
            this.lbname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbname.Name = "lbname";
            this.lbname.Size = new System.Drawing.Size(44, 25);
            this.lbname.TabIndex = 89;
            this.lbname.Text = "lb1";
            // 
            // purchasehistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 774);
            this.Controls.Add(this.lbaddress);
            this.Controls.Add(this.lbname);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.lsvitems);
            this.Controls.Add(this.DateTimePicker1);
            this.Controls.Add(this.check);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "purchasehistory";
            this.Text = "purchasehistory";
            this.Load += new System.EventHandler(this.purchasehistory_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.purchasehistory_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		internal System.Windows.Forms.PictureBox PictureBox1;
		internal System.Windows.Forms.Label Label8;
		internal System.Windows.Forms.TextBox txtsearch;
		internal System.Windows.Forms.TextBox txttotal;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.ListView lsvitems;
		internal System.Windows.Forms.ColumnHeader ColumnHeader2;
		internal System.Windows.Forms.ColumnHeader ColumnHeader3;
		internal System.Windows.Forms.ColumnHeader ColumnHeader4;
		internal System.Windows.Forms.ColumnHeader ColumnHeader5;
		internal System.Windows.Forms.ColumnHeader ColumnHeader6;
		internal System.Windows.Forms.ColumnHeader ColumnHeader1;
		internal System.Windows.Forms.ColumnHeader ColumnHeader11;
		internal System.Windows.Forms.ColumnHeader ColumnHeader7;
		internal System.Windows.Forms.ColumnHeader ColumnHeader8;
		internal System.Windows.Forms.ColumnHeader ColumnHeader9;
		internal System.Windows.Forms.ColumnHeader ColumnHeader10;
		internal System.Windows.Forms.DateTimePicker DateTimePicker1;
		internal System.Windows.Forms.Button check;
		internal System.Windows.Forms.Label lbaddress;
		internal System.Windows.Forms.Label lbname;
	}

}