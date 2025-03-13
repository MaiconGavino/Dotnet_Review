namespace pooCalculaIdade
{
    public class Pessoa
    {
        private String nome;
        private int anoNascimento;
        private int idade;

        public String Nome
        {
            get { return this.nome; }
            set { this.nome = value; }
        }

        public int Ano
        {
            get { return this.anoNascimento; }
            set { this.anoNascimento = value; }
        }

        public int Idade
        {
            get { return this.idade =  DateTime.Now.Year - this.anoNascimento; }
        }

        public void ExibirDados()
        {
            Console.WriteLine("Nome: " + this.Nome + "\nAno: " + this.Ano + "\nIdade:" + this.Idade);
        }
    }
}