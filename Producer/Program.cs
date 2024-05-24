using ApplicationProducer.IServices;
using ApplicationProducer.Services;
using Infrastructure.DBContext;
using Infrastructure.IRepository;
using InfrastructureProducer.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<ProducerContext>(options =>
{
    options.UseSqlServer("Data Source=DESKTOP-C6L5N55;Initial Catalog=CumtomDeclaration;Integrated Security=True");
});
// Add services to the container.

builder.Services.AddScoped<IProducerService, ProducerService>();
builder.Services.AddScoped<IProducerRepository, ProducerRepossitory>();
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
