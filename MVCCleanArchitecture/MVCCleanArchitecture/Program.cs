using Microsoft.EntityFrameworkCore;
using MVCCleanArchitecture.Application.Interfaces;
using MVCCleanArchitecture.Application.Services;
using MVCCleanArchitecture.Domain.Interfaces.Respositories.Application;
using MVCCleanArchitecture.Domain.Interfaces.Respositories.OtherApplication;
using MVCCleanArchitecture.Domain.Interfaces.Services.Application;
using MVCCleanArchitecture.Domain.Interfaces.Services.OtherApplication;
using MVCCleanArchitecture.Domain.Services.Application;
using MVCCleanArchitecture.Domain.Services.OtherApplication;
using MVCCleanArchitecture.Infrastructure.Data;
using MVCCleanArchitecture.Infrastructure.Repositories.Application;
using MVCCleanArchitecture.Infrastructure.Repositories.OtherApplication;

var builder = WebApplication.CreateBuilder(args);

// Configurações do EF Core
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddDbContext<OtherApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("OtherDefaultConnection")));

// Injeção de dependência para Repositórios e Serviços

builder.Services.AddScoped<ITransacaoService, TransacaoService>();
builder.Services.AddScoped<ITransacaoRepository, TransacaoRepository>();
builder.Services.AddScoped<IStatusService, StatusService>();
builder.Services.AddScoped<IStatusRepository, StatusRepository>();
builder.Services.AddScoped<IOtherTransacaoService, OtherTransacaoService>();
builder.Services.AddScoped<IOtherTransacaoRepository, OtherTransacaoRepository>();
builder.Services.AddScoped<IOtherStatusService, OtherStatusService>();
builder.Services.AddScoped<IOtherStatusRepository, OtherStatusRepository>();
builder.Services.AddScoped<IDataItemService, DataItemService>();

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
