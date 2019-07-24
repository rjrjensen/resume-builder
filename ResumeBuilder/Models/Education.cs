using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResumeBuilder.Models
{
	public class Education
	{
		public int Id { get; set; }
		public string ProgramName { get; set; }
		public string SchoolName { get; set; }
		public DateTime StartDate { get; set; }
		public DateTime EndDate { get; set; }
		public bool Graduated { get; set; }
		public int AddressId { get; set; }
	}
}
