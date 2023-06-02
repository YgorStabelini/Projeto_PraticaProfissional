using Projeto_PraticaProfissional.Dao;
using Projeto_PraticaProfissional.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_PraticaProfissional.Controller
{
    public class uCtrlFornecedor
    {
        private Fornecedor Fornecedores = new Fornecedor();
        private FornecedorDAO DaoFornecedor = new FornecedorDAO();
        public uCtrlFornecedor()
        {

        }
        public void Salvar(Fornecedor Fornecedores)
        {
            //Fornecedores = Fornecedores;
            //DaoFornecedor.CadastrarFornecedor(Fornecedores);
        }
    }
}
