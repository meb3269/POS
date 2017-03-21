using System.Collections.Generic;
using PosLibraryCode;

namespace PosLibrary
{
	public class Order
	{
		public string OrderNumber { get; set; }

		public string TableNumber { get; set; }

		public string OrderTime { get; set; }

		public string Server { get; set; }

		public List<Plate> plates { get; set; }
	}
}