using Projeto_PraticaProfissional.Dao;
using Projeto_PraticaProfissional.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_PraticaProfissional.Controller
{
    public class uCtrlProdutos
    {
        private Produto Produtos = new Produto();
        private ProdutoDAO DaoProduto = new ProdutoDAO();
        public uCtrlProdutos()
        {

        }
        public void Salvar(Produto Produtos)
        {
            Produtos = Produtos;
            DaoProduto.CadastrarProduto(Produtos);
        }
    }
}
