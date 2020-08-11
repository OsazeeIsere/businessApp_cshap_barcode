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
	public partial class cosmeticsreorderlevel : System.Windows.Forms.Form
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
            this.lsvitems = new System.Windows.Forms.ListView();
            this.ColumnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Button1 = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.ComboBox1 = new System.Windows.Forms.ComboBox();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.lbaddress = new System.Windows.Forms.Label();
            this.lbname = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lsvitems
            // 
            this.lsvitems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader2,
            this.ColumnHeader3,
            this.ColumnHeader4,
            this.ColumnHeader5});
            this.lsvitems.FullRowSelect = true;
            this.lsvitems.GridLines = true;
            this.lsvitems.Location = new System.Drawing.Point(89, 205);
            this.lsvitems.Name = "lsvitems";
            this.lsvitems.Size = new System.Drawing.Size(739, 384);
            this.lsvitems.TabIndex = 85;
            this.lsvitems.UseCompatibleStateImageBehavior = false;
            this.lsvitems.View = System.Windows.Forms.View.Details;
            // 
            // ColumnHeader2
            // 
            this.ColumnHeader2.Text = "productname ";
            this.ColumnHeader2.Width = 134;
            // 
            // ColumnHeader3
            // 
            this.ColumnHeader3.Text = "quantity";
            this.ColumnHeader3.Width = 130;
            // 
            // ColumnHeader4
            // 
            this.ColumnHeader4.Text = "unitcostprice";
            this.ColumnHeader4.Width = 142;
            // 
            // ColumnHeader5
            // 
            this.ColumnHeader5.Text = "unitsalesprice";
            this.ColumnHeader5.Width = 113;
            // 
            // DateTimePicker1
            // 
            this.DateTimePicker1.Location = new System.Drawing.Point(622, 115);
            this.DateTimePicker1.Name = "DateTimePicker1";
            this.DateTimePicker1.Size = new System.Drawing.Size(261, 26);
            this.DateTimePicker1.TabIndex = 84;
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(496, 109);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(117, 38);
            this.Button1.TabIndex = 83;
            this.Button1.Text = "Checked";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(8, 123);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(188, 20);
            this.Label1.TabIndex = 82;
            this.Label1.Text = "Select The Reorder Level";
            // 
            // ComboBox1
            // 
            this.ComboBox1.FormattingEnabled = true;
            this.ComboBox1.Items.AddRange(new object[] {
            "Products Less Than 5 units in Stock",
            "Products Less Than 10 units in Stock",
            "Products Less Than 20 units in Stock",
            "Products Less Than 50 units in Stock",
            "Products Above  50 units in Stock"});
            this.ComboBox1.Location = new System.Drawing.Point(202, 119);
            this.ComboBox1.Name = "ComboBox1";
            this.ComboBox1.Size = new System.Drawing.Size(288, 28);
            this.ComboBox1.TabIndex = 81;
            // 
            // txttotal
            // 
            this.txttotal.Location = new System.Drawing.Point(529, 157);
            this.txttotal.Multiline = true;
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(82, 32);
            this.txttotal.TabIndex = 87;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(238, 169);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(285, 20);
            this.Label2.TabIndex = 86;
            this.Label2.Text = "The Total Number of Products Affected";
            // 
            // lbaddress
            // 
            this.lbaddress.AutoSize = true;
            this.lbaddress.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbaddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbaddress.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbaddress.Location = new System.Drawing.Point(301, 61);
            this.lbaddress.Name = "lbaddress";
            this.lbaddress.Size = new System.Drawing.Size(27, 18);
            this.lbaddress.TabIndex = 89;
            this.lbaddress.Text = "lb2";
            // 
            // lbname
            // 
            this.lbname.AutoSize = true;
            this.lbname.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbname.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbname.Location = new System.Drawing.Point(263, 19);
            this.lbname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbname.Name = "lbname";
            this.lbname.Size = new System.Drawing.Size(44, 25);
            this.lbname.TabIndex = 88;
            this.lbname.Text = "lb1";
            // 
            // cosmeticsreorderlevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 623);
            this.Controls.Add(this.lbaddress);
            this.Controls.Add(this.lbname);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.lsvitems);
            this.Controls.Add(this.DateTimePicker1);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.ComboBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "cosmeticsreorderlevel";
            this.Text = "Cosmetics ReOrder Level";
            this.Load += new System.EventHandler(this.cardsreorderlevel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		internal System.Windows.Forms.ListView lsvitems;
		internal System.Windows.Forms.ColumnHeader ColumnHeader2;
		internal System.Windows.Forms.ColumnHeader ColumnHeader3;
		internal System.Windows.Forms.ColumnHeader ColumnHeader4;
		internal System.Windows.Forms.ColumnHeader ColumnHeader5;
		internal System.Windows.Forms.DateTimePicker DateTimePicker1;
		internal System.Windows.Forms.Button Button1;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.ComboBox ComboBox1;
		internal System.Windows.Forms.TextBox txttotal;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.Label lbaddress;
		internal System.Windows.Forms.Label lbname;
	}

}