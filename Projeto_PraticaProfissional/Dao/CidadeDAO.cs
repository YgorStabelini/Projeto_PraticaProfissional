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
    public class CidadeDAO
    {
        private MySqlConnection conexao;

        public CidadeDAO()
        {
            this.conexao = new ConnectionFactory().getconnection();
        }

        public void CadastrarCidade(Cidade obj)
        {
            try
            {

                string sql = @"insert into tb_Cidade (Nome_Cidade, DataCad, DataAlt, Id_Estado)
                                values (@nome, @DataCad, @DataAlt, @Id_Estado)";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", obj.Descricao);
                executacmd.Parameters.AddWithValue("@DataCad", obj.DataCad);
                executacmd.Parameters.AddWithValue("@DataAlt", obj.DataAlt);
                executacmd.Parameters.AddWithValue("@Id_Estado", obj.IdEstado);

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

        public void AlterarCidade()
        {

        }

        public void ExcluirCidade(Cidade obj)
        {
            try
            {
                string sql = @"delete from tb_Cidade where Cod_Cidade = @id";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                executacmd.Parameters.AddWithValue("@id", obj.Id);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Cidade Excluido com sucesso");

                conexao.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show("Verificar Cadastro" + erro);
            }
        }

        public DataTable ListarCidade()
        {
            {
                try
                {
                    DataTable tabelaCidade = new DataTable();

                    string sql = @"select Cod_Cidade, Nome_Cidade, tb_Estado.Nome_Estado, tb_pais.Nome_Pais from tb_Cidade
                                 Inner Join tb_Estado on (Tb_Estado.Cod_Estado = Tb_Cidade.id_Estado)
                                 Inner join tb_pais on (Tb_Estado.Id_Pais = tb_pais.Cod_Pais)";

                    MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                    conexao.Open();
                    executacmd.ExecuteNonQuery();

                    MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                    da.Fill(tabelaCidade);

                    conexao.Close();

                    return tabelaCidade;

                }
                catch (Exception erro)
                {
                    MessageBox.Show("Erro ao executar o comando sql" + erro);
                    return null;
                }
            }
        }
    }
}
