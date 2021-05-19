using GameTOP.Interface;

namespace GameTOP.Lib
{
public class Jogador1 : iJogador
    {
        public readonly string _nome;

        public Jogador1(string nome = "Ronaldo")
        {
            _nome = nome;
        }

        //chuta
        public string Chuta()
        {
            return $"{_nome} está chutando";
        }
        //corre
        public string Corre()
        {
            return $"{_nome} está correndo";
        }

        //passe
        public string Passa()
        {
            return $"{_nome} está passando";
        }
    }
}