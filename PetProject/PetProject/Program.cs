using Microsoft.EntityFrameworkCore;
using PetProject.Application.Interfaces;
using PetProject.Application.Services;
using PetProject.Persistence;
using PetProject.Persistence.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ProjectDbContext>(options =>
{
    options.UseNpgsql(builder.Configuration.GetConnectionString(nameof(ProjectDbContext)));
});

builder.Services.AddScoped<ITargetRepository, TargetRepository>();
builder.Services.AddScoped<ITargetsService, TargetsService>();

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
