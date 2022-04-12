using tabuleiro;

namespace Xadrez
{
    class Rei : Peca
    {
        public Rei(Tabuleiro tab, Color cor) : base(cor, tab)
        {
        }

        public override string ToString()
        {
            return "R";
        }

        private bool Movimento(Posicao pos)
        {
            Peca p = Tab.peca(pos);
            return p == null || p.Cor != Cor;
        }

        public override bool[,] MovimentosPossiveis()
        {
            bool[,] mat = new bool[Tab.Linhas, Tab.Colunas];

            Posicao pos = new Posicao(0,0);

            // movimento norte
            pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna);
            if (Tab.PosicaoValida(pos) && Movimento(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }
            
            // movimento nordeste
            pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna + 1);
            if (Tab.PosicaoValida(pos) && Movimento(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }
            
            // movimento leste
            pos.DefinirValores(Posicao.Linha, Posicao.Coluna + 1);
            if (Tab.PosicaoValida(pos) && Movimento(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }
            
            // movimento sudeste
            pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna + 1);
            if (Tab.PosicaoValida(pos) && Movimento(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }
            
            // movimento sul
            pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna);
            if (Tab.PosicaoValida(pos) && Movimento(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }
            
            // movimento sudoeste
            pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna - 1);
            if (Tab.PosicaoValida(pos) && Movimento(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }
            
            // movimento oeste
            pos.DefinirValores(Posicao.Linha, Posicao.Coluna - 1);
            if (Tab.PosicaoValida(pos) && Movimento(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }
            
            // movimento noroeste
            pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna - 1);
            if (Tab.PosicaoValida(pos) && Movimento(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }

            return mat;
        }

    }
}
