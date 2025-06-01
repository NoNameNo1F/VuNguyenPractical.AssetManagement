using AssetManagement.Infrastructure.Logging;

var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;

builder.WebHost.UseLogger(cfg =>
{
    var appSettings = new AppSettings();
    cfg.Bind(appSettings);
    return appSettings.Logging;
});

// builder.Services.AddInfrastructure(configuration);

builder.Services.AddApiExceptionHandler();
builder.Services.AddSwaggerDocumentation();
builder.Services.AddApiVersion();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddControllers();

builder.Services.AddHttpContextAccessor();

builder.Services.AddCors(options =>
{
    var allowedHosts = configuration.GetSection("AllowedHosts").Get<string[]>()!;
    options.AddDefaultPolicy(policy =>
        policy.AllowAnyOrigin()
            .AllowAnyHeader()
            .AllowAnyMethod());
    
    options.AddPolicy("AllowClients", policy =>
        policy.WithOrigins(allowedHosts)
            .AllowAnyHeader()
            .AllowAnyMethod());
});

builder.Services.AddAuthenticationExtension(opt => configuration.GetSection("Jwt").Bind(opt));
builder.Services.AddAuthorizationExtension();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwaggerDocumentation();
    app.UseCors();
}
else
{
    app.UseCors("AllowClients");
}

app.UseHttpsRedirection();
app.UseExceptionHandler();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();

