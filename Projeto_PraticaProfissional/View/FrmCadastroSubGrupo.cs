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
    public partial class FrmCadastroSubGrupo : Projeto_PraticaProfissional.FrmCadastro
    {
        public FrmCadastroSubGrupo()
        {
            InitializeComponent();
        }

        private void FrmCadastroSubGrupo_Load(object sender, EventArgs e)
        {
            GrupoProdutoDAO GrupoDAO = new GrupoProdutoDAO();

            cb_GrupoProduto.DataSource = GrupoDAO.ListaGrupoProdutos();
            cb_GrupoProduto.DisplayMember = "Nome_GrupoProduto";
            cb_GrupoProduto.ValueMember = "Cod_GrupoProduto";


            txtDataCad.Text = DateTime.Now.ToString();
            txtDataAlt.Text = DateTime.Now.ToString();
            txtDataCad.Enabled = false;
            txtDataAlt.Enabled = false;
        }

        private void bt_Salvar_Click(object sender, EventArgs e)
        {
            SubGrupoProduto obj = new SubGrupoProduto();
            obj.Descricao = txtdescricao.Text;
            obj.IdGrupoProduto = int.Parse(cb_GrupoProduto.SelectedValue.ToString());
            obj.DataCad = DateTime.Parse(txtDataCad.Text);
            obj.DataAlt = DateTime.Parse(txtDataAlt.Text);

            SubGrupoProdutoDAO dao = new SubGrupoProdutoDAO();
            dao.CadastrarSubGrupoProdutos(obj);

            this.Close();
        }
    }
}
