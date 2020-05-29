//INSTANT C# NOTE: Formerly VB project-level imports:
//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Data;
//using System.Drawing;
//using System.Diagnostics;
//using System.Windows.Forms;
//using System.Linq;
//using System.Xml.Linq;
//using System.Printing;
//using System.ComponentModel;
//namespace BusinessApp
//{
//	[Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
//	public partial class Old_Patient : System.Windows.Forms.Form
//	{
//		//Form overrides dispose to clean up the component list.
//		[System.Diagnostics.DebuggerNonUserCode()]
//		protected override void Dispose(bool disposing)
//		{
//			try
//			{
//				if (disposing && components != null)
//				{
//					components.Dispose();
//				}
//			}
//			finally
//			{
//				base.Dispose(disposing);
//			}
//		}

//		//Required by the Windows Form Designer
//		private System.ComponentModel.IContainer components;

//		//NOTE: The following procedure is required by the Windows Form Designer
//		//It can be modified using the Windows Form Designer.  
//		//Do not modify it using the code editor.
//		[System.Diagnostics.DebuggerStepThrough()]
//		private void InitializeComponent()
//		{
//			this.components = new System.ComponentModel.Container();
//			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Old_Patient));
//			this.PrintForm1 = new System.Printing.(this.components);
//			this.PrintForm2 = new Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(this.components);
//			this.Panel1 = new System.Windows.Forms.Panel();
//			this.Button2 = new System.Windows.Forms.Button();
//			this.Button1 = new System.Windows.Forms.Button();
//			this.txtpatientplan2 = new System.Windows.Forms.TextBox();
//			this.Label26 = new System.Windows.Forms.Label();
//			this.txtpatienttreatment2 = new System.Windows.Forms.TextBox();
//			this.Label25 = new System.Windows.Forms.Label();
//			this.txtpatientcomplaint2 = new System.Windows.Forms.TextBox();
//			this.Label24 = new System.Windows.Forms.Label();
//			this.txtpatientallergies2 = new System.Windows.Forms.RichTextBox();
//			this.Label23 = new System.Windows.Forms.Label();
//			this.txtdoctorphonenumber2 = new System.Windows.Forms.TextBox();
//			this.Label22 = new System.Windows.Forms.Label();
//			this.txthospital2 = new System.Windows.Forms.TextBox();
//			this.Label21 = new System.Windows.Forms.Label();
//			this.txtdoctorname2 = new System.Windows.Forms.TextBox();
//			this.Label20 = new System.Windows.Forms.Label();
//			this.txtpatientnextofkinrelationship2 = new System.Windows.Forms.TextBox();
//			this.Label19 = new System.Windows.Forms.Label();
//			this.txtpatientnextofkinaddress2 = new System.Windows.Forms.TextBox();
//			this.Label18 = new System.Windows.Forms.Label();
//			this.txtpatientnextofkin2 = new System.Windows.Forms.TextBox();
//			this.Label17 = new System.Windows.Forms.Label();
//			this.txtpatientbmi2 = new System.Windows.Forms.TextBox();
//			this.Label16 = new System.Windows.Forms.Label();
//			this.txtpatientweight2 = new System.Windows.Forms.TextBox();
//			this.Label15 = new System.Windows.Forms.Label();
//			this.txtpatientheight2 = new System.Windows.Forms.TextBox();
//			this.Label14 = new System.Windows.Forms.Label();
//			this.txtpatientreligion2 = new System.Windows.Forms.TextBox();
//			this.Label13 = new System.Windows.Forms.Label();
//			this.txtpatientoccupation2 = new System.Windows.Forms.TextBox();
//			this.Label12 = new System.Windows.Forms.Label();
//			this.cblpatientmaritalstatus2 = new System.Windows.Forms.ComboBox();
//			this.Label11 = new System.Windows.Forms.Label();
//			this.cblpatientsex2 = new System.Windows.Forms.ComboBox();
//			this.Label10 = new System.Windows.Forms.Label();
//			this.txtpatientage2 = new System.Windows.Forms.TextBox();
//			this.Label9 = new System.Windows.Forms.Label();
//			this.txtpatientdob2 = new System.Windows.Forms.TextBox();
//			this.Label8 = new System.Windows.Forms.Label();
//			this.txtpatientnumber2 = new System.Windows.Forms.TextBox();
//			this.Label7 = new System.Windows.Forms.Label();
//			this.txtpatientaddress2 = new System.Windows.Forms.TextBox();
//			this.Label6 = new System.Windows.Forms.Label();
//			this.txtpatientothernames2 = new System.Windows.Forms.TextBox();
//			this.Label5 = new System.Windows.Forms.Label();
//			this.txtpatientname2 = new System.Windows.Forms.TextBox();
//			this.Label4 = new System.Windows.Forms.Label();
//			this.Label3 = new System.Windows.Forms.Label();
//			this.Panel1.SuspendLayout();
//			this.SuspendLayout();
//			//
//			//PrintForm1
//			//
//			this.PrintForm1.DocumentName = "document";
//			this.PrintForm1.Form = this;
//			this.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter;
//			this.PrintForm1.PrinterSettings = (System.Drawing.Printing.PrinterSettings)resources.GetObject("PrintForm1.PrinterSettings");
//			this.PrintForm1.PrintFileName = null;
//			//
//			//PrintForm2
//			//
//			this.PrintForm2.DocumentName = "document";
//			this.PrintForm2.Form = this;
//			this.PrintForm2.PrintAction = System.Drawing.Printing.PrintAction.PrintToPreview;
//			this.PrintForm2.PrinterSettings = (System.Drawing.Printing.PrinterSettings)resources.GetObject("PrintForm2.PrinterSettings");
//			this.PrintForm2.PrintFileName = null;
//			//
//			//Panel1
//			//
//			this.Panel1.Controls.Add(this.txtpatientplan2);
//			this.Panel1.Controls.Add(this.Label26);
//			this.Panel1.Controls.Add(this.txtpatienttreatment2);
//			this.Panel1.Controls.Add(this.Label25);
//			this.Panel1.Controls.Add(this.txtpatientcomplaint2);
//			this.Panel1.Controls.Add(this.Label24);
//			this.Panel1.Controls.Add(this.txtpatientallergies2);
//			this.Panel1.Controls.Add(this.Label23);
//			this.Panel1.Controls.Add(this.txtdoctorphonenumber2);
//			this.Panel1.Controls.Add(this.Label22);
//			this.Panel1.Controls.Add(this.txthospital2);
//			this.Panel1.Controls.Add(this.Label21);
//			this.Panel1.Controls.Add(this.txtdoctorname2);
//			this.Panel1.Controls.Add(this.Label20);
//			this.Panel1.Controls.Add(this.txtpatientnextofkinrelationship2);
//			this.Panel1.Controls.Add(this.Label19);
//			this.Panel1.Controls.Add(this.txtpatientnextofkinaddress2);
//			this.Panel1.Controls.Add(this.Label18);
//			this.Panel1.Controls.Add(this.txtpatientnextofkin2);
//			this.Panel1.Controls.Add(this.Label17);
//			this.Panel1.Controls.Add(this.txtpatientbmi2);
//			this.Panel1.Controls.Add(this.Label16);
//			this.Panel1.Controls.Add(this.txtpatientweight2);
//			this.Panel1.Controls.Add(this.Label15);
//			this.Panel1.Controls.Add(this.txtpatientheight2);
//			this.Panel1.Controls.Add(this.Label14);
//			this.Panel1.Controls.Add(this.txtpatientreligion2);
//			this.Panel1.Controls.Add(this.Label13);
//			this.Panel1.Controls.Add(this.txtpatientoccupation2);
//			this.Panel1.Controls.Add(this.Label12);
//			this.Panel1.Controls.Add(this.cblpatientmaritalstatus2);
//			this.Panel1.Controls.Add(this.Label11);
//			this.Panel1.Controls.Add(this.cblpatientsex2);
//			this.Panel1.Controls.Add(this.Label10);
//			this.Panel1.Controls.Add(this.txtpatientage2);
//			this.Panel1.Controls.Add(this.Label9);
//			this.Panel1.Controls.Add(this.txtpatientdob2);
//			this.Panel1.Controls.Add(this.Label8);
//			this.Panel1.Controls.Add(this.txtpatientnumber2);
//			this.Panel1.Controls.Add(this.Label7);
//			this.Panel1.Controls.Add(this.txtpatientaddress2);
//			this.Panel1.Controls.Add(this.Label6);
//			this.Panel1.Controls.Add(this.txtpatientothernames2);
//			this.Panel1.Controls.Add(this.Label5);
//			this.Panel1.Controls.Add(this.txtpatientname2);
//			this.Panel1.Controls.Add(this.Label4);
//			this.Panel1.Controls.Add(this.Label3);
//			this.Panel1.Location = new System.Drawing.Point(6, 6);
//			this.Panel1.Name = "Panel1";
//			this.Panel1.Size = new System.Drawing.Size(1083, 672);
//			this.Panel1.TabIndex = 0;
//			//
//			//Button2
//			//
//			this.Button2.Location = new System.Drawing.Point(794, 702);
//			this.Button2.Name = "Button2";
//			this.Button2.Size = new System.Drawing.Size(135, 32);
//			this.Button2.TabIndex = 149;
//			this.Button2.Text = "Preview Form";
//			this.Button2.UseVisualStyleBackColor = true;
//			//
//			//Button1
//			//
//			this.Button1.Location = new System.Drawing.Point(935, 702);
//			this.Button1.Name = "Button1";
//			this.Button1.Size = new System.Drawing.Size(148, 32);
//			this.Button1.TabIndex = 148;
//			this.Button1.Text = "Print Form";
//			this.Button1.UseVisualStyleBackColor = true;
//			//
//			//txtpatientplan2
//			//
//			this.txtpatientplan2.BackColor = System.Drawing.Color.White;
//			this.txtpatientplan2.Location = new System.Drawing.Point(747, 481);
//			this.txtpatientplan2.Multiline = true;
//			this.txtpatientplan2.Name = "txtpatientplan2";
//			this.txtpatientplan2.ReadOnly = true;
//			this.txtpatientplan2.Size = new System.Drawing.Size(332, 138);
//			this.txtpatientplan2.TabIndex = 147;
//			//
//			//Label26
//			//
//			this.Label26.AutoSize = true;
//			this.Label26.Location = new System.Drawing.Point(682, 481);
//			this.Label26.Name = "Label26";
//			this.Label26.Size = new System.Drawing.Size(50, 20);
//			this.Label26.TabIndex = 146;
//			this.Label26.Text = "PLAN";
//			//
//			//txtpatienttreatment2
//			//
//			this.txtpatienttreatment2.BackColor = System.Drawing.Color.White;
//			this.txtpatienttreatment2.Location = new System.Drawing.Point(188, 563);
//			this.txtpatienttreatment2.Multiline = true;
//			this.txtpatienttreatment2.Name = "txtpatienttreatment2";
//			this.txtpatienttreatment2.ReadOnly = true;
//			this.txtpatienttreatment2.Size = new System.Drawing.Size(466, 92);
//			this.txtpatienttreatment2.TabIndex = 145;
//			//
//			//Label25
//			//
//			this.Label25.AutoSize = true;
//			this.Label25.Location = new System.Drawing.Point(4, 579);
//			this.Label25.Name = "Label25";
//			this.Label25.Size = new System.Drawing.Size(178, 40);
//			this.Label25.TabIndex = 144;
//			this.Label25.Text = "TREATMENT REVIEW " + "\r" + "\n" + "COMMENT/ADR";
//			//
//			//txtpatientcomplaint2
//			//
//			this.txtpatientcomplaint2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
//			this.txtpatientcomplaint2.Location = new System.Drawing.Point(151, 441);
//			this.txtpatientcomplaint2.Multiline = true;
//			this.txtpatientcomplaint2.Name = "txtpatientcomplaint2";
//			this.txtpatientcomplaint2.ReadOnly = true;
//			this.txtpatientcomplaint2.Size = new System.Drawing.Size(325, 96);
//			this.txtpatientcomplaint2.TabIndex = 143;
//			//
//			//Label24
//			//
//			this.Label24.AutoSize = true;
//			this.Label24.Location = new System.Drawing.Point(20, 453);
//			this.Label24.Name = "Label24";
//			this.Label24.Size = new System.Drawing.Size(125, 40);
//			this.Label24.TabIndex = 142;
//			this.Label24.Text = "COMPLAINTS/" + "\r" + "\n" + "OBSERVATION";
//			//
//			//txtpatientallergies2
//			//
//			this.txtpatientallergies2.Location = new System.Drawing.Point(522, 390);
//			this.txtpatientallergies2.Name = "txtpatientallergies2";
//			this.txtpatientallergies2.ReadOnly = true;
//			this.txtpatientallergies2.Size = new System.Drawing.Size(555, 61);
//			this.txtpatientallergies2.TabIndex = 141;
//			this.txtpatientallergies2.Text = "";
//			//
//			//Label23
//			//
//			this.Label23.AutoSize = true;
//			this.Label23.Location = new System.Drawing.Point(415, 396);
//			this.Label23.Name = "Label23";
//			this.Label23.Size = new System.Drawing.Size(101, 20);
//			this.Label23.TabIndex = 140;
//			this.Label23.Text = "ALLERGIES";
//			//
//			//txtdoctorphonenumber2
//			//
//			this.txtdoctorphonenumber2.BackColor = System.Drawing.Color.White;
//			this.txtdoctorphonenumber2.Location = new System.Drawing.Point(210, 390);
//			this.txtdoctorphonenumber2.Name = "txtdoctorphonenumber2";
//			this.txtdoctorphonenumber2.ReadOnly = true;
//			this.txtdoctorphonenumber2.Size = new System.Drawing.Size(165, 26);
//			this.txtdoctorphonenumber2.TabIndex = 139;
//			//
//			//Label22
//			//
//			this.Label22.AutoSize = true;
//			this.Label22.Location = new System.Drawing.Point(18, 390);
//			this.Label22.Name = "Label22";
//			this.Label22.Size = new System.Drawing.Size(175, 20);
//			this.Label22.TabIndex = 138;
//			this.Label22.Text = "DOCTOR'S PHONE No";
//			//
//			//txthospital2
//			//
//			this.txthospital2.BackColor = System.Drawing.Color.White;
//			this.txthospital2.Location = new System.Drawing.Point(837, 342);
//			this.txthospital2.Name = "txthospital2";
//			this.txthospital2.ReadOnly = true;
//			this.txthospital2.Size = new System.Drawing.Size(240, 26);
//			this.txthospital2.TabIndex = 137;
//			//
//			//Label21
//			//
//			this.Label21.AutoSize = true;
//			this.Label21.Location = new System.Drawing.Point(743, 349);
//			this.Label21.Name = "Label21";
//			this.Label21.Size = new System.Drawing.Size(88, 20);
//			this.Label21.TabIndex = 136;
//			this.Label21.Text = "HOSPITAL";
//			//
//			//txtdoctorname2
//			//
//			this.txtdoctorname2.BackColor = System.Drawing.Color.White;
//			this.txtdoctorname2.Location = new System.Drawing.Point(482, 346);
//			this.txtdoctorname2.Name = "txtdoctorname2";
//			this.txtdoctorname2.ReadOnly = true;
//			this.txtdoctorname2.Size = new System.Drawing.Size(224, 26);
//			this.txtdoctorname2.TabIndex = 135;
//			//
//			//Label20
//			//
//			this.Label20.AutoSize = true;
//			this.Label20.Location = new System.Drawing.Point(399, 345);
//			this.Label20.Name = "Label20";
//			this.Label20.Size = new System.Drawing.Size(77, 20);
//			this.Label20.TabIndex = 134;
//			this.Label20.Text = "DOCTOR";
//			//
//			//txtpatientnextofkinrelationship2
//			//
//			this.txtpatientnextofkinrelationship2.BackColor = System.Drawing.Color.White;
//			this.txtpatientnextofkinrelationship2.Location = new System.Drawing.Point(168, 339);
//			this.txtpatientnextofkinrelationship2.Name = "txtpatientnextofkinrelationship2";
//			this.txtpatientnextofkinrelationship2.ReadOnly = true;
//			this.txtpatientnextofkinrelationship2.Size = new System.Drawing.Size(184, 26);
//			this.txtpatientnextofkinrelationship2.TabIndex = 133;
//			//
//			//Label19
//			//
//			this.Label19.AutoSize = true;
//			this.Label19.Location = new System.Drawing.Point(18, 348);
//			this.Label19.Name = "Label19";
//			this.Label19.Size = new System.Drawing.Size(127, 20);
//			this.Label19.TabIndex = 132;
//			this.Label19.Text = "RELATIONSHIP";
//			//
//			//txtpatientnextofkinaddress2
//			//
//			this.txtpatientnextofkinaddress2.BackColor = System.Drawing.Color.White;
//			this.txtpatientnextofkinaddress2.Location = new System.Drawing.Point(563, 293);
//			this.txtpatientnextofkinaddress2.Multiline = true;
//			this.txtpatientnextofkinaddress2.Name = "txtpatientnextofkinaddress2";
//			this.txtpatientnextofkinaddress2.ReadOnly = true;
//			this.txtpatientnextofkinaddress2.Size = new System.Drawing.Size(516, 26);
//			this.txtpatientnextofkinaddress2.TabIndex = 131;
//			//
//			//Label18
//			//
//			this.Label18.AutoSize = true;
//			this.Label18.Location = new System.Drawing.Point(458, 294);
//			this.Label18.Name = "Label18";
//			this.Label18.Size = new System.Drawing.Size(89, 20);
//			this.Label18.TabIndex = 130;
//			this.Label18.Text = "ADDRESS";
//			//
//			//txtpatientnextofkin2
//			//
//			this.txtpatientnextofkin2.BackColor = System.Drawing.Color.White;
//			this.txtpatientnextofkin2.Location = new System.Drawing.Point(166, 293);
//			this.txtpatientnextofkin2.Name = "txtpatientnextofkin2";
//			this.txtpatientnextofkin2.ReadOnly = true;
//			this.txtpatientnextofkin2.Size = new System.Drawing.Size(269, 26);
//			this.txtpatientnextofkin2.TabIndex = 129;
//			//
//			//Label17
//			//
//			this.Label17.AutoSize = true;
//			this.Label17.Location = new System.Drawing.Point(32, 295);
//			this.Label17.Name = "Label17";
//			this.Label17.Size = new System.Drawing.Size(107, 20);
//			this.Label17.TabIndex = 128;
//			this.Label17.Text = "NEXT OF KIN";
//			//
//			//txtpatientbmi2
//			//
//			this.txtpatientbmi2.BackColor = System.Drawing.Color.White;
//			this.txtpatientbmi2.Location = new System.Drawing.Point(1003, 241);
//			this.txtpatientbmi2.Multiline = true;
//			this.txtpatientbmi2.Name = "txtpatientbmi2";
//			this.txtpatientbmi2.ReadOnly = true;
//			this.txtpatientbmi2.Size = new System.Drawing.Size(76, 28);
//			this.txtpatientbmi2.TabIndex = 127;
//			//
//			//Label16
//			//
//			this.Label16.AutoSize = true;
//			this.Label16.Location = new System.Drawing.Point(962, 246);
//			this.Label16.Name = "Label16";
//			this.Label16.Size = new System.Drawing.Size(38, 20);
//			this.Label16.TabIndex = 126;
//			this.Label16.Text = "BMI";
//			//
//			//txtpatientweight2
//			//
//			this.txtpatientweight2.BackColor = System.Drawing.Color.White;
//			this.txtpatientweight2.Location = new System.Drawing.Point(868, 243);
//			this.txtpatientweight2.Name = "txtpatientweight2";
//			this.txtpatientweight2.ReadOnly = true;
//			this.txtpatientweight2.Size = new System.Drawing.Size(73, 26);
//			this.txtpatientweight2.TabIndex = 125;
//			//
//			//Label15
//			//
//			this.Label15.AutoSize = true;
//			this.Label15.Location = new System.Drawing.Point(784, 244);
//			this.Label15.Name = "Label15";
//			this.Label15.Size = new System.Drawing.Size(74, 20);
//			this.Label15.TabIndex = 124;
//			this.Label15.Text = "WEIGHT";
//			//
//			//txtpatientheight2
//			//
//			this.txtpatientheight2.BackColor = System.Drawing.Color.White;
//			this.txtpatientheight2.Location = new System.Drawing.Point(697, 243);
//			this.txtpatientheight2.Name = "txtpatientheight2";
//			this.txtpatientheight2.ReadOnly = true;
//			this.txtpatientheight2.Size = new System.Drawing.Size(62, 26);
//			this.txtpatientheight2.TabIndex = 123;
//			//
//			//Label14
//			//
//			this.Label14.AutoSize = true;
//			this.Label14.Location = new System.Drawing.Point(616, 243);
//			this.Label14.Name = "Label14";
//			this.Label14.Size = new System.Drawing.Size(71, 20);
//			this.Label14.TabIndex = 122;
//			this.Label14.Text = "HEIGHT";
//			//
//			//txtpatientreligion2
//			//
//			this.txtpatientreligion2.BackColor = System.Drawing.Color.White;
//			this.txtpatientreligion2.Location = new System.Drawing.Point(459, 241);
//			this.txtpatientreligion2.Name = "txtpatientreligion2";
//			this.txtpatientreligion2.ReadOnly = true;
//			this.txtpatientreligion2.Size = new System.Drawing.Size(137, 26);
//			this.txtpatientreligion2.TabIndex = 121;
//			//
//			//Label13
//			//
//			this.Label13.AutoSize = true;
//			this.Label13.Location = new System.Drawing.Point(348, 243);
//			this.Label13.Name = "Label13";
//			this.Label13.Size = new System.Drawing.Size(87, 20);
//			this.Label13.TabIndex = 120;
//			this.Label13.Text = "RELIGION";
//			//
//			//txtpatientoccupation2
//			//
//			this.txtpatientoccupation2.BackColor = System.Drawing.Color.White;
//			this.txtpatientoccupation2.Location = new System.Drawing.Point(160, 243);
//			this.txtpatientoccupation2.Name = "txtpatientoccupation2";
//			this.txtpatientoccupation2.ReadOnly = true;
//			this.txtpatientoccupation2.Size = new System.Drawing.Size(154, 26);
//			this.txtpatientoccupation2.TabIndex = 119;
//			//
//			//Label12
//			//
//			this.Label12.AutoSize = true;
//			this.Label12.Location = new System.Drawing.Point(28, 249);
//			this.Label12.Name = "Label12";
//			this.Label12.Size = new System.Drawing.Size(113, 20);
//			this.Label12.TabIndex = 118;
//			this.Label12.Text = "OCCUPATION";
//			//
//			//cblpatientmaritalstatus2
//			//
//			this.cblpatientmaritalstatus2.Location = new System.Drawing.Point(867, 183);
//			this.cblpatientmaritalstatus2.Name = "cblpatientmaritalstatus2";
//			this.cblpatientmaritalstatus2.Size = new System.Drawing.Size(122, 28);
//			this.cblpatientmaritalstatus2.TabIndex = 117;
//			//
//			//Label11
//			//
//			this.Label11.AutoSize = true;
//			this.Label11.Location = new System.Drawing.Point(709, 190);
//			this.Label11.Name = "Label11";
//			this.Label11.Size = new System.Drawing.Size(146, 20);
//			this.Label11.TabIndex = 116;
//			this.Label11.Text = "MARITAL STATUS";
//			//
//			//cblpatientsex2
//			//
//			this.cblpatientsex2.Location = new System.Drawing.Point(596, 186);
//			this.cblpatientsex2.Name = "cblpatientsex2";
//			this.cblpatientsex2.Size = new System.Drawing.Size(87, 28);
//			this.cblpatientsex2.TabIndex = 115;
//			//
//			//Label10
//			//
//			this.Label10.AutoSize = true;
//			this.Label10.Location = new System.Drawing.Point(548, 190);
//			this.Label10.Name = "Label10";
//			this.Label10.Size = new System.Drawing.Size(42, 20);
//			this.Label10.TabIndex = 114;
//			this.Label10.Text = "SEX";
//			//
//			//txtpatientage2
//			//
//			this.txtpatientage2.BackColor = System.Drawing.Color.White;
//			this.txtpatientage2.Location = new System.Drawing.Point(411, 185);
//			this.txtpatientage2.Name = "txtpatientage2";
//			this.txtpatientage2.ReadOnly = true;
//			this.txtpatientage2.Size = new System.Drawing.Size(95, 26);
//			this.txtpatientage2.TabIndex = 113;
//			//
//			//Label9
//			//
//			this.Label9.AutoSize = true;
//			this.Label9.Location = new System.Drawing.Point(361, 189);
//			this.Label9.Name = "Label9";
//			this.Label9.Size = new System.Drawing.Size(44, 20);
//			this.Label9.TabIndex = 112;
//			this.Label9.Text = "AGE";
//			//
//			//txtpatientdob2
//			//
//			this.txtpatientdob2.BackColor = System.Drawing.Color.White;
//			this.txtpatientdob2.Location = new System.Drawing.Point(155, 187);
//			this.txtpatientdob2.Name = "txtpatientdob2";
//			this.txtpatientdob2.ReadOnly = true;
//			this.txtpatientdob2.Size = new System.Drawing.Size(160, 26);
//			this.txtpatientdob2.TabIndex = 111;
//			//
//			//Label8
//			//
//			this.Label8.AutoSize = true;
//			this.Label8.Location = new System.Drawing.Point(18, 185);
//			this.Label8.Name = "Label8";
//			this.Label8.Size = new System.Drawing.Size(122, 20);
//			this.Label8.TabIndex = 110;
//			this.Label8.Text = "DATE OF BIRH";
//			//
//			//txtpatientnumber2
//			//
//			this.txtpatientnumber2.BackColor = System.Drawing.Color.White;
//			this.txtpatientnumber2.Location = new System.Drawing.Point(852, 118);
//			this.txtpatientnumber2.Name = "txtpatientnumber2";
//			this.txtpatientnumber2.ReadOnly = true;
//			this.txtpatientnumber2.Size = new System.Drawing.Size(227, 26);
//			this.txtpatientnumber2.TabIndex = 109;
//			//
//			//Label7
//			//
//			this.Label7.AutoSize = true;
//			this.Label7.Location = new System.Drawing.Point(703, 124);
//			this.Label7.Name = "Label7";
//			this.Label7.Size = new System.Drawing.Size(143, 20);
//			this.Label7.TabIndex = 108;
//			this.Label7.Text = "PHONE NUMBER:";
//			//
//			//txtpatientaddress2
//			//
//			this.txtpatientaddress2.BackColor = System.Drawing.Color.White;
//			this.txtpatientaddress2.Location = new System.Drawing.Point(127, 121);
//			this.txtpatientaddress2.Multiline = true;
//			this.txtpatientaddress2.Name = "txtpatientaddress2";
//			this.txtpatientaddress2.ReadOnly = true;
//			this.txtpatientaddress2.Size = new System.Drawing.Size(546, 35);
//			this.txtpatientaddress2.TabIndex = 107;
//			//
//			//Label6
//			//
//			this.Label6.AutoSize = true;
//			this.Label6.Location = new System.Drawing.Point(28, 117);
//			this.Label6.Name = "Label6";
//			this.Label6.Size = new System.Drawing.Size(89, 20);
//			this.Label6.TabIndex = 106;
//			this.Label6.Text = "ADDRESS";
//			//
//			//txtpatientothernames2
//			//
//			this.txtpatientothernames2.BackColor = System.Drawing.Color.White;
//			this.txtpatientothernames2.Location = new System.Drawing.Point(478, 70);
//			this.txtpatientothernames2.Name = "txtpatientothernames2";
//			this.txtpatientothernames2.ReadOnly = true;
//			this.txtpatientothernames2.Size = new System.Drawing.Size(195, 26);
//			this.txtpatientothernames2.TabIndex = 105;
//			//
//			//Label5
//			//
//			this.Label5.AutoSize = true;
//			this.Label5.Location = new System.Drawing.Point(348, 73);
//			this.Label5.Name = "Label5";
//			this.Label5.Size = new System.Drawing.Size(122, 20);
//			this.Label5.TabIndex = 104;
//			this.Label5.Text = "OTHERNAMES";
//			//
//			//txtpatientname2
//			//
//			this.txtpatientname2.BackColor = System.Drawing.Color.White;
//			this.txtpatientname2.Location = new System.Drawing.Point(124, 72);
//			this.txtpatientname2.Name = "txtpatientname2";
//			this.txtpatientname2.ReadOnly = true;
//			this.txtpatientname2.Size = new System.Drawing.Size(163, 26);
//			this.txtpatientname2.TabIndex = 103;
//			//
//			//Label4
//			//
//			this.Label4.AutoSize = true;
//			this.Label4.Location = new System.Drawing.Point(28, 75);
//			this.Label4.Name = "Label4";
//			this.Label4.Size = new System.Drawing.Size(90, 20);
//			this.Label4.TabIndex = 102;
//			this.Label4.Text = "SURNAME";
//			//
//			//Label3
//			//
//			this.Label3.AutoSize = true;
//			this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
//			this.Label3.Location = new System.Drawing.Point(422, 15);
//			this.Label3.Name = "Label3";
//			this.Label3.Size = new System.Drawing.Size(247, 29);
//			this.Label3.TabIndex = 101;
//			this.Label3.Text = "PATIENT'S  DETAILS";
//			//
//			//Old_Patient
//			//
//			this.AutoScaleDimensions = new System.Drawing.SizeF(9.0F, 20.0F);
//			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
//			this.BackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(255)), Convert.ToInt32(Convert.ToByte(192)), Convert.ToInt32(Convert.ToByte(128)));
//			this.ClientSize = new System.Drawing.Size(1098, 768);
//			this.Controls.Add(this.Button2);
//			this.Controls.Add(this.Panel1);
//			this.Controls.Add(this.Button1);
//			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
//			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
//			this.Name = "Old_Patient";
//			this.Text = "Old Patient Info.";
//			this.Panel1.ResumeLayout(false);
//			this.Panel1.PerformLayout();
//			this.ResumeLayout(false);

////INSTANT C# NOTE: Converted design-time event handler wireups:
//			base.Load += new System.EventHandler(Old_Patient_Load);
//			Button2.Click += new System.EventHandler(Button2_Click_1);
//			Button1.Click += new System.EventHandler(Button1_Click_1);
//		}
//		internal Microsoft.VisualBasic.PowerPacks.Printing.PrintForm PrintForm1;
//		internal Microsoft.VisualBasic.PowerPacks.Printing.PrintForm PrintForm2;
//		internal System.Windows.Forms.Panel Panel1;
//		internal System.Windows.Forms.Button Button2;
//		internal System.Windows.Forms.Button Button1;
//		internal System.Windows.Forms.TextBox txtpatientplan2;
//		internal System.Windows.Forms.Label Label26;
//		internal System.Windows.Forms.TextBox txtpatienttreatment2;
//		internal System.Windows.Forms.Label Label25;
//		internal System.Windows.Forms.TextBox txtpatientcomplaint2;
//		internal System.Windows.Forms.Label Label24;
//		internal System.Windows.Forms.RichTextBox txtpatientallergies2;
//		internal System.Windows.Forms.Label Label23;
//		internal System.Windows.Forms.TextBox txtdoctorphonenumber2;
//		internal System.Windows.Forms.Label Label22;
//		internal System.Windows.Forms.TextBox txthospital2;
//		internal System.Windows.Forms.Label Label21;
//		internal System.Windows.Forms.TextBox txtdoctorname2;
//		internal System.Windows.Forms.Label Label20;
//		internal System.Windows.Forms.TextBox txtpatientnextofkinrelationship2;
//		internal System.Windows.Forms.Label Label19;
//		internal System.Windows.Forms.TextBox txtpatientnextofkinaddress2;
//		internal System.Windows.Forms.Label Label18;
//		internal System.Windows.Forms.TextBox txtpatientnextofkin2;
//		internal System.Windows.Forms.Label Label17;
//		internal System.Windows.Forms.TextBox txtpatientbmi2;
//		internal System.Windows.Forms.Label Label16;
//		internal System.Windows.Forms.TextBox txtpatientweight2;
//		internal System.Windows.Forms.Label Label15;
//		internal System.Windows.Forms.TextBox txtpatientheight2;
//		internal System.Windows.Forms.Label Label14;
//		internal System.Windows.Forms.TextBox txtpatientreligion2;
//		internal System.Windows.Forms.Label Label13;
//		internal System.Windows.Forms.TextBox txtpatientoccupation2;
//		internal System.Windows.Forms.Label Label12;
//		internal System.Windows.Forms.ComboBox cblpatientmaritalstatus2;
//		internal System.Windows.Forms.Label Label11;
//		internal System.Windows.Forms.ComboBox cblpatientsex2;
//		internal System.Windows.Forms.Label Label10;
//		internal System.Windows.Forms.TextBox txtpatientage2;
//		internal System.Windows.Forms.Label Label9;
//		internal System.Windows.Forms.TextBox txtpatientdob2;
//		internal System.Windows.Forms.Label Label8;
//		internal System.Windows.Forms.TextBox txtpatientnumber2;
//		internal System.Windows.Forms.Label Label7;
//		internal System.Windows.Forms.TextBox txtpatientaddress2;
//		internal System.Windows.Forms.Label Label6;
//		internal System.Windows.Forms.TextBox txtpatientothernames2;
//		internal System.Windows.Forms.Label Label5;
//		internal System.Windows.Forms.TextBox txtpatientname2;
//		internal System.Windows.Forms.Label Label4;
//		internal System.Windows.Forms.Label Label3;
//	}

//}