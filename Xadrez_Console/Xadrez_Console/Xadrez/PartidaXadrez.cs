using System;
using tabuleiro;

namespace Xadrez
{
    class PartidaXadrez
    {
        public Tabuleiro Tab { get; private set; }

        private int _turno;

        private Color _jogadorAtual;
        public bool Terminada { get; private set; }

        public PartidaXadrez()
        {
            Tab = new Tabuleiro(8, 8);
            _turno = 1;
            _jogadorAtual = Color.Branca;
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

        private void ColocarPecas()
        {
            Tab.ColocarPeca(new Rei(Color.Branca, Tab), new NotacaoXadrez('e',1).ToPosicao());
            Tab.ColocarPeca(new Torre(Color.Branca, Tab), new NotacaoXadrez('a', 1).ToPosicao());
            Tab.ColocarPeca(new Torre(Color.Branca, Tab), new NotacaoXadrez('h', 1).ToPosicao());

            Tab.ColocarPeca(new Torre(Color.Branca, Tab), new NotacaoXadrez('h', 8).ToPosicao());
            Tab.ColocarPeca(new Torre(Color.Branca, Tab), new NotacaoXadrez('a', 8).ToPosicao());
            Tab.ColocarPeca(new Torre(Color.Branca, Tab), new NotacaoXadrez('d', 1).ToPosicao());
            Tab.ColocarPeca(new Torre(Color.Branca, Tab), new NotacaoXadrez('d', 2).ToPosicao());
            Tab.ColocarPeca(new Torre(Color.Branca, Tab), new NotacaoXadrez('c', 1).ToPosicao());
            Tab.ColocarPeca(new Torre(Color.Branca, Tab), new NotacaoXadrez('c', 2).ToPosicao());
            Tab.ColocarPeca(new Rei(Color.Branca, Tab), new NotacaoXadrez('e', 8).ToPosicao());
        }
    }
}
