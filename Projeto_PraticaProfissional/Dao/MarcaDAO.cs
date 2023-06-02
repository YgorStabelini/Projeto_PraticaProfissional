using MySql.Data.MySqlClient;
using Projeto_PraticaProfissional.Conexao;
using Projeto_PraticaProfissional.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_PraticaProfissional.Dao
{
    public class MarcaDAO
    {
        private MySqlConnection conexao;

        public MarcaDAO()
        {
            this.conexao = new ConnectionFactory().getconnection();
        }

        public void CadastrarMarca(Marca obj)
        {
            try
            {

                string sql = @"insert into tb_marca (Nome_Marca, DataCad, DataAlt)
                                values (@nome, @DataCad, @DataAlt)";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", obj.Descricao);
                executacmd.Parameters.AddWithValue("@DataCad", obj.DataCad);
                executacmd.Parameters.AddWithValue("@DataAlt", obj.DataAlt);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Marca Cadastrado com sucesso");

                conexao.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show("Verificar Cadastro" + erro);
            }
        }

        public void AlterarMarca(Marca obj)
        {

        }

        public void ExcluirMarca(Marca obj)
        {
            try
            {
                string sql = @"delete from tb_marca where Cod_Marca = @id";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                executacmd.Parameters.AddWithValue("@id", obj.Id);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Marca Excluido com sucesso");

                conexao.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show("Verificar Cadastro" + erro);
            }
        }

        public DataTable ListarMarca()
        {
            try
            {
                DataTable tabelaMarca = new DataTable();

                string sql = "select Cod_Marca, Nome_Marca from tb_marca";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelaMarca);

                conexao.Close();

                return tabelaMarca;

            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao executar o comando sql" + erro);
                return null;
            }

        }
    }
}
