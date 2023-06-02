using Projeto_PraticaProfissional.Dao;
using Projeto_PraticaProfissional.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_PraticaProfissional.Controller
{
    public class uCtrlCliente
    {
        private Cliente Clientes = new Cliente();
        private ClienteDAO DaoCliente = new ClienteDAO();
        public uCtrlCliente()
        {

        }
        public void Salvar(Cliente Clientes)
        {
            Clientes = Clientes;
            DaoCliente.CadastrarCliente(Clientes);
        }
    }
}
