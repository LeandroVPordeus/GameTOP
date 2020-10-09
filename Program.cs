using System;

namespace GameTOP
{
    class Program
    {
        static void Main(string[] args)
        {
            var jogo = new JogoFODA(new Jogador("BoNaldo"));
            jogo.IniciarJogo();
        }
    }

    class Jogador
    {
        public readonly string _Nome;
        public Jogador(string nome)
        {
            _Nome = nome;
        }

        public void Chuta()
        {
            Console.Write($"{_Nome}Esta Chutando");
        }
        public void Corre()
        {
            Console.Write($"{_Nome}Esta Correndo");
        }
        public void Pases()
        {
            Console.Write($"{_Nome}Esta Passando");
        }
        
    }
       
}
