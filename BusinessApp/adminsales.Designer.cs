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
	public partial class adminsales : System.Windows.Forms.Form
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
            this.Button7 = new System.Windows.Forms.Button();
            this.Button6 = new System.Windows.Forms.Button();
            this.txtcardssearch = new System.Windows.Forms.TextBox();
            this.btncards = new System.Windows.Forms.Button();
            this.txtcardsquantity = new System.Windows.Forms.TextBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.txtseachdrugs = new System.Windows.Forms.TextBox();
            this.Button1 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.btnenter = new System.Windows.Forms.Button();
            this.txttime = new System.Windows.Forms.TextBox();
            this.DateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.txtcashiername1 = new System.Windows.Forms.TextBox();
            this.txtquantity = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtunitsalesprice1 = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.txtunitsalesprice = new System.Windows.Forms.TextBox();
            this.lsvitems1 = new System.Windows.Forms.ListView();
            this.ColumnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lsvitems = new System.Windows.Forms.ListView();
            this.ColumnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Label4 = new System.Windows.Forms.Label();
            this.txtdrugid = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.txtcosmeticsid = new System.Windows.Forms.TextBox();
            this.PictureBox2 = new System.Windows.Forms.PictureBox();
            this.PictureBox3 = new System.Windows.Forms.PictureBox();
            this.Button3 = new System.Windows.Forms.Button();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt0 = new System.Windows.Forms.TextBox();
            this.thisMonth1 = new System.Windows.Forms.Button();
            this.thisMonth2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.thisMonth = new System.Windows.Forms.Button();
            this.txtcode2 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtproductname = new System.Windows.Forms.TextBox();
            this.Label15 = new System.Windows.Forms.Label();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // Button7
            // 
            this.Button7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Button7.Location = new System.Drawing.Point(1165, 189);
            this.Button7.Name = "Button7";
            this.Button7.Size = new System.Drawing.Size(154, 49);
            this.Button7.TabIndex = 101;
            this.Button7.Text = "ReOrder Level";
            this.Button7.UseVisualStyleBackColor = true;
            this.Button7.Click += new System.EventHandler(this.Button7_Click);
            // 
            // Button6
            // 
            this.Button6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Button6.Location = new System.Drawing.Point(1165, 141);
            this.Button6.Name = "Button6";
            this.Button6.Size = new System.Drawing.Size(154, 42);
            this.Button6.TabIndex = 100;
            this.Button6.Text = "Expiry Date Info.";
            this.Button6.UseVisualStyleBackColor = true;
            this.Button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // txtcardssearch
            // 
            this.txtcardssearch.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtcardssearch.Location = new System.Drawing.Point(1154, 219);
            this.txtcardssearch.Multiline = true;
            this.txtcardssearch.Name = "txtcardssearch";
            this.txtcardssearch.Size = new System.Drawing.Size(164, 37);
            this.txtcardssearch.TabIndex = 98;
            this.txtcardssearch.TextChanged += new System.EventHandler(this.txtcardssearch_TextChanged);
            // 
            // btncards
            // 
            this.btncards.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btncards.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncards.Location = new System.Drawing.Point(846, 228);
            this.btncards.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btncards.Name = "btncards";
            this.btncards.Size = new System.Drawing.Size(176, 63);
            this.btncards.TabIndex = 96;
            this.btncards.Text = "Calculate And Add To CART";
            this.btncards.UseVisualStyleBackColor = true;
            this.btncards.Click += new System.EventHandler(this.btncards_Click);
            // 
            // txtcardsquantity
            // 
            this.txtcardsquantity.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtcardsquantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcardsquantity.Location = new System.Drawing.Point(781, 249);
            this.txtcardsquantity.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtcardsquantity.Name = "txtcardsquantity";
            this.txtcardsquantity.Size = new System.Drawing.Size(55, 29);
            this.txtcardsquantity.TabIndex = 95;
            // 
            // Label7
            // 
            this.Label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.Location = new System.Drawing.Point(701, 252);
            this.Label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(78, 24);
            this.Label7.TabIndex = 94;
            this.Label7.Text = "Quantity";
            // 
            // txtseachdrugs
            // 
            this.txtseachdrugs.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtseachdrugs.Location = new System.Drawing.Point(427, 252);
            this.txtseachdrugs.Multiline = true;
            this.txtseachdrugs.Name = "txtseachdrugs";
            this.txtseachdrugs.Size = new System.Drawing.Size(195, 37);
            this.txtseachdrugs.TabIndex = 92;
            this.txtseachdrugs.TextChanged += new System.EventHandler(this.txtseachdrugs_TextChanged);
            // 
            // Button1
            // 
            this.Button1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Button1.Location = new System.Drawing.Point(1165, 86);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(152, 53);
            this.Button1.TabIndex = 91;
            this.Button1.Text = "View Sales Log";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Button2
            // 
            this.Button2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Button2.Location = new System.Drawing.Point(997, 88);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(162, 53);
            this.Button2.TabIndex = 87;
            this.Button2.Text = "View CART";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // btnenter
            // 
            this.btnenter.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnenter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnenter.Location = new System.Drawing.Point(171, 231);
            this.btnenter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnenter.Name = "btnenter";
            this.btnenter.Size = new System.Drawing.Size(175, 66);
            this.btnenter.TabIndex = 86;
            this.btnenter.Text = "Calculate And Add To CART";
            this.btnenter.UseVisualStyleBackColor = true;
            this.btnenter.Click += new System.EventHandler(this.btnenter_Click);
            // 
            // txttime
            // 
            this.txttime.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txttime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttime.Location = new System.Drawing.Point(1187, 54);
            this.txttime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txttime.Name = "txttime";
            this.txttime.ReadOnly = true;
            this.txttime.Size = new System.Drawing.Size(131, 29);
            this.txttime.TabIndex = 85;
            // 
            // DateTimePicker1
            // 
            this.DateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DateTimePicker1.Location = new System.Drawing.Point(544, 108);
            this.DateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DateTimePicker1.Name = "DateTimePicker1";
            this.DateTimePicker1.Size = new System.Drawing.Size(295, 26);
            this.DateTimePicker1.TabIndex = 84;
            // 
            // Label8
            // 
            this.Label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.Location = new System.Drawing.Point(483, 108);
            this.Label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(53, 24);
            this.Label8.TabIndex = 83;
            this.Label8.Text = "Date:";
            // 
            // Label9
            // 
            this.Label9.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Label9.AutoSize = true;
            this.Label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label9.Location = new System.Drawing.Point(1116, 59);
            this.Label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(58, 24);
            this.Label9.TabIndex = 82;
            this.Label9.Text = "Time:";
            // 
            // Label5
            // 
            this.Label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(25, 112);
            this.Label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(142, 24);
            this.Label5.TabIndex = 81;
            this.Label5.Text = "Cashier Name";
            // 
            // txtcashiername1
            // 
            this.txtcashiername1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtcashiername1.Location = new System.Drawing.Point(175, 110);
            this.txtcashiername1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtcashiername1.Name = "txtcashiername1";
            this.txtcashiername1.ReadOnly = true;
            this.txtcashiername1.Size = new System.Drawing.Size(199, 26);
            this.txtcashiername1.TabIndex = 80;
            // 
            // txtquantity
            // 
            this.txtquantity.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtquantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtquantity.Location = new System.Drawing.Point(96, 259);
            this.txtquantity.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtquantity.Name = "txtquantity";
            this.txtquantity.Size = new System.Drawing.Size(65, 29);
            this.txtquantity.TabIndex = 79;
            // 
            // Label2
            // 
            this.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(19, 259);
            this.Label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(78, 24);
            this.Label2.TabIndex = 78;
            this.Label2.Text = "Quantity";
            // 
            // Label1
            // 
            this.Label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(812, 150);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(225, 20);
            this.Label1.TabIndex = 102;
            this.Label1.Text = "Cosmetics Unit Sales Price";
            // 
            // txtunitsalesprice1
            // 
            this.txtunitsalesprice1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtunitsalesprice1.Location = new System.Drawing.Point(1043, 147);
            this.txtunitsalesprice1.Name = "txtunitsalesprice1";
            this.txtunitsalesprice1.ReadOnly = true;
            this.txtunitsalesprice1.Size = new System.Drawing.Size(86, 26);
            this.txtunitsalesprice1.TabIndex = 103;
            // 
            // Label3
            // 
            this.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(579, 200);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(181, 20);
            this.Label3.TabIndex = 104;
            this.Label3.Text = "Drug Unit Sales Price";
            // 
            // txtunitsalesprice
            // 
            this.txtunitsalesprice.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtunitsalesprice.Location = new System.Drawing.Point(766, 200);
            this.txtunitsalesprice.Name = "txtunitsalesprice";
            this.txtunitsalesprice.Size = new System.Drawing.Size(101, 26);
            this.txtunitsalesprice.TabIndex = 105;
            // 
            // lsvitems1
            // 
            this.lsvitems1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader1,
            this.ColumnHeader7,
            this.ColumnHeader8,
            this.ColumnHeader9,
            this.ColumnHeader11,
            this.ColumnHeader13,
            this.ColumnHeader14});
            this.lsvitems1.FullRowSelect = true;
            this.lsvitems1.GridLines = true;
            this.lsvitems1.HideSelection = false;
            this.lsvitems1.Location = new System.Drawing.Point(1170, 757);
            this.lsvitems1.Name = "lsvitems1";
            this.lsvitems1.ShowItemToolTips = true;
            this.lsvitems1.Size = new System.Drawing.Size(183, 56);
            this.lsvitems1.TabIndex = 107;
            this.lsvitems1.UseCompatibleStateImageBehavior = false;
            this.lsvitems1.View = System.Windows.Forms.View.Details;
            this.lsvitems1.SelectedIndexChanged += new System.EventHandler(this.lsvitems1_SelectedIndexChanged);
            this.lsvitems1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lsvitems1_MouseClick);
            // 
            // ColumnHeader1
            // 
            this.ColumnHeader1.Text = "ID";
            this.ColumnHeader1.Width = 51;
            // 
            // ColumnHeader7
            // 
            this.ColumnHeader7.Text = "productname ";
            this.ColumnHeader7.Width = 315;
            // 
            // ColumnHeader8
            // 
            this.ColumnHeader8.Text = "Qty";
            this.ColumnHeader8.Width = 58;
            // 
            // ColumnHeader9
            // 
            this.ColumnHeader9.Text = "S/Price";
            this.ColumnHeader9.Width = 64;
            // 
            // ColumnHeader11
            // 
            this.ColumnHeader11.Text = "C/Price";
            this.ColumnHeader11.Width = 104;
            // 
            // ColumnHeader13
            // 
            this.ColumnHeader13.Text = "Exp.";
            this.ColumnHeader13.Width = 125;
            // 
            // ColumnHeader14
            // 
            this.ColumnHeader14.Text = "entrydate";
            this.ColumnHeader14.Width = 87;
            // 
            // lsvitems
            // 
            this.lsvitems.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
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
            this.lsvitems.HideSelection = false;
            this.lsvitems.Location = new System.Drawing.Point(38, 314);
            this.lsvitems.Name = "lsvitems";
            this.lsvitems.ShowItemToolTips = true;
            this.lsvitems.Size = new System.Drawing.Size(908, 409);
            this.lsvitems.TabIndex = 106;
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
            this.ColumnHeader2.Width = 435;
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
            this.ColumnHeader5.Width = 104;
            // 
            // ColumnHeader6
            // 
            this.ColumnHeader6.Text = "Exp";
            this.ColumnHeader6.Width = 125;
            // 
            // ColumnHeader10
            // 
            this.ColumnHeader10.Text = "entrydate";
            this.ColumnHeader10.Width = 87;
            // 
            // Label4
            // 
            this.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(18, 197);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(85, 20);
            this.Label4.TabIndex = 108;
            this.Label4.Text = "Drug\'s ID";
            // 
            // txtdrugid
            // 
            this.txtdrugid.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtdrugid.Location = new System.Drawing.Point(112, 194);
            this.txtdrugid.Name = "txtdrugid";
            this.txtdrugid.ReadOnly = true;
            this.txtdrugid.Size = new System.Drawing.Size(55, 26);
            this.txtdrugid.TabIndex = 109;
            // 
            // Label6
            // 
            this.Label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(710, 152);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(28, 20);
            this.Label6.TabIndex = 110;
            this.Label6.Text = "ID";
            // 
            // txtcosmeticsid
            // 
            this.txtcosmeticsid.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtcosmeticsid.Location = new System.Drawing.Point(744, 150);
            this.txtcosmeticsid.Name = "txtcosmeticsid";
            this.txtcosmeticsid.ReadOnly = true;
            this.txtcosmeticsid.Size = new System.Drawing.Size(64, 26);
            this.txtcosmeticsid.TabIndex = 111;
            // 
            // PictureBox2
            // 
            this.PictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.PictureBox2.Image = global::BusinessApp.Properties.Resources.search3;
            this.PictureBox2.Location = new System.Drawing.Point(1090, 219);
            this.PictureBox2.Name = "PictureBox2";
            this.PictureBox2.Size = new System.Drawing.Size(58, 37);
            this.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox2.TabIndex = 99;
            this.PictureBox2.TabStop = false;
            // 
            // PictureBox3
            // 
            this.PictureBox3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.PictureBox3.Image = global::BusinessApp.Properties.Resources.search3;
            this.PictureBox3.Location = new System.Drawing.Point(349, 252);
            this.PictureBox3.Name = "PictureBox3";
            this.PictureBox3.Size = new System.Drawing.Size(61, 37);
            this.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox3.TabIndex = 93;
            this.PictureBox3.TabStop = false;
            // 
            // Button3
            // 
            this.Button3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Button3.BackColor = System.Drawing.Color.White;
            this.Button3.ForeColor = System.Drawing.Color.Red;
            this.Button3.Location = new System.Drawing.Point(546, 142);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(158, 43);
            this.Button3.TabIndex = 114;
            this.Button3.Text = "View Hold Sales";
            this.Button3.UseVisualStyleBackColor = false;
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // txt3
            // 
            this.txt3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txt3.ForeColor = System.Drawing.Color.Gold;
            this.txt3.Location = new System.Drawing.Point(1001, 626);
            this.txt3.Multiline = true;
            this.txt3.Name = "txt3";
            this.txt3.ReadOnly = true;
            this.txt3.Size = new System.Drawing.Size(202, 85);
            this.txt3.TabIndex = 136;
            // 
            // txt1
            // 
            this.txt1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txt1.ForeColor = System.Drawing.Color.Red;
            this.txt1.Location = new System.Drawing.Point(1001, 472);
            this.txt1.Multiline = true;
            this.txt1.Name = "txt1";
            this.txt1.ReadOnly = true;
            this.txt1.Size = new System.Drawing.Size(207, 89);
            this.txt1.TabIndex = 135;
            // 
            // txt0
            // 
            this.txt0.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txt0.Location = new System.Drawing.Point(1001, 352);
            this.txt0.Multiline = true;
            this.txt0.Name = "txt0";
            this.txt0.ReadOnly = true;
            this.txt0.Size = new System.Drawing.Size(207, 80);
            this.txt0.TabIndex = 134;
            // 
            // thisMonth1
            // 
            this.thisMonth1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.thisMonth1.ForeColor = System.Drawing.Color.Red;
            this.thisMonth1.Location = new System.Drawing.Point(1214, 472);
            this.thisMonth1.Name = "thisMonth1";
            this.thisMonth1.Size = new System.Drawing.Size(104, 89);
            this.thisMonth1.TabIndex = 133;
            this.thisMonth1.Text = "View Details";
            this.thisMonth1.UseVisualStyleBackColor = true;
            this.thisMonth1.Click += new System.EventHandler(this.thisMonth1_Click);
            // 
            // thisMonth2
            // 
            this.thisMonth2.AllowDrop = true;
            this.thisMonth2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.thisMonth2.Location = new System.Drawing.Point(1214, 352);
            this.thisMonth2.Name = "thisMonth2";
            this.thisMonth2.Size = new System.Drawing.Size(104, 80);
            this.thisMonth2.TabIndex = 132;
            this.thisMonth2.Text = "View Detail";
            this.thisMonth2.UseVisualStyleBackColor = true;
            this.thisMonth2.Click += new System.EventHandler(this.thisMonth2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Lime;
            this.textBox1.Location = new System.Drawing.Point(1001, 317);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(317, 29);
            this.textBox1.TabIndex = 131;
            this.textBox1.Text = "Expiry Date NOTIFICATION";
            // 
            // thisMonth
            // 
            this.thisMonth.AllowDrop = true;
            this.thisMonth.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.thisMonth.BackColor = System.Drawing.Color.White;
            this.thisMonth.ForeColor = System.Drawing.Color.Gold;
            this.thisMonth.Location = new System.Drawing.Point(1214, 626);
            this.thisMonth.Name = "thisMonth";
            this.thisMonth.Size = new System.Drawing.Size(104, 85);
            this.thisMonth.TabIndex = 130;
            this.thisMonth.Text = "View Details";
            this.thisMonth.UseVisualStyleBackColor = false;
            this.thisMonth.Click += new System.EventHandler(this.thisMonth_Click);
            // 
            // txtcode2
            // 
            this.txtcode2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtcode2.Location = new System.Drawing.Point(112, 150);
            this.txtcode2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtcode2.Name = "txtcode2";
            this.txtcode2.Size = new System.Drawing.Size(199, 26);
            this.txtcode2.TabIndex = 138;
            this.txtcode2.TextChanged += new System.EventHandler(this.txtcode2_TextChanged);
            // 
            // label19
            // 
            this.label19.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(13, 150);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(88, 24);
            this.label19.TabIndex = 137;
            this.label19.Text = "Barcode";
            // 
            // txtproductname
            // 
            this.txtproductname.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtproductname.Location = new System.Drawing.Point(237, 194);
            this.txtproductname.Name = "txtproductname";
            this.txtproductname.ReadOnly = true;
            this.txtproductname.Size = new System.Drawing.Size(324, 26);
            this.txtproductname.TabIndex = 140;
            // 
            // Label15
            // 
            this.Label15.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Label15.AutoSize = true;
            this.Label15.Location = new System.Drawing.Point(177, 199);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(55, 20);
            this.Label15.TabIndex = 139;
            this.Label15.Text = "Name";
            // 
            // txtaddress
            // 
            this.txtaddress.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtaddress.Location = new System.Drawing.Point(0, 26);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.ReadOnly = true;
            this.txtaddress.Size = new System.Drawing.Size(1365, 26);
            this.txtaddress.TabIndex = 142;
            this.txtaddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtname
            // 
            this.txtname.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtname.Location = new System.Drawing.Point(0, 0);
            this.txtname.Name = "txtname";
            this.txtname.ReadOnly = true;
            this.txtname.Size = new System.Drawing.Size(1365, 26);
            this.txtname.TabIndex = 141;
            this.txtname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // adminsales
            // 
            this.AcceptButton = this.btnenter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1365, 816);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtproductname);
            this.Controls.Add(this.Label15);
            this.Controls.Add(this.txtcode2);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.txt0);
            this.Controls.Add(this.thisMonth1);
            this.Controls.Add(this.thisMonth2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.thisMonth);
            this.Controls.Add(this.Button3);
            this.Controls.Add(this.txtcosmeticsid);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.txtdrugid);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.lsvitems1);
            this.Controls.Add(this.lsvitems);
            this.Controls.Add(this.txtunitsalesprice);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.txtunitsalesprice1);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Button7);
            this.Controls.Add(this.Button6);
            this.Controls.Add(this.PictureBox2);
            this.Controls.Add(this.txtcardssearch);
            this.Controls.Add(this.btncards);
            this.Controls.Add(this.txtcardsquantity);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.PictureBox3);
            this.Controls.Add(this.txtseachdrugs);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.btnenter);
            this.Controls.Add(this.txttime);
            this.Controls.Add(this.DateTimePicker1);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.Label9);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.txtcashiername1);
            this.Controls.Add(this.txtquantity);
            this.Controls.Add(this.Label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "adminsales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "adminsales";
            this.Load += new System.EventHandler(this.adminsales_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.adminsales_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		internal System.Windows.Forms.Button Button7;
		internal System.Windows.Forms.Button Button6;
		internal System.Windows.Forms.PictureBox PictureBox2;
		internal System.Windows.Forms.TextBox txtcardssearch;
		internal System.Windows.Forms.Button btncards;
		internal System.Windows.Forms.TextBox txtcardsquantity;
		internal System.Windows.Forms.Label Label7;
		internal System.Windows.Forms.PictureBox PictureBox3;
		internal System.Windows.Forms.TextBox txtseachdrugs;
		internal System.Windows.Forms.Button Button1;
		internal System.Windows.Forms.Button Button2;
		internal System.Windows.Forms.Button btnenter;
		internal System.Windows.Forms.TextBox txttime;
		internal System.Windows.Forms.DateTimePicker DateTimePicker1;
		internal System.Windows.Forms.Label Label8;
		internal System.Windows.Forms.Label Label9;
		internal System.Windows.Forms.Label Label5;
		internal System.Windows.Forms.TextBox txtcashiername1;
		internal System.Windows.Forms.TextBox txtquantity;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.TextBox txtunitsalesprice1;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.TextBox txtunitsalesprice;
		internal System.Windows.Forms.ListView lsvitems1;
		internal System.Windows.Forms.ColumnHeader ColumnHeader1;
		internal System.Windows.Forms.ColumnHeader ColumnHeader7;
		internal System.Windows.Forms.ColumnHeader ColumnHeader8;
		internal System.Windows.Forms.ColumnHeader ColumnHeader9;
		internal System.Windows.Forms.ColumnHeader ColumnHeader11;
		internal System.Windows.Forms.ColumnHeader ColumnHeader13;
		internal System.Windows.Forms.ColumnHeader ColumnHeader14;
		internal System.Windows.Forms.ListView lsvitems;
		internal System.Windows.Forms.ColumnHeader ColumnHeader12;
		internal System.Windows.Forms.ColumnHeader ColumnHeader2;
		internal System.Windows.Forms.ColumnHeader ColumnHeader3;
		internal System.Windows.Forms.ColumnHeader ColumnHeader4;
		internal System.Windows.Forms.ColumnHeader ColumnHeader5;
		internal System.Windows.Forms.ColumnHeader ColumnHeader6;
		internal System.Windows.Forms.ColumnHeader ColumnHeader10;
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.TextBox txtdrugid;
		internal System.Windows.Forms.Label Label6;
		internal System.Windows.Forms.TextBox txtcosmeticsid;
		internal System.Windows.Forms.Button Button3;
        private TextBox txt3;
        private TextBox txt1;
        private TextBox txt0;
        private Button thisMonth1;
        private Button thisMonth2;
        private TextBox textBox1;
        private Button thisMonth;
        internal TextBox txtcode2;
        private Label label19;
        internal TextBox txtproductname;
        internal Label Label15;
        private TextBox txtaddress;
        private TextBox txtname;
    }

}