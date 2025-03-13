namespace pooMensagem
{

    public class Mensagem
    { 
        private String TextoMensagem;

        public void ExibirMensagem()
        {
            Console.WriteLine(this.TextoMensagem);
        }

        public String getTextoMensagem()
        {
            return this.TextoMensagem;
        }

        public void setTextoMensagem(String textoMensagem)
        {
            this.TextoMensagem = textoMensagem.ToUpper();
        }
    }
}