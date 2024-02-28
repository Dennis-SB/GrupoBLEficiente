using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Text;
using BackEnd.Data;
using BackEnd.Areas.Identity.Data;
using BackEnd.Models.Service;
using BackEnd.DAL.interfaces;
using BackEnd.DAL.Implementations;

var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;

# region Connection String
var connectionString = configuration.GetConnectionString("GrupoBLContextConnection") ?? throw new InvalidOperationException("Connection string 'GrupoBLContextConnection' not found.");

builder.Services.AddDbContext<GrupoBLContext>(options =>
    options.UseSqlServer(connectionString));
#endregion

#region Identity
builder.Services.AddIdentity<GrupoBLUser, IdentityRole>(options =>
{
    options.SignIn.RequireConfirmedAccount = false;
    options.SignIn.RequireConfirmedEmail = true;
    options.Password.RequiredLength = 3;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequireDigit = false;
    options.Password.RequireLowercase = false;
    options.Password.RequireUppercase = false;
})
    .AddEntityFrameworkStores<GrupoBLContext>()
    .AddDefaultTokenProviders();
#endregion

# region Authentication
builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
});
#endregion

# region Email Configuration
var emailconfig = configuration.GetSection("EmailConfiguration").Get<EmailConfiguration>();
builder.Services.AddSingleton(emailconfig);
builder.Services.AddScoped<IEmailService, EmailServiceImpl>();
#endregion

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
app.UseAuthentication();;
app.UseAuthorization();
app.MapControllers();
app.Run();