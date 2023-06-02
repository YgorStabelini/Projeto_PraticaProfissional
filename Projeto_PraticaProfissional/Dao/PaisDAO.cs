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
    public class PaisDAO
    {
        private MySqlConnection conexao;

        public PaisDAO()
        {
            this.conexao = new ConnectionFactory().getconnection();
        }

        public void cadastrarPais(Pais obj)
        {
            try
            {

                string sql = @"insert into tb_pais (Nome_Pais, Sigla, DataCad, DataAlt)
                                values (@nome, @Sigla, @DataCad, @DataAlt)";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", obj.Descricao);
                executacmd.Parameters.AddWithValue("@Sigla", obj.Sigla);
                executacmd.Parameters.AddWithValue("@DataCad", obj.DataCad);
                executacmd.Parameters.AddWithValue("@DataAlt", obj.DataAlt);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Cliente Cadastrado com sucesso");

                conexao.Close();

            }
            catch(Exception erro)
            {
                MessageBox.Show("Verificar Cadastro"+ erro);
            }
        }

        public void AlterarPais(Pais obj)
        {
            try
            {
                string sql = @"update tb_pais set (Nome_Pais=@nome, Sigla=@Sigla)
                             where Cod_Pais=@id";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", obj.Descricao);
                executacmd.Parameters.AddWithValue("@Sigla", obj.Sigla);

                executacmd.Parameters.AddWithValue("@id", obj.Id);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Pais Alterado com sucesso");

                conexao.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show("Verificar Cadastro" + erro);
            }
        }

        public void ExcluirPais(Pais obj)
        {
            try
            {
                string sql = @"delete from tb_Pais where Cod_Pais = @id";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                executacmd.Parameters.AddWithValue("@id", obj.Id);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Pais Excluido com sucesso");

                conexao.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show("Verificar Cadastro" + erro);
            }
        }

        public DataTable ListarPais() 
        {
            try
            {
                DataTable tabelaPais = new DataTable();

                string sql = "select Cod_Pais, Nome_Pais, Sigla from tb_Pais";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelaPais);

                conexao.Close();

                return tabelaPais;

            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao executar o comando sql" + erro);
                return null;
            }
        
        }

        public DataTable PesquisarNome(string Nome)
        {
            try
            {
                DataTable tabelaPais = new DataTable();

                string sql = "select Cod_Pais, Nome_Pais, Sigla from tb_Pais where Nome_Pais like @Nome";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@Nome", Nome);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelaPais);

                conexao.Close();

                return tabelaPais;

            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao executar o comando sql" + erro);
                return null;
            }

        }

        public DataTable PesquisarID(string id)
        {
            try
            {
                DataTable tabelaPais = new DataTable();

                string sql = "select Cod_Pais, Nome_Pais, Sigla from tb_Pais where Cod_Pais = @id";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@id", id);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelaPais);

                conexao.Close();

                return tabelaPais;

            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao executar o comando sql" + erro);
                return null;
            }

        }
    }
}
