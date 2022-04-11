using System;
using tabuleiro;

namespace Xadrez
{
    class PartidaXadrez
    {
        public Tabuleiro Tab { get; private set; }

        public int Turno { get; private set; }
        public Color JogadorAtual { get; private set; }
        public bool Terminada { get; private set; }

        public PartidaXadrez()
        {
            Tab = new Tabuleiro(8, 8);
            Turno = 1;
            JogadorAtual = Color.Branca;
            ColocarPecas();
        }

        public void ExecutarMovimento(Posicao origem, Posicao destino)
        {
            Peca p = Tab.RetirarPeca(origem);
            p.IncrementarQntdMovimentos();
            Peca pecaCapturada = Tab.RetirarPeca(destino);
            Terminada = false;
            Tab.ColocarPeca(p,destino);
        }

        public void RealizaJogada(Posicao origem, Posicao destino)
        {
            ExecutarMovimento(origem, destino);
            Turno++;
            MudarJogador();
        }

        public void validarPosicaoDeOrigem(Posicao pos)
        {
            if (Tab.peca(pos) == null)
            {
                throw new TabuleiroException("Não existe peça nessa posição de origem escolhida!");
            }
            if (JogadorAtual != Tab.peca(pos).Cor)
            {
                throw new TabuleiroException("A peça de origem escolhida não é sua!");
            }
            if (!Tab.peca(pos).ExisteMovimentosPossiveis())
            {
                throw new TabuleiroException("Não há lances permitidos para a peça de origem escolhida!");
            }
        }

        public void ValidarPosicaoDeDestino(Posicao origem, Posicao destino)
        {
            if (!Tab.peca(origem).PodeMoverPara(destino))
            {
                throw new TabuleiroException("Posição de destino inválida!");
            }
        }

        private void MudarJogador()
        {
            if(JogadorAtual == Color.Branca)
            {
                JogadorAtual = Color.Preta;
            }
            else
            {
                JogadorAtual = Color.Branca;
            }
        }
        private void ColocarPecas()
        {
            Tab.ColocarPeca(new Rei(Color.Branca, Tab), new NotacaoXadrez('e',1).ToPosicao());
            Tab.ColocarPeca(new Torre(Color.Branca, Tab), new NotacaoXadrez('a', 1).ToPosicao());
            Tab.ColocarPeca(new Torre(Color.Branca, Tab), new NotacaoXadrez('h', 1).ToPosicao());
            Tab.ColocarPeca(new Torre(Color.Branca, Tab), new NotacaoXadrez('d', 1).ToPosicao());
            Tab.ColocarPeca(new Torre(Color.Branca, Tab), new NotacaoXadrez('d', 2).ToPosicao());
            Tab.ColocarPeca(new Torre(Color.Branca, Tab), new NotacaoXadrez('c', 1).ToPosicao());
            Tab.ColocarPeca(new Torre(Color.Branca, Tab), new NotacaoXadrez('c', 2).ToPosicao());

            Tab.ColocarPeca(new Torre(Color.Preta, Tab), new NotacaoXadrez('h', 8).ToPosicao());
            Tab.ColocarPeca(new Torre(Color.Preta, Tab), new NotacaoXadrez('a', 8).ToPosicao());
            Tab.ColocarPeca(new Rei(Color.Preta, Tab), new NotacaoXadrez('e', 8).ToPosicao());
        }
    }
}
