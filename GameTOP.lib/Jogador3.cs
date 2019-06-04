using GameTOP.Interface;

namespace GameTOP.lib
{
    public class Jogador3 : iJogador
    {
        public string _nome;
        public Jogador3(string nome = "João")
        {
            _nome = nome;
        }

        public string Chuta()
        {
            return $"{_nome} com um(a) chute diferente! \n";
        }

        public string Corre()
        {
            return $"{_nome} com um(a) corrida diferente! \n";
        }

        public string Passe()
        {
            return $"{_nome} com um(a) passe diferente! \n";
        }
    }
}