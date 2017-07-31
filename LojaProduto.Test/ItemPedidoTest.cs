using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LojaProduto.Test
{
    [TestClass]
    public class ItemPedidoTest
    {
        [TestMethod]
        public void TestCalculaTotalItem()
        {
            var produto = new Domain.Produto()
            {
                Codigo = 1,
                Nome = "Detergente",
                QuantidadeEmEstoque = 10,
                Preco = 5
            };

            var item = new Domain.ItemPedido(produto, 5);

            Assert.AreEqual(25, item.TotalItem);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "Quantidade superior ao estoque")]
        public void TestAdicionarAcimaDoEstoque()
        {
            var produto = new Domain.Produto()
            {
                Codigo = 1,
                Nome = "Detergente",
                QuantidadeEmEstoque = 10,
                Preco = 5
            };

            var item = new Domain.ItemPedido(produto, 15);
        }

        [TestMethod]
        public void TestQuantidadeEmEstoque()
        {
            var produto = new Domain.Produto()
            {
                Codigo = 1,
                Nome = "Detergente",
                QuantidadeEmEstoque = 10,
                Preco = 5
            };

            var item = new Domain.ItemPedido(produto, 5);

            Assert.AreEqual(5, item.Produto.QuantidadeEmEstoque);
        }
    }
}
