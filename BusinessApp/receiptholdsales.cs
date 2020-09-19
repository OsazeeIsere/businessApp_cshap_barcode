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

using System.Runtime.InteropServices;
using System.Drawing.Printing;
using MySql.Data.MySqlClient;
namespace BusinessApp
{
	public partial class receiptholdsales
	{
		internal receiptholdsales()
		{
			InitializeComponent();
		}

		private System.Data.DataTable getdatabase(string strcommand)
		{
			System.Data.DataTable tempgetdatabase = null;
			tempgetdatabase = new System.Data.DataTable();
			MySqlConnection cn = new MySqlConnection();
			MySqlDataAdapter ad = new MySqlDataAdapter();
			MySqlCommand cm = new MySqlCommand();
			string strconnection = "";
			strconnection = "Server=localhost;Port=3306;Database=businessdatabase;Uid=root;Pwd=prayer;";
			cn.ConnectionString = strconnection;
			cn.Open();
			cm.CommandText = strcommand;
			ad.SelectCommand = cm;
			cm.Connection = cn;
			System.Data.DataTable dt = new System.Data.DataTable();
			ad.Fill(dt);
			tempgetdatabase = dt;
			cn.Close();
			return tempgetdatabase;
		}
		private void receiptholdsales_Load(object sender, System.EventArgs e)
		{
			try
			{
                DataTable dtidentity = new DataTable();
                dtidentity = getdatabase("Select * from identity");

                lbname.Text = dtidentity.Rows[0]["businessName"].ToString();
                lbaddress.Text = dtidentity.Rows[0]["address"].ToString();
                lbtel.Text = dtidentity.Rows[0]["telephone"].ToString();
                System.Data.DataTable dtgetsales = new System.Data.DataTable();
				dtgetsales = getdatabase("select quantitysold,itemsold,unitprice,amount from holdsales order by itemsold");
				if (dtgetsales.Rows.Count > 0)
				{
					ListViewItem lstitem = new ListViewItem();
					lsvitems.Items.Clear();

					for (var i = 0; i < dtgetsales.Rows.Count; i++)
					{
						lstitem = new ListViewItem();
						lstitem.Text = dtgetsales.Rows[i]["itemsold"].ToString();
						lstitem.SubItems.Add(dtgetsales.Rows[i]["quantitysold"].ToString());
						lstitem.SubItems.Add(dtgetsales.Rows[i]["unitprice"].ToString());
						lstitem.SubItems.Add(dtgetsales.Rows[i]["amount"].ToString());
						lsvitems.Items.Add(lstitem);
					}
				}
                System.Data.DataTable dtgetreceipt = new System.Data.DataTable();
                dtgetreceipt = getdatabase("select * from receipt");

                if (dtgetreceipt.Rows.Count > 0)
                {
                    txtreceiptnumber.Text = dtgetreceipt.Rows.Count.ToString();
                }
                txtcashiername1.Text = txtcashiername1.Text;
				string time1 = null;
                time1 = DateTime.Now.ToShortTimeString();
                txttime.Text = time1;
				// insert Copyright symbol
				lbcopyright.Text = "Copyright " + Microsoft.VisualBasic.Strings.Chr(169) + "2020 Nozeme Concepts(08163775990)";


			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void Button3_Click(object sender, System.EventArgs e)
		{
			PrintDocument1.Print();
		}

		private void PrintDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
		{
			try
			{
				Font font = new Font("arial", 8F, FontStyle.Bold);
				Font fontx = new Font("arial", 7F, FontStyle.Bold);
				Font font1 = new Font("arial", 7F, FontStyle.Regular);
				Font font2 = new Font("arial", 7F, FontStyle.Regular);
				Font font3 = new Font("arial", 8F, FontStyle.Regular);
				e.Graphics.DrawString(lbaddress.Text, font, Brushes.Black, 1, 20);
				e.Graphics.DrawString(lbname.Text, font1, Brushes.Black, 1, 35);
				e.Graphics.DrawString(lbtel.Text, fontx, Brushes.Black, 6, 50);
				e.Graphics.DrawString(Label3.Text, font2, Brushes.Black, 2, 65);
				e.Graphics.DrawString(txtcashiername1.Text, font3, Brushes.Black, 60, 65);
				e.Graphics.DrawString(Label5.Text, font2, Brushes.Black, 120, 65);
				e.Graphics.DrawString(txttime.Text, font2, Brushes.Black, 145, 65);
				e.Graphics.DrawString(Label4.Text, font2, Brushes.Black, 2, 80);
				e.Graphics.DrawString(txtreceiptnumber.Text, font3, Brushes.Black, 60, 80);
				e.Graphics.DrawString(Label6.Text, font2, Brushes.Black, 100, 80);
				e.Graphics.DrawString(DateTimePicker1.Value.Date.ToString (), font2, Brushes.Black, 140, 80);
				int j = 100;
				int k = 2;
				Font headerFont = new Font("Arial", 6F, FontStyle.Bold);
				for (var i = 0; i < lsvitems.Items.Count; i++)
				{
					j = j + 15;
					foreach (ColumnHeader ch in lsvitems.Columns)
					{
						e.Graphics.DrawString(ch.Text, headerFont, Brushes.Black, k, j);
						k = k + 70;
					}
					string intlistname = lsvitems.Items[i].Text;
					e.Graphics.DrawString(intlistname, font2, Brushes.Black, 2, j + 15);
					int intlistquantity = Convert.ToInt32(lsvitems.Items[i].SubItems[1].Text);
					e.Graphics.DrawString(intlistquantity.ToString(), font2, Brushes.Black, 110, j);
					//e.Graphics.DrawString(ch., headerFont, Brushes.Black, 50, j + 15)
					double dblunitprice = Convert.ToDouble(lsvitems.Items[i].SubItems[2].Text);
					e.Graphics.DrawString(dblunitprice.ToString(), font2, Brushes.Black, 185, j);
					//e.Graphics.DrawString(ch.Text, headerFont, Brushes.Black, 140, j + 15)
					double dblamount = Convert.ToDouble(lsvitems.Items[i].SubItems[3].Text);
					e.Graphics.DrawString(dblamount.ToString(), font2, Brushes.Black, 250, j);
					j = j + 15;
					k = 2;
				}
				j = j + 30;
				Pen mypen = null;
				mypen = new Pen(Color.Black, Height =50);
				e.Graphics.DrawLine(mypen, x1:10, y1:j, x2:200, y2:j);
				j = j + 20;
				e.Graphics.DrawString(Label7.Text, font3, Brushes.Black, 100, j);
				e.Graphics.DrawString(Label13.Text, font2, Brushes.Black, 160, j);
				e.Graphics.DrawString(txttotal.Text, font3, Brushes.Black, 210, j);
				e.Graphics.DrawString(Label8.Text, font2, Brushes.Black, 100, j + 20);
				e.Graphics.DrawString(Label14.Text, font2, Brushes.Black, 160, j + 20);
				e.Graphics.DrawString(txtcash.Text, font3, Brushes.Black, 210, j + 20);
				e.Graphics.DrawString(Label16.Text, font2, Brushes.Black, 100, j + 40);
				e.Graphics.DrawString(Label17.Text, font2, Brushes.Black, 160, j + 40);
				e.Graphics.DrawString(txtdiscount1.Text, font3, Brushes.Black, 210, j + 40);
				e.Graphics.DrawString(Label9.Text, font2, Brushes.Black, 100, j + 60);
				e.Graphics.DrawString(Label15.Text, font2, Brushes.Black, 160, j + 60);
				e.Graphics.DrawString(txtchange.Text, font3, Brushes.Black, 210, j + 60);
				//e.Graphics.DrawString(Label10.Text, font, Brushes.Black, 60, j + 80)
				e.Graphics.DrawString(Label11.Text, font2, Brushes.Black, 40, j + 90);
				e.Graphics.DrawString(Label12.Text, font2, Brushes.Black, 30, j + 100);
				e.Graphics.DrawString(lbcopyright.Text, font2, Brushes.Black, 1, j + 110);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void Button1_Click(object sender, System.EventArgs e)
		{

			try
			{
				MySqlConnection cn = new MySqlConnection();
				MySqlDataAdapter ad = new MySqlDataAdapter();
				MySqlCommand cm = new MySqlCommand();
				System.Data.DataTable dtgetsales = new System.Data.DataTable();
				dtgetsales = getdatabase("Select* from holdsales");
				string strconnection = "";
				strconnection = "server= localhost;port=3306;database=businessdatabase;uid=root;pwd=prayer";
				cn.ConnectionString = strconnection;
				cn.Open();
				cm.CommandText = "Delete from holdsales where transactionid>0";
				cm.Connection = cn;
				cm.ExecuteNonQuery();
				txttotal.Text = "";
				txtcash.Text = "";
				txtchange.Text = "";
				txtreceiptnumber.Text = "";
				txtdiscount1.Text = "";
				sales x = new sales();
				x.discount = 0;
				lsvitems.Clear();
                this.Close();
                MessageBox.Show("Well done! Just CLICK ON THE FORM to get update from the Database.");

            }
            catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}
	}
}