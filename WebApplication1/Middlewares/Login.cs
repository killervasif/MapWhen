namespace WebApplication1.Middlewares;

public class Login
{
    private RequestDelegate? _next;

    public Login(RequestDelegate next)
    {
        _next = next;
    }

    public async Task Invoke(HttpContext context)
    {
        Console.WriteLine("Login started");
        await _next?.Invoke(context);
        Console.WriteLine("Login ended");
    }
}
