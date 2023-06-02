using Projeto_PraticaProfissional.Dao;
using Projeto_PraticaProfissional.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_PraticaProfissional.Controller
{
    public class uCtrlFuncionario
    {
        private Funcionario Funcionarios = new Funcionario();
        private FuncionarioDAO DaoFuncionario = new FuncionarioDAO();
        public uCtrlFuncionario()
        {

        }
        public void Salvar(Funcionario Funcionarios)
        {
            Funcionarios = Funcionarios;
            DaoFuncionario.CadastrarFuncionario(Funcionarios);
        }
    }
}
