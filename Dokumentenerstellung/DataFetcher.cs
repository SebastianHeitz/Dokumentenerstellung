using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dokumentenerstellung
{
	public class DataFetcher
	{
		private string date;
		public string Date
		{
			get { return date; }
			set { date = value; }
		}

		private string company;
		public string Company
		{
			get { return company; }
			set { company = value; }
		}

		private string contactPerson;
		public string ContactPerson
		{
			get { return contactPerson; }
			set { contactPerson = value; }
		}

		private string street;
		public string Street
		{
			get { return street; }
			set { street = value; }
		}
		private string houseNumber;
		public string HouseNumber
		{
			get { return houseNumber; }
			set { houseNumber = value; }
		}
		private string postcode;
		public string Postcode
		{
			get { return postcode; }
			set { postcode = value; }
		}

		private string cityRecipient;
		public string CityRecipient
		{
			get { return cityRecipient; }
			set { cityRecipient = value; }
		}

		private string subject;
		public string Subject
		{
			get { return subject; }
			set { subject= value; }
		}

		private string citySender;
		public string CitySender
		{
			get { return citySender; }
			set { citySender = value; }
		}

		private string salutation;
		public string Salutation
		{
			get { return salutation; }
			set { salutation= value; }
		}

		private string mainText;
		public string MainText
		{
			get { return mainText; }
			set { mainText = value; }
		}

		private string signature;
		public string Signature
		{
			get { return signature; }
			set { signature = value; }
		}
	}
}
