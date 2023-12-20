using Apis_Dynamics.Model;
using System.Text.Json;


using (HttpClient client = new())
{
    try
    {
        Random random = new();
        int idPokemon = random.Next(1, 1026);
        var conexao = await client.GetStringAsync($"https://pokeapi.co/api/v2/pokemon/{idPokemon}");
        var nomeDoPokemon = JsonSerializer.Deserialize<ModeloPokemon>(conexao)!;

        nomeDoPokemon.ExibirDetalhes();
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Erro: {ex.Message}");
    }
}

