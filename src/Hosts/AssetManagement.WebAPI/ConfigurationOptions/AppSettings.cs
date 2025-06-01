using AssetManagement.Infrastructure.ConfigurationOptions;
using AssetManagement.Infrastructure.Logging;
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.

namespace AssetManagement.WebAPI.ConfigurationOptions;

public class AppSettings
{
    public JwtOptions Jwt { get; set; }
    public ConnectionStringOptions ConnectionString { get; set; }
    public Dictionary<string, string> Storage { get; set; }
    public string[] AllowedHosts { get; set; }
    public LoggingOptions Logging { get; set; }
}