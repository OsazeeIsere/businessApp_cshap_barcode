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

using System.Runtime.InteropServices;
using System.Drawing.Printing;
using MySql.Data;
using Microsoft.VisualBasic;
namespace BusinessApp
{
	[Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
	public partial class receiptholdsales : System.Windows.Forms.Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(receiptholdsales));
            this.Label17 = new System.Windows.Forms.Label();
            this.txtdiscount1 = new System.Windows.Forms.TextBox();
            this.Label16 = new System.Windows.Forms.Label();
            this.Label15 = new System.Windows.Forms.Label();
            this.Label14 = new System.Windows.Forms.Label();
            this.Label13 = new System.Windows.Forms.Label();
            this.lsvitems = new System.Windows.Forms.ListView();
            this.ColumnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Button3 = new System.Windows.Forms.Button();
            this.txtchange = new System.Windows.Forms.TextBox();
            this.Label9 = new System.Windows.Forms.Label();
            this.Button1 = new System.Windows.Forms.Button();
            this.txtcash = new System.Windows.Forms.TextBox();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.txttime = new System.Windows.Forms.TextBox();
            this.DateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtreceiptnumber = new System.Windows.Forms.TextBox();
            this.txtcashiername1 = new System.Windows.Forms.TextBox();
            this.Label12 = new System.Windows.Forms.Label();
            this.Label11 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.PrintDocument1 = new System.Drawing.Printing.PrintDocument();
            this.PrintForm1 = new Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(this.components);
            this.lbcopyright = new System.Windows.Forms.Label();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txttel = new System.Windows.Forms.TextBox();
            this.lbauthorTel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtservicecharge = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtrepeatreceipt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Label17
            // 
            this.Label17.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Label17.AutoSize = true;
            this.Label17.Location = new System.Drawing.Point(427, 507);
            this.Label17.Name = "Label17";
            this.Label17.Size = new System.Drawing.Size(44, 20);
            this.Label17.TabIndex = 175;
            this.Label17.Text = "NGN";
            // 
            // txtdiscount1
            // 
            this.txtdiscount1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtdiscount1.Location = new System.Drawing.Point(490, 504);
            this.txtdiscount1.Name = "txtdiscount1";
            this.txtdiscount1.ReadOnly = true;
            this.txtdiscount1.Size = new System.Drawing.Size(130, 26);
            this.txtdiscount1.TabIndex = 174;
            // 
            // Label16
            // 
            this.Label16.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Label16.AutoSize = true;
            this.Label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label16.Location = new System.Drawing.Point(319, 504);
            this.Label16.Name = "Label16";
            this.Label16.Size = new System.Drawing.Size(80, 20);
            this.Label16.TabIndex = 173;
            this.Label16.Text = "Discount";
            // 
            // Label15
            // 
            this.Label15.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Label15.AutoSize = true;
            this.Label15.Location = new System.Drawing.Point(431, 549);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(44, 20);
            this.Label15.TabIndex = 172;
            this.Label15.Text = "NGN";
            // 
            // Label14
            // 
            this.Label14.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Label14.AutoSize = true;
            this.Label14.Location = new System.Drawing.Point(439, 459);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(44, 20);
            this.Label14.TabIndex = 171;
            this.Label14.Text = "NGN";
            // 
            // Label13
            // 
            this.Label13.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Label13.AutoSize = true;
            this.Label13.Location = new System.Drawing.Point(439, 420);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(44, 20);
            this.Label13.TabIndex = 170;
            this.Label13.Text = "NGN";
            // 
            // lsvitems
            // 
            this.lsvitems.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lsvitems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader1,
            this.ColumnHeader2,
            this.ColumnHeader3,
            this.ColumnHeader4});
            this.lsvitems.FullRowSelect = true;
            this.lsvitems.GridLines = true;
            this.lsvitems.HideSelection = false;
            this.lsvitems.Location = new System.Drawing.Point(65, 186);
            this.lsvitems.Name = "lsvitems";
            this.lsvitems.Size = new System.Drawing.Size(574, 193);
            this.lsvitems.TabIndex = 169;
            this.lsvitems.UseCompatibleStateImageBehavior = false;
            this.lsvitems.View = System.Windows.Forms.View.Details;
            // 
            // ColumnHeader1
            // 
            this.ColumnHeader1.Text = "Item ";
            this.ColumnHeader1.Width = 213;
            // 
            // ColumnHeader2
            // 
            this.ColumnHeader2.Text = "Qty Sold";
            this.ColumnHeader2.Width = 134;
            // 
            // ColumnHeader3
            // 
            this.ColumnHeader3.Text = "Unit Price";
            this.ColumnHeader3.Width = 130;
            // 
            // ColumnHeader4
            // 
            this.ColumnHeader4.Text = "Amount";
            this.ColumnHeader4.Width = 165;
            // 
            // Button3
            // 
            this.Button3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Button3.Location = new System.Drawing.Point(431, 617);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(105, 32);
            this.Button3.TabIndex = 168;
            this.Button3.Text = "Print";
            this.Button3.UseVisualStyleBackColor = true;
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // txtchange
            // 
            this.txtchange.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtchange.Location = new System.Drawing.Point(488, 543);
            this.txtchange.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtchange.Name = "txtchange";
            this.txtchange.ReadOnly = true;
            this.txtchange.Size = new System.Drawing.Size(132, 26);
            this.txtchange.TabIndex = 167;
            // 
            // Label9
            // 
            this.Label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Label9.AutoSize = true;
            this.Label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label9.Location = new System.Drawing.Point(328, 546);
            this.Label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(71, 20);
            this.Label9.TabIndex = 166;
            this.Label9.Text = "Change";
            // 
            // Button1
            // 
            this.Button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Button1.Location = new System.Drawing.Point(541, 615);
            this.Button1.Margin = new System.Windows.Forms.Padding(4);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(105, 36);
            this.Button1.TabIndex = 165;
            this.Button1.Text = "Clear Sales";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // txtcash
            // 
            this.txtcash.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtcash.Location = new System.Drawing.Point(490, 456);
            this.txtcash.Margin = new System.Windows.Forms.Padding(4);
            this.txtcash.Name = "txtcash";
            this.txtcash.ReadOnly = true;
            this.txtcash.Size = new System.Drawing.Size(130, 26);
            this.txtcash.TabIndex = 164;
            // 
            // txttotal
            // 
            this.txttotal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txttotal.Location = new System.Drawing.Point(491, 418);
            this.txttotal.Margin = new System.Windows.Forms.Padding(4);
            this.txttotal.Name = "txttotal";
            this.txttotal.ReadOnly = true;
            this.txttotal.Size = new System.Drawing.Size(129, 26);
            this.txttotal.TabIndex = 163;
            // 
            // txttime
            // 
            this.txttime.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txttime.Location = new System.Drawing.Point(370, 82);
            this.txttime.Margin = new System.Windows.Forms.Padding(4);
            this.txttime.Name = "txttime";
            this.txttime.Size = new System.Drawing.Size(258, 26);
            this.txttime.TabIndex = 162;
            // 
            // DateTimePicker1
            // 
            this.DateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.DateTimePicker1.Location = new System.Drawing.Point(359, 138);
            this.DateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.DateTimePicker1.Name = "DateTimePicker1";
            this.DateTimePicker1.Size = new System.Drawing.Size(269, 26);
            this.DateTimePicker1.TabIndex = 161;
            // 
            // txtreceiptnumber
            // 
            this.txtreceiptnumber.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtreceiptnumber.Location = new System.Drawing.Point(155, 135);
            this.txtreceiptnumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtreceiptnumber.Name = "txtreceiptnumber";
            this.txtreceiptnumber.Size = new System.Drawing.Size(128, 26);
            this.txtreceiptnumber.TabIndex = 160;
            // 
            // txtcashiername1
            // 
            this.txtcashiername1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtcashiername1.Location = new System.Drawing.Point(144, 87);
            this.txtcashiername1.Margin = new System.Windows.Forms.Padding(4);
            this.txtcashiername1.Name = "txtcashiername1";
            this.txtcashiername1.Size = new System.Drawing.Size(141, 26);
            this.txtcashiername1.TabIndex = 159;
            // 
            // Label12
            // 
            this.Label12.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Label12.AutoSize = true;
            this.Label12.Location = new System.Drawing.Point(131, 670);
            this.Label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(268, 20);
            this.Label12.TabIndex = 158;
            this.Label12.Text = "Goods Bought Cannot Be Returned.";
            // 
            // Label11
            // 
            this.Label11.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Label11.AutoSize = true;
            this.Label11.Location = new System.Drawing.Point(161, 641);
            this.Label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(199, 20);
            this.Label11.TabIndex = 157;
            this.Label11.Text = "Thanks for your patronage.";
            // 
            // Label8
            // 
            this.Label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.Location = new System.Drawing.Point(290, 455);
            this.Label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(142, 24);
            this.Label8.TabIndex = 156;
            this.Label8.Text = "Cash Tendered";
            // 
            // Label7
            // 
            this.Label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.Location = new System.Drawing.Point(286, 418);
            this.Label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(136, 25);
            this.Label7.TabIndex = 155;
            this.Label7.Text = "Grand Total";
            // 
            // Label6
            // 
            this.Label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(311, 143);
            this.Label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(48, 20);
            this.Label6.TabIndex = 154;
            this.Label6.Text = "Date:";
            // 
            // Label5
            // 
            this.Label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(310, 85);
            this.Label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(47, 20);
            this.Label5.TabIndex = 153;
            this.Label5.Text = "Time:";
            // 
            // Label4
            // 
            this.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(61, 138);
            this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(92, 20);
            this.Label4.TabIndex = 152;
            this.Label4.Text = "Receipt No:";
            // 
            // Label3
            // 
            this.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(55, 84);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(67, 20);
            this.Label3.TabIndex = 151;
            this.Label3.Text = "Cashier ";
            // 
            // PrintDocument1
            // 
            this.PrintDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintDocument1_PrintPage);
            // 
            // PrintForm1
            // 
            this.PrintForm1.DocumentName = "document";
            this.PrintForm1.Form = this;
            this.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter;
            this.PrintForm1.PrinterSettings = ((System.Drawing.Printing.PrinterSettings)(resources.GetObject("PrintForm1.PrinterSettings")));
            this.PrintForm1.PrintFileName = null;
            // 
            // lbcopyright
            // 
            this.lbcopyright.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbcopyright.AutoSize = true;
            this.lbcopyright.Location = new System.Drawing.Point(12, 703);
            this.lbcopyright.Name = "lbcopyright";
            this.lbcopyright.Size = new System.Drawing.Size(73, 20);
            this.lbcopyright.TabIndex = 179;
            this.lbcopyright.Text = "copyright";
            // 
            // txtaddress
            // 
            this.txtaddress.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtaddress.Location = new System.Drawing.Point(0, 26);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.ReadOnly = true;
            this.txtaddress.Size = new System.Drawing.Size(703, 26);
            this.txtaddress.TabIndex = 181;
            this.txtaddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtname
            // 
            this.txtname.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtname.Location = new System.Drawing.Point(0, 0);
            this.txtname.Name = "txtname";
            this.txtname.ReadOnly = true;
            this.txtname.Size = new System.Drawing.Size(703, 26);
            this.txtname.TabIndex = 180;
            this.txtname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txttel
            // 
            this.txttel.Dock = System.Windows.Forms.DockStyle.Top;
            this.txttel.Location = new System.Drawing.Point(0, 52);
            this.txttel.Name = "txttel";
            this.txttel.ReadOnly = true;
            this.txttel.Size = new System.Drawing.Size(703, 26);
            this.txttel.TabIndex = 182;
            this.txttel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbauthorTel
            // 
            this.lbauthorTel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbauthorTel.AutoSize = true;
            this.lbauthorTel.Location = new System.Drawing.Point(12, 742);
            this.lbauthorTel.Name = "lbauthorTel";
            this.lbauthorTel.Size = new System.Drawing.Size(34, 20);
            this.lbauthorTel.TabIndex = 183;
            this.lbauthorTel.Text = "Tel.";
            this.lbauthorTel.Visible = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(430, 388);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 194;
            this.label2.Text = "NGN";
            // 
            // txtservicecharge
            // 
            this.txtservicecharge.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtservicecharge.Location = new System.Drawing.Point(488, 385);
            this.txtservicecharge.Name = "txtservicecharge";
            this.txtservicecharge.ReadOnly = true;
            this.txtservicecharge.Size = new System.Drawing.Size(131, 26);
            this.txtservicecharge.TabIndex = 192;
            this.txtservicecharge.Text = "0";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(282, 391);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 20);
            this.label1.TabIndex = 193;
            this.label1.Text = "Service Charge:";
            // 
            // txtrepeatreceipt
            // 
            this.txtrepeatreceipt.Location = new System.Drawing.Point(26, 498);
            this.txtrepeatreceipt.Name = "txtrepeatreceipt";
            this.txtrepeatreceipt.Size = new System.Drawing.Size(227, 26);
            this.txtrepeatreceipt.TabIndex = 195;
            this.txtrepeatreceipt.Visible = false;
            // 
            // receiptholdsales
            // 
            this.AcceptButton = this.Button3;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 782);
            this.Controls.Add(this.txtrepeatreceipt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtservicecharge);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbauthorTel);
            this.Controls.Add(this.txttel);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.lbcopyright);
            this.Controls.Add(this.Label17);
            this.Controls.Add(this.txtdiscount1);
            this.Controls.Add(this.Label16);
            this.Controls.Add(this.Label15);
            this.Controls.Add(this.Label14);
            this.Controls.Add(this.Label13);
            this.Controls.Add(this.lsvitems);
            this.Controls.Add(this.Button3);
            this.Controls.Add(this.txtchange);
            this.Controls.Add(this.Label9);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.txtcash);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.txttime);
            this.Controls.Add(this.DateTimePicker1);
            this.Controls.Add(this.txtreceiptnumber);
            this.Controls.Add(this.txtcashiername1);
            this.Controls.Add(this.Label12);
            this.Controls.Add(this.Label11);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "receiptholdsales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "receiptholdsales";
            this.Load += new System.EventHandler(this.receiptholdsales_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		internal System.Windows.Forms.Label Label17;
		internal System.Windows.Forms.TextBox txtdiscount1;
		internal System.Windows.Forms.Label Label16;
		internal System.Windows.Forms.Label Label15;
		internal System.Windows.Forms.Label Label14;
		internal System.Windows.Forms.Label Label13;
		internal System.Windows.Forms.ListView lsvitems;
		internal System.Windows.Forms.ColumnHeader ColumnHeader1;
		internal System.Windows.Forms.ColumnHeader ColumnHeader2;
		internal System.Windows.Forms.ColumnHeader ColumnHeader3;
		internal System.Windows.Forms.ColumnHeader ColumnHeader4;
		internal System.Windows.Forms.Button Button3;
		internal System.Windows.Forms.TextBox txtchange;
		internal System.Windows.Forms.Label Label9;
		internal System.Windows.Forms.Button Button1;
		internal System.Windows.Forms.TextBox txtcash;
		internal System.Windows.Forms.TextBox txttotal;
		internal System.Windows.Forms.TextBox txttime;
		internal System.Windows.Forms.DateTimePicker DateTimePicker1;
		internal System.Windows.Forms.TextBox txtreceiptnumber;
		internal System.Windows.Forms.TextBox txtcashiername1;
		internal System.Windows.Forms.Label Label12;
		internal System.Windows.Forms.Label Label11;
		internal System.Windows.Forms.Label Label8;
		internal System.Windows.Forms.Label Label7;
		internal System.Windows.Forms.Label Label6;
		internal System.Windows.Forms.Label Label5;
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.Label Label3;
		internal System.Drawing.Printing.PrintDocument PrintDocument1;
		internal Microsoft.VisualBasic.PowerPacks.Printing.PrintForm PrintForm1;
		internal System.Windows.Forms.Label lbcopyright;
        private TextBox txttel;
        private TextBox txtaddress;
        private TextBox txtname;
        internal Label lbauthorTel;
        internal Label label2;
        public TextBox txtservicecharge;
        internal Label label1;
        internal TextBox txtrepeatreceipt;
    }

}