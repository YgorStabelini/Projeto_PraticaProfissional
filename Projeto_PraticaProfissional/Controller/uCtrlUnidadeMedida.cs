using Projeto_PraticaProfissional.Dao;
using Projeto_PraticaProfissional.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_PraticaProfissional.Controller
{
    public class uCtrlUnidadeMedida
    {
        private UnidadeDeMedida UnidadeMedidas = new UnidadeDeMedida();
        private UndMedidaDAO DaoUndMedida = new UndMedidaDAO();
        public uCtrlUnidadeMedida()
        {

        }
        public void Salvar(UnidadeDeMedida UnidadeMedidas)
        {
            UnidadeMedidas = UnidadeMedidas;
            DaoUndMedida.CadastrarUndMedida(UnidadeMedidas);
        }
    }
}
