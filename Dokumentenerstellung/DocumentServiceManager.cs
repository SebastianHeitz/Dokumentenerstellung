using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using System.IO;

namespace Dokumentenerstellung
{
	/// <summary>
	/// Manager Klasse zum generieren von Dokumenten
	/// </summary>
	public class DocumentServiceManager
	{
		/// <summary>
		/// Repräsentiert Platzhalter Felder
		/// </summary>
		private class PlaceholderField
		{
			/// <summary>
			/// Mögliche Arten wie ein Platzhalter extrahiert wurde
			/// </summary>
			public enum FieldType
			{
				/// <summary>
				/// Platzhalter wurde aus einem SimpleField extrahiert
				/// </summary>
				SimpleField,

				/// <summary>
				/// Platzhalter wurde aus einem FieldChar extrahiert
				/// </summary>
				FieldChar
			}

			/// <summary>
			/// Art und Weise wie der der Platzhalter extrahiert wurde
			/// </summary>
			public FieldType ExtractionType { get; set; }

			/// <summary>
			/// Schlüssel des Platzhalters
			/// </summary>
			public string Key { get; set; }

			/// <summary>
			/// true wenn der Paragraph zu dem der Platzhalter gehört bei einem leeren Wert gelöscht werden soll, sonst false
			/// </summary>
			public bool NoEmptyParagraph { get; set; }

			/// <summary>
			/// OpenXmlElemente die zu dem Platzhalter
			/// </summary>
			public List<OpenXmlElement> Elements { get; set; }

			/// <summary>
			/// Konstruktor, nimmt den Typen entgegen
			/// </summary>
			/// <param name="type">Typ des Platzhalters</param>
			public PlaceholderField(FieldType type)
			{
				ExtractionType = type;
				Key = string.Empty;
				NoEmptyParagraph = false;
				Elements = new List<OpenXmlElement>();
			}

			/// <summary>
			/// Fügt einen konkreten Wert für den Platzhalter ein. Löscht die OpenXML Elemente nicht.
			/// </summary>
			/// <param name="value">Wert der zu dem Platzhalter eingefügt wird</param>
			public void InsertPlaceholder(string value)
			{
				// Wenn Feld leer ist und Paragraph gelöscht werden muss, dies tun
				if (string.IsNullOrEmpty(value) && NoEmptyParagraph)
				{
					foreach (OpenXmlElement curElem in Elements)
					{
						OpenXmlElement removeElement = curElem.Parent;
						while (removeElement != null)
						{
							if (removeElement is Paragraph)
							{
								removeElement.Remove();
								return;
							}

							removeElement = removeElement.Parent;
						}
					}
				}

				// SimpleField ersetzen
				if (ExtractionType == FieldType.SimpleField)
				{
					if (Elements.Count == 0)
					{
						return;
					}

					Run fieldRun = Elements[0].Elements<Run>().FirstOrDefault();
					if (fieldRun == null)
					{
						return;
					}

					Run clonedRun = (Run)fieldRun.CloneNode(true);
					Text updateText = clonedRun.Descendants<Text>().FirstOrDefault();
					if (updateText == null)
					{
						return;
					}

					updateText.Text = value;
					Elements[0].PreviousSibling().Append(clonedRun);
				}
				else if (ExtractionType == FieldType.FieldChar)
				{
					//Field Char ersetzen
					Text runText = new Text(value);
					runText.Space = SpaceProcessingModeValues.Preserve;

					Run insertRun = new Run();
					insertRun.Append(runText);

					Exception addException = null;
					foreach (OpenXmlElement curElem in Elements)
					{
						OpenXmlElement previousSibling = curElem.PreviousSibling();
						while (previousSibling != null)
						{
							try
							{
								previousSibling.Append(insertRun);
								return;
							}
							catch (Exception ex)
							{
								previousSibling = previousSibling.PreviousSibling();
								addException = ex;
							}
						}
					}

					if (addException != null)
					{
						throw addException;
					}
				}
			}
		};

		/// <summary>
		/// Default Konstruktor
		/// </summary>
		public DocumentServiceManager()
		{
		}

		/// <summary>
		/// Extrahiert Platzhalter Felder aus einem Dokument
		/// </summary>
		/// <param name="document">Dokument mit Platzhaltern</param>
		/// <returns>Platzhalter des Dokuments</returns>
		private List<PlaceholderField> ExtractFields(WordprocessingDocument document)
		{
			List<PlaceholderField> fields = new List<PlaceholderField>();

			// Alle Elemente iterieren um auch FieldChars extrahieren zu können
			List<OpenXmlElement> fieldCharElements = null;
			OpenXmlElement[] descendants = document.MainDocumentPart.Document.Descendants().ToArray();
			foreach (var item in descendants)
			{
				// SimpleField prüfen
				if (item is SimpleField)
				{
					fields.Add(ExtractSimpleField((SimpleField)item));
					continue;
				}

				// FieldChar prüfen
				if (item is FieldChar)
				{
					FieldChar fieldChar = (FieldChar)item;

					//Prüfen ob neues FieldChar Feld beginnt
					if (fieldChar.FieldCharType == "begin")
					{
						//Wenn bereits ein FieldChar Feld aktiv ist Fehler werfen
						if (fieldCharElements != null)
						{
							throw new Exception("Placeholder inside placeholder found. This is not supported.");
						}
						fieldCharElements = new List<OpenXmlElement>();
					}
					else if (fieldChar.FieldCharType == "end")
					{
						// Endes des FieldChars => Daten in PlaceHolder Field umwandeln
						fields.Add(ExtractFieldChar(fieldCharElements));
						fieldCharElements = null;
						continue;
					}
				}

				if (fieldCharElements != null)
				{
					fieldCharElements.Add(item);
				}
			}

			return fields;
		}

		/// <summary>
		/// Entfernt unnötige und unerwünsche Zeichen im Schlüssel eines Feldes
		/// </summary>
		/// <param name="key">Schlüssel des Feldes</param>
		/// <returns>Bereinigter Schlüssel</returns>
		private string CleanKey(string key)
		{
			key = key.Trim().ToLower();
			key = key.Replace("<<", "");
			key = key.Replace(">>", "");
			string[] keys = key.Split(' ');
			if (keys.Length > 0)
			{
				return keys[0];
			}

			return key;
		}

		/// <summary>
		/// Prüft ob ein Parameter für einen Schlüssel existiert
		/// </summary>
		/// <param name="key">Schlüssel des Feldes</param>
		/// <param name="param">Gesuchter Parameter</param>
		/// <returns>true wenn der Schlüssel existiert, sonst false</returns>
		private bool CheckKeyParamExists(string key, string param)
		{
			key = key.Trim().ToLower();
			key = key.Replace("<<", "");
			key = key.Replace(">>", "");
			string[] keys = key.Split(' ');
			foreach (string curParam in keys)
			{
				if (curParam == param)
				{
					return true;
				}
			}

			return false;
		}

		/// <summary>
		/// Generiert ein PlaceholderField aus einem OpenXML SimpleField
		/// </summary>
		/// <param name="field">OpenXML SimpleField</param>
		/// <returns>PlaceholderField</returns>
		private PlaceholderField ExtractSimpleField(SimpleField field)
		{
			PlaceholderField placeholderField = new PlaceholderField(PlaceholderField.FieldType.SimpleField);
			placeholderField.Key = CleanKey(field.InnerText);
			placeholderField.NoEmptyParagraph = RemoveEmptyParagraph(placeholderField.Key);
			placeholderField.Elements.Add(field);

			return placeholderField;
		}

		/// <summary>
		/// Generiert ein PlaceholderField aus einem OpenXML FieldChar
		/// </summary>
		/// <param name="fieldElements">OpenXML FieldChar Elemente</param>
		/// <returns>PlaceholderField</returns>
		private PlaceholderField ExtractFieldChar(IEnumerable<OpenXmlElement> fieldElements)
		{
			PlaceholderField placeholderField = new PlaceholderField(PlaceholderField.FieldType.FieldChar);

			// Schlüssel extrahieren
			string key = string.Empty;
			foreach (OpenXmlElement curElem in fieldElements)
			{
				if (curElem.Descendants<FieldCode>().FirstOrDefault() != null)
				{
					continue;
				}

				if (curElem is Run)
				{
					key += ((Run)curElem).InnerText;
				}
			}

			placeholderField.Key = CleanKey(key);
			placeholderField.NoEmptyParagraph = RemoveEmptyParagraph(placeholderField.Key);
			placeholderField.Elements.AddRange(fieldElements);

			return placeholderField;
		}

		/// <summary>
		/// Erzeugt ein Dokument aus einem Template
		/// </summary>
		/// <param name="templateFile">Pfad zum Template</param>
		/// <param name="fileFormat">Dateiformat in dem das Dokument generiert wird</param>
		/// <returns>MemoryStream mit ausgefüllten Dokument</returns>
		public MemoryStream CreateDocument(string templateFile)
		{
			// Daten intialisieren
			byte[] byteArray = File.ReadAllBytes(templateFile);
			MemoryStream docStream = new MemoryStream();
			docStream.Write(byteArray, 0, (int)byteArray.Length);

			// OpenXML intialisieren
			using (WordprocessingDocument wordDoc = WordprocessingDocument.Open(docStream, true))
			{
				// Felder abfragen
				List<PlaceholderField> fields = ExtractFields(wordDoc);

				//Platzhalter ersetzen
				foreach (PlaceholderField curField in fields)
				{
					curField.InsertPlaceholder(GetPlaceholderValue(curField.Key));

					// Elemente löschen
					foreach (OpenXmlElement curElem in curField.Elements)
					{
						curElem.RemoveAllChildren();
						if (curElem.Parent != null)
						{
							curElem.Remove();
						}
					}
				}
			}

			docStream.Seek(0, SeekOrigin.Begin);

			return docStream;
		}

		/// <summary>
		/// Gibt zurück ob der Paragraph in dem sich ein Platzhalter befindet gelöscht werden soll wenn der Wert des Paragraphen leer ist
		/// </summary>
		/// <param name="key">Schlüssel</param>
		/// <returns>true wenn ein leerer Paragraph entfernt wird, sonst false</returns>
		private bool RemoveEmptyParagraph(string key)
		{
			// TODO: Bestimmen ob leerer Paragraph erlaubt ist. Nützlich wenn z.B. in einem Addressblock der Paragraph eines zweiten Addressfelds gelöscht werden soll wenn es leer ist etc.
			return false;
		}

		/// <summary>
		/// Gibt den Wert für einen Platzhalter zurück
		/// </summary>
		/// <param name="key">Schlüssel</param>
		/// <returns>Wert des Platzhalters</returns>
		private string GetPlaceholderValue(string key)
		{
			// TODO: Platzhalter Werte bestimmen, z.B: über Webservice oder eine Liste an Interface von Placeholder Resolvern welche an die Manager Klasse eingefügt werden etc.
			if (key == "date")
			{
				return "02.03.2018";
			}
			else if (key == "type")
			{
				return "Betreffzeile";
			}
			//else if (key == "company")
			//{
			//	return "Volkswagen AG";
			//}

			return string.Empty;
		}

	}
}
