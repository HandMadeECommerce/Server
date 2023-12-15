using Microsoft.EntityFrameworkCore;
using Server.src.Core.Context;

namespace Server.src.Core;

public static class DependencyInjection
{
    public static IServiceCollection AddCore(this IServiceCollection services, WebApplicationBuilder builder)
    {
        services.AddDbContext<AppDbContext>(opt =>
                opt.UseNpgsql(builder.Configuration["Development"] ??
                              throw new InvalidOperationException("Connection string not found.")));

        return services;
    }
}
