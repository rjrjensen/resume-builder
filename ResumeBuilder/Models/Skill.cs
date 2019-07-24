using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResumeBuilder.Models
{
	public class Skill
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public int Experience { get; set; }
		public int SkillTypeId { get; set; }
	}
}
