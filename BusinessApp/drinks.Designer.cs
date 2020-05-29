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
	public partial class drinks : System.Windows.Forms.Form
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
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.Label8 = new System.Windows.Forms.Label();
			this.txtsearch = new System.Windows.Forms.TextBox();
			this.Button4 = new System.Windows.Forms.Button();
			this.txtitems = new System.Windows.Forms.TextBox();
			this.txtfile = new System.Windows.Forms.TextBox();
			this.txtunitcostprice = new System.Windows.Forms.TextBox();
			this.Label7 = new System.Windows.Forms.Label();
			this.Label5 = new System.Windows.Forms.Label();
			this.Label6 = new System.Windows.Forms.Label();
			this.Button2 = new System.Windows.Forms.Button();
			this.Button3 = new System.Windows.Forms.Button();
			this.txtproductname = new System.Windows.Forms.TextBox();
			this.txtcashiername1 = new System.Windows.Forms.TextBox();
			this.Label4 = new System.Windows.Forms.Label();
			this.Button1 = new System.Windows.Forms.Button();
			this.dgvdrinks = new System.Windows.Forms.DataGridView();
			this.txtunitprice = new System.Windows.Forms.TextBox();
			this.Label3 = new System.Windows.Forms.Label();
			this.txtquantity = new System.Windows.Forms.TextBox();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.Timer1 = new System.Windows.Forms.Timer(this.components);
			this.OpenFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.PageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
			this.Button7 = new System.Windows.Forms.Button();
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
			this.txtamountpaid = new System.Windows.Forms.TextBox();
			this.Label13 = new System.Windows.Forms.Label();
			this.PictureBox1 = new System.Windows.Forms.PictureBox();
			this.Button5 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)this.dgvdrinks).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.PictureBox1).BeginInit();
			this.SuspendLayout();
			//
			//Label8
			//
			this.Label8.AutoSize = true;
			this.Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label8.Location = new System.Drawing.Point(1008, 196);
			this.Label8.Name = "Label8";
			this.Label8.Size = new System.Drawing.Size(60, 20);
			this.Label8.TabIndex = 63;
			this.Label8.Text = "Search";
			//
			//txtsearch
			//
			this.txtsearch.Location = new System.Drawing.Point(879, 188);
			this.txtsearch.Multiline = true;
			this.txtsearch.Name = "txtsearch";
			this.txtsearch.Size = new System.Drawing.Size(123, 31);
			this.txtsearch.TabIndex = 62;
			//
			//Button4
			//
			this.Button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Button4.Location = new System.Drawing.Point(821, 141);
			this.Button4.Name = "Button4";
			this.Button4.Size = new System.Drawing.Size(128, 41);
			this.Button4.TabIndex = 59;
			this.Button4.Text = "Import";
			this.Button4.UseVisualStyleBackColor = true;
			//
			//txtitems
			//
			this.txtitems.Location = new System.Drawing.Point(955, 141);
			this.txtitems.Multiline = true;
			this.txtitems.Name = "txtitems";
			this.txtitems.Size = new System.Drawing.Size(62, 41);
			this.txtitems.TabIndex = 61;
			//
			//txtfile
			//
			this.txtfile.Location = new System.Drawing.Point(821, 105);
			this.txtfile.Name = "txtfile";
			this.txtfile.Size = new System.Drawing.Size(196, 20);
			this.txtfile.TabIndex = 60;
			//
			//txtunitcostprice
			//
			this.txtunitcostprice.Location = new System.Drawing.Point(160, 279);
			this.txtunitcostprice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtunitcostprice.Name = "txtunitcostprice";
			this.txtunitcostprice.Size = new System.Drawing.Size(190, 20);
			this.txtunitcostprice.TabIndex = 58;
			//
			//Label7
			//
			this.Label7.AutoSize = true;
			this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label7.Location = new System.Drawing.Point(37, 277);
			this.Label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label7.Name = "Label7";
			this.Label7.Size = new System.Drawing.Size(114, 20);
			this.Label7.TabIndex = 57;
			this.Label7.Text = "Unit Cost Price";
			//
			//Label5
			//
			this.Label5.AutoSize = true;
			this.Label5.BackColor = System.Drawing.Color.White;
			this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.Label5.Location = new System.Drawing.Point(449, 45);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(381, 24);
			this.Label5.TabIndex = 56;
			this.Label5.Text = "No. 218, 2nd, East Circular Road, Benin City.";
			//
			//Label6
			//
			this.Label6.AutoSize = true;
			this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label6.ForeColor = System.Drawing.Color.Aqua;
			this.Label6.Location = new System.Drawing.Point(290, 9);
			this.Label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label6.Name = "Label6";
			this.Label6.Size = new System.Drawing.Size(712, 29);
			this.Label6.TabIndex = 55;
			this.Label6.Text = "WELCOME TO JULIA AND SYL PHARMACY  AND STORES ";
			//
			//Button2
			//
			this.Button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Button2.Location = new System.Drawing.Point(1090, 200);
			this.Button2.Name = "Button2";
			this.Button2.Size = new System.Drawing.Size(156, 57);
			this.Button2.TabIndex = 54;
			this.Button2.Text = "View sales Log";
			this.Button2.UseVisualStyleBackColor = true;
			//
			//Button3
			//
			this.Button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Button3.Location = new System.Drawing.Point(1090, 257);
			this.Button3.Name = "Button3";
			this.Button3.Size = new System.Drawing.Size(156, 58);
			this.Button3.TabIndex = 53;
			this.Button3.Text = "Make Sales";
			this.Button3.UseVisualStyleBackColor = true;
			//
			//txtproductname
			//
			this.txtproductname.Location = new System.Drawing.Point(159, 155);
			this.txtproductname.Name = "txtproductname";
			this.txtproductname.Size = new System.Drawing.Size(190, 20);
			this.txtproductname.TabIndex = 52;
			//
			//txtcashiername1
			//
			this.txtcashiername1.Location = new System.Drawing.Point(159, 108);
			this.txtcashiername1.Name = "txtcashiername1";
			this.txtcashiername1.Size = new System.Drawing.Size(191, 20);
			this.txtcashiername1.TabIndex = 51;
			//
			//Label4
			//
			this.Label4.AutoSize = true;
			this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label4.Location = new System.Drawing.Point(62, 108);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(89, 20);
			this.Label4.TabIndex = 50;
			this.Label4.Text = "User Name";
			//
			//Button1
			//
			this.Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Button1.Location = new System.Drawing.Point(815, 257);
			this.Button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Button1.Name = "Button1";
			this.Button1.Size = new System.Drawing.Size(202, 58);
			this.Button1.TabIndex = 49;
			this.Button1.Text = "Enter The Product";
			this.Button1.UseVisualStyleBackColor = true;
			//
			//dgvdrinks
			//
			DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(255)), Convert.ToInt32(Convert.ToByte(192)), Convert.ToInt32(Convert.ToByte(128)));
			DataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
			DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Lime;
			DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
			DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvdrinks.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1;
			this.dgvdrinks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvdrinks.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
			this.dgvdrinks.BackgroundColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(255)), Convert.ToInt32(Convert.ToByte(192)), Convert.ToInt32(Convert.ToByte(192)));
			this.dgvdrinks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvdrinks.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.dgvdrinks.Location = new System.Drawing.Point(13, 325);
			this.dgvdrinks.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.dgvdrinks.Name = "dgvdrinks";
			this.dgvdrinks.RightToLeft = System.Windows.Forms.RightToLeft.No;
			DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			DataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
			DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Silver;
			this.dgvdrinks.RowsDefaultCellStyle = DataGridViewCellStyle2;
			this.dgvdrinks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.dgvdrinks.Size = new System.Drawing.Size(1219, 396);
			this.dgvdrinks.TabIndex = 48;
			//
			//txtunitprice
			//
			this.txtunitprice.Location = new System.Drawing.Point(601, 110);
			this.txtunitprice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtunitprice.Name = "txtunitprice";
			this.txtunitprice.Size = new System.Drawing.Size(162, 20);
			this.txtunitprice.TabIndex = 47;
			//
			//Label3
			//
			this.Label3.AutoSize = true;
			this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label3.Location = new System.Drawing.Point(472, 108);
			this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(121, 20);
			this.Label3.TabIndex = 46;
			this.Label3.Text = "Unit Sales Price";
			//
			//txtquantity
			//
			this.txtquantity.Location = new System.Drawing.Point(160, 195);
			this.txtquantity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtquantity.Name = "txtquantity";
			this.txtquantity.Size = new System.Drawing.Size(190, 20);
			this.txtquantity.TabIndex = 45;
			//
			//Label2
			//
			this.Label2.AutoSize = true;
			this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label2.Location = new System.Drawing.Point(84, 199);
			this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(68, 20);
			this.Label2.TabIndex = 44;
			this.Label2.Text = "Quantity";
			//
			//Label1
			//
			this.Label1.AutoSize = true;
			this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label1.Location = new System.Drawing.Point(41, 153);
			this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(110, 20);
			this.Label1.TabIndex = 43;
			this.Label1.Text = "Product Name";
			//
			//OpenFileDialog1
			//
			this.OpenFileDialog1.FileName = "OpenFileDialog1";
			//
			//Button7
			//
			this.Button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Button7.Location = new System.Drawing.Point(1090, 141);
			this.Button7.Name = "Button7";
			this.Button7.Size = new System.Drawing.Size(156, 49);
			this.Button7.TabIndex = 66;
			this.Button7.Text = "ReOrder Level";
			this.Button7.UseVisualStyleBackColor = true;
			//
			//txtsupplierphonenumber
			//
			this.txtsupplierphonenumber.Location = new System.Drawing.Point(601, 213);
			this.txtsupplierphonenumber.Name = "txtsupplierphonenumber";
			this.txtsupplierphonenumber.Size = new System.Drawing.Size(161, 20);
			this.txtsupplierphonenumber.TabIndex = 76;
			//
			//Label15
			//
			this.Label15.AutoSize = true;
			this.Label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label15.Location = new System.Drawing.Point(488, 213);
			this.Label15.Name = "Label15";
			this.Label15.Size = new System.Drawing.Size(96, 20);
			this.Label15.TabIndex = 75;
			this.Label15.Text = "Supplier Tel:";
			//
			//txtinvoicenumber
			//
			this.txtinvoicenumber.Location = new System.Drawing.Point(602, 277);
			this.txtinvoicenumber.Name = "txtinvoicenumber";
			this.txtinvoicenumber.Size = new System.Drawing.Size(157, 20);
			this.txtinvoicenumber.TabIndex = 74;
			//
			//Label14
			//
			this.Label14.AutoSize = true;
			this.Label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label14.Location = new System.Drawing.Point(472, 279);
			this.Label14.Name = "Label14";
			this.Label14.Size = new System.Drawing.Size(119, 20);
			this.Label14.TabIndex = 73;
			this.Label14.Text = "Invoice Number";
			//
			//txtdatepurchased
			//
			this.txtdatepurchased.Location = new System.Drawing.Point(601, 245);
			this.txtdatepurchased.Name = "txtdatepurchased";
			this.txtdatepurchased.Size = new System.Drawing.Size(160, 20);
			this.txtdatepurchased.TabIndex = 72;
			//
			//Label12
			//
			this.Label12.AutoSize = true;
			this.Label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label12.Location = new System.Drawing.Point(460, 253);
			this.Label12.Name = "Label12";
			this.Label12.Size = new System.Drawing.Size(124, 20);
			this.Label12.TabIndex = 71;
			this.Label12.Text = "Date Purchased";
			//
			//txtsuppliername
			//
			this.txtsuppliername.Location = new System.Drawing.Point(602, 176);
			this.txtsuppliername.Name = "txtsuppliername";
			this.txtsuppliername.Size = new System.Drawing.Size(161, 20);
			this.txtsuppliername.TabIndex = 70;
			//
			//Label11
			//
			this.Label11.AutoSize = true;
			this.Label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label11.Location = new System.Drawing.Point(480, 177);
			this.Label11.Name = "Label11";
			this.Label11.Size = new System.Drawing.Size(113, 20);
			this.Label11.TabIndex = 69;
			this.Label11.Text = "Supplier Name";
			//
			//txtexpirydate
			//
			this.txtexpirydate.Location = new System.Drawing.Point(601, 146);
			this.txtexpirydate.Name = "txtexpirydate";
			this.txtexpirydate.Size = new System.Drawing.Size(161, 20);
			this.txtexpirydate.TabIndex = 68;
			//
			//Label9
			//
			this.Label9.AutoSize = true;
			this.Label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label9.Location = new System.Drawing.Point(512, 146);
			this.Label9.Name = "Label9";
			this.Label9.Size = new System.Drawing.Size(81, 20);
			this.Label9.TabIndex = 67;
			this.Label9.Text = "expirydate";
			//
			//txtamountpaid
			//
			this.txtamountpaid.Location = new System.Drawing.Point(160, 245);
			this.txtamountpaid.Name = "txtamountpaid";
			this.txtamountpaid.Size = new System.Drawing.Size(191, 20);
			this.txtamountpaid.TabIndex = 78;
			//
			//Label13
			//
			this.Label13.AutoSize = true;
			this.Label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label13.Location = new System.Drawing.Point(54, 245);
			this.Label13.Name = "Label13";
			this.Label13.Size = new System.Drawing.Size(100, 20);
			this.Label13.TabIndex = 77;
			this.Label13.Text = "Amount Paid";
			//
			//PictureBox1
			//
			this.PictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.PictureBox1.Image = BusinessApp.Properties.Resources.search2;
			this.PictureBox1.Location = new System.Drawing.Point(821, 188);
			this.PictureBox1.Name = "PictureBox1";
			this.PictureBox1.Size = new System.Drawing.Size(52, 31);
			this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.PictureBox1.TabIndex = 64;
			this.PictureBox1.TabStop = false;
			//
			//Button5
			//
			this.Button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Button5.Location = new System.Drawing.Point(1090, 82);
			this.Button5.Name = "Button5";
			this.Button5.Size = new System.Drawing.Size(156, 53);
			this.Button5.TabIndex = 79;
			this.Button5.Text = "Expiry Date" + "\r" + "\n" + "Info.";
			this.Button5.UseVisualStyleBackColor = true;
			//
			//drinks
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6.0F, 13.0F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(255)), Convert.ToInt32(Convert.ToByte(128)), Convert.ToInt32(Convert.ToByte(0)));
			this.ClientSize = new System.Drawing.Size(1284, 782);
			this.Controls.Add(this.Button5);
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
			this.Controls.Add(this.txtunitcostprice);
			this.Controls.Add(this.Label7);
			this.Controls.Add(this.Label5);
			this.Controls.Add(this.Label6);
			this.Controls.Add(this.Button2);
			this.Controls.Add(this.Button3);
			this.Controls.Add(this.txtproductname);
			this.Controls.Add(this.txtcashiername1);
			this.Controls.Add(this.Label4);
			this.Controls.Add(this.Button1);
			this.Controls.Add(this.dgvdrinks);
			this.Controls.Add(this.txtunitprice);
			this.Controls.Add(this.Label3);
			this.Controls.Add(this.txtquantity);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.Label1);
			this.Name = "drinks";
			this.Text = "drinks";
			((System.ComponentModel.ISupportInitialize)this.dgvdrinks).EndInit();
			((System.ComponentModel.ISupportInitialize)this.PictureBox1).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

//INSTANT C# NOTE: Converted design-time event handler wireups:
			base.Load += new System.EventHandler(drinks_Load);
			Button1.Click += new System.EventHandler(Button1_Click);
			Button4.Click += new System.EventHandler(Button4_Click);
			txtsearch.TextChanged += new System.EventHandler(txtsearch_TextChanged);
			txtfile.TextChanged += new System.EventHandler(txtfile_TextChanged);
			Button3.Click += new System.EventHandler(Button3_Click);
			Button2.Click += new System.EventHandler(Button2_Click);
			OpenFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(OpenFileDialog1_FileOk);
			Button7.Click += new System.EventHandler(Button7_Click);
			txtunitcostprice.Click += new System.EventHandler(txtunitcostprice_Click);
			txtunitcostprice.TextChanged += new System.EventHandler(txtunitcostprice_TextChanged);
			Button5.Click += new System.EventHandler(Button5_Click_1);
		}
		internal System.Windows.Forms.PictureBox PictureBox1;
		internal System.Windows.Forms.Label Label8;
		internal System.Windows.Forms.TextBox txtsearch;
		internal System.Windows.Forms.Button Button4;
		internal System.Windows.Forms.TextBox txtitems;
		internal System.Windows.Forms.TextBox txtfile;
		internal System.Windows.Forms.TextBox txtunitcostprice;
		internal System.Windows.Forms.Label Label7;
		internal System.Windows.Forms.Label Label5;
		internal System.Windows.Forms.Label Label6;
		internal System.Windows.Forms.Button Button2;
		internal System.Windows.Forms.Button Button3;
		internal System.Windows.Forms.TextBox txtproductname;
		internal System.Windows.Forms.TextBox txtcashiername1;
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.Button Button1;
		internal System.Windows.Forms.DataGridView dgvdrinks;
		internal System.Windows.Forms.TextBox txtunitprice;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.TextBox txtquantity;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.Timer Timer1;
		internal System.Windows.Forms.OpenFileDialog OpenFileDialog1;
		internal System.Windows.Forms.PageSetupDialog PageSetupDialog1;
		internal System.Windows.Forms.Button Button7;
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
		internal System.Windows.Forms.TextBox txtamountpaid;
		internal System.Windows.Forms.Label Label13;
		internal System.Windows.Forms.Button Button5;
	}

}