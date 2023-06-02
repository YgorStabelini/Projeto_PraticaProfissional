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
    public partial class FrmConsultaSubGrupo : Projeto_PraticaProfissional.FrmConsulta
    {
        public FrmConsultaSubGrupo()
        {
            InitializeComponent();
        }

        private void bt_Incluir_Click(object sender, EventArgs e)
        {
            SubGrupoProdutoDAO dao = new SubGrupoProdutoDAO();

            FrmCadastroSubGrupo frmCadSubGrupo = new FrmCadastroSubGrupo();
            frmCadSubGrupo.ShowDialog();

            DgViewSubGrupo.DataSource = dao.ListaSubGrupoProdutos();
        }

        private void FrmConsultaSubGrupo_Load(object sender, EventArgs e)
        {
            SubGrupoProdutoDAO dao = new SubGrupoProdutoDAO();
            DgViewSubGrupo.DataSource = dao.ListaSubGrupoProdutos();
            DgViewSubGrupo.Columns["Cod_SubGrupo"].HeaderText = "Código";
            DgViewSubGrupo.Columns["Nome_SubGrupo"].HeaderText = "Nome";
            DgViewSubGrupo.Columns["Nome_GrupoProduto"].HeaderText = "Grupo Produto";
        }

        private void bt_Excluir_Click(object sender, EventArgs e)
        {
            SubGrupoProduto obj = new SubGrupoProduto();

            obj.Id = Convert.ToInt32(DgViewSubGrupo.Rows[DgViewSubGrupo.CurrentCell.RowIndex].Cells["Cod_SubGrupo"].Value);

            SubGrupoProdutoDAO dao = new SubGrupoProdutoDAO();
            if (MessageBox.Show("Tem certeza que deseja Excluir este Cadastro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dao.ExcluirSubGrupoProdutos(obj);
                DgViewSubGrupo.DataSource = dao.ListaSubGrupoProdutos();
            }
        }
    }
}
