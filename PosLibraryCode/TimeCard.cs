using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PosLibraryCode
{
	public class TimeCard
	{
		public Employee Employee { get; set; }

		public string DayOfWeek { get; set; }

		public DateTime StartDayTime { get; set; }

		public DateTime EndDayTime { get; set; }

		public DateTime StartBreak { get; set; }

		public DateTime EndBreak { get; set; }

		public int AggregateHours { get; set; }
	}
}