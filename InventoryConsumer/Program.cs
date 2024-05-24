using Application.IServices;
using Application.Services;
using Confluent.Kafka;
using Infrastructure.DBContext;
using Infrastructure.IRepository;
using Infrastructure.Repository;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ConsumerContext>(options =>
{
    options.UseSqlServer("Data Source=DESKTOP-C6L5N55;Initial Catalog=CumtomDeclaration;Integrated Security=True");
});
// Add services to the container.

builder.Services.AddScoped<IConsumerService, ConsumerService>();
builder.Services.AddScoped<IConsumerRepository, ConsumerRepossitory>();
//builder.Services.AddScoped<IKafkaConsumer, KafkaConsumer>();
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
