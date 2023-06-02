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
    public partial class FrmCadastroGrupoProduto : Projeto_PraticaProfissional.FrmCadastro
    {
        public FrmCadastroGrupoProduto()
        {
            InitializeComponent();
        }

        private void FrmCadastroGrupoProduto_Load(object sender, EventArgs e)
        {
            txtDataCad.Text = DateTime.Now.ToString();
            txtDataAlt.Text = DateTime.Now.ToString();
            txtDataCad.Enabled = false;
            txtDataAlt.Enabled = false;
        }

        private void bt_Salvar_Click(object sender, EventArgs e)
        {
            GrupoProduto obj = new GrupoProduto();
            obj.Descricao = txtdescricao.Text;
            obj.DataCad = DateTime.Parse(txtDataCad.Text);
            obj.DataAlt = DateTime.Parse(txtDataAlt.Text);

            GrupoProdutoDAO dao = new GrupoProdutoDAO();
            dao.CadastrarGrupoProdutos(obj);

            this.Close();
        }
    }
}
