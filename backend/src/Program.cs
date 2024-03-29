using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Identity;
using backend.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors();

// Retrieve the connection string from appsettings.json
var configuration = builder.Configuration;
var connectionString = configuration.GetConnectionString("SqliteConnection");

// Configure the database context with IdentityUser
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite(connectionString));

// Configure Identity services
builder.Services.AddIdentity<ApplicationUser, IdentityRole>(options =>
    {
        // Configure password requirements if needed
        // options.Password.RequiredLength = 8;
        // options.Password.RequireUppercase = true;
        // Other password requirements...
    })
    .AddEntityFrameworkStores<AppDbContext>()
    .AddDefaultTokenProviders();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

// app.UseCors(x => x.AllowAnyHeader().AllowAnyMethod().WithOrigins("http://localhost:3000"));

// app.UseHttpsRedirection();
app.UseAuthentication(); // Add this line to enable authentication
app.UseAuthorization();

app.MapControllers();

app.Run();
