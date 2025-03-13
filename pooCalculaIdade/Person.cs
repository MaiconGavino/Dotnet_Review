using System.Runtime.CompilerServices;

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

        //melhorando o código
        public int Idade
        {
            get
            {
                this.CalcularIdade();
                return this.idade;
            }
            //get { return this.idade =  DateTime.Now.Year - this.anoNascimento; }
        }

        public void ExibirDados()
        {
            Console.WriteLine("Nome: " + this.Nome + "\nAno: " + this.Ano + "\nIdade:" + this.Idade);
        }

        private void CalcularIdade()
        {
            int ano = DateTime.Now.Year;
            this.idade = ano - this.anoNascimento;
        }
    }
}