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
    public class ProdutoDAO
    {
        private MySqlConnection conexao;

        public ProdutoDAO()
        {
            this.conexao = new ConnectionFactory().getconnection();
        }

        public void CadastrarProduto(Produto obj)
        {

        }

        public void AlterarProduto(Produto obj)
        {

        }

        public void ExcluirProduto(Produto obj)
        {
            try
            {
                string sql = @"delete from tb_Produto where Cod_Produto = @id";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                executacmd.Parameters.AddWithValue("@id", obj.Id);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Excluido com sucesso");

                conexao.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show("Verificar Cadastro" + erro);
            }
        }

        public DataTable ListaProduto()
        {
                try
                {
                    DataTable tabelaProduto = new DataTable();

                    string sql = @"select * from tb_Produto";

                    MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                    conexao.Open();
                    executacmd.ExecuteNonQuery();

                    MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                    da.Fill(tabelaProduto);

                    conexao.Close();

                    return tabelaProduto;

                }
                catch (Exception erro)
                {
                    MessageBox.Show("Erro ao executar o comando sql" + erro);
                    return null;
                }
        }
    }
}
