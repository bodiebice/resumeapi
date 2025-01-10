using Microsoft.EntityFrameworkCore;

class ResumeDb : DbContext
{
    public ResumeDb(DbContextOptions<ResumeDb> options)
        : base(options) { }

    public DbSet<ResumeExperienceItem> ResumeExperienceItems => Set<ResumeExperienceItem>();
    public DbSet<ResumePersonalProject> ResumePersonalProjects => Set<ResumePersonalProject>();
}
