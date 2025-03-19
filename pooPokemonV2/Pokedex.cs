namespace pooPokemonV2;

public class Pokedex
{
    private List<Pokemon> _pokemons;
    
    public List<Pokemon> Pokemons { get => _pokemons; set => _pokemons = value; }

    public Pokedex()
    {
        _pokemons = new List<Pokemon>();
    }

    public void AddPokemon(string nome, string tipo)
    {
        var novoPokemon = new Pokemon(nome, tipo);
        _pokemons.Add(novoPokemon);
    }

    public void ExibirPokemons()
    {
        if (_pokemons.Count == 0)
        {
            Console.WriteLine("Nenhum pokémon cadastrado.");
            return;
        }
        foreach (var pokemon in _pokemons)
        {
            pokemon.ExibirDados();
        }
    }

    public void AlterarPokemon(string nome, string novoTipo)
    {
        bool existe = false;
        foreach (var poke  in _pokemons)
        {
            if (poke.Name.Equals(nome, StringComparison.OrdinalIgnoreCase))
            {
                poke.Tipo = novoTipo;
                existe = true;
            }
            if (!existe)
            {
                Console.WriteLine("Pokemon não Encontrado para alteração.");
            }
        }
    }

    public void DeletePokemon(string nome)
    {
        int removido = _pokemons.RemoveAll(x => x.Name.Equals(nome, StringComparison.OrdinalIgnoreCase));
        if (removido == 0)
        {
            Console.WriteLine("Nenhum Pokémon foi removido, pois não foi encontrado.");
        }
        else
        {
            Console.WriteLine($"{removido} Pokemon(s) removido(s) da Pokedex");
        }
    }
    
}