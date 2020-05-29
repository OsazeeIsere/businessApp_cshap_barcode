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
	public partial class drinksreorderlevel : System.Windows.Forms.Form
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
			this.ColumnHeader2 = (System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader());
			this.ColumnHeader3 = (System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader());
			this.ColumnHeader4 = (System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader());
			this.ColumnHeader5 = (System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader());
			this.DateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.Button1 = new System.Windows.Forms.Button();
			this.Label1 = new System.Windows.Forms.Label();
			this.ComboBox1 = new System.Windows.Forms.ComboBox();
			this.Label5 = new System.Windows.Forms.Label();
			this.Label6 = new System.Windows.Forms.Label();
			this.txttotal = new System.Windows.Forms.TextBox();
			this.Label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			//
			//lsvitems
			//
			this.lsvitems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {this.ColumnHeader2, this.ColumnHeader3, this.ColumnHeader4, this.ColumnHeader5});
			this.lsvitems.FullRowSelect = true;
			this.lsvitems.GridLines = true;
			this.lsvitems.Location = new System.Drawing.Point(120, 202);
			this.lsvitems.Name = "lsvitems";
			this.lsvitems.Size = new System.Drawing.Size(739, 384);
			this.lsvitems.TabIndex = 78;
			this.lsvitems.UseCompatibleStateImageBehavior = false;
			this.lsvitems.View = System.Windows.Forms.View.Details;
			//
			//ColumnHeader2
			//
			this.ColumnHeader2.Text = "productname ";
			this.ColumnHeader2.Width = 134;
			//
			//ColumnHeader3
			//
			this.ColumnHeader3.Text = "quantity";
			this.ColumnHeader3.Width = 130;
			//
			//ColumnHeader4
			//
			this.ColumnHeader4.Text = "unitcostprice";
			this.ColumnHeader4.Width = 142;
			//
			//ColumnHeader5
			//
			this.ColumnHeader5.Text = "unitsalesprice";
			this.ColumnHeader5.Width = 113;
			//
			//DateTimePicker1
			//
			this.DateTimePicker1.Location = new System.Drawing.Point(650, 114);
			this.DateTimePicker1.Name = "DateTimePicker1";
			this.DateTimePicker1.Size = new System.Drawing.Size(261, 26);
			this.DateTimePicker1.TabIndex = 77;
			//
			//Button1
			//
			this.Button1.Location = new System.Drawing.Point(524, 108);
			this.Button1.Name = "Button1";
			this.Button1.Size = new System.Drawing.Size(117, 38);
			this.Button1.TabIndex = 76;
			this.Button1.Text = "Checked";
			this.Button1.UseVisualStyleBackColor = true;
			//
			//Label1
			//
			this.Label1.AutoSize = true;
			this.Label1.Location = new System.Drawing.Point(36, 122);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(188, 20);
			this.Label1.TabIndex = 75;
			this.Label1.Text = "Select The Reorder Level";
			//
			//ComboBox1
			//
			this.ComboBox1.FormattingEnabled = true;
			this.ComboBox1.Items.AddRange(new object[] {"Products Less Than 5 units in Stock", "Products Less Than 10 units in Stock", "Products Less Than 20 units in Stock", "Products Less Than 50 units in Stock", "Products Above  50 units in Stock"});
			this.ComboBox1.Location = new System.Drawing.Point(230, 118);
			this.ComboBox1.Name = "ComboBox1";
			this.ComboBox1.Size = new System.Drawing.Size(288, 28);
			this.ComboBox1.TabIndex = 74;
			//
			//Label5
			//
			this.Label5.AutoSize = true;
			this.Label5.BackColor = System.Drawing.Color.White;
			this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.Label5.Location = new System.Drawing.Point(330, 68);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(381, 24);
			this.Label5.TabIndex = 73;
			this.Label5.Text = "No. 218, 2nd, East Circular Road, Benin City.";
			//
			//Label6
			//
			this.Label6.AutoSize = true;
			this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label6.ForeColor = System.Drawing.Color.Aqua;
			this.Label6.Location = new System.Drawing.Point(183, 27);
			this.Label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label6.Name = "Label6";
			this.Label6.Size = new System.Drawing.Size(712, 29);
			this.Label6.TabIndex = 72;
			this.Label6.Text = "WELCOME TO JULIA AND SYL PHARMACY  AND STORES ";
			//
			//txttotal
			//
			this.txttotal.Location = new System.Drawing.Point(562, 154);
			this.txttotal.Multiline = true;
			this.txttotal.Name = "txttotal";
			this.txttotal.Size = new System.Drawing.Size(82, 32);
			this.txttotal.TabIndex = 80;
			//
			//Label2
			//
			this.Label2.AutoSize = true;
			this.Label2.Location = new System.Drawing.Point(271, 166);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(285, 20);
			this.Label2.TabIndex = 79;
			this.Label2.Text = "The Total Number of Products Affected";
			//
			//drinksreorderlevel
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(9.0F, 20.0F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(947, 614);
			this.Controls.Add(this.txttotal);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.lsvitems);
			this.Controls.Add(this.DateTimePicker1);
			this.Controls.Add(this.Button1);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.ComboBox1);
			this.Controls.Add(this.Label5);
			this.Controls.Add(this.Label6);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "drinksreorderlevel";
			this.Text = "Drinks ReOrder Level";
			this.ResumeLayout(false);
			this.PerformLayout();

//INSTANT C# NOTE: Converted design-time event handler wireups:
			Button1.Click += new System.EventHandler(Button1_Click);
			base.Load += new System.EventHandler(drinksreorderlevel_Load);
			DateTimePicker1.ValueChanged += new System.EventHandler(DateTimePicker1_ValueChanged);
			ComboBox1.SelectedIndexChanged += new System.EventHandler(ComboBox1_SelectedIndexChanged);
			lsvitems.SelectedIndexChanged += new System.EventHandler(lsvitems_SelectedIndexChanged);
			Label6.Click += new System.EventHandler(Label6_Click);
			Label1.Click += new System.EventHandler(Label1_Click);
			Label5.Click += new System.EventHandler(Label5_Click);
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
		internal System.Windows.Forms.Label Label5;
		internal System.Windows.Forms.Label Label6;
		internal System.Windows.Forms.TextBox txttotal;
		internal System.Windows.Forms.Label Label2;
	}

}