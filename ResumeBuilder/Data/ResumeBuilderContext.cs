using System;
using Microsoft.EntityFrameworkCore;

namespace ResumeBuilder.Models
{
    public class ResumeBuilderContext : DbContext
    {
        public ResumeBuilderContext (DbContextOptions<ResumeBuilderContext> options)
            : base(options)
        {
        }

        public DbSet<ResumeBuilder.Models.User> User { get; set; }

        public DbSet<ResumeBuilder.Models.Job> Job { get; set; }

        public DbSet<ResumeBuilder.Models.Education> Education { get; set; }

        public DbSet<ResumeBuilder.Models.Skill> Skill { get; set; }

		public DbSet<ResumeBuilder.Models.SkillType> SkillType { get; set; }

        public DbSet<ResumeBuilder.Models.Company> Company { get; set; }

	}
}
