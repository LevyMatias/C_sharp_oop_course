using tabuleiro;

namespace Xadrez
{
    class Torre : Peca
    {
        public Torre(Color cor, Tabuleiro tab) : base(cor, tab)
        {
        }

        public override string ToString()
        {
            return "T";
        }
    }
}
