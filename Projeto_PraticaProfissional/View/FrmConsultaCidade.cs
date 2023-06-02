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
    public partial class FrmConsultaCidade : Projeto_PraticaProfissional.FrmConsulta
    {
        public FrmConsultaCidade()
        {
            InitializeComponent();
        }

        private void bt_Incluir_Click(object sender, EventArgs e)
        {
            CidadeDAO dao = new CidadeDAO();

            FrmCadastroCidade frmCadCidade = new FrmCadastroCidade();
            frmCadCidade.ShowDialog();

            DgViewCidade.DataSource = dao.ListarCidade();
        }

        private void FrmConsultaCidade_Load(object sender, EventArgs e)
        {
            CidadeDAO dao = new CidadeDAO();
            DgViewCidade.DataSource = dao.ListarCidade();
            DgViewCidade.Columns["Cod_Cidade"].HeaderText = "Código";
            DgViewCidade.Columns["Nome_Cidade"].HeaderText = "Nome";
            DgViewCidade.Columns["Nome_Estado"].HeaderText = "Estado";
            DgViewCidade.Columns["Nome_Pais"].HeaderText = "Páis";
        }

        private void bt_Excluir_Click(object sender, EventArgs e)
        {
            Cidade obj = new Cidade();

            obj.Id = Convert.ToInt32(DgViewCidade.Rows[DgViewCidade.CurrentCell.RowIndex].Cells["Cod_Cidade"].Value);

            CidadeDAO dao = new CidadeDAO();
            if (MessageBox.Show("Tem certeza que deseja Excluir este Cadastro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dao.ExcluirCidade(obj);
                DgViewCidade.DataSource = dao.ListarCidade();
            }
        }
    }
}
