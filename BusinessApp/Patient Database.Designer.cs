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
	public partial class Patient_Database : System.Windows.Forms.Form
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
			this.lblpharmacyname = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.dgvpatient = new System.Windows.Forms.DataGridView();
			this.Label2 = new System.Windows.Forms.Label();
			this.txttotalnumberofpatient = new System.Windows.Forms.TextBox();
			this.txtpatientplan1 = new System.Windows.Forms.TextBox();
			this.Label26 = new System.Windows.Forms.Label();
			this.txtpatienttreatment1 = new System.Windows.Forms.TextBox();
			this.Label25 = new System.Windows.Forms.Label();
			this.txtpatientcomplaint1 = new System.Windows.Forms.TextBox();
			this.Label24 = new System.Windows.Forms.Label();
			this.DateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.Button1 = new System.Windows.Forms.Button();
			this.txtpatientallergies1 = new System.Windows.Forms.RichTextBox();
			this.Label23 = new System.Windows.Forms.Label();
			this.Button2 = new System.Windows.Forms.Button();
			this.Label8 = new System.Windows.Forms.Label();
			this.txtsearch = new System.Windows.Forms.TextBox();
			this.PictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)this.dgvpatient).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.PictureBox1).BeginInit();
			this.SuspendLayout();
			//
			//lblpharmacyname
			//
			this.lblpharmacyname.AutoSize = true;
			this.lblpharmacyname.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.lblpharmacyname.Location = new System.Drawing.Point(289, 12);
			this.lblpharmacyname.Name = "lblpharmacyname";
			this.lblpharmacyname.Size = new System.Drawing.Size(292, 31);
			this.lblpharmacyname.TabIndex = 0;
			this.lblpharmacyname.Text = "Good Mind Pharmacy";
			//
			//Label1
			//
			this.Label1.AutoSize = true;
			this.Label1.Location = new System.Drawing.Point(18, 244);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(215, 20);
			this.Label1.TabIndex = 1;
			this.Label1.Text = "List Of Patients In Data Base";
			//
			//dgvpatient
			//
			this.dgvpatient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvpatient.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.dgvpatient.Location = new System.Drawing.Point(12, 289);
			this.dgvpatient.Name = "dgvpatient";
			this.dgvpatient.Size = new System.Drawing.Size(1246, 328);
			this.dgvpatient.TabIndex = 2;
			//
			//Label2
			//
			this.Label2.AutoSize = true;
			this.Label2.Location = new System.Drawing.Point(45, 671);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(199, 20);
			this.Label2.TabIndex = 3;
			this.Label2.Text = "Total Number Of Patients : ";
			//
			//txttotalnumberofpatient
			//
			this.txttotalnumberofpatient.Location = new System.Drawing.Point(262, 674);
			this.txttotalnumberofpatient.Name = "txttotalnumberofpatient";
			this.txttotalnumberofpatient.Size = new System.Drawing.Size(137, 26);
			this.txttotalnumberofpatient.TabIndex = 4;
			//
			//txtpatientplan1
			//
			this.txtpatientplan1.Location = new System.Drawing.Point(839, 181);
			this.txtpatientplan1.Multiline = true;
			this.txtpatientplan1.Name = "txtpatientplan1";
			this.txtpatientplan1.Size = new System.Drawing.Size(419, 46);
			this.txtpatientplan1.TabIndex = 57;
			//
			//Label26
			//
			this.Label26.AutoSize = true;
			this.Label26.Location = new System.Drawing.Point(783, 193);
			this.Label26.Name = "Label26";
			this.Label26.Size = new System.Drawing.Size(50, 20);
			this.Label26.TabIndex = 56;
			this.Label26.Text = "PLAN";
			//
			//txtpatienttreatment1
			//
			this.txtpatienttreatment1.Location = new System.Drawing.Point(837, 71);
			this.txtpatienttreatment1.Multiline = true;
			this.txtpatienttreatment1.Name = "txtpatienttreatment1";
			this.txtpatienttreatment1.Size = new System.Drawing.Size(421, 104);
			this.txtpatienttreatment1.TabIndex = 55;
			//
			//Label25
			//
			this.Label25.AutoSize = true;
			this.Label25.Location = new System.Drawing.Point(516, 87);
			this.Label25.Name = "Label25";
			this.Label25.Size = new System.Drawing.Size(297, 20);
			this.Label25.TabIndex = 54;
			this.Label25.Text = "TREATMENT REVIEW COMMENT/ADR";
			//
			//txtpatientcomplaint1
			//
			this.txtpatientcomplaint1.Location = new System.Drawing.Point(234, 69);
			this.txtpatientcomplaint1.Multiline = true;
			this.txtpatientcomplaint1.Name = "txtpatientcomplaint1";
			this.txtpatientcomplaint1.Size = new System.Drawing.Size(257, 144);
			this.txtpatientcomplaint1.TabIndex = 53;
			//
			//Label24
			//
			this.Label24.AutoSize = true;
			this.Label24.Location = new System.Drawing.Point(3, 71);
			this.Label24.Name = "Label24";
			this.Label24.Size = new System.Drawing.Size(231, 20);
			this.Label24.TabIndex = 52;
			this.Label24.Text = "COMPLAINTS/OBSERVATION";
			//
			//DateTimePicker1
			//
			this.DateTimePicker1.Location = new System.Drawing.Point(1012, 26);
			this.DateTimePicker1.Name = "DateTimePicker1";
			this.DateTimePicker1.Size = new System.Drawing.Size(260, 26);
			this.DateTimePicker1.TabIndex = 58;
			//
			//Button1
			//
			this.Button1.Location = new System.Drawing.Point(531, 652);
			this.Button1.Name = "Button1";
			this.Button1.Size = new System.Drawing.Size(176, 68);
			this.Button1.TabIndex = 59;
			this.Button1.Text = "Update Patient Record";
			this.Button1.UseVisualStyleBackColor = true;
			//
			//txtpatientallergies1
			//
			this.txtpatientallergies1.Location = new System.Drawing.Point(839, 233);
			this.txtpatientallergies1.Name = "txtpatientallergies1";
			this.txtpatientallergies1.Size = new System.Drawing.Size(419, 41);
			this.txtpatientallergies1.TabIndex = 61;
			this.txtpatientallergies1.Text = "";
			//
			//Label23
			//
			this.Label23.AutoSize = true;
			this.Label23.Location = new System.Drawing.Point(732, 245);
			this.Label23.Name = "Label23";
			this.Label23.Size = new System.Drawing.Size(101, 20);
			this.Label23.TabIndex = 60;
			this.Label23.Text = "ALLERGIES";
			//
			//Button2
			//
			this.Button2.Location = new System.Drawing.Point(837, 656);
			this.Button2.Name = "Button2";
			this.Button2.Size = new System.Drawing.Size(203, 64);
			this.Button2.TabIndex = 62;
			this.Button2.Text = "View Patient Details";
			this.Button2.UseVisualStyleBackColor = true;
			//
			//Label8
			//
			this.Label8.AutoSize = true;
			this.Label8.Location = new System.Drawing.Point(436, 240);
			this.Label8.Name = "Label8";
			this.Label8.Size = new System.Drawing.Size(60, 20);
			this.Label8.TabIndex = 64;
			this.Label8.Text = "Search";
			//
			//txtsearch
			//
			this.txtsearch.Location = new System.Drawing.Point(307, 233);
			this.txtsearch.Multiline = true;
			this.txtsearch.Name = "txtsearch";
			this.txtsearch.Size = new System.Drawing.Size(123, 31);
			this.txtsearch.TabIndex = 63;
			//
			//PictureBox1
			//
			this.PictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.PictureBox1.Image = BusinessApp.Properties.Resources.search2;
			this.PictureBox1.Location = new System.Drawing.Point(234, 233);
			this.PictureBox1.Name = "PictureBox1";
			this.PictureBox1.Size = new System.Drawing.Size(67, 31);
			this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.PictureBox1.TabIndex = 65;
			this.PictureBox1.TabStop = false;
			//
			//Patient_Database
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(9.0F, 20.0F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(128)), Convert.ToInt32(Convert.ToByte(255)), Convert.ToInt32(Convert.ToByte(128)));
			this.ClientSize = new System.Drawing.Size(1284, 782);
			this.Controls.Add(this.PictureBox1);
			this.Controls.Add(this.Label8);
			this.Controls.Add(this.txtsearch);
			this.Controls.Add(this.Button2);
			this.Controls.Add(this.txtpatientallergies1);
			this.Controls.Add(this.Label23);
			this.Controls.Add(this.Button1);
			this.Controls.Add(this.DateTimePicker1);
			this.Controls.Add(this.txtpatientplan1);
			this.Controls.Add(this.Label26);
			this.Controls.Add(this.txtpatienttreatment1);
			this.Controls.Add(this.Label25);
			this.Controls.Add(this.txtpatientcomplaint1);
			this.Controls.Add(this.Label24);
			this.Controls.Add(this.txttotalnumberofpatient);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.dgvpatient);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.lblpharmacyname);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "Patient_Database";
			this.Text = "Patient_Database";
			((System.ComponentModel.ISupportInitialize)this.dgvpatient).EndInit();
			((System.ComponentModel.ISupportInitialize)this.PictureBox1).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

//INSTANT C# NOTE: Converted design-time event handler wireups:
			base.Load += new System.EventHandler(Patient_Database_Load);
			Button1.Click += new System.EventHandler(Button1_Click);
			Button2.Click += new System.EventHandler(Button2_Click);
			txtsearch.TextChanged += new System.EventHandler(txtsearch_TextChanged);
		}
		internal System.Windows.Forms.Label lblpharmacyname;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.DataGridView dgvpatient;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.TextBox txttotalnumberofpatient;
		internal System.Windows.Forms.TextBox txtpatientplan1;
		internal System.Windows.Forms.Label Label26;
		internal System.Windows.Forms.TextBox txtpatienttreatment1;
		internal System.Windows.Forms.Label Label25;
		internal System.Windows.Forms.TextBox txtpatientcomplaint1;
		internal System.Windows.Forms.Label Label24;
		internal System.Windows.Forms.DateTimePicker DateTimePicker1;
		internal System.Windows.Forms.Button Button1;
		internal System.Windows.Forms.RichTextBox txtpatientallergies1;
		internal System.Windows.Forms.Label Label23;
		internal System.Windows.Forms.Button Button2;
		internal System.Windows.Forms.PictureBox PictureBox1;
		internal System.Windows.Forms.Label Label8;
		internal System.Windows.Forms.TextBox txtsearch;
	}

}