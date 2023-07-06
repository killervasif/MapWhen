using WebApplication1.Middlewares;

namespace WebApplication1.Extensions;

public static class MiddlewareRegistrationExtension
{
    public static IApplicationBuilder UseLogin(this IApplicationBuilder applicationBuilder)
    {
        return applicationBuilder.UseMiddleware<Login>();
    }
}
