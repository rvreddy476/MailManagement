using Mail.Repository.DBContext;
using Mail.Repository.Repository.Implementations;
using Mail.Repository.Repository.Interfaces;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using OutBoundMail.API.Services.Implementations;
using OutBoundMail.API.Services.Interfaces;
using System.Text;
using User.Management.User.Implementations;
using User.Management.User.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<EmailDbContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

builder.Services.AddScoped<ITokenService, TokenService>();
builder.Services.AddScoped<IEmailService, EmailService>();
builder.Services.AddScoped<IEmailOutboundRepository, EmailOutboundRepository>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


// JWT Authentication
var key = Encoding.ASCII.GetBytes("secret_123456789"); // Replace with your secret key
builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
.AddJwtBearer(options =>
{
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
        ValidIssuer = "rajender",
        ValidAudience = "rajender",
        IssuerSigningKey = new SymmetricSecurityKey(key)
    };
});
builder.Services.AddAuthorization();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    try
    {
        var dbContext = scope.ServiceProvider.GetRequiredService<EmailDbContext>();
        dbContext.Database.EnsureCreated();
    }
    catch (Exception ex)
    {

        Console.WriteLine(ex?.Message);
    }

}


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();



app.UseAuthorization();
app.UseAuthorization();

app.MapControllers();

app.Run();
