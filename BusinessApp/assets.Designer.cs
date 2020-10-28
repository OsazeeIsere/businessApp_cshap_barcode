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
	public partial class assets : System.Windows.Forms.Form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.txtquanity = new System.Windows.Forms.TextBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.txtproductamount = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.dgvdrugs = new System.Windows.Forms.DataGridView();
            this.txtquantitycount = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.dgvdrinks = new System.Windows.Forms.DataGridView();
            this.dgvcards = new System.Windows.Forms.DataGridView();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.txtquantitycount1 = new System.Windows.Forms.TextBox();
            this.Label9 = new System.Windows.Forms.Label();
            this.txtquanity1 = new System.Windows.Forms.TextBox();
            this.Label10 = new System.Windows.Forms.Label();
            this.txtproductamount1 = new System.Windows.Forms.TextBox();
            this.Label11 = new System.Windows.Forms.Label();
            this.txtquantitycount2 = new System.Windows.Forms.TextBox();
            this.Label12 = new System.Windows.Forms.Label();
            this.txtquanity2 = new System.Windows.Forms.TextBox();
            this.Label13 = new System.Windows.Forms.Label();
            this.txtproductamount2 = new System.Windows.Forms.TextBox();
            this.Label14 = new System.Windows.Forms.Label();
            this.Label15 = new System.Windows.Forms.Label();
            this.txtgrandtotal = new System.Windows.Forms.TextBox();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.pncosmetics = new System.Windows.Forms.Panel();
            this.pndrinks = new System.Windows.Forms.Panel();
            this.pngridview = new System.Windows.Forms.Panel();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdrugs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdrinks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcards)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.pncosmetics.SuspendLayout();
            this.pndrinks.SuspendLayout();
            this.pngridview.SuspendLayout();
            this.SuspendLayout();
            // 
            // DateTimePicker2
            // 
            this.DateTimePicker2.Location = new System.Drawing.Point(946, 58);
            this.DateTimePicker2.Name = "DateTimePicker2";
            this.DateTimePicker2.Size = new System.Drawing.Size(286, 26);
            this.DateTimePicker2.TabIndex = 66;
            // 
            // txtquanity
            // 
            this.txtquanity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtquanity.Location = new System.Drawing.Point(232, 575);
            this.txtquanity.Name = "txtquanity";
            this.txtquanity.Size = new System.Drawing.Size(157, 26);
            this.txtquanity.TabIndex = 65;
            // 
            // Label7
            // 
            this.Label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(12, 575);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(198, 40);
            this.Label7.TabIndex = 64;
            this.Label7.Text = "Total Quantity Of Drugs\r\nIn Stock";
            this.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtproductamount
            // 
            this.txtproductamount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtproductamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtproductamount.Location = new System.Drawing.Point(232, 505);
            this.txtproductamount.Name = "txtproductamount";
            this.txtproductamount.Size = new System.Drawing.Size(160, 31);
            this.txtproductamount.TabIndex = 59;
            // 
            // Label1
            // 
            this.Label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(8, 499);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(201, 48);
            this.Label1.TabIndex = 57;
            this.Label1.Text = "Total Amount Of Drugs\r\nIn Stock";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgvdrugs
            // 
            this.dgvdrugs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvdrugs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvdrugs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvdrugs.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvdrugs.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvdrugs.Location = new System.Drawing.Point(16, 136);
            this.dgvdrugs.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvdrugs.Name = "dgvdrugs";
            this.dgvdrugs.Size = new System.Drawing.Size(1166, 334);
            this.dgvdrugs.TabIndex = 54;
            // 
            // txtquantitycount
            // 
            this.txtquantitycount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtquantitycount.Location = new System.Drawing.Point(230, 627);
            this.txtquantitycount.Name = "txtquantitycount";
            this.txtquantitycount.Size = new System.Drawing.Size(157, 26);
            this.txtquantitycount.TabIndex = 69;
            // 
            // Label2
            // 
            this.Label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(8, 627);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(193, 40);
            this.Label2.TabIndex = 68;
            this.Label2.Text = "Total Number Of Drugs\r\nIn Stock";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgvdrinks
            // 
            this.dgvdrinks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvdrinks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvdrinks.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvdrinks.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvdrinks.Location = new System.Drawing.Point(424, 44);
            this.dgvdrinks.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvdrinks.Name = "dgvdrinks";
            this.dgvdrinks.Size = new System.Drawing.Size(406, 334);
            this.dgvdrinks.TabIndex = 70;
            // 
            // dgvcards
            // 
            this.dgvcards.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvcards.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvcards.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvcards.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvcards.Location = new System.Drawing.Point(0, 44);
            this.dgvcards.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvcards.Name = "dgvcards";
            this.dgvcards.Size = new System.Drawing.Size(415, 334);
            this.dgvcards.TabIndex = 71;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.BackColor = System.Drawing.Color.White;
            this.Label3.Location = new System.Drawing.Point(117, 110);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(200, 20);
            this.Label3.TabIndex = 72;
            this.Label3.Text = "Products\' Current Asset";
            this.Label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.BackColor = System.Drawing.Color.White;
            this.Label4.Location = new System.Drawing.Point(547, 18);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(214, 20);
            this.Label4.TabIndex = 73;
            this.Label4.Text = "Category C Current Asset";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.BackColor = System.Drawing.Color.White;
            this.Label8.Location = new System.Drawing.Point(99, 18);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(219, 20);
            this.Label8.TabIndex = 74;
            this.Label8.Text = "Category B Current Asset ";
            // 
            // txtquantitycount1
            // 
            this.txtquantitycount1.Location = new System.Drawing.Point(233, 127);
            this.txtquantitycount1.Name = "txtquantitycount1";
            this.txtquantitycount1.Size = new System.Drawing.Size(157, 26);
            this.txtquantitycount1.TabIndex = 80;
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Location = new System.Drawing.Point(11, 127);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(196, 40);
            this.Label9.TabIndex = 79;
            this.Label9.Text = "Total Number Of Drinks\r\nIn Stock";
            this.Label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtquanity1
            // 
            this.txtquanity1.Location = new System.Drawing.Point(233, 75);
            this.txtquanity1.Name = "txtquanity1";
            this.txtquanity1.Size = new System.Drawing.Size(157, 26);
            this.txtquanity1.TabIndex = 78;
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Location = new System.Drawing.Point(13, 75);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(201, 40);
            this.Label10.TabIndex = 77;
            this.Label10.Text = "Total Quantity Of Drinks\r\nIn Stock";
            this.Label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtproductamount1
            // 
            this.txtproductamount1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtproductamount1.Location = new System.Drawing.Point(235, 22);
            this.txtproductamount1.Name = "txtproductamount1";
            this.txtproductamount1.Size = new System.Drawing.Size(160, 31);
            this.txtproductamount1.TabIndex = 76;
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label11.Location = new System.Drawing.Point(11, 16);
            this.Label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(203, 48);
            this.Label11.TabIndex = 75;
            this.Label11.Text = "Total Amount Of Drinks\r\nIn Stock";
            this.Label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtquantitycount2
            // 
            this.txtquantitycount2.Location = new System.Drawing.Point(255, 133);
            this.txtquantitycount2.Name = "txtquantitycount2";
            this.txtquantitycount2.Size = new System.Drawing.Size(157, 26);
            this.txtquantitycount2.TabIndex = 86;
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.Location = new System.Drawing.Point(23, 133);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(228, 40);
            this.Label12.TabIndex = 85;
            this.Label12.Text = "Total Number Of Cosmetics\r\n In Stock";
            this.Label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtquanity2
            // 
            this.txtquanity2.Location = new System.Drawing.Point(252, 78);
            this.txtquanity2.Name = "txtquanity2";
            this.txtquanity2.Size = new System.Drawing.Size(157, 26);
            this.txtquanity2.TabIndex = 84;
            // 
            // Label13
            // 
            this.Label13.AutoSize = true;
            this.Label13.Location = new System.Drawing.Point(13, 78);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(233, 40);
            this.Label13.TabIndex = 83;
            this.Label13.Text = "Total Quantity Of Cosmetics\r\nIn Stock";
            this.Label13.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Label13.Click += new System.EventHandler(this.Label13_Click);
            // 
            // txtproductamount2
            // 
            this.txtproductamount2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtproductamount2.Location = new System.Drawing.Point(255, 6);
            this.txtproductamount2.Name = "txtproductamount2";
            this.txtproductamount2.Size = new System.Drawing.Size(160, 31);
            this.txtproductamount2.TabIndex = 82;
            // 
            // Label14
            // 
            this.Label14.AutoSize = true;
            this.Label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label14.Location = new System.Drawing.Point(13, 5);
            this.Label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(238, 48);
            this.Label14.TabIndex = 81;
            this.Label14.Text = "Total Amount Of Cosmetics\r\n In Stock";
            this.Label14.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Label15
            // 
            this.Label15.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Label15.AutoSize = true;
            this.Label15.BackColor = System.Drawing.Color.White;
            this.Label15.Location = new System.Drawing.Point(305, 694);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(253, 20);
            this.Label15.TabIndex = 87;
            this.Label15.Text = "Grand Total Of Current Assets";
            // 
            // txtgrandtotal
            // 
            this.txtgrandtotal.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtgrandtotal.Location = new System.Drawing.Point(661, 688);
            this.txtgrandtotal.Name = "txtgrandtotal";
            this.txtgrandtotal.Size = new System.Drawing.Size(206, 26);
            this.txtgrandtotal.TabIndex = 88;
            // 
            // PictureBox1
            // 
            this.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.PictureBox1.BackColor = System.Drawing.Color.White;
            this.PictureBox1.Image = global::BusinessApp.Properties.Resources.NAIRA;
            this.PictureBox1.Location = new System.Drawing.Point(621, 693);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(34, 21);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox1.TabIndex = 90;
            this.PictureBox1.TabStop = false;
            // 
            // pncosmetics
            // 
            this.pncosmetics.Controls.Add(this.txtquantitycount2);
            this.pncosmetics.Controls.Add(this.Label12);
            this.pncosmetics.Controls.Add(this.txtquanity2);
            this.pncosmetics.Controls.Add(this.Label13);
            this.pncosmetics.Controls.Add(this.Label14);
            this.pncosmetics.Controls.Add(this.txtproductamount2);
            this.pncosmetics.Location = new System.Drawing.Point(433, 486);
            this.pncosmetics.Name = "pncosmetics";
            this.pncosmetics.Size = new System.Drawing.Size(428, 189);
            this.pncosmetics.TabIndex = 93;
            // 
            // pndrinks
            // 
            this.pndrinks.Controls.Add(this.txtquantitycount1);
            this.pndrinks.Controls.Add(this.Label9);
            this.pndrinks.Controls.Add(this.txtquanity1);
            this.pndrinks.Controls.Add(this.Label10);
            this.pndrinks.Controls.Add(this.txtproductamount1);
            this.pndrinks.Controls.Add(this.Label11);
            this.pndrinks.Location = new System.Drawing.Point(867, 486);
            this.pndrinks.Name = "pndrinks";
            this.pndrinks.Size = new System.Drawing.Size(403, 196);
            this.pndrinks.TabIndex = 94;
            // 
            // pngridview
            // 
            this.pngridview.Controls.Add(this.Label8);
            this.pngridview.Controls.Add(this.Label4);
            this.pngridview.Controls.Add(this.dgvcards);
            this.pngridview.Controls.Add(this.dgvdrinks);
            this.pngridview.Location = new System.Drawing.Point(441, 92);
            this.pngridview.Name = "pngridview";
            this.pngridview.Size = new System.Drawing.Size(840, 394);
            this.pngridview.TabIndex = 95;
            // 
            // txtaddress
            // 
            this.txtaddress.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtaddress.Location = new System.Drawing.Point(0, 26);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.ReadOnly = true;
            this.txtaddress.Size = new System.Drawing.Size(1284, 26);
            this.txtaddress.TabIndex = 108;
            this.txtaddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtname
            // 
            this.txtname.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtname.Location = new System.Drawing.Point(0, 0);
            this.txtname.Name = "txtname";
            this.txtname.ReadOnly = true;
            this.txtname.Size = new System.Drawing.Size(1284, 26);
            this.txtname.TabIndex = 107;
            this.txtname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // assets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1284, 782);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.pngridview);
            this.Controls.Add(this.pndrinks);
            this.Controls.Add(this.pncosmetics);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.txtgrandtotal);
            this.Controls.Add(this.Label15);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.txtquantitycount);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.DateTimePicker2);
            this.Controls.Add(this.txtquanity);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.txtproductamount);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.dgvdrugs);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "assets";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "assets";
            this.Load += new System.EventHandler(this.assets_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdrugs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdrinks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcards)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.pncosmetics.ResumeLayout(false);
            this.pncosmetics.PerformLayout();
            this.pndrinks.ResumeLayout(false);
            this.pndrinks.PerformLayout();
            this.pngridview.ResumeLayout(false);
            this.pngridview.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		internal System.Windows.Forms.DateTimePicker DateTimePicker2;
		internal System.Windows.Forms.TextBox txtquanity;
		internal System.Windows.Forms.Label Label7;
		internal System.Windows.Forms.TextBox txtproductamount;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.DataGridView dgvdrugs;
		internal System.Windows.Forms.TextBox txtquantitycount;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.DataGridView dgvdrinks;
		internal System.Windows.Forms.DataGridView dgvcards;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.Label Label8;
		internal System.Windows.Forms.TextBox txtquantitycount1;
		internal System.Windows.Forms.Label Label9;
		internal System.Windows.Forms.TextBox txtquanity1;
		internal System.Windows.Forms.Label Label10;
		internal System.Windows.Forms.TextBox txtproductamount1;
		internal System.Windows.Forms.Label Label11;
		internal System.Windows.Forms.TextBox txtquantitycount2;
		internal System.Windows.Forms.Label Label12;
		internal System.Windows.Forms.TextBox txtquanity2;
		internal System.Windows.Forms.Label Label13;
		internal System.Windows.Forms.TextBox txtproductamount2;
		internal System.Windows.Forms.Label Label14;
		internal System.Windows.Forms.Label Label15;
		internal System.Windows.Forms.TextBox txtgrandtotal;
		internal System.Windows.Forms.PictureBox PictureBox1;
        private Panel pncosmetics;
        private Panel pndrinks;
        private Panel pngridview;
        private TextBox txtaddress;
        private TextBox txtname;
    }

}