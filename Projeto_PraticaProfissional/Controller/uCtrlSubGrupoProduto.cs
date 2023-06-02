using Projeto_PraticaProfissional.Dao;
using Projeto_PraticaProfissional.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_PraticaProfissional.Controller
{
    public class uCtrlSubGrupoProduto
    {
        private SubGrupoProduto SubGrupos = new SubGrupoProduto();
        private SubGrupoProdutoDAO DaoSubGrupo = new SubGrupoProdutoDAO();
        public uCtrlSubGrupoProduto()
        {

        }
        public void Salvar(SubGrupoProduto SubGrupos)
        {
            SubGrupos = SubGrupos;
            DaoSubGrupo.CadastrarSubGrupoProdutos(SubGrupos);
        }
    }
}
