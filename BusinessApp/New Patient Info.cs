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
	public partial class PatientInfo
	{
		internal PatientInfo()
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
		private void TextBox1_TextChanged(object sender, System.EventArgs e)
		{

		}

		private void Label2_Click(object sender, System.EventArgs e)
		{

		}

		private void TextBox5_TextChanged(object sender, System.EventArgs e)
		{

		}

		private void Label23_Click(object sender, System.EventArgs e)
		{

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
				if (string.IsNullOrEmpty(txtpatientname.Text))
				{
					MessageBox.Show("Please enter the patient surname");

				}
				else if (string.IsNullOrEmpty(txtpatientothernames.Text))
				{
					MessageBox.Show("Please enter the patient's other names");
				}
				else if (string.IsNullOrEmpty(txtpatientaddress.Text))
				{
					MessageBox.Show("Please enter the patient's address");
				}
				else if (string.IsNullOrEmpty(txtpatientnumber.Text))
				{
					MessageBox.Show("Please enter the patient's phone number");
				}
				else if (string.IsNullOrEmpty(txtpatientdob.Text))
				{
					MessageBox.Show("Please enter the patient's date of birth");
				}
				else if (string.IsNullOrEmpty(txtpatientage.Text))
				{
					MessageBox.Show("Please enter the patient's age");
				}
				else if (string.IsNullOrEmpty(cblpatientsex.Text))
				{
					MessageBox.Show("Please select the patient's sex");
				}
				else if (string.IsNullOrEmpty(cblpatientmaritalstatus.Text))
				{
					MessageBox.Show("Please select the patient's marital status");
				}
				else if (string.IsNullOrEmpty(txtpatientoccupation.Text))
				{
					MessageBox.Show("Please enter the patient's occupation");
				}
				else if (string.IsNullOrEmpty(txtpatientreligion.Text))
				{
					MessageBox.Show("Please enter the patient's religion");
				}
				else if (string.IsNullOrEmpty(txtpatientheight.Text))
				{
					MessageBox.Show("Please enter the patient's height");
				}
				else if (string.IsNullOrEmpty(txtpatientweight.Text))
				{
					MessageBox.Show("Please enter the patient's weight");
				}
				else if (string.IsNullOrEmpty(txtpatientbmi.Text))
				{
					MessageBox.Show("Please enter the patient's BMI");
				}
				else if (string.IsNullOrEmpty(txtpatientnextofkin.Text))
				{
					MessageBox.Show("Please enter the patient's next of kin");
				}
				else if (string.IsNullOrEmpty(txtpatientnextofkinaddress.Text))
				{
					MessageBox.Show("Please enter the patient's next of kin address");
				}
				else if (string.IsNullOrEmpty(txtpatientnextofkinrelationship.Text))
				{
					MessageBox.Show("Please enter the patient's next of kin relationship");
				}
				else if (string.IsNullOrEmpty(txtdoctorname.Text))
				{
					MessageBox.Show("Please enter the doctor's names");
				}
				else if (string.IsNullOrEmpty(txthospital.Text))
				{
					MessageBox.Show("Please enter the hospital's names");
				}
				else if (string.IsNullOrEmpty(txtdoctorphonenumber.Text))
				{
					MessageBox.Show("Please enter the doctor's phone number");
				}
				else if (string.IsNullOrEmpty(txtpatientcomplaint.Text))
				{
					MessageBox.Show("Please enter the patient's complaints");
				}
				else if (string.IsNullOrEmpty(txtpatienttreatment.Text))
				{
					MessageBox.Show("Please enter the patient's recommended treatment");
				}
				else if (string.IsNullOrEmpty(txtpatientplan.Text))
				{
					MessageBox.Show("Please enter the treatment plan for the patient");
				}
				else if (Simulate.IsNumeric(txtpatientnumber.Text) && (txtdoctorphonenumber.Text) != null )
				{
					strconnection = "server= localhost;port=3306;database=businnessdatabase;uid=root;pwd=prayer";
					cn.ConnectionString = strconnection;
					cn.Open();
					cm.CommandText = "Insert Into casefile(surname,othernames,address,phonenumber,dateofbirth,age,sex,maritalstatus,occupation,religion,height,weight,bmi,nextofkin,nextofkinaddress,relationship,doctor,hospital,doctorphonenumber,allergies,complaint,treatment,plan) Values('" + txtpatientname.Text + "','" + txtpatientothernames.Text + "','" + txtpatientaddress.Text + "','" + txtpatientnumber.Text + "','" + txtpatientdob.Text + "','" + txtpatientage.Text + "','" + cblpatientsex.Text + "','" + cblpatientmaritalstatus.Text + "','" + txtpatientoccupation.Text + "','" + txtpatientreligion.Text + "','" + txtpatientheight.Text + "','" + txtpatientweight.Text + "','" + txtpatientbmi.Text + "','" + txtpatientnextofkin.Text + "','" + txtpatientnextofkinaddress.Text + "','" + txtpatientnextofkinrelationship.Text + "','" + txtdoctorname.Text + "','" + txthospital.Text + "','" + txtdoctorphonenumber.Text + "','" + txtpatientallergies.Text + "','" + txtpatientcomplaint.Text + "','" + txtpatienttreatment.Text + "','" + txtpatientplan.Text + "')";
					cm.Connection = cn;
					cm.ExecuteNonQuery();
					cn.Close();
					MessageBox.Show("The Patient Information is successfully captured");
					txtpatientothernames.Text = "";
					txtpatientaddress.Text = "";
					txtpatientnumber.Text = "";
					txtpatientdob.Text = "";
					txtpatientage.Text = "";
					cblpatientsex.Text = "";
					cblpatientmaritalstatus.Text = "";
					txtpatientoccupation.Text = "";
					txtpatientreligion.Text = "";
					txtpatientheight.Text = "";
					txtpatientweight.Text = "";
					txtpatientbmi.Text = "";
					txtpatientnextofkin.Text = "";
					txtpatientnextofkinaddress.Text = "";
					txtpatientnextofkinrelationship.Text = "";
					txthospital.Text = "";
					txtdoctorphonenumber.Text = "";
					txtpatientcomplaint.Text = "";
					txtpatienttreatment.Text = "";
					txtpatientplan.Text = "";
					//'computeresult(intpersonid, CDbl(txtscore.Text), cbosubject.Text)
					//dgvdrugs.DataSource = getdatabase("Select * From product")
					//txtproductname.Text = ""
					//txtquantity.Text = ""
					//txtunitprice.Text = ""
					//txtunitcostprice.Text = ""
					//txtexpirydate.Text = ""
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void DataGridView1_CellContentClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
		{

		}

		private void txtpatienttreatment_TextChanged(object sender, System.EventArgs e)
		{

		}

		private void Button2_Click(object sender, System.EventArgs e)
		{
			Patient_Database X = new Patient_Database();
			X.ShowDialog();
		}

		private void txtpatientallergies_TextChanged(object sender, System.EventArgs e)
		{

		}

		private void PatientInfo_Load(object sender, System.EventArgs e)
		{

		}

		private void txtpatientnextofkin_TextChanged(object sender, System.EventArgs e)
		{

		}

		private void txtpatientnextofkinrelationship_TextChanged(object sender, System.EventArgs e)
		{

		}

		private void Label19_Click(object sender, System.EventArgs e)
		{

		}

		private void Label22_Click(object sender, System.EventArgs e)
		{

		}

		private void txtdoctorphonenumber_TextChanged(object sender, System.EventArgs e)
		{

		}

		private void txtpatientnextofkinaddress_TextChanged(object sender, System.EventArgs e)
		{

		}

		private void Label18_Click(object sender, System.EventArgs e)
		{

		}

		private void Label4_Click(object sender, System.EventArgs e)
		{

		}

		private void Label17_Click(object sender, System.EventArgs e)
		{

		}

		private void cblpatientmaritalstatus_SelectedIndexChanged(object sender, System.EventArgs e)
		{

		}

		private void Label11_Click(object sender, System.EventArgs e)
		{

		}

		private void cblpatientsex_SelectedIndexChanged(object sender, System.EventArgs e)
		{

		}

		private void Label10_Click(object sender, System.EventArgs e)
		{

		}

		private void Label8_Click(object sender, System.EventArgs e)
		{

		}

		private void Label7_Click(object sender, System.EventArgs e)
		{

		}

		private void txtpatientaddress_TextChanged(object sender, System.EventArgs e)
		{

		}

		private void Label6_Click(object sender, System.EventArgs e)
		{

		}

		private void txtpatientothernames_TextChanged(object sender, System.EventArgs e)
		{

		}

		private void Label5_Click(object sender, System.EventArgs e)
		{

		}

		private void txtpatientname_TextChanged(object sender, System.EventArgs e)
		{

		}
	}
}