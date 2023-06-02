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
    public partial class FrmConsultaGrupoProduto : Projeto_PraticaProfissional.FrmConsulta
    {
        public FrmConsultaGrupoProduto()
        {
            InitializeComponent();
        }

        private void FrmConsultaGrupoProduto_Load(object sender, EventArgs e)
        {
            GrupoProdutoDAO dao = new GrupoProdutoDAO();
            DgViewGrupoProduto.DataSource = dao.ListaGrupoProdutos();
            DgViewGrupoProduto.Columns["Cod_GrupoProduto"].HeaderText = "Código";
            DgViewGrupoProduto.Columns["Nome_GrupoProduto"].HeaderText = "Nome";
        }

        private void bt_Incluir_Click(object sender, EventArgs e)
        {
            GrupoProdutoDAO dao = new GrupoProdutoDAO();

            FrmCadastroGrupoProduto frmCadGrupo = new FrmCadastroGrupoProduto();
            frmCadGrupo.ShowDialog();

            DgViewGrupoProduto.DataSource = dao.ListaGrupoProdutos();
        }

        private void bt_Excluir_Click(object sender, EventArgs e)
        {
            GrupoProduto obj = new GrupoProduto();

            obj.Id = Convert.ToInt32(DgViewGrupoProduto.Rows[DgViewGrupoProduto.CurrentCell.RowIndex].Cells["Cod_GrupoProduto"].Value);

            GrupoProdutoDAO dao = new GrupoProdutoDAO();
            if (MessageBox.Show("Tem certeza que deseja Excluir este Cadastro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dao.ExcluirGrupoProdutos(obj);
                DgViewGrupoProduto.DataSource = dao.ListaGrupoProdutos();
            }
        }
    }
}
