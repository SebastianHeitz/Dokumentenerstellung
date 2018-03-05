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

		//public Dictionary<string, string> FetchDocumentData()
		//{
		//	ErrorList errorList = new ErrorList();
		//	Dictionary<string, string> documentData = new Dictionary<string, string>();
		//	string date = dateTimePicker1.Value.ToShortDateString();
		//	string company = tbx_company.Text;
		//	string contactPerson = tbx_contactPerson.Text;
		//	string street = tbx_street.Text;
		//	string houseNumber = tbx_houseNumber.Text;
		//	string postcode = tbx_postcode.Text;
		//	string cityRecipient = tbx_cityRecipient.Text;
		//	string subject = Tbx_subject.Text;
		//	string citySender = Tbx_citySender.Text;
		//	string salutation = Cbox_salutation.Text;
		//	string mainText = Rtb_mainText.Text;
		//	string signature = Cbx_signature.Text;

		//	if (tabControl1.SelectedTab.Text == "Allgemein")
		//	{
		//		if (date == string.Empty)
		//		{
		//			errorList.AddError("Bitte ein Datum angeben (Standard ist heutiges Datum)!");
		//		}
		//		else
		//		{
		//			documentData.Add("date", date);
		//		}
		//		if (company == string.Empty)
		//		{
		//			errorList.AddError("Beim Empfänger fehlt die Firma.");
		//		}
		//		else
		//		{
		//			documentData.Add("company", company);
		//		}
		//		if (contactPerson == string.Empty)
		//		{
		//			errorList.AddError("Beim Empfänger fehlt der Ansprechpartner.");
		//		}
		//		else
		//		{
		//			documentData.Add("contactPerson", contactPerson);
		//		}
		//		if (street == string.Empty)
		//		{
		//			errorList.AddError("Beim Empfänger fehlt die Straße!");
		//		}
		//		else
		//		{
		//			documentData.Add("street", street);
		//		}
		//		if (houseNumber == string.Empty)
		//		{
		//			errorList.AddError("Beim Empfänger fehlt die Hausnummer!");
		//		}
		//		else
		//		{
		//			documentData.Add("houseNumber", houseNumber);
		//		}
		//		if (postcode == string.Empty)
		//		{
		//			errorList.AddError("Beim Empfänger fehlt die PLZ!");
		//		}
		//		else
		//		{
		//			documentData.Add("postcode", postcode);
		//		}
		//		if (cityRecipient == string.Empty)
		//		{
		//			errorList.AddError("Beim Empfänger fehlt die Stadt!");
		//		}
		//		else
		//		{
		//			documentData.Add("cityRecipient", cityRecipient);
		//		}
		//		if (citySender == string.Empty)
		//		{
		//			errorList.AddError("Beim Absender fehlt die Stadt!");
		//		}
		//		else
		//		{
		//			documentData.Add("citySender", citySender);
		//		}
		//		if (subject == string.Empty)
		//		{
		//			errorList.AddError("Es fehlt eine Betreffzeile!");
		//		}
		//		else
		//		{
		//			documentData.Add("subject", subject);
		//		}
		//		if (salutation == string.Empty)
		//		{
		//			errorList.AddError("Die Anrede ist leer!");
		//		}
		//		else
		//		{
		//			documentData.Add("salutation", salutation);
		//		}
		//		if (mainText == string.Empty)
		//		{
		//			errorList.AddError("Der Hauptteil ist leer!");
		//		}
		//		else
		//		{
		//			documentData.Add("mainText", mainText);
		//		}
		//		if (signature == string.Empty)
		//		{
		//			errorList.AddError("Es fehlt eine Grußformel!");
		//		}
		//		else
		//		{
		//			documentData.Add("signature", signature);
		//		}
		//		if (errorList.list != null)
		//		{
		//			documentData.Add("error", errorList.ErrorCount.ToString());
		//		}
		//		errorList.ShowList();
		//	}
		//	return documentData;
		//}

		private void Btn_generateDocument_Click(object sender, EventArgs e)
		{
			ErrorList errorList = new ErrorList();
			DataFetcher data = new DataFetcher();
			data.Date = dateTimePicker1.Value.ToShortDateString();
			data.Company = tbx_company.Text;

			errorList.CheckForErrors(data);
			if (errorList.ErrorCount == 0)
			{
				Console.WriteLine("BAU DAS DOKUMENT ZUSAMMEN!");
			}

			// Console.WriteLine(data.Date);
			//foreach (KeyValuePair<string, string> entry in FetchDocumentData())
			//{
			//	// do something with entry.Value or entry.Key
			//	if (entry.Value != "0")
			//	{
			//		// Mach nichts
			//		// MessageBox.Show(entry.Value);
			//		Console.WriteLine("Es ist ein Fehler aufgetreten.");
			//	}
			//	else
			//	{
			//		// Erstelle Dokument
			//		Console.WriteLine("Key: " + entry.Key + " | Wert: " + entry.Value);
			//	}
			//}
		}

		private void chkbx_addSignature_CheckedChanged(object sender, EventArgs e)
		{
			pbx_digitalSignature.Visible = !pbx_digitalSignature.Visible;
		}

		private void Cbox_salutation_SelectedIndexChanged(object sender, EventArgs e)
		{
			switch (Cbox_salutation.Text)
			{
				case "Herr":
					Lbl_salutation.Text = "Sehr geehrter ";
					break;
				default:
					Lbl_salutation.Text = "Sehr geehrte ";
					break;
			}
		}

		private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
		{
			switch (tabControl1.SelectedTab.Text)
			{
				case "Allgemein":
					Btn_generateDocument.Text = "Dokument erstellen";
					break;
				case "Rechnung":
					Btn_generateDocument.Text = "Rechnung erstellen";
					break;
				case "Angebot":
					Btn_generateDocument.Text = "Angebot erstellen";
					break;
				case "Gehaltsabrechnung":
					Btn_generateDocument.Text = "Gehaltsabrechnung erstellen";
					break;
			}
		}

		private void Cbx_signature_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (Cbx_signature.Text == "Ralf Risse")
			{
				pbx_digitalSignature.Image = Properties.Resources.Unterschrift_Ralf_Risse;
			}
			else
			{
				pbx_digitalSignature.Image = Properties.Resources.Unterschrift_Ute_Heitz;
			}
		}
	}
}
