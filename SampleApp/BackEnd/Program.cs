using BackEnd.Application.Repository_Interfaces;
using BackEnd.Domain.Client;
using BackEnd.Domain.Engineer;
using BackEnd.Domain.Job;
using BackEnd.Infrastructure.Data;
using BackEnd.Infrastructure.Repository_Implementations;
using Microsoft.EntityFrameworkCore;

//sets the app upp, merges configurations, and starts the web server
var builder = WebApplication.CreateBuilder(args);

//registers services for dependency injection ~ data access, UI rendering, etc.




builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IClientRepository<Client>, ClientRepository>();
builder.Services.AddScoped<IJobRepository<Job>, JobRepository>();
builder.Services.AddScoped<IEngineerRepository<Engineer>, EngineerRepository>();

//finalised the configuration and starts the app
var app = builder.Build();

//error handling and security settings
if (!app.Environment.IsDevelopment())// if not in development environment
{
    app.UseExceptionHandler("/Error");//redirects to error page on exceptions
    app.UseHsts();//enables HTTP Strict Transport Security for enhanced security
    app.UseSwagger();
    app.UseSwaggerUI();
}

//middleware pipeline configuration -defines how HTTP requests are handled
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

app.MapGet("/", () => "Welcome to the BackEnd API!");


app.Run("http://localhost:5000");










