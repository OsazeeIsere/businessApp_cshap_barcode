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

namespace BusinessApp
{
	[Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
	public partial class sales : System.Windows.Forms.Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sales));
            this.txtcashiername1 = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.txtquantity = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.txttime = new System.Windows.Forms.TextBox();
            this.DateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.btnenter = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.Label14 = new System.Windows.Forms.Label();
            this.txtseachdrugs = new System.Windows.Forms.TextBox();
            this.txtcardssearch = new System.Windows.Forms.TextBox();
            this.btncards = new System.Windows.Forms.Button();
            this.txtcardsquantity = new System.Windows.Forms.TextBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.Button7 = new System.Windows.Forms.Button();
            this.Button6 = new System.Windows.Forms.Button();
            this.PrintForm1 = new Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(this.components);
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.lsvitems = new System.Windows.Forms.ListView();
            this.ColumnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lsvitems1 = new System.Windows.Forms.ListView();
            this.ColumnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtdrugid = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.txtcosmeticsid = new System.Windows.Forms.TextBox();
            this.Label12 = new System.Windows.Forms.Label();
            this.Label13 = new System.Windows.Forms.Label();
            this.txtcosmeticsname = new System.Windows.Forms.TextBox();
            this.txtproductname = new System.Windows.Forms.TextBox();
            this.Label15 = new System.Windows.Forms.Label();
            this.Button3 = new System.Windows.Forms.Button();
            this.lbaddress = new System.Windows.Forms.Label();
            this.lbname = new System.Windows.Forms.Label();
            this.thisMonth = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.thisMonth2 = new System.Windows.Forms.Button();
            this.thisMonth1 = new System.Windows.Forms.Button();
            this.txt0 = new System.Windows.Forms.TextBox();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.PictureBox2 = new System.Windows.Forms.PictureBox();
            this.PictureBox3 = new System.Windows.Forms.PictureBox();
            this.txtcode2 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // txtcashiername1
            // 
            this.txtcashiername1.Location = new System.Drawing.Point(154, 47);
            this.txtcashiername1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtcashiername1.Name = "txtcashiername1";
            this.txtcashiername1.ReadOnly = true;
            this.txtcashiername1.Size = new System.Drawing.Size(199, 26);
            this.txtcashiername1.TabIndex = 25;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(-154, 220);
            this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(109, 20);
            this.Label4.TabIndex = 24;
            this.Label4.Text = "Cashier Name";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(-144, 400);
            this.Label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(77, 20);
            this.Label3.TabIndex = 22;
            this.Label3.Text = "Unit Price";
            // 
            // txtquantity
            // 
            this.txtquantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtquantity.Location = new System.Drawing.Point(91, 211);
            this.txtquantity.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtquantity.Name = "txtquantity";
            this.txtquantity.Size = new System.Drawing.Size(67, 29);
            this.txtquantity.TabIndex = 21;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(14, 211);
            this.Label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(78, 24);
            this.Label2.TabIndex = 20;
            this.Label2.Text = "Quantity";
            this.Label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(-172, 312);
            this.Label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(110, 20);
            this.Label1.TabIndex = 19;
            this.Label1.Text = "Product Name";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(4, 49);
            this.Label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(142, 24);
            this.Label5.TabIndex = 29;
            this.Label5.Text = "Cashier Name";
            // 
            // txttime
            // 
            this.txttime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttime.Location = new System.Drawing.Point(930, 92);
            this.txttime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txttime.Name = "txttime";
            this.txttime.ReadOnly = true;
            this.txttime.Size = new System.Drawing.Size(131, 29);
            this.txttime.TabIndex = 33;
            this.txttime.TextChanged += new System.EventHandler(this.txttime_TextChanged);
            // 
            // DateTimePicker1
            // 
            this.DateTimePicker1.Location = new System.Drawing.Point(535, 90);
            this.DateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DateTimePicker1.Name = "DateTimePicker1";
            this.DateTimePicker1.Size = new System.Drawing.Size(295, 26);
            this.DateTimePicker1.TabIndex = 32;
            this.DateTimePicker1.ValueChanged += new System.EventHandler(this.DateTimePicker1_ValueChanged);
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.Location = new System.Drawing.Point(458, 90);
            this.Label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(53, 24);
            this.Label8.TabIndex = 31;
            this.Label8.Text = "Date:";
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label9.Location = new System.Drawing.Point(859, 97);
            this.Label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(58, 24);
            this.Label9.TabIndex = 30;
            this.Label9.Text = "Time:";
            // 
            // btnenter
            // 
            this.btnenter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnenter.Location = new System.Drawing.Point(166, 183);
            this.btnenter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnenter.Name = "btnenter";
            this.btnenter.Size = new System.Drawing.Size(167, 66);
            this.btnenter.TabIndex = 38;
            this.btnenter.Text = "Calculate And Add To CART";
            this.btnenter.UseVisualStyleBackColor = true;
            this.btnenter.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Button2
            // 
            this.Button2.Location = new System.Drawing.Point(965, 29);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(162, 53);
            this.Button2.TabIndex = 40;
            this.Button2.Text = "View CART";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(1133, 29);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(152, 53);
            this.Button1.TabIndex = 46;
            this.Button1.Text = "View Sales Log";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click_2);
            // 
            // Label14
            // 
            this.Label14.AutoSize = true;
            this.Label14.Location = new System.Drawing.Point(1283, 227);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(60, 20);
            this.Label14.TabIndex = 60;
            this.Label14.Text = "Search";
            this.Label14.Click += new System.EventHandler(this.Label14_Click);
            // 
            // txtseachdrugs
            // 
            this.txtseachdrugs.Location = new System.Drawing.Point(418, 212);
            this.txtseachdrugs.Multiline = true;
            this.txtseachdrugs.Name = "txtseachdrugs";
            this.txtseachdrugs.Size = new System.Drawing.Size(195, 37);
            this.txtseachdrugs.TabIndex = 59;
            this.txtseachdrugs.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // txtcardssearch
            // 
            this.txtcardssearch.Location = new System.Drawing.Point(1114, 211);
            this.txtcardssearch.Multiline = true;
            this.txtcardssearch.Name = "txtcardssearch";
            this.txtcardssearch.Size = new System.Drawing.Size(158, 37);
            this.txtcardssearch.TabIndex = 74;
            this.txtcardssearch.TextChanged += new System.EventHandler(this.TextBox3_TextChanged);
            // 
            // btncards
            // 
            this.btncards.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncards.Location = new System.Drawing.Point(885, 195);
            this.btncards.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btncards.Name = "btncards";
            this.btncards.Size = new System.Drawing.Size(155, 63);
            this.btncards.TabIndex = 72;
            this.btncards.Text = "Calculate And Add To CART";
            this.btncards.UseVisualStyleBackColor = true;
            this.btncards.Click += new System.EventHandler(this.btncards_Click);
            // 
            // txtcardsquantity
            // 
            this.txtcardsquantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcardsquantity.Location = new System.Drawing.Point(795, 216);
            this.txtcardsquantity.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtcardsquantity.Name = "txtcardsquantity";
            this.txtcardsquantity.Size = new System.Drawing.Size(80, 29);
            this.txtcardsquantity.TabIndex = 71;
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.Location = new System.Drawing.Point(718, 216);
            this.Label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(78, 24);
            this.Label7.TabIndex = 70;
            this.Label7.Text = "Quantity";
            // 
            // Button7
            // 
            this.Button7.Location = new System.Drawing.Point(1133, 132);
            this.Button7.Name = "Button7";
            this.Button7.Size = new System.Drawing.Size(154, 49);
            this.Button7.TabIndex = 77;
            this.Button7.Text = "ReOrder Level";
            this.Button7.UseVisualStyleBackColor = true;
            this.Button7.Click += new System.EventHandler(this.Button7_Click);
            // 
            // Button6
            // 
            this.Button6.Location = new System.Drawing.Point(1133, 84);
            this.Button6.Name = "Button6";
            this.Button6.Size = new System.Drawing.Size(154, 42);
            this.Button6.TabIndex = 76;
            this.Button6.Text = "Expiry Date Info.";
            this.Button6.UseVisualStyleBackColor = true;
            this.Button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // PrintForm1
            // 
            this.PrintForm1.DocumentName = "document";
            this.PrintForm1.Form = this;
            this.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter;
            this.PrintForm1.PrinterSettings = ((System.Drawing.Printing.PrinterSettings)(resources.GetObject("PrintForm1.PrinterSettings")));
            this.PrintForm1.PrintFileName = null;
            // 
            // Timer1
            // 
            this.Timer1.Enabled = true;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // lsvitems
            // 
            this.lsvitems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader12,
            this.ColumnHeader2,
            this.ColumnHeader3,
            this.ColumnHeader4,
            this.ColumnHeader6,
            this.ColumnHeader10});
            this.lsvitems.FullRowSelect = true;
            this.lsvitems.GridLines = true;
            this.lsvitems.Location = new System.Drawing.Point(12, 268);
            this.lsvitems.Name = "lsvitems";
            this.lsvitems.ShowItemToolTips = true;
            this.lsvitems.Size = new System.Drawing.Size(1049, 407);
            this.lsvitems.TabIndex = 78;
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
            // ColumnHeader6
            // 
            this.ColumnHeader6.Text = "Exp";
            this.ColumnHeader6.Width = 125;
            // 
            // ColumnHeader10
            // 
            this.ColumnHeader10.Text = "entrydate";
            this.ColumnHeader10.Width = 160;
            // 
            // lsvitems1
            // 
            this.lsvitems1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader1,
            this.ColumnHeader7,
            this.ColumnHeader8,
            this.ColumnHeader9,
            this.ColumnHeader13,
            this.ColumnHeader14});
            this.lsvitems1.FullRowSelect = true;
            this.lsvitems1.GridLines = true;
            this.lsvitems1.Location = new System.Drawing.Point(1310, 692);
            this.lsvitems1.Name = "lsvitems1";
            this.lsvitems1.ShowItemToolTips = true;
            this.lsvitems1.Size = new System.Drawing.Size(81, 60);
            this.lsvitems1.TabIndex = 79;
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
            // txtdrugid
            // 
            this.txtdrugid.Location = new System.Drawing.Point(103, 155);
            this.txtdrugid.Name = "txtdrugid";
            this.txtdrugid.ReadOnly = true;
            this.txtdrugid.Size = new System.Drawing.Size(55, 26);
            this.txtdrugid.TabIndex = 111;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(16, 156);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(76, 20);
            this.Label6.TabIndex = 110;
            this.Label6.Text = "Drug\'s ID";
            // 
            // txtcosmeticsid
            // 
            this.txtcosmeticsid.Location = new System.Drawing.Point(755, 161);
            this.txtcosmeticsid.Name = "txtcosmeticsid";
            this.txtcosmeticsid.ReadOnly = true;
            this.txtcosmeticsid.Size = new System.Drawing.Size(64, 26);
            this.txtcosmeticsid.TabIndex = 113;
            this.txtcosmeticsid.TextChanged += new System.EventHandler(this.txtcosmeticsid_TextChanged);
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.Location = new System.Drawing.Point(719, 164);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(30, 20);
            this.Label12.TabIndex = 112;
            this.Label12.Text = " ID";
            // 
            // Label13
            // 
            this.Label13.AutoSize = true;
            this.Label13.Location = new System.Drawing.Point(825, 169);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(51, 20);
            this.Label13.TabIndex = 114;
            this.Label13.Text = "Name";
            // 
            // txtcosmeticsname
            // 
            this.txtcosmeticsname.Location = new System.Drawing.Point(885, 164);
            this.txtcosmeticsname.Name = "txtcosmeticsname";
            this.txtcosmeticsname.ReadOnly = true;
            this.txtcosmeticsname.Size = new System.Drawing.Size(223, 26);
            this.txtcosmeticsname.TabIndex = 115;
            // 
            // txtproductname
            // 
            this.txtproductname.Location = new System.Drawing.Point(255, 150);
            this.txtproductname.Name = "txtproductname";
            this.txtproductname.ReadOnly = true;
            this.txtproductname.Size = new System.Drawing.Size(324, 26);
            this.txtproductname.TabIndex = 117;
            // 
            // Label15
            // 
            this.Label15.AutoSize = true;
            this.Label15.Location = new System.Drawing.Point(195, 155);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(51, 20);
            this.Label15.TabIndex = 116;
            this.Label15.Text = "Name";
            // 
            // Button3
            // 
            this.Button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Button3.Location = new System.Drawing.Point(616, 124);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(139, 37);
            this.Button3.TabIndex = 120;
            this.Button3.Text = "View Hold Sales";
            this.Button3.UseVisualStyleBackColor = true;
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // lbaddress
            // 
            this.lbaddress.AutoSize = true;
            this.lbaddress.BackColor = System.Drawing.Color.Black;
            this.lbaddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbaddress.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbaddress.Location = new System.Drawing.Point(486, 45);
            this.lbaddress.Name = "lbaddress";
            this.lbaddress.Size = new System.Drawing.Size(33, 20);
            this.lbaddress.TabIndex = 122;
            this.lbaddress.Text = "lb2";
            // 
            // lbname
            // 
            this.lbname.AutoSize = true;
            this.lbname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbname.ForeColor = System.Drawing.Color.Red;
            this.lbname.Location = new System.Drawing.Point(476, 9);
            this.lbname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbname.Name = "lbname";
            this.lbname.Size = new System.Drawing.Size(44, 25);
            this.lbname.TabIndex = 121;
            this.lbname.Text = "lb1";
            // 
            // thisMonth
            // 
            this.thisMonth.AllowDrop = true;
            this.thisMonth.BackColor = System.Drawing.Color.White;
            this.thisMonth.ForeColor = System.Drawing.Color.Gold;
            this.thisMonth.Location = new System.Drawing.Point(1287, 577);
            this.thisMonth.Name = "thisMonth";
            this.thisMonth.Size = new System.Drawing.Size(104, 85);
            this.thisMonth.TabIndex = 123;
            this.thisMonth.Text = "View Details";
            this.thisMonth.UseVisualStyleBackColor = false;
            this.thisMonth.Click += new System.EventHandler(this.thisMonth_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Lime;
            this.textBox1.Location = new System.Drawing.Point(1074, 268);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(317, 29);
            this.textBox1.TabIndex = 124;
            this.textBox1.Text = "Expiry Date NOTIFICATION";
            // 
            // thisMonth2
            // 
            this.thisMonth2.AllowDrop = true;
            this.thisMonth2.Location = new System.Drawing.Point(1287, 303);
            this.thisMonth2.Name = "thisMonth2";
            this.thisMonth2.Size = new System.Drawing.Size(104, 80);
            this.thisMonth2.TabIndex = 125;
            this.thisMonth2.Text = "View Detail";
            this.thisMonth2.UseVisualStyleBackColor = true;
            this.thisMonth2.Click += new System.EventHandler(this.button4_Click);
            // 
            // thisMonth1
            // 
            this.thisMonth1.ForeColor = System.Drawing.Color.Red;
            this.thisMonth1.Location = new System.Drawing.Point(1287, 423);
            this.thisMonth1.Name = "thisMonth1";
            this.thisMonth1.Size = new System.Drawing.Size(104, 89);
            this.thisMonth1.TabIndex = 126;
            this.thisMonth1.Text = "View Details";
            this.thisMonth1.UseVisualStyleBackColor = true;
            this.thisMonth1.Click += new System.EventHandler(this.thisMonth1_Click);
            // 
            // txt0
            // 
            this.txt0.Location = new System.Drawing.Point(1074, 303);
            this.txt0.Multiline = true;
            this.txt0.Name = "txt0";
            this.txt0.Size = new System.Drawing.Size(207, 80);
            this.txt0.TabIndex = 127;
            // 
            // txt1
            // 
            this.txt1.ForeColor = System.Drawing.Color.Red;
            this.txt1.Location = new System.Drawing.Point(1074, 423);
            this.txt1.Multiline = true;
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(207, 89);
            this.txt1.TabIndex = 128;
            // 
            // txt3
            // 
            this.txt3.ForeColor = System.Drawing.Color.Gold;
            this.txt3.Location = new System.Drawing.Point(1074, 577);
            this.txt3.Multiline = true;
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(202, 85);
            this.txt3.TabIndex = 129;
            // 
            // PictureBox2
            // 
            this.PictureBox2.Image = global::BusinessApp.Properties.Resources.search3;
            this.PictureBox2.Location = new System.Drawing.Point(1050, 211);
            this.PictureBox2.Name = "PictureBox2";
            this.PictureBox2.Size = new System.Drawing.Size(58, 37);
            this.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox2.TabIndex = 75;
            this.PictureBox2.TabStop = false;
            this.PictureBox2.Click += new System.EventHandler(this.PictureBox2_Click);
            // 
            // PictureBox3
            // 
            this.PictureBox3.Image = global::BusinessApp.Properties.Resources.search3;
            this.PictureBox3.Location = new System.Drawing.Point(340, 212);
            this.PictureBox3.Name = "PictureBox3";
            this.PictureBox3.Size = new System.Drawing.Size(61, 37);
            this.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox3.TabIndex = 63;
            this.PictureBox3.TabStop = false;
            // 
            // txtcode2
            // 
            this.txtcode2.Location = new System.Drawing.Point(154, 97);
            this.txtcode2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtcode2.Name = "txtcode2";
            this.txtcode2.ReadOnly = true;
            this.txtcode2.Size = new System.Drawing.Size(190, 26);
            this.txtcode2.TabIndex = 131;
            this.txtcode2.TextChanged += new System.EventHandler(this.txtcode2_TextChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(59, 97);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(88, 24);
            this.label19.TabIndex = 130;
            this.label19.Text = "Barcode";
            // 
            // sales
            // 
            this.AcceptButton = this.btnenter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1412, 784);
            this.Controls.Add(this.txtcode2);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.txt0);
            this.Controls.Add(this.thisMonth1);
            this.Controls.Add(this.thisMonth2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.thisMonth);
            this.Controls.Add(this.lbaddress);
            this.Controls.Add(this.lbname);
            this.Controls.Add(this.Button3);
            this.Controls.Add(this.txtproductname);
            this.Controls.Add(this.Label15);
            this.Controls.Add(this.txtcosmeticsname);
            this.Controls.Add(this.Label13);
            this.Controls.Add(this.txtcosmeticsid);
            this.Controls.Add(this.Label12);
            this.Controls.Add(this.txtdrugid);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.lsvitems1);
            this.Controls.Add(this.lsvitems);
            this.Controls.Add(this.Button7);
            this.Controls.Add(this.Button6);
            this.Controls.Add(this.PictureBox2);
            this.Controls.Add(this.txtcardssearch);
            this.Controls.Add(this.btncards);
            this.Controls.Add(this.txtcardsquantity);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.PictureBox3);
            this.Controls.Add(this.Label14);
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
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.txtquantity);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "sales";
            this.Text = "Sales";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.sales_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.sales_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		internal System.Windows.Forms.TextBox txtcashiername1;
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.TextBox txtquantity;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.Label Label5;
		internal System.Windows.Forms.TextBox txttime;
		internal System.Windows.Forms.DateTimePicker DateTimePicker1;
		internal System.Windows.Forms.Label Label8;
		internal System.Windows.Forms.Label Label9;
		internal System.Windows.Forms.Button btnenter;
		internal System.Windows.Forms.Button Button2;
		internal System.Windows.Forms.Button Button1;
		internal System.Windows.Forms.Label Label14;
		internal System.Windows.Forms.TextBox txtseachdrugs;
		internal System.Windows.Forms.PictureBox PictureBox3;
		internal System.Windows.Forms.PictureBox PictureBox2;
		internal System.Windows.Forms.TextBox txtcardssearch;
		internal System.Windows.Forms.Button btncards;
		internal System.Windows.Forms.TextBox txtcardsquantity;
		internal System.Windows.Forms.Label Label7;
		internal System.Windows.Forms.Button Button7;
		internal System.Windows.Forms.Button Button6;
		internal Microsoft.VisualBasic.PowerPacks.Printing.PrintForm PrintForm1;
		internal System.Windows.Forms.Timer Timer1;
		internal System.Windows.Forms.ListView lsvitems;
		internal System.Windows.Forms.ColumnHeader ColumnHeader2;
		internal System.Windows.Forms.ColumnHeader ColumnHeader3;
		internal System.Windows.Forms.ColumnHeader ColumnHeader4;
		internal System.Windows.Forms.ColumnHeader ColumnHeader6;
		internal System.Windows.Forms.ColumnHeader ColumnHeader10;
		internal System.Windows.Forms.ColumnHeader ColumnHeader12;
		internal System.Windows.Forms.ListView lsvitems1;
		internal System.Windows.Forms.ColumnHeader ColumnHeader1;
		internal System.Windows.Forms.ColumnHeader ColumnHeader7;
		internal System.Windows.Forms.ColumnHeader ColumnHeader8;
		internal System.Windows.Forms.ColumnHeader ColumnHeader9;
		internal System.Windows.Forms.ColumnHeader ColumnHeader13;
		internal System.Windows.Forms.ColumnHeader ColumnHeader14;
		internal System.Windows.Forms.TextBox txtdrugid;
		internal System.Windows.Forms.Label Label6;
		internal System.Windows.Forms.TextBox txtcosmeticsid;
		internal System.Windows.Forms.Label Label12;
		internal System.Windows.Forms.TextBox txtcosmeticsname;
		internal System.Windows.Forms.Label Label13;
		internal System.Windows.Forms.TextBox txtproductname;
		internal System.Windows.Forms.Label Label15;
		internal System.Windows.Forms.Button Button3;
		internal System.Windows.Forms.Label lbaddress;
		internal System.Windows.Forms.Label lbname;
        private TextBox textBox1;
        private Button thisMonth;
        private Button thisMonth2;
        private Button thisMonth1;
        private TextBox txt3;
        private TextBox txt1;
        private TextBox txt0;
        internal TextBox txtcode2;
        private Label label19;
    }

}