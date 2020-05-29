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
	public partial class expirydateinfo : System.Windows.Forms.Form
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
            this.ComboBox1 = new System.Windows.Forms.ComboBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.check = new System.Windows.Forms.Button();
            this.DateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lsvitems = new System.Windows.Forms.ListView();
            this.ColumnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.Label2 = new System.Windows.Forms.Label();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.import = new System.Windows.Forms.Button();
            this.txtitems = new System.Windows.Forms.TextBox();
            this.txtfile = new System.Windows.Forms.TextBox();
            this.OpenFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ComboBox1
            // 
            this.ComboBox1.FormattingEnabled = true;
            this.ComboBox1.Items.AddRange(new object[] {
            "All Drugs",
            "Drugs That Will Expire This Month",
            "Three Months(3) Time",
            "Six Months(6) Time",
            "Above Six Months(6) Time",
            "Drugs Already Expired"});
            this.ComboBox1.Location = new System.Drawing.Point(120, 100);
            this.ComboBox1.Name = "ComboBox1";
            this.ComboBox1.Size = new System.Drawing.Size(262, 28);
            this.ComboBox1.TabIndex = 60;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(12, 103);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(103, 20);
            this.Label1.TabIndex = 61;
            this.Label1.Text = "Select Period";
            // 
            // check
            // 
            this.check.Location = new System.Drawing.Point(391, 94);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(223, 38);
            this.check.TabIndex = 62;
            this.check.Text = "Checked";
            this.check.UseVisualStyleBackColor = true;
            this.check.Click += new System.EventHandler(this.Button1_Click);
            // 
            // DateTimePicker1
            // 
            this.DateTimePicker1.Location = new System.Drawing.Point(740, 108);
            this.DateTimePicker1.Name = "DateTimePicker1";
            this.DateTimePicker1.Size = new System.Drawing.Size(261, 26);
            this.DateTimePicker1.TabIndex = 63;
            // 
            // lsvitems
            // 
            this.lsvitems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader13,
            this.ColumnHeader12,
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
            this.lsvitems.Location = new System.Drawing.Point(4, 290);
            this.lsvitems.Name = "lsvitems";
            this.lsvitems.ShowItemToolTips = true;
            this.lsvitems.Size = new System.Drawing.Size(1268, 436);
            this.lsvitems.TabIndex = 70;
            this.lsvitems.UseCompatibleStateImageBehavior = false;
            this.lsvitems.View = System.Windows.Forms.View.Details;
            this.lsvitems.SelectedIndexChanged += new System.EventHandler(this.lsvitems_SelectedIndexChanged);
            // 
            // ColumnHeader13
            // 
            this.ColumnHeader13.Text = "ExpirydateID";
            // 
            // ColumnHeader12
            // 
            this.ColumnHeader12.Text = "ProductID";
            this.ColumnHeader12.Width = 90;
            // 
            // ColumnHeader2
            // 
            this.ColumnHeader2.Text = "productname ";
            this.ColumnHeader2.Width = 406;
            // 
            // ColumnHeader3
            // 
            this.ColumnHeader3.Text = "quantity";
            this.ColumnHeader3.Width = 72;
            // 
            // ColumnHeader4
            // 
            this.ColumnHeader4.Text = "unitcostprice";
            this.ColumnHeader4.Width = 98;
            // 
            // ColumnHeader5
            // 
            this.ColumnHeader5.Text = "unitsalesprice";
            this.ColumnHeader5.Width = 100;
            // 
            // ColumnHeader6
            // 
            this.ColumnHeader6.Text = "expirydate";
            this.ColumnHeader6.Width = 104;
            // 
            // ColumnHeader1
            // 
            this.ColumnHeader1.Text = "Supplier Name";
            this.ColumnHeader1.Width = 113;
            // 
            // ColumnHeader11
            // 
            this.ColumnHeader11.Text = "Supplier Tel:";
            this.ColumnHeader11.Width = 116;
            // 
            // ColumnHeader7
            // 
            this.ColumnHeader7.Text = "Date Purchased";
            this.ColumnHeader7.Width = 118;
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
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(9, 178);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(285, 20);
            this.Label2.TabIndex = 71;
            this.Label2.Text = "The Total Number of Products Affected";
            // 
            // txttotal
            // 
            this.txttotal.Location = new System.Drawing.Point(300, 166);
            this.txttotal.Multiline = true;
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(82, 32);
            this.txttotal.TabIndex = 72;
            // 
            // PictureBox1
            // 
            this.PictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PictureBox1.Image = global::BusinessApp.Properties.Resources.search2;
            this.PictureBox1.Location = new System.Drawing.Point(14, 229);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(67, 31);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox1.TabIndex = 78;
            this.PictureBox1.TabStop = false;
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(216, 240);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(60, 20);
            this.Label8.TabIndex = 77;
            this.Label8.Text = "Search";
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(87, 229);
            this.txtsearch.Multiline = true;
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(123, 31);
            this.txtsearch.TabIndex = 76;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // import
            // 
            this.import.Location = new System.Drawing.Point(788, 166);
            this.import.Name = "import";
            this.import.Size = new System.Drawing.Size(128, 49);
            this.import.TabIndex = 73;
            this.import.Text = "Import for The\r\n    First Time";
            this.import.UseVisualStyleBackColor = true;
            this.import.Click += new System.EventHandler(this.Button4_Click);
            // 
            // txtitems
            // 
            this.txtitems.Location = new System.Drawing.Point(922, 166);
            this.txtitems.Multiline = true;
            this.txtitems.Name = "txtitems";
            this.txtitems.Size = new System.Drawing.Size(62, 41);
            this.txtitems.TabIndex = 75;
            // 
            // txtfile
            // 
            this.txtfile.Location = new System.Drawing.Point(582, 174);
            this.txtfile.Name = "txtfile";
            this.txtfile.Size = new System.Drawing.Size(196, 26);
            this.txtfile.TabIndex = 74;
            // 
            // OpenFileDialog1
            // 
            this.OpenFileDialog1.FileName = "OpenFileDialog1";
            this.OpenFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.OpenFileDialog1_FileOk);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label3.Location = new System.Drawing.Point(472, 57);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(269, 18);
            this.Label3.TabIndex = 80;
            this.Label3.Text = "Okha Market , Sapele Road, Benin City.\r\n";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label4.Location = new System.Drawing.Point(442, 21);
            this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(336, 25);
            this.Label4.TabIndex = 79;
            this.Label4.Text = "WELCOME TO TRENDY SHOP\r\n";
            // 
            // expirydateinfo
            // 
            this.AcceptButton = this.check;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1284, 782);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.import);
            this.Controls.Add(this.txtitems);
            this.Controls.Add(this.txtfile);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.lsvitems);
            this.Controls.Add(this.DateTimePicker1);
            this.Controls.Add(this.check);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.ComboBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "expirydateinfo";
            this.Text = "Expiry Date Info";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.expirydateinfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		internal System.Windows.Forms.ComboBox ComboBox1;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.Button check;
		internal System.Windows.Forms.DateTimePicker DateTimePicker1;
		internal System.Windows.Forms.ListView lsvitems;
		internal System.Windows.Forms.ColumnHeader ColumnHeader2;
		internal System.Windows.Forms.ColumnHeader ColumnHeader3;
		internal System.Windows.Forms.ColumnHeader ColumnHeader4;
		internal System.Windows.Forms.ColumnHeader ColumnHeader5;
		internal System.Windows.Forms.ColumnHeader ColumnHeader6;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.TextBox txttotal;
		internal System.Windows.Forms.PictureBox PictureBox1;
		internal System.Windows.Forms.Label Label8;
		internal System.Windows.Forms.TextBox txtsearch;
		internal System.Windows.Forms.Button import;
		internal System.Windows.Forms.TextBox txtitems;
		internal System.Windows.Forms.TextBox txtfile;
		internal System.Windows.Forms.OpenFileDialog OpenFileDialog1;
		internal System.Windows.Forms.ColumnHeader ColumnHeader1;
		internal System.Windows.Forms.ColumnHeader ColumnHeader7;
		internal System.Windows.Forms.ColumnHeader ColumnHeader8;
		internal System.Windows.Forms.ColumnHeader ColumnHeader9;
		internal System.Windows.Forms.ColumnHeader ColumnHeader10;
		internal System.Windows.Forms.ColumnHeader ColumnHeader11;
		internal System.Windows.Forms.ColumnHeader ColumnHeader12;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.ColumnHeader ColumnHeader13;
	}

}