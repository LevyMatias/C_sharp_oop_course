namespace tabuleiro
{
    abstract class Peca
    {
        public Posicao Posicao { get; set; }
        public Color Cor { get; protected set; }
        public int QntdMovimentos { get; protected set; }
        public Tabuleiro Tab { get; protected set; }

        public Peca(Color cor, Tabuleiro tab)
        {
            Posicao = null;
            Cor = cor;
            Tab = tab;
            QntdMovimentos = 0;
        }

        public void IncrementarQntdMovimentos()
        {
            QntdMovimentos++;
        }

        public abstract bool[,] MovimentosPossiveis();
    }
}
