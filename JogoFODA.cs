using System;

namespace GameTOP
{
    public class JogoFODA
{
    private readonly Jogador _jogador;
    public JogoFODA(Jogador jogador)
    {
        _jogador = _jogador;
    }
    public void IniciarJogo()
    {
        Console.Write($"{_jogador.nome}Jogador deu Um Passe");
    }
}
    
}