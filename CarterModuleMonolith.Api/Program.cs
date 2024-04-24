using Carter;
using CarterModuleMonolith.ModuleOne;
using CarterModuleMonolith.ModuleTwo;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddModuleOne();
builder.Services.AddModuleTwo();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();
app.MapCarter();

app.Run();
