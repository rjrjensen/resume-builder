using System;

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

        public int UserId { get; set; }
        public User User { get; set; }
    }
}
