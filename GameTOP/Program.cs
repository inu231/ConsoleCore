using System;
using GameTOP.lib;

namespace GameTOP
{
    class Program
    {
        static void Main(string[] args)
        {
            var jogo = new JogoFODA(new Jogador3("Jonas"), new Jogador1("Neymar"));
            jogo.IniciarJogo();
        }
    }
}
