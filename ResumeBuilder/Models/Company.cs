using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResumeBuilder.Models
{
	public class Company
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public int AddressId { get; set; }
		public string Phone { get; set; }
		public string PhoneExtention { get; set; }
		public string SupervisorName { get; set; }
		public bool CanContact { get; set; }
	}
}
