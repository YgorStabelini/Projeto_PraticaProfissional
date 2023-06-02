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
    public partial class FrmConsultaEstado : Projeto_PraticaProfissional.FrmConsulta
    {
        public FrmConsultaEstado()
        {
            InitializeComponent();
        }

        private void bt_Incluir_Click(object sender, EventArgs e)
        {
            EstadoDAO dao = new EstadoDAO();

            FrmCadastroEstado frmCadEstado = new FrmCadastroEstado();
            frmCadEstado.ShowDialog();

            DgViewEstado.DataSource = dao.ListarEstado();
        }

        private void bt_Sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmConsultaEstado_Load_1(object sender, EventArgs e)
        {
            EstadoDAO dao = new EstadoDAO();
            DgViewEstado.DataSource = dao.ListarEstado();
            DgViewEstado.Columns["Cod_Estado"].HeaderText = "Código";
            DgViewEstado.Columns["Nome_Estado"].HeaderText = "Nome";
            DgViewEstado.Columns["UF"].HeaderText = "UF";
            DgViewEstado.Columns["Nome_Pais"].HeaderText = "País";
        }

        private void bt_Excluir_Click(object sender, EventArgs e)
        {
            Estado obj = new Estado();

            obj.Id = Convert.ToInt32(DgViewEstado.Rows[DgViewEstado.CurrentCell.RowIndex].Cells["Cod_Estado"].Value);

            EstadoDAO dao = new EstadoDAO();
            if (MessageBox.Show("Tem certeza que deseja Excluir este Cadastro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dao.ExcluirEstado(obj);
                DgViewEstado.DataSource = dao.ListarEstado();
            }
        }
    }
}
