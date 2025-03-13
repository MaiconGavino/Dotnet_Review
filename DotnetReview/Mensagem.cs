namespace pooMensagem
{

    public class Mensagem
    { 
        // private String TextoMensagem;
        //
        // public void ExibirMensagem()
        // {
        //     Console.WriteLine(this.TextoMensagem);
        // }
        //
        // public String getTextoMensagem()
        // {
        //     return this.TextoMensagem;
        // }
        //
        // public void setTextoMensagem(String textoMensagem)
        // {
        //     this.TextoMensagem = textoMensagem.ToUpper();
        // }
        
        private string textoMensagem;

        public String TextoMensagem
        {
            get { return this.textoMensagem; }
            set { this.textoMensagem = value.ToUpper(); }
        }

        public void ExibirMensagem()
        {
            Console.WriteLine(this.TextoMensagem);
        }
    }
}