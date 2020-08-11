﻿//INSTANT C# NOTE: Formerly VB project-level imports:
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
	public partial class drugs : System.Windows.Forms.Form
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
            this.components = new System.ComponentModel.Container();
            this.txtunitprice = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.txtquantity = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.Button1 = new System.Windows.Forms.Button();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.Label4 = new System.Windows.Forms.Label();
            this.txtcashiername1 = new System.Windows.Forms.TextBox();
            this.txtproductname = new System.Windows.Forms.TextBox();
            this.Button3 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.txtunitcostprice = new System.Windows.Forms.TextBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.Button4 = new System.Windows.Forms.Button();
            this.OpenFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtfile = new System.Windows.Forms.TextBox();
            this.txtitems = new System.Windows.Forms.TextBox();
            this.PageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.txtexpirydate = new System.Windows.Forms.TextBox();
            this.txtyear = new System.Windows.Forms.TextBox();
            this.txtday = new System.Windows.Forms.TextBox();
            this.DateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.DateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.Label10 = new System.Windows.Forms.Label();
            this.Button5 = new System.Windows.Forms.Button();
            this.Button6 = new System.Windows.Forms.Button();
            this.Button7 = new System.Windows.Forms.Button();
            this.Label11 = new System.Windows.Forms.Label();
            this.txtsuppliername = new System.Windows.Forms.TextBox();
            this.Label12 = new System.Windows.Forms.Label();
            this.txtdatepurchased = new System.Windows.Forms.TextBox();
            this.Label13 = new System.Windows.Forms.Label();
            this.txtamountpaid = new System.Windows.Forms.TextBox();
            this.Label14 = new System.Windows.Forms.Label();
            this.txtinvoicenumber = new System.Windows.Forms.TextBox();
            this.Label15 = new System.Windows.Forms.Label();
            this.txtsupplierphonenumber = new System.Windows.Forms.TextBox();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.Button8 = new System.Windows.Forms.Button();
            this.Label16 = new System.Windows.Forms.Label();
            this.txtadminpassword = new System.Windows.Forms.TextBox();
            this.Button9 = new System.Windows.Forms.Button();
            this.lsvitems = new System.Windows.Forms.ListView();
            this.ColumnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txttotal = new System.Windows.Forms.TextBox();
            this.Label17 = new System.Windows.Forms.Label();
            this.Label18 = new System.Windows.Forms.Label();
            this.txtproductid = new System.Windows.Forms.TextBox();
            this.lbaddress = new System.Windows.Forms.Label();
            this.lbname = new System.Windows.Forms.Label();
            this.txtcode2 = new System.Windows.Forms.TextBox();
            this.btncode = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtunitprice
            // 
            this.txtunitprice.Location = new System.Drawing.Point(545, 92);
            this.txtunitprice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtunitprice.Name = "txtunitprice";
            this.txtunitprice.Size = new System.Drawing.Size(161, 26);
            this.txtunitprice.TabIndex = 12;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(402, 95);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(121, 20);
            this.Label3.TabIndex = 11;
            this.Label3.Text = "Unit Sales Price";
            // 
            // txtquantity
            // 
            this.txtquantity.Location = new System.Drawing.Point(168, 165);
            this.txtquantity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtquantity.Name = "txtquantity";
            this.txtquantity.Size = new System.Drawing.Size(190, 26);
            this.txtquantity.TabIndex = 10;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(77, 168);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(68, 20);
            this.Label2.TabIndex = 9;
            this.Label2.Text = "Quantity";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(24, 133);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(110, 20);
            this.Label1.TabIndex = 7;
            this.Label1.Text = "Product Name";
            // 
            // Button1
            // 
            this.Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button1.Location = new System.Drawing.Point(716, 263);
            this.Button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(196, 76);
            this.Button1.TabIndex = 14;
            this.Button1.Text = "Enter The Product";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(54, 63);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(89, 20);
            this.Label4.TabIndex = 16;
            this.Label4.Text = "User Name";
            // 
            // txtcashiername1
            // 
            this.txtcashiername1.Location = new System.Drawing.Point(166, 61);
            this.txtcashiername1.Name = "txtcashiername1";
            this.txtcashiername1.Size = new System.Drawing.Size(191, 26);
            this.txtcashiername1.TabIndex = 17;
            // 
            // txtproductname
            // 
            this.txtproductname.Location = new System.Drawing.Point(167, 130);
            this.txtproductname.Name = "txtproductname";
            this.txtproductname.Size = new System.Drawing.Size(190, 26);
            this.txtproductname.TabIndex = 18;
            // 
            // Button3
            // 
            this.Button3.Location = new System.Drawing.Point(1119, 197);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(153, 57);
            this.Button3.TabIndex = 19;
            this.Button3.Text = "Sell As Cashier";
            this.Button3.UseVisualStyleBackColor = true;
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // Button2
            // 
            this.Button2.Location = new System.Drawing.Point(952, 265);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(156, 70);
            this.Button2.TabIndex = 20;
            this.Button2.Text = "View sales Log";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.Button2_Click_1);
            // 
            // txtunitcostprice
            // 
            this.txtunitcostprice.Location = new System.Drawing.Point(167, 233);
            this.txtunitcostprice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtunitcostprice.Name = "txtunitcostprice";
            this.txtunitcostprice.Size = new System.Drawing.Size(191, 26);
            this.txtunitcostprice.TabIndex = 24;
            this.txtunitcostprice.Click += new System.EventHandler(this.txtunitcostprice_Click);
            this.txtunitcostprice.TextChanged += new System.EventHandler(this.txtunitcostprice_TextChanged);
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(24, 236);
            this.Label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(114, 20);
            this.Label7.TabIndex = 23;
            this.Label7.Text = "Unit Cost Price";
            // 
            // Button4
            // 
            this.Button4.Location = new System.Drawing.Point(918, 157);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(128, 41);
            this.Button4.TabIndex = 25;
            this.Button4.Text = "Import";
            this.Button4.UseVisualStyleBackColor = true;
            this.Button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // OpenFileDialog1
            // 
            this.OpenFileDialog1.FileName = "OpenFileDialog1";
            this.OpenFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.OpenFileDialog1_FileOk);
            // 
            // txtfile
            // 
            this.txtfile.Location = new System.Drawing.Point(716, 165);
            this.txtfile.Name = "txtfile";
            this.txtfile.Size = new System.Drawing.Size(196, 26);
            this.txtfile.TabIndex = 26;
            this.txtfile.TextChanged += new System.EventHandler(this.txtfile_TextChanged);
            // 
            // txtitems
            // 
            this.txtitems.Location = new System.Drawing.Point(1052, 157);
            this.txtitems.Multiline = true;
            this.txtitems.Name = "txtitems";
            this.txtitems.Size = new System.Drawing.Size(62, 41);
            this.txtitems.TabIndex = 27;
            this.txtitems.TextChanged += new System.EventHandler(this.txtitems_TextChanged);
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(79, 310);
            this.txtsearch.Multiline = true;
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(154, 31);
            this.txtsearch.TabIndex = 28;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            this.txtsearch.QueryContinueDrag += new System.Windows.Forms.QueryContinueDragEventHandler(this.txtsearch_QueryContinueDrag);
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(239, 317);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(60, 20);
            this.Label8.TabIndex = 29;
            this.Label8.Text = "Search";
            this.Label8.Click += new System.EventHandler(this.Label8_Click);
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Location = new System.Drawing.Point(441, 136);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(81, 20);
            this.Label9.TabIndex = 31;
            this.Label9.Text = "expirydate";
            // 
            // txtexpirydate
            // 
            this.txtexpirydate.Location = new System.Drawing.Point(545, 134);
            this.txtexpirydate.Name = "txtexpirydate";
            this.txtexpirydate.Size = new System.Drawing.Size(161, 26);
            this.txtexpirydate.TabIndex = 32;
            // 
            // txtyear
            // 
            this.txtyear.Location = new System.Drawing.Point(355, 953);
            this.txtyear.Name = "txtyear";
            this.txtyear.Size = new System.Drawing.Size(107, 26);
            this.txtyear.TabIndex = 33;
            // 
            // txtday
            // 
            this.txtday.Location = new System.Drawing.Point(653, 953);
            this.txtday.Name = "txtday";
            this.txtday.Size = new System.Drawing.Size(93, 26);
            this.txtday.TabIndex = 35;
            // 
            // DateTimePicker1
            // 
            this.DateTimePicker1.Location = new System.Drawing.Point(27, 953);
            this.DateTimePicker1.Name = "DateTimePicker1";
            this.DateTimePicker1.Size = new System.Drawing.Size(115, 26);
            this.DateTimePicker1.TabIndex = 36;
            // 
            // DateTimePicker2
            // 
            this.DateTimePicker2.Location = new System.Drawing.Point(192, 953);
            this.DateTimePicker2.Name = "DateTimePicker2";
            this.DateTimePicker2.Size = new System.Drawing.Size(102, 26);
            this.DateTimePicker2.TabIndex = 37;
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Location = new System.Drawing.Point(831, 958);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(134, 20);
            this.Label10.TabIndex = 38;
            this.Label10.Text = "Verify Expiry Date";
            // 
            // Button5
            // 
            this.Button5.Location = new System.Drawing.Point(983, 954);
            this.Button5.Name = "Button5";
            this.Button5.Size = new System.Drawing.Size(140, 41);
            this.Button5.TabIndex = 39;
            this.Button5.Text = "Enter";
            this.Button5.UseVisualStyleBackColor = true;
            this.Button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // Button6
            // 
            this.Button6.Location = new System.Drawing.Point(1114, 265);
            this.Button6.Name = "Button6";
            this.Button6.Size = new System.Drawing.Size(158, 70);
            this.Button6.TabIndex = 44;
            this.Button6.Text = "Expiry Date Info.";
            this.Button6.UseVisualStyleBackColor = true;
            this.Button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // Button7
            // 
            this.Button7.Location = new System.Drawing.Point(733, 83);
            this.Button7.Name = "Button7";
            this.Button7.Size = new System.Drawing.Size(143, 49);
            this.Button7.TabIndex = 45;
            this.Button7.Text = "ReOrder Level";
            this.Button7.UseVisualStyleBackColor = true;
            this.Button7.Click += new System.EventHandler(this.Button7_Click);
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Location = new System.Drawing.Point(404, 168);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(113, 20);
            this.Label11.TabIndex = 46;
            this.Label11.Text = "Supplier Name";
            // 
            // txtsuppliername
            // 
            this.txtsuppliername.Location = new System.Drawing.Point(542, 164);
            this.txtsuppliername.Name = "txtsuppliername";
            this.txtsuppliername.Size = new System.Drawing.Size(161, 26);
            this.txtsuppliername.TabIndex = 47;
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.Location = new System.Drawing.Point(404, 241);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(124, 20);
            this.Label12.TabIndex = 48;
            this.Label12.Text = "Date Purchased";
            // 
            // txtdatepurchased
            // 
            this.txtdatepurchased.Location = new System.Drawing.Point(545, 233);
            this.txtdatepurchased.Name = "txtdatepurchased";
            this.txtdatepurchased.Size = new System.Drawing.Size(160, 26);
            this.txtdatepurchased.TabIndex = 49;
            // 
            // Label13
            // 
            this.Label13.AutoSize = true;
            this.Label13.Location = new System.Drawing.Point(30, 205);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(100, 20);
            this.Label13.TabIndex = 50;
            this.Label13.Text = "Amount Paid";
            // 
            // txtamountpaid
            // 
            this.txtamountpaid.Location = new System.Drawing.Point(167, 199);
            this.txtamountpaid.Name = "txtamountpaid";
            this.txtamountpaid.Size = new System.Drawing.Size(191, 26);
            this.txtamountpaid.TabIndex = 51;
            this.txtamountpaid.TextAlignChanged += new System.EventHandler(this.txtamountpaid_TextAlignChanged);
            this.txtamountpaid.TextChanged += new System.EventHandler(this.txtamountpaid_TextChanged);
            // 
            // Label14
            // 
            this.Label14.AutoSize = true;
            this.Label14.Location = new System.Drawing.Point(400, 269);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(119, 20);
            this.Label14.TabIndex = 52;
            this.Label14.Text = "Invoice Number";
            // 
            // txtinvoicenumber
            // 
            this.txtinvoicenumber.Location = new System.Drawing.Point(546, 265);
            this.txtinvoicenumber.Name = "txtinvoicenumber";
            this.txtinvoicenumber.Size = new System.Drawing.Size(157, 26);
            this.txtinvoicenumber.TabIndex = 53;
            // 
            // Label15
            // 
            this.Label15.AutoSize = true;
            this.Label15.Location = new System.Drawing.Point(404, 204);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(96, 20);
            this.Label15.TabIndex = 54;
            this.Label15.Text = "Supplier Tel:";
            // 
            // txtsupplierphonenumber
            // 
            this.txtsupplierphonenumber.Location = new System.Drawing.Point(545, 201);
            this.txtsupplierphonenumber.Name = "txtsupplierphonenumber";
            this.txtsupplierphonenumber.Size = new System.Drawing.Size(161, 26);
            this.txtsupplierphonenumber.TabIndex = 55;
            // 
            // PictureBox1
            // 
            this.PictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PictureBox1.Image = global::BusinessApp.Properties.Resources.search2;
            this.PictureBox1.Location = new System.Drawing.Point(12, 310);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(61, 31);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox1.TabIndex = 30;
            this.PictureBox1.TabStop = false;
            this.PictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // Button8
            // 
            this.Button8.Location = new System.Drawing.Point(1119, 124);
            this.Button8.Name = "Button8";
            this.Button8.Size = new System.Drawing.Size(153, 66);
            this.Button8.TabIndex = 56;
            this.Button8.Text = "Sell As Adninistrator";
            this.Button8.UseVisualStyleBackColor = true;
            this.Button8.Click += new System.EventHandler(this.Button8_Click);
            // 
            // Label16
            // 
            this.Label16.AutoSize = true;
            this.Label16.Location = new System.Drawing.Point(928, 83);
            this.Label16.Name = "Label16";
            this.Label16.Size = new System.Drawing.Size(170, 20);
            this.Label16.TabIndex = 99;
            this.Label16.Text = "Enter Admin Password";
            // 
            // txtadminpassword
            // 
            this.txtadminpassword.Location = new System.Drawing.Point(1113, 83);
            this.txtadminpassword.Name = "txtadminpassword";
            this.txtadminpassword.PasswordChar = '#';
            this.txtadminpassword.Size = new System.Drawing.Size(159, 26);
            this.txtadminpassword.TabIndex = 98;
            // 
            // Button9
            // 
            this.Button9.Location = new System.Drawing.Point(424, 297);
            this.Button9.Name = "Button9";
            this.Button9.Size = new System.Drawing.Size(127, 37);
            this.Button9.TabIndex = 100;
            this.Button9.Text = "Delet Product";
            this.Button9.UseVisualStyleBackColor = true;
            this.Button9.Click += new System.EventHandler(this.Button9_Click);
            // 
            // lsvitems
            // 
            this.lsvitems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader12,
            this.ColumnHeader2,
            this.ColumnHeader3,
            this.ColumnHeader4,
            this.ColumnHeader5,
            this.ColumnHeader6,
            this.ColumnHeader10});
            this.lsvitems.FullRowSelect = true;
            this.lsvitems.GridLines = true;
            this.lsvitems.Location = new System.Drawing.Point(12, 347);
            this.lsvitems.Name = "lsvitems";
            this.lsvitems.ShowItemToolTips = true;
            this.lsvitems.Size = new System.Drawing.Size(1260, 371);
            this.lsvitems.TabIndex = 101;
            this.lsvitems.UseCompatibleStateImageBehavior = false;
            this.lsvitems.View = System.Windows.Forms.View.Details;
            this.lsvitems.SelectedIndexChanged += new System.EventHandler(this.lsvitems_SelectedIndexChanged);
            this.lsvitems.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lsvitems_MouseClick);
            // 
            // ColumnHeader12
            // 
            this.ColumnHeader12.Text = "ID";
            this.ColumnHeader12.Width = 53;
            // 
            // ColumnHeader2
            // 
            this.ColumnHeader2.Text = "Product Name ";
            this.ColumnHeader2.Width = 554;
            // 
            // ColumnHeader3
            // 
            this.ColumnHeader3.Text = "Qty";
            this.ColumnHeader3.Width = 44;
            // 
            // ColumnHeader4
            // 
            this.ColumnHeader4.Text = "S/Price";
            this.ColumnHeader4.Width = 81;
            // 
            // ColumnHeader5
            // 
            this.ColumnHeader5.Text = "C/Price";
            this.ColumnHeader5.Width = 120;
            // 
            // ColumnHeader6
            // 
            this.ColumnHeader6.Text = "Expiry Date";
            this.ColumnHeader6.Width = 149;
            // 
            // ColumnHeader10
            // 
            this.ColumnHeader10.Text = "entrydate";
            this.ColumnHeader10.Width = 339;
            // 
            // txttotal
            // 
            this.txttotal.Location = new System.Drawing.Point(275, 278);
            this.txttotal.Multiline = true;
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(82, 32);
            this.txttotal.TabIndex = 103;
            // 
            // Label17
            // 
            this.Label17.AutoSize = true;
            this.Label17.Location = new System.Drawing.Point(9, 281);
            this.Label17.Name = "Label17";
            this.Label17.Size = new System.Drawing.Size(263, 20);
            this.Label17.TabIndex = 102;
            this.Label17.Text = "The Total Number of Drugs In Stock";
            // 
            // Label18
            // 
            this.Label18.AutoSize = true;
            this.Label18.Location = new System.Drawing.Point(53, 93);
            this.Label18.Name = "Label18";
            this.Label18.Size = new System.Drawing.Size(85, 20);
            this.Label18.TabIndex = 104;
            this.Label18.Text = "Product ID";
            // 
            // txtproductid
            // 
            this.txtproductid.Location = new System.Drawing.Point(166, 93);
            this.txtproductid.Name = "txtproductid";
            this.txtproductid.Size = new System.Drawing.Size(191, 26);
            this.txtproductid.TabIndex = 105;
            // 
            // lbaddress
            // 
            this.lbaddress.AutoSize = true;
            this.lbaddress.BackColor = System.Drawing.Color.Black;
            this.lbaddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbaddress.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbaddress.Location = new System.Drawing.Point(498, 49);
            this.lbaddress.Name = "lbaddress";
            this.lbaddress.Size = new System.Drawing.Size(27, 18);
            this.lbaddress.TabIndex = 107;
            this.lbaddress.Text = "lb2";
            // 
            // lbname
            // 
            this.lbname.AutoSize = true;
            this.lbname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lbname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbname.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbname.Location = new System.Drawing.Point(454, 9);
            this.lbname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbname.Name = "lbname";
            this.lbname.Size = new System.Drawing.Size(44, 25);
            this.lbname.TabIndex = 106;
            this.lbname.Text = "lb1";
            // 
            // txtcode2
            // 
            this.txtcode2.Location = new System.Drawing.Point(824, 215);
            this.txtcode2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtcode2.Name = "txtcode2";
            this.txtcode2.Size = new System.Drawing.Size(191, 26);
            this.txtcode2.TabIndex = 115;
            this.txtcode2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtcode2_MouseClick);
            this.txtcode2.TextChanged += new System.EventHandler(this.txtcode2_TextChanged);
            this.txtcode2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcode2_KeyPress);
            this.txtcode2.Leave += new System.EventHandler(this.txtcode2_Leave);
            this.txtcode2.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txtcode2_MouseDoubleClick);
            // 
            // btncode
            // 
            this.btncode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncode.Location = new System.Drawing.Point(733, 207);
            this.btncode.Name = "btncode";
            this.btncode.Size = new System.Drawing.Size(89, 36);
            this.btncode.TabIndex = 116;
            this.btncode.Text = "Barcode";
            this.btncode.UseVisualStyleBackColor = true;
            this.btncode.Click += new System.EventHandler(this.button10_Click);
            // 
            // drugs
            // 
            this.AcceptButton = this.btncode;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1284, 762);
            this.Controls.Add(this.btncode);
            this.Controls.Add(this.txtcode2);
            this.Controls.Add(this.lbaddress);
            this.Controls.Add(this.lbname);
            this.Controls.Add(this.txtproductid);
            this.Controls.Add(this.Label18);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.Label17);
            this.Controls.Add(this.lsvitems);
            this.Controls.Add(this.Button9);
            this.Controls.Add(this.Label16);
            this.Controls.Add(this.txtadminpassword);
            this.Controls.Add(this.Button8);
            this.Controls.Add(this.txtsupplierphonenumber);
            this.Controls.Add(this.Label15);
            this.Controls.Add(this.txtinvoicenumber);
            this.Controls.Add(this.Label14);
            this.Controls.Add(this.txtamountpaid);
            this.Controls.Add(this.Label13);
            this.Controls.Add(this.txtdatepurchased);
            this.Controls.Add(this.Label12);
            this.Controls.Add(this.txtsuppliername);
            this.Controls.Add(this.Label11);
            this.Controls.Add(this.Button7);
            this.Controls.Add(this.Button6);
            this.Controls.Add(this.Button5);
            this.Controls.Add(this.Label10);
            this.Controls.Add(this.DateTimePicker2);
            this.Controls.Add(this.DateTimePicker1);
            this.Controls.Add(this.txtday);
            this.Controls.Add(this.txtyear);
            this.Controls.Add(this.txtexpirydate);
            this.Controls.Add(this.Label9);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.Button4);
            this.Controls.Add(this.txtitems);
            this.Controls.Add(this.txtfile);
            this.Controls.Add(this.txtunitcostprice);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button3);
            this.Controls.Add(this.txtproductname);
            this.Controls.Add(this.txtcashiername1);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.txtunitprice);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.txtquantity);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "drugs";
            this.Text = "Inventory";
            this.Load += new System.EventHandler(this.product_Load);
            this.Enter += new System.EventHandler(this.drugs_Enter);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.drugs_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		internal System.Windows.Forms.TextBox txtunitprice;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.TextBox txtquantity;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.Button Button1;
		internal System.Windows.Forms.Timer Timer1;
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.TextBox txtcashiername1;
		internal System.Windows.Forms.TextBox txtproductname;
		internal System.Windows.Forms.Button Button3;
		internal System.Windows.Forms.Button Button2;
		internal System.Windows.Forms.TextBox txtunitcostprice;
		internal System.Windows.Forms.Label Label7;
		internal System.Windows.Forms.Button Button4;
		internal System.Windows.Forms.OpenFileDialog OpenFileDialog1;
		internal System.Windows.Forms.TextBox txtfile;
		internal System.Windows.Forms.TextBox txtitems;
		internal System.Windows.Forms.PageSetupDialog PageSetupDialog1;
		internal System.Windows.Forms.TextBox txtsearch;
		internal System.Windows.Forms.Label Label8;
		internal System.Windows.Forms.PictureBox PictureBox1;
		internal System.Windows.Forms.Label Label9;
		internal System.Windows.Forms.TextBox txtexpirydate;
		internal System.Windows.Forms.TextBox txtyear;
		internal System.Windows.Forms.TextBox txtday;
		internal System.Windows.Forms.DateTimePicker DateTimePicker1;
		internal System.Windows.Forms.DateTimePicker DateTimePicker2;
		internal System.Windows.Forms.Label Label10;
		internal System.Windows.Forms.Button Button5;
		internal System.Windows.Forms.Button Button6;
		internal System.Windows.Forms.Button Button7;
		internal System.Windows.Forms.Label Label11;
		internal System.Windows.Forms.TextBox txtsuppliername;
		internal System.Windows.Forms.Label Label12;
		internal System.Windows.Forms.TextBox txtdatepurchased;
		internal System.Windows.Forms.Label Label13;
		internal System.Windows.Forms.TextBox txtamountpaid;
		internal System.Windows.Forms.Label Label14;
		internal System.Windows.Forms.TextBox txtinvoicenumber;
		internal System.Windows.Forms.Label Label15;
		internal System.Windows.Forms.TextBox txtsupplierphonenumber;
		internal System.Windows.Forms.Button Button8;
		internal System.Windows.Forms.Label Label16;
		internal System.Windows.Forms.TextBox txtadminpassword;
		internal System.Windows.Forms.Button Button9;
		internal System.Windows.Forms.ListView lsvitems;
		internal System.Windows.Forms.ColumnHeader ColumnHeader12;
		internal System.Windows.Forms.ColumnHeader ColumnHeader2;
		internal System.Windows.Forms.ColumnHeader ColumnHeader3;
		internal System.Windows.Forms.ColumnHeader ColumnHeader4;
		internal System.Windows.Forms.ColumnHeader ColumnHeader5;
		internal System.Windows.Forms.ColumnHeader ColumnHeader6;
		internal System.Windows.Forms.ColumnHeader ColumnHeader10;
		internal System.Windows.Forms.TextBox txttotal;
		internal System.Windows.Forms.Label Label17;
		internal System.Windows.Forms.Label Label18;
		internal System.Windows.Forms.TextBox txtproductid;
		internal System.Windows.Forms.Label lbaddress;
		internal System.Windows.Forms.Label lbname;
        internal System.Windows.Forms.TextBox txtcode2;
        private System.Windows.Forms.Button btncode;
    }

}