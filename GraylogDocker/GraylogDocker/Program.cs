using Serilog;
using Serilog.Sinks.Graylog;
using Serilog.Sinks.Graylog.Core.Transport;

var builder = WebApplication.CreateBuilder(args);

builder.Logging.ClearProviders();
//Para utilizar as configs do Serilog no appsetting é preciso o pacote Serilog.Settings.Configuration

Log.Logger = new LoggerConfiguration()
    .MinimumLevel.Information()  // Nível mínimo de log
    .WriteTo.Console()
    .WriteTo.Graylog("127.0.0.1", 12201, TransportType.Udp)  // Envia para o Graylog
    .CreateLogger();

builder.Host.UseSerilog(); // Integra o Serilog com o ASP.NET Core

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
