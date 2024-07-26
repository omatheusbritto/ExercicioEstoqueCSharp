using System;
using System.Globalization;
namespace ExercicioEstoque
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Qtd;

        public double ValorTotalEmEstoque()
        {

            return (double)Preco * (int)Qtd;

        }
        public void ExcluirProduto(int qtd)
        {
            Qtd -= qtd;

        }
        public void AdicionarProduto(int qtd)
        {
            Qtd += qtd;

        }
        public override string ToString()
        {
            return "Produto "
                + Nome
                + " | Valor unitario R$"
                + Preco.ToString("F2")
                + " | Qtda "
                + Qtd
                + " | Valor Total R$"
                + ValorTotalEmEstoque().ToString("F2");
        }
    }
}
