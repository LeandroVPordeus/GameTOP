using System;

namespace GameTOP
{
    class Program
    {
        static void Main(string[] args)
        {
            var jogo = new JogoFODA();
            jogo.IniciarJogo();
        }
    }

    class JogoFODA
    {
        public JogoFODA(string nome)
        {
            
        }
        public void IniciarJogo()
        {
            Console.Write($"{}Jogador deu Um Passe");
        }

    }
    
}
