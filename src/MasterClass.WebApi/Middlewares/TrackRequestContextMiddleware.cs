using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

public class TrackRequestContextMiddleware
{
    private readonly RequestDelegate _next;

    public TrackRequestContextMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task InvokeAsync(HttpContext context, IApplicationRequestContext requestContext)
    {
        context.Response.Headers.Add("X-Guid", requestContext.Id.ToString());
        await _next(context);
    }
}