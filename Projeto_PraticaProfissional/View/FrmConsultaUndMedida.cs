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
    public partial class FrmConsultaUndMedida : Projeto_PraticaProfissional.FrmConsulta
    {
        public FrmConsultaUndMedida()
        {
            InitializeComponent();
        }

        private void bt_Sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bt_Incluir_Click(object sender, EventArgs e)
        {
            FrmCadastroUndMedida frmCadUndMedida = new FrmCadastroUndMedida();
            frmCadUndMedida.ShowDialog();
        }

        private void FrmConsultaUndMedida_Load(object sender, EventArgs e)
        {
            UndMedidaDAO dao = new UndMedidaDAO();
            DgViewUndMedida.DataSource = dao.ListarUndMedida();
            DgViewUndMedida.Columns["Cod_UndMedida"].HeaderText = "Código";
            DgViewUndMedida.Columns["Nome_UndMedida"].HeaderText = "Unidade de Medida";
            DgViewUndMedida.Columns["Abreviacao"].HeaderText = "Abreviação";
        }

        private void bt_Excluir_Click(object sender, EventArgs e)
        {
            UnidadeDeMedida obj = new UnidadeDeMedida();

            obj.Id = Convert.ToInt32(DgViewUndMedida.Rows[DgViewUndMedida.CurrentCell.RowIndex].Cells["Cod_UndMedida"].Value);

            UndMedidaDAO dao = new UndMedidaDAO();
            if (MessageBox.Show("Tem certeza que deseja Excluir este Cadastro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dao.ExcluirUndMedida(obj);
                DgViewUndMedida.DataSource = dao.ListarUndMedida();
            }
        }
    }
}
