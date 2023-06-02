using Projeto_PraticaProfissional.Dao;
using Projeto_PraticaProfissional.Models;
using System;
using System.Collections.Generic;
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

    }
}

