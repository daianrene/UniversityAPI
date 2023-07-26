using Microsoft.EntityFrameworkCore;
using UniversityAPI.DataAcces;
using UniversityAPI.Services;

var builder = WebApplication.CreateBuilder(args);


// DB Connection    
var connectionString = builder.Configuration.GetConnectionString("UniversityDB");
builder.Services.AddDbContext<UniversityDBContext>(options => options.UseSqlServer(connectionString));

// Add Controllers
builder.Services.AddControllers();

// Add services to the container.
builder.Services.AddScoped<IStudentService, StudentService>();

// Add JWT

//builder.Services.AddJwtTokensServices(builder.Configuration);

// Add CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: "CorsPolicy", builder =>
    {
        builder.AllowAnyOrigin();
        builder.AllowAnyMethod();
        builder.AllowAnyHeader();
    }); 
});

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

// Swagger config to take care of JWT
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

app.UseCors("CorsPolicy");

app.Run();
