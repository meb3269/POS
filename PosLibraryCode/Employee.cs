using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PosLibraryCode
{
	public class Employee
	{
		public string EmployeeType { get; set; }

		public string EmployeeId { get; set; }

		public string FirstName { get; set; }

		public string LastName { get; set; }

		public Address EmployeeAddress { get; set; }

		public Phone EmployeePhone { get; set; }

		public Schedule EmployeeSchedule { get; set; }

		public int EmployeeVacationHours { get; set; }
	}
}