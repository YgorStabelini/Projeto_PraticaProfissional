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
    public class EstadoDAO
    {
        private MySqlConnection conexao;

        public EstadoDAO()
        {
            this.conexao = new ConnectionFactory().getconnection();
        }

        public void CadastrarEstado(Estado obj)
        {
            try
            {

                string sql = @"insert into tb_Estado (Nome_Estado, UF, DataCad, DataAlt, Id_Pais)
                                values (@nome, @Uf, @DataCad, @DataAlt, @Id_Pais)";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", obj.Descricao);
                executacmd.Parameters.AddWithValue("@Uf", obj.UF);
                executacmd.Parameters.AddWithValue("@DataCad", obj.DataCad);
                executacmd.Parameters.AddWithValue("@DataAlt", obj.DataAlt);
                executacmd.Parameters.AddWithValue("@Id_Pais", obj.IdPais);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Estado Cadastrado com sucesso");

                conexao.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show("Verificar Cadastro" + erro);
            }
        }

        public void AlterarEstado(Estado obj)
        {

        }

        public void ExcluirEstado(Estado obj)
        {
            try
            {
                string sql = @"delete from tb_Estado where Cod_Estado = @id";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                executacmd.Parameters.AddWithValue("@id", obj.Id);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Estado Excluido com sucesso");

                conexao.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show("Verificar Cadastro" + erro);
            }
        }

        public DataTable ListarEstado()
        {
            try
            {
                DataTable tabelaEstado = new DataTable();

                string sql = "select Cod_Estado, Nome_Estado, UF, tb_Pais.Nome_Pais from tb_Estado Inner Join tb_Pais ON tb_Pais.Cod_Pais = tb_Estado.id_Pais";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelaEstado);

                conexao.Close();

                return tabelaEstado;

            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao executar o comando sql" + erro);
                return null;
            }
        }
    }
}
