using Competency.DOMAIN.Core.Interfaces;
using Competency.DOMAIN.Infrastructure.Data;
using Competency.DOMAIN.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddTransient<ICompetencyRepository, CompetencyRepository>();
var _config = builder.Configuration;
var cnx = _config.GetConnectionString("DevConnection");
builder.Services
    .AddDbContext<Parcial20240221101034Context>
    (options => options.UseSqlServer(cnx));
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

app.UseAuthorization();

app.MapControllers();

app.Run();
