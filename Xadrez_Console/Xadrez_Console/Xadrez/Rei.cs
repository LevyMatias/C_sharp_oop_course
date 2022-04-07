using tabuleiro;

namespace Xadrez
{
    class Rei : Peca
    {
        public Rei(Color cor, Tabuleiro tab) : base(cor, tab)
        {
        }

        public override string ToString()
        {
            return "R";
        }
    }
}
