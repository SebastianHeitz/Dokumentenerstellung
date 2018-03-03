using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
//using DocumentFormat.OpenXml.Packaging;

namespace Dokumentenerstellung
{
	class ErrorList
	{
		string list = null;
		int errorCount = 0;

		public void AddError(string errorName)
		{
			if (errorName.Length >= 0)
			{
				list = list + errorName + "\r\n";
				errorCount++;
			}
			
		}

		public void ShowList()
		{
			if (list != null)
			{
				MessageBox.Show("Es wurden " + errorCount + " Fehler gefunden:\n\n\r" + list);
			}
		}
	}
}
