using GameTOP.Interface;

namespace GameTOP.Lib
{
    public class Jogador2 : iJogador
    {

        public readonly string _nome;

        public Jogador2(string nome = "Maradona")
        {
            _nome = nome;
        }

        public string Chuta()
        {
            return $"{_nome} estas corriendo";;
        }

        public string Corre()
        {
            return $"{_nome} está corriendo";;
        }

        public string Passa()
        {
            return $"{_nome} está pasando";;
        }
    }
}