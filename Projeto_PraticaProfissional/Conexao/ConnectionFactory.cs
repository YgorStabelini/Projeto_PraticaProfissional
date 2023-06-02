using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_PraticaProfissional.Conexao
{
    public class ConnectionFactory
    {
        public MySqlConnection getconnection()
        {
            string conexao = ConfigurationManager.ConnectionStrings["bdprojeto"].ConnectionString;

            return new MySqlConnection(conexao);
        }
    }
}
