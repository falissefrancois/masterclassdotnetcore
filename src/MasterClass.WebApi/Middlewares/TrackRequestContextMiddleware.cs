using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

public class TrackRequestContextMiddleware
{
    private readonly RequestDelegate _next;
    private readonly IEnumerable<IApplicationRequestContext> _appRCs;

    public TrackRequestContextMiddleware(RequestDelegate next, IEnumerable<IApplicationRequestContext> appRC)
    {
        _next = next;
        _appRCs = appRC;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        Random random = new Random();
        context.Response.Headers.Add("X-Guid", _appRCs.ElementAt(random.Next(0,3)).Id.ToString());
        await _next(context);
    }
}