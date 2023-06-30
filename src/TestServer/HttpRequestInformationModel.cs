namespace TestServer;

using System.Collections.Immutable;
using System.Text.Json.Serialization;

internal sealed class HttpRequestInformationModel
{
    [JsonRequired]
    [JsonPropertyName("method")]
    public required string Method { get; init; }

    [JsonRequired]
    [JsonPropertyName("scheme")]
    public required string Scheme { get; init; }

    [JsonRequired]
    [JsonPropertyName("isHttps")]
    public required bool IsHttps { get; init; }

    [JsonRequired]
    [JsonPropertyName("host")]
    public required string Host { get; init; }

    [JsonRequired]
    [JsonPropertyName("pathBase")]
    public required string? PathBase { get; init; }

    [JsonRequired]
    [JsonPropertyName("path")]
    public required string? Path { get; init; }

    [JsonRequired]
    [JsonPropertyName("protocol")]
    public required string Protocol { get; init; }

    [JsonRequired]
    [JsonPropertyName("query")]
    public required IImmutableDictionary<string, string> Query { get; init; }

    [JsonRequired]
    [JsonPropertyName("headers")]
    public required IImmutableDictionary<string, string> Headers { get; init; }
}
