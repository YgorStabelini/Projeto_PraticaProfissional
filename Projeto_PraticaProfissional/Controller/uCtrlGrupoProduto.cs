using Projeto_PraticaProfissional.Dao;
using Projeto_PraticaProfissional.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_PraticaProfissional.Controller
{
    public class uCtrlGrupoProduto
    {
        private GrupoProduto Grupoprodutos = new GrupoProduto();
        private GrupoProdutoDAO DaoGrupoProduto = new GrupoProdutoDAO();
        public uCtrlGrupoProduto()
        {

        }
        public void Salvar(GrupoProduto Grupoprodutos)
        {
            Grupoprodutos = Grupoprodutos;
            DaoGrupoProduto.CadastrarGrupoProdutos(Grupoprodutos);
        }
    }
}
