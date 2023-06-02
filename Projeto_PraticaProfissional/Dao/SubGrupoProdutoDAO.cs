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
    public class SubGrupoProdutoDAO
    {
        private MySqlConnection conexao;

        public SubGrupoProdutoDAO()
        {
            this.conexao = new ConnectionFactory().getconnection();
        }

        public void CadastrarSubGrupoProdutos(SubGrupoProduto obj)
        {
            try
            {

                string sql = @"insert into tb_subgrupo (Nome_SubGrupo, DataCad, DataAlt, Id_GrupoProduto)
                                values (@nome, @DataCad, @DataAlt, @Id_GrupoProduto)";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", obj.Descricao);
                executacmd.Parameters.AddWithValue("@DataCad", obj.DataCad);
                executacmd.Parameters.AddWithValue("@DataAlt", obj.DataAlt);
                executacmd.Parameters.AddWithValue("@Id_GrupoProduto", obj.IdGrupoProduto);

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

        public void AlterarSubGrupoProdutos(SubGrupoProduto obj)
        {

        }

        public void ExcluirSubGrupoProdutos(SubGrupoProduto obj)
        {
            try
            {
                string sql = @"delete from tb_subgrupo where Cod_SubGrupo = @id";

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

        public DataTable ListaSubGrupoProdutos()
        {
            try
            {
                DataTable tabelaSubGrupoProduto = new DataTable();

                string sql = "select Cod_SubGrupo, Nome_SubGrupo, tb_grupoproduto.Nome_GrupoProduto from tb_subgrupo inner join tb_grupoproduto on tb_grupoproduto.Cod_GrupoProduto = tb_subgrupo.Id_GrupoProduto";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelaSubGrupoProduto);

                conexao.Close();

                return tabelaSubGrupoProduto;

            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao executar o comando sql" + erro);
                return null;
            }
        }
    }
}
