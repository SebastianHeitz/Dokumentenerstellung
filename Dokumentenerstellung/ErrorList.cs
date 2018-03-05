using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Dokumentenerstellung
{
	class ErrorList
	{
		public string list = null;
		private int errorCount;
		public int ErrorCount
		{
			get { return errorCount; }
			set { errorCount = value; }
		}

		public void AddError(string errorName)
		{
			if (errorName.Length >= 0)
			{
				list = list + errorName + "\r\n";
				errorCount++;
			}
			
		}
		
		public void CheckForErrors(DataFetcher data)
		{
			if (data.Date == String.Empty)
			{
				AddError("Es wurde kein Datum angegeben.");
			}
			if (data.Company == String.Empty)
			{
				AddError("Beim Empfänger fehlt die Firma.");
			}
			ShowList();
		}

		public void ShowList()
		{
			if (list != null)
			{
				if (ErrorCount > 1)
				{
					MessageBox.Show("Es wurden " + ErrorCount + " Fehler gefunden:\n\n\r" + list);
				}
				else
				{
					MessageBox.Show("Es wurde " + ErrorCount + " Fehler gefunden:\n\n\r" + list);
				}
			}
		}
	}
}
