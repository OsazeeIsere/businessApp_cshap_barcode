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

using MySql.Data.MySqlClient;
namespace BusinessApp
{
	public partial class Patient_Database
	{
		internal Patient_Database()
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
			string strconnection1 = "";
			strconnection1 = "Server=localhost;Port=3306;Database=businnessdatabase;Uid=root;Pwd=prayer;";
			cn.ConnectionString = strconnection1;
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
		private void Patient_Database_Load(object sender, System.EventArgs e)
		{
			try
			{
				MySqlConnection cn = new MySqlConnection();
				MySqlDataAdapter ad = new MySqlDataAdapter();
				MySqlCommand cm = new MySqlCommand();
				string strconnection = "";
				int intpatientid = 0;
				strconnection = "server= localhost;port=3306;database=businnessdatabase;uid=root;pwd=prayer";
				cn.ConnectionString = strconnection;
				string newpatientallegies = null;
				string newpatientcomplaint = null;
				string newpatienttreatment = null;
				string newpatientplan = null;
				System.Data.DataTable dtgetcasefile = new System.Data.DataTable();
				dtgetcasefile = getdatabase("select* from casefile");

				dgvpatient.DataSource = dtgetcasefile;
				txttotalnumberofpatient.Text = dtgetcasefile.Rows.Count.ToString();
				//If dgvpatient.SelectedCells(0).Value.ToString <> "" Then
				//    If IsNumeric(dgvpatient.SelectedCells(0).Value.ToString) Then
				//        intpatientid = CInt(dgvpatient.SelectedCells(0).Value)
				//        dtgetcasefile = getdatabase("Select * From casefile where patientid=" & intpatientid)
				//        cn.Open()
				//        newpatientallegies = CInt(dtgetproduct.Rows(0).Item("quantity")) + CInt(txtquantity.Text)
				//        cm.CommandText = "Update casefile Set allergies =" & newpatientallegies & ",complaint=" & newpatientcomplaint & ",treatment=" & newpatienttreatment & ",plan='" & newpatientplan & "' Where patientid=" & intpatientid & ";"
				//        '        cm.Connection = cn
				//        cm.ExecuteNonQuery()
				//        cn.Close()
				//        dgvdrugs.DataSource = getdatabase("Select * From product")
				//        txtquantity.Text = ""
				//        txtunitprice.Text = ""
				//        txtunitcostprice.Text = ""
				//        txtexpirydate.Text = ""
				//    Else
				//        MsgBox("please Select The Product ID")
				//    End If
				//End If
				//Else
				//'Dim intpersonid = CInt(studentinfo.dgvnames.SelectedCells(0).Value)
				//strconnection = "server= localhost;port=3306;database=businnessdatabase;uid=root;pwd=prayer"
				//cn.ConnectionString = strconnection
				//cn.Open()
				//cm.CommandText = "Insert Into casefile(surname,othernames,address,phonenumber,dateofbirth,age,sex,maritalstatus,occupation,religion,height,weight,bmi,nextofkin,nextofkinaddress,relationship,doctor,hospital,doctorphonenumber,allergies,complaint,treatment,plan) Values('" & txtpatientname.Text & "','" & txtpatientothernames.Text & "','" & txtpatientaddress.Text & "','" & txtpatientnumber.Text & "','" & txtpatientdob.Text & "','" & txtpatientage.Text & "','" & cblpatientsex.Text & "','" & cblpatientmaritalstatus.Text & "','" & txtpatientoccupation.Text & "','" & txtpatientreligion.Text & "','" & txtpatientheight.Text & "','" & txtpatientweight.Text & "','" & txtpatientbmi.Text & "','" & txtpatientnextofkin.Text & "','" & txtpatientnextofkinaddress.Text & "','" & txtpatientnextofkinrelationship.Text & "','" & txtdoctorname.Text & "','" & txthospital.Text & "','" & txtdoctorphonenumber.Text & "','" & txtpatientallergies.Text & "','" & txtpatientcomplaint.Text & "','" & txtpatienttreatment.Text & "','" & txtpatientplan.Text & "')"
				//cm.Connection = cn
				//cm.ExecuteNonQuery()
				//cn.Close()
				//MessageBox.Show("The Patient Information is successfully captured")
				// ''computeresult(intpersonid, CDbl(txtscore.Text), cbosubject.Text)
				//dgvdrugs.DataSource = getdatabase("Select * From product")
				//txtproductname.Text = ""
				//txtquantity.Text = ""
				//txtunitprice.Text = ""
				//txtunitcostprice.Text = ""
				//txtexpirydate.Text = ""
				//  End If
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
				string strconnection = "";
				int intpatientid = 0;
				strconnection = "server= localhost;port=3306;database=businnessdatabase;uid=root;pwd=prayer";
				cn.ConnectionString = strconnection;
				string newpatientallegies = null;
				string newpatientcomplaint = null;
				string newpatienttreatment = null;
				string newpatientplan = null;
				System.Data.DataTable dtgetcasefile = new System.Data.DataTable();
				txttotalnumberofpatient.Text = dtgetcasefile.Rows.Count.ToString();
				if (!string.IsNullOrEmpty(dgvpatient.SelectedCells[0].Value.ToString()))
				{
					if (Simulate.IsNumeric(dgvpatient.SelectedCells[0].Value.ToString()))
					{
						intpatientid = Convert.ToInt32(dgvpatient.SelectedCells[0].Value);
						dtgetcasefile = getdatabase("Select * From casefile where patientid=" + intpatientid);
						cn.Open();
						newpatientallegies = dtgetcasefile.Rows[0]["allergies"].ToString() + Convert.ToString(DateTimePicker1.Value.Date).ToString() + (txtpatientallergies1.Text).ToString();
						newpatientcomplaint = dtgetcasefile.Rows[0]["complaint"].ToString() + Convert.ToString(DateTimePicker1.Value.Date).ToString() + (txtpatientcomplaint1.Text).ToString();
						newpatienttreatment = dtgetcasefile.Rows[0]["treatment"].ToString() + Convert.ToString(DateTimePicker1.Value.Date).ToString() + (txtpatienttreatment1.Text).ToString();
						newpatientplan = dtgetcasefile.Rows[0]["plan"].ToString() + Convert.ToString(DateTimePicker1.Value.Date).ToString() + (txtpatientplan1.Text).ToString();
						cm.CommandText = "Update casefile Set allergies ='" + newpatientallegies.ToString() + "',complaint='" + newpatientcomplaint.ToString() + "',treatment='" + newpatienttreatment.ToString() + "',plan='" + newpatientplan.ToString() + "' Where patientid=" + intpatientid + ";";
						cm.Connection = cn;
						cm.ExecuteNonQuery();
						cn.Close();
						dtgetcasefile = getdatabase("Select * From casefile");
						dgvpatient.DataSource = getdatabase("select* from casefile");
						txttotalnumberofpatient.Text = dtgetcasefile.Rows.Count.ToString();
						MessageBox.Show("The Patient Record is Updated");
						txtpatientallergies1.Text = "";
						txtpatientcomplaint1.Text = "";
						txtpatientplan1.Text = "";
						txtpatienttreatment1.Text = "";
					}
					else
					{
						MessageBox.Show("Please Select the Patient's ID");
					}
				}
				else
				{
					MessageBox.Show("Please Select the Patient's ID");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void Button2_Click(object sender, System.EventArgs e)
		{
			try
			{
				MySqlConnection cn = new MySqlConnection();
				MySqlDataAdapter ad = new MySqlDataAdapter();
				MySqlCommand cm = new MySqlCommand();
				string strconnection = "";
				int intpatientid = 0;
				strconnection = "server= localhost;port=3306;database=businnessdatabase;uid=root;pwd=prayer";
				cn.ConnectionString = strconnection;
				System.Data.DataTable dtgetcasefile = new System.Data.DataTable();
				if (!string.IsNullOrEmpty(dgvpatient.SelectedCells[0].Value.ToString()))
				{
					if (Simulate.IsNumeric(dgvpatient.SelectedCells[0].Value.ToString()))
					{
						//intpatientid = Convert.ToInt32(dgvpatient.SelectedCells[0].Value);
						//dtgetcasefile = getdatabase("Select * From casefile where patientid=" + intpatientid);
						// new Old Patient();
						//v.txtpatientname2.Text = dtgetcasefile.Rows[0]["surname"].ToString();
						//v.txtpatientothernames2.Text = dtgetcasefile.Rows[0]["othernames"].ToString();
						//v.txtpatientaddress2.Text = dtgetcasefile.Rows[0]["address"].ToString();
						//v.txtpatientnumber2.Text = dtgetcasefile.Rows[0]["phonenumber"].ToString();
						//v.txtpatientdob2.Text = dtgetcasefile.Rows[0]["dateofbirth"].ToString();
						//v.txtpatientage2.Text = dtgetcasefile.Rows[0]["age"].ToString();
						//v.cblpatientsex2.Text = dtgetcasefile.Rows[0]["sex"].ToString();
						//v.cblpatientmaritalstatus2.Text = dtgetcasefile.Rows[0]["maritalstatus"].ToString();
						//v.txtpatientoccupation2.Text = dtgetcasefile.Rows[0]["occupation"].ToString();
						//v.txtpatientreligion2.Text = dtgetcasefile.Rows[0]["religion"].ToString();
						//v.txtpatientheight2.Text = dtgetcasefile.Rows[0]["height"].ToString();
						//v.txtpatientweight2.Text = dtgetcasefile.Rows[0]["weight"].ToString();
						//v.txtpatientbmi2.Text = dtgetcasefile.Rows[0]["bmi"].ToString();
						//v.txtpatientnextofkin2.Text = dtgetcasefile.Rows[0]["nextofkin"].ToString();
						//v.txtpatientnextofkinaddress2.Text = dtgetcasefile.Rows[0]["nextofkinaddress"].ToString();
						//v.txtpatientnextofkinrelationship2.Text = dtgetcasefile.Rows[0]["relationship"].ToString();
						//v.txtdoctorname2.Text = dtgetcasefile.Rows[0]["doctor"].ToString();
						//v.txtdoctorphonenumber2.Text = dtgetcasefile.Rows[0]["doctorphonenumber"].ToString();
						//v.txthospital2.Text = dtgetcasefile.Rows[0]["hospital"].ToString();
						//v.txtpatientallergies2.Text = dtgetcasefile.Rows[0]["allergies"].ToString();
						//v.txtpatientcomplaint2.Text = dtgetcasefile.Rows[0]["complaint"].ToString();
						//v.txtpatienttreatment2.Text = dtgetcasefile.Rows[0]["treatment"].ToString();
						//v.txtpatientplan2.Text = dtgetcasefile.Rows[0]["plan"].ToString();
						
						//v.ShowDialog();
					}
					else
					{
						MessageBox.Show("Please Select the Patient's ID");
					}
				}
				else
				{
					MessageBox.Show("Please Select the Patient's ID");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}

		}

		private void txtsearch_TextChanged(object sender, System.EventArgs e)
		{
			try
			{
				System.Data.DataTable dtgetpatientdb = new System.Data.DataTable();
				dtgetpatientdb = getdatabase("Select * From casefile Where surname Like '%" + txtsearch.Text + "%' or phonenumber Like '%" + txtsearch.Text + "%' or othernames Like '%" + txtsearch.Text + "%' Order By surname;");
				//dtgetpatientdb = getdatabase("Select * From casefile Where surname Like '%" & txtsearch.Text & "%' Order By surname;")

				dgvpatient.DataSource = dtgetpatientdb;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}
	}
}