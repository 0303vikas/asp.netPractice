

namespace PracticeAsp.Net.Middlewares
{
    public class UserMiddleware : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {

            Console.WriteLine($"MiddleWare initiation: {context.Request.Path}");

            await next(context);

        }
    }
}