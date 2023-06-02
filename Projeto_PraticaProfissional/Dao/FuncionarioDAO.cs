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
    public class FuncionarioDAO
    {
        private MySqlConnection conexao;

        public FuncionarioDAO()
        {
            this.conexao = new ConnectionFactory().getconnection();
        }

        public void CadastrarFuncionario(Funcionario obj)
        {
            try
            {
                string sql = @"insert into tb_Funcioario (Nome_Funcionario, rg, CPF_CNPJ, email, telefone, celular, cep, endereco, numero, complemento, bairro, Id_cidade, DataCad, DataAlt, DataAdm, DataDem, DataNasc, Sexo)
                                values (@nome, @rg, @cpf_cnpj, @email, @telefone, @celular, @cep, @endereco, @numero, @complemento, @bairro, @Id_cidade, @DataCad, @DataAlt, @DataAdm, @DataDem, @DataNasc, @Sexo)";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", obj.Nome);
                executacmd.Parameters.AddWithValue("@rg", obj.Rg);
                executacmd.Parameters.AddWithValue("@cpf_cnpj", obj.Cpf);
                executacmd.Parameters.AddWithValue("@email", obj.Email);
                executacmd.Parameters.AddWithValue("@telefone", obj.Telefone);
                executacmd.Parameters.AddWithValue("@celular", obj.Celular);
                executacmd.Parameters.AddWithValue("@cep", obj.Cep);
                executacmd.Parameters.AddWithValue("@endereco", obj.Endereco);
                executacmd.Parameters.AddWithValue("@numero", obj.numero);
                executacmd.Parameters.AddWithValue("@complemento", obj.Complemento);
                executacmd.Parameters.AddWithValue("@bairro", obj.Bairro);
                executacmd.Parameters.AddWithValue("@Id_cidade", obj.Id_Cidade);
                executacmd.Parameters.AddWithValue("@DataCad", obj.DataCad);
                executacmd.Parameters.AddWithValue("@DataAlt", obj.DataAlt);
                executacmd.Parameters.AddWithValue("@DataAdm", obj.DataAdmissao);
                executacmd.Parameters.AddWithValue("@DataDem", obj.DataDemissao);
                executacmd.Parameters.AddWithValue("@DataNasc", obj.DataNasc);
                executacmd.Parameters.AddWithValue("@Sexo", obj.Sexo);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Pais Cadastrado com sucesso");

                conexao.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show("Verificar Cadastro" + erro);
            }
        }

        public void AlterarFuncionario(Funcionario obj)
        {

        }

        public void ExcluirFuncionario(Funcionario obj)
        {
            try
            {
                string sql = @"delete from tb_Funcionario where Cod_Funcionario = @id";

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

        public DataTable ListaFuncionario()
        {
            {
                try
                {
                    DataTable tabelaFuncionario = new DataTable();

                    string sql = @"select * from tb_Funcionario";

                    MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                    conexao.Open();
                    executacmd.ExecuteNonQuery();

                    MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                    da.Fill(tabelaFuncionario);

                    conexao.Close();

                    return tabelaFuncionario;

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
