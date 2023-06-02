using Projeto_PraticaProfissional.Dao;
using Projeto_PraticaProfissional.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Projeto_PraticaProfissional.View
{
    public partial class FrmCadastroFuncionario : Projeto_PraticaProfissional.View.FrmCadastroPessoa
    {
        public FrmCadastroFuncionario()
        {
            InitializeComponent();
        }

        private void bt_Salvar_Click(object sender, EventArgs e)
        {
            Funcionario obj = new Funcionario();
            obj.Nome = txtNome.Text;
            obj.Rg = txtRG.Text;
            obj.Cpf = txtCPF.Text;
            obj.Email = txtEmail.Text;
            obj.Telefone = txtTelefone.Text;
            obj.Celular = txtCelular.Text;
            obj.Endereco = txtEndereco.Text;
            obj.numero = int.Parse(txtNumero.Text);
            obj.Complemento = txtComplemento.Text;
            obj.Bairro = txtBairro.Text;
            obj.Cep = txtCEP.Text;
            obj.Id_Cidade = int.Parse(cbCidade.SelectedValue.ToString());
            obj.DataCad = DateTime.Parse(txtDataCad.Text);
            obj.DataAlt = DateTime.Parse(txtDataAlt.Text);
            obj.DataAdmissao = DateTime.Parse(txt_DataAdmissao.Text);
            obj.DataDemissao = DateTime.Parse(txt_DataDemissao.Text);
            obj.DataNasc = DateTime.Parse(txtDataNasc.Text);
            obj.Sexo = Char.Parse(Cb_Sexo.Text);

            FuncionarioDAO dao = new FuncionarioDAO();
            dao.CadastrarFuncionario(obj);

            this.Close();
        }

        private void FrmCadastroFuncionario_Load(object sender, EventArgs e)
        {
            CidadeDAO cidadeDAO = new CidadeDAO();

            cbCidade.DataSource = cidadeDAO.ListarCidade();
            cbCidade.DisplayMember = "Nome_Cidade";
            cbCidade.ValueMember = "Cod_Cidade";

            txtDataCad.Text = DateTime.Now.ToString();
            txtDataAlt.Text = DateTime.Now.ToString();
            txtDataCad.Enabled = false;
            txtDataAlt.Enabled = false;
        }
    }
}
