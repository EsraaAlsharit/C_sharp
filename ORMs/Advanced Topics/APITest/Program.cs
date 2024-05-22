using System.Net.Http.Headers;
using System.Text.Json;
using HttpClient client = new();
client.DefaultRequestHeaders.Accept.Clear();
client.DefaultRequestHeaders.Accept.Add(
    new MediaTypeWithQualityHeaderValue("application/json"));


// Program.cs code above removed for brevity
static async Task<Pokemon> ProcessPokemonAsync(HttpClient client, string url)
{
    await using Stream stream =
    await client.GetStreamAsync(url);
    Pokemon? Result =
        await JsonSerializer.DeserializeAsync<Pokemon>(stream);
    return Result;
}

// Program.cs code above removed for brevity
Pokemon OnePoke = await ProcessPokemonAsync(client, "https://pokeapi.co/api/v2/pokemon/pikachu");
Console.WriteLine($"I choose you, {OnePoke.Name}!");

// Program.cs code above removed for brevity
Pokemon OnePokes = await ProcessPokemonAsync(client, "https://pokeapi.co/api/v2/pokemon/bulbasaur");
foreach(PokeTypes t in OnePokes.Types)
{
    Console.WriteLine($" - {t.Type.Name}");
}