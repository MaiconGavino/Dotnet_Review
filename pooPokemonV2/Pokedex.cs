namespace pooPokemonV2;

public class Pokedex
{
    private List<Pokemon> pokemons;
    
    public List<Pokemon> Pokemons { get => pokemons; set => pokemons = value; }

    public Pokedex()
    {
        pokemons = new List<Pokemon>();
    }

    public void AddPokemon(string nome, string desc)
    {
        var novoPokemon = new Pokemon(nome, desc);
        Pokemons.Add(novoPokemon);
    }

    public void ExibirPokemons()
    {
        foreach (var pokemon in pokemons)
        {
            pokemon.ExibirDados();
        }
    }
    
    
}