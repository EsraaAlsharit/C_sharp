using System.Text.Json.Serialization;
public record class Pokemon(
    [property: JsonPropertyName("id")] int Id,
    [property: JsonPropertyName("name")] string Name,
    [property: JsonPropertyName("sprites")] Sprites Image,
    [property: JsonPropertyName("types")] PokeTypes[] Types,
    [property: JsonPropertyName("moves")] Moveset[] Moves
);
public record class Sprites(
    [property: JsonPropertyName("front_default")] string front,
    [property: JsonPropertyName("front_shiny")] string frontShiny,
    [property: JsonPropertyName("front_male")] string male,
    [property: JsonPropertyName("front_female")] string female
);
public record class GetName(
    [property: JsonPropertyName("name")] string Name
);
public record class PokeTypes(
    [property: JsonPropertyName("type")] GetName Type
);
public record class Moveset(
    [property: JsonPropertyName("move")] GetName Move
);