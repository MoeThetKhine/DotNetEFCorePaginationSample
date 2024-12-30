namespace PresentationLayerApi;

public static class ModularService
{
    #region AddFeatures

    public static IServiceCollection AddFeatures(this IServiceCollection services, WebApplicationBuilder builder)
    {
        services.AddDbContextService(builder);
        services.AddDataAccess();
        services.AddBusinessLogic();
        services.AddJsonService();
        return services;
    }
    #endregion

    #region AddDbContextService
    private static IServiceCollection AddDbContextService(this IServiceCollection services, WebApplicationBuilder builder)
    {
        builder.Services.AddDbContext<AppDbContext>(opt =>
        {
            opt.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
            opt.UseSqlServer(builder.Configuration.GetConnectionString("DbConnection"));
        });
        return services;
    }
    #endregion

    #region AddDataAccess
    private static IServiceCollection AddDataAccess(this IServiceCollection services)
    {
        services.AddScoped<DA_Blog>();
        return services;
    }

    #endregion

    #region AddBusinessLogic
    private static IServiceCollection AddBusinessLogic(this IServiceCollection services)
    {
        services.AddScoped<BL_Blog>();
        return services;
    }
    #endregion

    #region AddJsonService
    private static IServiceCollection AddJsonService(this IServiceCollection services)
    {
        services.AddControllers().AddJsonOptions(opt =>
        {
            opt.JsonSerializerOptions.PropertyNamingPolicy = null;
        });
        return services;
    }
    #endregion
}
