using System.Collections.Generic;
using PosLibrary;

namespace PosLibraryCode
{
	public class Plate
	{
		public Plate()
		{
			PlateNumber = "0";
			PlateOrder = new List<FoodMenuItem>();
		}

		public string PlateNumber { get; set; }

		public List<FoodMenuItem> PlateOrder { get; set; }
	}
}