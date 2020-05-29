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

//namespace BusinessApp
//{
//	public partial class Old_Patient
//	{

//		internal Old_Patient()
//		{
//			InitializeComponent();
//		}

//		private void Old_Patient_Load(object sender, System.EventArgs e)
//		{
//			this.AutoScroll = true;

//		}

//		private void Button1_Click(object sender, System.EventArgs e)
//		{


//		}

//		private void Button2_Click(object sender, System.EventArgs e)
//		{

//		}

//		private void Button2_Click_1(object sender, System.EventArgs e)
//		{
//			PrintForm2.Print();
//		}

//		private void Button1_Click_1(object sender, System.EventArgs e)
//		{
//			//PrintForm1.Print(Me, PowerPacks.Printing.PrintForm.PrintOption.ClientAreaOnly)
//			Panel1.Height = 900; //my screen hight is only 768 (1024x768) Panel1.Height = 900 'my screen hight is only 768 (1024x768)
//			Rectangle r = new Rectangle(0, 0, Panel1.Width, Panel1.Height); //make the bitmap hight larger if you need space at the bottom
//			using (Bitmap bm = new Bitmap(Panel1.Width, Panel1.Height))
//			{
//				Panel1.DrawToBitmap(bm, r);
//				//you can print the image instead of saving it to the hard drive. this was for testing
//				bm.Save("C:\\Users\\oz\\Desktop\\testfolder\\pnlimage.png", System.Drawing.Imaging.ImageFormat.Png);
//				MessageBox.Show("Form Saved Successfully");
//			}
//			this.AutoScroll = true;
//			Button1.Show();
//		}
//	}
//}