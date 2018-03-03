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
			string salutation = Cbox_salutation.Text;
			string mainText = Rtb_mainText.Text;
			string signature = Cbx_signature.Text;
			

			if (tabControl1.SelectedTab.Text == "Allgemein")
			{
				ErrorList errorList = new ErrorList();
				if (date == string.Empty)
				{
					errorList.AddError("Bitte ein Datum angeben (Standard ist heutiges Datum)!");
				}
				else
				{
					Console.WriteLine(date);
				}
				if (company == string.Empty)
				{
					errorList.AddError("Beim Empfänger fehlt die Firma.");
				}
				else
				{
					Console.WriteLine(company);
				}
				if (contactPerson == string.Empty)
				{
					errorList.AddError("Beim Empfänger fehlt der Ansprechpartner.");
				}
				else
				{
					Console.WriteLine(contactPerson);
				}
				if (street == string.Empty)
				{
					errorList.AddError("Beim Empfänger fehlt die Straße!");
				}
				else
				{
					Console.WriteLine(street);
				}
				if (houseNumber == string.Empty)
				{
					errorList.AddError("Beim Empfänger fehlt die Hausnummer!");
				}
				else
				{
					Console.WriteLine(houseNumber);
				}
				if (postcode == string.Empty)
				{
					errorList.AddError("Beim Empfänger fehlt die PLZ!");
				}
				else
				{
					Console.WriteLine(postcode);
				}
				if (cityRecipient == string.Empty)
				{
					errorList.AddError("Beim Empfänger fehlt die Stadt!");
				}
				else
				{
					Console.WriteLine(cityRecipient);
				}
				if (citySender == string.Empty)
				{
					errorList.AddError("Beim Absender fehlt die Stadt!");
				}
				else
				{
					Console.WriteLine(citySender);
				}
				if (subject == string.Empty)
				{
					errorList.AddError("Es fehlt eine Betreffzeile!");
				}
				else
				{
					Console.WriteLine(subject);
				}
				if (salutation == string.Empty)
				{
					errorList.AddError("Die Anrede ist leer!");
				}
				else
				{
					Console.WriteLine(salutation);
				}
				if (mainText == string.Empty)
				{
					errorList.AddError("Der Hauptteil ist leer!");
				}
				else
				{
					Console.WriteLine(mainText);
				}
				if (signature == string.Empty)
				{
					errorList.AddError("Es fehlt eine Grußformel!");
				}
				else
				{
					Console.WriteLine(signature);
				}
				errorList.ShowList();

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
			ErrorList errorList = new ErrorList();
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
				errorList.AddError("test");
				//MessageBox.Show("Welche digitale Unterschrift soll ich denn einfügen?\r\nBitte eine Signatur im \"Grußformel\"-Bereich auswählen!");
				chkbx_addSignature.Checked = false;
			}
			errorList.ShowList();
			
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

		private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (tabControl1.SelectedTab.Text == "Allgemein")
			{
				Btn_generateDocument.Text = "Dokument erstellen";
			}
			else if (tabControl1.SelectedTab.Text == "Rechnung")
			{
				Btn_generateDocument.Text = "Rechnung erstellen";
			}
			else if (tabControl1.SelectedTab.Text == "Angebot")
			{
				Btn_generateDocument.Text = "Angebot erstellen";
			}
			else if (tabControl1.SelectedTab.Text == "Gehaltsabrechnung")
			{
				Btn_generateDocument.Text = "Gehaltsabrechnung erstellen";
			}
		}
	}
}
