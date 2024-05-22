// public record class Pokemon();

// public record class Pokemon(
// 	[property: JsonPropertyName("name")] string Name
// );

// public record class Pokemon(
//     [property: JsonPropertyName("id")] int Id,
// 	[property: JsonPropertyName("name")] string Name
// );

// public record class Pokemon(
//     [property: JsonPropertyName("id")] int Id,
// 	[property: JsonPropertyName("name")] string Name
// );




// public record class Pokemon(
//     [property: JsonPropertyName("id")] int Id,
// 	[property: JsonPropertyName("name")] string Name,
//     // We created an array of Moveset to hold all the data
//     [property: JsonPropertyName("moves")] Moveset[] Moves
// );
// // We created a Moveset class to pull the move from inside the object
// public record class Moveset(
//     [property: JsonPropertyName("move")] GetName Move
// );
// // However, the "move" object itself also has nested data
// // so we built ANOTHER record class to access the name inside the move object inside the moves array
// public record class GetName(
//     [property: JsonPropertyName("name")] string Name
// );


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