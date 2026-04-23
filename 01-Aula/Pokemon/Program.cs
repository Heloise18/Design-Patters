using Doke.Pokedex;
using Doke.Pokedex.Enum;

Console.WriteLine(new string('=',40) + "Poke Battle!" + new string('=',40));




Pokemons Charizard = new(
    "Charizard",
    60,
    PokemonType.Fire,
    [
        new Attack (
           "FireBall",
            4,
           PokemonType.Fire
        ),
        new Attack(
            "Explosion",
            6,
            PokemonType.Fire
        ),
        new Attack(
            "Bamm",
            10,
            PokemonType.Ground
        ),
        new Attack(
            "Bafo quente",
            5,
            PokemonType.Dragon
        ),
        new Attack(
            "Mordida",
            15,
            PokemonType.Dragon
        )
    ]
);

Pokemons Glaceon = new(
    "Eevee Ice",
    60,
    PokemonType.Fire,
    [
        new Attack (
           "Nevasca",
            8,
           PokemonType.Ice
        ),
        new Attack(
            "Estalactites",
            12,
            PokemonType.Ice
        ),
        new Attack(
            "Agua Gelada",
            3,
            PokemonType.Water
        ),
        new Attack(
            "Rabada",
            4,
            PokemonType.Normal
        ),
        new Attack(
            "Pulo",
            2,
            PokemonType.Normal
        )
    ]
);

Pokemons Ditto = new(
    "Ditto",
    60,
    PokemonType.Psychic,
    [
        new Attack (
           "Transform",
            0,
           PokemonType.Psychic
        )
    ]
);

Pokemons Winner;
// static Pokemons Battle(Pokemons pokemon1, Pokemons Ditto, Pokemons Winner )

// {
//     int atackP1 = Random.Shared.Next(0,4);
//     int atackP2 = Random.Shared.Next(0,4);

//     pokemon1.HP -= pokemon1.Strikes[atackP1].Damage;
    
//     Console.WriteLine($"{pokemon1.Name}            |   {Ditto.Name}");
//     Console.WriteLine($"Attack: {pokemon1.Strikes[atackP1].Name}          {Ditto.Strikes[atackP2].Name}");
//     Console.WriteLine($"HP: {pokemon1.HP}                   {Ditto.HP}");

//     if(pokemon1.HP > Ditto.HP)
//         Winner = pokemon1;
//     else
//         Winner = Ditto;

//     if (pokemon1.HP < 0)
//        return Ditto;
//     if(Ditto.HP < 0)
//         return pokemon1;
// }
 

Console.WriteLine(new string('=',20) + "Vencedor!" + new string('=',20));
Console.WriteLine($"O vencedor é {Winner.Name}");
Console.WriteLine($"Vida Restante: {Winner.HP}");
