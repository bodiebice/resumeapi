using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<ResumeDb>(opt => opt.UseInMemoryDatabase("Resume Details"));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

var app = builder.Build();

var ExperienceItems = app.MapGroup("/careerexperiences");
var PersonalProjects = app.MapGroup("/personalprojects");

ExperienceItems.MapGet("/",GetJobHistory);

PersonalProjects.MapGet("/",GetPersonalProjects);

app.Run();

static async Task<IResult> GetJobHistory(ResumeDb db)
{
    return TypedResults.Ok(await db.ResumeExperienceItems.ToArrayAsync());
}

static async Task<IResult> GetPersonalProjects(ResumeDb db) {
    return TypedResults.Ok(await db.ResumePersonalProjects.ToArrayAsync());
}
