using System.Collections.Immutable;
using TestServer;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors();

var app = builder.Build();

app.UseCors(x => x.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin());
app.UseForwardedHeaders();

app.Map("/", (HttpContext context) =>
{
    var data = new HttpRequestInformationModel
    {
        Method = context.Request.Method,
        Scheme = context.Request.Scheme,
        IsHttps = context.Request.IsHttps,
        Host = context.Request.Host.Value,
        PathBase = context.Request.PathBase.Value,
        Path = context.Request.Path.Value,
        Protocol = context.Request.Protocol,

        Query = context.Request.Query.ToImmutableDictionary(
            keySelector: x => x.Key,
            elementSelector: x => x.Value.ToString()),

        Headers = context.Request.Headers.ToImmutableDictionary(
            keySelector: x => x.Key.ToLowerInvariant(),
            elementSelector: x => x.Value.ToString()),
    };

    return TypedResults.Json(data, ModelJsonSerializerContext.Default.HttpRequestInformationModel);
});

app.Run();