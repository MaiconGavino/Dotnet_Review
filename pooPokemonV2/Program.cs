namespace pooPokemonV2
{
    class program
    {
        public static void Main(string[] args)
        {
            Pokemon poke = new Pokemon();
            poke.Name = "tauros";
            poke.Tipo = "fogo";
            poke.ExibirDados();
        }
    }
}