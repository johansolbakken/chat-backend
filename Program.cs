using Microsoft.EntityFrameworkCore;
using Chat.Controllers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddGraphQLServer()
                .AddQueryType<Query>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    // app.UseSwagger();
    // app.UseSwaggerUI();
}

app.UseRouting().UseEndpoints(endpoints => endpoints.MapGraphQL());

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
