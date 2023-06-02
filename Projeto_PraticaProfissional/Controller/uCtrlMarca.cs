using Projeto_PraticaProfissional.Dao;
using Projeto_PraticaProfissional.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_PraticaProfissional.Controller
{
    public class uCtrlMarca
    {
        private Marca Marcas = new Marca();
        private MarcaDAO DaoMarca = new MarcaDAO();
        public uCtrlMarca()
        {

        }
        public void Salvar(Marca Marcas)
        {
            Marcas = Marcas;
            DaoMarca.CadastrarMarca(Marcas);
        }
    }
}
