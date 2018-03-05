using System;
using System.IO;
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
			ErrorList errorList = new ErrorList();
			DataFetcher data = new DataFetcher
			{
				Date = dateTimePicker1.Value.ToShortDateString(),
				Company = tbx_company.Text,
				ContactPerson = tbx_contactPerson.Text,
				Street = tbx_street.Text,
				HouseNumber = tbx_houseNumber.Text,
				Postcode = tbx_postcode.Text,
				CityRecipient = tbx_cityRecipient.Text,
				Subject = Tbx_subject.Text,
				CitySender = Tbx_citySender.Text,
				Salutation = Cbox_salutation.Text,
				MainText = Rtb_mainText.Text,
				Signature = Cbx_signature.Text
			};

			errorList.CheckForErrors(data);
			if (errorList.ErrorCount == 0)
			{
				CreateDocument(tabControl1.SelectedIndex, data);
			}
		}

		private void CreateDocument(int documentType, DataFetcher data)
		{
			string templateFile = "Allgemein_Alpha.docx";
			string outputFile = "output_Allgemein.docx";

			switch (documentType)
			{
				case 1:
					templateFile = "Rechnung_Alpha.docx";
					outputFile = "output_Rechnung.docx";
					break;
				case 2:
					templateFile = "Angebot_Alpha.docx";
					outputFile = "output_Angebot.docx";
					break;
				case 3:
					templateFile = "Gehaltsabrechnung_Alpha.docx";
					outputFile = "output_Gehaltsabrechnung.docx";
					break;
				default:
					break;
			}

			// Manager aufbauen und Template "test.docx" befüllen
			DocumentServiceManager manager = new DocumentServiceManager();
			using (Stream stream = manager.CreateDocument(templateFile, data))
			{
				// Stream in Ausgabe Datei speichern
				using (FileStream fileStream = new FileStream("output_"+tabControl1.SelectedTab.Text+".docx", FileMode.Create))
				{
					stream.CopyTo(fileStream);
					fileStream.Close();
				}
			}
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
