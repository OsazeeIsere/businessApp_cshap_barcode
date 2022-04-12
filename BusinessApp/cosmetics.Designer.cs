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
	public partial class cosmetics : System.Windows.Forms.Form
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
            this.OpenFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Label8 = new System.Windows.Forms.Label();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.Button4 = new System.Windows.Forms.Button();
            this.txtitems = new System.Windows.Forms.TextBox();
            this.txtfile = new System.Windows.Forms.TextBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.Button2 = new System.Windows.Forms.Button();
            this.Button3 = new System.Windows.Forms.Button();
            this.txtproductname = new System.Windows.Forms.TextBox();
            this.txtcashiername1 = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.Button1 = new System.Windows.Forms.Button();
            this.txtunitprice = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.txtquantity = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.Button7 = new System.Windows.Forms.Button();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtamountpaid = new System.Windows.Forms.TextBox();
            this.Label13 = new System.Windows.Forms.Label();
            this.txtsupplierphonenumber = new System.Windows.Forms.TextBox();
            this.Label15 = new System.Windows.Forms.Label();
            this.txtinvoicenumber = new System.Windows.Forms.TextBox();
            this.Label14 = new System.Windows.Forms.Label();
            this.txtdatepurchased = new System.Windows.Forms.TextBox();
            this.Label12 = new System.Windows.Forms.Label();
            this.txtsuppliername = new System.Windows.Forms.TextBox();
            this.Label11 = new System.Windows.Forms.Label();
            this.txtexpirydate = new System.Windows.Forms.TextBox();
            this.Label9 = new System.Windows.Forms.Label();
            this.txtunitcostprice = new System.Windows.Forms.TextBox();
            this.Button5 = new System.Windows.Forms.Button();
            this.Button6 = new System.Windows.Forms.Button();
            this.Label10 = new System.Windows.Forms.Label();
            this.txtadminpassword = new System.Windows.Forms.TextBox();
            this.Button9 = new System.Windows.Forms.Button();
            this.lsvitems1 = new System.Windows.Forms.ListView();
            this.ColumnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txttotal = new System.Windows.Forms.TextBox();
            this.Label16 = new System.Windows.Forms.Label();
            this.txtproductid = new System.Windows.Forms.TextBox();
            this.Label18 = new System.Windows.Forms.Label();
            this.txtcode = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // OpenFileDialog1
            // 
            this.OpenFileDialog1.FileName = "OpenFileDialog1";
            this.OpenFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.OpenFileDialog1_FileOk);
            // 
            // Label8
            // 
            this.Label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(657, 390);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(60, 20);
            this.Label8.TabIndex = 51;
            this.Label8.Text = "Search";
            // 
            // txtsearch
            // 
            this.txtsearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtsearch.Location = new System.Drawing.Point(512, 383);
            this.txtsearch.Multiline = true;
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(132, 31);
            this.txtsearch.TabIndex = 50;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // Button4
            // 
            this.Button4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Button4.Location = new System.Drawing.Point(706, 133);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(137, 41);
            this.Button4.TabIndex = 47;
            this.Button4.Text = "Import";
            this.Button4.UseVisualStyleBackColor = true;
            this.Button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // txtitems
            // 
            this.txtitems.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtitems.Location = new System.Drawing.Point(849, 133);
            this.txtitems.Multiline = true;
            this.txtitems.Name = "txtitems";
            this.txtitems.Size = new System.Drawing.Size(62, 41);
            this.txtitems.TabIndex = 49;
            // 
            // txtfile
            // 
            this.txtfile.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtfile.Location = new System.Drawing.Point(706, 97);
            this.txtfile.Name = "txtfile";
            this.txtfile.Size = new System.Drawing.Size(205, 27);
            this.txtfile.TabIndex = 48;
            // 
            // Label7
            // 
            this.Label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(11, 340);
            this.Label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(122, 20);
            this.Label7.TabIndex = 45;
            this.Label7.Text = "Unit Cost Price";
            // 
            // Button2
            // 
            this.Button2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Button2.Location = new System.Drawing.Point(1077, 146);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(143, 54);
            this.Button2.TabIndex = 42;
            this.Button2.Text = "View sales Log";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Button3
            // 
            this.Button3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Button3.Location = new System.Drawing.Point(1077, 273);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(143, 66);
            this.Button3.TabIndex = 41;
            this.Button3.Text = "Sell As Cashier";
            this.Button3.UseVisualStyleBackColor = true;
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // txtproductname
            // 
            this.txtproductname.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtproductname.Location = new System.Drawing.Point(155, 195);
            this.txtproductname.Name = "txtproductname";
            this.txtproductname.Size = new System.Drawing.Size(190, 27);
            this.txtproductname.TabIndex = 40;
            // 
            // txtcashiername1
            // 
            this.txtcashiername1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtcashiername1.Location = new System.Drawing.Point(154, 114);
            this.txtcashiername1.Name = "txtcashiername1";
            this.txtcashiername1.Size = new System.Drawing.Size(191, 27);
            this.txtcashiername1.TabIndex = 39;
            // 
            // Label4
            // 
            this.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(42, 116);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(92, 20);
            this.Label4.TabIndex = 38;
            this.Label4.Text = "User Name";
            // 
            // Button1
            // 
            this.Button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button1.Location = new System.Drawing.Point(689, 252);
            this.Button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(137, 73);
            this.Button1.TabIndex = 37;
            this.Button1.Text = "Enter The Product";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // txtunitprice
            // 
            this.txtunitprice.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtunitprice.Location = new System.Drawing.Point(512, 104);
            this.txtunitprice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtunitprice.Name = "txtunitprice";
            this.txtunitprice.Size = new System.Drawing.Size(158, 27);
            this.txtunitprice.TabIndex = 35;
            // 
            // Label3
            // 
            this.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(371, 111);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(128, 20);
            this.Label3.TabIndex = 34;
            this.Label3.Text = "Unit Sales Price";
            // 
            // txtquantity
            // 
            this.txtquantity.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtquantity.Location = new System.Drawing.Point(155, 240);
            this.txtquantity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtquantity.Name = "txtquantity";
            this.txtquantity.Size = new System.Drawing.Size(190, 27);
            this.txtquantity.TabIndex = 33;
            // 
            // Label2
            // 
            this.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(64, 243);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(76, 20);
            this.Label2.TabIndex = 32;
            this.Label2.Text = "Quantity";
            // 
            // Label1
            // 
            this.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(12, 198);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(115, 20);
            this.Label1.TabIndex = 31;
            this.Label1.Text = "Product Name";
            // 
            // Button7
            // 
            this.Button7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Button7.Location = new System.Drawing.Point(1077, 91);
            this.Button7.Name = "Button7";
            this.Button7.Size = new System.Drawing.Size(143, 49);
            this.Button7.TabIndex = 54;
            this.Button7.Text = "ReOrder Level";
            this.Button7.UseVisualStyleBackColor = true;
            this.Button7.Click += new System.EventHandler(this.Button7_Click);
            // 
            // PictureBox1
            // 
            this.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PictureBox1.Image = global::BusinessApp.Properties.Resources.search2;
            this.PictureBox1.Location = new System.Drawing.Point(439, 383);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(67, 31);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox1.TabIndex = 52;
            this.PictureBox1.TabStop = false;
            // 
            // txtamountpaid
            // 
            this.txtamountpaid.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtamountpaid.Location = new System.Drawing.Point(155, 286);
            this.txtamountpaid.Name = "txtamountpaid";
            this.txtamountpaid.Size = new System.Drawing.Size(191, 27);
            this.txtamountpaid.TabIndex = 92;
            // 
            // Label13
            // 
            this.Label13.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Label13.AutoSize = true;
            this.Label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label13.Location = new System.Drawing.Point(49, 289);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(100, 20);
            this.Label13.TabIndex = 91;
            this.Label13.Text = "Amount Paid";
            // 
            // txtsupplierphonenumber
            // 
            this.txtsupplierphonenumber.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtsupplierphonenumber.Location = new System.Drawing.Point(512, 210);
            this.txtsupplierphonenumber.Name = "txtsupplierphonenumber";
            this.txtsupplierphonenumber.Size = new System.Drawing.Size(161, 27);
            this.txtsupplierphonenumber.TabIndex = 90;
            // 
            // Label15
            // 
            this.Label15.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Label15.AutoSize = true;
            this.Label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label15.Location = new System.Drawing.Point(399, 210);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(96, 20);
            this.Label15.TabIndex = 89;
            this.Label15.Text = "Supplier Tel:";
            // 
            // txtinvoicenumber
            // 
            this.txtinvoicenumber.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtinvoicenumber.Location = new System.Drawing.Point(510, 294);
            this.txtinvoicenumber.Name = "txtinvoicenumber";
            this.txtinvoicenumber.Size = new System.Drawing.Size(157, 27);
            this.txtinvoicenumber.TabIndex = 88;
            // 
            // Label14
            // 
            this.Label14.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Label14.AutoSize = true;
            this.Label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label14.Location = new System.Drawing.Point(380, 296);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(119, 20);
            this.Label14.TabIndex = 87;
            this.Label14.Text = "Invoice Number";
            // 
            // txtdatepurchased
            // 
            this.txtdatepurchased.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtdatepurchased.Location = new System.Drawing.Point(512, 250);
            this.txtdatepurchased.Name = "txtdatepurchased";
            this.txtdatepurchased.Size = new System.Drawing.Size(160, 27);
            this.txtdatepurchased.TabIndex = 86;
            // 
            // Label12
            // 
            this.Label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Label12.AutoSize = true;
            this.Label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label12.Location = new System.Drawing.Point(371, 258);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(124, 20);
            this.Label12.TabIndex = 85;
            this.Label12.Text = "Date Purchased";
            // 
            // txtsuppliername
            // 
            this.txtsuppliername.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtsuppliername.Location = new System.Drawing.Point(512, 177);
            this.txtsuppliername.Name = "txtsuppliername";
            this.txtsuppliername.Size = new System.Drawing.Size(161, 27);
            this.txtsuppliername.TabIndex = 84;
            // 
            // Label11
            // 
            this.Label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Label11.AutoSize = true;
            this.Label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label11.Location = new System.Drawing.Point(391, 174);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(113, 20);
            this.Label11.TabIndex = 83;
            this.Label11.Text = "Supplier Name";
            // 
            // txtexpirydate
            // 
            this.txtexpirydate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtexpirydate.Location = new System.Drawing.Point(512, 143);
            this.txtexpirydate.Name = "txtexpirydate";
            this.txtexpirydate.Size = new System.Drawing.Size(161, 27);
            this.txtexpirydate.TabIndex = 82;
            // 
            // Label9
            // 
            this.Label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Label9.AutoSize = true;
            this.Label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label9.Location = new System.Drawing.Point(423, 143);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(81, 20);
            this.Label9.TabIndex = 81;
            this.Label9.Text = "expirydate";
            // 
            // txtunitcostprice
            // 
            this.txtunitcostprice.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtunitcostprice.Location = new System.Drawing.Point(154, 333);
            this.txtunitcostprice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtunitcostprice.Name = "txtunitcostprice";
            this.txtunitcostprice.Size = new System.Drawing.Size(190, 27);
            this.txtunitcostprice.TabIndex = 93;
            this.txtunitcostprice.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtunitcostprice_MouseClick);
            this.txtunitcostprice.TextChanged += new System.EventHandler(this.txtunitcostprice_TextChanged);
            // 
            // Button5
            // 
            this.Button5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button5.Location = new System.Drawing.Point(928, 91);
            this.Button5.Name = "Button5";
            this.Button5.Size = new System.Drawing.Size(143, 53);
            this.Button5.TabIndex = 94;
            this.Button5.Text = "Expiry Date\r\nInfo.";
            this.Button5.UseVisualStyleBackColor = true;
            this.Button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // Button6
            // 
            this.Button6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Button6.Location = new System.Drawing.Point(1077, 201);
            this.Button6.Name = "Button6";
            this.Button6.Size = new System.Drawing.Size(143, 66);
            this.Button6.TabIndex = 95;
            this.Button6.Text = "Sell As Adninistrator";
            this.Button6.UseVisualStyleBackColor = true;
            this.Button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // Label10
            // 
            this.Label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Label10.AutoSize = true;
            this.Label10.Location = new System.Drawing.Point(748, 221);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(179, 20);
            this.Label10.TabIndex = 97;
            this.Label10.Text = "Enter Admin Password";
            // 
            // txtadminpassword
            // 
            this.txtadminpassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtadminpassword.Location = new System.Drawing.Point(933, 221);
            this.txtadminpassword.Name = "txtadminpassword";
            this.txtadminpassword.PasswordChar = '#';
            this.txtadminpassword.Size = new System.Drawing.Size(138, 27);
            this.txtadminpassword.TabIndex = 96;
            // 
            // Button9
            // 
            this.Button9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Button9.Location = new System.Drawing.Point(872, 258);
            this.Button9.Name = "Button9";
            this.Button9.Size = new System.Drawing.Size(127, 67);
            this.Button9.TabIndex = 101;
            this.Button9.Text = "Delet Product";
            this.Button9.UseVisualStyleBackColor = true;
            this.Button9.Click += new System.EventHandler(this.Button9_Click);
            // 
            // lsvitems1
            // 
            this.lsvitems1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.lsvitems1.Location = new System.Drawing.Point(27, 420);
            this.lsvitems1.Name = "lsvitems1";
            this.lsvitems1.ShowItemToolTips = true;
            this.lsvitems1.Size = new System.Drawing.Size(1193, 350);
            this.lsvitems1.TabIndex = 102;
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
            this.ColumnHeader7.Width = 566;
            // 
            // ColumnHeader8
            // 
            this.ColumnHeader8.Text = "Qty";
            this.ColumnHeader8.Width = 67;
            // 
            // ColumnHeader9
            // 
            this.ColumnHeader9.Text = "S/Price";
            this.ColumnHeader9.Width = 93;
            // 
            // ColumnHeader11
            // 
            this.ColumnHeader11.Text = "C/Price";
            this.ColumnHeader11.Width = 104;
            // 
            // ColumnHeader13
            // 
            this.ColumnHeader13.Text = "Exp.";
            this.ColumnHeader13.Width = 159;
            // 
            // ColumnHeader14
            // 
            this.ColumnHeader14.Text = "entrydate";
            this.ColumnHeader14.Width = 135;
            // 
            // txttotal
            // 
            this.txttotal.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txttotal.Location = new System.Drawing.Point(324, 378);
            this.txttotal.Multiline = true;
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(71, 32);
            this.txttotal.TabIndex = 104;
            // 
            // Label16
            // 
            this.Label16.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Label16.AutoSize = true;
            this.Label16.Location = new System.Drawing.Point(21, 383);
            this.Label16.Name = "Label16";
            this.Label16.Size = new System.Drawing.Size(297, 20);
            this.Label16.TabIndex = 103;
            this.Label16.Text = "The Total Number of Products In Stock";
            // 
            // txtproductid
            // 
            this.txtproductid.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtproductid.Location = new System.Drawing.Point(154, 152);
            this.txtproductid.Name = "txtproductid";
            this.txtproductid.Size = new System.Drawing.Size(191, 27);
            this.txtproductid.TabIndex = 107;
            // 
            // Label18
            // 
            this.Label18.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Label18.AutoSize = true;
            this.Label18.Location = new System.Drawing.Point(41, 152);
            this.Label18.Name = "Label18";
            this.Label18.Size = new System.Drawing.Size(90, 20);
            this.Label18.TabIndex = 106;
            this.Label18.Text = "Product ID";
            // 
            // txtcode
            // 
            this.txtcode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtcode.Location = new System.Drawing.Point(155, 78);
            this.txtcode.Name = "txtcode";
            this.txtcode.Size = new System.Drawing.Size(190, 27);
            this.txtcode.TabIndex = 110;
            this.txtcode.TextChanged += new System.EventHandler(this.txtcode_TextChanged);
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(58, 81);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(69, 20);
            this.label17.TabIndex = 111;
            this.label17.Text = "Barcode";
            // 
            // txtaddress
            // 
            this.txtaddress.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtaddress.Location = new System.Drawing.Point(0, 27);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.ReadOnly = true;
            this.txtaddress.Size = new System.Drawing.Size(1284, 27);
            this.txtaddress.TabIndex = 113;
            this.txtaddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtaddress.TextChanged += new System.EventHandler(this.txtaddress_TextChanged);
            // 
            // txtname
            // 
            this.txtname.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtname.Location = new System.Drawing.Point(0, 0);
            this.txtname.Name = "txtname";
            this.txtname.ReadOnly = true;
            this.txtname.Size = new System.Drawing.Size(1284, 27);
            this.txtname.TabIndex = 112;
            this.txtname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cosmetics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(1284, 782);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtcode);
            this.Controls.Add(this.txtproductid);
            this.Controls.Add(this.Label18);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.Label16);
            this.Controls.Add(this.lsvitems1);
            this.Controls.Add(this.Button9);
            this.Controls.Add(this.Label10);
            this.Controls.Add(this.txtadminpassword);
            this.Controls.Add(this.Button6);
            this.Controls.Add(this.Button5);
            this.Controls.Add(this.txtunitcostprice);
            this.Controls.Add(this.txtamountpaid);
            this.Controls.Add(this.Label13);
            this.Controls.Add(this.txtsupplierphonenumber);
            this.Controls.Add(this.Label15);
            this.Controls.Add(this.txtinvoicenumber);
            this.Controls.Add(this.Label14);
            this.Controls.Add(this.txtdatepurchased);
            this.Controls.Add(this.Label12);
            this.Controls.Add(this.txtsuppliername);
            this.Controls.Add(this.Label11);
            this.Controls.Add(this.txtexpirydate);
            this.Controls.Add(this.Label9);
            this.Controls.Add(this.Button7);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.Button4);
            this.Controls.Add(this.txtitems);
            this.Controls.Add(this.txtfile);
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
            this.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "cosmetics";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cosmetics";
            this.Load += new System.EventHandler(this.cards_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cosmetics_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		internal System.Windows.Forms.PictureBox PictureBox1;
		internal System.Windows.Forms.OpenFileDialog OpenFileDialog1;
		internal System.Windows.Forms.Label Label8;
		internal System.Windows.Forms.Timer Timer1;
		internal System.Windows.Forms.TextBox txtsearch;
		internal System.Windows.Forms.Button Button4;
		internal System.Windows.Forms.TextBox txtitems;
		internal System.Windows.Forms.TextBox txtfile;
		internal System.Windows.Forms.Label Label7;
		internal System.Windows.Forms.Button Button2;
		internal System.Windows.Forms.Button Button3;
		internal System.Windows.Forms.TextBox txtproductname;
		internal System.Windows.Forms.TextBox txtcashiername1;
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.Button Button1;
		internal System.Windows.Forms.TextBox txtunitprice;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.TextBox txtquantity;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.Button Button7;
		internal System.Windows.Forms.TextBox txtamountpaid;
		internal System.Windows.Forms.Label Label13;
		internal System.Windows.Forms.TextBox txtsupplierphonenumber;
		internal System.Windows.Forms.Label Label15;
		internal System.Windows.Forms.TextBox txtinvoicenumber;
		internal System.Windows.Forms.Label Label14;
		internal System.Windows.Forms.TextBox txtdatepurchased;
		internal System.Windows.Forms.Label Label12;
		internal System.Windows.Forms.TextBox txtsuppliername;
		internal System.Windows.Forms.Label Label11;
		internal System.Windows.Forms.TextBox txtexpirydate;
		internal System.Windows.Forms.Label Label9;
		internal System.Windows.Forms.TextBox txtunitcostprice;
		internal System.Windows.Forms.Button Button5;
		internal System.Windows.Forms.Button Button6;
		internal System.Windows.Forms.Label Label10;
		internal System.Windows.Forms.TextBox txtadminpassword;
		internal System.Windows.Forms.Button Button9;
		internal System.Windows.Forms.ListView lsvitems1;
		internal System.Windows.Forms.ColumnHeader ColumnHeader1;
		internal System.Windows.Forms.ColumnHeader ColumnHeader7;
		internal System.Windows.Forms.ColumnHeader ColumnHeader8;
		internal System.Windows.Forms.ColumnHeader ColumnHeader9;
		internal System.Windows.Forms.ColumnHeader ColumnHeader11;
		internal System.Windows.Forms.ColumnHeader ColumnHeader13;
		internal System.Windows.Forms.ColumnHeader ColumnHeader14;
		internal System.Windows.Forms.TextBox txttotal;
		internal System.Windows.Forms.Label Label16;
		internal System.Windows.Forms.TextBox txtproductid;
		internal System.Windows.Forms.Label Label18;
        private System.Windows.Forms.TextBox txtcode;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.TextBox txtname;
    }

}