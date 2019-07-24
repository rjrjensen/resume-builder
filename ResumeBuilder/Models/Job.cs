using System;

namespace ResumeBuilder.Models
{
    public class Job
	{
		public int Id { get; set; }
		public string JobTitle { get; set; }
		public int CompanyId { get; set; }
		public DateTime StartDate { get; set; }
		public DateTime EndDate	{ get; set; }
		public string JobDescription { get; set; }
		public int JobTypeId { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
    }
}
