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
    public class UndMedidaDAO
    {
        private MySqlConnection conexao;

        public UndMedidaDAO()
        {
            this.conexao = new ConnectionFactory().getconnection();
        }

        public void CadastrarUndMedida(UnidadeDeMedida obj)
        {
            try
            {

                string sql = @"insert into tb_undmedida (Nome_UndMedida, Abreviacao, DataCad, DataAlt)
                                values (@nome, @Abreviacao, @DataCad, @DataAlt)";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", obj.Descricao);
                executacmd.Parameters.AddWithValue("@Abreviacao", obj.Abreviacao);
                executacmd.Parameters.AddWithValue("@DataCad", obj.DataCad);
                executacmd.Parameters.AddWithValue("@DataAlt", obj.DataAlt);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Unidade de Medida Cadastrado com sucesso");

                conexao.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show("Verificar Cadastro" + erro);
            }
        }

        public void AlterarUndMedida(UnidadeDeMedida obj)
        {

        }

        public void ExcluirUndMedida(UnidadeDeMedida obj)
        {
            try
            {
                string sql = @"delete from tb_undmedida where Cod_UndMedida = @id";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                executacmd.Parameters.AddWithValue("@id", obj.Id);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Unidade de Medida Excluido com sucesso");

                conexao.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show("Verificar Cadastro" + erro);
            }
        }

        public DataTable ListarUndMedida()
        {
            try
            {
                DataTable tabelaUndMedida = new DataTable();

                string sql = "select Cod_UndMedida, Nome_UndMedida, Abreviacao from tb_undmedida";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelaUndMedida);

                conexao.Close();

                return tabelaUndMedida;

            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao executar o comando sql" + erro);
                return null;
            }

        }
    }
}
