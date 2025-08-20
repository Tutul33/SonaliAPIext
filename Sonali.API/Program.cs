using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Sonali.API.DomainService.Base;
using Sonali.API.Infrustructure.DAL.Base;
using Sonali.API.Infrustructure.Data.Data;
using Sonali.API.Middlewares;
using Sonali.API.ServicesRegister;
using Sonali.API.Utilities;

var builder = WebApplication.CreateBuilder(args);
var configBuilder = new ConfigurationBuilder()
                       .SetBasePath(Directory.GetCurrentDirectory())
                       .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

IConfiguration _configuration = configBuilder.Build();
StaticInfos.MsSqlConnectionString = _configuration.GetValue<string>("MsSqlConnectionString");
builder.Services.Configure<JwtSettings>(_configuration.GetSection("Jwt"));
builder.Services.Configure<FileUploadSettings>(_configuration.GetSection("FileUpload"));
// Add services to the container.
builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer(StaticInfos.MsSqlConnectionString);
});

ServiceRegister.Register(builder);
ValidatorRegister.Register(builder);

builder.Services.AddScoped<FluentValidationActionFilter>();

builder.Services.AddControllers(options =>
{
    options.Filters.Add<FluentValidationActionFilter>();
}).AddJsonOptions(opts =>
{
    opts.JsonSerializerOptions.Converters.Add(new NullableDecimalConverter());
    opts.JsonSerializerOptions.Converters.Add(new DateOnlyJsonConverter());
}); 
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
        policy.AllowAnyOrigin()
              .AllowAnyHeader()
              .AllowAnyMethod());
});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    // Add JWT bearer definition
    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        Name = "Authorization",
        Type = SecuritySchemeType.ApiKey,
        Scheme = "Bearer",
        BearerFormat = "JWT",
        In = ParameterLocation.Header,
        Description = "Enter 'Bearer' [space] and then your valid token.\r\n\r\nExample: \"Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6...\""
    });

    // Require JWT in requests
    c.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = "Bearer"
                }
            },
            Array.Empty<string>()
        }
    });
});
builder.Services.AddAutoMapper(cfg =>
{
    cfg.AddProfile<MappingProfile>();
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
else
{
    app.UseDefaultFiles();
    app.UseStaticFiles();
}
app.UseRouting();
app.UseCors();
app.UseMiddleware<JwtMiddleware>();
app.UseMiddleware<ApiResponseMiddleware>();
app.UseAuthorization();

app.MapControllers();

app.Run();


/// <summary>
///  This partial class is necessary for the WebApplicationFactory to work correctly
///  This allows WebApplicationFactory<Program> to discover your app for testing purposes of Sonali.API.Tests integration tests
/// </summary>
public partial class Program { }