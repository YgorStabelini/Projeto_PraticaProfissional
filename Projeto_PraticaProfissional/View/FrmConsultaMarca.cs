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
    public partial class FrmConsultaMarca : Projeto_PraticaProfissional.FrmConsulta
    {
        public FrmConsultaMarca()
        {
            InitializeComponent();
        }

        private void bt_Incluir_Click(object sender, EventArgs e)
        {
            FrmCadastroMarca frmCadMarca = new FrmCadastroMarca();
            frmCadMarca.ShowDialog();
        }

        private void FrmConsultaMarca_Load(object sender, EventArgs e)
        {
            MarcaDAO dao = new MarcaDAO();
            DgViewMarca.DataSource = dao.ListarMarca();
            DgViewMarca.Columns["Cod_Marca"].HeaderText = "Código";
            DgViewMarca.Columns["Nome_Marca"].HeaderText = "Marca";
        }

        private void bt_Excluir_Click(object sender, EventArgs e)
        {
            Marca obj = new Marca();

            obj.Id = Convert.ToInt32(DgViewMarca.Rows[DgViewMarca.CurrentCell.RowIndex].Cells["Cod_Marca"].Value);

            MarcaDAO dao = new MarcaDAO();
            if (MessageBox.Show("Tem certeza que deseja Excluir este Cadastro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dao.ExcluirMarca(obj);
                DgViewMarca.DataSource = dao.ListarMarca();
            }
        }
    }
}
