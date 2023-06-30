namespace TestServer;

using System.Text.Json.Serialization;

[JsonSerializable(typeof(HttpRequestInformationModel))]
internal sealed partial class ModelJsonSerializerContext : JsonSerializerContext
{
}
