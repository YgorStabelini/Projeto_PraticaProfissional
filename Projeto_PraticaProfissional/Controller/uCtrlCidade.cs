using Projeto_PraticaProfissional.Dao;
using Projeto_PraticaProfissional.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_PraticaProfissional.Controller
{
    public class uCtrlCidade
    {
        private Cidade cidades = new Cidade();
        private CidadeDAO DaoCidade = new CidadeDAO();
        public uCtrlCidade()
        {

        }
        public void Salvar(Cidade cidades)
        {
            cidades = cidades;
            DaoCidade.CadastrarCidade(cidades);
        }

    }
}
