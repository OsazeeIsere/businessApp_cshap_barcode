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
	public partial class viewsales : System.Windows.Forms.Form
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
            this.Label3 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.txtcashiername1 = new System.Windows.Forms.TextBox();
            this.txtreceiptnumber = new System.Windows.Forms.TextBox();
            this.DateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txttime = new System.Windows.Forms.TextBox();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.txtcash = new System.Windows.Forms.TextBox();
            this.Button1 = new System.Windows.Forms.Button();
            this.ColumnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lsvitems = new System.Windows.Forms.ListView();
            this.ColumnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Label9 = new System.Windows.Forms.Label();
            this.txtdiscount = new System.Windows.Forms.TextBox();
            this.Label10 = new System.Windows.Forms.Label();
            this.txtgrandtotal = new System.Windows.Forms.TextBox();
            this.Label11 = new System.Windows.Forms.Label();
            this.cbldiscount = new System.Windows.Forms.ComboBox();
            this.Label13 = new System.Windows.Forms.Label();
            this.txtdiscountapproval = new System.Windows.Forms.TextBox();
            this.Label12 = new System.Windows.Forms.Label();
            this.txtnairadiscount = new System.Windows.Forms.TextBox();
            this.Label14 = new System.Windows.Forms.Label();
            this.txtquantity = new System.Windows.Forms.TextBox();
            this.Label15 = new System.Windows.Forms.Label();
            this.txtproductname = new System.Windows.Forms.TextBox();
            this.Label16 = new System.Windows.Forms.Label();
            this.txttransactionid = new System.Windows.Forms.TextBox();
            this.Button2 = new System.Windows.Forms.Button();
            this.Button3 = new System.Windows.Forms.Button();
            this.Button4 = new System.Windows.Forms.Button();
            this.Button5 = new System.Windows.Forms.Button();
            this.Button6 = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(12, 70);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(67, 20);
            this.Label3.TabIndex = 7;
            this.Label3.Text = "Cashier:";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(16, 114);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(92, 20);
            this.Label4.TabIndex = 8;
            this.Label4.Text = "Receipt No:";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(256, 72);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(47, 20);
            this.Label5.TabIndex = 9;
            this.Label5.Text = "Time:";
            this.Label5.Click += new System.EventHandler(this.Label5_Click);
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(257, 119);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(48, 20);
            this.Label6.TabIndex = 10;
            this.Label6.Text = "Date:";
            this.Label6.Click += new System.EventHandler(this.Label6_Click);
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.Location = new System.Drawing.Point(461, 379);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(66, 25);
            this.Label7.TabIndex = 11;
            this.Label7.Text = " Total";
            this.Label7.Click += new System.EventHandler(this.Label7_Click);
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.Location = new System.Drawing.Point(413, 507);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(123, 24);
            this.Label8.TabIndex = 12;
            this.Label8.Text = "Cash To Paid";
            this.Label8.Click += new System.EventHandler(this.Label8_Click);
            // 
            // txtcashiername1
            // 
            this.txtcashiername1.Location = new System.Drawing.Point(113, 74);
            this.txtcashiername1.Name = "txtcashiername1";
            this.txtcashiername1.Size = new System.Drawing.Size(107, 26);
            this.txtcashiername1.TabIndex = 18;
            // 
            // txtreceiptnumber
            // 
            this.txtreceiptnumber.Location = new System.Drawing.Point(122, 113);
            this.txtreceiptnumber.Name = "txtreceiptnumber";
            this.txtreceiptnumber.Size = new System.Drawing.Size(97, 26);
            this.txtreceiptnumber.TabIndex = 19;
            // 
            // DateTimePicker1
            // 
            this.DateTimePicker1.Location = new System.Drawing.Point(302, 114);
            this.DateTimePicker1.Name = "DateTimePicker1";
            this.DateTimePicker1.Size = new System.Drawing.Size(259, 26);
            this.DateTimePicker1.TabIndex = 20;
            this.DateTimePicker1.ValueChanged += new System.EventHandler(this.DateTimePicker1_ValueChanged);
            // 
            // txttime
            // 
            this.txttime.Location = new System.Drawing.Point(324, 65);
            this.txttime.Name = "txttime";
            this.txttime.Size = new System.Drawing.Size(155, 26);
            this.txttime.TabIndex = 21;
            this.txttime.TextChanged += new System.EventHandler(this.txttime_TextChanged);
            // 
            // txttotal
            // 
            this.txttotal.Location = new System.Drawing.Point(541, 378);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(98, 26);
            this.txttotal.TabIndex = 34;
            // 
            // txtcash
            // 
            this.txtcash.AcceptsTab = true;
            this.txtcash.Location = new System.Drawing.Point(540, 505);
            this.txtcash.Name = "txtcash";
            this.txtcash.Size = new System.Drawing.Size(99, 26);
            this.txtcash.TabIndex = 35;
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(497, 566);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(142, 60);
            this.Button1.TabIndex = 36;
            this.Button1.Text = "Get receipt";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
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
            // lsvitems
            // 
            this.lsvitems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader5,
            this.ColumnHeader1,
            this.ColumnHeader2,
            this.ColumnHeader3,
            this.ColumnHeader4});
            this.lsvitems.FullRowSelect = true;
            this.lsvitems.GridLines = true;
            this.lsvitems.Location = new System.Drawing.Point(16, 190);
            this.lsvitems.Name = "lsvitems";
            this.lsvitems.Size = new System.Drawing.Size(647, 171);
            this.lsvitems.TabIndex = 69;
            this.lsvitems.UseCompatibleStateImageBehavior = false;
            this.lsvitems.View = System.Windows.Forms.View.Details;
            this.lsvitems.SelectedIndexChanged += new System.EventHandler(this.lsvitems_SelectedIndexChanged);
            this.lsvitems.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lsvitems_MouseClick);
            // 
            // ColumnHeader5
            // 
            this.ColumnHeader5.Text = "ID";
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label9.Location = new System.Drawing.Point(379, 416);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(148, 20);
            this.Label9.TabIndex = 70;
            this.Label9.Text = "Discount In Naira";
            // 
            // txtdiscount
            // 
            this.txtdiscount.Location = new System.Drawing.Point(538, 410);
            this.txtdiscount.Name = "txtdiscount";
            this.txtdiscount.Size = new System.Drawing.Size(101, 26);
            this.txtdiscount.TabIndex = 71;
            this.txtdiscount.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtdiscount_MouseClick);
            this.txtdiscount.TextChanged += new System.EventHandler(this.txtdiscount_TextChanged);
            this.txtdiscount.MouseHover += new System.EventHandler(this.txtdiscount_MouseHover);
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label10.Location = new System.Drawing.Point(411, 459);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(104, 20);
            this.Label10.TabIndex = 72;
            this.Label10.Text = "Grand Total";
            // 
            // txtgrandtotal
            // 
            this.txtgrandtotal.Location = new System.Drawing.Point(538, 459);
            this.txtgrandtotal.Name = "txtgrandtotal";
            this.txtgrandtotal.Size = new System.Drawing.Size(101, 26);
            this.txtgrandtotal.TabIndex = 73;
            this.txtgrandtotal.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtgrandtotal_MouseClick);
            this.txtgrandtotal.TextChanged += new System.EventHandler(this.txtgrandtotal_TextChanged);
            this.txtgrandtotal.MouseHover += new System.EventHandler(this.txtgrandtotal_MouseHover);
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Location = new System.Drawing.Point(16, 375);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(186, 40);
            this.Label11.TabIndex = 74;
            this.Label11.Text = "Percentage(%) Discount \r\nGiven\r\n";
            // 
            // cbldiscount
            // 
            this.cbldiscount.FormattingEnabled = true;
            this.cbldiscount.Items.AddRange(new object[] {
            "5",
            "10",
            "15",
            "20"});
            this.cbldiscount.Location = new System.Drawing.Point(20, 418);
            this.cbldiscount.Name = "cbldiscount";
            this.cbldiscount.Size = new System.Drawing.Size(182, 28);
            this.cbldiscount.TabIndex = 80;
            this.cbldiscount.SelectedIndexChanged += new System.EventHandler(this.cbldiscount_SelectedIndexChanged);
            // 
            // Label13
            // 
            this.Label13.AutoSize = true;
            this.Label13.Location = new System.Drawing.Point(19, 627);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(138, 20);
            this.Label13.TabIndex = 83;
            this.Label13.Text = "Discount Approval";
            // 
            // txtdiscountapproval
            // 
            this.txtdiscountapproval.Location = new System.Drawing.Point(19, 650);
            this.txtdiscountapproval.Name = "txtdiscountapproval";
            this.txtdiscountapproval.PasswordChar = '#';
            this.txtdiscountapproval.Size = new System.Drawing.Size(138, 26);
            this.txtdiscountapproval.TabIndex = 82;
            this.txtdiscountapproval.TextChanged += new System.EventHandler(this.txtdiscountapproval_TextChanged);
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.Location = new System.Drawing.Point(16, 476);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(131, 20);
            this.Label12.TabIndex = 84;
            this.Label12.Text = "Discount In Naira\r\n";
            // 
            // txtnairadiscount
            // 
            this.txtnairadiscount.Location = new System.Drawing.Point(20, 505);
            this.txtnairadiscount.Name = "txtnairadiscount";
            this.txtnairadiscount.Size = new System.Drawing.Size(127, 26);
            this.txtnairadiscount.TabIndex = 85;
            // 
            // Label14
            // 
            this.Label14.AutoSize = true;
            this.Label14.Location = new System.Drawing.Point(402, 160);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(132, 20);
            this.Label14.TabIndex = 86;
            this.Label14.Text = "Change Quantity ";
            // 
            // txtquantity
            // 
            this.txtquantity.Location = new System.Drawing.Point(540, 156);
            this.txtquantity.Name = "txtquantity";
            this.txtquantity.Size = new System.Drawing.Size(56, 26);
            this.txtquantity.TabIndex = 87;
            this.txtquantity.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            this.txtquantity.ChangeUICues += new System.Windows.Forms.UICuesEventHandler(this.TextBox1_ChangeUICues);
            // 
            // Label15
            // 
            this.Label15.AutoSize = true;
            this.Label15.Location = new System.Drawing.Point(137, 159);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(51, 20);
            this.Label15.TabIndex = 88;
            this.Label15.Text = "Name";
            // 
            // txtproductname
            // 
            this.txtproductname.Location = new System.Drawing.Point(206, 158);
            this.txtproductname.Name = "txtproductname";
            this.txtproductname.ReadOnly = true;
            this.txtproductname.Size = new System.Drawing.Size(186, 26);
            this.txtproductname.TabIndex = 89;
            // 
            // Label16
            // 
            this.Label16.AutoSize = true;
            this.Label16.Location = new System.Drawing.Point(22, 160);
            this.Label16.Name = "Label16";
            this.Label16.Size = new System.Drawing.Size(26, 20);
            this.Label16.TabIndex = 90;
            this.Label16.Text = "ID";
            // 
            // txttransactionid
            // 
            this.txttransactionid.Location = new System.Drawing.Point(68, 158);
            this.txttransactionid.Name = "txttransactionid";
            this.txttransactionid.ReadOnly = true;
            this.txttransactionid.Size = new System.Drawing.Size(58, 26);
            this.txttransactionid.TabIndex = 91;
            // 
            // Button2
            // 
            this.Button2.BackColor = System.Drawing.Color.Lime;
            this.Button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button2.Location = new System.Drawing.Point(602, 152);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(56, 35);
            this.Button2.TabIndex = 92;
            this.Button2.Text = "ok";
            this.Button2.UseVisualStyleBackColor = false;
            this.Button2.Click += new System.EventHandler(this.Button2_Click_1);
            // 
            // Button3
            // 
            this.Button3.BackColor = System.Drawing.Color.White;
            this.Button3.ForeColor = System.Drawing.Color.Red;
            this.Button3.Location = new System.Drawing.Point(540, 60);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(123, 36);
            this.Button3.TabIndex = 93;
            this.Button3.Text = "Remove Item";
            this.Button3.UseVisualStyleBackColor = false;
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // Button4
            // 
            this.Button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button4.ForeColor = System.Drawing.Color.Red;
            this.Button4.Location = new System.Drawing.Point(173, 650);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(110, 49);
            this.Button4.TabIndex = 118;
            this.Button4.Text = "Hold Sales";
            this.Button4.UseVisualStyleBackColor = true;
            this.Button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // Button5
            // 
            this.Button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Button5.Location = new System.Drawing.Point(289, 650);
            this.Button5.Name = "Button5";
            this.Button5.Size = new System.Drawing.Size(122, 49);
            this.Button5.TabIndex = 119;
            this.Button5.Text = "View Hold Sales";
            this.Button5.UseVisualStyleBackColor = true;
            this.Button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // Button6
            // 
            this.Button6.BackColor = System.Drawing.Color.Red;
            this.Button6.ForeColor = System.Drawing.Color.White;
            this.Button6.Location = new System.Drawing.Point(497, 650);
            this.Button6.Name = "Button6";
            this.Button6.Size = new System.Drawing.Size(142, 44);
            this.Button6.TabIndex = 120;
            this.Button6.Text = "Clear Cart";
            this.Button6.UseVisualStyleBackColor = false;
            this.Button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Black;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Label1.Location = new System.Drawing.Point(169, 42);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(326, 20);
            this.Label1.TabIndex = 156;
            this.Label1.Text = "Okha Market , Sapele Road, Benin City.\r\n";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.Red;
            this.Label2.Location = new System.Drawing.Point(177, 9);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(302, 24);
            this.Label2.TabIndex = 155;
            this.Label2.Text = "WELCOME TO TRENDY SHOP\r\n";
            // 
            // viewsales
            // 
            this.AcceptButton = this.Button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 738);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Button6);
            this.Controls.Add(this.Button5);
            this.Controls.Add(this.Button4);
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
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "viewsales";
            this.Text = "viewsales";
            this.Load += new System.EventHandler(this.receipt_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.viewsales_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.Label Label5;
		internal System.Windows.Forms.Label Label6;
		internal System.Windows.Forms.Label Label7;
		internal System.Windows.Forms.Label Label8;
		internal System.Windows.Forms.TextBox txtcashiername1;
		internal System.Windows.Forms.TextBox txtreceiptnumber;
		internal System.Windows.Forms.DateTimePicker DateTimePicker1;
		internal System.Windows.Forms.TextBox txttime;
		internal System.Windows.Forms.TextBox txttotal;
		internal System.Windows.Forms.TextBox txtcash;
		internal System.Windows.Forms.Button Button1;
		internal System.Windows.Forms.ColumnHeader ColumnHeader1;
		internal System.Windows.Forms.ColumnHeader ColumnHeader2;
		internal System.Windows.Forms.ColumnHeader ColumnHeader3;
		internal System.Windows.Forms.ColumnHeader ColumnHeader4;
		internal System.Windows.Forms.ListView lsvitems;
		internal System.Windows.Forms.Label Label9;
		internal System.Windows.Forms.TextBox txtdiscount;
		internal System.Windows.Forms.Label Label10;
		internal System.Windows.Forms.TextBox txtgrandtotal;
		internal System.Windows.Forms.Label Label11;
		internal System.Windows.Forms.ComboBox cbldiscount;
		internal System.Windows.Forms.Label Label13;
		internal System.Windows.Forms.TextBox txtdiscountapproval;
		internal System.Windows.Forms.Label Label12;
		internal System.Windows.Forms.TextBox txtnairadiscount;
		internal System.Windows.Forms.Label Label14;
		internal System.Windows.Forms.TextBox txtquantity;
		internal System.Windows.Forms.Label Label15;
		internal System.Windows.Forms.TextBox txtproductname;
		internal System.Windows.Forms.ColumnHeader ColumnHeader5;
		internal System.Windows.Forms.Label Label16;
		internal System.Windows.Forms.TextBox txttransactionid;
		internal System.Windows.Forms.Button Button2;
		internal System.Windows.Forms.Button Button3;
		internal System.Windows.Forms.Button Button4;
		internal System.Windows.Forms.Button Button5;
		internal System.Windows.Forms.Button Button6;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.Label Label2;
	}

}