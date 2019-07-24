using System.Collections.Generic;

namespace ResumeBuilder.Models
{
    public class User
	{
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public string LinkedIn { get; set; }
        public string GitHub { get; set; }
        public string Facebook { get; set; }

        public List<Job> Jobs { get; set; }
        public List<Education> Educations { get; set; }
        public List<Skill> Skills { get; set; }
	}
}
