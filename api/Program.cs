using Microsoft.EntityFrameworkCore;
using Serilog;
using System.Reflection;
using yasapp.Infrastructure.Data;
using yasapp.Infrastructure.Interfaces;
using yasapp.Domain.Entities.Masterdata;
using yasapp.Infrastructure.Repositories;
using yasapp.Infrastructure.UnitOfWork;
using Module = yasapp.Domain.Entities.Masterdata.Module;
using yasapp.Application.Services;
using yasapp.Application.Interfaces;
using yasapp.Domain.Entities;

var builder = WebApplication.CreateBuilder(args);

//--------------------------------------------------- cors --------------------------------------------------
builder.Services.AddCors(options => options.AddPolicy("MyAllowSpecificOrigins", p =>
{//TODO: this is only for development, in production be more restrictive

    p.AllowAnyMethod()
        .AllowAnyHeader()
        .SetIsOriginAllowed((host) => true)
        .AllowCredentials();
    /*p.AllowAnyMethod()
        .AllowAnyHeader()
        .SetIsOriginAllowed((host) => true)
        .WithOrigins("https://vipp-api.azurewebsites.net",
                     "https://vipp-portal.azurewebsites.net",
                     "http://localhost:4200")
        .AllowCredentials();*/

}));


//-------------------------------------------------- serilog -------------------------------------------------
Log.Logger = new LoggerConfiguration().WriteTo.Console().CreateBootstrapLogger();
builder.Host.UseSerilog(((ctx, lc) => lc.ReadFrom.Configuration(ctx.Configuration)));
builder.Logging.ClearProviders();
builder.Logging.AddSerilog(Log.Logger);

//-------------------------------------------------- swagger ------------------------------------------------
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
    c.IncludeXmlComments(xmlPath);
    c.EnableAnnotations();
});

//------------------------------------------------- ef core -------------------------------------------------
//
builder.Services.AddScoped<YasappDbContext>();
builder.Services.AddDbContext<DbContext>(opts =>
{
    opts.UseSqlServer(builder.Configuration["ConnectionStrings:yasappDb"],
        x => x.MigrationsHistoryTable("__yasappDb_MigrationHistory"));
});


builder.Services.AddAutoMapper(typeof(Program));
//-----------------------------------------------------------------------------------------------------------

//------------------------------------------------- repositories -------------------------------------------------
//
builder.Services.AddScoped<IExaminationService<ExaminationModel, Examination>,
                           ExaminationService<ExaminationModel, Examination>>();

builder.Services.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

//builder.Services.AddScoped<IUnitOfWork, UnitOfWork>
//builder.Services.AddScoped<IUnitOfWork<Examination, Module,Student,StudyProgram, Contact>, 
//                            UnitOfWork<Examination, Module, Student, StudyProgram, Contact>>();


/*
builder.Services.AddScoped<IExaminationRepository<Examination>, ExaminationRepository<Examination>>();
builder.Services.AddScoped<IModuleRepository<Module>, ModuleRepository<Module>>();
builder.Services.AddScoped<IStudentRepository<Student>, StudentRepository<Student>>();
builder.Services.AddScoped<IStudyProgramRepository<StudyProgram>, StudyProgramRepository<StudyProgram>>();
builder.Services.AddScoped<IContactRepository<Contact>, ContactRepository<Contact>>();
*/
//todo: add more repositories here
//-----------------------------------------------------------------------------------------------------------





//-----------------------------------------------------------------------------------------------------------
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
//execute ef core migrations
using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<YasappDbContext>();
    db.Database.Migrate();
}


// Configure the HTTP request pipeline.
app.UseSwagger();
app.UseSwaggerUI();

app.UseCors("MyAllowSpecificOrigins");
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
