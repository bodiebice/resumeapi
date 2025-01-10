using Microsoft.EntityFrameworkCore;

class ResumePersonalProjectDb : DbContext
{
    public ResumePersonalProjectDb(DbContextOptions<ResumePersonalProjectDb> options)
        : base(options) { }

    public DbSet<ResumePersonalProject> ResumePersonalProjects => Set<ResumePersonalProject>();
}
