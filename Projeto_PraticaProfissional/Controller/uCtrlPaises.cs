using Projeto_PraticaProfissional.Dao;
using Projeto_PraticaProfissional.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_PraticaProfissional.Controller
{
    public class uCtrlPaises
    {
        private Pais pais = new Pais();
        private PaisDAO DaoPais = new PaisDAO();
        public uCtrlPaises()
        {

        }
        public void Salvar(Pais pais)
        {
            pais = pais;
            DaoPais.cadastrarPais(pais);
        }

        public DataTable Carregar()
        {
            return DaoPais.ListarPais();
        }

        public void Alterar(Pais pais)
        {
            pais = pais;
            DaoPais.AlterarPais(pais);
        }

        public void Excluir(Pais pais)
        {
            pais = pais;
            DaoPais.ExcluirPais(pais);
        }
    }
}

