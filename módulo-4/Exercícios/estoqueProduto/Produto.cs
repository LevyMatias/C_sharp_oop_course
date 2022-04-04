using System;
using System.Globalization;

namespace estoqueProduto
{
    public class Produto
    {
        public String Nome { get; set; }
        public double Preco { get; set; }
        public double Quantidade { get; set; }


        public override string ToString()
        {
            return Nome
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
        public void AdicionarProduto(int quantidade)
        {

            Quantidade += quantidade;
        }
        public void RemoverProduto(int quantidade)
        {

            Quantidade -= quantidade;
        }
        public double ValorTotalEmEstoque()
        {
            return Quantidade * Preco;
        }
    }
}