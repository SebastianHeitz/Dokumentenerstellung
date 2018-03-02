using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dokumentenerstellung
{
	public partial class MainWindow : Form
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void Btn_generateDocument_Click(object sender, EventArgs e)
		{
			string date = dateTimePicker1.Value.ToShortDateString();
			string company = tbx_company.Text;
			string contactPerson = tbx_contactPerson.Text;
			string street = tbx_street.Text;
			string houseNumber = tbx_houseNumber.Text;
			string postcode = tbx_postcode.Text;
			string cityRecipient = tbx_cityRecipient.Text;
			string subject = Tbx_subject.Text;
			string citySender = Tbx_citySender.Text;

			if (date == string.Empty)
			{
				MessageBox.Show("Bitte ein Datum angeben (Standard ist heutiges Datum)!");
			}
			else
			{
				Console.WriteLine(date);
			}
			if (company == string.Empty)
			{
				MessageBox.Show("Beim Empfänger fehlt die Firma!");
			}
			else
			{
				Console.WriteLine(company);
			}
			if (contactPerson == string.Empty)
			{
				MessageBox.Show("Es fehlt ein Ansprechpartner!");
			}
			else
			{
				Console.WriteLine(contactPerson);
			}
			if (street == string.Empty)
			{
				MessageBox.Show("Beim Empfänger fehlt die Straße!");
			}
			else
			{
				Console.WriteLine(street);
			}
			if (houseNumber == string.Empty)
			{
				MessageBox.Show("Beim Empfänger fehlt die Hausnummer!");
			}
			else
			{
				Console.WriteLine(houseNumber);
			}
			if (postcode == string.Empty)
			{
				MessageBox.Show("Beim Empfänger fehlt die PLZ!");
			}
			else
			{
				Console.WriteLine(postcode);
			}
			if (cityRecipient == string.Empty)
			{
				MessageBox.Show("Beim Empfänger fehlt die Stadt!");
			}
			else
			{
				Console.WriteLine(cityRecipient);
			}
		}

		private void addDigitalSignature()
		{
			if (pbx_digitalSignature.Visible)
			{
				pbx_digitalSignature.Visible = false;
			}
			else
			{
				pbx_digitalSignature.Visible = true;
			}
		}

		private void chkbx_addSignature_CheckedChanged(object sender, EventArgs e)
		{
			if (Cbx_signature.Text == "Ralf Risse")
			{
				addDigitalSignature();
				pbx_digitalSignature.Image = Properties.Resources.Unterschrift_Ralf_Risse;
				//pbx_digitalSignature.Visible = true;
			}
			else if (Cbx_signature.Text == "Ute Heitz")
			{
				addDigitalSignature();
				pbx_digitalSignature.Image = Properties.Resources.Unterschrift_Ute_Heitz;
				//pbx_digitalSignature.Visible = true;
			}
			else
			{
				chkbx_addSignature.Checked = false;
				MessageBox.Show("Welche digitale Unterschrift soll ich denn einfügen?\r\nBitte eine Signatur im \"Grußformel\"-Bereich auswählen!");
			}
			
		}

		private void Cbox_salutation_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (Cbox_salutation.Text == "Herr")
			{
				Lbl_salutation.Text = "Sehr geehrter ";
			}
			if (Cbox_salutation.Text == "Frau" | Cbox_salutation.Text == "Damen und Herren")
			{
				Lbl_salutation.Text = "Sehr geehrte ";
			}
		}
	}
}
