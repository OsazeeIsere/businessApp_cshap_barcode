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
	public partial class PatientInfo : System.Windows.Forms.Form
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
			this.Label1 = new System.Windows.Forms.Label();
			this.txtpharmacyname = new System.Windows.Forms.TextBox();
			this.Label2 = new System.Windows.Forms.Label();
			this.txtpharmacyaddress = new System.Windows.Forms.RichTextBox();
			this.Label3 = new System.Windows.Forms.Label();
			this.Label4 = new System.Windows.Forms.Label();
			this.txtpatientname = new System.Windows.Forms.TextBox();
			this.Label5 = new System.Windows.Forms.Label();
			this.txtpatientothernames = new System.Windows.Forms.TextBox();
			this.DateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.Label6 = new System.Windows.Forms.Label();
			this.txtpatientaddress = new System.Windows.Forms.TextBox();
			this.Label7 = new System.Windows.Forms.Label();
			this.txtpatientnumber = new System.Windows.Forms.TextBox();
			this.Label8 = new System.Windows.Forms.Label();
			this.txtpatientdob = new System.Windows.Forms.TextBox();
			this.Label9 = new System.Windows.Forms.Label();
			this.txtpatientage = new System.Windows.Forms.TextBox();
			this.Label10 = new System.Windows.Forms.Label();
			this.cblpatientsex = new System.Windows.Forms.ComboBox();
			this.Label11 = new System.Windows.Forms.Label();
			this.cblpatientmaritalstatus = new System.Windows.Forms.ComboBox();
			this.Label12 = new System.Windows.Forms.Label();
			this.txtpatientoccupation = new System.Windows.Forms.TextBox();
			this.Label13 = new System.Windows.Forms.Label();
			this.txtpatientreligion = new System.Windows.Forms.TextBox();
			this.Label14 = new System.Windows.Forms.Label();
			this.txtpatientheight = new System.Windows.Forms.TextBox();
			this.Label15 = new System.Windows.Forms.Label();
			this.txtpatientweight = new System.Windows.Forms.TextBox();
			this.Label16 = new System.Windows.Forms.Label();
			this.txtpatientbmi = new System.Windows.Forms.TextBox();
			this.Label17 = new System.Windows.Forms.Label();
			this.txtpatientnextofkin = new System.Windows.Forms.TextBox();
			this.Label18 = new System.Windows.Forms.Label();
			this.txtpatientnextofkinaddress = new System.Windows.Forms.TextBox();
			this.Label19 = new System.Windows.Forms.Label();
			this.txtpatientnextofkinrelationship = new System.Windows.Forms.TextBox();
			this.Label20 = new System.Windows.Forms.Label();
			this.txtdoctorname = new System.Windows.Forms.TextBox();
			this.Label21 = new System.Windows.Forms.Label();
			this.txthospital = new System.Windows.Forms.TextBox();
			this.Label22 = new System.Windows.Forms.Label();
			this.txtdoctorphonenumber = new System.Windows.Forms.TextBox();
			this.Label23 = new System.Windows.Forms.Label();
			this.txtpatientallergies = new System.Windows.Forms.RichTextBox();
			this.Label24 = new System.Windows.Forms.Label();
			this.txtpatientcomplaint = new System.Windows.Forms.TextBox();
			this.Label25 = new System.Windows.Forms.Label();
			this.txtpatienttreatment = new System.Windows.Forms.TextBox();
			this.Label26 = new System.Windows.Forms.Label();
			this.txtpatientplan = new System.Windows.Forms.TextBox();
			this.Button1 = new System.Windows.Forms.Button();
			this.Button2 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			//
			//Label1
			//
			this.Label1.AutoSize = true;
			this.Label1.Location = new System.Drawing.Point(22, 28);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(150, 20);
			this.Label1.TabIndex = 0;
			this.Label1.Text = "Name Of Pharmacy:";
			//
			//txtpharmacyname
			//
			this.txtpharmacyname.Location = new System.Drawing.Point(197, 26);
			this.txtpharmacyname.Multiline = true;
			this.txtpharmacyname.Name = "txtpharmacyname";
			this.txtpharmacyname.Size = new System.Drawing.Size(876, 31);
			this.txtpharmacyname.TabIndex = 1;
			//
			//Label2
			//
			this.Label2.AutoSize = true;
			this.Label2.Location = new System.Drawing.Point(29, 76);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(76, 20);
			this.Label2.TabIndex = 2;
			this.Label2.Text = "Address :";
			//
			//txtpharmacyaddress
			//
			this.txtpharmacyaddress.Location = new System.Drawing.Point(197, 73);
			this.txtpharmacyaddress.Name = "txtpharmacyaddress";
			this.txtpharmacyaddress.Size = new System.Drawing.Size(876, 37);
			this.txtpharmacyaddress.TabIndex = 3;
			this.txtpharmacyaddress.Text = "";
			//
			//Label3
			//
			this.Label3.AutoSize = true;
			this.Label3.Location = new System.Drawing.Point(30, 154);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(174, 20);
			this.Label3.TabIndex = 4;
			this.Label3.Text = "DETAILS OF CLIENTS";
			//
			//Label4
			//
			this.Label4.AutoSize = true;
			this.Label4.Location = new System.Drawing.Point(22, 191);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(90, 20);
			this.Label4.TabIndex = 5;
			this.Label4.Text = "SURNAME";
			//
			//txtpatientname
			//
			this.txtpatientname.Location = new System.Drawing.Point(118, 188);
			this.txtpatientname.Name = "txtpatientname";
			this.txtpatientname.Size = new System.Drawing.Size(163, 26);
			this.txtpatientname.TabIndex = 6;
			//
			//Label5
			//
			this.Label5.AutoSize = true;
			this.Label5.Location = new System.Drawing.Point(342, 189);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(122, 20);
			this.Label5.TabIndex = 7;
			this.Label5.Text = "OTHERNAMES";
			//
			//txtpatientothernames
			//
			this.txtpatientothernames.Location = new System.Drawing.Point(472, 186);
			this.txtpatientothernames.Name = "txtpatientothernames";
			this.txtpatientothernames.Size = new System.Drawing.Size(195, 26);
			this.txtpatientothernames.TabIndex = 8;
			//
			//DateTimePicker1
			//
			this.DateTimePicker1.Location = new System.Drawing.Point(601, 130);
			this.DateTimePicker1.Name = "DateTimePicker1";
			this.DateTimePicker1.Size = new System.Drawing.Size(267, 26);
			this.DateTimePicker1.TabIndex = 9;
			//
			//Label6
			//
			this.Label6.AutoSize = true;
			this.Label6.Location = new System.Drawing.Point(22, 233);
			this.Label6.Name = "Label6";
			this.Label6.Size = new System.Drawing.Size(89, 20);
			this.Label6.TabIndex = 10;
			this.Label6.Text = "ADDRESS";
			//
			//txtpatientaddress
			//
			this.txtpatientaddress.Location = new System.Drawing.Point(121, 237);
			this.txtpatientaddress.Multiline = true;
			this.txtpatientaddress.Name = "txtpatientaddress";
			this.txtpatientaddress.Size = new System.Drawing.Size(546, 35);
			this.txtpatientaddress.TabIndex = 11;
			//
			//Label7
			//
			this.Label7.AutoSize = true;
			this.Label7.Location = new System.Drawing.Point(697, 240);
			this.Label7.Name = "Label7";
			this.Label7.Size = new System.Drawing.Size(143, 20);
			this.Label7.TabIndex = 12;
			this.Label7.Text = "PHONE NUMBER:";
			//
			//txtpatientnumber
			//
			this.txtpatientnumber.Location = new System.Drawing.Point(846, 234);
			this.txtpatientnumber.Name = "txtpatientnumber";
			this.txtpatientnumber.Size = new System.Drawing.Size(227, 26);
			this.txtpatientnumber.TabIndex = 13;
			//
			//Label8
			//
			this.Label8.AutoSize = true;
			this.Label8.Location = new System.Drawing.Point(12, 301);
			this.Label8.Name = "Label8";
			this.Label8.Size = new System.Drawing.Size(122, 20);
			this.Label8.TabIndex = 14;
			this.Label8.Text = "DATE OF BIRH";
			//
			//txtpatientdob
			//
			this.txtpatientdob.Location = new System.Drawing.Point(149, 303);
			this.txtpatientdob.Name = "txtpatientdob";
			this.txtpatientdob.Size = new System.Drawing.Size(160, 26);
			this.txtpatientdob.TabIndex = 15;
			//
			//Label9
			//
			this.Label9.AutoSize = true;
			this.Label9.Location = new System.Drawing.Point(355, 305);
			this.Label9.Name = "Label9";
			this.Label9.Size = new System.Drawing.Size(44, 20);
			this.Label9.TabIndex = 16;
			this.Label9.Text = "AGE";
			//
			//txtpatientage
			//
			this.txtpatientage.Location = new System.Drawing.Point(405, 301);
			this.txtpatientage.Name = "txtpatientage";
			this.txtpatientage.Size = new System.Drawing.Size(95, 26);
			this.txtpatientage.TabIndex = 17;
			//
			//Label10
			//
			this.Label10.AutoSize = true;
			this.Label10.Location = new System.Drawing.Point(542, 306);
			this.Label10.Name = "Label10";
			this.Label10.Size = new System.Drawing.Size(42, 20);
			this.Label10.TabIndex = 18;
			this.Label10.Text = "SEX";
			//
			//cblpatientsex
			//
			this.cblpatientsex.FormattingEnabled = true;
			this.cblpatientsex.Items.AddRange(new object[] {"MALE", "FEMALE"});
			this.cblpatientsex.Location = new System.Drawing.Point(590, 302);
			this.cblpatientsex.Name = "cblpatientsex";
			this.cblpatientsex.Size = new System.Drawing.Size(87, 28);
			this.cblpatientsex.TabIndex = 19;
			//
			//Label11
			//
			this.Label11.AutoSize = true;
			this.Label11.Location = new System.Drawing.Point(703, 306);
			this.Label11.Name = "Label11";
			this.Label11.Size = new System.Drawing.Size(146, 20);
			this.Label11.TabIndex = 20;
			this.Label11.Text = "MARITAL STATUS";
			//
			//cblpatientmaritalstatus
			//
			this.cblpatientmaritalstatus.FormattingEnabled = true;
			this.cblpatientmaritalstatus.Items.AddRange(new object[] {"SINGLE", "MARRIED", "DIVORCED", "WIDOW", "WIDOWER"});
			this.cblpatientmaritalstatus.Location = new System.Drawing.Point(861, 299);
			this.cblpatientmaritalstatus.Name = "cblpatientmaritalstatus";
			this.cblpatientmaritalstatus.Size = new System.Drawing.Size(122, 28);
			this.cblpatientmaritalstatus.TabIndex = 21;
			//
			//Label12
			//
			this.Label12.AutoSize = true;
			this.Label12.Location = new System.Drawing.Point(22, 365);
			this.Label12.Name = "Label12";
			this.Label12.Size = new System.Drawing.Size(113, 20);
			this.Label12.TabIndex = 22;
			this.Label12.Text = "OCCUPATION";
			//
			//txtpatientoccupation
			//
			this.txtpatientoccupation.Location = new System.Drawing.Point(154, 359);
			this.txtpatientoccupation.Name = "txtpatientoccupation";
			this.txtpatientoccupation.Size = new System.Drawing.Size(154, 26);
			this.txtpatientoccupation.TabIndex = 23;
			//
			//Label13
			//
			this.Label13.AutoSize = true;
			this.Label13.Location = new System.Drawing.Point(342, 359);
			this.Label13.Name = "Label13";
			this.Label13.Size = new System.Drawing.Size(87, 20);
			this.Label13.TabIndex = 24;
			this.Label13.Text = "RELIGION";
			//
			//txtpatientreligion
			//
			this.txtpatientreligion.Location = new System.Drawing.Point(453, 357);
			this.txtpatientreligion.Name = "txtpatientreligion";
			this.txtpatientreligion.Size = new System.Drawing.Size(137, 26);
			this.txtpatientreligion.TabIndex = 25;
			//
			//Label14
			//
			this.Label14.AutoSize = true;
			this.Label14.Location = new System.Drawing.Point(610, 359);
			this.Label14.Name = "Label14";
			this.Label14.Size = new System.Drawing.Size(71, 20);
			this.Label14.TabIndex = 26;
			this.Label14.Text = "HEIGHT";
			//
			//txtpatientheight
			//
			this.txtpatientheight.Location = new System.Drawing.Point(691, 359);
			this.txtpatientheight.Name = "txtpatientheight";
			this.txtpatientheight.Size = new System.Drawing.Size(62, 26);
			this.txtpatientheight.TabIndex = 27;
			//
			//Label15
			//
			this.Label15.AutoSize = true;
			this.Label15.Location = new System.Drawing.Point(778, 360);
			this.Label15.Name = "Label15";
			this.Label15.Size = new System.Drawing.Size(74, 20);
			this.Label15.TabIndex = 28;
			this.Label15.Text = "WEIGHT";
			//
			//txtpatientweight
			//
			this.txtpatientweight.Location = new System.Drawing.Point(862, 359);
			this.txtpatientweight.Name = "txtpatientweight";
			this.txtpatientweight.Size = new System.Drawing.Size(73, 26);
			this.txtpatientweight.TabIndex = 29;
			//
			//Label16
			//
			this.Label16.AutoSize = true;
			this.Label16.Location = new System.Drawing.Point(956, 362);
			this.Label16.Name = "Label16";
			this.Label16.Size = new System.Drawing.Size(38, 20);
			this.Label16.TabIndex = 30;
			this.Label16.Text = "BMI";
			//
			//txtpatientbmi
			//
			this.txtpatientbmi.Location = new System.Drawing.Point(997, 357);
			this.txtpatientbmi.Multiline = true;
			this.txtpatientbmi.Name = "txtpatientbmi";
			this.txtpatientbmi.Size = new System.Drawing.Size(76, 28);
			this.txtpatientbmi.TabIndex = 31;
			//
			//Label17
			//
			this.Label17.AutoSize = true;
			this.Label17.Location = new System.Drawing.Point(26, 411);
			this.Label17.Name = "Label17";
			this.Label17.Size = new System.Drawing.Size(107, 20);
			this.Label17.TabIndex = 32;
			this.Label17.Text = "NEXT OF KIN";
			//
			//txtpatientnextofkin
			//
			this.txtpatientnextofkin.Location = new System.Drawing.Point(160, 409);
			this.txtpatientnextofkin.Name = "txtpatientnextofkin";
			this.txtpatientnextofkin.Size = new System.Drawing.Size(269, 26);
			this.txtpatientnextofkin.TabIndex = 33;
			//
			//Label18
			//
			this.Label18.AutoSize = true;
			this.Label18.Location = new System.Drawing.Point(452, 410);
			this.Label18.Name = "Label18";
			this.Label18.Size = new System.Drawing.Size(89, 20);
			this.Label18.TabIndex = 34;
			this.Label18.Text = "ADDRESS";
			//
			//txtpatientnextofkinaddress
			//
			this.txtpatientnextofkinaddress.Location = new System.Drawing.Point(556, 409);
			this.txtpatientnextofkinaddress.Multiline = true;
			this.txtpatientnextofkinaddress.Name = "txtpatientnextofkinaddress";
			this.txtpatientnextofkinaddress.Size = new System.Drawing.Size(516, 26);
			this.txtpatientnextofkinaddress.TabIndex = 35;
			//
			//Label19
			//
			this.Label19.AutoSize = true;
			this.Label19.Location = new System.Drawing.Point(12, 464);
			this.Label19.Name = "Label19";
			this.Label19.Size = new System.Drawing.Size(127, 20);
			this.Label19.TabIndex = 36;
			this.Label19.Text = "RELATIONSHIP";
			//
			//txtpatientnextofkinrelationship
			//
			this.txtpatientnextofkinrelationship.Location = new System.Drawing.Point(162, 455);
			this.txtpatientnextofkinrelationship.Name = "txtpatientnextofkinrelationship";
			this.txtpatientnextofkinrelationship.Size = new System.Drawing.Size(184, 26);
			this.txtpatientnextofkinrelationship.TabIndex = 37;
			//
			//Label20
			//
			this.Label20.AutoSize = true;
			this.Label20.Location = new System.Drawing.Point(393, 461);
			this.Label20.Name = "Label20";
			this.Label20.Size = new System.Drawing.Size(77, 20);
			this.Label20.TabIndex = 38;
			this.Label20.Text = "DOCTOR";
			//
			//txtdoctorname
			//
			this.txtdoctorname.Location = new System.Drawing.Point(476, 462);
			this.txtdoctorname.Name = "txtdoctorname";
			this.txtdoctorname.Size = new System.Drawing.Size(224, 26);
			this.txtdoctorname.TabIndex = 39;
			//
			//Label21
			//
			this.Label21.AutoSize = true;
			this.Label21.Location = new System.Drawing.Point(737, 465);
			this.Label21.Name = "Label21";
			this.Label21.Size = new System.Drawing.Size(88, 20);
			this.Label21.TabIndex = 40;
			this.Label21.Text = "HOSPITAL";
			//
			//txthospital
			//
			this.txthospital.Location = new System.Drawing.Point(831, 458);
			this.txthospital.Name = "txthospital";
			this.txthospital.Size = new System.Drawing.Size(240, 26);
			this.txthospital.TabIndex = 41;
			//
			//Label22
			//
			this.Label22.AutoSize = true;
			this.Label22.Location = new System.Drawing.Point(12, 506);
			this.Label22.Name = "Label22";
			this.Label22.Size = new System.Drawing.Size(175, 20);
			this.Label22.TabIndex = 42;
			this.Label22.Text = "DOCTOR'S PHONE No";
			//
			//txtdoctorphonenumber
			//
			this.txtdoctorphonenumber.Location = new System.Drawing.Point(204, 506);
			this.txtdoctorphonenumber.Name = "txtdoctorphonenumber";
			this.txtdoctorphonenumber.Size = new System.Drawing.Size(165, 26);
			this.txtdoctorphonenumber.TabIndex = 43;
			//
			//Label23
			//
			this.Label23.AutoSize = true;
			this.Label23.Location = new System.Drawing.Point(401, 509);
			this.Label23.Name = "Label23";
			this.Label23.Size = new System.Drawing.Size(101, 20);
			this.Label23.TabIndex = 44;
			this.Label23.Text = "ALLERGIES";
			//
			//txtpatientallergies
			//
			this.txtpatientallergies.Location = new System.Drawing.Point(516, 506);
			this.txtpatientallergies.Name = "txtpatientallergies";
			this.txtpatientallergies.Size = new System.Drawing.Size(255, 25);
			this.txtpatientallergies.TabIndex = 45;
			this.txtpatientallergies.Text = "";
			//
			//Label24
			//
			this.Label24.AutoSize = true;
			this.Label24.Location = new System.Drawing.Point(14, 569);
			this.Label24.Name = "Label24";
			this.Label24.Size = new System.Drawing.Size(231, 20);
			this.Label24.TabIndex = 46;
			this.Label24.Text = "COMPLAINTS/OBSERVATION";
			//
			//txtpatientcomplaint
			//
			this.txtpatientcomplaint.Location = new System.Drawing.Point(245, 567);
			this.txtpatientcomplaint.Multiline = true;
			this.txtpatientcomplaint.Name = "txtpatientcomplaint";
			this.txtpatientcomplaint.Size = new System.Drawing.Size(257, 71);
			this.txtpatientcomplaint.TabIndex = 47;
			//
			//Label25
			//
			this.Label25.AutoSize = true;
			this.Label25.Location = new System.Drawing.Point(528, 570);
			this.Label25.Name = "Label25";
			this.Label25.Size = new System.Drawing.Size(297, 20);
			this.Label25.TabIndex = 48;
			this.Label25.Text = "TREATMENT REVIEW COMMENT/ADR";
			//
			//txtpatienttreatment
			//
			this.txtpatienttreatment.Location = new System.Drawing.Point(831, 554);
			this.txtpatienttreatment.Multiline = true;
			this.txtpatienttreatment.Name = "txtpatienttreatment";
			this.txtpatienttreatment.Size = new System.Drawing.Size(240, 50);
			this.txtpatienttreatment.TabIndex = 49;
			//
			//Label26
			//
			this.Label26.AutoSize = true;
			this.Label26.Location = new System.Drawing.Point(27, 696);
			this.Label26.Name = "Label26";
			this.Label26.Size = new System.Drawing.Size(50, 20);
			this.Label26.TabIndex = 50;
			this.Label26.Text = "PLAN";
			//
			//txtpatientplan
			//
			this.txtpatientplan.Location = new System.Drawing.Point(83, 684);
			this.txtpatientplan.Multiline = true;
			this.txtpatientplan.Name = "txtpatientplan";
			this.txtpatientplan.Size = new System.Drawing.Size(419, 46);
			this.txtpatientplan.TabIndex = 51;
			//
			//Button1
			//
			this.Button1.BackColor = System.Drawing.Color.White;
			this.Button1.ForeColor = System.Drawing.Color.Red;
			this.Button1.Location = new System.Drawing.Point(516, 669);
			this.Button1.Name = "Button1";
			this.Button1.Size = new System.Drawing.Size(255, 61);
			this.Button1.TabIndex = 52;
			this.Button1.Text = "CAPTURE PATIENT INFO";
			this.Button1.UseVisualStyleBackColor = false;
			//
			//Button2
			//
			this.Button2.Location = new System.Drawing.Point(831, 669);
			this.Button2.Name = "Button2";
			this.Button2.Size = new System.Drawing.Size(240, 61);
			this.Button2.TabIndex = 53;
			this.Button2.Text = "View Patients' Database";
			this.Button2.UseVisualStyleBackColor = true;
			//
			//PatientInfo
			//
			this.AcceptButton = this.Button1;
			this.AutoScaleDimensions = new System.Drawing.SizeF(9.0F, 20.0F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1098, 782);
			this.Controls.Add(this.Button2);
			this.Controls.Add(this.Button1);
			this.Controls.Add(this.txtpatientplan);
			this.Controls.Add(this.Label26);
			this.Controls.Add(this.txtpatienttreatment);
			this.Controls.Add(this.Label25);
			this.Controls.Add(this.txtpatientcomplaint);
			this.Controls.Add(this.Label24);
			this.Controls.Add(this.txtpatientallergies);
			this.Controls.Add(this.Label23);
			this.Controls.Add(this.txtdoctorphonenumber);
			this.Controls.Add(this.Label22);
			this.Controls.Add(this.txthospital);
			this.Controls.Add(this.Label21);
			this.Controls.Add(this.txtdoctorname);
			this.Controls.Add(this.Label20);
			this.Controls.Add(this.txtpatientnextofkinrelationship);
			this.Controls.Add(this.Label19);
			this.Controls.Add(this.txtpatientnextofkinaddress);
			this.Controls.Add(this.Label18);
			this.Controls.Add(this.txtpatientnextofkin);
			this.Controls.Add(this.Label17);
			this.Controls.Add(this.txtpatientbmi);
			this.Controls.Add(this.Label16);
			this.Controls.Add(this.txtpatientweight);
			this.Controls.Add(this.Label15);
			this.Controls.Add(this.txtpatientheight);
			this.Controls.Add(this.Label14);
			this.Controls.Add(this.txtpatientreligion);
			this.Controls.Add(this.Label13);
			this.Controls.Add(this.txtpatientoccupation);
			this.Controls.Add(this.Label12);
			this.Controls.Add(this.cblpatientmaritalstatus);
			this.Controls.Add(this.Label11);
			this.Controls.Add(this.cblpatientsex);
			this.Controls.Add(this.Label10);
			this.Controls.Add(this.txtpatientage);
			this.Controls.Add(this.Label9);
			this.Controls.Add(this.txtpatientdob);
			this.Controls.Add(this.Label8);
			this.Controls.Add(this.txtpatientnumber);
			this.Controls.Add(this.Label7);
			this.Controls.Add(this.txtpatientaddress);
			this.Controls.Add(this.Label6);
			this.Controls.Add(this.DateTimePicker1);
			this.Controls.Add(this.txtpatientothernames);
			this.Controls.Add(this.Label5);
			this.Controls.Add(this.txtpatientname);
			this.Controls.Add(this.Label4);
			this.Controls.Add(this.Label3);
			this.Controls.Add(this.txtpharmacyaddress);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.txtpharmacyname);
			this.Controls.Add(this.Label1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "PatientInfo";
			this.Text = "New Patient Info";
			this.ResumeLayout(false);
			this.PerformLayout();

//INSTANT C# NOTE: Converted design-time event handler wireups:
			txtpharmacyname.TextChanged += new System.EventHandler(TextBox1_TextChanged);
			Label2.Click += new System.EventHandler(Label2_Click);
			txtpatientnumber.TextChanged += new System.EventHandler(TextBox5_TextChanged);
			Label23.Click += new System.EventHandler(Label23_Click);
			Button1.Click += new System.EventHandler(Button1_Click);
			txtpatienttreatment.TextChanged += new System.EventHandler(txtpatienttreatment_TextChanged);
			Button2.Click += new System.EventHandler(Button2_Click);
			txtpatientallergies.TextChanged += new System.EventHandler(txtpatientallergies_TextChanged);
			base.Load += new System.EventHandler(PatientInfo_Load);
			txtpatientnextofkin.TextChanged += new System.EventHandler(txtpatientnextofkin_TextChanged);
			txtpatientnextofkinrelationship.TextChanged += new System.EventHandler(txtpatientnextofkinrelationship_TextChanged);
			Label19.Click += new System.EventHandler(Label19_Click);
			Label22.Click += new System.EventHandler(Label22_Click);
			txtdoctorphonenumber.TextChanged += new System.EventHandler(txtdoctorphonenumber_TextChanged);
			txtpatientnextofkinaddress.TextChanged += new System.EventHandler(txtpatientnextofkinaddress_TextChanged);
			Label18.Click += new System.EventHandler(Label18_Click);
			Label4.Click += new System.EventHandler(Label4_Click);
			Label17.Click += new System.EventHandler(Label17_Click);
			cblpatientmaritalstatus.SelectedIndexChanged += new System.EventHandler(cblpatientmaritalstatus_SelectedIndexChanged);
			Label11.Click += new System.EventHandler(Label11_Click);
			cblpatientsex.SelectedIndexChanged += new System.EventHandler(cblpatientsex_SelectedIndexChanged);
			Label10.Click += new System.EventHandler(Label10_Click);
			Label8.Click += new System.EventHandler(Label8_Click);
			Label7.Click += new System.EventHandler(Label7_Click);
			txtpatientaddress.TextChanged += new System.EventHandler(txtpatientaddress_TextChanged);
			Label6.Click += new System.EventHandler(Label6_Click);
			txtpatientothernames.TextChanged += new System.EventHandler(txtpatientothernames_TextChanged);
			Label5.Click += new System.EventHandler(Label5_Click);
			txtpatientname.TextChanged += new System.EventHandler(txtpatientname_TextChanged);
		}
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.TextBox txtpharmacyname;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.RichTextBox txtpharmacyaddress;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.TextBox txtpatientname;
		internal System.Windows.Forms.Label Label5;
		internal System.Windows.Forms.TextBox txtpatientothernames;
		internal System.Windows.Forms.DateTimePicker DateTimePicker1;
		internal System.Windows.Forms.Label Label6;
		internal System.Windows.Forms.TextBox txtpatientaddress;
		internal System.Windows.Forms.Label Label7;
		internal System.Windows.Forms.TextBox txtpatientnumber;
		internal System.Windows.Forms.Label Label8;
		internal System.Windows.Forms.TextBox txtpatientdob;
		internal System.Windows.Forms.Label Label9;
		internal System.Windows.Forms.TextBox txtpatientage;
		internal System.Windows.Forms.Label Label10;
		internal System.Windows.Forms.ComboBox cblpatientsex;
		internal System.Windows.Forms.Label Label11;
		internal System.Windows.Forms.ComboBox cblpatientmaritalstatus;
		internal System.Windows.Forms.Label Label12;
		internal System.Windows.Forms.TextBox txtpatientoccupation;
		internal System.Windows.Forms.Label Label13;
		internal System.Windows.Forms.TextBox txtpatientreligion;
		internal System.Windows.Forms.Label Label14;
		internal System.Windows.Forms.TextBox txtpatientheight;
		internal System.Windows.Forms.Label Label15;
		internal System.Windows.Forms.TextBox txtpatientweight;
		internal System.Windows.Forms.Label Label16;
		internal System.Windows.Forms.TextBox txtpatientbmi;
		internal System.Windows.Forms.Label Label17;
		internal System.Windows.Forms.TextBox txtpatientnextofkin;
		internal System.Windows.Forms.Label Label18;
		internal System.Windows.Forms.TextBox txtpatientnextofkinaddress;
		internal System.Windows.Forms.Label Label19;
		internal System.Windows.Forms.TextBox txtpatientnextofkinrelationship;
		internal System.Windows.Forms.Label Label20;
		internal System.Windows.Forms.TextBox txtdoctorname;
		internal System.Windows.Forms.Label Label21;
		internal System.Windows.Forms.TextBox txthospital;
		internal System.Windows.Forms.Label Label22;
		internal System.Windows.Forms.TextBox txtdoctorphonenumber;
		internal System.Windows.Forms.Label Label23;
		internal System.Windows.Forms.RichTextBox txtpatientallergies;
		internal System.Windows.Forms.Label Label24;
		internal System.Windows.Forms.TextBox txtpatientcomplaint;
		internal System.Windows.Forms.Label Label25;
		internal System.Windows.Forms.TextBox txtpatienttreatment;
		internal System.Windows.Forms.Label Label26;
		internal System.Windows.Forms.TextBox txtpatientplan;
		internal System.Windows.Forms.Button Button1;
		internal System.Windows.Forms.Button Button2;
	}

}