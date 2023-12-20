using System.Text.Json.Serialization;

namespace Apis_Dynamics.Model;

internal class ModeloPokemon
{
    [JsonPropertyName("name")]
    public string Nome { get; set; }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Nome do pokemon é: {Nome}");
    }
}
