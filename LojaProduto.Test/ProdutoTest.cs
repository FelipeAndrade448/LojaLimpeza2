using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LojaProduto.Test
{
    [TestClass]
    public class ProdutoTest
    {
        [TestMethod]
        public void TestAdicionarEstoque()
        {
            var produto = new Domain.Produto()
            {
                Codigo = 1,
                Nome = "Detergente",
                QuantidadeEmEstoque = 10
            };

            produto.AdicionarEstoque(5);

            Assert.AreEqual(produto.QuantidadeEmEstoque, 15);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "Quantidade deve ser maior que zero")]
        public void TestAdicionarEstoqueValorNegativo()
        {
            var produto = new Domain.Produto()
            {
                Codigo = 1,
                Nome = "Detergente",
                QuantidadeEmEstoque = 10
            };

            produto.AdicionarEstoque(-1);
        }
    }
}
