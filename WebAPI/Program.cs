using Application.Common.Interfaces.Repository;
using Application.Common.Interfaces.Services;
using Application.Services.JobTaskServices;
using Domain.Entities;
using Infrastructure.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<List<JobTask>>();

builder.Services.AddScoped<ITaskServices, JobTaskService>();
builder.Services.AddScoped<ITaskRepository, TaskRepository>();
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

