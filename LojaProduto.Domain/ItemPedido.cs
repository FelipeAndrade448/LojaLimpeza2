using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaProduto.Domain
{
    public class ItemPedido
    {
        private int quantidade;
        private Produto produto;
        private decimal totalItem;

        public int Quantidade { get { return this.quantidade; } }
        public Produto Produto { get { return this.produto; } }
        public decimal TotalItem { get { return this.totalItem; } }

        public ItemPedido(Produto produto, int quantidade) {

            this.produto = produto;
            this.quantidade = quantidade;

            ValidaQuantidadeEstoque();

            this.Produto.RemoverEstoque(this.Quantidade);

            CalculaTotalItem();
        }

        private void ValidaQuantidadeEstoque()
        {
            if (this.Quantidade > this.Produto.QuantidadeEmEstoque)
                throw new Exception("Quantidade superior ao estoque");
        }
        
        private void CalculaTotalItem() {
            this.totalItem = this.Produto.Preco * this.Quantidade;
        }
    }
}
