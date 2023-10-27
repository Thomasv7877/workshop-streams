using API.Controllers;
using BL.managers;
using DAL;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<WSContext>(options =>
{
    var dbConnectionString = builder.Configuration.GetConnectionString("DbConnection");
    options.UseSqlServer(dbConnectionString);
});


builder.Services.AddScoped<WorkshopManager>();
builder.Services.AddScoped<WorkshopQuery>();
builder.Services.AddScoped<WorkshopMutation>();


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddGraphQLServer()
    .AddQueryType(q => q.Name("Query"))
    .AddMutationType(m => m.Name("Mutation"))
    .AddType<WorkshopQuery>()
    .AddType<WorkshopMutation>();

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
app.MapGraphQL();

app.Run();
