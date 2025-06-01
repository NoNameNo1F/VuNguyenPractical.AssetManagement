namespace AssetManagement.WebAPI.Extensions;

public static class ExceptionHandlerExtensions
{
    public static IServiceCollection AddApiExceptionHandler(this IServiceCollection services)
    {
        services.AddProblemDetails();
        services.AddExceptionHandler<ApiExceptionHandler>();

        return services;
    }
}