using Microsoft.EntityFrameworkCore;
using System.Reflection;
using yasapp.Infrastructure.Data;

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

/*
builder.Services.AddSwaggerGen(c =>
{
    var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
    c.IncludeXmlComments(xmlPath);
    c.EnableAnnotations();
});*/


//------------------------------------------------- ef core -------------------------------------------------
//
builder.Services.AddScoped<YasappDbContext>();
builder.Services.AddDbContext<DbContext>(opts =>
{
    opts.UseSqlServer(builder.Configuration["ConnectionStrings:yasappDb"],
        x => x.MigrationsHistoryTable("__yasappDb_MigrationHistory"));
});

//-----------------------------------------------------------------------------------------------------------


// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
