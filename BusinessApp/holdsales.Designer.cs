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

namespace BusinessApp
{
	[Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
	public partial class holdsales : System.Windows.Forms.Form
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
            this.Button3 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.txttransactionid = new System.Windows.Forms.TextBox();
            this.Label16 = new System.Windows.Forms.Label();
            this.txtproductname = new System.Windows.Forms.TextBox();
            this.Label15 = new System.Windows.Forms.Label();
            this.txtquantity = new System.Windows.Forms.TextBox();
            this.Label14 = new System.Windows.Forms.Label();
            this.txtnairadiscount = new System.Windows.Forms.TextBox();
            this.Label12 = new System.Windows.Forms.Label();
            this.Label13 = new System.Windows.Forms.Label();
            this.txtdiscountapproval = new System.Windows.Forms.TextBox();
            this.cbldiscount = new System.Windows.Forms.ComboBox();
            this.Label11 = new System.Windows.Forms.Label();
            this.txtgrandtotal = new System.Windows.Forms.TextBox();
            this.Label10 = new System.Windows.Forms.Label();
            this.txtdiscount = new System.Windows.Forms.TextBox();
            this.Label9 = new System.Windows.Forms.Label();
            this.lsvitems = new System.Windows.Forms.ListView();
            this.ColumnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Button1 = new System.Windows.Forms.Button();
            this.txtcash = new System.Windows.Forms.TextBox();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.txttime = new System.Windows.Forms.TextBox();
            this.DateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtreceiptnumber = new System.Windows.Forms.TextBox();
            this.txtcashiername1 = new System.Windows.Forms.TextBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Button6 = new System.Windows.Forms.Button();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtservicecharge = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Button3
            // 
            this.Button3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Button3.BackColor = System.Drawing.Color.White;
            this.Button3.ForeColor = System.Drawing.Color.Red;
            this.Button3.Location = new System.Drawing.Point(581, 61);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(123, 36);
            this.Button3.TabIndex = 149;
            this.Button3.Text = "Remove Item";
            this.Button3.UseVisualStyleBackColor = false;
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // Button2
            // 
            this.Button2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Button2.BackColor = System.Drawing.Color.Lime;
            this.Button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button2.Location = new System.Drawing.Point(643, 153);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(56, 35);
            this.Button2.TabIndex = 148;
            this.Button2.Text = "ok";
            this.Button2.UseVisualStyleBackColor = false;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // txttransactionid
            // 
            this.txttransactionid.Location = new System.Drawing.Point(109, 159);
            this.txttransactionid.Name = "txttransactionid";
            this.txttransactionid.ReadOnly = true;
            this.txttransactionid.Size = new System.Drawing.Size(58, 26);
            this.txttransactionid.TabIndex = 147;
            // 
            // Label16
            // 
            this.Label16.AutoSize = true;
            this.Label16.Location = new System.Drawing.Point(63, 161);
            this.Label16.Name = "Label16";
            this.Label16.Size = new System.Drawing.Size(28, 20);
            this.Label16.TabIndex = 146;
            this.Label16.Text = "ID";
            // 
            // txtproductname
            // 
            this.txtproductname.Location = new System.Drawing.Point(247, 159);
            this.txtproductname.Name = "txtproductname";
            this.txtproductname.ReadOnly = true;
            this.txtproductname.Size = new System.Drawing.Size(186, 26);
            this.txtproductname.TabIndex = 145;
            // 
            // Label15
            // 
            this.Label15.AutoSize = true;
            this.Label15.Location = new System.Drawing.Point(178, 160);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(55, 20);
            this.Label15.TabIndex = 144;
            this.Label15.Text = "Name";
            // 
            // txtquantity
            // 
            this.txtquantity.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtquantity.Location = new System.Drawing.Point(581, 157);
            this.txtquantity.Name = "txtquantity";
            this.txtquantity.Size = new System.Drawing.Size(56, 26);
            this.txtquantity.TabIndex = 143;
            // 
            // Label14
            // 
            this.Label14.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Label14.AutoSize = true;
            this.Label14.Location = new System.Drawing.Point(443, 161);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(148, 20);
            this.Label14.TabIndex = 142;
            this.Label14.Text = "Change Quantity ";
            // 
            // txtnairadiscount
            // 
            this.txtnairadiscount.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtnairadiscount.Location = new System.Drawing.Point(61, 506);
            this.txtnairadiscount.Name = "txtnairadiscount";
            this.txtnairadiscount.Size = new System.Drawing.Size(127, 26);
            this.txtnairadiscount.TabIndex = 141;
            // 
            // Label12
            // 
            this.Label12.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Label12.AutoSize = true;
            this.Label12.Location = new System.Drawing.Point(57, 477);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(148, 20);
            this.Label12.TabIndex = 140;
            this.Label12.Text = "Discount In Naira\r\n";
            // 
            // Label13
            // 
            this.Label13.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Label13.AutoSize = true;
            this.Label13.Location = new System.Drawing.Point(62, 574);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(155, 20);
            this.Label13.TabIndex = 139;
            this.Label13.Text = "Discount Approval";
            // 
            // txtdiscountapproval
            // 
            this.txtdiscountapproval.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtdiscountapproval.Location = new System.Drawing.Point(62, 597);
            this.txtdiscountapproval.Name = "txtdiscountapproval";
            this.txtdiscountapproval.PasswordChar = '#';
            this.txtdiscountapproval.Size = new System.Drawing.Size(138, 26);
            this.txtdiscountapproval.TabIndex = 138;
            // 
            // cbldiscount
            // 
            this.cbldiscount.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbldiscount.FormattingEnabled = true;
            this.cbldiscount.Items.AddRange(new object[] {
            "5",
            "10",
            "15",
            "20"});
            this.cbldiscount.Location = new System.Drawing.Point(61, 419);
            this.cbldiscount.Name = "cbldiscount";
            this.cbldiscount.Size = new System.Drawing.Size(182, 28);
            this.cbldiscount.TabIndex = 137;
            // 
            // Label11
            // 
            this.Label11.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Label11.AutoSize = true;
            this.Label11.Location = new System.Drawing.Point(57, 376);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(209, 40);
            this.Label11.TabIndex = 136;
            this.Label11.Text = "Percentage(%) Discount \r\nGiven\r\n";
            // 
            // txtgrandtotal
            // 
            this.txtgrandtotal.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtgrandtotal.Location = new System.Drawing.Point(604, 494);
            this.txtgrandtotal.Name = "txtgrandtotal";
            this.txtgrandtotal.ReadOnly = true;
            this.txtgrandtotal.Size = new System.Drawing.Size(101, 26);
            this.txtgrandtotal.TabIndex = 135;
            this.txtgrandtotal.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtgrandtotal_MouseClick);
            this.txtgrandtotal.TextChanged += new System.EventHandler(this.txtgrandtotal_TextChanged);
            // 
            // Label10
            // 
            this.Label10.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Label10.AutoSize = true;
            this.Label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label10.Location = new System.Drawing.Point(477, 494);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(104, 20);
            this.Label10.TabIndex = 134;
            this.Label10.Text = "Grand Total";
            // 
            // txtdiscount
            // 
            this.txtdiscount.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtdiscount.Location = new System.Drawing.Point(606, 462);
            this.txtdiscount.Name = "txtdiscount";
            this.txtdiscount.ReadOnly = true;
            this.txtdiscount.Size = new System.Drawing.Size(101, 26);
            this.txtdiscount.TabIndex = 133;
            this.txtdiscount.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtdiscount_MouseClick);
            this.txtdiscount.TextChanged += new System.EventHandler(this.txtdiscount_TextChanged);
            // 
            // Label9
            // 
            this.Label9.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Label9.AutoSize = true;
            this.Label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label9.Location = new System.Drawing.Point(447, 468);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(148, 20);
            this.Label9.TabIndex = 132;
            this.Label9.Text = "Discount In Naira";
            // 
            // lsvitems
            // 
            this.lsvitems.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lsvitems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader5,
            this.ColumnHeader1,
            this.ColumnHeader2,
            this.ColumnHeader3,
            this.ColumnHeader4});
            this.lsvitems.FullRowSelect = true;
            this.lsvitems.GridLines = true;
            this.lsvitems.HideSelection = false;
            this.lsvitems.Location = new System.Drawing.Point(57, 191);
            this.lsvitems.Name = "lsvitems";
            this.lsvitems.Size = new System.Drawing.Size(647, 171);
            this.lsvitems.TabIndex = 131;
            this.lsvitems.UseCompatibleStateImageBehavior = false;
            this.lsvitems.View = System.Windows.Forms.View.Details;
            this.lsvitems.SelectedIndexChanged += new System.EventHandler(this.lsvitems_SelectedIndexChanged);
            this.lsvitems.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lsvitems_MouseClick);
            // 
            // ColumnHeader5
            // 
            this.ColumnHeader5.Text = "ID";
            // 
            // ColumnHeader1
            // 
            this.ColumnHeader1.Text = "Item Description";
            this.ColumnHeader1.Width = 176;
            // 
            // ColumnHeader2
            // 
            this.ColumnHeader2.Text = "Quantity Sold";
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
            this.ColumnHeader4.Width = 142;
            // 
            // Button1
            // 
            this.Button1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Button1.Location = new System.Drawing.Point(582, 568);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(122, 55);
            this.Button1.TabIndex = 130;
            this.Button1.Text = "Get receipt";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // txtcash
            // 
            this.txtcash.AcceptsTab = true;
            this.txtcash.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtcash.Location = new System.Drawing.Point(606, 526);
            this.txtcash.Name = "txtcash";
            this.txtcash.Size = new System.Drawing.Size(99, 26);
            this.txtcash.TabIndex = 129;
            // 
            // txttotal
            // 
            this.txttotal.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txttotal.Location = new System.Drawing.Point(606, 381);
            this.txttotal.Name = "txttotal";
            this.txttotal.ReadOnly = true;
            this.txttotal.Size = new System.Drawing.Size(98, 26);
            this.txttotal.TabIndex = 128;
            // 
            // txttime
            // 
            this.txttime.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txttime.Location = new System.Drawing.Point(365, 66);
            this.txttime.Name = "txttime";
            this.txttime.ReadOnly = true;
            this.txttime.Size = new System.Drawing.Size(155, 26);
            this.txttime.TabIndex = 127;
            // 
            // DateTimePicker1
            // 
            this.DateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DateTimePicker1.Location = new System.Drawing.Point(343, 115);
            this.DateTimePicker1.Name = "DateTimePicker1";
            this.DateTimePicker1.Size = new System.Drawing.Size(259, 26);
            this.DateTimePicker1.TabIndex = 126;
            // 
            // txtreceiptnumber
            // 
            this.txtreceiptnumber.Location = new System.Drawing.Point(163, 114);
            this.txtreceiptnumber.Name = "txtreceiptnumber";
            this.txtreceiptnumber.ReadOnly = true;
            this.txtreceiptnumber.Size = new System.Drawing.Size(97, 26);
            this.txtreceiptnumber.TabIndex = 125;
            // 
            // txtcashiername1
            // 
            this.txtcashiername1.Location = new System.Drawing.Point(154, 75);
            this.txtcashiername1.Name = "txtcashiername1";
            this.txtcashiername1.ReadOnly = true;
            this.txtcashiername1.Size = new System.Drawing.Size(107, 26);
            this.txtcashiername1.TabIndex = 124;
            // 
            // Label8
            // 
            this.Label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.Location = new System.Drawing.Point(453, 528);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(142, 24);
            this.Label8.TabIndex = 123;
            this.Label8.Text = "Cash Tendered";
            this.Label8.Click += new System.EventHandler(this.Label8_Click);
            // 
            // Label7
            // 
            this.Label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.Location = new System.Drawing.Point(526, 382);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(66, 25);
            this.Label7.TabIndex = 122;
            this.Label7.Text = " Total";
            // 
            // Label6
            // 
            this.Label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(284, 117);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(53, 20);
            this.Label6.TabIndex = 121;
            this.Label6.Text = "Date:";
            this.Label6.Click += new System.EventHandler(this.Label6_Click);
            // 
            // Label5
            // 
            this.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(297, 73);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(52, 20);
            this.Label5.TabIndex = 120;
            this.Label5.Text = "Time:";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(57, 115);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(103, 20);
            this.Label4.TabIndex = 119;
            this.Label4.Text = "Receipt No:";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(53, 71);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(75, 20);
            this.Label3.TabIndex = 118;
            this.Label3.Text = "Cashier:";
            // 
            // Button6
            // 
            this.Button6.BackColor = System.Drawing.Color.Red;
            this.Button6.ForeColor = System.Drawing.Color.White;
            this.Button6.Location = new System.Drawing.Point(343, 579);
            this.Button6.Name = "Button6";
            this.Button6.Size = new System.Drawing.Size(142, 44);
            this.Button6.TabIndex = 152;
            this.Button6.Text = "Clear Cart";
            this.Button6.UseVisualStyleBackColor = false;
            this.Button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // txtaddress
            // 
            this.txtaddress.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtaddress.Location = new System.Drawing.Point(0, 26);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.ReadOnly = true;
            this.txtaddress.Size = new System.Drawing.Size(744, 26);
            this.txtaddress.TabIndex = 154;
            this.txtaddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtname
            // 
            this.txtname.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtname.Location = new System.Drawing.Point(0, 0);
            this.txtname.Name = "txtname";
            this.txtname.ReadOnly = true;
            this.txtname.Size = new System.Drawing.Size(744, 26);
            this.txtname.TabIndex = 153;
            this.txtname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtservicecharge
            // 
            this.txtservicecharge.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtservicecharge.Location = new System.Drawing.Point(606, 421);
            this.txtservicecharge.Name = "txtservicecharge";
            this.txtservicecharge.Size = new System.Drawing.Size(101, 26);
            this.txtservicecharge.TabIndex = 189;
            this.txtservicecharge.Text = "0";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(464, 427);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 190;
            this.label1.Text = "Service Charge";
            // 
            // holdsales
            // 
            this.AcceptButton = this.Button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 667);
            this.Controls.Add(this.txtservicecharge);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.Button6);
            this.Controls.Add(this.Button3);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.txttransactionid);
            this.Controls.Add(this.Label16);
            this.Controls.Add(this.txtproductname);
            this.Controls.Add(this.Label15);
            this.Controls.Add(this.txtquantity);
            this.Controls.Add(this.Label14);
            this.Controls.Add(this.txtnairadiscount);
            this.Controls.Add(this.Label12);
            this.Controls.Add(this.Label13);
            this.Controls.Add(this.txtdiscountapproval);
            this.Controls.Add(this.cbldiscount);
            this.Controls.Add(this.Label11);
            this.Controls.Add(this.txtgrandtotal);
            this.Controls.Add(this.Label10);
            this.Controls.Add(this.txtdiscount);
            this.Controls.Add(this.Label9);
            this.Controls.Add(this.lsvitems);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.txtcash);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.txttime);
            this.Controls.Add(this.DateTimePicker1);
            this.Controls.Add(this.txtreceiptnumber);
            this.Controls.Add(this.txtcashiername1);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimumSize = new System.Drawing.Size(700, 650);
            this.Name = "holdsales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "holdsales";
            this.Load += new System.EventHandler(this.holdsales_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.holdsales_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		internal System.Windows.Forms.Button Button3;
		internal System.Windows.Forms.Button Button2;
		internal System.Windows.Forms.TextBox txttransactionid;
		internal System.Windows.Forms.Label Label16;
		internal System.Windows.Forms.TextBox txtproductname;
		internal System.Windows.Forms.Label Label15;
		internal System.Windows.Forms.TextBox txtquantity;
		internal System.Windows.Forms.Label Label14;
		internal System.Windows.Forms.TextBox txtnairadiscount;
		internal System.Windows.Forms.Label Label12;
		internal System.Windows.Forms.Label Label13;
		internal System.Windows.Forms.TextBox txtdiscountapproval;
		internal System.Windows.Forms.ComboBox cbldiscount;
		internal System.Windows.Forms.Label Label11;
		internal System.Windows.Forms.TextBox txtgrandtotal;
		internal System.Windows.Forms.Label Label10;
		internal System.Windows.Forms.TextBox txtdiscount;
		internal System.Windows.Forms.Label Label9;
		internal System.Windows.Forms.ListView lsvitems;
		internal System.Windows.Forms.ColumnHeader ColumnHeader5;
		internal System.Windows.Forms.ColumnHeader ColumnHeader1;
		internal System.Windows.Forms.ColumnHeader ColumnHeader2;
		internal System.Windows.Forms.ColumnHeader ColumnHeader3;
		internal System.Windows.Forms.ColumnHeader ColumnHeader4;
		internal System.Windows.Forms.Button Button1;
		internal System.Windows.Forms.TextBox txtcash;
		internal System.Windows.Forms.TextBox txttotal;
		internal System.Windows.Forms.TextBox txttime;
		internal System.Windows.Forms.DateTimePicker DateTimePicker1;
		internal System.Windows.Forms.TextBox txtreceiptnumber;
		internal System.Windows.Forms.TextBox txtcashiername1;
		internal System.Windows.Forms.Label Label8;
		internal System.Windows.Forms.Label Label7;
		internal System.Windows.Forms.Label Label6;
		internal System.Windows.Forms.Label Label5;
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.Button Button6;
        private TextBox txtaddress;
        private TextBox txtname;
        internal TextBox txtservicecharge;
        internal Label label1;
    }

}