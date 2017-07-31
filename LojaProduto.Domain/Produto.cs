using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaProduto.Domain
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public int QuantidadeEmEstoque { get; set; }

        public void AdicionarEstoque(int quantidade)
        {
            if (quantidade > 0)
                this.QuantidadeEmEstoque += quantidade;
            else
                throw new Exception("Quantidade deve ser maior que zero");
        }

        public void RemoverEstoque(int quantidade)
        {
            if (quantidade > 0)
                this.QuantidadeEmEstoque -= quantidade;
            else
                throw new Exception("Quantidade deve ser maior que zero");
        }
    }
}
