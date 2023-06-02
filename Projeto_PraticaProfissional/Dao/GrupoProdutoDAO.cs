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
    public class GrupoProdutoDAO
    {
        private MySqlConnection conexao;

        public GrupoProdutoDAO()
        {
            this.conexao = new ConnectionFactory().getconnection();
        }

        public void CadastrarGrupoProdutos(GrupoProduto obj)
        {
            try
            {

                string sql = @"insert into tb_grupoproduto (Nome_GrupoProduto, DataCad, DataAlt)
                                values (@nome, @DataCad, @DataAlt)";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", obj.Descricao);
                executacmd.Parameters.AddWithValue("@DataCad", obj.DataCad);
                executacmd.Parameters.AddWithValue("@DataAlt", obj.DataAlt);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Cliente Cadastrado com sucesso");

                conexao.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show("Verificar Cadastro" + erro);
            }
        }

        public void AlterarGrupoProdutos(GrupoProduto obj)
        {

        }

        public void ExcluirGrupoProdutos(GrupoProduto obj)
        {
            try
            {
                string sql = @"delete from tb_GrupoProduto where Cod_GrupoProduto = @id";

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

        public DataTable ListaGrupoProdutos()
        {
            try
            {
                DataTable tabelaGrupoProduto = new DataTable();

                string sql = "select Cod_GrupoProduto, Nome_GrupoProduto from tb_GrupoProduto";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelaGrupoProduto);

                conexao.Close();

                return tabelaGrupoProduto;

            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao executar o comando sql" + erro);
                return null;
            }
        }
    }
}
