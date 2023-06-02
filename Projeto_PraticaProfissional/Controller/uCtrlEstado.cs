using Projeto_PraticaProfissional.Dao;
using Projeto_PraticaProfissional.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_PraticaProfissional.Controller
{
    public class uCtrlEstado
    {
        private Estado estados = new Estado();
        private EstadoDAO DaoEstado = new EstadoDAO();
        public uCtrlEstado()
        {

        }
        public void Salvar(Estado estados)
        {
            estados = estados;
            DaoEstado.CadastrarEstado(estados);
        }

    }
}
