using Microsoft.EntityFrameworkCore;

class ResumeExperienceItemDb : DbContext
{
    public ResumeExperienceItemDb(DbContextOptions<ResumeExperienceItemDb> options)
        : base(options) { }

    public DbSet<ResumeExperienceItem> ResumeExperienceItems => Set<ResumeExperienceItem>();
}

