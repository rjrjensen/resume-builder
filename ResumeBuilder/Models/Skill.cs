namespace ResumeBuilder.Models
{
    public class Skill
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public int Experience { get; set; }
		public int SkillTypeId { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
    }
}
